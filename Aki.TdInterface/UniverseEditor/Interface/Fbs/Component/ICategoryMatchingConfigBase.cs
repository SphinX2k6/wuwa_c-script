using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F67 RID: 20327
	public struct ICategoryMatchingConfigBase : IFlatbufferObject
	{
		// Token: 0x170092C3 RID: 37571
		// (get) Token: 0x060203CF RID: 132047 RVA: 0x0047C5EB File Offset: 0x0047A7EB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060203D0 RID: 132048 RVA: 0x0047C5F8 File Offset: 0x0047A7F8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060203D1 RID: 132049 RVA: 0x0047C600 File Offset: 0x0047A800
		public static ICategoryMatchingConfigBase GetRootAsICategoryMatchingConfigBase(ByteBuffer _bb)
		{
			return ICategoryMatchingConfigBase.GetRootAsICategoryMatchingConfigBase(_bb, default(ICategoryMatchingConfigBase));
		}

		// Token: 0x060203D2 RID: 132050 RVA: 0x0047C61C File Offset: 0x0047A81C
		public static ICategoryMatchingConfigBase GetRootAsICategoryMatchingConfigBase(ByteBuffer _bb, ICategoryMatchingConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060203D3 RID: 132051 RVA: 0x0047C639 File Offset: 0x0047A839
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060203D4 RID: 132052 RVA: 0x0047C648 File Offset: 0x0047A848
		public ICategoryMatchingConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170092C4 RID: 37572
		// (get) Token: 0x060203D5 RID: 132053 RVA: 0x0047C658 File Offset: 0x0047A858
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

		// Token: 0x170092C5 RID: 37573
		// (get) Token: 0x060203D6 RID: 132054 RVA: 0x0047C6B8 File Offset: 0x0047A8B8
		public ICategoryMatchingAnimationBase? Animation
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ICategoryMatchingAnimationBase?(default(ICategoryMatchingAnimationBase).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170092C6 RID: 37574
		// (get) Token: 0x060203D7 RID: 132055 RVA: 0x0047C718 File Offset: 0x0047A918
		public ICategoryMatchingSucceedBase? Callback
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ICategoryMatchingSucceedBase?(default(ICategoryMatchingSucceedBase).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060203D8 RID: 132056 RVA: 0x0047C775 File Offset: 0x0047A975
		public static Offset<ICategoryMatchingConfigBase> CreateICategoryMatchingConfigBase(FlatBufferBuilder builder, Offset<ICategoryMatchingCondition> ConditionOffset = default(Offset<ICategoryMatchingCondition>), Offset<ICategoryMatchingAnimationBase> AnimationOffset = default(Offset<ICategoryMatchingAnimationBase>), Offset<ICategoryMatchingSucceedBase> CallbackOffset = default(Offset<ICategoryMatchingSucceedBase>))
		{
			builder.StartTable(3);
			ICategoryMatchingConfigBase.AddCallback(builder, CallbackOffset);
			ICategoryMatchingConfigBase.AddAnimation(builder, AnimationOffset);
			ICategoryMatchingConfigBase.AddCondition(builder, ConditionOffset);
			return ICategoryMatchingConfigBase.EndICategoryMatchingConfigBase(builder);
		}

		// Token: 0x060203D9 RID: 132057 RVA: 0x0047C799 File Offset: 0x0047A999
		public static void StartICategoryMatchingConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060203DA RID: 132058 RVA: 0x0047C7A2 File Offset: 0x0047A9A2
		public static void AddCondition(FlatBufferBuilder builder, Offset<ICategoryMatchingCondition> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x060203DB RID: 132059 RVA: 0x0047C7B2 File Offset: 0x0047A9B2
		public static void AddAnimation(FlatBufferBuilder builder, Offset<ICategoryMatchingAnimationBase> animationOffset)
		{
			builder.AddOffset(1, animationOffset.Value, 0);
		}

		// Token: 0x060203DC RID: 132060 RVA: 0x0047C7C2 File Offset: 0x0047A9C2
		public static void AddCallback(FlatBufferBuilder builder, Offset<ICategoryMatchingSucceedBase> callbackOffset)
		{
			builder.AddOffset(2, callbackOffset.Value, 0);
		}

		// Token: 0x060203DD RID: 132061 RVA: 0x0047C7D2 File Offset: 0x0047A9D2
		public static Offset<ICategoryMatchingConfigBase> EndICategoryMatchingConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<ICategoryMatchingConfigBase>(builder.EndTable());
		}

		// Token: 0x060203DE RID: 132062 RVA: 0x0047C7E0 File Offset: 0x0047A9E0
		public ICategoryMatchingConfigBaseT UnPack()
		{
			ICategoryMatchingConfigBaseT categoryMatchingConfigBaseT = new ICategoryMatchingConfigBaseT();
			this.UnPackTo(categoryMatchingConfigBaseT);
			return categoryMatchingConfigBaseT;
		}

		// Token: 0x060203DF RID: 132063 RVA: 0x0047C7FC File Offset: 0x0047A9FC
		public void UnPackTo(ICategoryMatchingConfigBaseT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Animation = ((this.Animation != null) ? this.Animation.Value.UnPack() : null);
			_o.Callback = ((this.Callback != null) ? this.Callback.Value.UnPack() : null);
		}

		// Token: 0x060203E0 RID: 132064 RVA: 0x0047C89C File Offset: 0x0047AA9C
		public static Offset<ICategoryMatchingConfigBase> Pack(FlatBufferBuilder builder, ICategoryMatchingConfigBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICategoryMatchingConfigBase>);
			}
			Offset<ICategoryMatchingCondition> conditionOffset = (_o.Condition == null) ? default(Offset<ICategoryMatchingCondition>) : ICategoryMatchingCondition.Pack(builder, _o.Condition);
			Offset<ICategoryMatchingAnimationBase> animationOffset = (_o.Animation == null) ? default(Offset<ICategoryMatchingAnimationBase>) : ICategoryMatchingAnimationBase.Pack(builder, _o.Animation);
			Offset<ICategoryMatchingSucceedBase> callbackOffset = (_o.Callback == null) ? default(Offset<ICategoryMatchingSucceedBase>) : ICategoryMatchingSucceedBase.Pack(builder, _o.Callback);
			return ICategoryMatchingConfigBase.CreateICategoryMatchingConfigBase(builder, conditionOffset, animationOffset, callbackOffset);
		}

		// Token: 0x0400DDFA RID: 56826
		private Table __p;
	}
}
