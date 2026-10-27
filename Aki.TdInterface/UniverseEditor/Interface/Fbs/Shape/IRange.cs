using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003C2B RID: 15403
	public struct IRange : IFlatbufferObject
	{
		// Token: 0x17006A0E RID: 27150
		// (get) Token: 0x06015427 RID: 87079 RVA: 0x00313EC0 File Offset: 0x003120C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015428 RID: 87080 RVA: 0x00313ECD File Offset: 0x003120CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015429 RID: 87081 RVA: 0x00313ED4 File Offset: 0x003120D4
		public static IRange GetRootAsIRange(ByteBuffer _bb)
		{
			return IRange.GetRootAsIRange(_bb, default(IRange));
		}

		// Token: 0x0601542A RID: 87082 RVA: 0x00313EF0 File Offset: 0x003120F0
		public static IRange GetRootAsIRange(ByteBuffer _bb, IRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601542B RID: 87083 RVA: 0x00313F0D File Offset: 0x0031210D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601542C RID: 87084 RVA: 0x00313F1C File Offset: 0x0031211C
		public IRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006A0F RID: 27151
		// (get) Token: 0x0601542D RID: 87085 RVA: 0x00313F2C File Offset: 0x0031212C
		public ERangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ERangeType.CircleRange;
				}
				return (ERangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601542E RID: 87086 RVA: 0x00313F68 File Offset: 0x00312168
		public static Offset<IRange> CreateIRange(FlatBufferBuilder builder, ERangeType Type = ERangeType.CircleRange)
		{
			builder.StartTable(1);
			IRange.AddType(builder, Type);
			return IRange.EndIRange(builder);
		}

		// Token: 0x0601542F RID: 87087 RVA: 0x00313F7E File Offset: 0x0031217E
		public static void StartIRange(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06015430 RID: 87088 RVA: 0x00313F87 File Offset: 0x00312187
		public static void AddType(FlatBufferBuilder builder, ERangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06015431 RID: 87089 RVA: 0x00313F92 File Offset: 0x00312192
		public static Offset<IRange> EndIRange(FlatBufferBuilder builder)
		{
			return new Offset<IRange>(builder.EndTable());
		}

		// Token: 0x06015432 RID: 87090 RVA: 0x00313FA0 File Offset: 0x003121A0
		public IRangeT UnPack()
		{
			IRangeT rangeT = new IRangeT();
			this.UnPackTo(rangeT);
			return rangeT;
		}

		// Token: 0x06015433 RID: 87091 RVA: 0x00313FBB File Offset: 0x003121BB
		public void UnPackTo(IRangeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06015434 RID: 87092 RVA: 0x00313FCC File Offset: 0x003121CC
		public static Offset<IRange> Pack(FlatBufferBuilder builder, IRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRange>);
			}
			return IRange.CreateIRange(builder, _o.Type);
		}

		// Token: 0x0400B222 RID: 45602
		private Table __p;
	}
}
