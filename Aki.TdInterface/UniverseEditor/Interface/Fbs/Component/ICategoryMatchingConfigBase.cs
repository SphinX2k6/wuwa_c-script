using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005496 RID: 21654
	public struct ICategoryMatchingConfigBase : IFlatbufferObject
	{
		// Token: 0x17009A3C RID: 39484
		// (get) Token: 0x06022121 RID: 139553 RVA: 0x004B25DB File Offset: 0x004B07DB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022122 RID: 139554 RVA: 0x004B25E8 File Offset: 0x004B07E8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022123 RID: 139555 RVA: 0x004B25F0 File Offset: 0x004B07F0
		public static ICategoryMatchingConfigBase GetRootAsICategoryMatchingConfigBase(ByteBuffer _bb)
		{
			return ICategoryMatchingConfigBase.GetRootAsICategoryMatchingConfigBase(_bb, default(ICategoryMatchingConfigBase));
		}

		// Token: 0x06022124 RID: 139556 RVA: 0x004B260C File Offset: 0x004B080C
		public static ICategoryMatchingConfigBase GetRootAsICategoryMatchingConfigBase(ByteBuffer _bb, ICategoryMatchingConfigBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022125 RID: 139557 RVA: 0x004B2629 File Offset: 0x004B0829
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022126 RID: 139558 RVA: 0x004B2638 File Offset: 0x004B0838
		public ICategoryMatchingConfigBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009A3D RID: 39485
		// (get) Token: 0x06022127 RID: 139559 RVA: 0x004B2648 File Offset: 0x004B0848
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

		// Token: 0x17009A3E RID: 39486
		// (get) Token: 0x06022128 RID: 139560 RVA: 0x004B26A8 File Offset: 0x004B08A8
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

		// Token: 0x17009A3F RID: 39487
		// (get) Token: 0x06022129 RID: 139561 RVA: 0x004B2708 File Offset: 0x004B0908
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

		// Token: 0x0602212A RID: 139562 RVA: 0x004B2765 File Offset: 0x004B0965
		public static Offset<ICategoryMatchingConfigBase> CreateICategoryMatchingConfigBase(FlatBufferBuilder builder, Offset<ICategoryMatchingCondition> ConditionOffset = default(Offset<ICategoryMatchingCondition>), Offset<ICategoryMatchingAnimationBase> AnimationOffset = default(Offset<ICategoryMatchingAnimationBase>), Offset<ICategoryMatchingSucceedBase> CallbackOffset = default(Offset<ICategoryMatchingSucceedBase>))
		{
			builder.StartTable(3);
			ICategoryMatchingConfigBase.AddCallback(builder, CallbackOffset);
			ICategoryMatchingConfigBase.AddAnimation(builder, AnimationOffset);
			ICategoryMatchingConfigBase.AddCondition(builder, ConditionOffset);
			return ICategoryMatchingConfigBase.EndICategoryMatchingConfigBase(builder);
		}

		// Token: 0x0602212B RID: 139563 RVA: 0x004B2789 File Offset: 0x004B0989
		public static void StartICategoryMatchingConfigBase(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602212C RID: 139564 RVA: 0x004B2792 File Offset: 0x004B0992
		public static void AddCondition(FlatBufferBuilder builder, Offset<ICategoryMatchingCondition> conditionOffset)
		{
			builder.AddOffset(0, conditionOffset.Value, 0);
		}

		// Token: 0x0602212D RID: 139565 RVA: 0x004B27A2 File Offset: 0x004B09A2
		public static void AddAnimation(FlatBufferBuilder builder, Offset<ICategoryMatchingAnimationBase> animationOffset)
		{
			builder.AddOffset(1, animationOffset.Value, 0);
		}

		// Token: 0x0602212E RID: 139566 RVA: 0x004B27B2 File Offset: 0x004B09B2
		public static void AddCallback(FlatBufferBuilder builder, Offset<ICategoryMatchingSucceedBase> callbackOffset)
		{
			builder.AddOffset(2, callbackOffset.Value, 0);
		}

		// Token: 0x0602212F RID: 139567 RVA: 0x004B27C2 File Offset: 0x004B09C2
		public static Offset<ICategoryMatchingConfigBase> EndICategoryMatchingConfigBase(FlatBufferBuilder builder)
		{
			return new Offset<ICategoryMatchingConfigBase>(builder.EndTable());
		}

		// Token: 0x06022130 RID: 139568 RVA: 0x004B27D0 File Offset: 0x004B09D0
		public ICategoryMatchingConfigBaseT UnPack()
		{
			ICategoryMatchingConfigBaseT categoryMatchingConfigBaseT = new ICategoryMatchingConfigBaseT();
			this.UnPackTo(categoryMatchingConfigBaseT);
			return categoryMatchingConfigBaseT;
		}

		// Token: 0x06022131 RID: 139569 RVA: 0x004B27EC File Offset: 0x004B09EC
		public void UnPackTo(ICategoryMatchingConfigBaseT _o)
		{
			_o.Condition = ((this.Condition != null) ? this.Condition.Value.UnPack() : null);
			_o.Animation = ((this.Animation != null) ? this.Animation.Value.UnPack() : null);
			_o.Callback = ((this.Callback != null) ? this.Callback.Value.UnPack() : null);
		}

		// Token: 0x06022132 RID: 139570 RVA: 0x004B288C File Offset: 0x004B0A8C
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

		// Token: 0x0400E9A4 RID: 59812
		private Table __p;
	}
}
