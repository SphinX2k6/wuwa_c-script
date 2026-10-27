using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200635E RID: 25438
	public struct ICheckFlowLookAtConfig : IFlatbufferObject
	{
		// Token: 0x1700BDCA RID: 48586
		// (get) Token: 0x0602C019 RID: 180249 RVA: 0x0060C0D4 File Offset: 0x0060A2D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C01A RID: 180250 RVA: 0x0060C0E1 File Offset: 0x0060A2E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C01B RID: 180251 RVA: 0x0060C0E8 File Offset: 0x0060A2E8
		public static ICheckFlowLookAtConfig GetRootAsICheckFlowLookAtConfig(ByteBuffer _bb)
		{
			return ICheckFlowLookAtConfig.GetRootAsICheckFlowLookAtConfig(_bb, default(ICheckFlowLookAtConfig));
		}

		// Token: 0x0602C01C RID: 180252 RVA: 0x0060C104 File Offset: 0x0060A304
		public static ICheckFlowLookAtConfig GetRootAsICheckFlowLookAtConfig(ByteBuffer _bb, ICheckFlowLookAtConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C01D RID: 180253 RVA: 0x0060C121 File Offset: 0x0060A321
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C01E RID: 180254 RVA: 0x0060C130 File Offset: 0x0060A330
		public ICheckFlowLookAtConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDCB RID: 48587
		// (get) Token: 0x0602C01F RID: 180255 RVA: 0x0060C140 File Offset: 0x0060A340
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

		// Token: 0x1700BDCC RID: 48588
		// (get) Token: 0x0602C020 RID: 180256 RVA: 0x0060C1A0 File Offset: 0x0060A3A0
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

		// Token: 0x0602C021 RID: 180257 RVA: 0x0060C1DC File Offset: 0x0060A3DC
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C022 RID: 180258 RVA: 0x0060C220 File Offset: 0x0060A420
		public ICheckFlowLookAtEntity TargetAsICheckFlowLookAtEntity()
		{
			return this.Target<ICheckFlowLookAtEntity>().Value;
		}

		// Token: 0x0602C023 RID: 180259 RVA: 0x0060C23C File Offset: 0x0060A43C
		public ICheckFlowLookAtPlayer TargetAsICheckFlowLookAtPlayer()
		{
			return this.Target<ICheckFlowLookAtPlayer>().Value;
		}

		// Token: 0x1700BDCD RID: 48589
		// (get) Token: 0x0602C024 RID: 180260 RVA: 0x0060C258 File Offset: 0x0060A458
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

		// Token: 0x0602C025 RID: 180261 RVA: 0x0060C2B6 File Offset: 0x0060A4B6
		public static Offset<ICheckFlowLookAtConfig> CreateICheckFlowLookAtConfig(FlatBufferBuilder builder, Offset<IPlayFlow> FlowOffset = default(Offset<IPlayFlow>), TCheckFlowLookAtTarget Target_type = TCheckFlowLookAtTarget.NONE, int TargetOffset = 0, Offset<IEntityLookAtPerform> EntityLookAtPerformOffset = default(Offset<IEntityLookAtPerform>))
		{
			builder.StartTable(4);
			ICheckFlowLookAtConfig.AddEntityLookAtPerform(builder, EntityLookAtPerformOffset);
			ICheckFlowLookAtConfig.AddTarget(builder, TargetOffset);
			ICheckFlowLookAtConfig.AddFlow(builder, FlowOffset);
			ICheckFlowLookAtConfig.AddTargetType(builder, Target_type);
			return ICheckFlowLookAtConfig.EndICheckFlowLookAtConfig(builder);
		}

		// Token: 0x0602C026 RID: 180262 RVA: 0x0060C2E2 File Offset: 0x0060A4E2
		public static void StartICheckFlowLookAtConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602C027 RID: 180263 RVA: 0x0060C2EB File Offset: 0x0060A4EB
		public static void AddFlow(FlatBufferBuilder builder, Offset<IPlayFlow> flowOffset)
		{
			builder.AddOffset(0, flowOffset.Value, 0);
		}

		// Token: 0x0602C028 RID: 180264 RVA: 0x0060C2FB File Offset: 0x0060A4FB
		public static void AddTargetType(FlatBufferBuilder builder, TCheckFlowLookAtTarget targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0602C029 RID: 180265 RVA: 0x0060C306 File Offset: 0x0060A506
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0602C02A RID: 180266 RVA: 0x0060C311 File Offset: 0x0060A511
		public static void AddEntityLookAtPerform(FlatBufferBuilder builder, Offset<IEntityLookAtPerform> entityLookAtPerformOffset)
		{
			builder.AddOffset(3, entityLookAtPerformOffset.Value, 0);
		}

		// Token: 0x0602C02B RID: 180267 RVA: 0x0060C321 File Offset: 0x0060A521
		public static Offset<ICheckFlowLookAtConfig> EndICheckFlowLookAtConfig(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFlowLookAtConfig>(builder.EndTable());
		}

		// Token: 0x0602C02C RID: 180268 RVA: 0x0060C330 File Offset: 0x0060A530
		public ICheckFlowLookAtConfigT UnPack()
		{
			ICheckFlowLookAtConfigT checkFlowLookAtConfigT = new ICheckFlowLookAtConfigT();
			this.UnPackTo(checkFlowLookAtConfigT);
			return checkFlowLookAtConfigT;
		}

		// Token: 0x0602C02D RID: 180269 RVA: 0x0060C34C File Offset: 0x0060A54C
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

		// Token: 0x0602C02E RID: 180270 RVA: 0x0060C458 File Offset: 0x0060A658
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

		// Token: 0x0401092B RID: 67883
		private Table __p;
	}
}
