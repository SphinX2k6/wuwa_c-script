using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060FD RID: 24829
	public struct ITriggerUe5Component : IFlatbufferObject
	{
		// Token: 0x1700B8D6 RID: 47318
		// (get) Token: 0x0602A156 RID: 172374 RVA: 0x005BEA1A File Offset: 0x005BCC1A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602A157 RID: 172375 RVA: 0x005BEA27 File Offset: 0x005BCC27
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602A158 RID: 172376 RVA: 0x005BEA30 File Offset: 0x005BCC30
		public static ITriggerUe5Component GetRootAsITriggerUe5Component(ByteBuffer _bb)
		{
			return ITriggerUe5Component.GetRootAsITriggerUe5Component(_bb, default(ITriggerUe5Component));
		}

		// Token: 0x0602A159 RID: 172377 RVA: 0x005BEA4C File Offset: 0x005BCC4C
		public static ITriggerUe5Component GetRootAsITriggerUe5Component(ByteBuffer _bb, ITriggerUe5Component obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602A15A RID: 172378 RVA: 0x005BEA69 File Offset: 0x005BCC69
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602A15B RID: 172379 RVA: 0x005BEA78 File Offset: 0x005BCC78
		public ITriggerUe5Component __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B8D7 RID: 47319
		// (get) Token: 0x0602A15C RID: 172380 RVA: 0x005BEA88 File Offset: 0x005BCC88
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B8D8 RID: 47320
		// (get) Token: 0x0602A15D RID: 172381 RVA: 0x005BEAC8 File Offset: 0x005BCCC8
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

		// Token: 0x1700B8D9 RID: 47321
		// (get) Token: 0x0602A15E RID: 172382 RVA: 0x005BEB04 File Offset: 0x005BCD04
		public bool IsNotLoad
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B8DA RID: 47322
		// (get) Token: 0x0602A15F RID: 172383 RVA: 0x005BEB44 File Offset: 0x005BCD44
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

		// Token: 0x1700B8DB RID: 47323
		// (get) Token: 0x0602A160 RID: 172384 RVA: 0x005BEBA4 File Offset: 0x005BCDA4
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

		// Token: 0x0602A161 RID: 172385 RVA: 0x005BEBE1 File Offset: 0x005BCDE1
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

		// Token: 0x0602A162 RID: 172386 RVA: 0x005BEC15 File Offset: 0x005BCE15
		public static void StartITriggerUe5Component(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602A163 RID: 172387 RVA: 0x005BEC1E File Offset: 0x005BCE1E
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602A164 RID: 172388 RVA: 0x005BEC29 File Offset: 0x005BCE29
		public static void AddMaxTriggerTimes(FlatBufferBuilder builder, int maxTriggerTimes)
		{
			builder.AddInt(1, maxTriggerTimes, 0);
		}

		// Token: 0x0602A165 RID: 172389 RVA: 0x005BEC34 File Offset: 0x005BCE34
		public static void AddIsNotLoad(FlatBufferBuilder builder, bool isNotLoad)
		{
			builder.AddBool(2, isNotLoad, false);
		}

		// Token: 0x0602A166 RID: 172390 RVA: 0x005BEC3F File Offset: 0x005BCE3F
		public static void AddTriggerActions(FlatBufferBuilder builder, Offset<ITriggerActions> triggerActionsOffset)
		{
			builder.AddOffset(3, triggerActionsOffset.Value, 0);
		}

		// Token: 0x0602A167 RID: 172391 RVA: 0x005BEC4F File Offset: 0x005BCE4F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602A168 RID: 172392 RVA: 0x005BEC5A File Offset: 0x005BCE5A
		public static Offset<ITriggerUe5Component> EndITriggerUe5Component(FlatBufferBuilder builder)
		{
			return new Offset<ITriggerUe5Component>(builder.EndTable());
		}

		// Token: 0x0602A169 RID: 172393 RVA: 0x005BEC68 File Offset: 0x005BCE68
		public ITriggerUe5ComponentT UnPack()
		{
			ITriggerUe5ComponentT triggerUe5ComponentT = new ITriggerUe5ComponentT();
			this.UnPackTo(triggerUe5ComponentT);
			return triggerUe5ComponentT;
		}

		// Token: 0x0602A16A RID: 172394 RVA: 0x005BEC84 File Offset: 0x005BCE84
		public void UnPackTo(ITriggerUe5ComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.MaxTriggerTimes = this.MaxTriggerTimes;
			_o.IsNotLoad = this.IsNotLoad;
			_o.TriggerActions = ((this.TriggerActions != null) ? this.TriggerActions.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602A16B RID: 172395 RVA: 0x005BECF0 File Offset: 0x005BCEF0
		public static Offset<ITriggerUe5Component> Pack(FlatBufferBuilder builder, ITriggerUe5ComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITriggerUe5Component>);
			}
			Offset<ITriggerActions> triggerActionsOffset = (_o.TriggerActions == null) ? default(Offset<ITriggerActions>) : ITriggerActions.Pack(builder, _o.TriggerActions);
			return ITriggerUe5Component.CreateITriggerUe5Component(builder, _o.Disabled, _o.MaxTriggerTimes, _o.IsNotLoad, triggerActionsOffset, _o.NullMask);
		}

		// Token: 0x0400FEE1 RID: 65249
		private Table __p;
	}
}
