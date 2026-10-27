using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007115 RID: 28949
	public struct ISingleAxisSpringArmSoftZoneConfig : IFlatbufferObject
	{
		// Token: 0x1700D730 RID: 55088
		// (get) Token: 0x06033527 RID: 210215 RVA: 0x006EB233 File Offset: 0x006E9433
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033528 RID: 210216 RVA: 0x006EB240 File Offset: 0x006E9440
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033529 RID: 210217 RVA: 0x006EB248 File Offset: 0x006E9448
		public static ISingleAxisSpringArmSoftZoneConfig GetRootAsISingleAxisSpringArmSoftZoneConfig(ByteBuffer _bb)
		{
			return ISingleAxisSpringArmSoftZoneConfig.GetRootAsISingleAxisSpringArmSoftZoneConfig(_bb, default(ISingleAxisSpringArmSoftZoneConfig));
		}

		// Token: 0x0603352A RID: 210218 RVA: 0x006EB264 File Offset: 0x006E9464
		public static ISingleAxisSpringArmSoftZoneConfig GetRootAsISingleAxisSpringArmSoftZoneConfig(ByteBuffer _bb, ISingleAxisSpringArmSoftZoneConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603352B RID: 210219 RVA: 0x006EB281 File Offset: 0x006E9481
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603352C RID: 210220 RVA: 0x006EB290 File Offset: 0x006E9490
		public ISingleAxisSpringArmSoftZoneConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D731 RID: 55089
		// (get) Token: 0x0603352D RID: 210221 RVA: 0x006EB2A0 File Offset: 0x006E94A0
		public float MaxOffsetDistance
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D732 RID: 55090
		// (get) Token: 0x0603352E RID: 210222 RVA: 0x006EB2E0 File Offset: 0x006E94E0
		public float MinOffsetDistance
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D733 RID: 55091
		// (get) Token: 0x0603352F RID: 210223 RVA: 0x006EB320 File Offset: 0x006E9520
		public float MaxInterpolationSpeed
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D734 RID: 55092
		// (get) Token: 0x06033530 RID: 210224 RVA: 0x006EB360 File Offset: 0x006E9560
		public float MinInterpolationSpeed
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D735 RID: 55093
		// (get) Token: 0x06033531 RID: 210225 RVA: 0x006EB3A4 File Offset: 0x006E95A4
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

		// Token: 0x06033532 RID: 210226 RVA: 0x006EB3E1 File Offset: 0x006E95E1
		public static Offset<ISingleAxisSpringArmSoftZoneConfig> CreateISingleAxisSpringArmSoftZoneConfig(FlatBufferBuilder builder, float MaxOffsetDistance = 0f, float MinOffsetDistance = 0f, float MaxInterpolationSpeed = 0f, float MinInterpolationSpeed = 0f, byte NullMask = 0)
		{
			builder.StartTable(5);
			ISingleAxisSpringArmSoftZoneConfig.AddMinInterpolationSpeed(builder, MinInterpolationSpeed);
			ISingleAxisSpringArmSoftZoneConfig.AddMaxInterpolationSpeed(builder, MaxInterpolationSpeed);
			ISingleAxisSpringArmSoftZoneConfig.AddMinOffsetDistance(builder, MinOffsetDistance);
			ISingleAxisSpringArmSoftZoneConfig.AddMaxOffsetDistance(builder, MaxOffsetDistance);
			ISingleAxisSpringArmSoftZoneConfig.AddNullMask(builder, NullMask);
			return ISingleAxisSpringArmSoftZoneConfig.EndISingleAxisSpringArmSoftZoneConfig(builder);
		}

		// Token: 0x06033533 RID: 210227 RVA: 0x006EB415 File Offset: 0x006E9615
		public static void StartISingleAxisSpringArmSoftZoneConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06033534 RID: 210228 RVA: 0x006EB41E File Offset: 0x006E961E
		public static void AddMaxOffsetDistance(FlatBufferBuilder builder, float maxOffsetDistance)
		{
			builder.AddFloat(0, maxOffsetDistance, 0.0);
		}

		// Token: 0x06033535 RID: 210229 RVA: 0x006EB431 File Offset: 0x006E9631
		public static void AddMinOffsetDistance(FlatBufferBuilder builder, float minOffsetDistance)
		{
			builder.AddFloat(1, minOffsetDistance, 0.0);
		}

		// Token: 0x06033536 RID: 210230 RVA: 0x006EB444 File Offset: 0x006E9644
		public static void AddMaxInterpolationSpeed(FlatBufferBuilder builder, float maxInterpolationSpeed)
		{
			builder.AddFloat(2, maxInterpolationSpeed, 0.0);
		}

		// Token: 0x06033537 RID: 210231 RVA: 0x006EB457 File Offset: 0x006E9657
		public static void AddMinInterpolationSpeed(FlatBufferBuilder builder, float minInterpolationSpeed)
		{
			builder.AddFloat(3, minInterpolationSpeed, 0.0);
		}

		// Token: 0x06033538 RID: 210232 RVA: 0x006EB46A File Offset: 0x006E966A
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06033539 RID: 210233 RVA: 0x006EB475 File Offset: 0x006E9675
		public static Offset<ISingleAxisSpringArmSoftZoneConfig> EndISingleAxisSpringArmSoftZoneConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISingleAxisSpringArmSoftZoneConfig>(builder.EndTable());
		}

		// Token: 0x0603353A RID: 210234 RVA: 0x006EB484 File Offset: 0x006E9684
		public ISingleAxisSpringArmSoftZoneConfigT UnPack()
		{
			ISingleAxisSpringArmSoftZoneConfigT singleAxisSpringArmSoftZoneConfigT = new ISingleAxisSpringArmSoftZoneConfigT();
			this.UnPackTo(singleAxisSpringArmSoftZoneConfigT);
			return singleAxisSpringArmSoftZoneConfigT;
		}

		// Token: 0x0603353B RID: 210235 RVA: 0x006EB49F File Offset: 0x006E969F
		public void UnPackTo(ISingleAxisSpringArmSoftZoneConfigT _o)
		{
			_o.MaxOffsetDistance = this.MaxOffsetDistance;
			_o.MinOffsetDistance = this.MinOffsetDistance;
			_o.MaxInterpolationSpeed = this.MaxInterpolationSpeed;
			_o.MinInterpolationSpeed = this.MinInterpolationSpeed;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603353C RID: 210236 RVA: 0x006EB4E0 File Offset: 0x006E96E0
		public static Offset<ISingleAxisSpringArmSoftZoneConfig> Pack(FlatBufferBuilder builder, ISingleAxisSpringArmSoftZoneConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISingleAxisSpringArmSoftZoneConfig>);
			}
			return ISingleAxisSpringArmSoftZoneConfig.CreateISingleAxisSpringArmSoftZoneConfig(builder, _o.MaxOffsetDistance, _o.MinOffsetDistance, _o.MaxInterpolationSpeed, _o.MinInterpolationSpeed, _o.NullMask);
		}

		// Token: 0x04011BA4 RID: 72612
		private Table __p;
	}
}
