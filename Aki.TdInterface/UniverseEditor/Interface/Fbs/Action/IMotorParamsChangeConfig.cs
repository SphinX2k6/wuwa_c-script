using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B1E RID: 27422
	public struct IMotorParamsChangeConfig : IFlatbufferObject
	{
		// Token: 0x1700CBD3 RID: 52179
		// (get) Token: 0x0603021C RID: 197148 RVA: 0x0068AED0 File Offset: 0x006890D0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603021D RID: 197149 RVA: 0x0068AEDD File Offset: 0x006890DD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603021E RID: 197150 RVA: 0x0068AEE4 File Offset: 0x006890E4
		public static IMotorParamsChangeConfig GetRootAsIMotorParamsChangeConfig(ByteBuffer _bb)
		{
			return IMotorParamsChangeConfig.GetRootAsIMotorParamsChangeConfig(_bb, default(IMotorParamsChangeConfig));
		}

		// Token: 0x0603021F RID: 197151 RVA: 0x0068AF00 File Offset: 0x00689100
		public static IMotorParamsChangeConfig GetRootAsIMotorParamsChangeConfig(ByteBuffer _bb, IMotorParamsChangeConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030220 RID: 197152 RVA: 0x0068AF1D File Offset: 0x0068911D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030221 RID: 197153 RVA: 0x0068AF2C File Offset: 0x0068912C
		public IMotorParamsChangeConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CBD4 RID: 52180
		// (get) Token: 0x06030222 RID: 197154 RVA: 0x0068AF3C File Offset: 0x0068913C
		public EMotorParamsChangeType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMotorParamsChangeType.SpeedUp;
				}
				return (EMotorParamsChangeType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030223 RID: 197155 RVA: 0x0068AF78 File Offset: 0x00689178
		public static Offset<IMotorParamsChangeConfig> CreateIMotorParamsChangeConfig(FlatBufferBuilder builder, EMotorParamsChangeType Type = EMotorParamsChangeType.SpeedUp)
		{
			builder.StartTable(1);
			IMotorParamsChangeConfig.AddType(builder, Type);
			return IMotorParamsChangeConfig.EndIMotorParamsChangeConfig(builder);
		}

		// Token: 0x06030224 RID: 197156 RVA: 0x0068AF8E File Offset: 0x0068918E
		public static void StartIMotorParamsChangeConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06030225 RID: 197157 RVA: 0x0068AF97 File Offset: 0x00689197
		public static void AddType(FlatBufferBuilder builder, EMotorParamsChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030226 RID: 197158 RVA: 0x0068AFA2 File Offset: 0x006891A2
		public static Offset<IMotorParamsChangeConfig> EndIMotorParamsChangeConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorParamsChangeConfig>(builder.EndTable());
		}

		// Token: 0x06030227 RID: 197159 RVA: 0x0068AFB0 File Offset: 0x006891B0
		public IMotorParamsChangeConfigT UnPack()
		{
			IMotorParamsChangeConfigT motorParamsChangeConfigT = new IMotorParamsChangeConfigT();
			this.UnPackTo(motorParamsChangeConfigT);
			return motorParamsChangeConfigT;
		}

		// Token: 0x06030228 RID: 197160 RVA: 0x0068AFCB File Offset: 0x006891CB
		public void UnPackTo(IMotorParamsChangeConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06030229 RID: 197161 RVA: 0x0068AFDC File Offset: 0x006891DC
		public static Offset<IMotorParamsChangeConfig> Pack(FlatBufferBuilder builder, IMotorParamsChangeConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorParamsChangeConfig>);
			}
			return IMotorParamsChangeConfig.CreateIMotorParamsChangeConfig(builder, _o.Type);
		}

		// Token: 0x040113B0 RID: 70576
		private Table __p;
	}
}
