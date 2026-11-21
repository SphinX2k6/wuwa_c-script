using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005415 RID: 21525
	public struct IAutoLockControl : IFlatbufferObject
	{
		// Token: 0x1700986D RID: 39021
		// (get) Token: 0x06021AAB RID: 137899 RVA: 0x004A3E23 File Offset: 0x004A2023
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021AAC RID: 137900 RVA: 0x004A3E30 File Offset: 0x004A2030
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021AAD RID: 137901 RVA: 0x004A3E38 File Offset: 0x004A2038
		public static IAutoLockControl GetRootAsIAutoLockControl(ByteBuffer _bb)
		{
			return IAutoLockControl.GetRootAsIAutoLockControl(_bb, default(IAutoLockControl));
		}

		// Token: 0x06021AAE RID: 137902 RVA: 0x004A3E54 File Offset: 0x004A2054
		public static IAutoLockControl GetRootAsIAutoLockControl(ByteBuffer _bb, IAutoLockControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021AAF RID: 137903 RVA: 0x004A3E71 File Offset: 0x004A2071
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021AB0 RID: 137904 RVA: 0x004A3E80 File Offset: 0x004A2080
		public IAutoLockControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700986E RID: 39022
		// (get) Token: 0x06021AB1 RID: 137905 RVA: 0x004A3E90 File Offset: 0x004A2090
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

		// Token: 0x1700986F RID: 39023
		// (get) Token: 0x06021AB2 RID: 137906 RVA: 0x004A3EF0 File Offset: 0x004A20F0
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

		// Token: 0x06021AB3 RID: 137907 RVA: 0x004A3F4D File Offset: 0x004A214D
		public static Offset<IAutoLockControl> CreateIAutoLockControl(FlatBufferBuilder builder, Offset<IConditionGroup> EnableConditionOffset = default(Offset<IConditionGroup>), Offset<IConditionGroup> DisableConditionOffset = default(Offset<IConditionGroup>))
		{
			builder.StartTable(2);
			IAutoLockControl.AddDisableCondition(builder, DisableConditionOffset);
			IAutoLockControl.AddEnableCondition(builder, EnableConditionOffset);
			return IAutoLockControl.EndIAutoLockControl(builder);
		}

		// Token: 0x06021AB4 RID: 137908 RVA: 0x004A3F6A File Offset: 0x004A216A
		public static void StartIAutoLockControl(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06021AB5 RID: 137909 RVA: 0x004A3F73 File Offset: 0x004A2173
		public static void AddEnableCondition(FlatBufferBuilder builder, Offset<IConditionGroup> enableConditionOffset)
		{
			builder.AddOffset(0, enableConditionOffset.Value, 0);
		}

		// Token: 0x06021AB6 RID: 137910 RVA: 0x004A3F83 File Offset: 0x004A2183
		public static void AddDisableCondition(FlatBufferBuilder builder, Offset<IConditionGroup> disableConditionOffset)
		{
			builder.AddOffset(1, disableConditionOffset.Value, 0);
		}

		// Token: 0x06021AB7 RID: 137911 RVA: 0x004A3F93 File Offset: 0x004A2193
		public static Offset<IAutoLockControl> EndIAutoLockControl(FlatBufferBuilder builder)
		{
			return new Offset<IAutoLockControl>(builder.EndTable());
		}

		// Token: 0x06021AB8 RID: 137912 RVA: 0x004A3FA0 File Offset: 0x004A21A0
		public IAutoLockControlT UnPack()
		{
			IAutoLockControlT autoLockControlT = new IAutoLockControlT();
			this.UnPackTo(autoLockControlT);
			return autoLockControlT;
		}

		// Token: 0x06021AB9 RID: 137913 RVA: 0x004A3FBC File Offset: 0x004A21BC
		public void UnPackTo(IAutoLockControlT _o)
		{
			_o.EnableCondition = ((this.EnableCondition != null) ? this.EnableCondition.Value.UnPack() : null);
			_o.DisableCondition = ((this.DisableCondition != null) ? this.DisableCondition.Value.UnPack() : null);
		}

		// Token: 0x06021ABA RID: 137914 RVA: 0x004A4028 File Offset: 0x004A2228
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

		// Token: 0x0400E896 RID: 59542
		private Table __p;
	}
}
