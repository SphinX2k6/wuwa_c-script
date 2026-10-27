using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02005851 RID: 22609
	[NullableContext(1)]
	[Nullable(0)]
	public class InteractConfirmController : Singleton
	{
		// Token: 0x06039780 RID: 235392 RVA: 0x00DA4640 File Offset: 0x00DA2840
		public void RegisterActions()
		{
			this.SetupAction<CommonConfirmBoxAction>(EInteractionConfirmBoxType.Common, () => new CommonConfirmBoxAction());
			this.SetupAction<HonamiStoryConfirmBoxAction>(EInteractionConfirmBoxType.HonamiStoryCorruptedChest, () => new HonamiStoryConfirmBoxAction());
			this.SetupAction<HonamiStoryLeaveTipAction>(EInteractionConfirmBoxType.HonamiStoryEvacuateConfirm, () => new HonamiStoryLeaveTipAction());
		}

		// Token: 0x06039781 RID: 235393 RVA: 0x00DA46C0 File Offset: 0x00DA28C0
		private void SetupAction<[Nullable(0)] T>(EInteractionConfirmBoxType type, Func<T> ctor) where T : InteractConfirmActionBase
		{
			if (this.ActionMap.ContainsKey(type))
			{
				return;
			}
			T t = ctor();
			this.ActionMap[type] = t;
		}

		// Token: 0x06039782 RID: 235394 RVA: 0x00DA46F8 File Offset: 0x00DA28F8
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

		// Token: 0x06039783 RID: 235395 RVA: 0x00DA47E8 File Offset: 0x00DA29E8
		public void CancelAction(int handle)
		{
			if (this.ExecutingAction != null && this.ExecutingAction.GetValueOrDefault().Item1 == handle)
			{
				this.ExecutingAction.Value.Item2.Cancel();
				this.ExecutingAction = null;
			}
		}

		// Token: 0x06039784 RID: 235396 RVA: 0x00DA4838 File Offset: 0x00DA2A38
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

		// Token: 0x06039785 RID: 235397 RVA: 0x00DA4858 File Offset: 0x00DA2A58
		public void ReleaseAction(EInteractionConfirmBoxType type)
		{
			if (!this.ActionMap.ContainsKey(type))
			{
				return;
			}
			this.ActionMap.Remove(type);
		}

		// Token: 0x06039786 RID: 235398 RVA: 0x00DA4876 File Offset: 0x00DA2A76
		public bool CheckHandleValid(int handle)
		{
			return this.ExecutingAction != null && this.ExecutingAction.GetValueOrDefault().Item1 == handle;
		}

		// Token: 0x06039787 RID: 235399 RVA: 0x00DA4896 File Offset: 0x00DA2A96
		public void Clear()
		{
			if (this.ExecutingAction != null)
			{
				this.ExecutingAction.Value.Item2.Cancel();
			}
			this.ExecutingAction = null;
			this.ActionMap.Clear();
		}

		// Token: 0x17008A4B RID: 35403
		// (get) Token: 0x06039788 RID: 235400 RVA: 0x00DA48D1 File Offset: 0x00DA2AD1
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

		// Token: 0x06039789 RID: 235401 RVA: 0x00DA48F4 File Offset: 0x00DA2AF4
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603978A RID: 235402 RVA: 0x00DA48F6 File Offset: 0x00DA2AF6
		public static void ResetStaticDefaultValue()
		{
			InteractConfirmController instance = InteractConfirmController._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			InteractConfirmController._instance = null;
		}

		// Token: 0x0603978B RID: 235403 RVA: 0x00DA490F File Offset: 0x00DA2B0F
		static InteractConfirmController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InteractConfirmController.CreateStaticDefaultValue), new Action(InteractConfirmController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E0DA RID: 123098
		private readonly Dictionary<EInteractionConfirmBoxType, InteractConfirmActionBase> ActionMap = new Dictionary<EInteractionConfirmBoxType, InteractConfirmActionBase>();

		// Token: 0x0401E0DB RID: 123099
		private int HandleId = 1;

		// Token: 0x0401E0DC RID: 123100
		[Nullable(new byte[]
		{
			0,
			1
		})]
		private ValueTuple<int, InteractConfirmActionBase>? ExecutingAction;

		// Token: 0x0401E0DD RID: 123101
		[Nullable(2)]
		private static InteractConfirmController _instance;
	}
}
