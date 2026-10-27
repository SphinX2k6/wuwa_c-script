using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x0200475A RID: 18266
	public struct IGlobalFix : IFlatbufferObject
	{
		// Token: 0x17008308 RID: 33544
		// (get) Token: 0x0601C1CF RID: 115151 RVA: 0x003FBB0B File Offset: 0x003F9D0B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C1D0 RID: 115152 RVA: 0x003FBB18 File Offset: 0x003F9D18
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C1D1 RID: 115153 RVA: 0x003FBB20 File Offset: 0x003F9D20
		public static IGlobalFix GetRootAsIGlobalFix(ByteBuffer _bb)
		{
			return IGlobalFix.GetRootAsIGlobalFix(_bb, default(IGlobalFix));
		}

		// Token: 0x0601C1D2 RID: 115154 RVA: 0x003FBB3C File Offset: 0x003F9D3C
		public static IGlobalFix GetRootAsIGlobalFix(ByteBuffer _bb, IGlobalFix obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C1D3 RID: 115155 RVA: 0x003FBB59 File Offset: 0x003F9D59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C1D4 RID: 115156 RVA: 0x003FBB68 File Offset: 0x003F9D68
		public IGlobalFix __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008309 RID: 33545
		// (get) Token: 0x0601C1D5 RID: 115157 RVA: 0x003FBB78 File Offset: 0x003F9D78
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

		// Token: 0x1700830A RID: 33546
		// (get) Token: 0x0601C1D6 RID: 115158 RVA: 0x003FBBB4 File Offset: 0x003F9DB4
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

		// Token: 0x1700830B RID: 33547
		// (get) Token: 0x0601C1D7 RID: 115159 RVA: 0x003FBBF0 File Offset: 0x003F9DF0
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

		// Token: 0x1700830C RID: 33548
		// (get) Token: 0x0601C1D8 RID: 115160 RVA: 0x003FBC2C File Offset: 0x003F9E2C
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

		// Token: 0x1700830D RID: 33549
		// (get) Token: 0x0601C1D9 RID: 115161 RVA: 0x003FBC6C File Offset: 0x003F9E6C
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

		// Token: 0x1700830E RID: 33550
		// (get) Token: 0x0601C1DA RID: 115162 RVA: 0x003FBCCC File Offset: 0x003F9ECC
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

		// Token: 0x0601C1DB RID: 115163 RVA: 0x003FBD2A File Offset: 0x003F9F2A
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

		// Token: 0x0601C1DC RID: 115164 RVA: 0x003FBD66 File Offset: 0x003F9F66
		public static void StartIGlobalFix(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0601C1DD RID: 115165 RVA: 0x003FBD6F File Offset: 0x003F9F6F
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601C1DE RID: 115166 RVA: 0x003FBD7A File Offset: 0x003F9F7A
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(1, dungeonId, 0);
		}

		// Token: 0x0601C1DF RID: 115167 RVA: 0x003FBD85 File Offset: 0x003F9F85
		public static void AddExecuteCount(FlatBufferBuilder builder, int executeCount)
		{
			builder.AddInt(2, executeCount, 0);
		}

		// Token: 0x0601C1E0 RID: 115168 RVA: 0x003FBD90 File Offset: 0x003F9F90
		public static void AddExecuteCycle(FlatBufferBuilder builder, int executeCycle)
		{
			builder.AddInt(3, executeCycle, 0);
		}

		// Token: 0x0601C1E1 RID: 115169 RVA: 0x003FBD9B File Offset: 0x003F9F9B
		public static void AddConditions(FlatBufferBuilder builder, Offset<IConditionGroup> conditionsOffset)
		{
			builder.AddOffset(4, conditionsOffset.Value, 0);
		}

		// Token: 0x0601C1E2 RID: 115170 RVA: 0x003FBDAB File Offset: 0x003F9FAB
		public static void AddActions(FlatBufferBuilder builder, Offset<IGlobalFixActions> actionsOffset)
		{
			builder.AddOffset(5, actionsOffset.Value, 0);
		}

		// Token: 0x0601C1E3 RID: 115171 RVA: 0x003FBDBB File Offset: 0x003F9FBB
		public static Offset<IGlobalFix> EndIGlobalFix(FlatBufferBuilder builder)
		{
			return new Offset<IGlobalFix>(builder.EndTable());
		}

		// Token: 0x0601C1E4 RID: 115172 RVA: 0x003FBDC8 File Offset: 0x003F9FC8
		public IGlobalFixT UnPack()
		{
			IGlobalFixT globalFixT = new IGlobalFixT();
			this.UnPackTo(globalFixT);
			return globalFixT;
		}

		// Token: 0x0601C1E5 RID: 115173 RVA: 0x003FBDE4 File Offset: 0x003F9FE4
		public void UnPackTo(IGlobalFixT _o)
		{
			_o.Id = this.Id;
			_o.DungeonId = this.DungeonId;
			_o.ExecuteCount = this.ExecuteCount;
			_o.ExecuteCycle = this.ExecuteCycle;
			_o.Conditions = ((this.Conditions != null) ? this.Conditions.Value.UnPack() : null);
			_o.Actions = ((this.Actions != null) ? this.Actions.Value.UnPack() : null);
		}

		// Token: 0x0601C1E6 RID: 115174 RVA: 0x003FBE80 File Offset: 0x003FA080
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

		// Token: 0x0400CA57 RID: 51799
		private Table __p;
	}
}
