using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006068 RID: 24680
	public struct IAccelerateSkiConfig : IFlatbufferObject
	{
		// Token: 0x1700B5D7 RID: 46551
		// (get) Token: 0x06029C8E RID: 171150 RVA: 0x005BBBD0 File Offset: 0x005B9DD0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029C8F RID: 171151 RVA: 0x005BBBDD File Offset: 0x005B9DDD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029C90 RID: 171152 RVA: 0x005BBBE4 File Offset: 0x005B9DE4
		public static IAccelerateSkiConfig GetRootAsIAccelerateSkiConfig(ByteBuffer _bb)
		{
			return IAccelerateSkiConfig.GetRootAsIAccelerateSkiConfig(_bb, default(IAccelerateSkiConfig));
		}

		// Token: 0x06029C91 RID: 171153 RVA: 0x005BBC00 File Offset: 0x005B9E00
		public static IAccelerateSkiConfig GetRootAsIAccelerateSkiConfig(ByteBuffer _bb, IAccelerateSkiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029C92 RID: 171154 RVA: 0x005BBC1D File Offset: 0x005B9E1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029C93 RID: 171155 RVA: 0x005BBC2C File Offset: 0x005B9E2C
		public IAccelerateSkiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B5D8 RID: 46552
		// (get) Token: 0x06029C94 RID: 171156 RVA: 0x005BBC3C File Offset: 0x005B9E3C
		public ESkiConfig Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESkiConfig.Open;
				}
				return (ESkiConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B5D9 RID: 46553
		// (get) Token: 0x06029C95 RID: 171157 RVA: 0x005BBC78 File Offset: 0x005B9E78
		public TTargetEntity TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetEntity.NONE;
				}
				return (TTargetEntity)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029C96 RID: 171158 RVA: 0x005BBCB4 File Offset: 0x005B9EB4
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06029C97 RID: 171159 RVA: 0x005BBCF8 File Offset: 0x005B9EF8
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x06029C98 RID: 171160 RVA: 0x005BBD14 File Offset: 0x005B9F14
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x06029C99 RID: 171161 RVA: 0x005BBD30 File Offset: 0x005B9F30
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x06029C9A RID: 171162 RVA: 0x005BBD4C File Offset: 0x005B9F4C
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x06029C9B RID: 171163 RVA: 0x005BBD68 File Offset: 0x005B9F68
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x1700B5DA RID: 46554
		// (get) Token: 0x06029C9C RID: 171164 RVA: 0x005BBD84 File Offset: 0x005B9F84
		public int Duration
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

		// Token: 0x1700B5DB RID: 46555
		// (get) Token: 0x06029C9D RID: 171165 RVA: 0x005BBDC4 File Offset: 0x005B9FC4
		public int LimitSpeed
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B5DC RID: 46556
		// (get) Token: 0x06029C9E RID: 171166 RVA: 0x005BBE04 File Offset: 0x005BA004
		public int Acceleration
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B5DD RID: 46557
		// (get) Token: 0x06029C9F RID: 171167 RVA: 0x005BBE44 File Offset: 0x005BA044
		public int InstantSpeed
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B5DE RID: 46558
		// (get) Token: 0x06029CA0 RID: 171168 RVA: 0x005BBE84 File Offset: 0x005BA084
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029CA1 RID: 171169 RVA: 0x005BBEC4 File Offset: 0x005BA0C4
		public static Offset<IAccelerateSkiConfig> CreateIAccelerateSkiConfig(FlatBufferBuilder builder, ESkiConfig Type = ESkiConfig.Open, TTargetEntity Target_type = TTargetEntity.NONE, int TargetOffset = 0, int Duration = 0, int LimitSpeed = 0, int Acceleration = 0, int InstantSpeed = 0, byte NullMask = 0)
		{
			builder.StartTable(8);
			IAccelerateSkiConfig.AddInstantSpeed(builder, InstantSpeed);
			IAccelerateSkiConfig.AddAcceleration(builder, Acceleration);
			IAccelerateSkiConfig.AddLimitSpeed(builder, LimitSpeed);
			IAccelerateSkiConfig.AddDuration(builder, Duration);
			IAccelerateSkiConfig.AddTarget(builder, TargetOffset);
			IAccelerateSkiConfig.AddNullMask(builder, NullMask);
			IAccelerateSkiConfig.AddTargetType(builder, Target_type);
			IAccelerateSkiConfig.AddType(builder, Type);
			return IAccelerateSkiConfig.EndIAccelerateSkiConfig(builder);
		}

		// Token: 0x06029CA2 RID: 171170 RVA: 0x005BBF1B File Offset: 0x005BA11B
		public static void StartIAccelerateSkiConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06029CA3 RID: 171171 RVA: 0x005BBF24 File Offset: 0x005BA124
		public static void AddType(FlatBufferBuilder builder, ESkiConfig type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029CA4 RID: 171172 RVA: 0x005BBF2F File Offset: 0x005BA12F
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x06029CA5 RID: 171173 RVA: 0x005BBF3A File Offset: 0x005BA13A
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x06029CA6 RID: 171174 RVA: 0x005BBF45 File Offset: 0x005BA145
		public static void AddDuration(FlatBufferBuilder builder, int duration)
		{
			builder.AddInt(3, duration, 0);
		}

		// Token: 0x06029CA7 RID: 171175 RVA: 0x005BBF50 File Offset: 0x005BA150
		public static void AddLimitSpeed(FlatBufferBuilder builder, int limitSpeed)
		{
			builder.AddInt(4, limitSpeed, 0);
		}

		// Token: 0x06029CA8 RID: 171176 RVA: 0x005BBF5B File Offset: 0x005BA15B
		public static void AddAcceleration(FlatBufferBuilder builder, int acceleration)
		{
			builder.AddInt(5, acceleration, 0);
		}

		// Token: 0x06029CA9 RID: 171177 RVA: 0x005BBF66 File Offset: 0x005BA166
		public static void AddInstantSpeed(FlatBufferBuilder builder, int instantSpeed)
		{
			builder.AddInt(6, instantSpeed, 0);
		}

		// Token: 0x06029CAA RID: 171178 RVA: 0x005BBF71 File Offset: 0x005BA171
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06029CAB RID: 171179 RVA: 0x005BBF7C File Offset: 0x005BA17C
		public static Offset<IAccelerateSkiConfig> EndIAccelerateSkiConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAccelerateSkiConfig>(builder.EndTable());
		}

		// Token: 0x06029CAC RID: 171180 RVA: 0x005BBF8C File Offset: 0x005BA18C
		public IAccelerateSkiConfigT UnPack()
		{
			IAccelerateSkiConfigT accelerateSkiConfigT = new IAccelerateSkiConfigT();
			this.UnPackTo(accelerateSkiConfigT);
			return accelerateSkiConfigT;
		}

		// Token: 0x06029CAD RID: 171181 RVA: 0x005BBFA8 File Offset: 0x005BA1A8
		public void UnPackTo(IAccelerateSkiConfigT _o)
		{
			_o.Type = this.Type;
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
			_o.Duration = this.Duration;
			_o.LimitSpeed = this.LimitSpeed;
			_o.Acceleration = this.Acceleration;
			_o.InstantSpeed = this.InstantSpeed;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029CAE RID: 171182 RVA: 0x005BC160 File Offset: 0x005BA360
		public static Offset<IAccelerateSkiConfig> Pack(FlatBufferBuilder builder, IAccelerateSkiConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAccelerateSkiConfig>);
			}
			TTargetEntity target_type = (_o.Target == null) ? TTargetEntity.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TTargetEntityUnion.Pack(builder, _o.Target);
			return IAccelerateSkiConfig.CreateIAccelerateSkiConfig(builder, _o.Type, target_type, targetOffset, _o.Duration, _o.LimitSpeed, _o.Acceleration, _o.InstantSpeed, _o.NullMask);
		}

		// Token: 0x04010228 RID: 66088
		private Table __p;
	}
}
