using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BAB RID: 27563
	public struct IDartGameplay : IFlatbufferObject
	{
		// Token: 0x1700CA37 RID: 51767
		// (get) Token: 0x0602F6F7 RID: 194295 RVA: 0x0067878E File Offset: 0x0067698E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F6F8 RID: 194296 RVA: 0x0067879B File Offset: 0x0067699B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F6F9 RID: 194297 RVA: 0x006787A4 File Offset: 0x006769A4
		public static IDartGameplay GetRootAsIDartGameplay(ByteBuffer _bb)
		{
			return IDartGameplay.GetRootAsIDartGameplay(_bb, default(IDartGameplay));
		}

		// Token: 0x0602F6FA RID: 194298 RVA: 0x006787C0 File Offset: 0x006769C0
		public static IDartGameplay GetRootAsIDartGameplay(ByteBuffer _bb, IDartGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F6FB RID: 194299 RVA: 0x006787DD File Offset: 0x006769DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F6FC RID: 194300 RVA: 0x006787EC File Offset: 0x006769EC
		public IDartGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CA38 RID: 51768
		// (get) Token: 0x0602F6FD RID: 194301 RVA: 0x006787FC File Offset: 0x006769FC
		public ESimpleGameplayType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESimpleGameplayType.Cipher;
				}
				return (ESimpleGameplayType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CA39 RID: 51769
		// (get) Token: 0x0602F6FE RID: 194302 RVA: 0x00678838 File Offset: 0x00676A38
		public int MachineEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CA3A RID: 51770
		// (get) Token: 0x0602F6FF RID: 194303 RVA: 0x00678874 File Offset: 0x00676A74
		public TDartInteractType InteractTypeType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TDartInteractType.NONE;
				}
				return (TDartInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F700 RID: 194304 RVA: 0x006788B0 File Offset: 0x00676AB0
		public TTable? InteractType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602F701 RID: 194305 RVA: 0x006788F8 File Offset: 0x00676AF8
		public IDartChampionOwnerInteractType InteractTypeAsIDartChampionOwnerInteractType()
		{
			return this.InteractType<IDartChampionOwnerInteractType>().Value;
		}

		// Token: 0x0602F702 RID: 194306 RVA: 0x00678914 File Offset: 0x00676B14
		public IDartMachineInteractType InteractTypeAsIDartMachineInteractType()
		{
			return this.InteractType<IDartMachineInteractType>().Value;
		}

		// Token: 0x0602F703 RID: 194307 RVA: 0x00678930 File Offset: 0x00676B30
		public IDartPlayableRoleInteractType InteractTypeAsIDartPlayableRoleInteractType()
		{
			return this.InteractType<IDartPlayableRoleInteractType>().Value;
		}

		// Token: 0x0602F704 RID: 194308 RVA: 0x0067894B File Offset: 0x00676B4B
		public static Offset<IDartGameplay> CreateIDartGameplay(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int MachineEntityId = 0, TDartInteractType InteractType_type = TDartInteractType.NONE, int InteractTypeOffset = 0)
		{
			builder.StartTable(4);
			IDartGameplay.AddInteractType(builder, InteractTypeOffset);
			IDartGameplay.AddMachineEntityId(builder, MachineEntityId);
			IDartGameplay.AddInteractTypeType(builder, InteractType_type);
			IDartGameplay.AddType(builder, Type);
			return IDartGameplay.EndIDartGameplay(builder);
		}

		// Token: 0x0602F705 RID: 194309 RVA: 0x00678977 File Offset: 0x00676B77
		public static void StartIDartGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602F706 RID: 194310 RVA: 0x00678980 File Offset: 0x00676B80
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602F707 RID: 194311 RVA: 0x0067898B File Offset: 0x00676B8B
		public static void AddMachineEntityId(FlatBufferBuilder builder, int machineEntityId)
		{
			builder.AddInt(1, machineEntityId, 0);
		}

		// Token: 0x0602F708 RID: 194312 RVA: 0x00678996 File Offset: 0x00676B96
		public static void AddInteractTypeType(FlatBufferBuilder builder, TDartInteractType interactTypeType)
		{
			builder.AddByte(2, (byte)interactTypeType, 0);
		}

		// Token: 0x0602F709 RID: 194313 RVA: 0x006789A1 File Offset: 0x00676BA1
		public static void AddInteractType(FlatBufferBuilder builder, int interactTypeOffset)
		{
			builder.AddOffset(3, interactTypeOffset, 0);
		}

		// Token: 0x0602F70A RID: 194314 RVA: 0x006789AC File Offset: 0x00676BAC
		public static Offset<IDartGameplay> EndIDartGameplay(FlatBufferBuilder builder)
		{
			return new Offset<IDartGameplay>(builder.EndTable());
		}

		// Token: 0x0602F70B RID: 194315 RVA: 0x006789BC File Offset: 0x00676BBC
		public IDartGameplayT UnPack()
		{
			IDartGameplayT dartGameplayT = new IDartGameplayT();
			this.UnPackTo(dartGameplayT);
			return dartGameplayT;
		}

		// Token: 0x0602F70C RID: 194316 RVA: 0x006789D8 File Offset: 0x00676BD8
		public void UnPackTo(IDartGameplayT _o)
		{
			_o.Type = this.Type;
			_o.MachineEntityId = this.MachineEntityId;
			_o.InteractType = new TDartInteractTypeUnion();
			_o.InteractType.Type = this.InteractTypeType;
			switch (this.InteractTypeType)
			{
			case TDartInteractType.IDartChampionOwnerInteractType:
				_o.InteractType.Value = ((this.InteractType<IDartChampionOwnerInteractType>() != null) ? this.InteractType<IDartChampionOwnerInteractType>().Value.UnPack() : null);
				return;
			case TDartInteractType.IDartMachineInteractType:
				_o.InteractType.Value = ((this.InteractType<IDartMachineInteractType>() != null) ? this.InteractType<IDartMachineInteractType>().Value.UnPack() : null);
				return;
			case TDartInteractType.IDartPlayableRoleInteractType:
				_o.InteractType.Value = ((this.InteractType<IDartPlayableRoleInteractType>() != null) ? this.InteractType<IDartPlayableRoleInteractType>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x0602F70D RID: 194317 RVA: 0x00678AD8 File Offset: 0x00676CD8
		public static Offset<IDartGameplay> Pack(FlatBufferBuilder builder, IDartGameplayT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDartGameplay>);
			}
			TDartInteractType interactType_type = (_o.InteractType == null) ? TDartInteractType.NONE : _o.InteractType.Type;
			int interactTypeOffset = (_o.InteractType == null) ? 0 : TDartInteractTypeUnion.Pack(builder, _o.InteractType);
			return IDartGameplay.CreateIDartGameplay(builder, _o.Type, _o.MachineEntityId, interactType_type, interactTypeOffset);
		}

		// Token: 0x0401199D RID: 72093
		private Table __p;
	}
}
