using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EAD RID: 32429
	public class TDartInteractTypeUnion
	{
		// Token: 0x1700F241 RID: 62017
		// (get) Token: 0x0603A8C3 RID: 239811 RVA: 0x007E130C File Offset: 0x007DF50C
		// (set) Token: 0x0603A8C4 RID: 239812 RVA: 0x007E1314 File Offset: 0x007DF514
		public TDartInteractType Type { get; set; }

		// Token: 0x1700F242 RID: 62018
		// (get) Token: 0x0603A8C5 RID: 239813 RVA: 0x007E131D File Offset: 0x007DF51D
		// (set) Token: 0x0603A8C6 RID: 239814 RVA: 0x007E1325 File Offset: 0x007DF525
		public object Value { get; set; }

		// Token: 0x0603A8C7 RID: 239815 RVA: 0x007E132E File Offset: 0x007DF52E
		public TDartInteractTypeUnion()
		{
			this.Type = TDartInteractType.NONE;
			this.Value = null;
		}

		// Token: 0x0603A8C8 RID: 239816 RVA: 0x007E1344 File Offset: 0x007DF544
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603A8C9 RID: 239817 RVA: 0x007E1356 File Offset: 0x007DF556
		public IDartChampionOwnerInteractTypeT AsIDartChampionOwnerInteractType()
		{
			return this.As<IDartChampionOwnerInteractTypeT>();
		}

		// Token: 0x0603A8CA RID: 239818 RVA: 0x007E135E File Offset: 0x007DF55E
		public static TDartInteractTypeUnion FromIDartChampionOwnerInteractType(IDartChampionOwnerInteractTypeT _idartchampionownerinteracttype)
		{
			return new TDartInteractTypeUnion
			{
				Type = TDartInteractType.IDartChampionOwnerInteractType,
				Value = _idartchampionownerinteracttype
			};
		}

		// Token: 0x0603A8CB RID: 239819 RVA: 0x007E1373 File Offset: 0x007DF573
		public IDartMachineInteractTypeT AsIDartMachineInteractType()
		{
			return this.As<IDartMachineInteractTypeT>();
		}

		// Token: 0x0603A8CC RID: 239820 RVA: 0x007E137B File Offset: 0x007DF57B
		public static TDartInteractTypeUnion FromIDartMachineInteractType(IDartMachineInteractTypeT _idartmachineinteracttype)
		{
			return new TDartInteractTypeUnion
			{
				Type = TDartInteractType.IDartMachineInteractType,
				Value = _idartmachineinteracttype
			};
		}

		// Token: 0x0603A8CD RID: 239821 RVA: 0x007E1390 File Offset: 0x007DF590
		public IDartPlayableRoleInteractTypeT AsIDartPlayableRoleInteractType()
		{
			return this.As<IDartPlayableRoleInteractTypeT>();
		}

		// Token: 0x0603A8CE RID: 239822 RVA: 0x007E1398 File Offset: 0x007DF598
		public static TDartInteractTypeUnion FromIDartPlayableRoleInteractType(IDartPlayableRoleInteractTypeT _idartplayableroleinteracttype)
		{
			return new TDartInteractTypeUnion
			{
				Type = TDartInteractType.IDartPlayableRoleInteractType,
				Value = _idartplayableroleinteracttype
			};
		}

		// Token: 0x0603A8CF RID: 239823 RVA: 0x007E13B0 File Offset: 0x007DF5B0
		public static int Pack(FlatBufferBuilder builder, TDartInteractTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TDartInteractType.IDartChampionOwnerInteractType:
				return IDartChampionOwnerInteractType.Pack(builder, _o.AsIDartChampionOwnerInteractType()).Value;
			case TDartInteractType.IDartMachineInteractType:
				return IDartMachineInteractType.Pack(builder, _o.AsIDartMachineInteractType()).Value;
			case TDartInteractType.IDartPlayableRoleInteractType:
				return IDartPlayableRoleInteractType.Pack(builder, _o.AsIDartPlayableRoleInteractType()).Value;
			default:
				return 0;
			}
		}
	}
}
