using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.Module.GenericPrompt
{
	// Token: 0x02005997 RID: 22935
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class GenericPromptModel : ModelBase
	{
		// Token: 0x0603A336 RID: 238390 RVA: 0x00DD4E8F File Offset: 0x00DD308F
		protected override bool OnInit()
		{
			EventSystem.Instance.Add(EEventName.OnFinishLoadingState, new Action(this.OnLoadingDone));
			return true;
		}

		// Token: 0x0603A337 RID: 238391 RVA: 0x00DD4EAE File Offset: 0x00DD30AE
		protected override bool OnClear()
		{
			EventSystem.Instance.Remove(EEventName.OnFinishLoadingState, new Action(this.OnLoadingDone));
			this.WaitQueue.Clear();
			return true;
		}

		// Token: 0x0603A338 RID: 238392 RVA: 0x00DD4ED8 File Offset: 0x00DD30D8
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

		// Token: 0x0603A339 RID: 238393 RVA: 0x00DD4F37 File Offset: 0x00DD3137
		private bool NeedAddToWaitQueue()
		{
			return LoadingModel.Instance.IsLoading || LoginModel.Instance.HasLoginPromise();
		}

		// Token: 0x0603A33A RID: 238394 RVA: 0x00DD4F51 File Offset: 0x00DD3151
		public void ApplyPromptParamHub(IPromptParamHub promptParamHub)
		{
			if (this.NeedAddToWaitQueue())
			{
				this.WaitQueue.Push(promptParamHub);
				return;
			}
			EventSystem.Instance.Emit<IPromptParamHub>(EEventName.InsertFloatTips, promptParamHub);
		}

		// Token: 0x0603A33B RID: 238395 RVA: 0x00DD4F7C File Offset: 0x00DD317C
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

		// Token: 0x17008B8A RID: 35722
		// (get) Token: 0x0603A33C RID: 238396 RVA: 0x00DD5068 File Offset: 0x00DD3268
		public static GenericPromptModel Instance
		{
			get
			{
				return GenericPromptModel._Instance;
			}
		}

		// Token: 0x0603A33D RID: 238397 RVA: 0x00DD506F File Offset: 0x00DD326F
		public static GenericPromptModel GetOrCreateInstance()
		{
			if (GenericPromptModel._Instance == null)
			{
				GenericPromptModel.CreateInstance();
			}
			return GenericPromptModel._Instance;
		}

		// Token: 0x0603A33E RID: 238398 RVA: 0x00DD5083 File Offset: 0x00DD3283
		public static bool CreateInstance()
		{
			if (GenericPromptModel._Instance != null)
			{
				return true;
			}
			GenericPromptModel._Instance = new GenericPromptModel();
			return true;
		}

		// Token: 0x0603A33F RID: 238399 RVA: 0x00DD5099 File Offset: 0x00DD3299
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603A340 RID: 238400 RVA: 0x00DD509B File Offset: 0x00DD329B
		public static void ResetStaticDefaultValue()
		{
			GenericPromptModel._Instance = null;
		}

		// Token: 0x0603A341 RID: 238401 RVA: 0x00DD50A3 File Offset: 0x00DD32A3
		static GenericPromptModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GenericPromptModel.CreateStaticDefaultValue), new Action(GenericPromptModel.ResetStaticDefaultValue));
		}

		// Token: 0x0401E5D9 RID: 124377
		private readonly Queue<IPromptParamHub> WaitQueue = new Queue<IPromptParamHub>(4);

		// Token: 0x0401E5DA RID: 124378
		[Nullable(2)]
		private static GenericPromptModel _Instance;
	}
}
