using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E84 RID: 16004
	public struct IGuideCondition : IFlatbufferObject
	{
		// Token: 0x17006F03 RID: 28419
		// (get) Token: 0x060168F6 RID: 92406 RVA: 0x00342890 File Offset: 0x00340A90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060168F7 RID: 92407 RVA: 0x0034289D File Offset: 0x00340A9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060168F8 RID: 92408 RVA: 0x003428A4 File Offset: 0x00340AA4
		public static IGuideCondition GetRootAsIGuideCondition(ByteBuffer _bb)
		{
			return IGuideCondition.GetRootAsIGuideCondition(_bb, default(IGuideCondition));
		}

		// Token: 0x060168F9 RID: 92409 RVA: 0x003428C0 File Offset: 0x00340AC0
		public static IGuideCondition GetRootAsIGuideCondition(ByteBuffer _bb, IGuideCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060168FA RID: 92410 RVA: 0x003428DD File Offset: 0x00340ADD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060168FB RID: 92411 RVA: 0x003428EC File Offset: 0x00340AEC
		public IGuideCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006F04 RID: 28420
		// (get) Token: 0x060168FC RID: 92412 RVA: 0x003428FC File Offset: 0x00340AFC
		public EChildQuest Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EChildQuest.DoInteract;
				}
				return (EChildQuest)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17006F05 RID: 28421
		// (get) Token: 0x060168FD RID: 92413 RVA: 0x00342938 File Offset: 0x00340B38
		public IConditionGroup? PreConditions
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006F06 RID: 28422
		// (get) Token: 0x060168FE RID: 92414 RVA: 0x00342998 File Offset: 0x00340B98
		public int GuideGroupId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060168FF RID: 92415 RVA: 0x003429D4 File Offset: 0x00340BD4
		public static Offset<IGuideCondition> CreateIGuideCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int GuideGroupId = 0)
		{
			builder.StartTable(3);
			IGuideCondition.AddGuideGroupId(builder, GuideGroupId);
			IGuideCondition.AddPreConditions(builder, PreConditionsOffset);
			IGuideCondition.AddType(builder, Type);
			return IGuideCondition.EndIGuideCondition(builder);
		}

		// Token: 0x06016900 RID: 92416 RVA: 0x003429F8 File Offset: 0x00340BF8
		public static void StartIGuideCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06016901 RID: 92417 RVA: 0x00342A01 File Offset: 0x00340C01
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016902 RID: 92418 RVA: 0x00342A0C File Offset: 0x00340C0C
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06016903 RID: 92419 RVA: 0x00342A1C File Offset: 0x00340C1C
		public static void AddGuideGroupId(FlatBufferBuilder builder, int guideGroupId)
		{
			builder.AddInt(2, guideGroupId, 0);
		}

		// Token: 0x06016904 RID: 92420 RVA: 0x00342A27 File Offset: 0x00340C27
		public static Offset<IGuideCondition> EndIGuideCondition(FlatBufferBuilder builder)
		{
			return new Offset<IGuideCondition>(builder.EndTable());
		}

		// Token: 0x06016905 RID: 92421 RVA: 0x00342A34 File Offset: 0x00340C34
		public IGuideConditionT UnPack()
		{
			IGuideConditionT guideConditionT = new IGuideConditionT();
			this.UnPackTo(guideConditionT);
			return guideConditionT;
		}

		// Token: 0x06016906 RID: 92422 RVA: 0x00342A50 File Offset: 0x00340C50
		public void UnPackTo(IGuideConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.GuideGroupId = this.GuideGroupId;
		}

		// Token: 0x06016907 RID: 92423 RVA: 0x00342AA4 File Offset: 0x00340CA4
		public static Offset<IGuideCondition> Pack(FlatBufferBuilder builder, IGuideConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGuideCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return IGuideCondition.CreateIGuideCondition(builder, _o.Type, preConditionsOffset, _o.GuideGroupId);
		}

		// Token: 0x0400B83F RID: 47167
		private Table __p;
	}
}
