using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F75 RID: 28533
	public class IHandInHandInitiatorType_UnionUnion
	{
		// Token: 0x1700D102 RID: 53506
		// (get) Token: 0x0603162A RID: 202282 RVA: 0x006B287D File Offset: 0x006B0A7D
		// (set) Token: 0x0603162B RID: 202283 RVA: 0x006B2885 File Offset: 0x006B0A85
		public IHandInHandInitiatorType_Union Type { get; set; }

		// Token: 0x1700D103 RID: 53507
		// (get) Token: 0x0603162C RID: 202284 RVA: 0x006B288E File Offset: 0x006B0A8E
		// (set) Token: 0x0603162D RID: 202285 RVA: 0x006B2896 File Offset: 0x006B0A96
		public object Value { get; set; }

		// Token: 0x0603162E RID: 202286 RVA: 0x006B289F File Offset: 0x006B0A9F
		public IHandInHandInitiatorType_UnionUnion()
		{
			this.Type = IHandInHandInitiatorType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603162F RID: 202287 RVA: 0x006B28B5 File Offset: 0x006B0AB5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031630 RID: 202288 RVA: 0x006B28C7 File Offset: 0x006B0AC7
		public IHandInHandInitiatorTypeT AsIHandInHandInitiatorType()
		{
			return this.As<IHandInHandInitiatorTypeT>();
		}

		// Token: 0x06031631 RID: 202289 RVA: 0x006B28CF File Offset: 0x006B0ACF
		public static IHandInHandInitiatorType_UnionUnion FromIHandInHandInitiatorType(IHandInHandInitiatorTypeT _ihandinhandinitiatortype)
		{
			return new IHandInHandInitiatorType_UnionUnion
			{
				Type = IHandInHandInitiatorType_Union.IHandInHandInitiatorType,
				Value = _ihandinhandinitiatortype
			};
		}

		// Token: 0x06031632 RID: 202290 RVA: 0x006B28E4 File Offset: 0x006B0AE4
		public IPlayerHandInHandInitiatorT AsIPlayerHandInHandInitiator()
		{
			return this.As<IPlayerHandInHandInitiatorT>();
		}

		// Token: 0x06031633 RID: 202291 RVA: 0x006B28EC File Offset: 0x006B0AEC
		public static IHandInHandInitiatorType_UnionUnion FromIPlayerHandInHandInitiator(IPlayerHandInHandInitiatorT _iplayerhandinhandinitiator)
		{
			return new IHandInHandInitiatorType_UnionUnion
			{
				Type = IHandInHandInitiatorType_Union.IPlayerHandInHandInitiator,
				Value = _iplayerhandinhandinitiator
			};
		}

		// Token: 0x06031634 RID: 202292 RVA: 0x006B2901 File Offset: 0x006B0B01
		public IEntityHandInHandInitiatorT AsIEntityHandInHandInitiator()
		{
			return this.As<IEntityHandInHandInitiatorT>();
		}

		// Token: 0x06031635 RID: 202293 RVA: 0x006B2909 File Offset: 0x006B0B09
		public static IHandInHandInitiatorType_UnionUnion FromIEntityHandInHandInitiator(IEntityHandInHandInitiatorT _ientityhandinhandinitiator)
		{
			return new IHandInHandInitiatorType_UnionUnion
			{
				Type = IHandInHandInitiatorType_Union.IEntityHandInHandInitiator,
				Value = _ientityhandinhandinitiator
			};
		}

		// Token: 0x06031636 RID: 202294 RVA: 0x006B2920 File Offset: 0x006B0B20
		public static int Pack(FlatBufferBuilder builder, IHandInHandInitiatorType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IHandInHandInitiatorType_Union.IHandInHandInitiatorType:
				return IHandInHandInitiatorType.Pack(builder, _o.AsIHandInHandInitiatorType()).Value;
			case IHandInHandInitiatorType_Union.IPlayerHandInHandInitiator:
				return IPlayerHandInHandInitiator.Pack(builder, _o.AsIPlayerHandInHandInitiator()).Value;
			case IHandInHandInitiatorType_Union.IEntityHandInHandInitiator:
				return IEntityHandInHandInitiator.Pack(builder, _o.AsIEntityHandInHandInitiator()).Value;
			default:
				return 0;
			}
		}
	}
}
