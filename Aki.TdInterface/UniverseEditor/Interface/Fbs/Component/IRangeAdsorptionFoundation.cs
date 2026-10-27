using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057F6 RID: 22518
	public struct IRangeAdsorptionFoundation : IFlatbufferObject
	{
		// Token: 0x1700A82F RID: 43055
		// (get) Token: 0x06025D82 RID: 155010 RVA: 0x0053812E File Offset: 0x0053632E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025D83 RID: 155011 RVA: 0x0053813B File Offset: 0x0053633B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025D84 RID: 155012 RVA: 0x00538144 File Offset: 0x00536344
		public static IRangeAdsorptionFoundation GetRootAsIRangeAdsorptionFoundation(ByteBuffer _bb)
		{
			return IRangeAdsorptionFoundation.GetRootAsIRangeAdsorptionFoundation(_bb, default(IRangeAdsorptionFoundation));
		}

		// Token: 0x06025D85 RID: 155013 RVA: 0x00538160 File Offset: 0x00536360
		public static IRangeAdsorptionFoundation GetRootAsIRangeAdsorptionFoundation(ByteBuffer _bb, IRangeAdsorptionFoundation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025D86 RID: 155014 RVA: 0x0053817D File Offset: 0x0053637D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025D87 RID: 155015 RVA: 0x0053818C File Offset: 0x0053638C
		public IRangeAdsorptionFoundation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A830 RID: 43056
		// (get) Token: 0x06025D88 RID: 155016 RVA: 0x0053819C File Offset: 0x0053639C
		public EItemFoundation Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EItemFoundation.CategoryMatching;
				}
				return (EItemFoundation)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A831 RID: 43057
		// (get) Token: 0x06025D89 RID: 155017 RVA: 0x005381D8 File Offset: 0x005363D8
		public ICategoryMatchingCondition? Condition
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICategoryMatchingCondition?(default(ICategoryMatchingCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A832 RID: 43058
		// (get) Token: 0x06025D8A RID: 155018 RVA: 0x00538238 File Offset: 0x00536438
		public IAdsorptionMatchingAnimation? Animation
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IAdsorptionMatchingAnimation?(default(IAdsorptionMatchingAnimation).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A833 RID: 43059
		// (get) Token: 0x06025D8B RID: 155019 RVA: 0x00538298 File Offset: 0x00536498
		public ICategoryMatchingAnimation? CategoryAnimation
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ICategoryMatchingAnimation?(default(ICategoryMatchingAnimation).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A834 RID: 43060
		// (get) Token: 0x06025D8C RID: 155020 RVA: 0x005382F8 File Offset: 0x005364F8
		public ICategoryMatchingSucceed? Callback
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new ICategoryMatchingSucceed?(default(ICategoryMatchingSucceed).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06025D8D RID: 155021 RVA: 0x00538356 File Offset: 0x00536556
		public static Offset<IRangeAdsorptionFoundation> CreateIRangeAdsorptionFoundation(FlatBufferBuilder builder, EItemFoundation Type = EItemFoundation.CategoryMatching, Offset<ICategoryMatchingCondition> ConditionOffset = default(Offset<ICategoryMatchingCondition>), Offset<IAdsorptionMatchingAnimation> AnimationOffset = default(Offset<IAdsorptionMatchingAnimation>), Offset<ICategoryMatchingAnimation> CategoryAnimationOffset = default(Offset<ICategoryMatchingAnimation>), Offset<ICategoryMatchingSucceed> CallbackOffset = default(Offset<ICategoryMatchingSucceed>))
		{
			builder.StartTable(5);
			IRangeAdsorptionFoundation.AddCallback(builder, CallbackOffset);
			IRangeAdsorptionFoundation.AddCategoryAnimation(builder, CategoryAnimationOffset);
			IRangeAdsorptionFoundation.AddAnimation(builder, AnimationOffset);
			IRangeAdsorptionFoundation.AddCondition(builder, ConditionOffset);
			IRangeAdsorptionFoundation.AddType(builder, Type);
			return IRangeAdsorptionFoundation.EndIRangeAdsorptionFoundation(builder);
		}

		// Token: 0x06025D8E RID: 155022 RVA: 0x0053838A File Offset: 0x0053658A
		public static void StartIRangeAdsorptionFoundation(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06025D8F RID: 155023 RVA: 0x00538393 File Offset: 0x00536593
		public static void AddType(FlatBufferBuilder builder, EItemFoundation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06025D90 RID: 155024 RVA: 0x0053839E File Offset: 0x0053659E
		public static void AddCondition(FlatBufferBuilder builder, Offset<ICategoryMatchingCondition> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x06025D91 RID: 155025 RVA: 0x005383AE File Offset: 0x005365AE
		public static void AddAnimation(FlatBufferBuilder builder, Offset<IAdsorptionMatchingAnimation> animationOffset)
		{
			builder.AddOffset(2, animationOffset.Value, 0);
		}

		// Token: 0x06025D92 RID: 155026 RVA: 0x005383BE File Offset: 0x005365BE
		public static void AddCategoryAnimation(FlatBufferBuilder builder, Offset<ICategoryMatchingAnimation> categoryAnimationOffset)
		{
			builder.AddOffset(3, categoryAnimationOffset.Value, 0);
		}

		// Token: 0x06025D93 RID: 155027 RVA: 0x005383CE File Offset: 0x005365CE
		public static void AddCallback(FlatBufferBuilder builder, Offset<ICategoryMatchingSucceed> callbackOffset)
		{
			builder.AddOffset(4, callbackOffset.Value, 0);
		}

		// Token: 0x06025D94 RID: 155028 RVA: 0x005383DE File Offset: 0x005365DE
		public static Offset<IRangeAdsorptionFoundation> EndIRangeAdsorptionFoundation(FlatBufferBuilder builder)
		{
			return new Offset<IRangeAdsorptionFoundation>(builder.EndTable());
		}

		// Token: 0x06025D95 RID: 155029 RVA: 0x005383EC File Offset: 0x005365EC
		public IRangeAdsorptionFoundationT UnPack()
		{
			IRangeAdsorptionFoundationT rangeAdsorptionFoundationT = new IRangeAdsorptionFoundationT();
			this.UnPackTo(rangeAdsorptionFoundationT);
			return rangeAdsorptionFoundationT;
		}

		// Token: 0x06025D96 RID: 155030 RVA: 0x00538408 File Offset: 0x00536608
		public void UnPackTo(IRangeAdsorptionFoundationT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Animation = ((this.Animation != null) ? this.Animation.Value.UnPack() : null);
			_o.CategoryAnimation = ((this.CategoryAnimation != null) ? this.CategoryAnimation.Value.UnPack() : null);
			_o.Callback = ((this.Callback != null) ? this.Callback.Value.UnPack() : null);
		}

		// Token: 0x06025D97 RID: 155031 RVA: 0x005384E4 File Offset: 0x005366E4
		public static Offset<IRangeAdsorptionFoundation> Pack(FlatBufferBuilder builder, IRangeAdsorptionFoundationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRangeAdsorptionFoundation>);
			}
			Offset<ICategoryMatchingCondition> conditionOffset = (_o.Condition == null) ? default(Offset<ICategoryMatchingCondition>) : ICategoryMatchingCondition.Pack(builder, _o.Condition);
			Offset<IAdsorptionMatchingAnimation> animationOffset = (_o.Animation == null) ? default(Offset<IAdsorptionMatchingAnimation>) : IAdsorptionMatchingAnimation.Pack(builder, _o.Animation);
			Offset<ICategoryMatchingAnimation> categoryAnimationOffset = (_o.CategoryAnimation == null) ? default(Offset<ICategoryMatchingAnimation>) : ICategoryMatchingAnimation.Pack(builder, _o.CategoryAnimation);
			Offset<ICategoryMatchingSucceed> callbackOffset = (_o.Callback == null) ? default(Offset<ICategoryMatchingSucceed>) : ICategoryMatchingSucceed.Pack(builder, _o.Callback);
			return IRangeAdsorptionFoundation.CreateIRangeAdsorptionFoundation(builder, _o.Type, conditionOffset, animationOffset, categoryAnimationOffset, callbackOffset);
		}

		// Token: 0x0400ECE9 RID: 60649
		private Table __p;
	}
}
