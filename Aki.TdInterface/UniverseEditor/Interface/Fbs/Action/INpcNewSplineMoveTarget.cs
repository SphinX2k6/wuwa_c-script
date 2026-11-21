using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007340 RID: 29504
	public struct INpcNewSplineMoveTarget : IFlatbufferObject
	{
		// Token: 0x1700D838 RID: 55352
		// (get) Token: 0x06033738 RID: 210744 RVA: 0x006EF87F File Offset: 0x006EDA7F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033739 RID: 210745 RVA: 0x006EF88C File Offset: 0x006EDA8C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603373A RID: 210746 RVA: 0x006EF894 File Offset: 0x006EDA94
		public static INpcNewSplineMoveTarget GetRootAsINpcNewSplineMoveTarget(ByteBuffer _bb)
		{
			return INpcNewSplineMoveTarget.GetRootAsINpcNewSplineMoveTarget(_bb, default(INpcNewSplineMoveTarget));
		}

		// Token: 0x0603373B RID: 210747 RVA: 0x006EF8B0 File Offset: 0x006EDAB0
		public static INpcNewSplineMoveTarget GetRootAsINpcNewSplineMoveTarget(ByteBuffer _bb, INpcNewSplineMoveTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603373C RID: 210748 RVA: 0x006EF8CD File Offset: 0x006EDACD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603373D RID: 210749 RVA: 0x006EF8DC File Offset: 0x006EDADC
		public INpcNewSplineMoveTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D839 RID: 55353
		// (get) Token: 0x0603373E RID: 210750 RVA: 0x006EF8EC File Offset: 0x006EDAEC
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

		// Token: 0x1700D83A RID: 55354
		// (get) Token: 0x0603373F RID: 210751 RVA: 0x006EF928 File Offset: 0x006EDB28
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

		// Token: 0x06033740 RID: 210752 RVA: 0x006EF964 File Offset: 0x006EDB64
		public static Offset<INpcNewSplineMoveTarget> CreateINpcNewSplineMoveTarget(FlatBufferBuilder builder, ENewSplineMoveTargetType Type = ENewSplineMoveTargetType.Player, int NpcId = 0)
		{
			builder.StartTable(2);
			INpcNewSplineMoveTarget.AddNpcId(builder, NpcId);
			INpcNewSplineMoveTarget.AddType(builder, Type);
			return INpcNewSplineMoveTarget.EndINpcNewSplineMoveTarget(builder);
		}

		// Token: 0x06033741 RID: 210753 RVA: 0x006EF981 File Offset: 0x006EDB81
		public static void StartINpcNewSplineMoveTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033742 RID: 210754 RVA: 0x006EF98A File Offset: 0x006EDB8A
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033743 RID: 210755 RVA: 0x006EF995 File Offset: 0x006EDB95
		public static void AddNpcId(FlatBufferBuilder builder, int npcId)
		{
			builder.AddInt(1, npcId, 0);
		}

		// Token: 0x06033744 RID: 210756 RVA: 0x006EF9A0 File Offset: 0x006EDBA0
		public static Offset<INpcNewSplineMoveTarget> EndINpcNewSplineMoveTarget(FlatBufferBuilder builder)
		{
			return new Offset<INpcNewSplineMoveTarget>(builder.EndTable());
		}

		// Token: 0x06033745 RID: 210757 RVA: 0x006EF9B0 File Offset: 0x006EDBB0
		public INpcNewSplineMoveTargetT UnPack()
		{
			INpcNewSplineMoveTargetT npcNewSplineMoveTargetT = new INpcNewSplineMoveTargetT();
			this.UnPackTo(npcNewSplineMoveTargetT);
			return npcNewSplineMoveTargetT;
		}

		// Token: 0x06033746 RID: 210758 RVA: 0x006EF9CB File Offset: 0x006EDBCB
		public void UnPackTo(INpcNewSplineMoveTargetT _o)
		{
			_o.Type = this.Type;
			_o.NpcId = this.NpcId;
		}

		// Token: 0x06033747 RID: 210759 RVA: 0x006EF9E8 File Offset: 0x006EDBE8
		public static Offset<INpcNewSplineMoveTarget> Pack(FlatBufferBuilder builder, INpcNewSplineMoveTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcNewSplineMoveTarget>);
			}
			return INpcNewSplineMoveTarget.CreateINpcNewSplineMoveTarget(builder, _o.Type, _o.NpcId);
		}

		// Token: 0x0401240F RID: 74767
		private Table __p;
	}
}
