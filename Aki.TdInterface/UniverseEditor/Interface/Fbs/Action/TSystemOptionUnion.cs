using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077BD RID: 30653
	public class TSystemOptionUnion
	{
		// Token: 0x1700E6C1 RID: 59073
		// (get) Token: 0x060379CE RID: 227790 RVA: 0x00785B10 File Offset: 0x00783D10
		// (set) Token: 0x060379CF RID: 227791 RVA: 0x00785B18 File Offset: 0x00783D18
		public TSystemOption Type { get; set; }

		// Token: 0x1700E6C2 RID: 59074
		// (get) Token: 0x060379D0 RID: 227792 RVA: 0x00785B21 File Offset: 0x00783D21
		// (set) Token: 0x060379D1 RID: 227793 RVA: 0x00785B29 File Offset: 0x00783D29
		public object Value { get; set; }

		// Token: 0x060379D2 RID: 227794 RVA: 0x00785B32 File Offset: 0x00783D32
		public TSystemOptionUnion()
		{
			this.Type = TSystemOption.NONE;
			this.Value = null;
		}

		// Token: 0x060379D3 RID: 227795 RVA: 0x00785B48 File Offset: 0x00783D48
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060379D4 RID: 227796 RVA: 0x00785B5A File Offset: 0x00783D5A
		public IGravityControlOptionT AsIGravityControlOption()
		{
			return this.As<IGravityControlOptionT>();
		}

		// Token: 0x060379D5 RID: 227797 RVA: 0x00785B62 File Offset: 0x00783D62
		public static TSystemOptionUnion FromIGravityControlOption(IGravityControlOptionT _igravitycontroloption)
		{
			return new TSystemOptionUnion
			{
				Type = TSystemOption.IGravityControlOption,
				Value = _igravitycontroloption
			};
		}

		// Token: 0x060379D6 RID: 227798 RVA: 0x00785B77 File Offset: 0x00783D77
		public IPermanentRogueRandomEventT AsIPermanentRogueRandomEvent()
		{
			return this.As<IPermanentRogueRandomEventT>();
		}

		// Token: 0x060379D7 RID: 227799 RVA: 0x00785B7F File Offset: 0x00783D7F
		public static TSystemOptionUnion FromIPermanentRogueRandomEvent(IPermanentRogueRandomEventT _ipermanentroguerandomevent)
		{
			return new TSystemOptionUnion
			{
				Type = TSystemOption.IPermanentRogueRandomEvent,
				Value = _ipermanentroguerandomevent
			};
		}

		// Token: 0x060379D8 RID: 227800 RVA: 0x00785B94 File Offset: 0x00783D94
		public IRogueRandomEventOptionT AsIRogueRandomEventOption()
		{
			return this.As<IRogueRandomEventOptionT>();
		}

		// Token: 0x060379D9 RID: 227801 RVA: 0x00785B9C File Offset: 0x00783D9C
		public static TSystemOptionUnion FromIRogueRandomEventOption(IRogueRandomEventOptionT _iroguerandomeventoption)
		{
			return new TSystemOptionUnion
			{
				Type = TSystemOption.IRogueRandomEventOption,
				Value = _iroguerandomeventoption
			};
		}

		// Token: 0x060379DA RID: 227802 RVA: 0x00785BB4 File Offset: 0x00783DB4
		public static int Pack(FlatBufferBuilder builder, TSystemOptionUnion _o)
		{
			switch (_o.Type)
			{
			case TSystemOption.IGravityControlOption:
				return IGravityControlOption.Pack(builder, _o.AsIGravityControlOption()).Value;
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
