using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005CEA RID: 23786
	public struct IPathDrivenActorSpawnerComponent : IFlatbufferObject
	{
		// Token: 0x1700AEBA RID: 44730
		// (get) Token: 0x060277BB RID: 161723 RVA: 0x00567146 File Offset: 0x00565346
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060277BC RID: 161724 RVA: 0x00567153 File Offset: 0x00565353
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060277BD RID: 161725 RVA: 0x0056715C File Offset: 0x0056535C
		public static IPathDrivenActorSpawnerComponent GetRootAsIPathDrivenActorSpawnerComponent(ByteBuffer _bb)
		{
			return IPathDrivenActorSpawnerComponent.GetRootAsIPathDrivenActorSpawnerComponent(_bb, default(IPathDrivenActorSpawnerComponent));
		}

		// Token: 0x060277BE RID: 161726 RVA: 0x00567178 File Offset: 0x00565378
		public static IPathDrivenActorSpawnerComponent GetRootAsIPathDrivenActorSpawnerComponent(ByteBuffer _bb, IPathDrivenActorSpawnerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060277BF RID: 161727 RVA: 0x00567195 File Offset: 0x00565395
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060277C0 RID: 161728 RVA: 0x005671A4 File Offset: 0x005653A4
		public IPathDrivenActorSpawnerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEBB RID: 44731
		// (get) Token: 0x060277C1 RID: 161729 RVA: 0x005671B4 File Offset: 0x005653B4
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AEBC RID: 44732
		// (get) Token: 0x060277C2 RID: 161730 RVA: 0x005671F4 File Offset: 0x005653F4
		public IIntervalSplineSpawn? SpawnRule
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IIntervalSplineSpawn?(default(IIntervalSplineSpawn).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AEBD RID: 44733
		// (get) Token: 0x060277C3 RID: 161731 RVA: 0x00567254 File Offset: 0x00565454
		public TTargetEntity TargetType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060277C4 RID: 161732 RVA: 0x00567290 File Offset: 0x00565490
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060277C5 RID: 161733 RVA: 0x005672D8 File Offset: 0x005654D8
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x060277C6 RID: 161734 RVA: 0x005672F4 File Offset: 0x005654F4
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x060277C7 RID: 161735 RVA: 0x00567310 File Offset: 0x00565510
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x060277C8 RID: 161736 RVA: 0x0056732C File Offset: 0x0056552C
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x060277C9 RID: 161737 RVA: 0x00567348 File Offset: 0x00565548
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x1700AEBE RID: 44734
		// (get) Token: 0x060277CA RID: 161738 RVA: 0x00567364 File Offset: 0x00565564
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

		// Token: 0x060277CB RID: 161739 RVA: 0x005673A1 File Offset: 0x005655A1
		public static Offset<IPathDrivenActorSpawnerComponent> CreateIPathDrivenActorSpawnerComponent(FlatBufferBuilder builder, bool Disabled = false, Offset<IIntervalSplineSpawn> SpawnRuleOffset = default(Offset<IIntervalSplineSpawn>), TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IPathDrivenActorSpawnerComponent.AddTarget(builder, TargetOffset);
			IPathDrivenActorSpawnerComponent.AddSpawnRule(builder, SpawnRuleOffset);
			IPathDrivenActorSpawnerComponent.AddNullMask(builder, NullMask);
			IPathDrivenActorSpawnerComponent.AddTargetType(builder, Target_type);
			IPathDrivenActorSpawnerComponent.AddDisabled(builder, Disabled);
			return IPathDrivenActorSpawnerComponent.EndIPathDrivenActorSpawnerComponent(builder);
		}

		// Token: 0x060277CC RID: 161740 RVA: 0x005673D5 File Offset: 0x005655D5
		public static void StartIPathDrivenActorSpawnerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060277CD RID: 161741 RVA: 0x005673DE File Offset: 0x005655DE
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060277CE RID: 161742 RVA: 0x005673E9 File Offset: 0x005655E9
		public static void AddSpawnRule(FlatBufferBuilder builder, Offset<IIntervalSplineSpawn> spawnRuleOffset)
		{
			builder.AddOffset(1, spawnRuleOffset.Value, 0);
		}

		// Token: 0x060277CF RID: 161743 RVA: 0x005673F9 File Offset: 0x005655F9
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(2, (byte)targetType, 0);
		}

		// Token: 0x060277D0 RID: 161744 RVA: 0x00567404 File Offset: 0x00565604
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(3, targetOffset, 0);
		}

		// Token: 0x060277D1 RID: 161745 RVA: 0x0056740F File Offset: 0x0056560F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060277D2 RID: 161746 RVA: 0x0056741A File Offset: 0x0056561A
		public static Offset<IPathDrivenActorSpawnerComponent> EndIPathDrivenActorSpawnerComponent(FlatBufferBuilder builder)
		{
			return new Offset<IPathDrivenActorSpawnerComponent>(builder.EndTable());
		}

		// Token: 0x060277D3 RID: 161747 RVA: 0x00567428 File Offset: 0x00565628
		public IPathDrivenActorSpawnerComponentT UnPack()
		{
			IPathDrivenActorSpawnerComponentT pathDrivenActorSpawnerComponentT = new IPathDrivenActorSpawnerComponentT();
			this.UnPackTo(pathDrivenActorSpawnerComponentT);
			return pathDrivenActorSpawnerComponentT;
		}

		// Token: 0x060277D4 RID: 161748 RVA: 0x00567444 File Offset: 0x00565644
		public void UnPackTo(IPathDrivenActorSpawnerComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.SpawnRule = ((this.SpawnRule != null) ? this.SpawnRule.Value.UnPack() : null);
			_o.Target = new TTargetEntityUnion();
			_o.Target.Type = this.TargetType;
			switch (this.TargetType)
			{
			case TTargetEntity.IPlayerEntity:
				_o.Target.Value = ((this.Target<IPlayerEntity>() != null) ? this.Target<IPlayerEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ISelfEntity:
				_o.Target.Value = ((this.Target<ISelfEntity>() != null) ? this.Target<ISelfEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITargetEntity:
				_o.Target.Value = ((this.Target<ITargetEntity>() != null) ? this.Target<ITargetEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.ITriggeredEntity:
				_o.Target.Value = ((this.Target<ITriggeredEntity>() != null) ? this.Target<ITriggeredEntity>().Value.UnPack() : null);
				break;
			case TTargetEntity.IVehicleEntity:
				_o.Target.Value = ((this.Target<IVehicleEntity>() != null) ? this.Target<IVehicleEntity>().Value.UnPack() : null);
				break;
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060277D5 RID: 161749 RVA: 0x005675FC File Offset: 0x005657FC
		public static Offset<IPathDrivenActorSpawnerComponent> Pack(FlatBufferBuilder builder, IPathDrivenActorSpawnerComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPathDrivenActorSpawnerComponent>);
			}
			Offset<IIntervalSplineSpawn> spawnRuleOffset = (_o.SpawnRule == null) ? default(Offset<IIntervalSplineSpawn>) : IIntervalSplineSpawn.Pack(builder, _o.SpawnRule);
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			return IPathDrivenActorSpawnerComponent.CreateIPathDrivenActorSpawnerComponent(builder, _o.Disabled, spawnRuleOffset, target_type, targetOffset, _o.NullMask);
		}

		// Token: 0x0400F81D RID: 63517
		private Table __p;
	}
}
