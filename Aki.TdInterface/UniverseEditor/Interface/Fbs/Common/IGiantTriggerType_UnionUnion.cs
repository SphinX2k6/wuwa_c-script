using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02005DF2 RID: 24050
	public class IGiantTriggerType_UnionUnion
	{
		// Token: 0x1700B3FD RID: 46077
		// (get) Token: 0x060292AA RID: 168618 RVA: 0x005A6175 File Offset: 0x005A4375
		// (set) Token: 0x060292AB RID: 168619 RVA: 0x005A617D File Offset: 0x005A437D
		public IGiantTriggerType_Union Type { get; set; }

		// Token: 0x1700B3FE RID: 46078
		// (get) Token: 0x060292AC RID: 168620 RVA: 0x005A6186 File Offset: 0x005A4386
		// (set) Token: 0x060292AD RID: 168621 RVA: 0x005A618E File Offset: 0x005A438E
		public object Value { get; set; }

		// Token: 0x060292AE RID: 168622 RVA: 0x005A6197 File Offset: 0x005A4397
		public IGiantTriggerType_UnionUnion()
		{
			this.Type = IGiantTriggerType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060292AF RID: 168623 RVA: 0x005A61AD File Offset: 0x005A43AD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060292B0 RID: 168624 RVA: 0x005A61BF File Offset: 0x005A43BF
		public IGiantTriggerTypeT AsIGiantTriggerType()
		{
			return this.As<IGiantTriggerTypeT>();
		}

		// Token: 0x060292B1 RID: 168625 RVA: 0x005A61C7 File Offset: 0x005A43C7
		public static IGiantTriggerType_UnionUnion FromIGiantTriggerType(IGiantTriggerTypeT _igianttriggertype)
		{
			return new IGiantTriggerType_UnionUnion
			{
				Type = IGiantTriggerType_Union.IGiantTriggerType,
				Value = _igianttriggertype
			};
		}

		// Token: 0x060292B2 RID: 168626 RVA: 0x005A61DC File Offset: 0x005A43DC
		public IGiantTriggerRoleStateT AsIGiantTriggerRoleState()
		{
			return this.As<IGiantTriggerRoleStateT>();
		}

		// Token: 0x060292B3 RID: 168627 RVA: 0x005A61E4 File Offset: 0x005A43E4
		public static IGiantTriggerType_UnionUnion FromIGiantTriggerRoleState(IGiantTriggerRoleStateT _igianttriggerrolestate)
		{
			return new IGiantTriggerType_UnionUnion
			{
				Type = IGiantTriggerType_Union.IGiantTriggerRoleState,
				Value = _igianttriggerrolestate
			};
		}

		// Token: 0x060292B4 RID: 168628 RVA: 0x005A61F9 File Offset: 0x005A43F9
		public IGiantTriggerStableValueT AsIGiantTriggerStableValue()
		{
			return this.As<IGiantTriggerStableValueT>();
		}

		// Token: 0x060292B5 RID: 168629 RVA: 0x005A6201 File Offset: 0x005A4401
		public static IGiantTriggerType_UnionUnion FromIGiantTriggerStableValue(IGiantTriggerStableValueT _igianttriggerstablevalue)
		{
			return new IGiantTriggerType_UnionUnion
			{
				Type = IGiantTriggerType_Union.IGiantTriggerStableValue,
				Value = _igianttriggerstablevalue
			};
		}

		// Token: 0x060292B6 RID: 168630 RVA: 0x005A6216 File Offset: 0x005A4416
		public IGiantTriggerEnterAreaT AsIGiantTriggerEnterArea()
		{
			return this.As<IGiantTriggerEnterAreaT>();
		}

		// Token: 0x060292B7 RID: 168631 RVA: 0x005A621E File Offset: 0x005A441E
		public static IGiantTriggerType_UnionUnion FromIGiantTriggerEnterArea(IGiantTriggerEnterAreaT _igianttriggerenterarea)
		{
			return new IGiantTriggerType_UnionUnion
			{
				Type = IGiantTriggerType_Union.IGiantTriggerEnterArea,
				Value = _igianttriggerenterarea
			};
		}

		// Token: 0x060292B8 RID: 168632 RVA: 0x005A6234 File Offset: 0x005A4434
		public static int Pack(FlatBufferBuilder builder, IGiantTriggerType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IGiantTriggerType_Union.IGiantTriggerType:
				return IGiantTriggerType.Pack(builder, _o.AsIGiantTriggerType()).Value;
			case IGiantTriggerType_Union.IGiantTriggerRoleState:
				return IGiantTriggerRoleState.Pack(builder, _o.AsIGiantTriggerRoleState()).Value;
			case IGiantTriggerType_Union.IGiantTriggerStableValue:
				return IGiantTriggerStableValue.Pack(builder, _o.AsIGiantTriggerStableValue()).Value;
			case IGiantTriggerType_Union.IGiantTriggerEnterArea:
				return IGiantTriggerEnterArea.Pack(builder, _o.AsIGiantTriggerEnterArea()).Value;
			default:
				return 0;
			}
		}
	}
}
