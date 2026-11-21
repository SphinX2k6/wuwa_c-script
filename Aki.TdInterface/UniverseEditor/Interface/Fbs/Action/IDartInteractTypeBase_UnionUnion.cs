using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BB2 RID: 27570
	public class IDartInteractTypeBase_UnionUnion
	{
		// Token: 0x1700CA41 RID: 51777
		// (get) Token: 0x0602F728 RID: 194344 RVA: 0x00678D71 File Offset: 0x00676F71
		// (set) Token: 0x0602F729 RID: 194345 RVA: 0x00678D79 File Offset: 0x00676F79
		public IDartInteractTypeBase_Union Type { get; set; }

		// Token: 0x1700CA42 RID: 51778
		// (get) Token: 0x0602F72A RID: 194346 RVA: 0x00678D82 File Offset: 0x00676F82
		// (set) Token: 0x0602F72B RID: 194347 RVA: 0x00678D8A File Offset: 0x00676F8A
		public object Value { get; set; }

		// Token: 0x0602F72C RID: 194348 RVA: 0x00678D93 File Offset: 0x00676F93
		public IDartInteractTypeBase_UnionUnion()
		{
			this.Type = IDartInteractTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F72D RID: 194349 RVA: 0x00678DA9 File Offset: 0x00676FA9
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F72E RID: 194350 RVA: 0x00678DBB File Offset: 0x00676FBB
		public IDartInteractTypeBaseT AsIDartInteractTypeBase()
		{
			return this.As<IDartInteractTypeBaseT>();
		}

		// Token: 0x0602F72F RID: 194351 RVA: 0x00678DC3 File Offset: 0x00676FC3
		public static IDartInteractTypeBase_UnionUnion FromIDartInteractTypeBase(IDartInteractTypeBaseT _idartinteracttypebase)
		{
			return new IDartInteractTypeBase_UnionUnion
			{
				Type = IDartInteractTypeBase_Union.IDartInteractTypeBase,
				Value = _idartinteracttypebase
			};
		}

		// Token: 0x0602F730 RID: 194352 RVA: 0x00678DD8 File Offset: 0x00676FD8
		public IDartMachineInteractTypeT AsIDartMachineInteractType()
		{
			return this.As<IDartMachineInteractTypeT>();
		}

		// Token: 0x0602F731 RID: 194353 RVA: 0x00678DE0 File Offset: 0x00676FE0
		public static IDartInteractTypeBase_UnionUnion FromIDartMachineInteractType(IDartMachineInteractTypeT _idartmachineinteracttype)
		{
			return new IDartInteractTypeBase_UnionUnion
			{
				Type = IDartInteractTypeBase_Union.IDartMachineInteractType,
				Value = _idartmachineinteracttype
			};
		}

		// Token: 0x0602F732 RID: 194354 RVA: 0x00678DF5 File Offset: 0x00676FF5
		public IDartChampionOwnerInteractTypeT AsIDartChampionOwnerInteractType()
		{
			return this.As<IDartChampionOwnerInteractTypeT>();
		}

		// Token: 0x0602F733 RID: 194355 RVA: 0x00678DFD File Offset: 0x00676FFD
		public static IDartInteractTypeBase_UnionUnion FromIDartChampionOwnerInteractType(IDartChampionOwnerInteractTypeT _idartchampionownerinteracttype)
		{
			return new IDartInteractTypeBase_UnionUnion
			{
				Type = IDartInteractTypeBase_Union.IDartChampionOwnerInteractType,
				Value = _idartchampionownerinteracttype
			};
		}

		// Token: 0x0602F734 RID: 194356 RVA: 0x00678E12 File Offset: 0x00677012
		public IDartPlayableRoleInteractTypeT AsIDartPlayableRoleInteractType()
		{
			return this.As<IDartPlayableRoleInteractTypeT>();
		}

		// Token: 0x0602F735 RID: 194357 RVA: 0x00678E1A File Offset: 0x0067701A
		public static IDartInteractTypeBase_UnionUnion FromIDartPlayableRoleInteractType(IDartPlayableRoleInteractTypeT _idartplayableroleinteracttype)
		{
			return new IDartInteractTypeBase_UnionUnion
			{
				Type = IDartInteractTypeBase_Union.IDartPlayableRoleInteractType,
				Value = _idartplayableroleinteracttype
			};
		}

		// Token: 0x0602F736 RID: 194358 RVA: 0x00678E30 File Offset: 0x00677030
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
