using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005493 RID: 21651
	public struct ICategoryMatchingConfig : IFlatbufferObject
	{
		// Token: 0x17009A33 RID: 39475
		// (get) Token: 0x06022103 RID: 139523 RVA: 0x004B20B4 File Offset: 0x004B02B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022104 RID: 139524 RVA: 0x004B20C1 File Offset: 0x004B02C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022105 RID: 139525 RVA: 0x004B20C8 File Offset: 0x004B02C8
		public static ICategoryMatchingConfig GetRootAsICategoryMatchingConfig(ByteBuffer _bb)
		{
			return ICategoryMatchingConfig.GetRootAsICategoryMatchingConfig(_bb, default(ICategoryMatchingConfig));
		}

		// Token: 0x06022106 RID: 139526 RVA: 0x004B20E4 File Offset: 0x004B02E4
		public static ICategoryMatchingConfig GetRootAsICategoryMatchingConfig(ByteBuffer _bb, ICategoryMatchingConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022107 RID: 139527 RVA: 0x004B2101 File Offset: 0x004B0301
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022108 RID: 139528 RVA: 0x004B2110 File Offset: 0x004B0310
		public ICategoryMatchingConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A34 RID: 39476
		// (get) Token: 0x06022109 RID: 139529 RVA: 0x004B2120 File Offset: 0x004B0320
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

		// Token: 0x17009A35 RID: 39477
		// (get) Token: 0x0602210A RID: 139530 RVA: 0x004B2180 File Offset: 0x004B0380
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

		// Token: 0x17009A36 RID: 39478
		// (get) Token: 0x0602210B RID: 139531 RVA: 0x004B21E0 File Offset: 0x004B03E0
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

		// Token: 0x17009A37 RID: 39479
		// (get) Token: 0x0602210C RID: 139532 RVA: 0x004B2240 File Offset: 0x004B0440
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

		// Token: 0x0602210D RID: 139533 RVA: 0x004B229E File Offset: 0x004B049E
		public static Offset<ICategoryMatchingConfig> CreateICategoryMatchingConfig(FlatBufferBuilder builder, Offset<ICategoryMatchingCondition> ConditionOffset = default(Offset<ICategoryMatchingCondition>), Offset<ICategoryMatchingAnimation> AnimationOffset = default(Offset<ICategoryMatchingAnimation>), Offset<ICategoryMatchingSucceed> CallbackOffset = default(Offset<ICategoryMatchingSucceed>), Offset<IItemLockingConfig> ItemLockingConfigOffset = default(Offset<IItemLockingConfig>))
		{
			builder.StartTable(4);
			ICategoryMatchingConfig.AddItemLockingConfig(builder, ItemLockingConfigOffset);
			ICategoryMatchingConfig.AddCallback(builder, CallbackOffset);
			ICategoryMatchingConfig.AddAnimation(builder, AnimationOffset);
			ICategoryMatchingConfig.AddCondition(builder, ConditionOffset);
			return ICategoryMatchingConfig.EndICategoryMatchingConfig(builder);
		}

		// Token: 0x0602210E RID: 139534 RVA: 0x004B22CA File Offset: 0x004B04CA
		public static void StartICategoryMatchingConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602210F RID: 139535 RVA: 0x004B22D3 File Offset: 0x004B04D3
		public static void AddCondition(FlatBufferBuilder builder, Offset<ICategoryMatchingCondition> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x06022110 RID: 139536 RVA: 0x004B22E3 File Offset: 0x004B04E3
		public static void AddAnimation(FlatBufferBuilder builder, Offset<ICategoryMatchingAnimation> animationOffset)
		{
			builder.AddOffset(1, animationOffset.Value, 0);
		}

		// Token: 0x06022111 RID: 139537 RVA: 0x004B22F3 File Offset: 0x004B04F3
		public static void AddCallback(FlatBufferBuilder builder, Offset<ICategoryMatchingSucceed> callbackOffset)
		{
			builder.AddOffset(2, callbackOffset.Value, 0);
		}

		// Token: 0x06022112 RID: 139538 RVA: 0x004B2303 File Offset: 0x004B0503
		public static void AddItemLockingConfig(FlatBufferBuilder builder, Offset<IItemLockingConfig> itemLockingConfigOffset)
		{
			builder.AddOffset(3, itemLockingConfigOffset.Value, 0);
		}

		// Token: 0x06022113 RID: 139539 RVA: 0x004B2313 File Offset: 0x004B0513
		public static Offset<ICategoryMatchingConfig> EndICategoryMatchingConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICategoryMatchingConfig>(builder.EndTable());
		}

		// Token: 0x06022114 RID: 139540 RVA: 0x004B2320 File Offset: 0x004B0520
		public ICategoryMatchingConfigT UnPack()
		{
			ICategoryMatchingConfigT categoryMatchingConfigT = new ICategoryMatchingConfigT();
			this.UnPackTo(categoryMatchingConfigT);
			return categoryMatchingConfigT;
		}

		// Token: 0x06022115 RID: 139541 RVA: 0x004B233C File Offset: 0x004B053C
		public void UnPackTo(ICategoryMatchingConfigT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Animation = ((this.Animation != null) ? this.Animation.Value.UnPack() : null);
			_o.Callback = ((this.Callback != null) ? this.Callback.Value.UnPack() : null);
			_o.ItemLockingConfig = ((this.ItemLockingConfig != null) ? this.ItemLockingConfig.Value.UnPack() : null);
		}

		// Token: 0x06022116 RID: 139542 RVA: 0x004B240C File Offset: 0x004B060C
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

		// Token: 0x0400E99F RID: 59807
		private Table __p;
	}
}
