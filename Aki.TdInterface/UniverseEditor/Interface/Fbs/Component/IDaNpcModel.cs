using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055D4 RID: 21972
	public struct IDaNpcModel : IFlatbufferObject
	{
		// Token: 0x17009D4D RID: 40269
		// (get) Token: 0x06022F5B RID: 143195 RVA: 0x004CFCD4 File Offset: 0x004CDED4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022F5C RID: 143196 RVA: 0x004CFCE1 File Offset: 0x004CDEE1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022F5D RID: 143197 RVA: 0x004CFCE8 File Offset: 0x004CDEE8
		public static IDaNpcModel GetRootAsIDaNpcModel(ByteBuffer _bb)
		{
			return IDaNpcModel.GetRootAsIDaNpcModel(_bb, default(IDaNpcModel));
		}

		// Token: 0x06022F5E RID: 143198 RVA: 0x004CFD04 File Offset: 0x004CDF04
		public static IDaNpcModel GetRootAsIDaNpcModel(ByteBuffer _bb, IDaNpcModel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022F5F RID: 143199 RVA: 0x004CFD21 File Offset: 0x004CDF21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022F60 RID: 143200 RVA: 0x004CFD30 File Offset: 0x004CDF30
		public IDaNpcModel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D4E RID: 40270
		// (get) Token: 0x06022F61 RID: 143201 RVA: 0x004CFD40 File Offset: 0x004CDF40
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

		// Token: 0x17009D4F RID: 40271
		// (get) Token: 0x06022F62 RID: 143202 RVA: 0x004CFD7C File Offset: 0x004CDF7C
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

		// Token: 0x06022F63 RID: 143203 RVA: 0x004CFDB3 File Offset: 0x004CDFB3
		public Span<byte> GetDaBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06022F64 RID: 143204 RVA: 0x004CFDC2 File Offset: 0x004CDFC2
		public byte[] GetDaArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x06022F65 RID: 143205 RVA: 0x004CFDD0 File Offset: 0x004CDFD0
		public static Offset<IDaNpcModel> CreateIDaNpcModel(FlatBufferBuilder builder, ENpcModelType Type = ENpcModelType.Mesh, StringOffset DaOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IDaNpcModel.AddDa(builder, DaOffset);
			IDaNpcModel.AddType(builder, Type);
			return IDaNpcModel.EndIDaNpcModel(builder);
		}

		// Token: 0x06022F66 RID: 143206 RVA: 0x004CFDED File Offset: 0x004CDFED
		public static void StartIDaNpcModel(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06022F67 RID: 143207 RVA: 0x004CFDF6 File Offset: 0x004CDFF6
		public static void AddType(FlatBufferBuilder builder, ENpcModelType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022F68 RID: 143208 RVA: 0x004CFE01 File Offset: 0x004CE001
		public static void AddDa(FlatBufferBuilder builder, StringOffset daOffset)
		{
			builder.AddOffset(1, daOffset.Value, 0);
		}

		// Token: 0x06022F69 RID: 143209 RVA: 0x004CFE11 File Offset: 0x004CE011
		public static Offset<IDaNpcModel> EndIDaNpcModel(FlatBufferBuilder builder)
		{
			return new Offset<IDaNpcModel>(builder.EndTable());
		}

		// Token: 0x06022F6A RID: 143210 RVA: 0x004CFE20 File Offset: 0x004CE020
		public IDaNpcModelT UnPack()
		{
			IDaNpcModelT daNpcModelT = new IDaNpcModelT();
			this.UnPackTo(daNpcModelT);
			return daNpcModelT;
		}

		// Token: 0x06022F6B RID: 143211 RVA: 0x004CFE3B File Offset: 0x004CE03B
		public void UnPackTo(IDaNpcModelT _o)
		{
			_o.Type = this.Type;
			_o.Da = this.Da;
		}

		// Token: 0x06022F6C RID: 143212 RVA: 0x004CFE58 File Offset: 0x004CE058
		public static Offset<IDaNpcModel> Pack(FlatBufferBuilder builder, IDaNpcModelT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDaNpcModel>);
			}
			StringOffset daOffset = (_o.Da == null) ? default(StringOffset) : builder.CreateString(_o.Da);
			return IDaNpcModel.CreateIDaNpcModel(builder, _o.Type, daOffset);
		}

		// Token: 0x0400EC6D RID: 60525
		private Table __p;
	}
}
