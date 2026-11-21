using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot.Sequence.Qte
{
	// Token: 0x02003FE9 RID: 16361
	[NullableContext(1)]
	[Nullable(0)]
	public class QteSpineInfoProxy
	{
		// Token: 0x0602967B RID: 169595 RVA: 0x00BA8AE0 File Offset: 0x00BA6CE0
		private static List<SpineDataProxy> CreateSpineDataList([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FSpineData> config)
		{
			List<SpineDataProxy> list = new List<SpineDataProxy>();
			if (config == null)
			{
				return list;
			}
			for (int i = 0; i < config.Num(); i++)
			{
				FSpineData fspineData = config.Get(i);
				list.Add(new SpineDataProxy
				{
					Name = fspineData.Name,
					NeedLoop = new bool?(fspineData.NeedLoop)
				});
			}
			return list;
		}

		// Token: 0x0602967C RID: 169596 RVA: 0x00BA8B3C File Offset: 0x00BA6D3C
		private static List<QteProgressSpineSegmentProxy> CreateProgressSpineSegmentList([Nullable(new byte[]
		{
			2,
			1
		})] TArray<FQteProgressSpineSegment> config)
		{
			List<QteProgressSpineSegmentProxy> list = new List<QteProgressSpineSegmentProxy>();
			if (config == null)
			{
				return list;
			}
			for (int i = 0; i < config.Num(); i++)
			{
				FQteProgressSpineSegment fqteProgressSpineSegment = config.Get(i);
				QteProgressSpineSegmentProxy qteProgressSpineSegmentProxy = new QteProgressSpineSegmentProxy();
				qteProgressSpineSegmentProxy.Spines = QteSpineInfoProxy.CreateSpineDataList(fqteProgressSpineSegment.Spines);
				if (qteProgressSpineSegmentProxy.Spines.Count != 0)
				{
					qteProgressSpineSegmentProxy.QteStartProgress = MathUtils.Instance.Clamp(fqteProgressSpineSegment.QteStartPercent * 0.01f, 0f, 1f);
					qteProgressSpineSegmentProxy.QteEndProgress = MathUtils.Instance.Clamp(fqteProgressSpineSegment.QteEndPercent * 0.01f, 0f, 1f);
					qteProgressSpineSegmentProxy.SpineStartProgress = MathUtils.Instance.Clamp(fqteProgressSpineSegment.SpineStartPercent * 0.01f, 0f, 1f);
					qteProgressSpineSegmentProxy.SpineEndProgress = MathUtils.Instance.Clamp(fqteProgressSpineSegment.SpineEndPercent * 0.01f, 0f, 1f);
					qteProgressSpineSegmentProxy.BlendInTime = Math.Max(fqteProgressSpineSegment.BlendInTime, 0f);
					qteProgressSpineSegmentProxy.BlendOutTime = Math.Max(fqteProgressSpineSegment.BlendOutTime, 0f);
					list.Add(qteProgressSpineSegmentProxy);
				}
			}
			return list;
		}

		// Token: 0x0602967D RID: 169597 RVA: 0x00BA8C68 File Offset: 0x00BA6E68
		[NullableContext(2)]
		public unsafe static QteSpineInfoProxy CreateQteSpineInfo(FQteSpineInfo config)
		{
			if (config == null)
			{
				return null;
			}
			bool flag = false;
			QteSpineInfoProxy qteSpineInfoProxy = new QteSpineInfoProxy();
			qteSpineInfoProxy.StartLoopSpines = QteSpineInfoProxy.CreateSpineDataList(config.StartLoopSpines);
			if (qteSpineInfoProxy.StartLoopSpines.Count > 0)
			{
				flag = true;
			}
			qteSpineInfoProxy.ProgressSpine = QteSpineInfoProxy.CreateSpineDataList(config.ProgressSpine);
			if (qteSpineInfoProxy.ProgressSpine.Count > 0)
			{
				flag = true;
			}
			qteSpineInfoProxy.ProgressSpineSegments = QteSpineInfoProxy.CreateProgressSpineSegmentList(config.ProgressSpineSegments);
			if (qteSpineInfoProxy.ProgressSpineSegments.Count > 0)
			{
				flag = true;
			}
			else if (qteSpineInfoProxy.ProgressSpine.Count > 0)
			{
				QteSpineInfoProxy qteSpineInfoProxy2 = qteSpineInfoProxy;
				int num = 1;
				List<QteProgressSpineSegmentProxy> list = new List<QteProgressSpineSegmentProxy>(num);
				CollectionsMarshal.SetCount<QteProgressSpineSegmentProxy>(list, num);
				Span<QteProgressSpineSegmentProxy> span = CollectionsMarshal.AsSpan<QteProgressSpineSegmentProxy>(list);
				int index = 0;
				*span[index] = QteProgressSpineSegmentProxy.CreateLegacyProgressSegment(qteSpineInfoProxy.ProgressSpine);
				qteSpineInfoProxy2.ProgressSpineSegments = list;
			}
			qteSpineInfoProxy.EndSpine = QteSpineInfoProxy.CreateSpineDataList(config.EndSpine);
			if (qteSpineInfoProxy.EndSpine.Count > 0)
			{
				flag = true;
			}
			qteSpineInfoProxy.SuccessSpine = QteSpineInfoProxy.CreateSpineDataList(config.SuccessSpine);
			if (qteSpineInfoProxy.SuccessSpine.Count > 0)
			{
				flag = true;
			}
			qteSpineInfoProxy.FailSpine = QteSpineInfoProxy.CreateSpineDataList(config.FailSpine);
			if (qteSpineInfoProxy.FailSpine.Count > 0)
			{
				flag = true;
			}
			qteSpineInfoProxy.WaitEndSpineFinish = config.WaitEndSpineFinish;
			qteSpineInfoProxy.NiagaraParamNames = new List<string>();
			for (int i = 0; i < config.NiagaraParamNames.Num(); i++)
			{
				string item = config.NiagaraParamNames.Get(i);
				qteSpineInfoProxy.NiagaraParamNames.Add(item);
				flag = true;
			}
			if (flag)
			{
				return qteSpineInfoProxy;
			}
			return null;
		}

		// Token: 0x0602967E RID: 169598 RVA: 0x00BA8DE8 File Offset: 0x00BA6FE8
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SpineDataProxy> GetProgressSpines()
		{
			List<SpineDataProxy> list = new List<SpineDataProxy>();
			if (this.ProgressSpine != null)
			{
				list.AddRange(this.ProgressSpine);
			}
			if (this.ProgressSpineSegments != null)
			{
				foreach (QteProgressSpineSegmentProxy qteProgressSpineSegmentProxy in this.ProgressSpineSegments)
				{
					list.AddRange(qteProgressSpineSegmentProxy.Spines);
				}
			}
			if (list.Count <= 0)
			{
				return null;
			}
			return list;
		}

		// Token: 0x0602967F RID: 169599 RVA: 0x00BA8E70 File Offset: 0x00BA7070
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SpineDataProxy> GetSuccessResultSpine()
		{
			if (this.SuccessSpine != null && this.SuccessSpine.Count > 0)
			{
				return this.SuccessSpine;
			}
			if (this.EndSpine != null && this.EndSpine.Count > 0)
			{
				return this.EndSpine;
			}
			return null;
		}

		// Token: 0x06029680 RID: 169600 RVA: 0x00BA8EAD File Offset: 0x00BA70AD
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SpineDataProxy> GetFailResultSpine()
		{
			if (this.FailSpine != null && this.FailSpine.Count > 0)
			{
				return this.FailSpine;
			}
			if (this.EndSpine != null && this.EndSpine.Count > 0)
			{
				return this.EndSpine;
			}
			return null;
		}

		// Token: 0x04016980 RID: 92544
		private const float PERCENT = 0.01f;

		// Token: 0x04016981 RID: 92545
		private const float BLEND_OUT_TIME = 0.5f;

		// Token: 0x04016982 RID: 92546
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SpineDataProxy> EndSpine;

		// Token: 0x04016983 RID: 92547
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SpineDataProxy> FailSpine;

		// Token: 0x04016984 RID: 92548
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SpineDataProxy> ProgressSpine;

		// Token: 0x04016985 RID: 92549
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<QteProgressSpineSegmentProxy> ProgressSpineSegments;

		// Token: 0x04016986 RID: 92550
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SpineDataProxy> StartLoopSpines;

		// Token: 0x04016987 RID: 92551
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<SpineDataProxy> SuccessSpine;

		// Token: 0x04016988 RID: 92552
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> NiagaraParamNames;

		// Token: 0x04016989 RID: 92553
		public bool WaitEndSpineFinish;
	}
}
