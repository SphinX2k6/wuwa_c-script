using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BC2 RID: 19394
	public struct IGlobalFix : IFlatbufferObject
	{
		// Token: 0x17008949 RID: 35145
		// (get) Token: 0x0601D9A4 RID: 121252 RVA: 0x00427DA7 File Offset: 0x00425FA7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D9A5 RID: 121253 RVA: 0x00427DB4 File Offset: 0x00425FB4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D9A6 RID: 121254 RVA: 0x00427DBC File Offset: 0x00425FBC
		public static IGlobalFix GetRootAsIGlobalFix(ByteBuffer _bb)
		{
			return IGlobalFix.GetRootAsIGlobalFix(_bb, default(IGlobalFix));
		}

		// Token: 0x0601D9A7 RID: 121255 RVA: 0x00427DD8 File Offset: 0x00425FD8
		public static IGlobalFix GetRootAsIGlobalFix(ByteBuffer _bb, IGlobalFix obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D9A8 RID: 121256 RVA: 0x00427DF5 File Offset: 0x00425FF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D9A9 RID: 121257 RVA: 0x00427E04 File Offset: 0x00426004
		public IGlobalFix __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700894A RID: 35146
		// (get) Token: 0x0601D9AA RID: 121258 RVA: 0x00427E14 File Offset: 0x00426014
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700894B RID: 35147
		// (get) Token: 0x0601D9AB RID: 121259 RVA: 0x00427E50 File Offset: 0x00426050
		public int DungeonId
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

		// Token: 0x1700894C RID: 35148
		// (get) Token: 0x0601D9AC RID: 121260 RVA: 0x00427E8C File Offset: 0x0042608C
		public int ExecuteCount
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700894D RID: 35149
		// (get) Token: 0x0601D9AD RID: 121261 RVA: 0x00427EC8 File Offset: 0x004260C8
		public int ExecuteCycle
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700894E RID: 35150
		// (get) Token: 0x0601D9AE RID: 121262 RVA: 0x00427F08 File Offset: 0x00426108
		public IConditionGroup? Conditions
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700894F RID: 35151
		// (get) Token: 0x0601D9AF RID: 121263 RVA: 0x00427F68 File Offset: 0x00426168
		public IGlobalFixActions? Actions
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IGlobalFixActions?(default(IGlobalFixActions).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601D9B0 RID: 121264 RVA: 0x00427FC6 File Offset: 0x004261C6
		public static Offset<IGlobalFix> CreateIGlobalFix(FlatBufferBuilder builder, int Id = 0, int DungeonId = 0, int ExecuteCount = 0, int ExecuteCycle = 0, Offset<IConditionGroup> ConditionsOffset = default(Offset<IConditionGroup>), Offset<IGlobalFixActions> ActionsOffset = default(Offset<IGlobalFixActions>))
		{
			builder.StartTable(6);
			IGlobalFix.AddActions(builder, ActionsOffset);
			IGlobalFix.AddConditions(builder, ConditionsOffset);
			IGlobalFix.AddExecuteCycle(builder, ExecuteCycle);
			IGlobalFix.AddExecuteCount(builder, ExecuteCount);
			IGlobalFix.AddDungeonId(builder, DungeonId);
			IGlobalFix.AddId(builder, Id);
			return IGlobalFix.EndIGlobalFix(builder);
		}

		// Token: 0x0601D9B1 RID: 121265 RVA: 0x00428002 File Offset: 0x00426202
		public static void StartIGlobalFix(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601D9B2 RID: 121266 RVA: 0x0042800B File Offset: 0x0042620B
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601D9B3 RID: 121267 RVA: 0x00428016 File Offset: 0x00426216
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(1, dungeonId, 0);
		}

		// Token: 0x0601D9B4 RID: 121268 RVA: 0x00428021 File Offset: 0x00426221
		public static void AddExecuteCount(FlatBufferBuilder builder, int executeCount)
		{
			builder.AddInt(2, executeCount, 0);
		}

		// Token: 0x0601D9B5 RID: 121269 RVA: 0x0042802C File Offset: 0x0042622C
		public static void AddExecuteCycle(FlatBufferBuilder builder, int executeCycle)
		{
			builder.AddInt(3, executeCycle, 0);
		}

		// Token: 0x0601D9B6 RID: 121270 RVA: 0x00428037 File Offset: 0x00426237
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditionGroup> conditionsOffset)
		{
			builder.AddOffset(4, conditionsOffset.Value, 0);
		}

		// Token: 0x0601D9B7 RID: 121271 RVA: 0x00428047 File Offset: 0x00426247
		public static void AddActions(FlatBufferBuilder builder, Offset<IGlobalFixActions> actionsOffset)
		{
			builder.AddOffset(5, actionsOffset.Value, 0);
		}

		// Token: 0x0601D9B8 RID: 121272 RVA: 0x00428057 File Offset: 0x00426257
		public static Offset<IGlobalFix> EndIGlobalFix(FlatBufferBuilder builder)
		{
			return new Offset<IGlobalFix>(builder.EndTable());
		}

		// Token: 0x0601D9B9 RID: 121273 RVA: 0x00428064 File Offset: 0x00426264
		public IGlobalFixT UnPack()
		{
			IGlobalFixT globalFixT = new IGlobalFixT();
			this.UnPackTo(globalFixT);
			return globalFixT;
		}

		// Token: 0x0601D9BA RID: 121274 RVA: 0x00428080 File Offset: 0x00426280
		public void UnPackTo(IGlobalFixT _o)
		{
			_o.Id = this.Id;
			_o.DungeonId = this.DungeonId;
			_o.ExecuteCount = this.ExecuteCount;
			_o.ExecuteCycle = this.ExecuteCycle;
			_o.Conditions = ((this.Conditions != null) ? this.Conditions.Value.UnPack() : null);
			_o.Actions = ((this.Actions != null) ? this.Actions.Value.UnPack() : null);
		}

		// Token: 0x0601D9BB RID: 121275 RVA: 0x0042811C File Offset: 0x0042631C
		public static Offset<IGlobalFix> Pack(FlatBufferBuilder builder, IGlobalFixT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGlobalFix>);
			}
			Offset<IConditionGroup> conditionsOffset = (_o.Conditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.Conditions);
			Offset<IGlobalFixActions> actionsOffset = (_o.Actions == null) ? default(Offset<IGlobalFixActions>) : IGlobalFixActions.Pack(builder, _o.Actions);
			return IGlobalFix.CreateIGlobalFix(builder, _o.Id, _o.DungeonId, _o.ExecuteCount, _o.ExecuteCycle, conditionsOffset, actionsOffset);
		}

		// Token: 0x0400D486 RID: 54406
		private Table __p;
	}
}
