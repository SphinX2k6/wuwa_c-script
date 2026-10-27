using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BDF RID: 27615
	public struct INpcNewSplineStopTarget : IFlatbufferObject
	{
		// Token: 0x1700CD31 RID: 52529
		// (get) Token: 0x06030832 RID: 198706 RVA: 0x0069617E File Offset: 0x0069437E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030833 RID: 198707 RVA: 0x0069618B File Offset: 0x0069438B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030834 RID: 198708 RVA: 0x00696194 File Offset: 0x00694394
		public static INpcNewSplineStopTarget GetRootAsINpcNewSplineStopTarget(ByteBuffer _bb)
		{
			return INpcNewSplineStopTarget.GetRootAsINpcNewSplineStopTarget(_bb, default(INpcNewSplineStopTarget));
		}

		// Token: 0x06030835 RID: 198709 RVA: 0x006961B0 File Offset: 0x006943B0
		public static INpcNewSplineStopTarget GetRootAsINpcNewSplineStopTarget(ByteBuffer _bb, INpcNewSplineStopTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030836 RID: 198710 RVA: 0x006961CD File Offset: 0x006943CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030837 RID: 198711 RVA: 0x006961DC File Offset: 0x006943DC
		public INpcNewSplineStopTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD32 RID: 52530
		// (get) Token: 0x06030838 RID: 198712 RVA: 0x006961EC File Offset: 0x006943EC
		public ENewSplineMoveTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return (ENewSplineMoveTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CD33 RID: 52531
		// (get) Token: 0x06030839 RID: 198713 RVA: 0x00696228 File Offset: 0x00694428
		public int NpcId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603083A RID: 198714 RVA: 0x00696264 File Offset: 0x00694464
		public static Offset<INpcNewSplineStopTarget> CreateINpcNewSplineStopTarget(FlatBufferBuilder builder, ENewSplineMoveTargetType Type = ENewSplineMoveTargetType.Player, int NpcId = 0)
		{
			builder.StartTable(2);
			INpcNewSplineStopTarget.AddNpcId(builder, NpcId);
			INpcNewSplineStopTarget.AddType(builder, Type);
			return INpcNewSplineStopTarget.EndINpcNewSplineStopTarget(builder);
		}

		// Token: 0x0603083B RID: 198715 RVA: 0x00696281 File Offset: 0x00694481
		public static void StartINpcNewSplineStopTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603083C RID: 198716 RVA: 0x0069628A File Offset: 0x0069448A
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603083D RID: 198717 RVA: 0x00696295 File Offset: 0x00694495
		public static void AddNpcId(FlatBufferBuilder builder, int npcId)
		{
			builder.AddInt(1, npcId, 0);
		}

		// Token: 0x0603083E RID: 198718 RVA: 0x006962A0 File Offset: 0x006944A0
		public static Offset<INpcNewSplineStopTarget> EndINpcNewSplineStopTarget(FlatBufferBuilder builder)
		{
			return new Offset<INpcNewSplineStopTarget>(builder.EndTable());
		}

		// Token: 0x0603083F RID: 198719 RVA: 0x006962B0 File Offset: 0x006944B0
		public INpcNewSplineStopTargetT UnPack()
		{
			INpcNewSplineStopTargetT npcNewSplineStopTargetT = new INpcNewSplineStopTargetT();
			this.UnPackTo(npcNewSplineStopTargetT);
			return npcNewSplineStopTargetT;
		}

		// Token: 0x06030840 RID: 198720 RVA: 0x006962CB File Offset: 0x006944CB
		public void UnPackTo(INpcNewSplineStopTargetT _o)
		{
			_o.Type = this.Type;
			_o.NpcId = this.NpcId;
		}

		// Token: 0x06030841 RID: 198721 RVA: 0x006962E8 File Offset: 0x006944E8
		public static Offset<INpcNewSplineStopTarget> Pack(FlatBufferBuilder builder, INpcNewSplineStopTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcNewSplineStopTarget>);
			}
			return INpcNewSplineStopTarget.CreateINpcNewSplineStopTarget(builder, _o.Type, _o.NpcId);
		}

		// Token: 0x040114C3 RID: 70851
		private Table __p;
	}
}
