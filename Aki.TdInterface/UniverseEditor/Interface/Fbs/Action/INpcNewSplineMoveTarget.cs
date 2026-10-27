using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BDC RID: 27612
	public struct INpcNewSplineMoveTarget : IFlatbufferObject
	{
		// Token: 0x1700CD2C RID: 52524
		// (get) Token: 0x0603081C RID: 198684 RVA: 0x00695F7F File Offset: 0x0069417F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603081D RID: 198685 RVA: 0x00695F8C File Offset: 0x0069418C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603081E RID: 198686 RVA: 0x00695F94 File Offset: 0x00694194
		public static INpcNewSplineMoveTarget GetRootAsINpcNewSplineMoveTarget(ByteBuffer _bb)
		{
			return INpcNewSplineMoveTarget.GetRootAsINpcNewSplineMoveTarget(_bb, default(INpcNewSplineMoveTarget));
		}

		// Token: 0x0603081F RID: 198687 RVA: 0x00695FB0 File Offset: 0x006941B0
		public static INpcNewSplineMoveTarget GetRootAsINpcNewSplineMoveTarget(ByteBuffer _bb, INpcNewSplineMoveTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030820 RID: 198688 RVA: 0x00695FCD File Offset: 0x006941CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030821 RID: 198689 RVA: 0x00695FDC File Offset: 0x006941DC
		public INpcNewSplineMoveTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD2D RID: 52525
		// (get) Token: 0x06030822 RID: 198690 RVA: 0x00695FEC File Offset: 0x006941EC
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

		// Token: 0x1700CD2E RID: 52526
		// (get) Token: 0x06030823 RID: 198691 RVA: 0x00696028 File Offset: 0x00694228
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

		// Token: 0x06030824 RID: 198692 RVA: 0x00696064 File Offset: 0x00694264
		public static Offset<INpcNewSplineMoveTarget> CreateINpcNewSplineMoveTarget(FlatBufferBuilder builder, ENewSplineMoveTargetType Type = ENewSplineMoveTargetType.Player, int NpcId = 0)
		{
			builder.StartTable(2);
			INpcNewSplineMoveTarget.AddNpcId(builder, NpcId);
			INpcNewSplineMoveTarget.AddType(builder, Type);
			return INpcNewSplineMoveTarget.EndINpcNewSplineMoveTarget(builder);
		}

		// Token: 0x06030825 RID: 198693 RVA: 0x00696081 File Offset: 0x00694281
		public static void StartINpcNewSplineMoveTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030826 RID: 198694 RVA: 0x0069608A File Offset: 0x0069428A
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030827 RID: 198695 RVA: 0x00696095 File Offset: 0x00694295
		public static void AddNpcId(FlatBufferBuilder builder, int npcId)
		{
			builder.AddInt(1, npcId, 0);
		}

		// Token: 0x06030828 RID: 198696 RVA: 0x006960A0 File Offset: 0x006942A0
		public static Offset<INpcNewSplineMoveTarget> EndINpcNewSplineMoveTarget(FlatBufferBuilder builder)
		{
			return new Offset<INpcNewSplineMoveTarget>(builder.EndTable());
		}

		// Token: 0x06030829 RID: 198697 RVA: 0x006960B0 File Offset: 0x006942B0
		public INpcNewSplineMoveTargetT UnPack()
		{
			INpcNewSplineMoveTargetT npcNewSplineMoveTargetT = new INpcNewSplineMoveTargetT();
			this.UnPackTo(npcNewSplineMoveTargetT);
			return npcNewSplineMoveTargetT;
		}

		// Token: 0x0603082A RID: 198698 RVA: 0x006960CB File Offset: 0x006942CB
		public void UnPackTo(INpcNewSplineMoveTargetT _o)
		{
			_o.Type = this.Type;
			_o.NpcId = this.NpcId;
		}

		// Token: 0x0603082B RID: 198699 RVA: 0x006960E8 File Offset: 0x006942E8
		public static Offset<INpcNewSplineMoveTarget> Pack(FlatBufferBuilder builder, INpcNewSplineMoveTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcNewSplineMoveTarget>);
			}
			return INpcNewSplineMoveTarget.CreateINpcNewSplineMoveTarget(builder, _o.Type, _o.NpcId);
		}

		// Token: 0x040114C0 RID: 70848
		private Table __p;
	}
}
