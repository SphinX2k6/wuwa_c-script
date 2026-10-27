using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot.Sequence.Qte
{
	// Token: 0x0200501E RID: 20510
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class SequenceQteGroup : SequenceQteHandleBase<CommonQteGroupContext>
	{
		// Token: 0x060347D0 RID: 214992 RVA: 0x00C5D280 File Offset: 0x00C5B480
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

		// Token: 0x060347D1 RID: 214993 RVA: 0x00C5D330 File Offset: 0x00C5B530
		public override void OnBegin()
		{
			base.OnBegin();
			this.MarkSequenceQtePending = true;
		}

		// Token: 0x060347D2 RID: 214994 RVA: 0x00C5D33F File Offset: 0x00C5B53F
		public override void OnFinish()
		{
			base.OnFinish();
			this.CacheIntervalCheckProgressMap.Clear();
		}

		// Token: 0x060347D3 RID: 214995 RVA: 0x00C5D354 File Offset: 0x00C5B554
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

		// Token: 0x060347D4 RID: 214996 RVA: 0x00C5D4E4 File Offset: 0x00C5B6E4
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

		// Token: 0x060347D5 RID: 214997 RVA: 0x00C5D544 File Offset: 0x00C5B744
		[NullableContext(2)]
		private void OnSubQteSucceed(CommonQteContextBase context)
		{
			this.PlaySubResultSpine(context, true);
		}

		// Token: 0x060347D6 RID: 214998 RVA: 0x00C5D54E File Offset: 0x00C5B74E
		[NullableContext(2)]
		private void OnSubQteFailed(CommonQteContextBase context)
		{
			this.PlaySubResultSpine(context, false);
		}

		// Token: 0x060347D7 RID: 214999 RVA: 0x00C5D558 File Offset: 0x00C5B758
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

		// Token: 0x0401BF91 RID: 114577
		private const int PAUSED_TIME_BUFFER = 50;

		// Token: 0x0401BF92 RID: 114578
		private readonly Dictionary<int, MovieSceneSubQteParamsProxy> SubQteParamsMap = new Dictionary<int, MovieSceneSubQteParamsProxy>();

		// Token: 0x0401BF93 RID: 114579
		private int PauseTimeCheck = 50;

		// Token: 0x0401BF94 RID: 114580
		private readonly Dictionary<int, double> CacheIntervalCheckProgressMap = new Dictionary<int, double>();
	}
}
