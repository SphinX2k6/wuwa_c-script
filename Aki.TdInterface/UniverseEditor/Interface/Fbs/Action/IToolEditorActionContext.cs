using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200741E RID: 29726
	public struct IToolEditorActionContext : IFlatbufferObject
	{
		// Token: 0x1700E1B5 RID: 57781
		// (get) Token: 0x06035FF3 RID: 221171 RVA: 0x00758806 File Offset: 0x00756A06
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035FF4 RID: 221172 RVA: 0x00758813 File Offset: 0x00756A13
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035FF5 RID: 221173 RVA: 0x0075881C File Offset: 0x00756A1C
		public static IToolEditorActionContext GetRootAsIToolEditorActionContext(ByteBuffer _bb)
		{
			return IToolEditorActionContext.GetRootAsIToolEditorActionContext(_bb, default(IToolEditorActionContext));
		}

		// Token: 0x06035FF6 RID: 221174 RVA: 0x00758838 File Offset: 0x00756A38
		public static IToolEditorActionContext GetRootAsIToolEditorActionContext(ByteBuffer _bb, IToolEditorActionContext obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035FF7 RID: 221175 RVA: 0x00758855 File Offset: 0x00756A55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035FF8 RID: 221176 RVA: 0x00758864 File Offset: 0x00756A64
		public IToolEditorActionContext __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E1B6 RID: 57782
		// (get) Token: 0x06035FF9 RID: 221177 RVA: 0x00758874 File Offset: 0x00756A74
		public string Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035FFA RID: 221178 RVA: 0x007588AB File Offset: 0x00756AAB
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06035FFB RID: 221179 RVA: 0x007588BA File Offset: 0x00756ABA
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x06035FFC RID: 221180 RVA: 0x007588C8 File Offset: 0x00756AC8
		public static Offset<IToolEditorActionContext> CreateIToolEditorActionContext(FlatBufferBuilder builder, StringOffset TypeOffset = default(StringOffset))
		{
			builder.StartTable(1);
			IToolEditorActionContext.AddType(builder, TypeOffset);
			return IToolEditorActionContext.EndIToolEditorActionContext(builder);
		}

		// Token: 0x06035FFD RID: 221181 RVA: 0x007588DE File Offset: 0x00756ADE
		public static void StartIToolEditorActionContext(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035FFE RID: 221182 RVA: 0x007588E7 File Offset: 0x00756AE7
		public static void AddType(FlatBufferBuilder builder, StringOffset typeOffset)
		{
			builder.AddOffset(0, typeOffset.Value, 0);
		}

		// Token: 0x06035FFF RID: 221183 RVA: 0x007588F7 File Offset: 0x00756AF7
		public static Offset<IToolEditorActionContext> EndIToolEditorActionContext(FlatBufferBuilder builder)
		{
			return new Offset<IToolEditorActionContext>(builder.EndTable());
		}

		// Token: 0x06036000 RID: 221184 RVA: 0x00758904 File Offset: 0x00756B04
		public IToolEditorActionContextT UnPack()
		{
			IToolEditorActionContextT toolEditorActionContextT = new IToolEditorActionContextT();
			this.UnPackTo(toolEditorActionContextT);
			return toolEditorActionContextT;
		}

		// Token: 0x06036001 RID: 221185 RVA: 0x0075891F File Offset: 0x00756B1F
		public void UnPackTo(IToolEditorActionContextT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036002 RID: 221186 RVA: 0x00758930 File Offset: 0x00756B30
		public static Offset<IToolEditorActionContext> Pack(FlatBufferBuilder builder, IToolEditorActionContextT _o)
		{
			if (_o == null)
			{
				return default(Offset<IToolEditorActionContext>);
			}
			StringOffset typeOffset = (_o.Type == null) ? default(StringOffset) : builder.CreateString(_o.Type);
			return IToolEditorActionContext.CreateIToolEditorActionContext(builder, typeOffset);
		}

		// Token: 0x04012294 RID: 74388
		private Table __p;
	}
}
