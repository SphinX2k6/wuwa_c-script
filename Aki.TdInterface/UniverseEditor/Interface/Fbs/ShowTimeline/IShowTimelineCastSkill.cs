using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003FB8 RID: 16312
	public struct IShowTimelineCastSkill : IFlatbufferObject
	{
		// Token: 0x17006E5C RID: 28252
		// (get) Token: 0x06016405 RID: 91141 RVA: 0x00330335 File Offset: 0x0032E535
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016406 RID: 91142 RVA: 0x00330342 File Offset: 0x0032E542
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016407 RID: 91143 RVA: 0x0033034C File Offset: 0x0032E54C
		public static IShowTimelineCastSkill GetRootAsIShowTimelineCastSkill(ByteBuffer _bb)
		{
			return IShowTimelineCastSkill.GetRootAsIShowTimelineCastSkill(_bb, default(IShowTimelineCastSkill));
		}

		// Token: 0x06016408 RID: 91144 RVA: 0x00330368 File Offset: 0x0032E568
		public static IShowTimelineCastSkill GetRootAsIShowTimelineCastSkill(ByteBuffer _bb, IShowTimelineCastSkill obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016409 RID: 91145 RVA: 0x00330385 File Offset: 0x0032E585
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601640A RID: 91146 RVA: 0x00330394 File Offset: 0x0032E594
		public IShowTimelineCastSkill __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006E5D RID: 28253
		// (get) Token: 0x0601640B RID: 91147 RVA: 0x003303A4 File Offset: 0x0032E5A4
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

		// Token: 0x17006E5E RID: 28254
		// (get) Token: 0x0601640C RID: 91148 RVA: 0x003303E0 File Offset: 0x0032E5E0
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

		// Token: 0x0601640D RID: 91149 RVA: 0x0033041C File Offset: 0x0032E61C
		public static Offset<IShowTimelineCastSkill> CreateIShowTimelineCastSkill(FlatBufferBuilder builder, EShowTimelineActionType Type = EShowTimelineActionType.Skill, int SkillId = 0)
		{
			builder.StartTable(2);
			IShowTimelineCastSkill.AddSkillId(builder, SkillId);
			IShowTimelineCastSkill.AddType(builder, Type);
			return IShowTimelineCastSkill.EndIShowTimelineCastSkill(builder);
		}

		// Token: 0x0601640E RID: 91150 RVA: 0x00330439 File Offset: 0x0032E639
		public static void StartIShowTimelineCastSkill(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601640F RID: 91151 RVA: 0x00330442 File Offset: 0x0032E642
		public static void AddType(FlatBufferBuilder builder, EShowTimelineActionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016410 RID: 91152 RVA: 0x0033044D File Offset: 0x0032E64D
		public static void AddSkillId(FlatBufferBuilder builder, int skillId)
		{
			builder.AddInt(1, skillId, 0);
		}

		// Token: 0x06016411 RID: 91153 RVA: 0x00330458 File Offset: 0x0032E658
		public static Offset<IShowTimelineCastSkill> EndIShowTimelineCastSkill(FlatBufferBuilder builder)
		{
			return new Offset<IShowTimelineCastSkill>(builder.EndTable());
		}

		// Token: 0x06016412 RID: 91154 RVA: 0x00330468 File Offset: 0x0032E668
		public IShowTimelineCastSkillT UnPack()
		{
			IShowTimelineCastSkillT showTimelineCastSkillT = new IShowTimelineCastSkillT();
			this.UnPackTo(showTimelineCastSkillT);
			return showTimelineCastSkillT;
		}

		// Token: 0x06016413 RID: 91155 RVA: 0x00330483 File Offset: 0x0032E683
		public void UnPackTo(IShowTimelineCastSkillT _o)
		{
			_o.Type = this.Type;
			_o.SkillId = this.SkillId;
		}

		// Token: 0x06016414 RID: 91156 RVA: 0x003304A0 File Offset: 0x0032E6A0
		public static Offset<IShowTimelineCastSkill> Pack(FlatBufferBuilder builder, IShowTimelineCastSkillT _o)
		{
			if (_o == null)
			{
				return default(Offset<IShowTimelineCastSkill>);
			}
			return IShowTimelineCastSkill.CreateIShowTimelineCastSkill(builder, _o.Type, _o.SkillId);
		}

		// Token: 0x0400BAAC RID: 47788
		private Table __p;
	}
}
