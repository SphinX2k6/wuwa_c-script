using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200424A RID: 16970
	public struct IUseSkillCheckByFollowShooterSkillId : IFlatbufferObject
	{
		// Token: 0x17007878 RID: 30840
		// (get) Token: 0x06019191 RID: 102801 RVA: 0x0039BE0E File Offset: 0x0039A00E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06019192 RID: 102802 RVA: 0x0039BE1B File Offset: 0x0039A01B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06019193 RID: 102803 RVA: 0x0039BE24 File Offset: 0x0039A024
		public static IUseSkillCheckByFollowShooterSkillId GetRootAsIUseSkillCheckByFollowShooterSkillId(ByteBuffer _bb)
		{
			return IUseSkillCheckByFollowShooterSkillId.GetRootAsIUseSkillCheckByFollowShooterSkillId(_bb, default(IUseSkillCheckByFollowShooterSkillId));
		}

		// Token: 0x06019194 RID: 102804 RVA: 0x0039BE40 File Offset: 0x0039A040
		public static IUseSkillCheckByFollowShooterSkillId GetRootAsIUseSkillCheckByFollowShooterSkillId(ByteBuffer _bb, IUseSkillCheckByFollowShooterSkillId obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06019195 RID: 102805 RVA: 0x0039BE5D File Offset: 0x0039A05D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06019196 RID: 102806 RVA: 0x0039BE6C File Offset: 0x0039A06C
		public IUseSkillCheckByFollowShooterSkillId __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007879 RID: 30841
		// (get) Token: 0x06019197 RID: 102807 RVA: 0x0039BE7C File Offset: 0x0039A07C
		public EUseSkillCheckType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EUseSkillCheckType.CheckSkillGenre;
				}
				return (EUseSkillCheckType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700787A RID: 30842
		// (get) Token: 0x06019198 RID: 102808 RVA: 0x0039BEB8 File Offset: 0x0039A0B8
		public int SkillId
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

		// Token: 0x06019199 RID: 102809 RVA: 0x0039BEF4 File Offset: 0x0039A0F4
		public static Offset<IUseSkillCheckByFollowShooterSkillId> CreateIUseSkillCheckByFollowShooterSkillId(FlatBufferBuilder builder, EUseSkillCheckType Type = EUseSkillCheckType.CheckSkillGenre, int SkillId = 0)
		{
			builder.StartTable(2);
			IUseSkillCheckByFollowShooterSkillId.AddSkillId(builder, SkillId);
			IUseSkillCheckByFollowShooterSkillId.AddType(builder, Type);
			return IUseSkillCheckByFollowShooterSkillId.EndIUseSkillCheckByFollowShooterSkillId(builder);
		}

		// Token: 0x0601919A RID: 102810 RVA: 0x0039BF11 File Offset: 0x0039A111
		public static void StartIUseSkillCheckByFollowShooterSkillId(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601919B RID: 102811 RVA: 0x0039BF1A File Offset: 0x0039A11A
		public static void AddType(FlatBufferBuilder builder, EUseSkillCheckType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601919C RID: 102812 RVA: 0x0039BF25 File Offset: 0x0039A125
		public static void AddSkillId(FlatBufferBuilder builder, int skillId)
		{
			builder.AddInt(1, skillId, 0);
		}

		// Token: 0x0601919D RID: 102813 RVA: 0x0039BF30 File Offset: 0x0039A130
		public static Offset<IUseSkillCheckByFollowShooterSkillId> EndIUseSkillCheckByFollowShooterSkillId(FlatBufferBuilder builder)
		{
			return new Offset<IUseSkillCheckByFollowShooterSkillId>(builder.EndTable());
		}

		// Token: 0x0601919E RID: 102814 RVA: 0x0039BF40 File Offset: 0x0039A140
		public IUseSkillCheckByFollowShooterSkillIdT UnPack()
		{
			IUseSkillCheckByFollowShooterSkillIdT useSkillCheckByFollowShooterSkillIdT = new IUseSkillCheckByFollowShooterSkillIdT();
			this.UnPackTo(useSkillCheckByFollowShooterSkillIdT);
			return useSkillCheckByFollowShooterSkillIdT;
		}

		// Token: 0x0601919F RID: 102815 RVA: 0x0039BF5B File Offset: 0x0039A15B
		public void UnPackTo(IUseSkillCheckByFollowShooterSkillIdT _o)
		{
			_o.Type = this.Type;
			_o.SkillId = this.SkillId;
		}

		// Token: 0x060191A0 RID: 102816 RVA: 0x0039BF78 File Offset: 0x0039A178
		public static Offset<IUseSkillCheckByFollowShooterSkillId> Pack(FlatBufferBuilder builder, IUseSkillCheckByFollowShooterSkillIdT _o)
		{
			if (_o == null)
			{
				return default(Offset<IUseSkillCheckByFollowShooterSkillId>);
			}
			return IUseSkillCheckByFollowShooterSkillId.CreateIUseSkillCheckByFollowShooterSkillId(builder, _o.Type, _o.SkillId);
		}

		// Token: 0x0400BED4 RID: 48852
		private Table __p;
	}
}
