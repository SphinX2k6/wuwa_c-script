using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A44 RID: 27204
	public struct IClientFollowShooterPlaySkill : IFlatbufferObject
	{
		// Token: 0x1700C7E1 RID: 51169
		// (get) Token: 0x0602EA96 RID: 191126 RVA: 0x0065C67D File Offset: 0x0065A87D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EA97 RID: 191127 RVA: 0x0065C68A File Offset: 0x0065A88A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EA98 RID: 191128 RVA: 0x0065C694 File Offset: 0x0065A894
		public static IClientFollowShooterPlaySkill GetRootAsIClientFollowShooterPlaySkill(ByteBuffer _bb)
		{
			return IClientFollowShooterPlaySkill.GetRootAsIClientFollowShooterPlaySkill(_bb, default(IClientFollowShooterPlaySkill));
		}

		// Token: 0x0602EA99 RID: 191129 RVA: 0x0065C6B0 File Offset: 0x0065A8B0
		public static IClientFollowShooterPlaySkill GetRootAsIClientFollowShooterPlaySkill(ByteBuffer _bb, IClientFollowShooterPlaySkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EA9A RID: 191130 RVA: 0x0065C6CD File Offset: 0x0065A8CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EA9B RID: 191131 RVA: 0x0065C6DC File Offset: 0x0065A8DC
		public IClientFollowShooterPlaySkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C7E2 RID: 51170
		// (get) Token: 0x0602EA9C RID: 191132 RVA: 0x0065C6EC File Offset: 0x0065A8EC
		public EClientFollowShooterLeisureInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EClientFollowShooterLeisureInteractType.PlayAnimation;
				}
				return (EClientFollowShooterLeisureInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C7E3 RID: 51171
		// (get) Token: 0x0602EA9D RID: 191133 RVA: 0x0065C728 File Offset: 0x0065A928
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

		// Token: 0x0602EA9E RID: 191134 RVA: 0x0065C764 File Offset: 0x0065A964
		public static Offset<IClientFollowShooterPlaySkill> CreateIClientFollowShooterPlaySkill(FlatBufferBuilder builder, EClientFollowShooterLeisureInteractType Type = EClientFollowShooterLeisureInteractType.PlayAnimation, int SkillId = 0)
		{
			builder.StartTable(2);
			IClientFollowShooterPlaySkill.AddSkillId(builder, SkillId);
			IClientFollowShooterPlaySkill.AddType(builder, Type);
			return IClientFollowShooterPlaySkill.EndIClientFollowShooterPlaySkill(builder);
		}

		// Token: 0x0602EA9F RID: 191135 RVA: 0x0065C781 File Offset: 0x0065A981
		public static void StartIClientFollowShooterPlaySkill(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602EAA0 RID: 191136 RVA: 0x0065C78A File Offset: 0x0065A98A
		public static void AddType(FlatBufferBuilder builder, EClientFollowShooterLeisureInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602EAA1 RID: 191137 RVA: 0x0065C795 File Offset: 0x0065A995
		public static void AddSkillId(FlatBufferBuilder builder, int skillId)
		{
			builder.AddInt(1, skillId, 0);
		}

		// Token: 0x0602EAA2 RID: 191138 RVA: 0x0065C7A0 File Offset: 0x0065A9A0
		public static Offset<IClientFollowShooterPlaySkill> EndIClientFollowShooterPlaySkill(FlatBufferBuilder builder)
		{
			return new Offset<IClientFollowShooterPlaySkill>(builder.EndTable());
		}

		// Token: 0x0602EAA3 RID: 191139 RVA: 0x0065C7B0 File Offset: 0x0065A9B0
		public IClientFollowShooterPlaySkillT UnPack()
		{
			IClientFollowShooterPlaySkillT clientFollowShooterPlaySkillT = new IClientFollowShooterPlaySkillT();
			this.UnPackTo(clientFollowShooterPlaySkillT);
			return clientFollowShooterPlaySkillT;
		}

		// Token: 0x0602EAA4 RID: 191140 RVA: 0x0065C7CB File Offset: 0x0065A9CB
		public void UnPackTo(IClientFollowShooterPlaySkillT _o)
		{
			_o.Type = this.Type;
			_o.SkillId = this.SkillId;
		}

		// Token: 0x0602EAA5 RID: 191141 RVA: 0x0065C7E8 File Offset: 0x0065A9E8
		public static Offset<IClientFollowShooterPlaySkill> Pack(FlatBufferBuilder builder, IClientFollowShooterPlaySkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientFollowShooterPlaySkill>);
			}
			return IClientFollowShooterPlaySkill.CreateIClientFollowShooterPlaySkill(builder, _o.Type, _o.SkillId);
		}

		// Token: 0x040117C5 RID: 71621
		private Table __p;
	}
}
