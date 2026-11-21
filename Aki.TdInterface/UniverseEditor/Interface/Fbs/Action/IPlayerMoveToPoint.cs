using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200747D RID: 29821
	public struct IPlayerMoveToPoint : IFlatbufferObject
	{
		// Token: 0x1700DB14 RID: 56084
		// (get) Token: 0x06034348 RID: 213832 RVA: 0x00708439 File Offset: 0x00706639
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06034349 RID: 213833 RVA: 0x00708446 File Offset: 0x00706646
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603434A RID: 213834 RVA: 0x00708450 File Offset: 0x00706650
		public static IPlayerMoveToPoint GetRootAsIPlayerMoveToPoint(ByteBuffer _bb)
		{
			return IPlayerMoveToPoint.GetRootAsIPlayerMoveToPoint(_bb, default(IPlayerMoveToPoint));
		}

		// Token: 0x0603434B RID: 213835 RVA: 0x0070846C File Offset: 0x0070666C
		public static IPlayerMoveToPoint GetRootAsIPlayerMoveToPoint(ByteBuffer _bb, IPlayerMoveToPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603434C RID: 213836 RVA: 0x00708489 File Offset: 0x00706689
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603434D RID: 213837 RVA: 0x00708498 File Offset: 0x00706698
		public IPlayerMoveToPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DB15 RID: 56085
		// (get) Token: 0x0603434E RID: 213838 RVA: 0x007084A8 File Offset: 0x007066A8
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700DB16 RID: 56086
		// (get) Token: 0x0603434F RID: 213839 RVA: 0x00708508 File Offset: 0x00706708
		public EMoveToPointType MoveType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EMoveToPointType.Straight;
				}
				return (EMoveToPointType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700DB17 RID: 56087
		// (get) Token: 0x06034350 RID: 213840 RVA: 0x00708544 File Offset: 0x00706744
		public bool IsExact
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700DB18 RID: 56088
		// (get) Token: 0x06034351 RID: 213841 RVA: 0x00708584 File Offset: 0x00706784
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06034352 RID: 213842 RVA: 0x007085C1 File Offset: 0x007067C1
		public static Offset<IPlayerMoveToPoint> CreateIPlayerMoveToPoint(FlatBufferBuilder builder, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), EMoveToPointType MoveType = EMoveToPointType.Straight, bool IsExact = false, byte NullMask = 0)
		{
			builder.StartTable(4);
			IPlayerMoveToPoint.AddPos(builder, PosOffset);
			IPlayerMoveToPoint.AddNullMask(builder, NullMask);
			IPlayerMoveToPoint.AddIsExact(builder, IsExact);
			IPlayerMoveToPoint.AddMoveType(builder, MoveType);
			return IPlayerMoveToPoint.EndIPlayerMoveToPoint(builder);
		}

		// Token: 0x06034353 RID: 213843 RVA: 0x007085ED File Offset: 0x007067ED
		public static void StartIPlayerMoveToPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06034354 RID: 213844 RVA: 0x007085F6 File Offset: 0x007067F6
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(0, posOffset.Value, 0);
		}

		// Token: 0x06034355 RID: 213845 RVA: 0x00708606 File Offset: 0x00706806
		public static void AddMoveType(FlatBufferBuilder builder, EMoveToPointType moveType)
		{
			builder.AddByte(1, (byte)moveType, 0);
		}

		// Token: 0x06034356 RID: 213846 RVA: 0x00708611 File Offset: 0x00706811
		public static void AddIsExact(FlatBufferBuilder builder, bool isExact)
		{
			builder.AddBool(2, isExact, false);
		}

		// Token: 0x06034357 RID: 213847 RVA: 0x0070861C File Offset: 0x0070681C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06034358 RID: 213848 RVA: 0x00708627 File Offset: 0x00706827
		public static Offset<IPlayerMoveToPoint> EndIPlayerMoveToPoint(FlatBufferBuilder builder)
		{
			return new Offset<IPlayerMoveToPoint>(builder.EndTable());
		}

		// Token: 0x06034359 RID: 213849 RVA: 0x00708634 File Offset: 0x00706834
		public IPlayerMoveToPointT UnPack()
		{
			IPlayerMoveToPointT playerMoveToPointT = new IPlayerMoveToPointT();
			this.UnPackTo(playerMoveToPointT);
			return playerMoveToPointT;
		}

		// Token: 0x0603435A RID: 213850 RVA: 0x00708650 File Offset: 0x00706850
		public void UnPackTo(IPlayerMoveToPointT _o)
		{
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.MoveType = this.MoveType;
			_o.IsExact = this.IsExact;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603435B RID: 213851 RVA: 0x007086B0 File Offset: 0x007068B0
		public static Offset<IPlayerMoveToPoint> Pack(FlatBufferBuilder builder, IPlayerMoveToPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPlayerMoveToPoint>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return IPlayerMoveToPoint.CreateIPlayerMoveToPoint(builder, posOffset, _o.MoveType, _o.IsExact, _o.NullMask);
		}

		// Token: 0x040125F8 RID: 75256
		private Table __p;
	}
}
