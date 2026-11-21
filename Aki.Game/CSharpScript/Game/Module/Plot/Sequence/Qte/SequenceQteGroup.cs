using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.Qte
{
	// Token: 0x02003FE8 RID: 16360
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SequenceQteGroup : SequenceQteHandleBase<CommonQteGroupContext>
	{
		// Token: 0x06029673 RID: 169587 RVA: 0x00BA87CC File Offset: 0x00BA69CC
		public SequenceQteGroup(SequenceQteManager qteManager, CommonQteGroupContext context) : base(qteManager, context)
		{
			if (this.Context.ContextMap != null)
			{
				foreach (KeyValuePair<int, CommonQteContextBase> keyValuePair in this.Context.ContextMap)
				{
					CommonQteContextBase value = keyValuePair.Value;
					value.SuccessCallback = new TCommonQteCallback(this.OnSubQteSucceed);
					value.FailCallback = new TCommonQteCallback(this.OnSubQteFailed);
				}
			}
		}

		// Token: 0x06029674 RID: 169588 RVA: 0x00BA887C File Offset: 0x00BA6A7C
		public override void OnBegin()
		{
			base.OnBegin();
			this.MarkSequenceQtePending = true;
		}

		// Token: 0x06029675 RID: 169589 RVA: 0x00BA888B File Offset: 0x00BA6A8B
		public override void OnFinish()
		{
			base.OnFinish();
			this.CacheIntervalCheckProgressMap.Clear();
		}

		// Token: 0x06029676 RID: 169590 RVA: 0x00BA88A0 File Offset: 0x00BA6AA0
		protected override void OnReceiveTick(float delta)
		{
			if (this.Context.ContextMap == null || this.Context.MainQteContext == null || this.Context.ContextMap.Count == 0)
			{
				return;
			}
			this.PauseTimeCheck += (int)delta;
			bool flag = this.PauseTimeCheck >= 50;
			if (flag)
			{
				this.PauseTimeCheck = 0;
			}
			double num = 0.0;
			foreach (KeyValuePair<int, CommonQteContextBase> keyValuePair in this.Context.ContextMap)
			{
				CommonQteContextBase value = keyValuePair.Value;
				if (value.Type.GetValueOrDefault() == ECommonQteContextType.SingleButtonContinuousClick)
				{
					if (flag)
					{
						this.CacheIntervalCheckProgressMap[value.HandleId] = (double)value.GetProgress();
						num += (double)value.GetProgress();
					}
					else
					{
						double num2;
						num += (this.CacheIntervalCheckProgressMap.TryGetValue(value.HandleId, out num2) ? num2 : 0.0);
					}
				}
				else if (value.Type.GetValueOrDefault() == ECommonQteContextType.SingleButtonLongPress)
				{
					num += (double)value.GetProgress();
				}
				else
				{
					num += (double)(value.IsSuccess() ? 100 : 0);
				}
			}
			this.Progress = (float)MathUtils.Instance.Clamp(num / (double)this.Context.ContextMap.Count * 0.009999999776482582, 0.0, 1.0);
		}

		// Token: 0x06029677 RID: 169591 RVA: 0x00BA8A30 File Offset: 0x00BA6C30
		public void SetSubQteParams([Nullable(new byte[]
		{
			2,
			1
		})] List<MovieSceneSubQteParamsProxy> parameters)
		{
			if (parameters == null)
			{
				return;
			}
			foreach (MovieSceneSubQteParamsProxy movieSceneSubQteParamsProxy in parameters)
			{
				this.SubQteParamsMap[movieSceneSubQteParamsProxy.SubQteId] = movieSceneSubQteParamsProxy;
			}
		}

		// Token: 0x06029678 RID: 169592 RVA: 0x00BA8A90 File Offset: 0x00BA6C90
		[NullableContext(2)]
		private void OnSubQteSucceed(CommonQteContextBase context)
		{
			this.PlaySubResultSpine(context, true);
		}

		// Token: 0x06029679 RID: 169593 RVA: 0x00BA8A9A File Offset: 0x00BA6C9A
		[NullableContext(2)]
		private void OnSubQteFailed(CommonQteContextBase context)
		{
			this.PlaySubResultSpine(context, false);
		}

		// Token: 0x0602967A RID: 169594 RVA: 0x00BA8AA4 File Offset: 0x00BA6CA4
		[NullableContext(2)]
		private void PlaySubResultSpine(CommonQteContextBase context, bool isSuccess)
		{
			if (context == null)
			{
				return;
			}
			MovieSceneSubQteParamsProxy movieSceneSubQteParamsProxy;
			if (!this.SubQteParamsMap.TryGetValue(context.QteId, out movieSceneSubQteParamsProxy))
			{
				return;
			}
			QteSpineInfoProxy spineInfo = movieSceneSubQteParamsProxy.SpineInfo;
			if (spineInfo == null)
			{
				return;
			}
			base.PlayResultSpine(isSuccess, spineInfo);
		}

		// Token: 0x0401697C RID: 92540
		private const int PAUSED_TIME_BUFFER = 50;

		// Token: 0x0401697D RID: 92541
		private readonly Dictionary<int, MovieSceneSubQteParamsProxy> SubQteParamsMap = new Dictionary<int, MovieSceneSubQteParamsProxy>();

		// Token: 0x0401697E RID: 92542
		private int PauseTimeCheck = 50;

		// Token: 0x0401697F RID: 92543
		private readonly Dictionary<int, double> CacheIntervalCheckProgressMap = new Dictionary<int, double>();
	}
}
