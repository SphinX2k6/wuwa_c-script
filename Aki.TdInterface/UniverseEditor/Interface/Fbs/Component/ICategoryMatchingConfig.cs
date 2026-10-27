using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F64 RID: 20324
	public struct ICategoryMatchingConfig : IFlatbufferObject
	{
		// Token: 0x170092BA RID: 37562
		// (get) Token: 0x060203B1 RID: 132017 RVA: 0x0047C0C4 File Offset: 0x0047A2C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060203B2 RID: 132018 RVA: 0x0047C0D1 File Offset: 0x0047A2D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060203B3 RID: 132019 RVA: 0x0047C0D8 File Offset: 0x0047A2D8
		public static ICategoryMatchingConfig GetRootAsICategoryMatchingConfig(ByteBuffer _bb)
		{
			return ICategoryMatchingConfig.GetRootAsICategoryMatchingConfig(_bb, default(ICategoryMatchingConfig));
		}

		// Token: 0x060203B4 RID: 132020 RVA: 0x0047C0F4 File Offset: 0x0047A2F4
		public static ICategoryMatchingConfig GetRootAsICategoryMatchingConfig(ByteBuffer _bb, ICategoryMatchingConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060203B5 RID: 132021 RVA: 0x0047C111 File Offset: 0x0047A311
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060203B6 RID: 132022 RVA: 0x0047C120 File Offset: 0x0047A320
		public ICategoryMatchingConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092BB RID: 37563
		// (get) Token: 0x060203B7 RID: 132023 RVA: 0x0047C130 File Offset: 0x0047A330
		public ICategoryMatchingCondition? Condition
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ICategoryMatchingCondition?(default(ICategoryMatchingCondition).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170092BC RID: 37564
		// (get) Token: 0x060203B8 RID: 132024 RVA: 0x0047C190 File Offset: 0x0047A390
		public ICategoryMatchingAnimation? Animation
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICategoryMatchingAnimation?(default(ICategoryMatchingAnimation).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170092BD RID: 37565
		// (get) Token: 0x060203B9 RID: 132025 RVA: 0x0047C1F0 File Offset: 0x0047A3F0
		public ICategoryMatchingSucceed? Callback
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ICategoryMatchingSucceed?(default(ICategoryMatchingSucceed).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170092BE RID: 37566
		// (get) Token: 0x060203BA RID: 132026 RVA: 0x0047C250 File Offset: 0x0047A450
		public IItemLockingConfig? ItemLockingConfig
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IItemLockingConfig?(default(IItemLockingConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060203BB RID: 132027 RVA: 0x0047C2AE File Offset: 0x0047A4AE
		public static Offset<ICategoryMatchingConfig> CreateICategoryMatchingConfig(FlatBufferBuilder builder, Offset<ICategoryMatchingCondition> ConditionOffset = default(Offset<ICategoryMatchingCondition>), Offset<ICategoryMatchingAnimation> AnimationOffset = default(Offset<ICategoryMatchingAnimation>), Offset<ICategoryMatchingSucceed> CallbackOffset = default(Offset<ICategoryMatchingSucceed>), Offset<IItemLockingConfig> ItemLockingConfigOffset = default(Offset<IItemLockingConfig>))
		{
			builder.StartTable(4);
			ICategoryMatchingConfig.AddItemLockingConfig(builder, ItemLockingConfigOffset);
			ICategoryMatchingConfig.AddCallback(builder, CallbackOffset);
			ICategoryMatchingConfig.AddAnimation(builder, AnimationOffset);
			ICategoryMatchingConfig.AddCondition(builder, ConditionOffset);
			return ICategoryMatchingConfig.EndICategoryMatchingConfig(builder);
		}

		// Token: 0x060203BC RID: 132028 RVA: 0x0047C2DA File Offset: 0x0047A4DA
		public static void StartICategoryMatchingConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060203BD RID: 132029 RVA: 0x0047C2E3 File Offset: 0x0047A4E3
		public static void AddCondition(FlatBufferBuilder builder, Offset<ICategoryMatchingCondition> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x060203BE RID: 132030 RVA: 0x0047C2F3 File Offset: 0x0047A4F3
		public static void AddAnimation(FlatBufferBuilder builder, Offset<ICategoryMatchingAnimation> animationOffset)
		{
			builder.AddOffset(1, animationOffset.Value, 0);
		}

		// Token: 0x060203BF RID: 132031 RVA: 0x0047C303 File Offset: 0x0047A503
		public static void AddCallback(FlatBufferBuilder builder, Offset<ICategoryMatchingSucceed> callbackOffset)
		{
			builder.AddOffset(2, callbackOffset.Value, 0);
		}

		// Token: 0x060203C0 RID: 132032 RVA: 0x0047C313 File Offset: 0x0047A513
		public static void AddItemLockingConfig(FlatBufferBuilder builder, Offset<IItemLockingConfig> itemLockingConfigOffset)
		{
			builder.AddOffset(3, itemLockingConfigOffset.Value, 0);
		}

		// Token: 0x060203C1 RID: 132033 RVA: 0x0047C323 File Offset: 0x0047A523
		public static Offset<ICategoryMatchingConfig> EndICategoryMatchingConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICategoryMatchingConfig>(builder.EndTable());
		}

		// Token: 0x060203C2 RID: 132034 RVA: 0x0047C330 File Offset: 0x0047A530
		public ICategoryMatchingConfigT UnPack()
		{
			ICategoryMatchingConfigT categoryMatchingConfigT = new ICategoryMatchingConfigT();
			this.UnPackTo(categoryMatchingConfigT);
			return categoryMatchingConfigT;
		}

		// Token: 0x060203C3 RID: 132035 RVA: 0x0047C34C File Offset: 0x0047A54C
		public void UnPackTo(ICategoryMatchingConfigT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Animation = ((this.Animation != null) ? this.Animation.Value.UnPack() : null);
			_o.Callback = ((this.Callback != null) ? this.Callback.Value.UnPack() : null);
			_o.ItemLockingConfig = ((this.ItemLockingConfig != null) ? this.ItemLockingConfig.Value.UnPack() : null);
		}

		// Token: 0x060203C4 RID: 132036 RVA: 0x0047C41C File Offset: 0x0047A61C
		public static Offset<ICategoryMatchingConfig> Pack(FlatBufferBuilder builder, ICategoryMatchingConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICategoryMatchingConfig>);
			}
			Offset<ICategoryMatchingCondition> conditionOffset = (_o.Condition == null) ? default(Offset<ICategoryMatchingCondition>) : ICategoryMatchingCondition.Pack(builder, _o.Condition);
			Offset<ICategoryMatchingAnimation> animationOffset = (_o.Animation == null) ? default(Offset<ICategoryMatchingAnimation>) : ICategoryMatchingAnimation.Pack(builder, _o.Animation);
			Offset<ICategoryMatchingSucceed> callbackOffset = (_o.Callback == null) ? default(Offset<ICategoryMatchingSucceed>) : ICategoryMatchingSucceed.Pack(builder, _o.Callback);
			Offset<IItemLockingConfig> itemLockingConfigOffset = (_o.ItemLockingConfig == null) ? default(Offset<IItemLockingConfig>) : IItemLockingConfig.Pack(builder, _o.ItemLockingConfig);
			return ICategoryMatchingConfig.CreateICategoryMatchingConfig(builder, conditionOffset, animationOffset, callbackOffset, itemLockingConfigOffset);
		}

		// Token: 0x0400DDF5 RID: 56821
		private Table __p;
	}
}
