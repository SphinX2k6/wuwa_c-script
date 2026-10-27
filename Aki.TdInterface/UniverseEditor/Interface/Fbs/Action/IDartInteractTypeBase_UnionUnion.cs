using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006541 RID: 25921
	public class IDartInteractTypeBase_UnionUnion
	{
		// Token: 0x1700C0AA RID: 49322
		// (get) Token: 0x0602CF74 RID: 184180 RVA: 0x0062C6C5 File Offset: 0x0062A8C5
		// (set) Token: 0x0602CF75 RID: 184181 RVA: 0x0062C6CD File Offset: 0x0062A8CD
		public IDartInteractTypeBase_Union Type { get; set; }

		// Token: 0x1700C0AB RID: 49323
		// (get) Token: 0x0602CF76 RID: 184182 RVA: 0x0062C6D6 File Offset: 0x0062A8D6
		// (set) Token: 0x0602CF77 RID: 184183 RVA: 0x0062C6DE File Offset: 0x0062A8DE
		public object Value { get; set; }

		// Token: 0x0602CF78 RID: 184184 RVA: 0x0062C6E7 File Offset: 0x0062A8E7
		public IDartInteractTypeBase_UnionUnion()
		{
			this.Type = IDartInteractTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602CF79 RID: 184185 RVA: 0x0062C6FD File Offset: 0x0062A8FD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602CF7A RID: 184186 RVA: 0x0062C70F File Offset: 0x0062A90F
		public IDartInteractTypeBaseT AsIDartInteractTypeBase()
		{
			return this.As<IDartInteractTypeBaseT>();
		}

		// Token: 0x0602CF7B RID: 184187 RVA: 0x0062C717 File Offset: 0x0062A917
		public static IDartInteractTypeBase_UnionUnion FromIDartInteractTypeBase(IDartInteractTypeBaseT _idartinteracttypebase)
		{
			return new IDartInteractTypeBase_UnionUnion
			{
				Type = IDartInteractTypeBase_Union.IDartInteractTypeBase,
				Value = _idartinteracttypebase
			};
		}

		// Token: 0x0602CF7C RID: 184188 RVA: 0x0062C72C File Offset: 0x0062A92C
		public IDartMachineInteractTypeT AsIDartMachineInteractType()
		{
			return this.As<IDartMachineInteractTypeT>();
		}

		// Token: 0x0602CF7D RID: 184189 RVA: 0x0062C734 File Offset: 0x0062A934
		public static IDartInteractTypeBase_UnionUnion FromIDartMachineInteractType(IDartMachineInteractTypeT _idartmachineinteracttype)
		{
			return new IDartInteractTypeBase_UnionUnion
			{
				Type = IDartInteractTypeBase_Union.IDartMachineInteractType,
				Value = _idartmachineinteracttype
			};
		}

		// Token: 0x0602CF7E RID: 184190 RVA: 0x0062C749 File Offset: 0x0062A949
		public IDartChampionOwnerInteractTypeT AsIDartChampionOwnerInteractType()
		{
			return this.As<IDartChampionOwnerInteractTypeT>();
		}

		// Token: 0x0602CF7F RID: 184191 RVA: 0x0062C751 File Offset: 0x0062A951
		public static IDartInteractTypeBase_UnionUnion FromIDartChampionOwnerInteractType(IDartChampionOwnerInteractTypeT _idartchampionownerinteracttype)
		{
			return new IDartInteractTypeBase_UnionUnion
			{
				Type = IDartInteractTypeBase_Union.IDartChampionOwnerInteractType,
				Value = _idartchampionownerinteracttype
			};
		}

		// Token: 0x0602CF80 RID: 184192 RVA: 0x0062C766 File Offset: 0x0062A966
		public IDartPlayableRoleInteractTypeT AsIDartPlayableRoleInteractType()
		{
			return this.As<IDartPlayableRoleInteractTypeT>();
		}

		// Token: 0x0602CF81 RID: 184193 RVA: 0x0062C76E File Offset: 0x0062A96E
		public static IDartInteractTypeBase_UnionUnion FromIDartPlayableRoleInteractType(IDartPlayableRoleInteractTypeT _idartplayableroleinteracttype)
		{
			return new IDartInteractTypeBase_UnionUnion
			{
				Type = IDartInteractTypeBase_Union.IDartPlayableRoleInteractType,
				Value = _idartplayableroleinteracttype
			};
		}

		// Token: 0x0602CF82 RID: 184194 RVA: 0x0062C784 File Offset: 0x0062A984
		public static int Pack(FlatBufferBuilder builder, IDartInteractTypeBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IDartInteractTypeBase_Union.IDartInteractTypeBase:
				return IDartInteractTypeBase.Pack(builder, _o.AsIDartInteractTypeBase()).Value;
			case IDartInteractTypeBase_Union.IDartMachineInteractType:
				return IDartMachineInteractType.Pack(builder, _o.AsIDartMachineInteractType()).Value;
			case IDartInteractTypeBase_Union.IDartChampionOwnerInteractType:
				return IDartChampionOwnerInteractType.Pack(builder, _o.AsIDartChampionOwnerInteractType()).Value;
			case IDartInteractTypeBase_Union.IDartPlayableRoleInteractType:
				return IDartPlayableRoleInteractType.Pack(builder, _o.AsIDartPlayableRoleInteractType()).Value;
			default:
				return 0;
			}
		}
	}
}
