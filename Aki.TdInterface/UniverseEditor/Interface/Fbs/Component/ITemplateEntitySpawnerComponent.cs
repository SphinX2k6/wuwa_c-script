using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200605F RID: 24671
	public struct ITemplateEntitySpawnerComponent : IFlatbufferObject
	{
		// Token: 0x1700B726 RID: 46886
		// (get) Token: 0x06029A98 RID: 170648 RVA: 0x005AFF88 File Offset: 0x005AE188
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029A99 RID: 170649 RVA: 0x005AFF95 File Offset: 0x005AE195
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029A9A RID: 170650 RVA: 0x005AFF9C File Offset: 0x005AE19C
		public static ITemplateEntitySpawnerComponent GetRootAsITemplateEntitySpawnerComponent(ByteBuffer _bb)
		{
			return ITemplateEntitySpawnerComponent.GetRootAsITemplateEntitySpawnerComponent(_bb, default(ITemplateEntitySpawnerComponent));
		}

		// Token: 0x06029A9B RID: 170651 RVA: 0x005AFFB8 File Offset: 0x005AE1B8
		public static ITemplateEntitySpawnerComponent GetRootAsITemplateEntitySpawnerComponent(ByteBuffer _bb, ITemplateEntitySpawnerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029A9C RID: 170652 RVA: 0x005AFFD5 File Offset: 0x005AE1D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029A9D RID: 170653 RVA: 0x005AFFE4 File Offset: 0x005AE1E4
		public ITemplateEntitySpawnerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B727 RID: 46887
		// (get) Token: 0x06029A9E RID: 170654 RVA: 0x005AFFF4 File Offset: 0x005AE1F4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B728 RID: 46888
		// (get) Token: 0x06029A9F RID: 170655 RVA: 0x005B0034 File Offset: 0x005AE234
		public IConditionGroup? SpawnConditions
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

		// Token: 0x1700B729 RID: 46889
		// (get) Token: 0x06029AA0 RID: 170656 RVA: 0x005B0094 File Offset: 0x005AE294
		public IConditionGroup? ClearConditions
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IConditionGroup?(default(IConditionGroup).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B72A RID: 46890
		// (get) Token: 0x06029AA1 RID: 170657 RVA: 0x005B00F4 File Offset: 0x005AE2F4
		public ITemplateMatrix? SpawnConfig
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ITemplateMatrix?(default(ITemplateMatrix).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B72B RID: 46891
		// (get) Token: 0x06029AA2 RID: 170658 RVA: 0x005B0154 File Offset: 0x005AE354
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

		// Token: 0x06029AA3 RID: 170659 RVA: 0x005B0191 File Offset: 0x005AE391
		public static Offset<ITemplateEntitySpawnerComponent> CreateITemplateEntitySpawnerComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IConditionGroup> SpawnConditionsOffset = default(Offset<IConditionGroup>), Offset<IConditionGroup> ClearConditionsOffset = default(Offset<IConditionGroup>), Offset<ITemplateMatrix> SpawnConfigOffset = default(Offset<ITemplateMatrix>), byte NullMask = 0)
		{
			builder.StartTable(5);
			ITemplateEntitySpawnerComponent.AddSpawnConfig(builder, SpawnConfigOffset);
			ITemplateEntitySpawnerComponent.AddClearConditions(builder, ClearConditionsOffset);
			ITemplateEntitySpawnerComponent.AddSpawnConditions(builder, SpawnConditionsOffset);
			ITemplateEntitySpawnerComponent.AddNullMask(builder, NullMask);
			ITemplateEntitySpawnerComponent.AddDisabled(builder, Disabled);
			return ITemplateEntitySpawnerComponent.EndITemplateEntitySpawnerComponent(builder);
		}

		// Token: 0x06029AA4 RID: 170660 RVA: 0x005B01C5 File Offset: 0x005AE3C5
		public static void StartITemplateEntitySpawnerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06029AA5 RID: 170661 RVA: 0x005B01CE File Offset: 0x005AE3CE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06029AA6 RID: 170662 RVA: 0x005B01D9 File Offset: 0x005AE3D9
		public static void AddSpawnConditions(FlatBufferBuilder builder, Offset<IConditionGroup> spawnConditionsOffset)
		{
			builder.AddOffset(1, spawnConditionsOffset.Value, 0);
		}

		// Token: 0x06029AA7 RID: 170663 RVA: 0x005B01E9 File Offset: 0x005AE3E9
		public static void AddClearConditions(FlatBufferBuilder builder, Offset<IConditionGroup> clearConditionsOffset)
		{
			builder.AddOffset(2, clearConditionsOffset.Value, 0);
		}

		// Token: 0x06029AA8 RID: 170664 RVA: 0x005B01F9 File Offset: 0x005AE3F9
		public static void AddSpawnConfig(FlatBufferBuilder builder, Offset<ITemplateMatrix> spawnConfigOffset)
		{
			builder.AddOffset(3, spawnConfigOffset.Value, 0);
		}

		// Token: 0x06029AA9 RID: 170665 RVA: 0x005B0209 File Offset: 0x005AE409
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06029AAA RID: 170666 RVA: 0x005B0214 File Offset: 0x005AE414
		public static Offset<ITemplateEntitySpawnerComponent> EndITemplateEntitySpawnerComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITemplateEntitySpawnerComponent>(builder.EndTable());
		}

		// Token: 0x06029AAB RID: 170667 RVA: 0x005B0224 File Offset: 0x005AE424
		public ITemplateEntitySpawnerComponentT UnPack()
		{
			ITemplateEntitySpawnerComponentT templateEntitySpawnerComponentT = new ITemplateEntitySpawnerComponentT();
			this.UnPackTo(templateEntitySpawnerComponentT);
			return templateEntitySpawnerComponentT;
		}

		// Token: 0x06029AAC RID: 170668 RVA: 0x005B0240 File Offset: 0x005AE440
		public void UnPackTo(ITemplateEntitySpawnerComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.SpawnConditions = ((this.SpawnConditions != null) ? this.SpawnConditions.Value.UnPack() : null);
			_o.ClearConditions = ((this.ClearConditions != null) ? this.ClearConditions.Value.UnPack() : null);
			_o.SpawnConfig = ((this.SpawnConfig != null) ? this.SpawnConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029AAD RID: 170669 RVA: 0x005B02F4 File Offset: 0x005AE4F4
		public static Offset<ITemplateEntitySpawnerComponent> Pack(FlatBufferBuilder builder, ITemplateEntitySpawnerComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITemplateEntitySpawnerComponent>);
			}
			Offset<IConditionGroup> spawnConditionsOffset = (_o.SpawnConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.SpawnConditions);
			Offset<IConditionGroup> clearConditionsOffset = (_o.ClearConditions == null) ? default(Offset<IConditionGroup>) : IConditionGroup.Pack(builder, _o.ClearConditions);
			Offset<ITemplateMatrix> spawnConfigOffset = (_o.SpawnConfig == null) ? default(Offset<ITemplateMatrix>) : ITemplateMatrix.Pack(builder, _o.SpawnConfig);
			return ITemplateEntitySpawnerComponent.CreateITemplateEntitySpawnerComponent(builder, _o.Disabled, spawnConditionsOffset, clearConditionsOffset, spawnConfigOffset, _o.NullMask);
		}

		// Token: 0x0400FDCF RID: 64975
		private Table __p;
	}
}
