using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02003BFB RID: 15355
	public struct ICircleRange : IFlatbufferObject
	{
		// Token: 0x17006971 RID: 26993
		// (get) Token: 0x0601521F RID: 86559 RVA: 0x0030FD90 File Offset: 0x0030DF90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06015220 RID: 86560 RVA: 0x0030FD9D File Offset: 0x0030DF9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06015221 RID: 86561 RVA: 0x0030FDA4 File Offset: 0x0030DFA4
		public static ICircleRange GetRootAsICircleRange(ByteBuffer _bb)
		{
			return ICircleRange.GetRootAsICircleRange(_bb, default(ICircleRange));
		}

		// Token: 0x06015222 RID: 86562 RVA: 0x0030FDC0 File Offset: 0x0030DFC0
		public static ICircleRange GetRootAsICircleRange(ByteBuffer _bb, ICircleRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06015223 RID: 86563 RVA: 0x0030FDDD File Offset: 0x0030DFDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06015224 RID: 86564 RVA: 0x0030FDEC File Offset: 0x0030DFEC
		public ICircleRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006972 RID: 26994
		// (get) Token: 0x06015225 RID: 86565 RVA: 0x0030FDFC File Offset: 0x0030DFFC
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

		// Token: 0x17006973 RID: 26995
		// (get) Token: 0x06015226 RID: 86566 RVA: 0x0030FE38 File Offset: 0x0030E038
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006974 RID: 26996
		// (get) Token: 0x06015227 RID: 86567 RVA: 0x0030FE98 File Offset: 0x0030E098
		public int Radius
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06015228 RID: 86568 RVA: 0x0030FED4 File Offset: 0x0030E0D4
		public static Offset<ICircleRange> CreateICircleRange(FlatBufferBuilder builder, ERangeType Type = ERangeType.CircleRange, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), int Radius = 0)
		{
			builder.StartTable(3);
			ICircleRange.AddRadius(builder, Radius);
			ICircleRange.AddPos(builder, PosOffset);
			ICircleRange.AddType(builder, Type);
			return ICircleRange.EndICircleRange(builder);
		}

		// Token: 0x06015229 RID: 86569 RVA: 0x0030FEF8 File Offset: 0x0030E0F8
		public static void StartICircleRange(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601522A RID: 86570 RVA: 0x0030FF01 File Offset: 0x0030E101
		public static void AddType(FlatBufferBuilder builder, ERangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601522B RID: 86571 RVA: 0x0030FF0C File Offset: 0x0030E10C
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x0601522C RID: 86572 RVA: 0x0030FF1C File Offset: 0x0030E11C
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x0601522D RID: 86573 RVA: 0x0030FF27 File Offset: 0x0030E127
		public static Offset<ICircleRange> EndICircleRange(FlatBufferBuilder builder)
		{
			return new Offset<ICircleRange>(builder.EndTable());
		}

		// Token: 0x0601522E RID: 86574 RVA: 0x0030FF34 File Offset: 0x0030E134
		public ICircleRangeT UnPack()
		{
			ICircleRangeT circleRangeT = new ICircleRangeT();
			this.UnPackTo(circleRangeT);
			return circleRangeT;
		}

		// Token: 0x0601522F RID: 86575 RVA: 0x0030FF50 File Offset: 0x0030E150
		public void UnPackTo(ICircleRangeT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Radius = this.Radius;
		}

		// Token: 0x06015230 RID: 86576 RVA: 0x0030FFA4 File Offset: 0x0030E1A4
		public static Offset<ICircleRange> Pack(FlatBufferBuilder builder, ICircleRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircleRange>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return ICircleRange.CreateICircleRange(builder, _o.Type, posOffset, _o.Radius);
		}

		// Token: 0x0400B1CC RID: 45516
		private Table __p;
	}
}
