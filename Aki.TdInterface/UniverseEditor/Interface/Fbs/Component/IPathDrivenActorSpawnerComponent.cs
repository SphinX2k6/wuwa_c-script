using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056FB RID: 22267
	public struct IPathDrivenActorSpawnerComponent : IFlatbufferObject
	{
		// Token: 0x1700A5B7 RID: 42423
		// (get) Token: 0x06025354 RID: 152404 RVA: 0x005226FA File Offset: 0x005208FA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06025355 RID: 152405 RVA: 0x00522707 File Offset: 0x00520907
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025356 RID: 152406 RVA: 0x00522710 File Offset: 0x00520910
		public static IPathDrivenActorSpawnerComponent GetRootAsIPathDrivenActorSpawnerComponent(ByteBuffer _bb)
		{
			return IPathDrivenActorSpawnerComponent.GetRootAsIPathDrivenActorSpawnerComponent(_bb, default(IPathDrivenActorSpawnerComponent));
		}

		// Token: 0x06025357 RID: 152407 RVA: 0x0052272C File Offset: 0x0052092C
		public static IPathDrivenActorSpawnerComponent GetRootAsIPathDrivenActorSpawnerComponent(ByteBuffer _bb, IPathDrivenActorSpawnerComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025358 RID: 152408 RVA: 0x00522749 File Offset: 0x00520949
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025359 RID: 152409 RVA: 0x00522758 File Offset: 0x00520958
		public IPathDrivenActorSpawnerComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A5B8 RID: 42424
		// (get) Token: 0x0602535A RID: 152410 RVA: 0x00522768 File Offset: 0x00520968
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A5B9 RID: 42425
		// (get) Token: 0x0602535B RID: 152411 RVA: 0x005227A8 File Offset: 0x005209A8
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

		// Token: 0x1700A5BA RID: 42426
		// (get) Token: 0x0602535C RID: 152412 RVA: 0x00522808 File Offset: 0x00520A08
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

		// Token: 0x0602535D RID: 152413 RVA: 0x00522844 File Offset: 0x00520A44
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602535E RID: 152414 RVA: 0x0052288C File Offset: 0x00520A8C
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0602535F RID: 152415 RVA: 0x005228A8 File Offset: 0x00520AA8
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x06025360 RID: 152416 RVA: 0x005228C4 File Offset: 0x00520AC4
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x06025361 RID: 152417 RVA: 0x005228E0 File Offset: 0x00520AE0
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x06025362 RID: 152418 RVA: 0x005228FC File Offset: 0x00520AFC
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x1700A5BB RID: 42427
		// (get) Token: 0x06025363 RID: 152419 RVA: 0x00522918 File Offset: 0x00520B18
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

		// Token: 0x06025364 RID: 152420 RVA: 0x00522955 File Offset: 0x00520B55
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

		// Token: 0x06025365 RID: 152421 RVA: 0x00522989 File Offset: 0x00520B89
		public static void StartIPathDrivenActorSpawnerComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06025366 RID: 152422 RVA: 0x00522992 File Offset: 0x00520B92
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06025367 RID: 152423 RVA: 0x0052299D File Offset: 0x00520B9D
		public static void AddSpawnRule(FlatBufferBuilder builder, Offset<IIntervalSplineSpawn> spawnRuleOffset)
		{
			builder.AddOffset(1, spawnRuleOffset.Value, 0);
		}

		// Token: 0x06025368 RID: 152424 RVA: 0x005229AD File Offset: 0x00520BAD
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(2, (byte)targetType, 0);
		}

		// Token: 0x06025369 RID: 152425 RVA: 0x005229B8 File Offset: 0x00520BB8
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(3, targetOffset, 0);
		}

		// Token: 0x0602536A RID: 152426 RVA: 0x005229C3 File Offset: 0x00520BC3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602536B RID: 152427 RVA: 0x005229CE File Offset: 0x00520BCE
		public static Offset<IPathDrivenActorSpawnerComponent> EndIPathDrivenActorSpawnerComponent(FlatBufferBuilder builder)
		{
			return new Offset<IPathDrivenActorSpawnerComponent>(builder.EndTable());
		}

		// Token: 0x0602536C RID: 152428 RVA: 0x005229DC File Offset: 0x00520BDC
		public IPathDrivenActorSpawnerComponentT UnPack()
		{
			IPathDrivenActorSpawnerComponentT pathDrivenActorSpawnerComponentT = new IPathDrivenActorSpawnerComponentT();
			this.UnPackTo(pathDrivenActorSpawnerComponentT);
			return pathDrivenActorSpawnerComponentT;
		}

		// Token: 0x0602536D RID: 152429 RVA: 0x005229F8 File Offset: 0x00520BF8
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

		// Token: 0x0602536E RID: 152430 RVA: 0x00522BB0 File Offset: 0x00520DB0
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

		// Token: 0x0400EB50 RID: 60240
		private Table __p;
	}
}
