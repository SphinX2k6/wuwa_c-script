using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061AC RID: 25004
	public struct IAttenuatedGamepadShake : IFlatbufferObject
	{
		// Token: 0x1700BA6A RID: 47722
		// (get) Token: 0x0602B140 RID: 176448 RVA: 0x005F0C6C File Offset: 0x005EEE6C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B141 RID: 176449 RVA: 0x005F0C79 File Offset: 0x005EEE79
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B142 RID: 176450 RVA: 0x005F0C80 File Offset: 0x005EEE80
		public static IAttenuatedGamepadShake GetRootAsIAttenuatedGamepadShake(ByteBuffer _bb)
		{
			return IAttenuatedGamepadShake.GetRootAsIAttenuatedGamepadShake(_bb, default(IAttenuatedGamepadShake));
		}

		// Token: 0x0602B143 RID: 176451 RVA: 0x005F0C9C File Offset: 0x005EEE9C
		public static IAttenuatedGamepadShake GetRootAsIAttenuatedGamepadShake(ByteBuffer _bb, IAttenuatedGamepadShake obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B144 RID: 176452 RVA: 0x005F0CB9 File Offset: 0x005EEEB9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B145 RID: 176453 RVA: 0x005F0CC8 File Offset: 0x005EEEC8
		public IAttenuatedGamepadShake __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BA6B RID: 47723
		// (get) Token: 0x0602B146 RID: 176454 RVA: 0x005F0CD8 File Offset: 0x005EEED8
		public EGamepadShakeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EGamepadShakeType.Onetime;
				}
				return (EGamepadShakeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BA6C RID: 47724
		// (get) Token: 0x0602B147 RID: 176455 RVA: 0x005F0D14 File Offset: 0x005EEF14
		public int CenterEntity
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

		// Token: 0x1700BA6D RID: 47725
		// (get) Token: 0x0602B148 RID: 176456 RVA: 0x005F0D50 File Offset: 0x005EEF50
		public bool IsFollowEntityMovement
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BA6E RID: 47726
		// (get) Token: 0x0602B149 RID: 176457 RVA: 0x005F0D90 File Offset: 0x005EEF90
		public string ForceFeedbackAttenuation
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B14A RID: 176458 RVA: 0x005F0DC8 File Offset: 0x005EEFC8
		public Span<byte> GetForceFeedbackAttenuationBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602B14B RID: 176459 RVA: 0x005F0DD8 File Offset: 0x005EEFD8
		public byte[] GetForceFeedbackAttenuationArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700BA6F RID: 47727
		// (get) Token: 0x0602B14C RID: 176460 RVA: 0x005F0DE8 File Offset: 0x005EEFE8
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BA70 RID: 47728
		// (get) Token: 0x0602B14D RID: 176461 RVA: 0x005F0E2C File Offset: 0x005EF02C
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602B14E RID: 176462 RVA: 0x005F0E6C File Offset: 0x005EF06C
		public static Offset<IAttenuatedGamepadShake> CreateIAttenuatedGamepadShake(FlatBufferBuilder builder, EGamepadShakeType Type = EGamepadShakeType.Onetime, int CenterEntity = 0, bool IsFollowEntityMovement = false, StringOffset ForceFeedbackAttenuationOffset = default(StringOffset), float Duration = 0f, bool IsLoop = false)
		{
			builder.StartTable(6);
			IAttenuatedGamepadShake.AddDuration(builder, Duration);
			IAttenuatedGamepadShake.AddForceFeedbackAttenuation(builder, ForceFeedbackAttenuationOffset);
			IAttenuatedGamepadShake.AddCenterEntity(builder, CenterEntity);
			IAttenuatedGamepadShake.AddIsLoop(builder, IsLoop);
			IAttenuatedGamepadShake.AddIsFollowEntityMovement(builder, IsFollowEntityMovement);
			IAttenuatedGamepadShake.AddType(builder, Type);
			return IAttenuatedGamepadShake.EndIAttenuatedGamepadShake(builder);
		}

		// Token: 0x0602B14F RID: 176463 RVA: 0x005F0EA8 File Offset: 0x005EF0A8
		public static void StartIAttenuatedGamepadShake(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602B150 RID: 176464 RVA: 0x005F0EB1 File Offset: 0x005EF0B1
		public static void AddType(FlatBufferBuilder builder, EGamepadShakeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B151 RID: 176465 RVA: 0x005F0EBC File Offset: 0x005EF0BC
		public static void AddCenterEntity(FlatBufferBuilder builder, int centerEntity)
		{
			builder.AddInt(1, centerEntity, 0);
		}

		// Token: 0x0602B152 RID: 176466 RVA: 0x005F0EC7 File Offset: 0x005EF0C7
		public static void AddIsFollowEntityMovement(FlatBufferBuilder builder, bool isFollowEntityMovement)
		{
			builder.AddBool(2, isFollowEntityMovement, false);
		}

		// Token: 0x0602B153 RID: 176467 RVA: 0x005F0ED2 File Offset: 0x005EF0D2
		public static void AddForceFeedbackAttenuation(FlatBufferBuilder builder, StringOffset forceFeedbackAttenuationOffset)
		{
			builder.AddOffset(3, forceFeedbackAttenuationOffset.Value, 0);
		}

		// Token: 0x0602B154 RID: 176468 RVA: 0x005F0EE2 File Offset: 0x005EF0E2
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(4, duration, 0.0);
		}

		// Token: 0x0602B155 RID: 176469 RVA: 0x005F0EF5 File Offset: 0x005EF0F5
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(5, isLoop, false);
		}

		// Token: 0x0602B156 RID: 176470 RVA: 0x005F0F00 File Offset: 0x005EF100
		public static Offset<IAttenuatedGamepadShake> EndIAttenuatedGamepadShake(FlatBufferBuilder builder)
		{
			return new Offset<IAttenuatedGamepadShake>(builder.EndTable());
		}

		// Token: 0x0602B157 RID: 176471 RVA: 0x005F0F10 File Offset: 0x005EF110
		public IAttenuatedGamepadShakeT UnPack()
		{
			IAttenuatedGamepadShakeT attenuatedGamepadShakeT = new IAttenuatedGamepadShakeT();
			this.UnPackTo(attenuatedGamepadShakeT);
			return attenuatedGamepadShakeT;
		}

		// Token: 0x0602B158 RID: 176472 RVA: 0x005F0F2C File Offset: 0x005EF12C
		public void UnPackTo(IAttenuatedGamepadShakeT _o)
		{
			_o.Type = this.Type;
			_o.CenterEntity = this.CenterEntity;
			_o.IsFollowEntityMovement = this.IsFollowEntityMovement;
			_o.ForceFeedbackAttenuation = this.ForceFeedbackAttenuation;
			_o.Duration = this.Duration;
			_o.IsLoop = this.IsLoop;
		}

		// Token: 0x0602B159 RID: 176473 RVA: 0x005F0F84 File Offset: 0x005EF184
		public static Offset<IAttenuatedGamepadShake> Pack(FlatBufferBuilder builder, IAttenuatedGamepadShakeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAttenuatedGamepadShake>);
			}
			StringOffset forceFeedbackAttenuationOffset = (_o.ForceFeedbackAttenuation == null) ? default(StringOffset) : builder.CreateString(_o.ForceFeedbackAttenuation);
			return IAttenuatedGamepadShake.CreateIAttenuatedGamepadShake(builder, _o.Type, _o.CenterEntity, _o.IsFollowEntityMovement, forceFeedbackAttenuationOffset, _o.Duration, _o.IsLoop);
		}

		// Token: 0x040106C7 RID: 67271
		private Table __p;
	}
}
