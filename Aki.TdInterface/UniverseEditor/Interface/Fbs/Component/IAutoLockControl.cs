using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EE6 RID: 20198
	public struct IAutoLockControl : IFlatbufferObject
	{
		// Token: 0x170090FA RID: 37114
		// (get) Token: 0x0601FD67 RID: 130407 RVA: 0x0046E053 File Offset: 0x0046C253
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601FD68 RID: 130408 RVA: 0x0046E060 File Offset: 0x0046C260
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601FD69 RID: 130409 RVA: 0x0046E068 File Offset: 0x0046C268
		public static IAutoLockControl GetRootAsIAutoLockControl(ByteBuffer _bb)
		{
			return IAutoLockControl.GetRootAsIAutoLockControl(_bb, default(IAutoLockControl));
		}

		// Token: 0x0601FD6A RID: 130410 RVA: 0x0046E084 File Offset: 0x0046C284
		public static IAutoLockControl GetRootAsIAutoLockControl(ByteBuffer _bb, IAutoLockControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601FD6B RID: 130411 RVA: 0x0046E0A1 File Offset: 0x0046C2A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601FD6C RID: 130412 RVA: 0x0046E0B0 File Offset: 0x0046C2B0
		public IAutoLockControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170090FB RID: 37115
		// (get) Token: 0x0601FD6D RID: 130413 RVA: 0x0046E0C0 File Offset: 0x0046C2C0
		public IConditionGroup? EnableCondition
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x170090FC RID: 37116
		// (get) Token: 0x0601FD6E RID: 130414 RVA: 0x0046E120 File Offset: 0x0046C320
		public IConditionGroup? DisableCondition
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

		// Token: 0x0601FD6F RID: 130415 RVA: 0x0046E17D File Offset: 0x0046C37D
		public static Offset<IAutoLockControl> CreateIAutoLockControl(FlatBufferBuilder builder, Offset<IConditionGroup> EnableConditionOffset = default(Offset<IConditionGroup>), Offset<IConditionGroup> DisableConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(2);
			IAutoLockControl.AddDisableCondition(builder, DisableConditionOffset);
			IAutoLockControl.AddEnableCondition(builder, EnableConditionOffset);
			return IAutoLockControl.EndIAutoLockControl(builder);
		}

		// Token: 0x0601FD70 RID: 130416 RVA: 0x0046E19A File Offset: 0x0046C39A
		public static void StartIAutoLockControl(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601FD71 RID: 130417 RVA: 0x0046E1A3 File Offset: 0x0046C3A3
		public static void AddEnableCondition(FlatBufferBuilder builder, Offset<IConditionGroup> enableConditionOffset)
		{
			builder.AddOffset(0, enableConditionOffset.Value, 0);
		}

		// Token: 0x0601FD72 RID: 130418 RVA: 0x0046E1B3 File Offset: 0x0046C3B3
		public static void AddDisableCondition(FlatBufferBuilder builder, Offset<IConditionGroup> disableConditionOffset)
		{
			builder.AddOffset(1, disableConditionOffset.Value, 0);
		}

		// Token: 0x0601FD73 RID: 130419 RVA: 0x0046E1C3 File Offset: 0x0046C3C3
		public static Offset<IAutoLockControl> EndIAutoLockControl(FlatBufferBuilder builder)
		{
			return new Offset<IAutoLockControl>(builder.EndTable());
		}

		// Token: 0x0601FD74 RID: 130420 RVA: 0x0046E1D0 File Offset: 0x0046C3D0
		public IAutoLockControlT UnPack()
		{
			IAutoLockControlT autoLockControlT = new IAutoLockControlT();
			this.UnPackTo(autoLockControlT);
			return autoLockControlT;
		}

		// Token: 0x0601FD75 RID: 130421 RVA: 0x0046E1EC File Offset: 0x0046C3EC
		public void UnPackTo(IAutoLockControlT _o)
		{
			_o.EnableCondition = ((this.EnableCondition != null) ? this.EnableCondition.Value.UnPack() : null);
			_o.DisableCondition = ((this.DisableCondition != null) ? this.DisableCondition.Value.UnPack() : null);
		}

		// Token: 0x0601FD76 RID: 130422 RVA: 0x0046E258 File Offset: 0x0046C458
		public static Offset<IAutoLockControl> Pack(FlatBufferBuilder builder, IAutoLockControlT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAutoLockControl>);
			}
			Offset<IConditionGroup> enableConditionOffset = (_o.EnableCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.EnableCondition);
			Offset<IConditionGroup> disableConditionOffset = (_o.DisableCondition == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.DisableCondition);
			return IAutoLockControl.CreateIAutoLockControl(builder, enableConditionOffset, disableConditionOffset);
		}

		// Token: 0x0400DCEF RID: 56559
		private Table __p;
	}
}
