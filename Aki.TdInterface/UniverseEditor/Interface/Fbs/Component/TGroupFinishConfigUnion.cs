using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C2E RID: 23598
	public class TGroupFinishConfigUnion
	{
		// Token: 0x1700B1FC RID: 45564
		// (get) Token: 0x06028761 RID: 165729 RVA: 0x00591494 File Offset: 0x0058F694
		// (set) Token: 0x06028762 RID: 165730 RVA: 0x0059149C File Offset: 0x0058F69C
		public TGroupFinishConfig Type { get; set; }

		// Token: 0x1700B1FD RID: 45565
		// (get) Token: 0x06028763 RID: 165731 RVA: 0x005914A5 File Offset: 0x0058F6A5
		// (set) Token: 0x06028764 RID: 165732 RVA: 0x005914AD File Offset: 0x0058F6AD
		public object Value { get; set; }

		// Token: 0x06028765 RID: 165733 RVA: 0x005914B6 File Offset: 0x0058F6B6
		public TGroupFinishConfigUnion()
		{
			this.Type = TGroupFinishConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06028766 RID: 165734 RVA: 0x005914CC File Offset: 0x0058F6CC
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028767 RID: 165735 RVA: 0x005914DE File Offset: 0x0058F6DE
		public IGroupFinishDestroyT AsIGroupFinishDestroy()
		{
			return this.As<IGroupFinishDestroyT>();
		}

		// Token: 0x06028768 RID: 165736 RVA: 0x005914E6 File Offset: 0x0058F6E6
		public static TGroupFinishConfigUnion FromIGroupFinishDestroy(IGroupFinishDestroyT _igroupfinishdestroy)
		{
			return new TGroupFinishConfigUnion
			{
				Type = TGroupFinishConfig.IGroupFinishDestroy,
				Value = _igroupfinishdestroy
			};
		}

		// Token: 0x06028769 RID: 165737 RVA: 0x005914FB File Offset: 0x0058F6FB
		public IGroupFinishSilenceT AsIGroupFinishSilence()
		{
			return this.As<IGroupFinishSilenceT>();
		}

		// Token: 0x0602876A RID: 165738 RVA: 0x00591503 File Offset: 0x0058F703
		public static TGroupFinishConfigUnion FromIGroupFinishSilence(IGroupFinishSilenceT _igroupfinishsilence)
		{
			return new TGroupFinishConfigUnion
			{
				Type = TGroupFinishConfig.IGroupFinishSilence,
				Value = _igroupfinishsilence
			};
		}

		// Token: 0x0602876B RID: 165739 RVA: 0x00591518 File Offset: 0x0058F718
		public static int Pack(FlatBufferBuilder builder, TGroupFinishConfigUnion _o)
		{
			TGroupFinishConfig type = _o.Type;
			if (type == TGroupFinishConfig.IGroupFinishDestroy)
			{
				return IGroupFinishDestroy.Pack(builder, _o.AsIGroupFinishDestroy()).Value;
			}
			if (type != TGroupFinishConfig.IGroupFinishSilence)
			{
				return 0;
			}
			return IGroupFinishSilence.Pack(builder, _o.AsIGroupFinishSilence()).Value;
		}
	}
}
