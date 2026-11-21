using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069CF RID: 27087
	public struct ICheckFlowLookAtConfig : IFlatbufferObject
	{
		// Token: 0x1700C752 RID: 51026
		// (get) Token: 0x0602E783 RID: 190339 RVA: 0x00657228 File Offset: 0x00655428
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602E784 RID: 190340 RVA: 0x00657235 File Offset: 0x00655435
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602E785 RID: 190341 RVA: 0x0065723C File Offset: 0x0065543C
		public static ICheckFlowLookAtConfig GetRootAsICheckFlowLookAtConfig(ByteBuffer _bb)
		{
			return ICheckFlowLookAtConfig.GetRootAsICheckFlowLookAtConfig(_bb, default(ICheckFlowLookAtConfig));
		}

		// Token: 0x0602E786 RID: 190342 RVA: 0x00657258 File Offset: 0x00655458
		public static ICheckFlowLookAtConfig GetRootAsICheckFlowLookAtConfig(ByteBuffer _bb, ICheckFlowLookAtConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602E787 RID: 190343 RVA: 0x00657275 File Offset: 0x00655475
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602E788 RID: 190344 RVA: 0x00657284 File Offset: 0x00655484
		public ICheckFlowLookAtConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C753 RID: 51027
		// (get) Token: 0x0602E789 RID: 190345 RVA: 0x00657294 File Offset: 0x00655494
		public IPlayFlow? Flow
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IPlayFlow?(default(IPlayFlow).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C754 RID: 51028
		// (get) Token: 0x0602E78A RID: 190346 RVA: 0x006572F4 File Offset: 0x006554F4
		public TCheckFlowLookAtTarget TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TCheckFlowLookAtTarget.NONE;
				}
				return (TCheckFlowLookAtTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602E78B RID: 190347 RVA: 0x00657330 File Offset: 0x00655530
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602E78C RID: 190348 RVA: 0x00657374 File Offset: 0x00655574
		public ICheckFlowLookAtEntity TargetAsICheckFlowLookAtEntity()
		{
			return this.Target<ICheckFlowLookAtEntity>().Value;
		}

		// Token: 0x0602E78D RID: 190349 RVA: 0x00657390 File Offset: 0x00655590
		public ICheckFlowLookAtPlayer TargetAsICheckFlowLookAtPlayer()
		{
			return this.Target<ICheckFlowLookAtPlayer>().Value;
		}

		// Token: 0x1700C755 RID: 51029
		// (get) Token: 0x0602E78E RID: 190350 RVA: 0x006573AC File Offset: 0x006555AC
		public IEntityLookAtPerform? EntityLookAtPerform
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IEntityLookAtPerform?(default(IEntityLookAtPerform).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602E78F RID: 190351 RVA: 0x0065740A File Offset: 0x0065560A
		public static Offset<ICheckFlowLookAtConfig> CreateICheckFlowLookAtConfig(FlatBufferBuilder builder, Offset<IPlayFlow> FlowOffset = default(Offset<IPlayFlow>), TCheckFlowLookAtTarget Target_type = TCheckFlowLookAtTarget.NONE, int TargetOffset = 0, Offset<IEntityLookAtPerform> EntityLookAtPerformOffset = default(Offset<IEntityLookAtPerform>))
		{
			builder.StartTable(4);
			ICheckFlowLookAtConfig.AddEntityLookAtPerform(builder, EntityLookAtPerformOffset);
			ICheckFlowLookAtConfig.AddTarget(builder, TargetOffset);
			ICheckFlowLookAtConfig.AddFlow(builder, FlowOffset);
			ICheckFlowLookAtConfig.AddTargetType(builder, Target_type);
			return ICheckFlowLookAtConfig.EndICheckFlowLookAtConfig(builder);
		}

		// Token: 0x0602E790 RID: 190352 RVA: 0x00657436 File Offset: 0x00655636
		public static void StartICheckFlowLookAtConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602E791 RID: 190353 RVA: 0x0065743F File Offset: 0x0065563F
		public static void AddFlow(FlatBufferBuilder builder, Offset<IPlayFlow> flowOffset)
		{
			builder.AddOffset(0, flowOffset.Value, 0);
		}

		// Token: 0x0602E792 RID: 190354 RVA: 0x0065744F File Offset: 0x0065564F
		public static void AddTargetType(FlatBufferBuilder builder, TCheckFlowLookAtTarget targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0602E793 RID: 190355 RVA: 0x0065745A File Offset: 0x0065565A
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0602E794 RID: 190356 RVA: 0x00657465 File Offset: 0x00655665
		public static void AddEntityLookAtPerform(FlatBufferBuilder builder, Offset<IEntityLookAtPerform> entityLookAtPerformOffset)
		{
			builder.AddOffset(3, entityLookAtPerformOffset.Value, 0);
		}

		// Token: 0x0602E795 RID: 190357 RVA: 0x00657475 File Offset: 0x00655675
		public static Offset<ICheckFlowLookAtConfig> EndICheckFlowLookAtConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFlowLookAtConfig>(builder.EndTable());
		}

		// Token: 0x0602E796 RID: 190358 RVA: 0x00657484 File Offset: 0x00655684
		public ICheckFlowLookAtConfigT UnPack()
		{
			ICheckFlowLookAtConfigT checkFlowLookAtConfigT = new ICheckFlowLookAtConfigT();
			this.UnPackTo(checkFlowLookAtConfigT);
			return checkFlowLookAtConfigT;
		}

		// Token: 0x0602E797 RID: 190359 RVA: 0x006574A0 File Offset: 0x006556A0
		public void UnPackTo(ICheckFlowLookAtConfigT _o)
		{
			_o.Flow = ((this.Flow != null) ? this.Flow.Value.UnPack() : null);
			_o.Target = new TCheckFlowLookAtTargetUnion();
			_o.Target.Type = this.TargetType;
			TCheckFlowLookAtTarget targetType = this.TargetType;
			if (targetType != TCheckFlowLookAtTarget.ICheckFlowLookAtEntity)
			{
				if (targetType == TCheckFlowLookAtTarget.ICheckFlowLookAtPlayer)
				{
					_o.Target.Value = ((this.Target<ICheckFlowLookAtPlayer>() != null) ? this.Target<ICheckFlowLookAtPlayer>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Target.Value = ((this.Target<ICheckFlowLookAtEntity>() != null) ? this.Target<ICheckFlowLookAtEntity>().Value.UnPack() : null);
			}
			_o.EntityLookAtPerform = ((this.EntityLookAtPerform != null) ? this.EntityLookAtPerform.Value.UnPack() : null);
		}

		// Token: 0x0602E798 RID: 190360 RVA: 0x006575AC File Offset: 0x006557AC
		public static Offset<ICheckFlowLookAtConfig> Pack(FlatBufferBuilder builder, ICheckFlowLookAtConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckFlowLookAtConfig>);
			}
			Offset<IPlayFlow> flowOffset = (_o.Flow == null) ? default(Offset<IPlayFlow>) : IPlayFlow.Pack(builder, _o.Flow);
			TCheckFlowLookAtTarget target_type = (_o.Target == null) ? TCheckFlowLookAtTarget.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TCheckFlowLookAtTargetUnion.Pack(builder, _o.Target);
			Offset<IEntityLookAtPerform> entityLookAtPerformOffset = (_o.EntityLookAtPerform == null) ? default(Offset<IEntityLookAtPerform>) : IEntityLookAtPerform.Pack(builder, _o.EntityLookAtPerform);
			return ICheckFlowLookAtConfig.CreateICheckFlowLookAtConfig(builder, flowOffset, target_type, targetOffset, entityLookAtPerformOffset);
		}

		// Token: 0x04011740 RID: 71488
		private Table __p;
	}
}
