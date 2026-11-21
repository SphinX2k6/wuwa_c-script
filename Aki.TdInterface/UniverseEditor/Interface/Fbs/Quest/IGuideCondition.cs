using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042BF RID: 17087
	public struct IGuideCondition : IFlatbufferObject
	{
		// Token: 0x170074EB RID: 29931
		// (get) Token: 0x06017F2D RID: 98093 RVA: 0x0036B614 File Offset: 0x00369814
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017F2E RID: 98094 RVA: 0x0036B621 File Offset: 0x00369821
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017F2F RID: 98095 RVA: 0x0036B628 File Offset: 0x00369828
		public static IGuideCondition GetRootAsIGuideCondition(ByteBuffer _bb)
		{
			return IGuideCondition.GetRootAsIGuideCondition(_bb, default(IGuideCondition));
		}

		// Token: 0x06017F30 RID: 98096 RVA: 0x0036B644 File Offset: 0x00369844
		public static IGuideCondition GetRootAsIGuideCondition(ByteBuffer _bb, IGuideCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017F31 RID: 98097 RVA: 0x0036B661 File Offset: 0x00369861
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017F32 RID: 98098 RVA: 0x0036B670 File Offset: 0x00369870
		public IGuideCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074EC RID: 29932
		// (get) Token: 0x06017F33 RID: 98099 RVA: 0x0036B680 File Offset: 0x00369880
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

		// Token: 0x170074ED RID: 29933
		// (get) Token: 0x06017F34 RID: 98100 RVA: 0x0036B6BC File Offset: 0x003698BC
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

		// Token: 0x170074EE RID: 29934
		// (get) Token: 0x06017F35 RID: 98101 RVA: 0x0036B71C File Offset: 0x0036991C
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

		// Token: 0x06017F36 RID: 98102 RVA: 0x0036B758 File Offset: 0x00369958
		public static Offset<IGuideCondition> CreateIGuideCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), int GuideGroupId = 0)
		{
			builder.StartTable(3);
			IGuideCondition.AddGuideGroupId(builder, GuideGroupId);
			IGuideCondition.AddPreConditions(builder, PreConditionsOffset);
			IGuideCondition.AddType(builder, Type);
			return IGuideCondition.EndIGuideCondition(builder);
		}

		// Token: 0x06017F37 RID: 98103 RVA: 0x0036B77C File Offset: 0x0036997C
		public static void StartIGuideCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06017F38 RID: 98104 RVA: 0x0036B785 File Offset: 0x00369985
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017F39 RID: 98105 RVA: 0x0036B790 File Offset: 0x00369990
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06017F3A RID: 98106 RVA: 0x0036B7A0 File Offset: 0x003699A0
		public static void AddGuideGroupId(FlatBufferBuilder builder, int guideGroupId)
		{
			builder.AddInt(2, guideGroupId, 0);
		}

		// Token: 0x06017F3B RID: 98107 RVA: 0x0036B7AB File Offset: 0x003699AB
		public static Offset<IGuideCondition> EndIGuideCondition(FlatBufferBuilder builder)
		{
			return new Offset<IGuideCondition>(builder.EndTable());
		}

		// Token: 0x06017F3C RID: 98108 RVA: 0x0036B7B8 File Offset: 0x003699B8
		public IGuideConditionT UnPack()
		{
			IGuideConditionT guideConditionT = new IGuideConditionT();
			this.UnPackTo(guideConditionT);
			return guideConditionT;
		}

		// Token: 0x06017F3D RID: 98109 RVA: 0x0036B7D4 File Offset: 0x003699D4
		public void UnPackTo(IGuideConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.GuideGroupId = this.GuideGroupId;
		}

		// Token: 0x06017F3E RID: 98110 RVA: 0x0036B828 File Offset: 0x00369A28
		public static Offset<IGuideCondition> Pack(FlatBufferBuilder builder, IGuideConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGuideCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			return IGuideCondition.CreateIGuideCondition(builder, _o.Type, preConditionsOffset, _o.GuideGroupId);
		}

		// Token: 0x0400C218 RID: 49688
		private Table __p;
	}
}
