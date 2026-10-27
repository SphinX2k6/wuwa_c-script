using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B45 RID: 27461
	public struct IMotorSpeedUpConfig : IFlatbufferObject
	{
		// Token: 0x1700CC0B RID: 52235
		// (get) Token: 0x06030333 RID: 197427 RVA: 0x0068CDDE File Offset: 0x0068AFDE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030334 RID: 197428 RVA: 0x0068CDEB File Offset: 0x0068AFEB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030335 RID: 197429 RVA: 0x0068CDF4 File Offset: 0x0068AFF4
		public static IMotorSpeedUpConfig GetRootAsIMotorSpeedUpConfig(ByteBuffer _bb)
		{
			return IMotorSpeedUpConfig.GetRootAsIMotorSpeedUpConfig(_bb, default(IMotorSpeedUpConfig));
		}

		// Token: 0x06030336 RID: 197430 RVA: 0x0068CE10 File Offset: 0x0068B010
		public static IMotorSpeedUpConfig GetRootAsIMotorSpeedUpConfig(ByteBuffer _bb, IMotorSpeedUpConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030337 RID: 197431 RVA: 0x0068CE2D File Offset: 0x0068B02D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030338 RID: 197432 RVA: 0x0068CE3C File Offset: 0x0068B03C
		public IMotorSpeedUpConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC0C RID: 52236
		// (get) Token: 0x06030339 RID: 197433 RVA: 0x0068CE4C File Offset: 0x0068B04C
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

		// Token: 0x1700CC0D RID: 52237
		// (get) Token: 0x0603033A RID: 197434 RVA: 0x0068CE88 File Offset: 0x0068B088
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

		// Token: 0x0603033B RID: 197435 RVA: 0x0068CEC4 File Offset: 0x0068B0C4
		public static Offset<IMotorSpeedUpConfig> CreateIMotorSpeedUpConfig(FlatBufferBuilder builder, EMotorParamsChangeType Type = EMotorParamsChangeType.SpeedUp, EMotorSpeedUpConfigTag SpeedUpTagId = EMotorSpeedUpConfigTag.None)
		{
			builder.StartTable(2);
			IMotorSpeedUpConfig.AddSpeedUpTagId(builder, SpeedUpTagId);
			IMotorSpeedUpConfig.AddType(builder, Type);
			return IMotorSpeedUpConfig.EndIMotorSpeedUpConfig(builder);
		}

		// Token: 0x0603033C RID: 197436 RVA: 0x0068CEE1 File Offset: 0x0068B0E1
		public static void StartIMotorSpeedUpConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603033D RID: 197437 RVA: 0x0068CEEA File Offset: 0x0068B0EA
		public static void AddType(FlatBufferBuilder builder, EMotorParamsChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603033E RID: 197438 RVA: 0x0068CEF5 File Offset: 0x0068B0F5
		public static void AddSpeedUpTagId(FlatBufferBuilder builder, EMotorSpeedUpConfigTag speedUpTagId)
		{
			builder.AddInt(1, (int)speedUpTagId, 0);
		}

		// Token: 0x0603033F RID: 197439 RVA: 0x0068CF00 File Offset: 0x0068B100
		public static Offset<IMotorSpeedUpConfig> EndIMotorSpeedUpConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorSpeedUpConfig>(builder.EndTable());
		}

		// Token: 0x06030340 RID: 197440 RVA: 0x0068CF10 File Offset: 0x0068B110
		public IMotorSpeedUpConfigT UnPack()
		{
			IMotorSpeedUpConfigT motorSpeedUpConfigT = new IMotorSpeedUpConfigT();
			this.UnPackTo(motorSpeedUpConfigT);
			return motorSpeedUpConfigT;
		}

		// Token: 0x06030341 RID: 197441 RVA: 0x0068CF2B File Offset: 0x0068B12B
		public void UnPackTo(IMotorSpeedUpConfigT _o)
		{
			_o.Type = this.Type;
			_o.SpeedUpTagId = this.SpeedUpTagId;
		}

		// Token: 0x06030342 RID: 197442 RVA: 0x0068CF48 File Offset: 0x0068B148
		public static Offset<IMotorSpeedUpConfig> Pack(FlatBufferBuilder builder, IMotorSpeedUpConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorSpeedUpConfig>);
			}
			return IMotorSpeedUpConfig.CreateIMotorSpeedUpConfig(builder, _o.Type, _o.SpeedUpTagId);
		}

		// Token: 0x040113E3 RID: 70627
		private Table __p;
	}
}
