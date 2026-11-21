using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FF5 RID: 32757
	public class TSystemOptionUnion
	{
		// Token: 0x1700F31B RID: 62235
		// (get) Token: 0x0603AF4F RID: 241487 RVA: 0x007EB0E0 File Offset: 0x007E92E0
		// (set) Token: 0x0603AF50 RID: 241488 RVA: 0x007EB0E8 File Offset: 0x007E92E8
		public TSystemOption Type { get; set; }

		// Token: 0x1700F31C RID: 62236
		// (get) Token: 0x0603AF51 RID: 241489 RVA: 0x007EB0F1 File Offset: 0x007E92F1
		// (set) Token: 0x0603AF52 RID: 241490 RVA: 0x007EB0F9 File Offset: 0x007E92F9
		public object Value { get; set; }

		// Token: 0x0603AF53 RID: 241491 RVA: 0x007EB102 File Offset: 0x007E9302
		public TSystemOptionUnion()
		{
			this.Type = TSystemOption.NONE;
			this.Value = null;
		}

		// Token: 0x0603AF54 RID: 241492 RVA: 0x007EB118 File Offset: 0x007E9318
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AF55 RID: 241493 RVA: 0x007EB12A File Offset: 0x007E932A
		public IGravityControlOptionT AsIGravityControlOption()
		{
			return this.As<IGravityControlOptionT>();
		}

		// Token: 0x0603AF56 RID: 241494 RVA: 0x007EB132 File Offset: 0x007E9332
		public static TSystemOptionUnion FromIGravityControlOption(IGravityControlOptionT _igravitycontroloption)
		{
			return new TSystemOptionUnion
			{
				Type = TSystemOption.IGravityControlOption,
				Value = _igravitycontroloption
			};
		}

		// Token: 0x0603AF57 RID: 241495 RVA: 0x007EB147 File Offset: 0x007E9347
		public ILiveInteractScOptionT AsILiveInteractScOption()
		{
			return this.As<ILiveInteractScOptionT>();
		}

		// Token: 0x0603AF58 RID: 241496 RVA: 0x007EB14F File Offset: 0x007E934F
		public static TSystemOptionUnion FromILiveInteractScOption(ILiveInteractScOptionT _iliveinteractscoption)
		{
			return new TSystemOptionUnion
			{
				Type = TSystemOption.ILiveInteractScOption,
				Value = _iliveinteractscoption
			};
		}

		// Token: 0x0603AF59 RID: 241497 RVA: 0x007EB164 File Offset: 0x007E9364
		public IPermanentRogueRandomEventT AsIPermanentRogueRandomEvent()
		{
			return this.As<IPermanentRogueRandomEventT>();
		}

		// Token: 0x0603AF5A RID: 241498 RVA: 0x007EB16C File Offset: 0x007E936C
		public static TSystemOptionUnion FromIPermanentRogueRandomEvent(IPermanentRogueRandomEventT _ipermanentroguerandomevent)
		{
			return new TSystemOptionUnion
			{
				Type = TSystemOption.IPermanentRogueRandomEvent,
				Value = _ipermanentroguerandomevent
			};
		}

		// Token: 0x0603AF5B RID: 241499 RVA: 0x007EB181 File Offset: 0x007E9381
		public IRogueRandomEventOptionT AsIRogueRandomEventOption()
		{
			return this.As<IRogueRandomEventOptionT>();
		}

		// Token: 0x0603AF5C RID: 241500 RVA: 0x007EB189 File Offset: 0x007E9389
		public static TSystemOptionUnion FromIRogueRandomEventOption(IRogueRandomEventOptionT _iroguerandomeventoption)
		{
			return new TSystemOptionUnion
			{
				Type = TSystemOption.IRogueRandomEventOption,
				Value = _iroguerandomeventoption
			};
		}

		// Token: 0x0603AF5D RID: 241501 RVA: 0x007EB1A0 File Offset: 0x007E93A0
		public static int Pack(FlatBufferBuilder builder, TSystemOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TSystemOption.IGravityControlOption:
				return IGravityControlOption.Pack(builder, _o.AsIGravityControlOption()).Value;
			case TSystemOption.ILiveInteractScOption:
				return ILiveInteractScOption.Pack(builder, _o.AsILiveInteractScOption()).Value;
			case TSystemOption.IPermanentRogueRandomEvent:
				return IPermanentRogueRandomEvent.Pack(builder, _o.AsIPermanentRogueRandomEvent()).Value;
			case TSystemOption.IRogueRandomEventOption:
				return IRogueRandomEventOption.Pack(builder, _o.AsIRogueRandomEventOption()).Value;
			default:
				return 0;
			}
		}
	}
}
