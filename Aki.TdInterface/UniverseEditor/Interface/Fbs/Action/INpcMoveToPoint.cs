using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200733D RID: 29501
	public struct INpcMoveToPoint : IFlatbufferObject
	{
		// Token: 0x1700D831 RID: 55345
		// (get) Token: 0x0603371E RID: 210718 RVA: 0x006EF566 File Offset: 0x006ED766
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603371F RID: 210719 RVA: 0x006EF573 File Offset: 0x006ED773
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033720 RID: 210720 RVA: 0x006EF57C File Offset: 0x006ED77C
		public static INpcMoveToPoint GetRootAsINpcMoveToPoint(ByteBuffer _bb)
		{
			return INpcMoveToPoint.GetRootAsINpcMoveToPoint(_bb, default(INpcMoveToPoint));
		}

		// Token: 0x06033721 RID: 210721 RVA: 0x006EF598 File Offset: 0x006ED798
		public static INpcMoveToPoint GetRootAsINpcMoveToPoint(ByteBuffer _bb, INpcMoveToPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033722 RID: 210722 RVA: 0x006EF5B5 File Offset: 0x006ED7B5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033723 RID: 210723 RVA: 0x006EF5C4 File Offset: 0x006ED7C4
		public INpcMoveToPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D832 RID: 55346
		// (get) Token: 0x06033724 RID: 210724 RVA: 0x006EF5D4 File Offset: 0x006ED7D4
		public int Target
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D833 RID: 55347
		// (get) Token: 0x06033725 RID: 210725 RVA: 0x006EF610 File Offset: 0x006ED810
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

		// Token: 0x1700D834 RID: 55348
		// (get) Token: 0x06033726 RID: 210726 RVA: 0x006EF670 File Offset: 0x006ED870
		public EMoveToPointType MoveType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EMoveToPointType.Straight;
				}
				return (EMoveToPointType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033727 RID: 210727 RVA: 0x006EF6AC File Offset: 0x006ED8AC
		public static Offset<INpcMoveToPoint> CreateINpcMoveToPoint(FlatBufferBuilder builder, int Target = 0, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), EMoveToPointType MoveType = EMoveToPointType.Straight)
		{
			builder.StartTable(3);
			INpcMoveToPoint.AddPos(builder, PosOffset);
			INpcMoveToPoint.AddTarget(builder, Target);
			INpcMoveToPoint.AddMoveType(builder, MoveType);
			return INpcMoveToPoint.EndINpcMoveToPoint(builder);
		}

		// Token: 0x06033728 RID: 210728 RVA: 0x006EF6D0 File Offset: 0x006ED8D0
		public static void StartINpcMoveToPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06033729 RID: 210729 RVA: 0x006EF6D9 File Offset: 0x006ED8D9
		public static void AddTarget(FlatBufferBuilder builder, int target)
		{
			builder.AddInt(0, target, 0);
		}

		// Token: 0x0603372A RID: 210730 RVA: 0x006EF6E4 File Offset: 0x006ED8E4
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x0603372B RID: 210731 RVA: 0x006EF6F4 File Offset: 0x006ED8F4
		public static void AddMoveType(FlatBufferBuilder builder, EMoveToPointType moveType)
		{
			builder.AddByte(2, (byte)moveType, 0);
		}

		// Token: 0x0603372C RID: 210732 RVA: 0x006EF6FF File Offset: 0x006ED8FF
		public static Offset<INpcMoveToPoint> EndINpcMoveToPoint(FlatBufferBuilder builder)
		{
			return new Offset<INpcMoveToPoint>(builder.EndTable());
		}

		// Token: 0x0603372D RID: 210733 RVA: 0x006EF70C File Offset: 0x006ED90C
		public INpcMoveToPointT UnPack()
		{
			INpcMoveToPointT npcMoveToPointT = new INpcMoveToPointT();
			this.UnPackTo(npcMoveToPointT);
			return npcMoveToPointT;
		}

		// Token: 0x0603372E RID: 210734 RVA: 0x006EF728 File Offset: 0x006ED928
		public void UnPackTo(INpcMoveToPointT _o)
		{
			_o.Target = this.Target;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.MoveType = this.MoveType;
		}

		// Token: 0x0603372F RID: 210735 RVA: 0x006EF77C File Offset: 0x006ED97C
		public static Offset<INpcMoveToPoint> Pack(FlatBufferBuilder builder, INpcMoveToPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcMoveToPoint>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return INpcMoveToPoint.CreateINpcMoveToPoint(builder, _o.Target, posOffset, _o.MoveType);
		}

		// Token: 0x0401240B RID: 74763
		private Table __p;
	}
}
