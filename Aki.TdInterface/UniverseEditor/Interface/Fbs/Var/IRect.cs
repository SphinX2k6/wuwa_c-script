using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003EBC RID: 16060
	public struct IRect : IFlatbufferObject
	{
		// Token: 0x17006CBE RID: 27838
		// (get) Token: 0x06015BB8 RID: 89016 RVA: 0x00320CDA File Offset: 0x0031EEDA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015BB9 RID: 89017 RVA: 0x00320CE7 File Offset: 0x0031EEE7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015BBA RID: 89018 RVA: 0x00320CF0 File Offset: 0x0031EEF0
		public static IRect GetRootAsIRect(ByteBuffer _bb)
		{
			return IRect.GetRootAsIRect(_bb, default(IRect));
		}

		// Token: 0x06015BBB RID: 89019 RVA: 0x00320D0C File Offset: 0x0031EF0C
		public static IRect GetRootAsIRect(ByteBuffer _bb, IRect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015BBC RID: 89020 RVA: 0x00320D29 File Offset: 0x0031EF29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015BBD RID: 89021 RVA: 0x00320D38 File Offset: 0x0031EF38
		public IRect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006CBF RID: 27839
		// (get) Token: 0x06015BBE RID: 89022 RVA: 0x00320D48 File Offset: 0x0031EF48
		public IVector2? Min
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVector2?(default(IVector2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006CC0 RID: 27840
		// (get) Token: 0x06015BBF RID: 89023 RVA: 0x00320DA8 File Offset: 0x0031EFA8
		public IVector2? Max
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVector2?(default(IVector2).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06015BC0 RID: 89024 RVA: 0x00320E05 File Offset: 0x0031F005
		public static Offset<IRect> CreateIRect(FlatBufferBuilder builder, Offset<IVector2> MinOffset = default(Offset<IVector2>), Offset<IVector2> MaxOffset = default(Offset<IVector2>))
		{
			builder.StartTable(2);
			IRect.AddMax(builder, MaxOffset);
			IRect.AddMin(builder, MinOffset);
			return IRect.EndIRect(builder);
		}

		// Token: 0x06015BC1 RID: 89025 RVA: 0x00320E22 File Offset: 0x0031F022
		public static void StartIRect(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06015BC2 RID: 89026 RVA: 0x00320E2B File Offset: 0x0031F02B
		public static void AddMin(FlatBufferBuilder builder, Offset<IVector2> minOffset)
		{
			builder.AddOffset(0, minOffset.Value, 0);
		}

		// Token: 0x06015BC3 RID: 89027 RVA: 0x00320E3B File Offset: 0x0031F03B
		public static void AddMax(FlatBufferBuilder builder, Offset<IVector2> maxOffset)
		{
			builder.AddOffset(1, maxOffset.Value, 0);
		}

		// Token: 0x06015BC4 RID: 89028 RVA: 0x00320E4B File Offset: 0x0031F04B
		public static Offset<IRect> EndIRect(FlatBufferBuilder builder)
		{
			return new Offset<IRect>(builder.EndTable());
		}

		// Token: 0x06015BC5 RID: 89029 RVA: 0x00320E58 File Offset: 0x0031F058
		public IRectT UnPack()
		{
			IRectT rectT = new IRectT();
			this.UnPackTo(rectT);
			return rectT;
		}

		// Token: 0x06015BC6 RID: 89030 RVA: 0x00320E74 File Offset: 0x0031F074
		public void UnPackTo(IRectT _o)
		{
			_o.Min = ((this.Min != null) ? this.Min.Value.UnPack() : null);
			_o.Max = ((this.Max != null) ? this.Max.Value.UnPack() : null);
		}

		// Token: 0x06015BC7 RID: 89031 RVA: 0x00320EE0 File Offset: 0x0031F0E0
		public static Offset<IRect> Pack(FlatBufferBuilder builder, IRectT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRect>);
			}
			Offset<IVector2> minOffset = (_o.Min == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.Min);
			Offset<IVector2> maxOffset = (_o.Max == null) ? default(Offset<IVector2>) : IVector2.Pack(builder, _o.Max);
			return IRect.CreateIRect(builder, minOffset, maxOffset);
		}

		// Token: 0x0400B8C5 RID: 47301
		private Table __p;
	}
}
