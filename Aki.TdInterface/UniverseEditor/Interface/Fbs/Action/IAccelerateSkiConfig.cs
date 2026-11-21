using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066CA RID: 26314
	public struct IAccelerateSkiConfig : IFlatbufferObject
	{
		// Token: 0x1700BF42 RID: 48962
		// (get) Token: 0x0602C342 RID: 181058 RVA: 0x006050B4 File Offset: 0x006032B4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C343 RID: 181059 RVA: 0x006050C1 File Offset: 0x006032C1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C344 RID: 181060 RVA: 0x006050C8 File Offset: 0x006032C8
		public static IAccelerateSkiConfig GetRootAsIAccelerateSkiConfig(ByteBuffer _bb)
		{
			return IAccelerateSkiConfig.GetRootAsIAccelerateSkiConfig(_bb, default(IAccelerateSkiConfig));
		}

		// Token: 0x0602C345 RID: 181061 RVA: 0x006050E4 File Offset: 0x006032E4
		public static IAccelerateSkiConfig GetRootAsIAccelerateSkiConfig(ByteBuffer _bb, IAccelerateSkiConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C346 RID: 181062 RVA: 0x00605101 File Offset: 0x00603301
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C347 RID: 181063 RVA: 0x00605110 File Offset: 0x00603310
		public IAccelerateSkiConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF43 RID: 48963
		// (get) Token: 0x0602C348 RID: 181064 RVA: 0x00605120 File Offset: 0x00603320
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

		// Token: 0x1700BF44 RID: 48964
		// (get) Token: 0x0602C349 RID: 181065 RVA: 0x0060515C File Offset: 0x0060335C
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

		// Token: 0x0602C34A RID: 181066 RVA: 0x00605198 File Offset: 0x00603398
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C34B RID: 181067 RVA: 0x006051DC File Offset: 0x006033DC
		public IPlayerEntity TargetAsIPlayerEntity()
		{
			return this.Target<IPlayerEntity>().Value;
		}

		// Token: 0x0602C34C RID: 181068 RVA: 0x006051F8 File Offset: 0x006033F8
		public ISelfEntity TargetAsISelfEntity()
		{
			return this.Target<ISelfEntity>().Value;
		}

		// Token: 0x0602C34D RID: 181069 RVA: 0x00605214 File Offset: 0x00603414
		public ITargetEntity TargetAsITargetEntity()
		{
			return this.Target<ITargetEntity>().Value;
		}

		// Token: 0x0602C34E RID: 181070 RVA: 0x00605230 File Offset: 0x00603430
		public ITriggeredEntity TargetAsITriggeredEntity()
		{
			return this.Target<ITriggeredEntity>().Value;
		}

		// Token: 0x0602C34F RID: 181071 RVA: 0x0060524C File Offset: 0x0060344C
		public IVehicleEntity TargetAsIVehicleEntity()
		{
			return this.Target<IVehicleEntity>().Value;
		}

		// Token: 0x1700BF45 RID: 48965
		// (get) Token: 0x0602C350 RID: 181072 RVA: 0x00605268 File Offset: 0x00603468
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

		// Token: 0x1700BF46 RID: 48966
		// (get) Token: 0x0602C351 RID: 181073 RVA: 0x006052A8 File Offset: 0x006034A8
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

		// Token: 0x1700BF47 RID: 48967
		// (get) Token: 0x0602C352 RID: 181074 RVA: 0x006052E8 File Offset: 0x006034E8
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

		// Token: 0x1700BF48 RID: 48968
		// (get) Token: 0x0602C353 RID: 181075 RVA: 0x00605328 File Offset: 0x00603528
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

		// Token: 0x1700BF49 RID: 48969
		// (get) Token: 0x0602C354 RID: 181076 RVA: 0x00605368 File Offset: 0x00603568
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

		// Token: 0x0602C355 RID: 181077 RVA: 0x006053A8 File Offset: 0x006035A8
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

		// Token: 0x0602C356 RID: 181078 RVA: 0x006053FF File Offset: 0x006035FF
		public static void StartIAccelerateSkiConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0602C357 RID: 181079 RVA: 0x00605408 File Offset: 0x00603608
		public static void AddType(FlatBufferBuilder builder, ESkiConfig type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C358 RID: 181080 RVA: 0x00605413 File Offset: 0x00603613
		public static void AddTargetType(FlatBufferBuilder builder, TTargetEntity targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0602C359 RID: 181081 RVA: 0x0060541E File Offset: 0x0060361E
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0602C35A RID: 181082 RVA: 0x00605429 File Offset: 0x00603629
		public static void AddDuration(FlatBufferBuilder builder, int duration)
		{
			builder.AddInt(3, duration, 0);
		}

		// Token: 0x0602C35B RID: 181083 RVA: 0x00605434 File Offset: 0x00603634
		public static void AddLimitSpeed(FlatBufferBuilder builder, int limitSpeed)
		{
			builder.AddInt(4, limitSpeed, 0);
		}

		// Token: 0x0602C35C RID: 181084 RVA: 0x0060543F File Offset: 0x0060363F
		public static void AddAcceleration(FlatBufferBuilder builder, int acceleration)
		{
			builder.AddInt(5, acceleration, 0);
		}

		// Token: 0x0602C35D RID: 181085 RVA: 0x0060544A File Offset: 0x0060364A
		public static void AddInstantSpeed(FlatBufferBuilder builder, int instantSpeed)
		{
			builder.AddInt(6, instantSpeed, 0);
		}

		// Token: 0x0602C35E RID: 181086 RVA: 0x00605455 File Offset: 0x00603655
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x0602C35F RID: 181087 RVA: 0x00605460 File Offset: 0x00603660
		public static Offset<IAccelerateSkiConfig> EndIAccelerateSkiConfig(FlatBufferBuilder builder)
		{
			return new Offset<IAccelerateSkiConfig>(builder.EndTable());
		}

		// Token: 0x0602C360 RID: 181088 RVA: 0x00605470 File Offset: 0x00603670
		public IAccelerateSkiConfigT UnPack()
		{
			IAccelerateSkiConfigT accelerateSkiConfigT = new IAccelerateSkiConfigT();
			this.UnPackTo(accelerateSkiConfigT);
			return accelerateSkiConfigT;
		}

		// Token: 0x0602C361 RID: 181089 RVA: 0x0060548C File Offset: 0x0060368C
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

		// Token: 0x0602C362 RID: 181090 RVA: 0x00605644 File Offset: 0x00603844
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

		// Token: 0x0401101D RID: 69661
		private Table __p;
	}
}
