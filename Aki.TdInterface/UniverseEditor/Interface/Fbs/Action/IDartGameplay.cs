using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200653A RID: 25914
	public struct IDartGameplay : IFlatbufferObject
	{
		// Token: 0x1700C0A0 RID: 49312
		// (get) Token: 0x0602CF43 RID: 184131 RVA: 0x0062C0E2 File Offset: 0x0062A2E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CF44 RID: 184132 RVA: 0x0062C0EF File Offset: 0x0062A2EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CF45 RID: 184133 RVA: 0x0062C0F8 File Offset: 0x0062A2F8
		public static IDartGameplay GetRootAsIDartGameplay(ByteBuffer _bb)
		{
			return IDartGameplay.GetRootAsIDartGameplay(_bb, default(IDartGameplay));
		}

		// Token: 0x0602CF46 RID: 184134 RVA: 0x0062C114 File Offset: 0x0062A314
		public static IDartGameplay GetRootAsIDartGameplay(ByteBuffer _bb, IDartGameplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CF47 RID: 184135 RVA: 0x0062C131 File Offset: 0x0062A331
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CF48 RID: 184136 RVA: 0x0062C140 File Offset: 0x0062A340
		public IDartGameplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0A1 RID: 49313
		// (get) Token: 0x0602CF49 RID: 184137 RVA: 0x0062C150 File Offset: 0x0062A350
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

		// Token: 0x1700C0A2 RID: 49314
		// (get) Token: 0x0602CF4A RID: 184138 RVA: 0x0062C18C File Offset: 0x0062A38C
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

		// Token: 0x1700C0A3 RID: 49315
		// (get) Token: 0x0602CF4B RID: 184139 RVA: 0x0062C1C8 File Offset: 0x0062A3C8
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

		// Token: 0x0602CF4C RID: 184140 RVA: 0x0062C204 File Offset: 0x0062A404
		public TTable? InteractType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602CF4D RID: 184141 RVA: 0x0062C24C File Offset: 0x0062A44C
		public IDartChampionOwnerInteractType InteractTypeAsIDartChampionOwnerInteractType()
		{
			return this.InteractType<IDartChampionOwnerInteractType>().Value;
		}

		// Token: 0x0602CF4E RID: 184142 RVA: 0x0062C268 File Offset: 0x0062A468
		public IDartMachineInteractType InteractTypeAsIDartMachineInteractType()
		{
			return this.InteractType<IDartMachineInteractType>().Value;
		}

		// Token: 0x0602CF4F RID: 184143 RVA: 0x0062C284 File Offset: 0x0062A484
		public IDartPlayableRoleInteractType InteractTypeAsIDartPlayableRoleInteractType()
		{
			return this.InteractType<IDartPlayableRoleInteractType>().Value;
		}

		// Token: 0x0602CF50 RID: 184144 RVA: 0x0062C29F File Offset: 0x0062A49F
		public static Offset<IDartGameplay> CreateIDartGameplay(FlatBufferBuilder builder, ESimpleGameplayType Type = ESimpleGameplayType.Cipher, int MachineEntityId = 0, TDartInteractType InteractType_type = TDartInteractType.NONE, int InteractTypeOffset = 0)
		{
			builder.StartTable(4);
			IDartGameplay.AddInteractType(builder, InteractTypeOffset);
			IDartGameplay.AddMachineEntityId(builder, MachineEntityId);
			IDartGameplay.AddInteractTypeType(builder, InteractType_type);
			IDartGameplay.AddType(builder, Type);
			return IDartGameplay.EndIDartGameplay(builder);
		}

		// Token: 0x0602CF51 RID: 184145 RVA: 0x0062C2CB File Offset: 0x0062A4CB
		public static void StartIDartGameplay(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602CF52 RID: 184146 RVA: 0x0062C2D4 File Offset: 0x0062A4D4
		public static void AddType(FlatBufferBuilder builder, ESimpleGameplayType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CF53 RID: 184147 RVA: 0x0062C2DF File Offset: 0x0062A4DF
		public static void AddMachineEntityId(FlatBufferBuilder builder, int machineEntityId)
		{
			builder.AddInt(1, machineEntityId, 0);
		}

		// Token: 0x0602CF54 RID: 184148 RVA: 0x0062C2EA File Offset: 0x0062A4EA
		public static void AddInteractTypeType(FlatBufferBuilder builder, TDartInteractType interactTypeType)
		{
			builder.AddByte(2, (byte)interactTypeType, 0);
		}

		// Token: 0x0602CF55 RID: 184149 RVA: 0x0062C2F5 File Offset: 0x0062A4F5
		public static void AddInteractType(FlatBufferBuilder builder, int interactTypeOffset)
		{
			builder.AddOffset(3, interactTypeOffset, 0);
		}

		// Token: 0x0602CF56 RID: 184150 RVA: 0x0062C300 File Offset: 0x0062A500
		public static Offset<IDartGameplay> EndIDartGameplay(FlatBufferBuilder builder)
		{
			return new Offset<IDartGameplay>(builder.EndTable());
		}

		// Token: 0x0602CF57 RID: 184151 RVA: 0x0062C310 File Offset: 0x0062A510
		public IDartGameplayT UnPack()
		{
			IDartGameplayT dartGameplayT = new IDartGameplayT();
			this.UnPackTo(dartGameplayT);
			return dartGameplayT;
		}

		// Token: 0x0602CF58 RID: 184152 RVA: 0x0062C32C File Offset: 0x0062A52C
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

		// Token: 0x0602CF59 RID: 184153 RVA: 0x0062C42C File Offset: 0x0062A62C
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

		// Token: 0x04010B81 RID: 68481
		private Table __p;
	}
}
