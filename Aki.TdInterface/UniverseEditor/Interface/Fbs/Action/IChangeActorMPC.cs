using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020062C3 RID: 25283
	public struct IChangeActorMPC : IFlatbufferObject
	{
		// Token: 0x1700BCBD RID: 48317
		// (get) Token: 0x0602BB21 RID: 178977 RVA: 0x00603903 File Offset: 0x00601B03
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BB22 RID: 178978 RVA: 0x00603910 File Offset: 0x00601B10
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BB23 RID: 178979 RVA: 0x00603918 File Offset: 0x00601B18
		public static IChangeActorMPC GetRootAsIChangeActorMPC(ByteBuffer _bb)
		{
			return IChangeActorMPC.GetRootAsIChangeActorMPC(_bb, default(IChangeActorMPC));
		}

		// Token: 0x0602BB24 RID: 178980 RVA: 0x00603934 File Offset: 0x00601B34
		public static IChangeActorMPC GetRootAsIChangeActorMPC(ByteBuffer _bb, IChangeActorMPC obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BB25 RID: 178981 RVA: 0x00603951 File Offset: 0x00601B51
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BB26 RID: 178982 RVA: 0x00603960 File Offset: 0x00601B60
		public IChangeActorMPC __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCBE RID: 48318
		// (get) Token: 0x0602BB27 RID: 178983 RVA: 0x00603970 File Offset: 0x00601B70
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

		// Token: 0x1700BCBF RID: 48319
		// (get) Token: 0x0602BB28 RID: 178984 RVA: 0x006039AC File Offset: 0x00601BAC
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

		// Token: 0x0602BB29 RID: 178985 RVA: 0x006039E3 File Offset: 0x00601BE3
		public Span<byte> GetMpcDataBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602BB2A RID: 178986 RVA: 0x006039F2 File Offset: 0x00601BF2
		public byte[] GetMpcDataArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602BB2B RID: 178987 RVA: 0x00603A00 File Offset: 0x00601C00
		public static Offset<IChangeActorMPC> CreateIChangeActorMPC(FlatBufferBuilder builder, EModifyActorMaterialType Type = EModifyActorMaterialType.ChangeMaterialData, StringOffset MpcDataOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IChangeActorMPC.AddMpcData(builder, MpcDataOffset);
			IChangeActorMPC.AddType(builder, Type);
			return IChangeActorMPC.EndIChangeActorMPC(builder);
		}

		// Token: 0x0602BB2C RID: 178988 RVA: 0x00603A1D File Offset: 0x00601C1D
		public static void StartIChangeActorMPC(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BB2D RID: 178989 RVA: 0x00603A26 File Offset: 0x00601C26
		public static void AddType(FlatBufferBuilder builder, EModifyActorMaterialType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602BB2E RID: 178990 RVA: 0x00603A31 File Offset: 0x00601C31
		public static void AddMpcData(FlatBufferBuilder builder, StringOffset mpcDataOffset)
		{
			builder.AddOffset(1, mpcDataOffset.Value, 0);
		}

		// Token: 0x0602BB2F RID: 178991 RVA: 0x00603A41 File Offset: 0x00601C41
		public static Offset<IChangeActorMPC> EndIChangeActorMPC(FlatBufferBuilder builder)
		{
			return new Offset<IChangeActorMPC>(builder.EndTable());
		}

		// Token: 0x0602BB30 RID: 178992 RVA: 0x00603A50 File Offset: 0x00601C50
		public IChangeActorMPCT UnPack()
		{
			IChangeActorMPCT changeActorMPCT = new IChangeActorMPCT();
			this.UnPackTo(changeActorMPCT);
			return changeActorMPCT;
		}

		// Token: 0x0602BB31 RID: 178993 RVA: 0x00603A6B File Offset: 0x00601C6B
		public void UnPackTo(IChangeActorMPCT _o)
		{
			_o.Type = this.Type;
			_o.MpcData = this.MpcData;
		}

		// Token: 0x0602BB32 RID: 178994 RVA: 0x00603A88 File Offset: 0x00601C88
		public static Offset<IChangeActorMPC> Pack(FlatBufferBuilder builder, IChangeActorMPCT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChangeActorMPC>);
			}
			StringOffset mpcDataOffset = (_o.MpcData == null) ? default(StringOffset) : builder.CreateString(_o.MpcData);
			return IChangeActorMPC.CreateIChangeActorMPC(builder, _o.Type, mpcDataOffset);
		}

		// Token: 0x0401086A RID: 67690
		private Table __p;
	}
}
