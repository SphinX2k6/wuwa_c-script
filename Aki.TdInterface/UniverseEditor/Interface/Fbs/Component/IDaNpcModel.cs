using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005072 RID: 20594
	public struct IDaNpcModel : IFlatbufferObject
	{
		// Token: 0x17009567 RID: 38247
		// (get) Token: 0x06021021 RID: 135201 RVA: 0x00496020 File Offset: 0x00494220
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021022 RID: 135202 RVA: 0x0049602D File Offset: 0x0049422D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021023 RID: 135203 RVA: 0x00496034 File Offset: 0x00494234
		public static IDaNpcModel GetRootAsIDaNpcModel(ByteBuffer _bb)
		{
			return IDaNpcModel.GetRootAsIDaNpcModel(_bb, default(IDaNpcModel));
		}

		// Token: 0x06021024 RID: 135204 RVA: 0x00496050 File Offset: 0x00494250
		public static IDaNpcModel GetRootAsIDaNpcModel(ByteBuffer _bb, IDaNpcModel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021025 RID: 135205 RVA: 0x0049606D File Offset: 0x0049426D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021026 RID: 135206 RVA: 0x0049607C File Offset: 0x0049427C
		public IDaNpcModel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009568 RID: 38248
		// (get) Token: 0x06021027 RID: 135207 RVA: 0x0049608C File Offset: 0x0049428C
		public ENpcModelType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcModelType.Mesh;
				}
				return (ENpcModelType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009569 RID: 38249
		// (get) Token: 0x06021028 RID: 135208 RVA: 0x004960C8 File Offset: 0x004942C8
		public string Da
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

		// Token: 0x06021029 RID: 135209 RVA: 0x004960FF File Offset: 0x004942FF
		public Span<byte> GetDaBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602102A RID: 135210 RVA: 0x0049610E File Offset: 0x0049430E
		public byte[] GetDaArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602102B RID: 135211 RVA: 0x0049611C File Offset: 0x0049431C
		public static Offset<IDaNpcModel> CreateIDaNpcModel(FlatBufferBuilder builder, ENpcModelType Type = ENpcModelType.Mesh, StringOffset DaOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IDaNpcModel.AddDa(builder, DaOffset);
			IDaNpcModel.AddType(builder, Type);
			return IDaNpcModel.EndIDaNpcModel(builder);
		}

		// Token: 0x0602102C RID: 135212 RVA: 0x00496139 File Offset: 0x00494339
		public static void StartIDaNpcModel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602102D RID: 135213 RVA: 0x00496142 File Offset: 0x00494342
		public static void AddType(FlatBufferBuilder builder, ENpcModelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602102E RID: 135214 RVA: 0x0049614D File Offset: 0x0049434D
		public static void AddDa(FlatBufferBuilder builder, StringOffset daOffset)
		{
			builder.AddOffset(1, daOffset.Value, 0);
		}

		// Token: 0x0602102F RID: 135215 RVA: 0x0049615D File Offset: 0x0049435D
		public static Offset<IDaNpcModel> EndIDaNpcModel(FlatBufferBuilder builder)
		{
			return new Offset<IDaNpcModel>(builder.EndTable());
		}

		// Token: 0x06021030 RID: 135216 RVA: 0x0049616C File Offset: 0x0049436C
		public IDaNpcModelT UnPack()
		{
			IDaNpcModelT daNpcModelT = new IDaNpcModelT();
			this.UnPackTo(daNpcModelT);
			return daNpcModelT;
		}

		// Token: 0x06021031 RID: 135217 RVA: 0x00496187 File Offset: 0x00494387
		public void UnPackTo(IDaNpcModelT _o)
		{
			_o.Type = this.Type;
			_o.Da = this.Da;
		}

		// Token: 0x06021032 RID: 135218 RVA: 0x004961A4 File Offset: 0x004943A4
		public static Offset<IDaNpcModel> Pack(FlatBufferBuilder builder, IDaNpcModelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDaNpcModel>);
			}
			StringOffset daOffset = (_o.Da == null) ? default(StringOffset) : builder.CreateString(_o.Da);
			return IDaNpcModel.CreateIDaNpcModel(builder, _o.Type, daOffset);
		}

		// Token: 0x0400E074 RID: 57460
		private Table __p;
	}
}
