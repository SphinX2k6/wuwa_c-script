using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076E4 RID: 30436
	public class THandInHandInitiatorUnion
	{
		// Token: 0x1700E631 RID: 58929
		// (get) Token: 0x06037560 RID: 226656 RVA: 0x0077EF1A File Offset: 0x0077D11A
		// (set) Token: 0x06037561 RID: 226657 RVA: 0x0077EF22 File Offset: 0x0077D122
		public THandInHandInitiator Type { get; set; }

		// Token: 0x1700E632 RID: 58930
		// (get) Token: 0x06037562 RID: 226658 RVA: 0x0077EF2B File Offset: 0x0077D12B
		// (set) Token: 0x06037563 RID: 226659 RVA: 0x0077EF33 File Offset: 0x0077D133
		public object Value { get; set; }

		// Token: 0x06037564 RID: 226660 RVA: 0x0077EF3C File Offset: 0x0077D13C
		public THandInHandInitiatorUnion()
		{
			this.Type = THandInHandInitiator.NONE;
			this.Value = null;
		}

		// Token: 0x06037565 RID: 226661 RVA: 0x0077EF52 File Offset: 0x0077D152
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037566 RID: 226662 RVA: 0x0077EF64 File Offset: 0x0077D164
		public IEntityHandInHandInitiatorT AsIEntityHandInHandInitiator()
		{
			return this.As<IEntityHandInHandInitiatorT>();
		}

		// Token: 0x06037567 RID: 226663 RVA: 0x0077EF6C File Offset: 0x0077D16C
		public static THandInHandInitiatorUnion FromIEntityHandInHandInitiator(IEntityHandInHandInitiatorT _ientityhandinhandinitiator)
		{
			return new THandInHandInitiatorUnion
			{
				Type = THandInHandInitiator.IEntityHandInHandInitiator,
				Value = _ientityhandinhandinitiator
			};
		}

		// Token: 0x06037568 RID: 226664 RVA: 0x0077EF81 File Offset: 0x0077D181
		public IPlayerHandInHandInitiatorT AsIPlayerHandInHandInitiator()
		{
			return this.As<IPlayerHandInHandInitiatorT>();
		}

		// Token: 0x06037569 RID: 226665 RVA: 0x0077EF89 File Offset: 0x0077D189
		public static THandInHandInitiatorUnion FromIPlayerHandInHandInitiator(IPlayerHandInHandInitiatorT _iplayerhandinhandinitiator)
		{
			return new THandInHandInitiatorUnion
			{
				Type = THandInHandInitiator.IPlayerHandInHandInitiator,
				Value = _iplayerhandinhandinitiator
			};
		}

		// Token: 0x0603756A RID: 226666 RVA: 0x0077EFA0 File Offset: 0x0077D1A0
		public static int Pack(FlatBufferBuilder builder, THandInHandInitiatorUnion _o)
		{
			THandInHandInitiator type = _o.Type;
			if (type == THandInHandInitiator.IEntityHandInHandInitiator)
			{
				return IEntityHandInHandInitiator.Pack(builder, _o.AsIEntityHandInHandInitiator()).Value;
			}
			if (type != THandInHandInitiator.IPlayerHandInHandInitiator)
			{
				return 0;
			}
			return IPlayerHandInHandInitiator.Pack(builder, _o.AsIPlayerHandInHandInitiator()).Value;
		}
	}
}
