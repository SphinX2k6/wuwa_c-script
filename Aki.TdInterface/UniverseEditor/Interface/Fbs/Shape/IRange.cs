using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x0200403A RID: 16442
	public struct IRange : IFlatbufferObject
	{
		// Token: 0x17006FBF RID: 28607
		// (get) Token: 0x0601693B RID: 92475 RVA: 0x0033AD60 File Offset: 0x00338F60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601693C RID: 92476 RVA: 0x0033AD6D File Offset: 0x00338F6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601693D RID: 92477 RVA: 0x0033AD74 File Offset: 0x00338F74
		public static IRange GetRootAsIRange(ByteBuffer _bb)
		{
			return IRange.GetRootAsIRange(_bb, default(IRange));
		}

		// Token: 0x0601693E RID: 92478 RVA: 0x0033AD90 File Offset: 0x00338F90
		public static IRange GetRootAsIRange(ByteBuffer _bb, IRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601693F RID: 92479 RVA: 0x0033ADAD File Offset: 0x00338FAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016940 RID: 92480 RVA: 0x0033ADBC File Offset: 0x00338FBC
		public IRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006FC0 RID: 28608
		// (get) Token: 0x06016941 RID: 92481 RVA: 0x0033ADCC File Offset: 0x00338FCC
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

		// Token: 0x06016942 RID: 92482 RVA: 0x0033AE08 File Offset: 0x00339008
		public static Offset<IRange> CreateIRange(FlatBufferBuilder builder, ERangeType Type = ERangeType.CircleRange)
		{
			builder.StartTable(1);
			IRange.AddType(builder, Type);
			return IRange.EndIRange(builder);
		}

		// Token: 0x06016943 RID: 92483 RVA: 0x0033AE1E File Offset: 0x0033901E
		public static void StartIRange(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06016944 RID: 92484 RVA: 0x0033AE27 File Offset: 0x00339027
		public static void AddType(FlatBufferBuilder builder, ERangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016945 RID: 92485 RVA: 0x0033AE32 File Offset: 0x00339032
		public static Offset<IRange> EndIRange(FlatBufferBuilder builder)
		{
			return new Offset<IRange>(builder.EndTable());
		}

		// Token: 0x06016946 RID: 92486 RVA: 0x0033AE40 File Offset: 0x00339040
		public IRangeT UnPack()
		{
			IRangeT rangeT = new IRangeT();
			this.UnPackTo(rangeT);
			return rangeT;
		}

		// Token: 0x06016947 RID: 92487 RVA: 0x0033AE5B File Offset: 0x0033905B
		public void UnPackTo(IRangeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06016948 RID: 92488 RVA: 0x0033AE6C File Offset: 0x0033906C
		public static Offset<IRange> Pack(FlatBufferBuilder builder, IRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRange>);
			}
			return IRange.CreateIRange(builder, _o.Type);
		}

		// Token: 0x0400BBB2 RID: 48050
		private Table __p;
	}
}
