using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006253 RID: 25171
	public class TGroupFinishConfigUnion
	{
		// Token: 0x1700BB4E RID: 47950
		// (get) Token: 0x0602AD6F RID: 175471 RVA: 0x005D96AC File Offset: 0x005D78AC
		// (set) Token: 0x0602AD70 RID: 175472 RVA: 0x005D96B4 File Offset: 0x005D78B4
		public TGroupFinishConfig Type { get; set; }

		// Token: 0x1700BB4F RID: 47951
		// (get) Token: 0x0602AD71 RID: 175473 RVA: 0x005D96BD File Offset: 0x005D78BD
		// (set) Token: 0x0602AD72 RID: 175474 RVA: 0x005D96C5 File Offset: 0x005D78C5
		public object Value { get; set; }

		// Token: 0x0602AD73 RID: 175475 RVA: 0x005D96CE File Offset: 0x005D78CE
		public TGroupFinishConfigUnion()
		{
			this.Type = TGroupFinishConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0602AD74 RID: 175476 RVA: 0x005D96E4 File Offset: 0x005D78E4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AD75 RID: 175477 RVA: 0x005D96F6 File Offset: 0x005D78F6
		public IGroupFinishDestroyT AsIGroupFinishDestroy()
		{
			return this.As<IGroupFinishDestroyT>();
		}

		// Token: 0x0602AD76 RID: 175478 RVA: 0x005D96FE File Offset: 0x005D78FE
		public static TGroupFinishConfigUnion FromIGroupFinishDestroy(IGroupFinishDestroyT _igroupfinishdestroy)
		{
			return new TGroupFinishConfigUnion
			{
				Type = TGroupFinishConfig.IGroupFinishDestroy,
				Value = _igroupfinishdestroy
			};
		}

		// Token: 0x0602AD77 RID: 175479 RVA: 0x005D9713 File Offset: 0x005D7913
		public IGroupFinishSilenceT AsIGroupFinishSilence()
		{
			return this.As<IGroupFinishSilenceT>();
		}

		// Token: 0x0602AD78 RID: 175480 RVA: 0x005D971B File Offset: 0x005D791B
		public static TGroupFinishConfigUnion FromIGroupFinishSilence(IGroupFinishSilenceT _igroupfinishsilence)
		{
			return new TGroupFinishConfigUnion
			{
				Type = TGroupFinishConfig.IGroupFinishSilence,
				Value = _igroupfinishsilence
			};
		}

		// Token: 0x0602AD79 RID: 175481 RVA: 0x005D9730 File Offset: 0x005D7930
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
