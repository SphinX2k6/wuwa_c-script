using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02004829 RID: 18473
	[NullableContext(1)]
	[Nullable(0)]
	public class InteractConfirmController : Singleton
	{
		// Token: 0x0602E69C RID: 190108 RVA: 0x00CF3300 File Offset: 0x00CF1500
		public void RegisterActions()
		{
			this.SetupAction<CommonConfirmBoxAction>(EInteractionConfirmBoxType.Common, () => new CommonConfirmBoxAction());
			this.SetupAction<HonamiStoryConfirmBoxAction>(EInteractionConfirmBoxType.HonamiStoryCorruptedChest, () => new HonamiStoryConfirmBoxAction());
			this.SetupAction<HonamiStoryLeaveTipAction>(EInteractionConfirmBoxType.HonamiStoryEvacuateConfirm, () => new HonamiStoryLeaveTipAction());
		}

		// Token: 0x0602E69D RID: 190109 RVA: 0x00CF3380 File Offset: 0x00CF1580
		private void SetupAction<[Nullable(0)] T>(EInteractionConfirmBoxType type, Func<T> ctor) where T : InteractConfirmActionBase
		{
			if (this.ActionMap.ContainsKey(type))
			{
				return;
			}
			T t = ctor();
			this.ActionMap[type] = t;
		}

		// Token: 0x0602E69E RID: 190110 RVA: 0x00CF33B8 File Offset: 0x00CF15B8
		public int HandleAction(CommonInteractOption option, Action<int, bool, CommonInteractOption> confirmCallback)
		{
			if (option2 == null || option2.ConfirmBox == null)
			{
				return 0;
			}
			InteractConfirmActionBase action = this.GetAction(option2.ConfirmBox.Type.Type);
			if (action == null)
			{
				global::Log instance = global::Log.Instance;
				ELogModule module = ELogModule.Interaction;
				ELogAuthor author = ELogAuthor.FJH;
				string message = "[交互二次确认] 未注册的二次确认类型";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("二次确认类型", option2.ConfirmBox.Type);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return 0;
			}
			if (this.ExecutingAction != null)
			{
				this.ExecutingAction.Value.Item2.Cancel();
			}
			int handleId = this.HandleId;
			this.HandleId = handleId + 1;
			int num = handleId;
			InteractSecondConfirmContext interactSecondConfirmContext = InteractSecondConfirmContext.Create(num, option2);
			interactSecondConfirmContext.ConfirmCallback = delegate(int handle, bool confirmResult, CommonInteractOption option)
			{
				if (this.CheckHandleValid(handle))
				{
					confirmCallback(handle, confirmResult, option);
					this.ExecutingAction = null;
				}
			};
			if (!action.Execute(interactSecondConfirmContext))
			{
				return 0;
			}
			this.ExecutingAction = new ValueTuple<int, InteractConfirmActionBase>?(new ValueTuple<int, InteractConfirmActionBase>(num, action));
			return num;
		}

		// Token: 0x0602E69F RID: 190111 RVA: 0x00CF34A8 File Offset: 0x00CF16A8
		public void CancelAction(int handle)
		{
			if (this.ExecutingAction != null && this.ExecutingAction.GetValueOrDefault().Item1 == handle)
			{
				this.ExecutingAction.Value.Item2.Cancel();
				this.ExecutingAction = null;
			}
		}

		// Token: 0x0602E6A0 RID: 190112 RVA: 0x00CF34F8 File Offset: 0x00CF16F8
		[NullableContext(2)]
		public InteractConfirmActionBase GetAction(EInteractionConfirmBoxType type)
		{
			InteractConfirmActionBase result;
			if (this.ActionMap.TryGetValue(type, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x0602E6A1 RID: 190113 RVA: 0x00CF3518 File Offset: 0x00CF1718
		public void ReleaseAction(EInteractionConfirmBoxType type)
		{
			if (!this.ActionMap.ContainsKey(type))
			{
				return;
			}
			this.ActionMap.Remove(type);
		}

		// Token: 0x0602E6A2 RID: 190114 RVA: 0x00CF3536 File Offset: 0x00CF1736
		public bool CheckHandleValid(int handle)
		{
			return this.ExecutingAction != null && this.ExecutingAction.GetValueOrDefault().Item1 == handle;
		}

		// Token: 0x0602E6A3 RID: 190115 RVA: 0x00CF3556 File Offset: 0x00CF1756
		public void Clear()
		{
			if (this.ExecutingAction != null)
			{
				this.ExecutingAction.Value.Item2.Cancel();
			}
			this.ExecutingAction = null;
			this.ActionMap.Clear();
		}

		// Token: 0x17005E17 RID: 24087
		// (get) Token: 0x0602E6A4 RID: 190116 RVA: 0x00CF3591 File Offset: 0x00CF1791
		public static InteractConfirmController Instance
		{
			get
			{
				if (InteractConfirmController._instance == null)
				{
					InteractConfirmController._instance = new InteractConfirmController();
					InteractConfirmController._instance.OnInit();
				}
				return InteractConfirmController._instance;
			}
		}

		// Token: 0x0602E6A5 RID: 190117 RVA: 0x00CF35B4 File Offset: 0x00CF17B4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E6A6 RID: 190118 RVA: 0x00CF35B6 File Offset: 0x00CF17B6
		public static void ResetStaticDefaultValue()
		{
			InteractConfirmController instance = InteractConfirmController._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			InteractConfirmController._instance = null;
		}

		// Token: 0x0602E6A7 RID: 190119 RVA: 0x00CF35CF File Offset: 0x00CF17CF
		static InteractConfirmController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InteractConfirmController.CreateStaticDefaultValue), new Action(InteractConfirmController.ResetStaticDefaultValue));
		}

		// Token: 0x04018B77 RID: 101239
		private readonly Dictionary<EInteractionConfirmBoxType, InteractConfirmActionBase> ActionMap = new Dictionary<EInteractionConfirmBoxType, InteractConfirmActionBase>();

		// Token: 0x04018B78 RID: 101240
		private int HandleId = 1;

		// Token: 0x04018B79 RID: 101241
		[Nullable(new byte[]
		{
			0,
			1
		})]
		private ValueTuple<int, InteractConfirmActionBase>? ExecutingAction;

		// Token: 0x04018B7A RID: 101242
		[Nullable(2)]
		private static InteractConfirmController _instance;
	}
}
