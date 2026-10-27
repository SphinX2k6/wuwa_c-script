using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003BB0 RID: 15280
	public struct IShowTimelineCastSkill : IFlatbufferObject
	{
		// Token: 0x170068B9 RID: 26809
		// (get) Token: 0x06014F2D RID: 85805 RVA: 0x00309ADB File Offset: 0x00307CDB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06014F2E RID: 85806 RVA: 0x00309AE8 File Offset: 0x00307CE8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06014F2F RID: 85807 RVA: 0x00309AF0 File Offset: 0x00307CF0
		public static IShowTimelineCastSkill GetRootAsIShowTimelineCastSkill(ByteBuffer _bb)
		{
			return IShowTimelineCastSkill.GetRootAsIShowTimelineCastSkill(_bb, default(IShowTimelineCastSkill));
		}

		// Token: 0x06014F30 RID: 85808 RVA: 0x00309B0C File Offset: 0x00307D0C
		public static IShowTimelineCastSkill GetRootAsIShowTimelineCastSkill(ByteBuffer _bb, IShowTimelineCastSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06014F31 RID: 85809 RVA: 0x00309B29 File Offset: 0x00307D29
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06014F32 RID: 85810 RVA: 0x00309B38 File Offset: 0x00307D38
		public IShowTimelineCastSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170068BA RID: 26810
		// (get) Token: 0x06014F33 RID: 85811 RVA: 0x00309B48 File Offset: 0x00307D48
		public EShowTimelineActionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EShowTimelineActionType.Skill;
				}
				return (EShowTimelineActionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170068BB RID: 26811
		// (get) Token: 0x06014F34 RID: 85812 RVA: 0x00309B84 File Offset: 0x00307D84
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

		// Token: 0x06014F35 RID: 85813 RVA: 0x00309BC0 File Offset: 0x00307DC0
		public static Offset<IShowTimelineCastSkill> CreateIShowTimelineCastSkill(FlatBufferBuilder builder, EShowTimelineActionType Type = EShowTimelineActionType.Skill, int SkillId = 0)
		{
			builder.StartTable(2);
			IShowTimelineCastSkill.AddSkillId(builder, SkillId);
			IShowTimelineCastSkill.AddType(builder, Type);
			return IShowTimelineCastSkill.EndIShowTimelineCastSkill(builder);
		}

		// Token: 0x06014F36 RID: 85814 RVA: 0x00309BDD File Offset: 0x00307DDD
		public static void StartIShowTimelineCastSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06014F37 RID: 85815 RVA: 0x00309BE6 File Offset: 0x00307DE6
		public static void AddType(FlatBufferBuilder builder, EShowTimelineActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06014F38 RID: 85816 RVA: 0x00309BF1 File Offset: 0x00307DF1
		public static void AddSkillId(FlatBufferBuilder builder, int skillId)
		{
			builder.AddInt(1, skillId, 0);
		}

		// Token: 0x06014F39 RID: 85817 RVA: 0x00309BFC File Offset: 0x00307DFC
		public static Offset<IShowTimelineCastSkill> EndIShowTimelineCastSkill(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineCastSkill>(builder.EndTable());
		}

		// Token: 0x06014F3A RID: 85818 RVA: 0x00309C0C File Offset: 0x00307E0C
		public IShowTimelineCastSkillT UnPack()
		{
			IShowTimelineCastSkillT showTimelineCastSkillT = new IShowTimelineCastSkillT();
			this.UnPackTo(showTimelineCastSkillT);
			return showTimelineCastSkillT;
		}

		// Token: 0x06014F3B RID: 85819 RVA: 0x00309C27 File Offset: 0x00307E27
		public void UnPackTo(IShowTimelineCastSkillT _o)
		{
			_o.Type = this.Type;
			_o.SkillId = this.SkillId;
		}

		// Token: 0x06014F3C RID: 85820 RVA: 0x00309C44 File Offset: 0x00307E44
		public static Offset<IShowTimelineCastSkill> Pack(FlatBufferBuilder builder, IShowTimelineCastSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineCastSkill>);
			}
			return IShowTimelineCastSkill.CreateIShowTimelineCastSkill(builder, _o.Type, _o.SkillId);
		}

		// Token: 0x0400B12D RID: 45357
		private Table __p;
	}
}
