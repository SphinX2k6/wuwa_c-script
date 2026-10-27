using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BD9 RID: 27609
	public struct INpcMoveToPoint : IFlatbufferObject
	{
		// Token: 0x1700CD25 RID: 52517
		// (get) Token: 0x06030802 RID: 198658 RVA: 0x00695C66 File Offset: 0x00693E66
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030803 RID: 198659 RVA: 0x00695C73 File Offset: 0x00693E73
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030804 RID: 198660 RVA: 0x00695C7C File Offset: 0x00693E7C
		public static INpcMoveToPoint GetRootAsINpcMoveToPoint(ByteBuffer _bb)
		{
			return INpcMoveToPoint.GetRootAsINpcMoveToPoint(_bb, default(INpcMoveToPoint));
		}

		// Token: 0x06030805 RID: 198661 RVA: 0x00695C98 File Offset: 0x00693E98
		public static INpcMoveToPoint GetRootAsINpcMoveToPoint(ByteBuffer _bb, INpcMoveToPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030806 RID: 198662 RVA: 0x00695CB5 File Offset: 0x00693EB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030807 RID: 198663 RVA: 0x00695CC4 File Offset: 0x00693EC4
		public INpcMoveToPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD26 RID: 52518
		// (get) Token: 0x06030808 RID: 198664 RVA: 0x00695CD4 File Offset: 0x00693ED4
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

		// Token: 0x1700CD27 RID: 52519
		// (get) Token: 0x06030809 RID: 198665 RVA: 0x00695D10 File Offset: 0x00693F10
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

		// Token: 0x1700CD28 RID: 52520
		// (get) Token: 0x0603080A RID: 198666 RVA: 0x00695D70 File Offset: 0x00693F70
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

		// Token: 0x0603080B RID: 198667 RVA: 0x00695DAC File Offset: 0x00693FAC
		public static Offset<INpcMoveToPoint> CreateINpcMoveToPoint(FlatBufferBuilder builder, int Target = 0, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), EMoveToPointType MoveType = EMoveToPointType.Straight)
		{
			builder.StartTable(3);
			INpcMoveToPoint.AddPos(builder, PosOffset);
			INpcMoveToPoint.AddTarget(builder, Target);
			INpcMoveToPoint.AddMoveType(builder, MoveType);
			return INpcMoveToPoint.EndINpcMoveToPoint(builder);
		}

		// Token: 0x0603080C RID: 198668 RVA: 0x00695DD0 File Offset: 0x00693FD0
		public static void StartINpcMoveToPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603080D RID: 198669 RVA: 0x00695DD9 File Offset: 0x00693FD9
		public static void AddTarget(FlatBufferBuilder builder, int target)
		{
			builder.AddInt(0, target, 0);
		}

		// Token: 0x0603080E RID: 198670 RVA: 0x00695DE4 File Offset: 0x00693FE4
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(1, posOffset.Value, 0);
		}

		// Token: 0x0603080F RID: 198671 RVA: 0x00695DF4 File Offset: 0x00693FF4
		public static void AddMoveType(FlatBufferBuilder builder, EMoveToPointType moveType)
		{
			builder.AddByte(2, (byte)moveType, 0);
		}

		// Token: 0x06030810 RID: 198672 RVA: 0x00695DFF File Offset: 0x00693FFF
		public static Offset<INpcMoveToPoint> EndINpcMoveToPoint(FlatBufferBuilder builder)
		{
			return new Offset<INpcMoveToPoint>(builder.EndTable());
		}

		// Token: 0x06030811 RID: 198673 RVA: 0x00695E0C File Offset: 0x0069400C
		public INpcMoveToPointT UnPack()
		{
			INpcMoveToPointT npcMoveToPointT = new INpcMoveToPointT();
			this.UnPackTo(npcMoveToPointT);
			return npcMoveToPointT;
		}

		// Token: 0x06030812 RID: 198674 RVA: 0x00695E28 File Offset: 0x00694028
		public void UnPackTo(INpcMoveToPointT _o)
		{
			_o.Target = this.Target;
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.MoveType = this.MoveType;
		}

		// Token: 0x06030813 RID: 198675 RVA: 0x00695E7C File Offset: 0x0069407C
		public static Offset<INpcMoveToPoint> Pack(FlatBufferBuilder builder, INpcMoveToPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcMoveToPoint>);
			}
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			return INpcMoveToPoint.CreateINpcMoveToPoint(builder, _o.Target, posOffset, _o.MoveType);
		}

		// Token: 0x040114BC RID: 70844
		private Table __p;
	}
}
