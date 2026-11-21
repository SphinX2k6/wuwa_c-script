using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007288 RID: 29320
	public struct IMotorSpeedDownConfig : IFlatbufferObject
	{
		// Token: 0x1700D6EB RID: 55019
		// (get) Token: 0x06033174 RID: 209268 RVA: 0x006E5199 File Offset: 0x006E3399
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033175 RID: 209269 RVA: 0x006E51A6 File Offset: 0x006E33A6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033176 RID: 209270 RVA: 0x006E51B0 File Offset: 0x006E33B0
		public static IMotorSpeedDownConfig GetRootAsIMotorSpeedDownConfig(ByteBuffer _bb)
		{
			return IMotorSpeedDownConfig.GetRootAsIMotorSpeedDownConfig(_bb, default(IMotorSpeedDownConfig));
		}

		// Token: 0x06033177 RID: 209271 RVA: 0x006E51CC File Offset: 0x006E33CC
		public static IMotorSpeedDownConfig GetRootAsIMotorSpeedDownConfig(ByteBuffer _bb, IMotorSpeedDownConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033178 RID: 209272 RVA: 0x006E51E9 File Offset: 0x006E33E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033179 RID: 209273 RVA: 0x006E51F8 File Offset: 0x006E33F8
		public IMotorSpeedDownConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D6EC RID: 55020
		// (get) Token: 0x0603317A RID: 209274 RVA: 0x006E5208 File Offset: 0x006E3408
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

		// Token: 0x1700D6ED RID: 55021
		// (get) Token: 0x0603317B RID: 209275 RVA: 0x006E5244 File Offset: 0x006E3444
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

		// Token: 0x0603317C RID: 209276 RVA: 0x006E5280 File Offset: 0x006E3480
		public static Offset<IMotorSpeedDownConfig> CreateIMotorSpeedDownConfig(FlatBufferBuilder builder, EMotorParamsChangeType Type = EMotorParamsChangeType.SpeedUp, EMotorSpeedDownConfig SpeedDownTagId = EMotorSpeedDownConfig.None)
		{
			builder.StartTable(2);
			IMotorSpeedDownConfig.AddSpeedDownTagId(builder, SpeedDownTagId);
			IMotorSpeedDownConfig.AddType(builder, Type);
			return IMotorSpeedDownConfig.EndIMotorSpeedDownConfig(builder);
		}

		// Token: 0x0603317D RID: 209277 RVA: 0x006E529D File Offset: 0x006E349D
		public static void StartIMotorSpeedDownConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603317E RID: 209278 RVA: 0x006E52A6 File Offset: 0x006E34A6
		public static void AddType(FlatBufferBuilder builder, EMotorParamsChangeType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603317F RID: 209279 RVA: 0x006E52B1 File Offset: 0x006E34B1
		public static void AddSpeedDownTagId(FlatBufferBuilder builder, EMotorSpeedDownConfig speedDownTagId)
		{
			builder.AddInt(1, (int)speedDownTagId, 0);
		}

		// Token: 0x06033180 RID: 209280 RVA: 0x006E52BC File Offset: 0x006E34BC
		public static Offset<IMotorSpeedDownConfig> EndIMotorSpeedDownConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorSpeedDownConfig>(builder.EndTable());
		}

		// Token: 0x06033181 RID: 209281 RVA: 0x006E52CC File Offset: 0x006E34CC
		public IMotorSpeedDownConfigT UnPack()
		{
			IMotorSpeedDownConfigT motorSpeedDownConfigT = new IMotorSpeedDownConfigT();
			this.UnPackTo(motorSpeedDownConfigT);
			return motorSpeedDownConfigT;
		}

		// Token: 0x06033182 RID: 209282 RVA: 0x006E52E7 File Offset: 0x006E34E7
		public void UnPackTo(IMotorSpeedDownConfigT _o)
		{
			_o.Type = this.Type;
			_o.SpeedDownTagId = this.SpeedDownTagId;
		}

		// Token: 0x06033183 RID: 209283 RVA: 0x006E5304 File Offset: 0x006E3504
		public static Offset<IMotorSpeedDownConfig> Pack(FlatBufferBuilder builder, IMotorSpeedDownConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorSpeedDownConfig>);
			}
			return IMotorSpeedDownConfig.CreateIMotorSpeedDownConfig(builder, _o.Type, _o.SpeedDownTagId);
		}

		// Token: 0x04012309 RID: 74505
		private Table __p;
	}
}
