using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B42 RID: 27458
	public struct IMotorSpeedDownConfig : IFlatbufferObject
	{
		// Token: 0x1700CC06 RID: 52230
		// (get) Token: 0x0603031D RID: 197405 RVA: 0x0068CBDD File Offset: 0x0068ADDD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603031E RID: 197406 RVA: 0x0068CBEA File Offset: 0x0068ADEA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603031F RID: 197407 RVA: 0x0068CBF4 File Offset: 0x0068ADF4
		public static IMotorSpeedDownConfig GetRootAsIMotorSpeedDownConfig(ByteBuffer _bb)
		{
			return IMotorSpeedDownConfig.GetRootAsIMotorSpeedDownConfig(_bb, default(IMotorSpeedDownConfig));
		}

		// Token: 0x06030320 RID: 197408 RVA: 0x0068CC10 File Offset: 0x0068AE10
		public static IMotorSpeedDownConfig GetRootAsIMotorSpeedDownConfig(ByteBuffer _bb, IMotorSpeedDownConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06030321 RID: 197409 RVA: 0x0068CC2D File Offset: 0x0068AE2D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06030322 RID: 197410 RVA: 0x0068CC3C File Offset: 0x0068AE3C
		public IMotorSpeedDownConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC07 RID: 52231
		// (get) Token: 0x06030323 RID: 197411 RVA: 0x0068CC4C File Offset: 0x0068AE4C
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

		// Token: 0x1700CC08 RID: 52232
		// (get) Token: 0x06030324 RID: 197412 RVA: 0x0068CC88 File Offset: 0x0068AE88
		public EMotorSpeedDownConfig SpeedDownTagId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EMotorSpeedDownConfig.None;
				}
				return (EMotorSpeedDownConfig)this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030325 RID: 197413 RVA: 0x0068CCC4 File Offset: 0x0068AEC4
		public static Offset<IMotorSpeedDownConfig> CreateIMotorSpeedDownConfig(FlatBufferBuilder builder, EMotorParamsChangeType Type = EMotorParamsChangeType.SpeedUp, EMotorSpeedDownConfig SpeedDownTagId = EMotorSpeedDownConfig.None)
		{
			builder.StartTable(2);
			IMotorSpeedDownConfig.AddSpeedDownTagId(builder, SpeedDownTagId);
			IMotorSpeedDownConfig.AddType(builder, Type);
			return IMotorSpeedDownConfig.EndIMotorSpeedDownConfig(builder);
		}

		// Token: 0x06030326 RID: 197414 RVA: 0x0068CCE1 File Offset: 0x0068AEE1
		public static void StartIMotorSpeedDownConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030327 RID: 197415 RVA: 0x0068CCEA File Offset: 0x0068AEEA
		public static void AddType(FlatBufferBuilder builder, EMotorParamsChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06030328 RID: 197416 RVA: 0x0068CCF5 File Offset: 0x0068AEF5
		public static void AddSpeedDownTagId(FlatBufferBuilder builder, EMotorSpeedDownConfig speedDownTagId)
		{
			builder.AddInt(1, (int)speedDownTagId, 0);
		}

		// Token: 0x06030329 RID: 197417 RVA: 0x0068CD00 File Offset: 0x0068AF00
		public static Offset<IMotorSpeedDownConfig> EndIMotorSpeedDownConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorSpeedDownConfig>(builder.EndTable());
		}

		// Token: 0x0603032A RID: 197418 RVA: 0x0068CD10 File Offset: 0x0068AF10
		public IMotorSpeedDownConfigT UnPack()
		{
			IMotorSpeedDownConfigT motorSpeedDownConfigT = new IMotorSpeedDownConfigT();
			this.UnPackTo(motorSpeedDownConfigT);
			return motorSpeedDownConfigT;
		}

		// Token: 0x0603032B RID: 197419 RVA: 0x0068CD2B File Offset: 0x0068AF2B
		public void UnPackTo(IMotorSpeedDownConfigT _o)
		{
			_o.Type = this.Type;
			_o.SpeedDownTagId = this.SpeedDownTagId;
		}

		// Token: 0x0603032C RID: 197420 RVA: 0x0068CD48 File Offset: 0x0068AF48
		public static Offset<IMotorSpeedDownConfig> Pack(FlatBufferBuilder builder, IMotorSpeedDownConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorSpeedDownConfig>);
			}
			return IMotorSpeedDownConfig.CreateIMotorSpeedDownConfig(builder, _o.Type, _o.SpeedDownTagId);
		}

		// Token: 0x040113E0 RID: 70624
		private Table __p;
	}
}
