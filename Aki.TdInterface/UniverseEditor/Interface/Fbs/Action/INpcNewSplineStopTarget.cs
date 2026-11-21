using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007343 RID: 29507
	public struct INpcNewSplineStopTarget : IFlatbufferObject
	{
		// Token: 0x1700D83D RID: 55357
		// (get) Token: 0x0603374E RID: 210766 RVA: 0x006EFA7E File Offset: 0x006EDC7E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603374F RID: 210767 RVA: 0x006EFA8B File Offset: 0x006EDC8B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033750 RID: 210768 RVA: 0x006EFA94 File Offset: 0x006EDC94
		public static INpcNewSplineStopTarget GetRootAsINpcNewSplineStopTarget(ByteBuffer _bb)
		{
			return INpcNewSplineStopTarget.GetRootAsINpcNewSplineStopTarget(_bb, default(INpcNewSplineStopTarget));
		}

		// Token: 0x06033751 RID: 210769 RVA: 0x006EFAB0 File Offset: 0x006EDCB0
		public static INpcNewSplineStopTarget GetRootAsINpcNewSplineStopTarget(ByteBuffer _bb, INpcNewSplineStopTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033752 RID: 210770 RVA: 0x006EFACD File Offset: 0x006EDCCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033753 RID: 210771 RVA: 0x006EFADC File Offset: 0x006EDCDC
		public INpcNewSplineStopTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D83E RID: 55358
		// (get) Token: 0x06033754 RID: 210772 RVA: 0x006EFAEC File Offset: 0x006EDCEC
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

		// Token: 0x1700D83F RID: 55359
		// (get) Token: 0x06033755 RID: 210773 RVA: 0x006EFB28 File Offset: 0x006EDD28
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

		// Token: 0x06033756 RID: 210774 RVA: 0x006EFB64 File Offset: 0x006EDD64
		public static Offset<INpcNewSplineStopTarget> CreateINpcNewSplineStopTarget(FlatBufferBuilder builder, ENewSplineMoveTargetType Type = ENewSplineMoveTargetType.Player, int NpcId = 0)
		{
			builder.StartTable(2);
			INpcNewSplineStopTarget.AddNpcId(builder, NpcId);
			INpcNewSplineStopTarget.AddType(builder, Type);
			return INpcNewSplineStopTarget.EndINpcNewSplineStopTarget(builder);
		}

		// Token: 0x06033757 RID: 210775 RVA: 0x006EFB81 File Offset: 0x006EDD81
		public static void StartINpcNewSplineStopTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033758 RID: 210776 RVA: 0x006EFB8A File Offset: 0x006EDD8A
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033759 RID: 210777 RVA: 0x006EFB95 File Offset: 0x006EDD95
		public static void AddNpcId(FlatBufferBuilder builder, int npcId)
		{
			builder.AddInt(1, npcId, 0);
		}

		// Token: 0x0603375A RID: 210778 RVA: 0x006EFBA0 File Offset: 0x006EDDA0
		public static Offset<INpcNewSplineStopTarget> EndINpcNewSplineStopTarget(FlatBufferBuilder builder)
		{
			return new Offset<INpcNewSplineStopTarget>(builder.EndTable());
		}

		// Token: 0x0603375B RID: 210779 RVA: 0x006EFBB0 File Offset: 0x006EDDB0
		public INpcNewSplineStopTargetT UnPack()
		{
			INpcNewSplineStopTargetT npcNewSplineStopTargetT = new INpcNewSplineStopTargetT();
			this.UnPackTo(npcNewSplineStopTargetT);
			return npcNewSplineStopTargetT;
		}

		// Token: 0x0603375C RID: 210780 RVA: 0x006EFBCB File Offset: 0x006EDDCB
		public void UnPackTo(INpcNewSplineStopTargetT _o)
		{
			_o.Type = this.Type;
			_o.NpcId = this.NpcId;
		}

		// Token: 0x0603375D RID: 210781 RVA: 0x006EFBE8 File Offset: 0x006EDDE8
		public static Offset<INpcNewSplineStopTarget> Pack(FlatBufferBuilder builder, INpcNewSplineStopTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcNewSplineStopTarget>);
			}
			return INpcNewSplineStopTarget.CreateINpcNewSplineStopTarget(builder, _o.Type, _o.NpcId);
		}

		// Token: 0x04012412 RID: 74770
		private Table __p;
	}
}
