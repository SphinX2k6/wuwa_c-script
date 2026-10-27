using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200728A RID: 29322
	public class ISystemOptionType_UnionUnion
	{
		// Token: 0x1700D989 RID: 55689
		// (get) Token: 0x06034069 RID: 213097 RVA: 0x006FED4B File Offset: 0x006FCF4B
		// (set) Token: 0x0603406A RID: 213098 RVA: 0x006FED53 File Offset: 0x006FCF53
		public ISystemOptionType_Union Type { get; set; }

		// Token: 0x1700D98A RID: 55690
		// (get) Token: 0x0603406B RID: 213099 RVA: 0x006FED5C File Offset: 0x006FCF5C
		// (set) Token: 0x0603406C RID: 213100 RVA: 0x006FED64 File Offset: 0x006FCF64
		public object Value { get; set; }

		// Token: 0x0603406D RID: 213101 RVA: 0x006FED6D File Offset: 0x006FCF6D
		public ISystemOptionType_UnionUnion()
		{
			this.Type = ISystemOptionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0603406E RID: 213102 RVA: 0x006FED83 File Offset: 0x006FCF83
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603406F RID: 213103 RVA: 0x006FED95 File Offset: 0x006FCF95
		public ISystemOptionTypeT AsISystemOptionType()
		{
			return this.As<ISystemOptionTypeT>();
		}

		// Token: 0x06034070 RID: 213104 RVA: 0x006FED9D File Offset: 0x006FCF9D
		public static ISystemOptionType_UnionUnion FromISystemOptionType(ISystemOptionTypeT _isystemoptiontype)
		{
			return new ISystemOptionType_UnionUnion
			{
				Type = ISystemOptionType_Union.ISystemOptionType,
				Value = _isystemoptiontype
			};
		}

		// Token: 0x06034071 RID: 213105 RVA: 0x006FEDB2 File Offset: 0x006FCFB2
		public IRogueRandomEventOptionT AsIRogueRandomEventOption()
		{
			return this.As<IRogueRandomEventOptionT>();
		}

		// Token: 0x06034072 RID: 213106 RVA: 0x006FEDBA File Offset: 0x006FCFBA
		public static ISystemOptionType_UnionUnion FromIRogueRandomEventOption(IRogueRandomEventOptionT _iroguerandomeventoption)
		{
			return new ISystemOptionType_UnionUnion
			{
				Type = ISystemOptionType_Union.IRogueRandomEventOption,
				Value = _iroguerandomeventoption
			};
		}

		// Token: 0x06034073 RID: 213107 RVA: 0x006FEDCF File Offset: 0x006FCFCF
		public IPermanentRogueRandomEventT AsIPermanentRogueRandomEvent()
		{
			return this.As<IPermanentRogueRandomEventT>();
		}

		// Token: 0x06034074 RID: 213108 RVA: 0x006FEDD7 File Offset: 0x006FCFD7
		public static ISystemOptionType_UnionUnion FromIPermanentRogueRandomEvent(IPermanentRogueRandomEventT _ipermanentroguerandomevent)
		{
			return new ISystemOptionType_UnionUnion
			{
				Type = ISystemOptionType_Union.IPermanentRogueRandomEvent,
				Value = _ipermanentroguerandomevent
			};
		}

		// Token: 0x06034075 RID: 213109 RVA: 0x006FEDEC File Offset: 0x006FCFEC
		public IGravityControlOptionT AsIGravityControlOption()
		{
			return this.As<IGravityControlOptionT>();
		}

		// Token: 0x06034076 RID: 213110 RVA: 0x006FEDF4 File Offset: 0x006FCFF4
		public static ISystemOptionType_UnionUnion FromIGravityControlOption(IGravityControlOptionT _igravitycontroloption)
		{
			return new ISystemOptionType_UnionUnion
			{
				Type = ISystemOptionType_Union.IGravityControlOption,
				Value = _igravitycontroloption
			};
		}

		// Token: 0x06034077 RID: 213111 RVA: 0x006FEE0C File Offset: 0x006FD00C
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
			default:
				return 0;
			}
		}
	}
}
