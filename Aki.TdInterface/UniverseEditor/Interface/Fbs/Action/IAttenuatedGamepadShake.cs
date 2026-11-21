using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200681A RID: 26650
	public struct IAttenuatedGamepadShake : IFlatbufferObject
	{
		// Token: 0x1700C3ED RID: 50157
		// (get) Token: 0x0602D887 RID: 186503 RVA: 0x0063B6E0 File Offset: 0x006398E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602D888 RID: 186504 RVA: 0x0063B6ED File Offset: 0x006398ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602D889 RID: 186505 RVA: 0x0063B6F4 File Offset: 0x006398F4
		public static IAttenuatedGamepadShake GetRootAsIAttenuatedGamepadShake(ByteBuffer _bb)
		{
			return IAttenuatedGamepadShake.GetRootAsIAttenuatedGamepadShake(_bb, default(IAttenuatedGamepadShake));
		}

		// Token: 0x0602D88A RID: 186506 RVA: 0x0063B710 File Offset: 0x00639910
		public static IAttenuatedGamepadShake GetRootAsIAttenuatedGamepadShake(ByteBuffer _bb, IAttenuatedGamepadShake obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602D88B RID: 186507 RVA: 0x0063B72D File Offset: 0x0063992D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602D88C RID: 186508 RVA: 0x0063B73C File Offset: 0x0063993C
		public IAttenuatedGamepadShake __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C3EE RID: 50158
		// (get) Token: 0x0602D88D RID: 186509 RVA: 0x0063B74C File Offset: 0x0063994C
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

		// Token: 0x1700C3EF RID: 50159
		// (get) Token: 0x0602D88E RID: 186510 RVA: 0x0063B788 File Offset: 0x00639988
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

		// Token: 0x1700C3F0 RID: 50160
		// (get) Token: 0x0602D88F RID: 186511 RVA: 0x0063B7C4 File Offset: 0x006399C4
		public bool IsFollowEntityMovement
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C3F1 RID: 50161
		// (get) Token: 0x0602D890 RID: 186512 RVA: 0x0063B804 File Offset: 0x00639A04
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

		// Token: 0x0602D891 RID: 186513 RVA: 0x0063B83C File Offset: 0x00639A3C
		public Span<byte> GetForceFeedbackAttenuationBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0602D892 RID: 186514 RVA: 0x0063B84C File Offset: 0x00639A4C
		public byte[] GetForceFeedbackAttenuationArray()
		{
			return this.__p.__vector_as_array<byte>(10);
		}

		// Token: 0x1700C3F2 RID: 50162
		// (get) Token: 0x0602D893 RID: 186515 RVA: 0x0063B85C File Offset: 0x00639A5C
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

		// Token: 0x1700C3F3 RID: 50163
		// (get) Token: 0x0602D894 RID: 186516 RVA: 0x0063B8A0 File Offset: 0x00639AA0
		public bool IsLoop
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602D895 RID: 186517 RVA: 0x0063B8E0 File Offset: 0x00639AE0
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

		// Token: 0x0602D896 RID: 186518 RVA: 0x0063B91C File Offset: 0x00639B1C
		public static void StartIAttenuatedGamepadShake(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602D897 RID: 186519 RVA: 0x0063B925 File Offset: 0x00639B25
		public static void AddType(FlatBufferBuilder builder, EGamepadShakeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602D898 RID: 186520 RVA: 0x0063B930 File Offset: 0x00639B30
		public static void AddCenterEntity(FlatBufferBuilder builder, int centerEntity)
		{
			builder.AddInt(1, centerEntity, 0);
		}

		// Token: 0x0602D899 RID: 186521 RVA: 0x0063B93B File Offset: 0x00639B3B
		public static void AddIsFollowEntityMovement(FlatBufferBuilder builder, bool isFollowEntityMovement)
		{
			builder.AddBool(2, isFollowEntityMovement, false);
		}

		// Token: 0x0602D89A RID: 186522 RVA: 0x0063B946 File Offset: 0x00639B46
		public static void AddForceFeedbackAttenuation(FlatBufferBuilder builder, StringOffset forceFeedbackAttenuationOffset)
		{
			builder.AddOffset(3, forceFeedbackAttenuationOffset.Value, 0);
		}

		// Token: 0x0602D89B RID: 186523 RVA: 0x0063B956 File Offset: 0x00639B56
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(4, duration, 0.0);
		}

		// Token: 0x0602D89C RID: 186524 RVA: 0x0063B969 File Offset: 0x00639B69
		public static void AddIsLoop(FlatBufferBuilder builder, bool isLoop)
		{
			builder.AddBool(5, isLoop, false);
		}

		// Token: 0x0602D89D RID: 186525 RVA: 0x0063B974 File Offset: 0x00639B74
		public static Offset<IAttenuatedGamepadShake> EndIAttenuatedGamepadShake(FlatBufferBuilder builder)
		{
			return new Offset<IAttenuatedGamepadShake>(builder.EndTable());
		}

		// Token: 0x0602D89E RID: 186526 RVA: 0x0063B984 File Offset: 0x00639B84
		public IAttenuatedGamepadShakeT UnPack()
		{
			IAttenuatedGamepadShakeT attenuatedGamepadShakeT = new IAttenuatedGamepadShakeT();
			this.UnPackTo(attenuatedGamepadShakeT);
			return attenuatedGamepadShakeT;
		}

		// Token: 0x0602D89F RID: 186527 RVA: 0x0063B9A0 File Offset: 0x00639BA0
		public void UnPackTo(IAttenuatedGamepadShakeT _o)
		{
			_o.Type = this.Type;
			_o.CenterEntity = this.CenterEntity;
			_o.IsFollowEntityMovement = this.IsFollowEntityMovement;
			_o.ForceFeedbackAttenuation = this.ForceFeedbackAttenuation;
			_o.Duration = this.Duration;
			_o.IsLoop = this.IsLoop;
		}

		// Token: 0x0602D8A0 RID: 186528 RVA: 0x0063B9F8 File Offset: 0x00639BF8
		public static Offset<IAttenuatedGamepadShake> Pack(FlatBufferBuilder builder, IAttenuatedGamepadShakeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAttenuatedGamepadShake>);
			}
			StringOffset forceFeedbackAttenuationOffset = (_o.ForceFeedbackAttenuation == null) ? default(StringOffset) : builder.CreateString(_o.ForceFeedbackAttenuation);
			return IAttenuatedGamepadShake.CreateIAttenuatedGamepadShake(builder, _o.Type, _o.CenterEntity, _o.IsFollowEntityMovement, forceFeedbackAttenuationOffset, _o.Duration, _o.IsLoop);
		}

		// Token: 0x040114D9 RID: 70873
		private Table __p;
	}
}
