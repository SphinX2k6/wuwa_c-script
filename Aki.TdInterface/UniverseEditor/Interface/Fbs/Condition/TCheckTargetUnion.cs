using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005239 RID: 21049
	public class TCheckTargetUnion
	{
		// Token: 0x1700967C RID: 38524
		// (get) Token: 0x06021275 RID: 135797 RVA: 0x00493D48 File Offset: 0x00491F48
		// (set) Token: 0x06021276 RID: 135798 RVA: 0x00493D50 File Offset: 0x00491F50
		public TCheckTarget Type { get; set; }

		// Token: 0x1700967D RID: 38525
		// (get) Token: 0x06021277 RID: 135799 RVA: 0x00493D59 File Offset: 0x00491F59
		// (set) Token: 0x06021278 RID: 135800 RVA: 0x00493D61 File Offset: 0x00491F61
		public object Value { get; set; }

		// Token: 0x06021279 RID: 135801 RVA: 0x00493D6A File Offset: 0x00491F6A
		public TCheckTargetUnion()
		{
			this.Type = TCheckTarget.NONE;
			this.Value = null;
		}

		// Token: 0x0602127A RID: 135802 RVA: 0x00493D80 File Offset: 0x00491F80
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602127B RID: 135803 RVA: 0x00493D92 File Offset: 0x00491F92
		public ICheckOnlinePlayerT AsICheckOnlinePlayer()
		{
			return this.As<ICheckOnlinePlayerT>();
		}

		// Token: 0x0602127C RID: 135804 RVA: 0x00493D9A File Offset: 0x00491F9A
		public static TCheckTargetUnion FromICheckOnlinePlayer(ICheckOnlinePlayerT _icheckonlineplayer)
		{
			return new TCheckTargetUnion
			{
				Type = TCheckTarget.ICheckOnlinePlayer,
				Value = _icheckonlineplayer
			};
		}

		// Token: 0x0602127D RID: 135805 RVA: 0x00493DAF File Offset: 0x00491FAF
		public ICheckTargetEntityT AsICheckTargetEntity()
		{
			return this.As<ICheckTargetEntityT>();
		}

		// Token: 0x0602127E RID: 135806 RVA: 0x00493DB7 File Offset: 0x00491FB7
		public static TCheckTargetUnion FromICheckTargetEntity(ICheckTargetEntityT _ichecktargetentity)
		{
			return new TCheckTargetUnion
			{
				Type = TCheckTarget.ICheckTargetEntity,
				Value = _ichecktargetentity
			};
		}

		// Token: 0x0602127F RID: 135807 RVA: 0x00493DCC File Offset: 0x00491FCC
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
