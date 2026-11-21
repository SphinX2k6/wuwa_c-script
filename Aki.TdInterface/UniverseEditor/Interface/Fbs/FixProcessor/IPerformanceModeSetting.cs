using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004BCE RID: 19406
	public struct IPerformanceModeSetting : IFlatbufferObject
	{
		// Token: 0x1700895F RID: 35167
		// (get) Token: 0x0601DA0C RID: 121356 RVA: 0x00428A8F File Offset: 0x00426C8F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DA0D RID: 121357 RVA: 0x00428A9C File Offset: 0x00426C9C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DA0E RID: 121358 RVA: 0x00428AA4 File Offset: 0x00426CA4
		public static IPerformanceModeSetting GetRootAsIPerformanceModeSetting(ByteBuffer _bb)
		{
			return IPerformanceModeSetting.GetRootAsIPerformanceModeSetting(_bb, default(IPerformanceModeSetting));
		}

		// Token: 0x0601DA0F RID: 121359 RVA: 0x00428AC0 File Offset: 0x00426CC0
		public static IPerformanceModeSetting GetRootAsIPerformanceModeSetting(ByteBuffer _bb, IPerformanceModeSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DA10 RID: 121360 RVA: 0x00428ADD File Offset: 0x00426CDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DA11 RID: 121361 RVA: 0x00428AEC File Offset: 0x00426CEC
		public IPerformanceModeSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008960 RID: 35168
		// (get) Token: 0x0601DA12 RID: 121362 RVA: 0x00428AFC File Offset: 0x00426CFC
		public EPerformanceMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPerformanceMode.High;
				}
				return (EPerformanceMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601DA13 RID: 121363 RVA: 0x00428B38 File Offset: 0x00426D38
		public static Offset<IPerformanceModeSetting> CreateIPerformanceModeSetting(FlatBufferBuilder builder, EPerformanceMode Type = EPerformanceMode.High)
		{
			builder.StartTable(1);
			IPerformanceModeSetting.AddType(builder, Type);
			return IPerformanceModeSetting.EndIPerformanceModeSetting(builder);
		}

		// Token: 0x0601DA14 RID: 121364 RVA: 0x00428B4E File Offset: 0x00426D4E
		public static void StartIPerformanceModeSetting(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601DA15 RID: 121365 RVA: 0x00428B57 File Offset: 0x00426D57
		public static void AddType(FlatBufferBuilder builder, EPerformanceMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DA16 RID: 121366 RVA: 0x00428B62 File Offset: 0x00426D62
		public static Offset<IPerformanceModeSetting> EndIPerformanceModeSetting(FlatBufferBuilder builder)
		{
			return new Offset<IPerformanceModeSetting>(builder.EndTable());
		}

		// Token: 0x0601DA17 RID: 121367 RVA: 0x00428B70 File Offset: 0x00426D70
		public IPerformanceModeSettingT UnPack()
		{
			IPerformanceModeSettingT performanceModeSettingT = new IPerformanceModeSettingT();
			this.UnPackTo(performanceModeSettingT);
			return performanceModeSettingT;
		}

		// Token: 0x0601DA18 RID: 121368 RVA: 0x00428B8B File Offset: 0x00426D8B
		public void UnPackTo(IPerformanceModeSettingT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601DA19 RID: 121369 RVA: 0x00428B9C File Offset: 0x00426D9C
		public static Offset<IPerformanceModeSetting> Pack(FlatBufferBuilder builder, IPerformanceModeSettingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformanceModeSetting>);
			}
			return IPerformanceModeSetting.CreateIPerformanceModeSetting(builder, _o.Type);
		}

		// Token: 0x0400D493 RID: 54419
		private Table __p;
	}
}
