using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200678A RID: 26506
	public struct IAddEntityDecoration : IFlatbufferObject
	{
		// Token: 0x1700C0B7 RID: 49335
		// (get) Token: 0x0602CF16 RID: 184086 RVA: 0x00624B62 File Offset: 0x00622D62
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602CF17 RID: 184087 RVA: 0x00624B6F File Offset: 0x00622D6F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602CF18 RID: 184088 RVA: 0x00624B78 File Offset: 0x00622D78
		public static IAddEntityDecoration GetRootAsIAddEntityDecoration(ByteBuffer _bb)
		{
			return IAddEntityDecoration.GetRootAsIAddEntityDecoration(_bb, default(IAddEntityDecoration));
		}

		// Token: 0x0602CF19 RID: 184089 RVA: 0x00624B94 File Offset: 0x00622D94
		public static IAddEntityDecoration GetRootAsIAddEntityDecoration(ByteBuffer _bb, IAddEntityDecoration obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602CF1A RID: 184090 RVA: 0x00624BB1 File Offset: 0x00622DB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602CF1B RID: 184091 RVA: 0x00624BC0 File Offset: 0x00622DC0
		public IAddEntityDecoration __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C0B8 RID: 49336
		// (get) Token: 0x0602CF1C RID: 184092 RVA: 0x00624BD0 File Offset: 0x00622DD0
		public EEntityDecorationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEntityDecorationType.Add;
				}
				return (EEntityDecorationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C0B9 RID: 49337
		// (get) Token: 0x0602CF1D RID: 184093 RVA: 0x00624C0C File Offset: 0x00622E0C
		public string DecorationId
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

		// Token: 0x0602CF1E RID: 184094 RVA: 0x00624C43 File Offset: 0x00622E43
		public Span<byte> GetDecorationIdBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602CF1F RID: 184095 RVA: 0x00624C52 File Offset: 0x00622E52
		public byte[] GetDecorationIdArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x0602CF20 RID: 184096 RVA: 0x00624C60 File Offset: 0x00622E60
		public static Offset<IAddEntityDecoration> CreateIAddEntityDecoration(FlatBufferBuilder builder, EEntityDecorationType Type = EEntityDecorationType.Add, StringOffset DecorationIdOffset = default(StringOffset))
		{
			builder.StartTable(2);
			IAddEntityDecoration.AddDecorationId(builder, DecorationIdOffset);
			IAddEntityDecoration.AddType(builder, Type);
			return IAddEntityDecoration.EndIAddEntityDecoration(builder);
		}

		// Token: 0x0602CF21 RID: 184097 RVA: 0x00624C7D File Offset: 0x00622E7D
		public static void StartIAddEntityDecoration(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602CF22 RID: 184098 RVA: 0x00624C86 File Offset: 0x00622E86
		public static void AddType(FlatBufferBuilder builder, EEntityDecorationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602CF23 RID: 184099 RVA: 0x00624C91 File Offset: 0x00622E91
		public static void AddDecorationId(FlatBufferBuilder builder, StringOffset decorationIdOffset)
		{
			builder.AddOffset(1, decorationIdOffset.Value, 0);
		}

		// Token: 0x0602CF24 RID: 184100 RVA: 0x00624CA1 File Offset: 0x00622EA1
		public static Offset<IAddEntityDecoration> EndIAddEntityDecoration(FlatBufferBuilder builder)
		{
			return new Offset<IAddEntityDecoration>(builder.EndTable());
		}

		// Token: 0x0602CF25 RID: 184101 RVA: 0x00624CB0 File Offset: 0x00622EB0
		public IAddEntityDecorationT UnPack()
		{
			IAddEntityDecorationT addEntityDecorationT = new IAddEntityDecorationT();
			this.UnPackTo(addEntityDecorationT);
			return addEntityDecorationT;
		}

		// Token: 0x0602CF26 RID: 184102 RVA: 0x00624CCB File Offset: 0x00622ECB
		public void UnPackTo(IAddEntityDecorationT _o)
		{
			_o.Type = this.Type;
			_o.DecorationId = this.DecorationId;
		}

		// Token: 0x0602CF27 RID: 184103 RVA: 0x00624CE8 File Offset: 0x00622EE8
		public static Offset<IAddEntityDecoration> Pack(FlatBufferBuilder builder, IAddEntityDecorationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAddEntityDecoration>);
			}
			StringOffset decorationIdOffset = (_o.DecorationId == null) ? default(StringOffset) : builder.CreateString(_o.DecorationId);
			return IAddEntityDecoration.CreateIAddEntityDecoration(builder, _o.Type, decorationIdOffset);
		}

		// Token: 0x040112FE RID: 70398
		private Table __p;
	}
}
