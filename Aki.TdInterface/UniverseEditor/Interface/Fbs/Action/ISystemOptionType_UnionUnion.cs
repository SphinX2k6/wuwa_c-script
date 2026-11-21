using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A5F RID: 31327
	public class ISystemOptionType_UnionUnion
	{
		// Token: 0x1700E582 RID: 58754
		// (get) Token: 0x0603736B RID: 226155 RVA: 0x007600AB File Offset: 0x0075E2AB
		// (set) Token: 0x0603736C RID: 226156 RVA: 0x007600B3 File Offset: 0x0075E2B3
		public ISystemOptionType_Union Type { get; set; }

		// Token: 0x1700E583 RID: 58755
		// (get) Token: 0x0603736D RID: 226157 RVA: 0x007600BC File Offset: 0x0075E2BC
		// (set) Token: 0x0603736E RID: 226158 RVA: 0x007600C4 File Offset: 0x0075E2C4
		public object Value { get; set; }

		// Token: 0x0603736F RID: 226159 RVA: 0x007600CD File Offset: 0x0075E2CD
		public ISystemOptionType_UnionUnion()
		{
			this.Type = ISystemOptionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06037370 RID: 226160 RVA: 0x007600E3 File Offset: 0x0075E2E3
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037371 RID: 226161 RVA: 0x007600F5 File Offset: 0x0075E2F5
		public ISystemOptionTypeT AsISystemOptionType()
		{
			return this.As<ISystemOptionTypeT>();
		}

		// Token: 0x06037372 RID: 226162 RVA: 0x007600FD File Offset: 0x0075E2FD
		public static ISystemOptionType_UnionUnion FromISystemOptionType(ISystemOptionTypeT _isystemoptiontype)
		{
			return new ISystemOptionType_UnionUnion
			{
				Type = ISystemOptionType_Union.ISystemOptionType,
				Value = _isystemoptiontype
			};
		}

		// Token: 0x06037373 RID: 226163 RVA: 0x00760112 File Offset: 0x0075E312
		public IRogueRandomEventOptionT AsIRogueRandomEventOption()
		{
			return this.As<IRogueRandomEventOptionT>();
		}

		// Token: 0x06037374 RID: 226164 RVA: 0x0076011A File Offset: 0x0075E31A
		public static ISystemOptionType_UnionUnion FromIRogueRandomEventOption(IRogueRandomEventOptionT _iroguerandomeventoption)
		{
			return new ISystemOptionType_UnionUnion
			{
				Type = ISystemOptionType_Union.IRogueRandomEventOption,
				Value = _iroguerandomeventoption
			};
		}

		// Token: 0x06037375 RID: 226165 RVA: 0x0076012F File Offset: 0x0075E32F
		public IPermanentRogueRandomEventT AsIPermanentRogueRandomEvent()
		{
			return this.As<IPermanentRogueRandomEventT>();
		}

		// Token: 0x06037376 RID: 226166 RVA: 0x00760137 File Offset: 0x0075E337
		public static ISystemOptionType_UnionUnion FromIPermanentRogueRandomEvent(IPermanentRogueRandomEventT _ipermanentroguerandomevent)
		{
			return new ISystemOptionType_UnionUnion
			{
				Type = ISystemOptionType_Union.IPermanentRogueRandomEvent,
				Value = _ipermanentroguerandomevent
			};
		}

		// Token: 0x06037377 RID: 226167 RVA: 0x0076014C File Offset: 0x0075E34C
		public IGravityControlOptionT AsIGravityControlOption()
		{
			return this.As<IGravityControlOptionT>();
		}

		// Token: 0x06037378 RID: 226168 RVA: 0x00760154 File Offset: 0x0075E354
		public static ISystemOptionType_UnionUnion FromIGravityControlOption(IGravityControlOptionT _igravitycontroloption)
		{
			return new ISystemOptionType_UnionUnion
			{
				Type = ISystemOptionType_Union.IGravityControlOption,
				Value = _igravitycontroloption
			};
		}

		// Token: 0x06037379 RID: 226169 RVA: 0x00760169 File Offset: 0x0075E369
		public ILiveInteractScOptionT AsILiveInteractScOption()
		{
			return this.As<ILiveInteractScOptionT>();
		}

		// Token: 0x0603737A RID: 226170 RVA: 0x00760171 File Offset: 0x0075E371
		public static ISystemOptionType_UnionUnion FromILiveInteractScOption(ILiveInteractScOptionT _iliveinteractscoption)
		{
			return new ISystemOptionType_UnionUnion
			{
				Type = ISystemOptionType_Union.ILiveInteractScOption,
				Value = _iliveinteractscoption
			};
		}

		// Token: 0x0603737B RID: 226171 RVA: 0x00760188 File Offset: 0x0075E388
		public static int Pack(FlatBufferBuilder builder, ISystemOptionType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISystemOptionType_Union.ISystemOptionType:
				return ISystemOptionType.Pack(builder, _o.AsISystemOptionType()).Value;
			case ISystemOptionType_Union.IRogueRandomEventOption:
				return IRogueRandomEventOption.Pack(builder, _o.AsIRogueRandomEventOption()).Value;
			case ISystemOptionType_Union.IPermanentRogueRandomEvent:
				return IPermanentRogueRandomEvent.Pack(builder, _o.AsIPermanentRogueRandomEvent()).Value;
			case ISystemOptionType_Union.IGravityControlOption:
				return IGravityControlOption.Pack(builder, _o.AsIGravityControlOption()).Value;
			case ISystemOptionType_Union.ILiveInteractScOption:
				return ILiveInteractScOption.Pack(builder, _o.AsILiveInteractScOption()).Value;
			default:
				return 0;
			}
		}
	}
}
