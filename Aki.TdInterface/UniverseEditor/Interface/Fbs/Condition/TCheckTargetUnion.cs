using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004D3D RID: 19773
	public class TCheckTargetUnion
	{
		// Token: 0x17008F43 RID: 36675
		// (get) Token: 0x0601F62C RID: 128556 RVA: 0x0045FD73 File Offset: 0x0045DF73
		// (set) Token: 0x0601F62D RID: 128557 RVA: 0x0045FD7B File Offset: 0x0045DF7B
		public TCheckTarget Type { get; set; }

		// Token: 0x17008F44 RID: 36676
		// (get) Token: 0x0601F62E RID: 128558 RVA: 0x0045FD84 File Offset: 0x0045DF84
		// (set) Token: 0x0601F62F RID: 128559 RVA: 0x0045FD8C File Offset: 0x0045DF8C
		public object Value { get; set; }

		// Token: 0x0601F630 RID: 128560 RVA: 0x0045FD95 File Offset: 0x0045DF95
		public TCheckTargetUnion()
		{
			this.Type = TCheckTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0601F631 RID: 128561 RVA: 0x0045FDAB File Offset: 0x0045DFAB
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601F632 RID: 128562 RVA: 0x0045FDBD File Offset: 0x0045DFBD
		public ICheckOnlinePlayerT AsICheckOnlinePlayer()
		{
			return this.As<ICheckOnlinePlayerT>();
		}

		// Token: 0x0601F633 RID: 128563 RVA: 0x0045FDC5 File Offset: 0x0045DFC5
		public static TCheckTargetUnion FromICheckOnlinePlayer(ICheckOnlinePlayerT _icheckonlineplayer)
		{
			return new TCheckTargetUnion
			{
				Type = TCheckTarget.ICheckOnlinePlayer,
				Value = _icheckonlineplayer
			};
		}

		// Token: 0x0601F634 RID: 128564 RVA: 0x0045FDDA File Offset: 0x0045DFDA
		public ICheckTargetEntityT AsICheckTargetEntity()
		{
			return this.As<ICheckTargetEntityT>();
		}

		// Token: 0x0601F635 RID: 128565 RVA: 0x0045FDE2 File Offset: 0x0045DFE2
		public static TCheckTargetUnion FromICheckTargetEntity(ICheckTargetEntityT _ichecktargetentity)
		{
			return new TCheckTargetUnion
			{
				Type = TCheckTarget.ICheckTargetEntity,
				Value = _ichecktargetentity
			};
		}

		// Token: 0x0601F636 RID: 128566 RVA: 0x0045FDF8 File Offset: 0x0045DFF8
		public static int Pack(FlatBufferBuilder builder, TCheckTargetUnion _o)
		{
			TCheckTarget type = _o.Type;
			if (type == TCheckTarget.ICheckOnlinePlayer)
			{
				return ICheckOnlinePlayer.Pack(builder, _o.AsICheckOnlinePlayer()).Value;
			}
			if (type != TCheckTarget.ICheckTargetEntity)
			{
				return 0;
			}
			return ICheckTargetEntity.Pack(builder, _o.AsICheckTargetEntity()).Value;
		}
	}
}
