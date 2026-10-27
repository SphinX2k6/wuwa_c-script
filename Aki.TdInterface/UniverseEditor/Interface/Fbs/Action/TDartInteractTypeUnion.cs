using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076A2 RID: 30370
	public class TDartInteractTypeUnion
	{
		// Token: 0x1700E605 RID: 58885
		// (get) Token: 0x06037420 RID: 226336 RVA: 0x0077D1B8 File Offset: 0x0077B3B8
		// (set) Token: 0x06037421 RID: 226337 RVA: 0x0077D1C0 File Offset: 0x0077B3C0
		public TDartInteractType Type { get; set; }

		// Token: 0x1700E606 RID: 58886
		// (get) Token: 0x06037422 RID: 226338 RVA: 0x0077D1C9 File Offset: 0x0077B3C9
		// (set) Token: 0x06037423 RID: 226339 RVA: 0x0077D1D1 File Offset: 0x0077B3D1
		public object Value { get; set; }

		// Token: 0x06037424 RID: 226340 RVA: 0x0077D1DA File Offset: 0x0077B3DA
		public TDartInteractTypeUnion()
		{
			this.Type = TDartInteractType.NONE;
			this.Value = null;
		}

		// Token: 0x06037425 RID: 226341 RVA: 0x0077D1F0 File Offset: 0x0077B3F0
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037426 RID: 226342 RVA: 0x0077D202 File Offset: 0x0077B402
		public IDartChampionOwnerInteractTypeT AsIDartChampionOwnerInteractType()
		{
			return this.As<IDartChampionOwnerInteractTypeT>();
		}

		// Token: 0x06037427 RID: 226343 RVA: 0x0077D20A File Offset: 0x0077B40A
		public static TDartInteractTypeUnion FromIDartChampionOwnerInteractType(IDartChampionOwnerInteractTypeT _idartchampionownerinteracttype)
		{
			return new TDartInteractTypeUnion
			{
				Type = TDartInteractType.IDartChampionOwnerInteractType,
				Value = _idartchampionownerinteracttype
			};
		}

		// Token: 0x06037428 RID: 226344 RVA: 0x0077D21F File Offset: 0x0077B41F
		public IDartMachineInteractTypeT AsIDartMachineInteractType()
		{
			return this.As<IDartMachineInteractTypeT>();
		}

		// Token: 0x06037429 RID: 226345 RVA: 0x0077D227 File Offset: 0x0077B427
		public static TDartInteractTypeUnion FromIDartMachineInteractType(IDartMachineInteractTypeT _idartmachineinteracttype)
		{
			return new TDartInteractTypeUnion
			{
				Type = TDartInteractType.IDartMachineInteractType,
				Value = _idartmachineinteracttype
			};
		}

		// Token: 0x0603742A RID: 226346 RVA: 0x0077D23C File Offset: 0x0077B43C
		public IDartPlayableRoleInteractTypeT AsIDartPlayableRoleInteractType()
		{
			return this.As<IDartPlayableRoleInteractTypeT>();
		}

		// Token: 0x0603742B RID: 226347 RVA: 0x0077D244 File Offset: 0x0077B444
		public static TDartInteractTypeUnion FromIDartPlayableRoleInteractType(IDartPlayableRoleInteractTypeT _idartplayableroleinteracttype)
		{
			return new TDartInteractTypeUnion
			{
				Type = TDartInteractType.IDartPlayableRoleInteractType,
				Value = _idartplayableroleinteracttype
			};
		}

		// Token: 0x0603742C RID: 226348 RVA: 0x0077D25C File Offset: 0x0077B45C
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
