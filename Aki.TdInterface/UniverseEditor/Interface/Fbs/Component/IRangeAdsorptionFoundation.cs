using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DFD RID: 24061
	public struct IRangeAdsorptionFoundation : IFlatbufferObject
	{
		// Token: 0x1700B153 RID: 45395
		// (get) Token: 0x060282A2 RID: 164514 RVA: 0x0057E2BA File Offset: 0x0057C4BA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060282A3 RID: 164515 RVA: 0x0057E2C7 File Offset: 0x0057C4C7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060282A4 RID: 164516 RVA: 0x0057E2D0 File Offset: 0x0057C4D0
		public static IRangeAdsorptionFoundation GetRootAsIRangeAdsorptionFoundation(ByteBuffer _bb)
		{
			return IRangeAdsorptionFoundation.GetRootAsIRangeAdsorptionFoundation(_bb, default(IRangeAdsorptionFoundation));
		}

		// Token: 0x060282A5 RID: 164517 RVA: 0x0057E2EC File Offset: 0x0057C4EC
		public static IRangeAdsorptionFoundation GetRootAsIRangeAdsorptionFoundation(ByteBuffer _bb, IRangeAdsorptionFoundation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060282A6 RID: 164518 RVA: 0x0057E309 File Offset: 0x0057C509
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060282A7 RID: 164519 RVA: 0x0057E318 File Offset: 0x0057C518
		public IRangeAdsorptionFoundation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B154 RID: 45396
		// (get) Token: 0x060282A8 RID: 164520 RVA: 0x0057E328 File Offset: 0x0057C528
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

		// Token: 0x1700B155 RID: 45397
		// (get) Token: 0x060282A9 RID: 164521 RVA: 0x0057E364 File Offset: 0x0057C564
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

		// Token: 0x1700B156 RID: 45398
		// (get) Token: 0x060282AA RID: 164522 RVA: 0x0057E3C4 File Offset: 0x0057C5C4
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

		// Token: 0x1700B157 RID: 45399
		// (get) Token: 0x060282AB RID: 164523 RVA: 0x0057E424 File Offset: 0x0057C624
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

		// Token: 0x1700B158 RID: 45400
		// (get) Token: 0x060282AC RID: 164524 RVA: 0x0057E484 File Offset: 0x0057C684
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

		// Token: 0x060282AD RID: 164525 RVA: 0x0057E4E2 File Offset: 0x0057C6E2
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

		// Token: 0x060282AE RID: 164526 RVA: 0x0057E516 File Offset: 0x0057C716
		public static void StartIRangeAdsorptionFoundation(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060282AF RID: 164527 RVA: 0x0057E51F File Offset: 0x0057C71F
		public static void AddType(FlatBufferBuilder builder, EItemFoundation type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060282B0 RID: 164528 RVA: 0x0057E52A File Offset: 0x0057C72A
		public static void AddCondition(FlatBufferBuilder builder, Offset<ICategoryMatchingCondition> conditionOffset)
		{
			builder.AddOffset(1, conditionOffset.Value, 0);
		}

		// Token: 0x060282B1 RID: 164529 RVA: 0x0057E53A File Offset: 0x0057C73A
		public static void AddAnimation(FlatBufferBuilder builder, Offset<IAdsorptionMatchingAnimation> animationOffset)
		{
			builder.AddOffset(2, animationOffset.Value, 0);
		}

		// Token: 0x060282B2 RID: 164530 RVA: 0x0057E54A File Offset: 0x0057C74A
		public static void AddCategoryAnimation(FlatBufferBuilder builder, Offset<ICategoryMatchingAnimation> categoryAnimationOffset)
		{
			builder.AddOffset(3, categoryAnimationOffset.Value, 0);
		}

		// Token: 0x060282B3 RID: 164531 RVA: 0x0057E55A File Offset: 0x0057C75A
		public static void AddCallback(FlatBufferBuilder builder, Offset<ICategoryMatchingSucceed> callbackOffset)
		{
			builder.AddOffset(4, callbackOffset.Value, 0);
		}

		// Token: 0x060282B4 RID: 164532 RVA: 0x0057E56A File Offset: 0x0057C76A
		public static Offset<IRangeAdsorptionFoundation> EndIRangeAdsorptionFoundation(FlatBufferBuilder builder)
		{
			return new Offset<IRangeAdsorptionFoundation>(builder.EndTable());
		}

		// Token: 0x060282B5 RID: 164533 RVA: 0x0057E578 File Offset: 0x0057C778
		public IRangeAdsorptionFoundationT UnPack()
		{
			IRangeAdsorptionFoundationT rangeAdsorptionFoundationT = new IRangeAdsorptionFoundationT();
			this.UnPackTo(rangeAdsorptionFoundationT);
			return rangeAdsorptionFoundationT;
		}

		// Token: 0x060282B6 RID: 164534 RVA: 0x0057E594 File Offset: 0x0057C794
		public void UnPackTo(IRangeAdsorptionFoundationT _o)
		{
			_o.Type = this.Type;
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Animation = ((this.Animation != null) ? this.Animation.Value.UnPack() : null);
			_o.CategoryAnimation = ((this.CategoryAnimation != null) ? this.CategoryAnimation.Value.UnPack() : null);
			_o.Callback = ((this.Callback != null) ? this.Callback.Value.UnPack() : null);
		}

		// Token: 0x060282B7 RID: 164535 RVA: 0x0057E670 File Offset: 0x0057C870
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

		// Token: 0x0400F9D4 RID: 63956
		private Table __p;
	}
}
