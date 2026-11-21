using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EF8 RID: 32504
	public class THandInHandInitiatorUnion
	{
		// Token: 0x1700F273 RID: 62067
		// (get) Token: 0x0603AA2D RID: 240173 RVA: 0x007E3426 File Offset: 0x007E1626
		// (set) Token: 0x0603AA2E RID: 240174 RVA: 0x007E342E File Offset: 0x007E162E
		public THandInHandInitiator Type { get; set; }

		// Token: 0x1700F274 RID: 62068
		// (get) Token: 0x0603AA2F RID: 240175 RVA: 0x007E3437 File Offset: 0x007E1637
		// (set) Token: 0x0603AA30 RID: 240176 RVA: 0x007E343F File Offset: 0x007E163F
		public object Value { get; set; }

		// Token: 0x0603AA31 RID: 240177 RVA: 0x007E3448 File Offset: 0x007E1648
		public THandInHandInitiatorUnion()
		{
			this.Type = THandInHandInitiator.NONE;
			this.Value = null;
		}

		// Token: 0x0603AA32 RID: 240178 RVA: 0x007E345E File Offset: 0x007E165E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AA33 RID: 240179 RVA: 0x007E3470 File Offset: 0x007E1670
		public IEntityHandInHandInitiatorT AsIEntityHandInHandInitiator()
		{
			return this.As<IEntityHandInHandInitiatorT>();
		}

		// Token: 0x0603AA34 RID: 240180 RVA: 0x007E3478 File Offset: 0x007E1678
		public static THandInHandInitiatorUnion FromIEntityHandInHandInitiator(IEntityHandInHandInitiatorT _ientityhandinhandinitiator)
		{
			return new THandInHandInitiatorUnion
			{
				Type = THandInHandInitiator.IEntityHandInHandInitiator,
				Value = _ientityhandinhandinitiator
			};
		}

		// Token: 0x0603AA35 RID: 240181 RVA: 0x007E348D File Offset: 0x007E168D
		public IPlayerHandInHandInitiatorT AsIPlayerHandInHandInitiator()
		{
			return this.As<IPlayerHandInHandInitiatorT>();
		}

		// Token: 0x0603AA36 RID: 240182 RVA: 0x007E3495 File Offset: 0x007E1695
		public static THandInHandInitiatorUnion FromIPlayerHandInHandInitiator(IPlayerHandInHandInitiatorT _iplayerhandinhandinitiator)
		{
			return new THandInHandInitiatorUnion
			{
				Type = THandInHandInitiator.IPlayerHandInHandInitiator,
				Value = _iplayerhandinhandinitiator
			};
		}

		// Token: 0x0603AA37 RID: 240183 RVA: 0x007E34AC File Offset: 0x007E16AC
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
