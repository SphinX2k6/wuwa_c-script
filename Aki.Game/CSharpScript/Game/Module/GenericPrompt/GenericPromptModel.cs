using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.GenericPrompt
{
	// Token: 0x02004970 RID: 18800
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class GenericPromptModel : ModelBase
	{
		// Token: 0x0602F25C RID: 193116 RVA: 0x00D2431F File Offset: 0x00D2251F
		protected override bool OnInit()
		{
			EventSystem.Instance.Add(EEventName.OnFinishLoadingState, new Action(this.OnLoadingDone));
			return true;
		}

		// Token: 0x0602F25D RID: 193117 RVA: 0x00D2433E File Offset: 0x00D2253E
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove(EEventName.OnFinishLoadingState, new Action(this.OnLoadingDone));
			this.WaitQueue.Clear();
			return true;
		}

		// Token: 0x0602F25E RID: 193118 RVA: 0x00D24368 File Offset: 0x00D22568
		private void OnLoadingDone()
		{
			int i = 0;
			int size = this.WaitQueue.Size;
			while (i < size)
			{
				this.ApplyPromptParamHub(this.WaitQueue.Pop());
				i++;
			}
			if (!this.WaitQueue.Empty)
			{
				Log.Instance.Error(ELogModule.GenericPrompt, ELogAuthor.XXJ, "播放队列飘字异常,存在从队列中取出又被放回队列的情况", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}

		// Token: 0x0602F25F RID: 193119 RVA: 0x00D243C7 File Offset: 0x00D225C7
		private bool NeedAddToWaitQueue()
		{
			return LoadingModel.Instance.IsLoading || LoginModel.Instance.HasLoginPromise();
		}

		// Token: 0x0602F260 RID: 193120 RVA: 0x00D243E1 File Offset: 0x00D225E1
		public void ApplyPromptParamHub(IPromptParamHub promptParamHub)
		{
			if (this.NeedAddToWaitQueue())
			{
				this.WaitQueue.Push(promptParamHub);
				return;
			}
			EventSystem.Instance.Emit<IPromptParamHub>(EEventName.InsertFloatTips, promptParamHub);
		}

		// Token: 0x0602F261 RID: 193121 RVA: 0x00D2440C File Offset: 0x00D2260C
		public void RemovePromptParamHubByKey(string promptKey)
		{
			int size = this.WaitQueue.Size;
			for (int i = 0; i < size; i++)
			{
				IPromptParamHub promptParamHub = this.WaitQueue.Get(i);
				if (promptParamHub != null && promptParamHub.PromptKey != null && promptParamHub.PromptKey == promptKey)
				{
					List<IPromptParamHub> list = new List<IPromptParamHub>();
					for (int j = 0; j < size; j++)
					{
						if (j != i)
						{
							list.Add(this.WaitQueue.Get(j));
						}
					}
					this.WaitQueue.Clear();
					foreach (IPromptParamHub element in list)
					{
						this.WaitQueue.Push(element);
					}
					return;
				}
			}
			EventSystem.Instance.Emit<string>(EEventName.RemoveFloatTips, promptKey);
		}

		// Token: 0x17005F57 RID: 24407
		// (get) Token: 0x0602F262 RID: 193122 RVA: 0x00D244F8 File Offset: 0x00D226F8
		public static GenericPromptModel Instance
		{
			get
			{
				return GenericPromptModel._Instance;
			}
		}

		// Token: 0x0602F263 RID: 193123 RVA: 0x00D244FF File Offset: 0x00D226FF
		public static GenericPromptModel GetOrCreateInstance()
		{
			if (GenericPromptModel._Instance == null)
			{
				GenericPromptModel.CreateInstance();
			}
			return GenericPromptModel._Instance;
		}

		// Token: 0x0602F264 RID: 193124 RVA: 0x00D24513 File Offset: 0x00D22713
		public static bool CreateInstance()
		{
			if (GenericPromptModel._Instance != null)
			{
				return true;
			}
			GenericPromptModel._Instance = new GenericPromptModel();
			return true;
		}

		// Token: 0x0602F265 RID: 193125 RVA: 0x00D24529 File Offset: 0x00D22729
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602F266 RID: 193126 RVA: 0x00D2452B File Offset: 0x00D2272B
		public static void ResetStaticDefaultValue()
		{
			GenericPromptModel._Instance = null;
		}

		// Token: 0x0602F267 RID: 193127 RVA: 0x00D24533 File Offset: 0x00D22733
		static GenericPromptModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GenericPromptModel.CreateStaticDefaultValue), new Action(GenericPromptModel.ResetStaticDefaultValue));
		}

		// Token: 0x04019077 RID: 102519
		private readonly Queue<IPromptParamHub> WaitQueue = new Queue<IPromptParamHub>(4);

		// Token: 0x04019078 RID: 102520
		[Nullable(2)]
		private static GenericPromptModel _Instance;
	}
}
