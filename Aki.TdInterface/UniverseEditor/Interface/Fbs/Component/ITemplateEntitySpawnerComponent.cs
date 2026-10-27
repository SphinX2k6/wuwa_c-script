using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A52 RID: 23122
	public struct ITemplateEntitySpawnerComponent : IFlatbufferObject
	{
		// Token: 0x1700ADEE RID: 44526
		// (get) Token: 0x06027520 RID: 161056 RVA: 0x00568F7C File Offset: 0x0056717C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027521 RID: 161057 RVA: 0x00568F89 File Offset: 0x00567189
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027522 RID: 161058 RVA: 0x00568F90 File Offset: 0x00567190
		public static ITemplateEntitySpawnerComponent GetRootAsITemplateEntitySpawnerComponent(ByteBuffer _bb)
		{
			return ITemplateEntitySpawnerComponent.GetRootAsITemplateEntitySpawnerComponent(_bb, default(ITemplateEntitySpawnerComponent));
		}

		// Token: 0x06027523 RID: 161059 RVA: 0x00568FAC File Offset: 0x005671AC
		public static ITemplateEntitySpawnerComponent GetRootAsITemplateEntitySpawnerComponent(ByteBuffer _bb, ITemplateEntitySpawnerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027524 RID: 161060 RVA: 0x00568FC9 File Offset: 0x005671C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027525 RID: 161061 RVA: 0x00568FD8 File Offset: 0x005671D8
		public ITemplateEntitySpawnerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADEF RID: 44527
		// (get) Token: 0x06027526 RID: 161062 RVA: 0x00568FE8 File Offset: 0x005671E8
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ADF0 RID: 44528
		// (get) Token: 0x06027527 RID: 161063 RVA: 0x00569028 File Offset: 0x00567228
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

		// Token: 0x1700ADF1 RID: 44529
		// (get) Token: 0x06027528 RID: 161064 RVA: 0x00569088 File Offset: 0x00567288
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

		// Token: 0x1700ADF2 RID: 44530
		// (get) Token: 0x06027529 RID: 161065 RVA: 0x005690E8 File Offset: 0x005672E8
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

		// Token: 0x1700ADF3 RID: 44531
		// (get) Token: 0x0602752A RID: 161066 RVA: 0x00569148 File Offset: 0x00567348
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

		// Token: 0x0602752B RID: 161067 RVA: 0x00569185 File Offset: 0x00567385
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

		// Token: 0x0602752C RID: 161068 RVA: 0x005691B9 File Offset: 0x005673B9
		public static void StartITemplateEntitySpawnerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602752D RID: 161069 RVA: 0x005691C2 File Offset: 0x005673C2
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x0602752E RID: 161070 RVA: 0x005691CD File Offset: 0x005673CD
		public static void AddSpawnConditions(FlatBufferBuilder builder, Offset<IConditionGroup> spawnConditionsOffset)
		{
			builder.AddOffset(1, spawnConditionsOffset.Value, 0);
		}

		// Token: 0x0602752F RID: 161071 RVA: 0x005691DD File Offset: 0x005673DD
		public static void AddClearConditions(FlatBufferBuilder builder, Offset<IConditionGroup> clearConditionsOffset)
		{
			builder.AddOffset(2, clearConditionsOffset.Value, 0);
		}

		// Token: 0x06027530 RID: 161072 RVA: 0x005691ED File Offset: 0x005673ED
		public static void AddSpawnConfig(FlatBufferBuilder builder, Offset<ITemplateMatrix> spawnConfigOffset)
		{
			builder.AddOffset(3, spawnConfigOffset.Value, 0);
		}

		// Token: 0x06027531 RID: 161073 RVA: 0x005691FD File Offset: 0x005673FD
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06027532 RID: 161074 RVA: 0x00569208 File Offset: 0x00567408
		public static Offset<ITemplateEntitySpawnerComponent> EndITemplateEntitySpawnerComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITemplateEntitySpawnerComponent>(builder.EndTable());
		}

		// Token: 0x06027533 RID: 161075 RVA: 0x00569218 File Offset: 0x00567418
		public ITemplateEntitySpawnerComponentT UnPack()
		{
			ITemplateEntitySpawnerComponentT templateEntitySpawnerComponentT = new ITemplateEntitySpawnerComponentT();
			this.UnPackTo(templateEntitySpawnerComponentT);
			return templateEntitySpawnerComponentT;
		}

		// Token: 0x06027534 RID: 161076 RVA: 0x00569234 File Offset: 0x00567434
		public void UnPackTo(ITemplateEntitySpawnerComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.SpawnConditions = ((this.SpawnConditions != null) ? this.SpawnConditions.Value.UnPack() : null);
			_o.ClearConditions = ((this.ClearConditions != null) ? this.ClearConditions.Value.UnPack() : null);
			_o.SpawnConfig = ((this.SpawnConfig != null) ? this.SpawnConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027535 RID: 161077 RVA: 0x005692E8 File Offset: 0x005674E8
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

		// Token: 0x0400F0D8 RID: 61656
		private Table __p;
	}
}
