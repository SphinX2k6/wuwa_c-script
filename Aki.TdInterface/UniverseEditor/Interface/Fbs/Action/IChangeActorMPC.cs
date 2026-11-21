using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006934 RID: 26932
	public struct IChangeActorMPC : IFlatbufferObject
	{
		// Token: 0x1700C647 RID: 50759
		// (get) Token: 0x0602E28A RID: 189066 RVA: 0x0064E90F File Offset: 0x0064CB0F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E28B RID: 189067 RVA: 0x0064E91C File Offset: 0x0064CB1C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E28C RID: 189068 RVA: 0x0064E924 File Offset: 0x0064CB24
		public static IChangeActorMPC GetRootAsIChangeActorMPC(ByteBuffer _bb)
		{
			return IChangeActorMPC.GetRootAsIChangeActorMPC(_bb, default(IChangeActorMPC));
		}

		// Token: 0x0602E28D RID: 189069 RVA: 0x0064E940 File Offset: 0x0064CB40
		public static IChangeActorMPC GetRootAsIChangeActorMPC(ByteBuffer _bb, IChangeActorMPC obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E28E RID: 189070 RVA: 0x0064E95D File Offset: 0x0064CB5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E28F RID: 189071 RVA: 0x0064E96C File Offset: 0x0064CB6C
		public IChangeActorMPC __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C648 RID: 50760
		// (get) Token: 0x0602E290 RID: 189072 RVA: 0x0064E97C File Offset: 0x0064CB7C
		public EModifyActorMaterialType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EModifyActorMaterialType.ChangeMaterialData;
				}
				return (EModifyActorMaterialType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C649 RID: 50761
		// (get) Token: 0x0602E291 RID: 189073 RVA: 0x0064E9B8 File Offset: 0x0064CBB8
		public string MpcData
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E292 RID: 189074 RVA: 0x0064E9EF File Offset: 0x0064CBEF
		public Span<byte> GetMpcDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602E293 RID: 189075 RVA: 0x0064E9FE File Offset: 0x0064CBFE
		public byte[] GetMpcDataArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602E294 RID: 189076 RVA: 0x0064EA0C File Offset: 0x0064CC0C
		public static Offset<IChangeActorMPC> CreateIChangeActorMPC(FlatBufferBuilder builder, EModifyActorMaterialType Type = EModifyActorMaterialType.ChangeMaterialData, StringOffset MpcDataOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IChangeActorMPC.AddMpcData(builder, MpcDataOffset);
			IChangeActorMPC.AddType(builder, Type);
			return IChangeActorMPC.EndIChangeActorMPC(builder);
		}

		// Token: 0x0602E295 RID: 189077 RVA: 0x0064EA29 File Offset: 0x0064CC29
		public static void StartIChangeActorMPC(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602E296 RID: 189078 RVA: 0x0064EA32 File Offset: 0x0064CC32
		public static void AddType(FlatBufferBuilder builder, EModifyActorMaterialType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602E297 RID: 189079 RVA: 0x0064EA3D File Offset: 0x0064CC3D
		public static void AddMpcData(FlatBufferBuilder builder, StringOffset mpcDataOffset)
		{
			builder.AddOffset(1, mpcDataOffset.Value, 0);
		}

		// Token: 0x0602E298 RID: 189080 RVA: 0x0064EA4D File Offset: 0x0064CC4D
		public static Offset<IChangeActorMPC> EndIChangeActorMPC(FlatBufferBuilder builder)
		{
			return new Offset<IChangeActorMPC>(builder.EndTable());
		}

		// Token: 0x0602E299 RID: 189081 RVA: 0x0064EA5C File Offset: 0x0064CC5C
		public IChangeActorMPCT UnPack()
		{
			IChangeActorMPCT changeActorMPCT = new IChangeActorMPCT();
			this.UnPackTo(changeActorMPCT);
			return changeActorMPCT;
		}

		// Token: 0x0602E29A RID: 189082 RVA: 0x0064EA77 File Offset: 0x0064CC77
		public void UnPackTo(IChangeActorMPCT _o)
		{
			_o.Type = this.Type;
			_o.MpcData = this.MpcData;
		}

		// Token: 0x0602E29B RID: 189083 RVA: 0x0064EA94 File Offset: 0x0064CC94
		public static Offset<IChangeActorMPC> Pack(FlatBufferBuilder builder, IChangeActorMPCT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeActorMPC>);
			}
			StringOffset mpcDataOffset = (_o.MpcData == null) ? default(StringOffset) : builder.CreateString(_o.MpcData);
			return IChangeActorMPC.CreateIChangeActorMPC(builder, _o.Type, mpcDataOffset);
		}

		// Token: 0x04011680 RID: 71296
		private Table __p;
	}
}
