using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F6E RID: 16238
	public struct IParallaxAlignQuestCondition : IFlatbufferObject
	{
		// Token: 0x170070F1 RID: 28913
		// (get) Token: 0x060171AC RID: 94636 RVA: 0x003545E9 File Offset: 0x003527E9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060171AD RID: 94637 RVA: 0x003545F6 File Offset: 0x003527F6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060171AE RID: 94638 RVA: 0x00354600 File Offset: 0x00352800
		public static IParallaxAlignQuestCondition GetRootAsIParallaxAlignQuestCondition(ByteBuffer _bb)
		{
			return IParallaxAlignQuestCondition.GetRootAsIParallaxAlignQuestCondition(_bb, default(IParallaxAlignQuestCondition));
		}

		// Token: 0x060171AF RID: 94639 RVA: 0x0035461C File Offset: 0x0035281C
		public static IParallaxAlignQuestCondition GetRootAsIParallaxAlignQuestCondition(ByteBuffer _bb, IParallaxAlignQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060171B0 RID: 94640 RVA: 0x00354639 File Offset: 0x00352839
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060171B1 RID: 94641 RVA: 0x00354648 File Offset: 0x00352848
		public IParallaxAlignQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170070F2 RID: 28914
		// (get) Token: 0x060171B2 RID: 94642 RVA: 0x00354658 File Offset: 0x00352858
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

		// Token: 0x170070F3 RID: 28915
		// (get) Token: 0x060171B3 RID: 94643 RVA: 0x00354694 File Offset: 0x00352894
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

		// Token: 0x170070F4 RID: 28916
		// (get) Token: 0x060171B4 RID: 94644 RVA: 0x003546F4 File Offset: 0x003528F4
		public IVectorInfo? SourcePos
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170070F5 RID: 28917
		// (get) Token: 0x060171B5 RID: 94645 RVA: 0x00354754 File Offset: 0x00352954
		public IVectorInfo? TargetPos
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170070F6 RID: 28918
		// (get) Token: 0x060171B6 RID: 94646 RVA: 0x003547B4 File Offset: 0x003529B4
		public float ErrorRange
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170070F7 RID: 28919
		// (get) Token: 0x060171B7 RID: 94647 RVA: 0x003547F8 File Offset: 0x003529F8
		public int BallEntity
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170070F8 RID: 28920
		// (get) Token: 0x060171B8 RID: 94648 RVA: 0x00354838 File Offset: 0x00352A38
		public float BrightnessAdjustRange
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170070F9 RID: 28921
		// (get) Token: 0x060171B9 RID: 94649 RVA: 0x0035487C File Offset: 0x00352A7C
		public float DefaultBrightness
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170070FA RID: 28922
		// (get) Token: 0x060171BA RID: 94650 RVA: 0x003548C0 File Offset: 0x00352AC0
		public IColor? FinalColor
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IColor?(default(IColor).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170070FB RID: 28923
		// (get) Token: 0x060171BB RID: 94651 RVA: 0x00354920 File Offset: 0x00352B20
		public float FixationTime
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170070FC RID: 28924
		// (get) Token: 0x060171BC RID: 94652 RVA: 0x00354964 File Offset: 0x00352B64
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060171BD RID: 94653 RVA: 0x003549A4 File Offset: 0x00352BA4
		public static Offset<IParallaxAlignQuestCondition> CreateIParallaxAlignQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<IVectorInfo> SourcePosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> TargetPosOffset = default(Offset<IVectorInfo>), float ErrorRange = 0f, int BallEntity = 0, float BrightnessAdjustRange = 0f, float DefaultBrightness = 0f, Offset<IColor> FinalColorOffset = default(Offset<IColor>), float FixationTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(11);
			IParallaxAlignQuestCondition.AddFixationTime(builder, FixationTime);
			IParallaxAlignQuestCondition.AddFinalColor(builder, FinalColorOffset);
			IParallaxAlignQuestCondition.AddDefaultBrightness(builder, DefaultBrightness);
			IParallaxAlignQuestCondition.AddBrightnessAdjustRange(builder, BrightnessAdjustRange);
			IParallaxAlignQuestCondition.AddBallEntity(builder, BallEntity);
			IParallaxAlignQuestCondition.AddErrorRange(builder, ErrorRange);
			IParallaxAlignQuestCondition.AddTargetPos(builder, TargetPosOffset);
			IParallaxAlignQuestCondition.AddSourcePos(builder, SourcePosOffset);
			IParallaxAlignQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IParallaxAlignQuestCondition.AddNullMask(builder, NullMask);
			IParallaxAlignQuestCondition.AddType(builder, Type);
			return IParallaxAlignQuestCondition.EndIParallaxAlignQuestCondition(builder);
		}

		// Token: 0x060171BE RID: 94654 RVA: 0x00354A14 File Offset: 0x00352C14
		public static void StartIParallaxAlignQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x060171BF RID: 94655 RVA: 0x00354A1E File Offset: 0x00352C1E
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060171C0 RID: 94656 RVA: 0x00354A29 File Offset: 0x00352C29
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x060171C1 RID: 94657 RVA: 0x00354A39 File Offset: 0x00352C39
		public static void AddSourcePos(FlatBufferBuilder builder, Offset<IVectorInfo> sourcePosOffset)
		{
			builder.AddOffset(2, sourcePosOffset.Value, 0);
		}

		// Token: 0x060171C2 RID: 94658 RVA: 0x00354A49 File Offset: 0x00352C49
		public static void AddTargetPos(FlatBufferBuilder builder, Offset<IVectorInfo> targetPosOffset)
		{
			builder.AddOffset(3, targetPosOffset.Value, 0);
		}

		// Token: 0x060171C3 RID: 94659 RVA: 0x00354A59 File Offset: 0x00352C59
		public static void AddErrorRange(FlatBufferBuilder builder, float errorRange)
		{
			builder.AddFloat(4, errorRange, 0.0);
		}

		// Token: 0x060171C4 RID: 94660 RVA: 0x00354A6C File Offset: 0x00352C6C
		public static void AddBallEntity(FlatBufferBuilder builder, int ballEntity)
		{
			builder.AddInt(5, ballEntity, 0);
		}

		// Token: 0x060171C5 RID: 94661 RVA: 0x00354A77 File Offset: 0x00352C77
		public static void AddBrightnessAdjustRange(FlatBufferBuilder builder, float brightnessAdjustRange)
		{
			builder.AddFloat(6, brightnessAdjustRange, 0.0);
		}

		// Token: 0x060171C6 RID: 94662 RVA: 0x00354A8A File Offset: 0x00352C8A
		public static void AddDefaultBrightness(FlatBufferBuilder builder, float defaultBrightness)
		{
			builder.AddFloat(7, defaultBrightness, 0.0);
		}

		// Token: 0x060171C7 RID: 94663 RVA: 0x00354A9D File Offset: 0x00352C9D
		public static void AddFinalColor(FlatBufferBuilder builder, Offset<IColor> finalColorOffset)
		{
			builder.AddOffset(8, finalColorOffset.Value, 0);
		}

		// Token: 0x060171C8 RID: 94664 RVA: 0x00354AAD File Offset: 0x00352CAD
		public static void AddFixationTime(FlatBufferBuilder builder, float fixationTime)
		{
			builder.AddFloat(9, fixationTime, 0.0);
		}

		// Token: 0x060171C9 RID: 94665 RVA: 0x00354AC1 File Offset: 0x00352CC1
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x060171CA RID: 94666 RVA: 0x00354ACD File Offset: 0x00352CCD
		public static Offset<IParallaxAlignQuestCondition> EndIParallaxAlignQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IParallaxAlignQuestCondition>(builder.EndTable());
		}

		// Token: 0x060171CB RID: 94667 RVA: 0x00354ADC File Offset: 0x00352CDC
		public IParallaxAlignQuestConditionT UnPack()
		{
			IParallaxAlignQuestConditionT parallaxAlignQuestConditionT = new IParallaxAlignQuestConditionT();
			this.UnPackTo(parallaxAlignQuestConditionT);
			return parallaxAlignQuestConditionT;
		}

		// Token: 0x060171CC RID: 94668 RVA: 0x00354AF8 File Offset: 0x00352CF8
		public void UnPackTo(IParallaxAlignQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.SourcePos = ((this.SourcePos != null) ? this.SourcePos.Value.UnPack() : null);
			_o.TargetPos = ((this.TargetPos != null) ? this.TargetPos.Value.UnPack() : null);
			_o.ErrorRange = this.ErrorRange;
			_o.BallEntity = this.BallEntity;
			_o.BrightnessAdjustRange = this.BrightnessAdjustRange;
			_o.DefaultBrightness = this.DefaultBrightness;
			_o.FinalColor = ((this.FinalColor != null) ? this.FinalColor.Value.UnPack() : null);
			_o.FixationTime = this.FixationTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060171CD RID: 94669 RVA: 0x00354C18 File Offset: 0x00352E18
		public static Offset<IParallaxAlignQuestCondition> Pack(FlatBufferBuilder builder, IParallaxAlignQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IParallaxAlignQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			Offset<IVectorInfo> sourcePosOffset = (_o.SourcePos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.SourcePos);
			Offset<IVectorInfo> targetPosOffset = (_o.TargetPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.TargetPos);
			Offset<IColor> finalColorOffset = (_o.FinalColor == null) ? default(Offset<IColor>) : IColor.Pack(builder, _o.FinalColor);
			return IParallaxAlignQuestCondition.CreateIParallaxAlignQuestCondition(builder, _o.Type, preConditionsOffset, sourcePosOffset, targetPosOffset, _o.ErrorRange, _o.BallEntity, _o.BrightnessAdjustRange, _o.DefaultBrightness, finalColorOffset, _o.FixationTime, _o.NullMask);
		}

		// Token: 0x0400B98D RID: 47501
		private Table __p;
	}
}
