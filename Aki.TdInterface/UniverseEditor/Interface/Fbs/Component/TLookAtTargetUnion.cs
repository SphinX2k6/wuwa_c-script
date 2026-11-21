using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200627D RID: 25213
	public class TLookAtTargetUnion
	{
		// Token: 0x1700BB6A RID: 47978
		// (get) Token: 0x0602AE5F RID: 175711 RVA: 0x005DAE12 File Offset: 0x005D9012
		// (set) Token: 0x0602AE60 RID: 175712 RVA: 0x005DAE1A File Offset: 0x005D901A
		public TLookAtTarget Type { get; set; }

		// Token: 0x1700BB6B RID: 47979
		// (get) Token: 0x0602AE61 RID: 175713 RVA: 0x005DAE23 File Offset: 0x005D9023
		// (set) Token: 0x0602AE62 RID: 175714 RVA: 0x005DAE2B File Offset: 0x005D902B
		public object Value { get; set; }

		// Token: 0x0602AE63 RID: 175715 RVA: 0x005DAE34 File Offset: 0x005D9034
		public TLookAtTargetUnion()
		{
			this.Type = TLookAtTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0602AE64 RID: 175716 RVA: 0x005DAE4A File Offset: 0x005D904A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AE65 RID: 175717 RVA: 0x005DAE5C File Offset: 0x005D905C
		public ILookAtTargetEntityT AsILookAtTargetEntity()
		{
			return this.As<ILookAtTargetEntityT>();
		}

		// Token: 0x0602AE66 RID: 175718 RVA: 0x005DAE64 File Offset: 0x005D9064
		public static TLookAtTargetUnion FromILookAtTargetEntity(ILookAtTargetEntityT _ilookattargetentity)
		{
			return new TLookAtTargetUnion
			{
				Type = TLookAtTarget.ILookAtTargetEntity,
				Value = _ilookattargetentity
			};
		}

		// Token: 0x0602AE67 RID: 175719 RVA: 0x005DAE79 File Offset: 0x005D9079
		public ILookAtTargetPlayerT AsILookAtTargetPlayer()
		{
			return this.As<ILookAtTargetPlayerT>();
		}

		// Token: 0x0602AE68 RID: 175720 RVA: 0x005DAE81 File Offset: 0x005D9081
		public static TLookAtTargetUnion FromILookAtTargetPlayer(ILookAtTargetPlayerT _ilookattargetplayer)
		{
			return new TLookAtTargetUnion
			{
				Type = TLookAtTarget.ILookAtTargetPlayer,
				Value = _ilookattargetplayer
			};
		}

		// Token: 0x0602AE69 RID: 175721 RVA: 0x005DAE98 File Offset: 0x005D9098
		public static int Pack(FlatBufferBuilder builder, TLookAtTargetUnion _o)
		{
			TLookAtTarget type = _o.Type;
			if (type == TLookAtTarget.ILookAtTargetEntity)
			{
				return ILookAtTargetEntity.Pack(builder, _o.AsILookAtTargetEntity()).Value;
			}
			if (type != TLookAtTarget.ILookAtTargetPlayer)
			{
				return 0;
			}
			return ILookAtTargetPlayer.Pack(builder, _o.AsILookAtTargetPlayer()).Value;
		}
	}
}
