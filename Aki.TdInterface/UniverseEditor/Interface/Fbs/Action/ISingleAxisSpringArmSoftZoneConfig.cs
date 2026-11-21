using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078E1 RID: 30945
	public struct ISingleAxisSpringArmSoftZoneConfig : IFlatbufferObject
	{
		// Token: 0x1700E313 RID: 58131
		// (get) Token: 0x060367C9 RID: 223177 RVA: 0x0074B83F File Offset: 0x00749A3F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060367CA RID: 223178 RVA: 0x0074B84C File Offset: 0x00749A4C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060367CB RID: 223179 RVA: 0x0074B854 File Offset: 0x00749A54
		public static ISingleAxisSpringArmSoftZoneConfig GetRootAsISingleAxisSpringArmSoftZoneConfig(ByteBuffer _bb)
		{
			return ISingleAxisSpringArmSoftZoneConfig.GetRootAsISingleAxisSpringArmSoftZoneConfig(_bb, default(ISingleAxisSpringArmSoftZoneConfig));
		}

		// Token: 0x060367CC RID: 223180 RVA: 0x0074B870 File Offset: 0x00749A70
		public static ISingleAxisSpringArmSoftZoneConfig GetRootAsISingleAxisSpringArmSoftZoneConfig(ByteBuffer _bb, ISingleAxisSpringArmSoftZoneConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060367CD RID: 223181 RVA: 0x0074B88D File Offset: 0x00749A8D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060367CE RID: 223182 RVA: 0x0074B89C File Offset: 0x00749A9C
		public ISingleAxisSpringArmSoftZoneConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E314 RID: 58132
		// (get) Token: 0x060367CF RID: 223183 RVA: 0x0074B8AC File Offset: 0x00749AAC
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

		// Token: 0x1700E315 RID: 58133
		// (get) Token: 0x060367D0 RID: 223184 RVA: 0x0074B8EC File Offset: 0x00749AEC
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

		// Token: 0x1700E316 RID: 58134
		// (get) Token: 0x060367D1 RID: 223185 RVA: 0x0074B92C File Offset: 0x00749B2C
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

		// Token: 0x1700E317 RID: 58135
		// (get) Token: 0x060367D2 RID: 223186 RVA: 0x0074B96C File Offset: 0x00749B6C
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

		// Token: 0x1700E318 RID: 58136
		// (get) Token: 0x060367D3 RID: 223187 RVA: 0x0074B9B0 File Offset: 0x00749BB0
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

		// Token: 0x060367D4 RID: 223188 RVA: 0x0074B9ED File Offset: 0x00749BED
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

		// Token: 0x060367D5 RID: 223189 RVA: 0x0074BA21 File Offset: 0x00749C21
		public static void StartISingleAxisSpringArmSoftZoneConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060367D6 RID: 223190 RVA: 0x0074BA2A File Offset: 0x00749C2A
		public static void AddMaxOffsetDistance(FlatBufferBuilder builder, float maxOffsetDistance)
		{
			builder.AddFloat(0, maxOffsetDistance, 0.0);
		}

		// Token: 0x060367D7 RID: 223191 RVA: 0x0074BA3D File Offset: 0x00749C3D
		public static void AddMinOffsetDistance(FlatBufferBuilder builder, float minOffsetDistance)
		{
			builder.AddFloat(1, minOffsetDistance, 0.0);
		}

		// Token: 0x060367D8 RID: 223192 RVA: 0x0074BA50 File Offset: 0x00749C50
		public static void AddMaxInterpolationSpeed(FlatBufferBuilder builder, float maxInterpolationSpeed)
		{
			builder.AddFloat(2, maxInterpolationSpeed, 0.0);
		}

		// Token: 0x060367D9 RID: 223193 RVA: 0x0074BA63 File Offset: 0x00749C63
		public static void AddMinInterpolationSpeed(FlatBufferBuilder builder, float minInterpolationSpeed)
		{
			builder.AddFloat(3, minInterpolationSpeed, 0.0);
		}

		// Token: 0x060367DA RID: 223194 RVA: 0x0074BA76 File Offset: 0x00749C76
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060367DB RID: 223195 RVA: 0x0074BA81 File Offset: 0x00749C81
		public static Offset<ISingleAxisSpringArmSoftZoneConfig> EndISingleAxisSpringArmSoftZoneConfig(FlatBufferBuilder builder)
		{
			return new Offset<ISingleAxisSpringArmSoftZoneConfig>(builder.EndTable());
		}

		// Token: 0x060367DC RID: 223196 RVA: 0x0074BA90 File Offset: 0x00749C90
		public ISingleAxisSpringArmSoftZoneConfigT UnPack()
		{
			ISingleAxisSpringArmSoftZoneConfigT singleAxisSpringArmSoftZoneConfigT = new ISingleAxisSpringArmSoftZoneConfigT();
			this.UnPackTo(singleAxisSpringArmSoftZoneConfigT);
			return singleAxisSpringArmSoftZoneConfigT;
		}

		// Token: 0x060367DD RID: 223197 RVA: 0x0074BAAB File Offset: 0x00749CAB
		public void UnPackTo(ISingleAxisSpringArmSoftZoneConfigT _o)
		{
			_o.MaxOffsetDistance = this.MaxOffsetDistance;
			_o.MinOffsetDistance = this.MinOffsetDistance;
			_o.MaxInterpolationSpeed = this.MaxInterpolationSpeed;
			_o.MinInterpolationSpeed = this.MinInterpolationSpeed;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060367DE RID: 223198 RVA: 0x0074BAEC File Offset: 0x00749CEC
		public static Offset<ISingleAxisSpringArmSoftZoneConfig> Pack(FlatBufferBuilder builder, ISingleAxisSpringArmSoftZoneConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISingleAxisSpringArmSoftZoneConfig>);
			}
			return ISingleAxisSpringArmSoftZoneConfig.CreateISingleAxisSpringArmSoftZoneConfig(builder, _o.MaxOffsetDistance, _o.MinOffsetDistance, _o.MaxInterpolationSpeed, _o.MinInterpolationSpeed, _o.NullMask);
		}

		// Token: 0x04012B92 RID: 76690
		private Table __p;
	}
}
