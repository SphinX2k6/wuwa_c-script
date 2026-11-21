using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Shape
{
	// Token: 0x02004007 RID: 16391
	public struct ICircleRange : IFlatbufferObject
	{
		// Token: 0x17006F19 RID: 28441
		// (get) Token: 0x06016715 RID: 91925 RVA: 0x00336918 File Offset: 0x00334B18
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016716 RID: 91926 RVA: 0x00336925 File Offset: 0x00334B25
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016717 RID: 91927 RVA: 0x0033692C File Offset: 0x00334B2C
		public static ICircleRange GetRootAsICircleRange(ByteBuffer _bb)
		{
			return ICircleRange.GetRootAsICircleRange(_bb, default(ICircleRange));
		}

		// Token: 0x06016718 RID: 91928 RVA: 0x00336948 File Offset: 0x00334B48
		public static ICircleRange GetRootAsICircleRange(ByteBuffer _bb, ICircleRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016719 RID: 91929 RVA: 0x00336965 File Offset: 0x00334B65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601671A RID: 91930 RVA: 0x00336974 File Offset: 0x00334B74
		public ICircleRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F1A RID: 28442
		// (get) Token: 0x0601671B RID: 91931 RVA: 0x00336984 File Offset: 0x00334B84
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

		// Token: 0x17006F1B RID: 28443
		// (get) Token: 0x0601671C RID: 91932 RVA: 0x003369C0 File Offset: 0x00334BC0
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

		// Token: 0x17006F1C RID: 28444
		// (get) Token: 0x0601671D RID: 91933 RVA: 0x00336A20 File Offset: 0x00334C20
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

		// Token: 0x0601671E RID: 91934 RVA: 0x00336A5C File Offset: 0x00334C5C
		public static Offset<ICircleRange> CreateICircleRange(FlatBufferBuilder builder, ERangeType Type = ERangeType.CircleRange, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), int Radius = 0)
		{
			builder.StartTable(3);
			ICircleRange.AddRadius(builder, Radius);
			ICircleRange.AddPos(builder, PosOffset);
			ICircleRange.AddType(builder, Type);
			return ICircleRange.EndICircleRange(builder);
		}

		// Token: 0x0601671F RID: 91935 RVA: 0x00336A80 File Offset: 0x00334C80
		public static void StartICircleRange(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016720 RID: 91936 RVA: 0x00336A89 File Offset: 0x00334C89
		public static void AddType(FlatBufferBuilder builder, ERangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016721 RID: 91937 RVA: 0x00336A94 File Offset: 0x00334C94
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x06016722 RID: 91938 RVA: 0x00336AA4 File Offset: 0x00334CA4
		public static void AddRadius(FlatBufferBuilder builder, int radius)
		{
			builder.AddInt(2, radius, 0);
		}

		// Token: 0x06016723 RID: 91939 RVA: 0x00336AAF File Offset: 0x00334CAF
		public static Offset<ICircleRange> EndICircleRange(FlatBufferBuilder builder)
		{
			return new Offset<ICircleRange>(builder.EndTable());
		}

		// Token: 0x06016724 RID: 91940 RVA: 0x00336ABC File Offset: 0x00334CBC
		public ICircleRangeT UnPack()
		{
			ICircleRangeT circleRangeT = new ICircleRangeT();
			this.UnPackTo(circleRangeT);
			return circleRangeT;
		}

		// Token: 0x06016725 RID: 91941 RVA: 0x00336AD8 File Offset: 0x00334CD8
		public void UnPackTo(ICircleRangeT _o)
		{
			_o.Type = this.Type;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Radius = this.Radius;
		}

		// Token: 0x06016726 RID: 91942 RVA: 0x00336B2C File Offset: 0x00334D2C
		public static Offset<ICircleRange> Pack(FlatBufferBuilder builder, ICircleRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircleRange>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return ICircleRange.CreateICircleRange(builder, _o.Type, posOffset, _o.Radius);
		}

		// Token: 0x0400BB57 RID: 47959
		private Table __p;
	}
}
