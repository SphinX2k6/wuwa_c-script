using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043AC RID: 17324
	public struct IParallaxAlignQuestCondition : IFlatbufferObject
	{
		// Token: 0x170076E2 RID: 30434
		// (get) Token: 0x0601880E RID: 100366 RVA: 0x0037DA5D File Offset: 0x0037BC5D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601880F RID: 100367 RVA: 0x0037DA6A File Offset: 0x0037BC6A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018810 RID: 100368 RVA: 0x0037DA74 File Offset: 0x0037BC74
		public static IParallaxAlignQuestCondition GetRootAsIParallaxAlignQuestCondition(ByteBuffer _bb)
		{
			return IParallaxAlignQuestCondition.GetRootAsIParallaxAlignQuestCondition(_bb, default(IParallaxAlignQuestCondition));
		}

		// Token: 0x06018811 RID: 100369 RVA: 0x0037DA90 File Offset: 0x0037BC90
		public static IParallaxAlignQuestCondition GetRootAsIParallaxAlignQuestCondition(ByteBuffer _bb, IParallaxAlignQuestCondition obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018812 RID: 100370 RVA: 0x0037DAAD File Offset: 0x0037BCAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018813 RID: 100371 RVA: 0x0037DABC File Offset: 0x0037BCBC
		public IParallaxAlignQuestCondition __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170076E3 RID: 30435
		// (get) Token: 0x06018814 RID: 100372 RVA: 0x0037DACC File Offset: 0x0037BCCC
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

		// Token: 0x170076E4 RID: 30436
		// (get) Token: 0x06018815 RID: 100373 RVA: 0x0037DB08 File Offset: 0x0037BD08
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

		// Token: 0x170076E5 RID: 30437
		// (get) Token: 0x06018816 RID: 100374 RVA: 0x0037DB68 File Offset: 0x0037BD68
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

		// Token: 0x170076E6 RID: 30438
		// (get) Token: 0x06018817 RID: 100375 RVA: 0x0037DBC8 File Offset: 0x0037BDC8
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

		// Token: 0x170076E7 RID: 30439
		// (get) Token: 0x06018818 RID: 100376 RVA: 0x0037DC28 File Offset: 0x0037BE28
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

		// Token: 0x06018819 RID: 100377 RVA: 0x0037DC6C File Offset: 0x0037BE6C
		public IParallaxPointPair? ExtraPairs(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new IParallaxPointPair?(default(IParallaxPointPair).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170076E8 RID: 30440
		// (get) Token: 0x0601881A RID: 100378 RVA: 0x0037DCD0 File Offset: 0x0037BED0
		public int ExtraPairsLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170076E9 RID: 30441
		// (get) Token: 0x0601881B RID: 100379 RVA: 0x0037DCFC File Offset: 0x0037BEFC
		public bool DetectMisaligned
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170076EA RID: 30442
		// (get) Token: 0x0601881C RID: 100380 RVA: 0x0037DD3C File Offset: 0x0037BF3C
		public int BallEntity
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170076EB RID: 30443
		// (get) Token: 0x0601881D RID: 100381 RVA: 0x0037DD7C File Offset: 0x0037BF7C
		public float BrightnessAdjustRange
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170076EC RID: 30444
		// (get) Token: 0x0601881E RID: 100382 RVA: 0x0037DDC0 File Offset: 0x0037BFC0
		public float DefaultBrightness
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

		// Token: 0x170076ED RID: 30445
		// (get) Token: 0x0601881F RID: 100383 RVA: 0x0037DE04 File Offset: 0x0037C004
		public IColor? FinalColor
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return null;
				}
				return new IColor?(default(IColor).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170076EE RID: 30446
		// (get) Token: 0x06018820 RID: 100384 RVA: 0x0037DE64 File Offset: 0x0037C064
		public float FixationTime
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170076EF RID: 30447
		// (get) Token: 0x06018821 RID: 100385 RVA: 0x0037DEA8 File Offset: 0x0037C0A8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06018822 RID: 100386 RVA: 0x0037DEE8 File Offset: 0x0037C0E8
		public static Offset<IParallaxAlignQuestCondition> CreateIParallaxAlignQuestCondition(FlatBufferBuilder builder, EChildQuest Type = EChildQuest.DoInteract, Offset<IConditionGroup> PreConditionsOffset = default(Offset<IConditionGroup>), Offset<IVectorInfo> SourcePosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> TargetPosOffset = default(Offset<IVectorInfo>), float ErrorRange = 0f, VectorOffset ExtraPairsOffset = default(VectorOffset), bool DetectMisaligned = false, int BallEntity = 0, float BrightnessAdjustRange = 0f, float DefaultBrightness = 0f, Offset<IColor> FinalColorOffset = default(Offset<IColor>), float FixationTime = 0f, byte NullMask = 0)
		{
			builder.StartTable(13);
			IParallaxAlignQuestCondition.AddFixationTime(builder, FixationTime);
			IParallaxAlignQuestCondition.AddFinalColor(builder, FinalColorOffset);
			IParallaxAlignQuestCondition.AddDefaultBrightness(builder, DefaultBrightness);
			IParallaxAlignQuestCondition.AddBrightnessAdjustRange(builder, BrightnessAdjustRange);
			IParallaxAlignQuestCondition.AddBallEntity(builder, BallEntity);
			IParallaxAlignQuestCondition.AddExtraPairs(builder, ExtraPairsOffset);
			IParallaxAlignQuestCondition.AddErrorRange(builder, ErrorRange);
			IParallaxAlignQuestCondition.AddTargetPos(builder, TargetPosOffset);
			IParallaxAlignQuestCondition.AddSourcePos(builder, SourcePosOffset);
			IParallaxAlignQuestCondition.AddPreConditions(builder, PreConditionsOffset);
			IParallaxAlignQuestCondition.AddNullMask(builder, NullMask);
			IParallaxAlignQuestCondition.AddDetectMisaligned(builder, DetectMisaligned);
			IParallaxAlignQuestCondition.AddType(builder, Type);
			return IParallaxAlignQuestCondition.EndIParallaxAlignQuestCondition(builder);
		}

		// Token: 0x06018823 RID: 100387 RVA: 0x0037DF68 File Offset: 0x0037C168
		public static void StartIParallaxAlignQuestCondition(FlatBufferBuilder builder)
		{
			builder.StartTable(13);
		}

		// Token: 0x06018824 RID: 100388 RVA: 0x0037DF72 File Offset: 0x0037C172
		public static void AddType(FlatBufferBuilder builder, EChildQuest type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06018825 RID: 100389 RVA: 0x0037DF7D File Offset: 0x0037C17D
		public static void AddPreConditions(FlatBufferBuilder builder, Offset<IConditionGroup> preConditionsOffset)
		{
			builder.AddOffset(1, preConditionsOffset.Value, 0);
		}

		// Token: 0x06018826 RID: 100390 RVA: 0x0037DF8D File Offset: 0x0037C18D
		public static void AddSourcePos(FlatBufferBuilder builder, Offset<IVectorInfo> sourcePosOffset)
		{
			builder.AddOffset(2, sourcePosOffset.Value, 0);
		}

		// Token: 0x06018827 RID: 100391 RVA: 0x0037DF9D File Offset: 0x0037C19D
		public static void AddTargetPos(FlatBufferBuilder builder, Offset<IVectorInfo> targetPosOffset)
		{
			builder.AddOffset(3, targetPosOffset.Value, 0);
		}

		// Token: 0x06018828 RID: 100392 RVA: 0x0037DFAD File Offset: 0x0037C1AD
		public static void AddErrorRange(FlatBufferBuilder builder, float errorRange)
		{
			builder.AddFloat(4, errorRange, 0.0);
		}

		// Token: 0x06018829 RID: 100393 RVA: 0x0037DFC0 File Offset: 0x0037C1C0
		public static void AddExtraPairs(FlatBufferBuilder builder, VectorOffset extraPairsOffset)
		{
			builder.AddOffset(5, extraPairsOffset.Value, 0);
		}

		// Token: 0x0601882A RID: 100394 RVA: 0x0037DFD0 File Offset: 0x0037C1D0
		public static VectorOffset CreateExtraPairsVector(FlatBufferBuilder builder, Offset<IParallaxPointPair>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601882B RID: 100395 RVA: 0x0037E010 File Offset: 0x0037C210
		public static VectorOffset CreateExtraPairsVectorBlock(FlatBufferBuilder builder, Offset<IParallaxPointPair>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IParallaxPointPair>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601882C RID: 100396 RVA: 0x0037E02A File Offset: 0x0037C22A
		public static VectorOffset CreateExtraPairsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IParallaxPointPair>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IParallaxPointPair>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601882D RID: 100397 RVA: 0x0037E048 File Offset: 0x0037C248
		public static VectorOffset CreateExtraPairsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IParallaxPointPair>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601882E RID: 100398 RVA: 0x0037E061 File Offset: 0x0037C261
		public static void StartExtraPairsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601882F RID: 100399 RVA: 0x0037E06C File Offset: 0x0037C26C
		public static void AddDetectMisaligned(FlatBufferBuilder builder, bool detectMisaligned)
		{
			builder.AddBool(6, detectMisaligned, false);
		}

		// Token: 0x06018830 RID: 100400 RVA: 0x0037E077 File Offset: 0x0037C277
		public static void AddBallEntity(FlatBufferBuilder builder, int ballEntity)
		{
			builder.AddInt(7, ballEntity, 0);
		}

		// Token: 0x06018831 RID: 100401 RVA: 0x0037E082 File Offset: 0x0037C282
		public static void AddBrightnessAdjustRange(FlatBufferBuilder builder, float brightnessAdjustRange)
		{
			builder.AddFloat(8, brightnessAdjustRange, 0.0);
		}

		// Token: 0x06018832 RID: 100402 RVA: 0x0037E095 File Offset: 0x0037C295
		public static void AddDefaultBrightness(FlatBufferBuilder builder, float defaultBrightness)
		{
			builder.AddFloat(9, defaultBrightness, 0.0);
		}

		// Token: 0x06018833 RID: 100403 RVA: 0x0037E0A9 File Offset: 0x0037C2A9
		public static void AddFinalColor(FlatBufferBuilder builder, Offset<IColor> finalColorOffset)
		{
			builder.AddOffset(10, finalColorOffset.Value, 0);
		}

		// Token: 0x06018834 RID: 100404 RVA: 0x0037E0BA File Offset: 0x0037C2BA
		public static void AddFixationTime(FlatBufferBuilder builder, float fixationTime)
		{
			builder.AddFloat(11, fixationTime, 0.0);
		}

		// Token: 0x06018835 RID: 100405 RVA: 0x0037E0CE File Offset: 0x0037C2CE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(12, nullMask, 0);
		}

		// Token: 0x06018836 RID: 100406 RVA: 0x0037E0DA File Offset: 0x0037C2DA
		public static Offset<IParallaxAlignQuestCondition> EndIParallaxAlignQuestCondition(FlatBufferBuilder builder)
		{
			return new Offset<IParallaxAlignQuestCondition>(builder.EndTable());
		}

		// Token: 0x06018837 RID: 100407 RVA: 0x0037E0E8 File Offset: 0x0037C2E8
		public IParallaxAlignQuestConditionT UnPack()
		{
			IParallaxAlignQuestConditionT parallaxAlignQuestConditionT = new IParallaxAlignQuestConditionT();
			this.UnPackTo(parallaxAlignQuestConditionT);
			return parallaxAlignQuestConditionT;
		}

		// Token: 0x06018838 RID: 100408 RVA: 0x0037E104 File Offset: 0x0037C304
		public void UnPackTo(IParallaxAlignQuestConditionT _o)
		{
			_o.Type = this.Type;
			_o.PreConditions = ((this.PreConditions != null) ? this.PreConditions.Value.UnPack() : null);
			_o.SourcePos = ((this.SourcePos != null) ? this.SourcePos.Value.UnPack() : null);
			_o.TargetPos = ((this.TargetPos != null) ? this.TargetPos.Value.UnPack() : null);
			_o.ErrorRange = this.ErrorRange;
			_o.ExtraPairs = new List<IParallaxPointPairT>();
			for (int i = 0; i < this.ExtraPairsLength; i++)
			{
				_o.ExtraPairs.Add((this.ExtraPairs(i) != null) ? this.ExtraPairs(i).Value.UnPack() : null);
			}
			_o.DetectMisaligned = this.DetectMisaligned;
			_o.BallEntity = this.BallEntity;
			_o.BrightnessAdjustRange = this.BrightnessAdjustRange;
			_o.DefaultBrightness = this.DefaultBrightness;
			_o.FinalColor = ((this.FinalColor != null) ? this.FinalColor.Value.UnPack() : null);
			_o.FixationTime = this.FixationTime;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06018839 RID: 100409 RVA: 0x0037E28C File Offset: 0x0037C48C
		public static Offset<IParallaxAlignQuestCondition> Pack(FlatBufferBuilder builder, IParallaxAlignQuestConditionT _o)
		{
			if (_o == null)
			{
				return default(Offset<IParallaxAlignQuestCondition>);
			}
			Offset<IConditionGroup> preConditionsOffset = (_o.PreConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.PreConditions);
			Offset<IVectorInfo> sourcePosOffset = (_o.SourcePos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.SourcePos);
			Offset<IVectorInfo> targetPosOffset = (_o.TargetPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.TargetPos);
			VectorOffset extraPairsOffset = default(VectorOffset);
			if (_o.ExtraPairs != null)
			{
				Offset<IParallaxPointPair>[] array = new Offset<IParallaxPointPair>[_o.ExtraPairs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IParallaxPointPair.Pack(builder, _o.ExtraPairs[i]);
				}
				extraPairsOffset = IParallaxAlignQuestCondition.CreateExtraPairsVector(builder, array);
			}
			Offset<IColor> finalColorOffset = (_o.FinalColor == null) ? default(Offset<IColor>) : IColor.Pack(builder, _o.FinalColor);
			return IParallaxAlignQuestCondition.CreateIParallaxAlignQuestCondition(builder, _o.Type, preConditionsOffset, sourcePosOffset, targetPosOffset, _o.ErrorRange, extraPairsOffset, _o.DetectMisaligned, _o.BallEntity, _o.BrightnessAdjustRange, _o.DefaultBrightness, finalColorOffset, _o.FixationTime, _o.NullMask);
		}

		// Token: 0x0400C36B RID: 50027
		private Table __p;
	}
}
