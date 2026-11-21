using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200728B RID: 29323
	public struct IMotorSpeedUpConfig : IFlatbufferObject
	{
		// Token: 0x1700D6F0 RID: 55024
		// (get) Token: 0x0603318A RID: 209290 RVA: 0x006E539A File Offset: 0x006E359A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603318B RID: 209291 RVA: 0x006E53A7 File Offset: 0x006E35A7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603318C RID: 209292 RVA: 0x006E53B0 File Offset: 0x006E35B0
		public static IMotorSpeedUpConfig GetRootAsIMotorSpeedUpConfig(ByteBuffer _bb)
		{
			return IMotorSpeedUpConfig.GetRootAsIMotorSpeedUpConfig(_bb, default(IMotorSpeedUpConfig));
		}

		// Token: 0x0603318D RID: 209293 RVA: 0x006E53CC File Offset: 0x006E35CC
		public static IMotorSpeedUpConfig GetRootAsIMotorSpeedUpConfig(ByteBuffer _bb, IMotorSpeedUpConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603318E RID: 209294 RVA: 0x006E53E9 File Offset: 0x006E35E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603318F RID: 209295 RVA: 0x006E53F8 File Offset: 0x006E35F8
		public IMotorSpeedUpConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6F1 RID: 55025
		// (get) Token: 0x06033190 RID: 209296 RVA: 0x006E5408 File Offset: 0x006E3608
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

		// Token: 0x1700D6F2 RID: 55026
		// (get) Token: 0x06033191 RID: 209297 RVA: 0x006E5444 File Offset: 0x006E3644
		public EMotorSpeedUpConfigTag SpeedUpTagId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EMotorSpeedUpConfigTag.None;
				}
				return (EMotorSpeedUpConfigTag)this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06033192 RID: 209298 RVA: 0x006E5480 File Offset: 0x006E3680
		public static Offset<IMotorSpeedUpConfig> CreateIMotorSpeedUpConfig(FlatBufferBuilder builder, EMotorParamsChangeType Type = EMotorParamsChangeType.SpeedUp, EMotorSpeedUpConfigTag SpeedUpTagId = EMotorSpeedUpConfigTag.None)
		{
			builder.StartTable(2);
			IMotorSpeedUpConfig.AddSpeedUpTagId(builder, SpeedUpTagId);
			IMotorSpeedUpConfig.AddType(builder, Type);
			return IMotorSpeedUpConfig.EndIMotorSpeedUpConfig(builder);
		}

		// Token: 0x06033193 RID: 209299 RVA: 0x006E549D File Offset: 0x006E369D
		public static void StartIMotorSpeedUpConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033194 RID: 209300 RVA: 0x006E54A6 File Offset: 0x006E36A6
		public static void AddType(FlatBufferBuilder builder, EMotorParamsChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033195 RID: 209301 RVA: 0x006E54B1 File Offset: 0x006E36B1
		public static void AddSpeedUpTagId(FlatBufferBuilder builder, EMotorSpeedUpConfigTag speedUpTagId)
		{
			builder.AddInt(1, (int)speedUpTagId, 0);
		}

		// Token: 0x06033196 RID: 209302 RVA: 0x006E54BC File Offset: 0x006E36BC
		public static Offset<IMotorSpeedUpConfig> EndIMotorSpeedUpConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorSpeedUpConfig>(builder.EndTable());
		}

		// Token: 0x06033197 RID: 209303 RVA: 0x006E54CC File Offset: 0x006E36CC
		public IMotorSpeedUpConfigT UnPack()
		{
			IMotorSpeedUpConfigT motorSpeedUpConfigT = new IMotorSpeedUpConfigT();
			this.UnPackTo(motorSpeedUpConfigT);
			return motorSpeedUpConfigT;
		}

		// Token: 0x06033198 RID: 209304 RVA: 0x006E54E7 File Offset: 0x006E36E7
		public void UnPackTo(IMotorSpeedUpConfigT _o)
		{
			_o.Type = this.Type;
			_o.SpeedUpTagId = this.SpeedUpTagId;
		}

		// Token: 0x06033199 RID: 209305 RVA: 0x006E5504 File Offset: 0x006E3704
		public static Offset<IMotorSpeedUpConfig> Pack(FlatBufferBuilder builder, IMotorSpeedUpConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorSpeedUpConfig>);
			}
			return IMotorSpeedUpConfig.CreateIMotorSpeedUpConfig(builder, _o.Type, _o.SpeedUpTagId);
		}

		// Token: 0x0401230C RID: 74508
		private Table __p;
	}
}
