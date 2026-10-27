using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AF0 RID: 23280
	public struct ITriggerUe5Component : IFlatbufferObject
	{
		// Token: 0x1700AF9A RID: 44954
		// (get) Token: 0x06027BCA RID: 162762 RVA: 0x00577556 File Offset: 0x00575756
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027BCB RID: 162763 RVA: 0x00577563 File Offset: 0x00575763
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027BCC RID: 162764 RVA: 0x0057756C File Offset: 0x0057576C
		public static ITriggerUe5Component GetRootAsITriggerUe5Component(ByteBuffer _bb)
		{
			return ITriggerUe5Component.GetRootAsITriggerUe5Component(_bb, default(ITriggerUe5Component));
		}

		// Token: 0x06027BCD RID: 162765 RVA: 0x00577588 File Offset: 0x00575788
		public static ITriggerUe5Component GetRootAsITriggerUe5Component(ByteBuffer _bb, ITriggerUe5Component obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027BCE RID: 162766 RVA: 0x005775A5 File Offset: 0x005757A5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027BCF RID: 162767 RVA: 0x005775B4 File Offset: 0x005757B4
		public ITriggerUe5Component __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AF9B RID: 44955
		// (get) Token: 0x06027BD0 RID: 162768 RVA: 0x005775C4 File Offset: 0x005757C4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AF9C RID: 44956
		// (get) Token: 0x06027BD1 RID: 162769 RVA: 0x00577604 File Offset: 0x00575804
		public int MaxTriggerTimes
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700AF9D RID: 44957
		// (get) Token: 0x06027BD2 RID: 162770 RVA: 0x00577640 File Offset: 0x00575840
		public bool IsNotLoad
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AF9E RID: 44958
		// (get) Token: 0x06027BD3 RID: 162771 RVA: 0x00577680 File Offset: 0x00575880
		public ITriggerActions? TriggerActions
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ITriggerActions?(default(ITriggerActions).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AF9F RID: 44959
		// (get) Token: 0x06027BD4 RID: 162772 RVA: 0x005776E0 File Offset: 0x005758E0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027BD5 RID: 162773 RVA: 0x0057771D File Offset: 0x0057591D
		public static Offset<ITriggerUe5Component> CreateITriggerUe5Component(FlatBufferBuilder builder, bool Disabled = false, int MaxTriggerTimes = 0, bool IsNotLoad = false, Offset<ITriggerActions> TriggerActionsOffset = default(Offset<ITriggerActions>), byte NullMask = 0)
		{
			builder.StartTable(5);
			ITriggerUe5Component.AddTriggerActions(builder, TriggerActionsOffset);
			ITriggerUe5Component.AddMaxTriggerTimes(builder, MaxTriggerTimes);
			ITriggerUe5Component.AddNullMask(builder, NullMask);
			ITriggerUe5Component.AddIsNotLoad(builder, IsNotLoad);
			ITriggerUe5Component.AddDisabled(builder, Disabled);
			return ITriggerUe5Component.EndITriggerUe5Component(builder);
		}

		// Token: 0x06027BD6 RID: 162774 RVA: 0x00577751 File Offset: 0x00575951
		public static void StartITriggerUe5Component(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06027BD7 RID: 162775 RVA: 0x0057775A File Offset: 0x0057595A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027BD8 RID: 162776 RVA: 0x00577765 File Offset: 0x00575965
		public static void AddMaxTriggerTimes(FlatBufferBuilder builder, int maxTriggerTimes)
		{
			builder.AddInt(1, maxTriggerTimes, 0);
		}

		// Token: 0x06027BD9 RID: 162777 RVA: 0x00577770 File Offset: 0x00575970
		public static void AddIsNotLoad(FlatBufferBuilder builder, bool isNotLoad)
		{
			builder.AddBool(2, isNotLoad, false);
		}

		// Token: 0x06027BDA RID: 162778 RVA: 0x0057777B File Offset: 0x0057597B
		public static void AddTriggerActions(FlatBufferBuilder builder, Offset<ITriggerActions> triggerActionsOffset)
		{
			builder.AddOffset(3, triggerActionsOffset.Value, 0);
		}

		// Token: 0x06027BDB RID: 162779 RVA: 0x0057778B File Offset: 0x0057598B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06027BDC RID: 162780 RVA: 0x00577796 File Offset: 0x00575996
		public static Offset<ITriggerUe5Component> EndITriggerUe5Component(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerUe5Component>(builder.EndTable());
		}

		// Token: 0x06027BDD RID: 162781 RVA: 0x005777A4 File Offset: 0x005759A4
		public ITriggerUe5ComponentT UnPack()
		{
			ITriggerUe5ComponentT triggerUe5ComponentT = new ITriggerUe5ComponentT();
			this.UnPackTo(triggerUe5ComponentT);
			return triggerUe5ComponentT;
		}

		// Token: 0x06027BDE RID: 162782 RVA: 0x005777C0 File Offset: 0x005759C0
		public void UnPackTo(ITriggerUe5ComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.MaxTriggerTimes = this.MaxTriggerTimes;
			_o.IsNotLoad = this.IsNotLoad;
			_o.TriggerActions = ((this.TriggerActions != null) ? this.TriggerActions.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027BDF RID: 162783 RVA: 0x0057782C File Offset: 0x00575A2C
		public static Offset<ITriggerUe5Component> Pack(FlatBufferBuilder builder, ITriggerUe5ComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerUe5Component>);
			}
			Offset<ITriggerActions> triggerActionsOffset = (_o.TriggerActions == null) ? default(Offset<ITriggerActions>) : ITriggerActions.Pack(builder, _o.TriggerActions);
			return ITriggerUe5Component.CreateITriggerUe5Component(builder, _o.Disabled, _o.MaxTriggerTimes, _o.IsNotLoad, triggerActionsOffset, _o.NullMask);
		}

		// Token: 0x0400F1E7 RID: 61927
		private Table __p;
	}
}
