using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007331 RID: 29489
	public struct INpcLookAtPlayer : IFlatbufferObject
	{
		// Token: 0x1700D824 RID: 55332
		// (get) Token: 0x060336D4 RID: 210644 RVA: 0x006EEE5E File Offset: 0x006ED05E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060336D5 RID: 210645 RVA: 0x006EEE6B File Offset: 0x006ED06B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060336D6 RID: 210646 RVA: 0x006EEE74 File Offset: 0x006ED074
		public static INpcLookAtPlayer GetRootAsINpcLookAtPlayer(ByteBuffer _bb)
		{
			return INpcLookAtPlayer.GetRootAsINpcLookAtPlayer(_bb, default(INpcLookAtPlayer));
		}

		// Token: 0x060336D7 RID: 210647 RVA: 0x006EEE90 File Offset: 0x006ED090
		public static INpcLookAtPlayer GetRootAsINpcLookAtPlayer(ByteBuffer _bb, INpcLookAtPlayer obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060336D8 RID: 210648 RVA: 0x006EEEAD File Offset: 0x006ED0AD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060336D9 RID: 210649 RVA: 0x006EEEBC File Offset: 0x006ED0BC
		public INpcLookAtPlayer __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D825 RID: 55333
		// (get) Token: 0x060336DA RID: 210650 RVA: 0x006EEECC File Offset: 0x006ED0CC
		public ECommonTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTargetType.Player;
				}
				return (ECommonTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060336DB RID: 210651 RVA: 0x006EEF08 File Offset: 0x006ED108
		public static Offset<INpcLookAtPlayer> CreateINpcLookAtPlayer(FlatBufferBuilder builder, ECommonTargetType Type = ECommonTargetType.Player)
		{
			builder.StartTable(1);
			INpcLookAtPlayer.AddType(builder, Type);
			return INpcLookAtPlayer.EndINpcLookAtPlayer(builder);
		}

		// Token: 0x060336DC RID: 210652 RVA: 0x006EEF1E File Offset: 0x006ED11E
		public static void StartINpcLookAtPlayer(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060336DD RID: 210653 RVA: 0x006EEF27 File Offset: 0x006ED127
		public static void AddType(FlatBufferBuilder builder, ECommonTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060336DE RID: 210654 RVA: 0x006EEF32 File Offset: 0x006ED132
		public static Offset<INpcLookAtPlayer> EndINpcLookAtPlayer(FlatBufferBuilder builder)
		{
			return new Offset<INpcLookAtPlayer>(builder.EndTable());
		}

		// Token: 0x060336DF RID: 210655 RVA: 0x006EEF40 File Offset: 0x006ED140
		public INpcLookAtPlayerT UnPack()
		{
			INpcLookAtPlayerT npcLookAtPlayerT = new INpcLookAtPlayerT();
			this.UnPackTo(npcLookAtPlayerT);
			return npcLookAtPlayerT;
		}

		// Token: 0x060336E0 RID: 210656 RVA: 0x006EEF5B File Offset: 0x006ED15B
		public void UnPackTo(INpcLookAtPlayerT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060336E1 RID: 210657 RVA: 0x006EEF6C File Offset: 0x006ED16C
		public static Offset<INpcLookAtPlayer> Pack(FlatBufferBuilder builder, INpcLookAtPlayerT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcLookAtPlayer>);
			}
			return INpcLookAtPlayer.CreateINpcLookAtPlayer(builder, _o.Type);
		}

		// Token: 0x040123FC RID: 74748
		private Table __p;
	}
}
