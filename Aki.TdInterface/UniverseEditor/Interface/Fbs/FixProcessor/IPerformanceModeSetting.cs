using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.FixProcessor
{
	// Token: 0x02004766 RID: 18278
	public struct IPerformanceModeSetting : IFlatbufferObject
	{
		// Token: 0x1700831E RID: 33566
		// (get) Token: 0x0601C237 RID: 115255 RVA: 0x003FC7F3 File Offset: 0x003FA9F3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C238 RID: 115256 RVA: 0x003FC800 File Offset: 0x003FAA00
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C239 RID: 115257 RVA: 0x003FC808 File Offset: 0x003FAA08
		public static IPerformanceModeSetting GetRootAsIPerformanceModeSetting(ByteBuffer _bb)
		{
			return IPerformanceModeSetting.GetRootAsIPerformanceModeSetting(_bb, default(IPerformanceModeSetting));
		}

		// Token: 0x0601C23A RID: 115258 RVA: 0x003FC824 File Offset: 0x003FAA24
		public static IPerformanceModeSetting GetRootAsIPerformanceModeSetting(ByteBuffer _bb, IPerformanceModeSetting obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C23B RID: 115259 RVA: 0x003FC841 File Offset: 0x003FAA41
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C23C RID: 115260 RVA: 0x003FC850 File Offset: 0x003FAA50
		public IPerformanceModeSetting __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700831F RID: 33567
		// (get) Token: 0x0601C23D RID: 115261 RVA: 0x003FC860 File Offset: 0x003FAA60
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

		// Token: 0x0601C23E RID: 115262 RVA: 0x003FC89C File Offset: 0x003FAA9C
		public static Offset<IPerformanceModeSetting> CreateIPerformanceModeSetting(FlatBufferBuilder builder, EPerformanceMode Type = EPerformanceMode.High)
		{
			builder.StartTable(1);
			IPerformanceModeSetting.AddType(builder, Type);
			return IPerformanceModeSetting.EndIPerformanceModeSetting(builder);
		}

		// Token: 0x0601C23F RID: 115263 RVA: 0x003FC8B2 File Offset: 0x003FAAB2
		public static void StartIPerformanceModeSetting(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0601C240 RID: 115264 RVA: 0x003FC8BB File Offset: 0x003FAABB
		public static void AddType(FlatBufferBuilder builder, EPerformanceMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C241 RID: 115265 RVA: 0x003FC8C6 File Offset: 0x003FAAC6
		public static Offset<IPerformanceModeSetting> EndIPerformanceModeSetting(FlatBufferBuilder builder)
		{
			return new Offset<IPerformanceModeSetting>(builder.EndTable());
		}

		// Token: 0x0601C242 RID: 115266 RVA: 0x003FC8D4 File Offset: 0x003FAAD4
		public IPerformanceModeSettingT UnPack()
		{
			IPerformanceModeSettingT performanceModeSettingT = new IPerformanceModeSettingT();
			this.UnPackTo(performanceModeSettingT);
			return performanceModeSettingT;
		}

		// Token: 0x0601C243 RID: 115267 RVA: 0x003FC8EF File Offset: 0x003FAAEF
		public void UnPackTo(IPerformanceModeSettingT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0601C244 RID: 115268 RVA: 0x003FC900 File Offset: 0x003FAB00
		public static Offset<IPerformanceModeSetting> Pack(FlatBufferBuilder builder, IPerformanceModeSettingT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPerformanceModeSetting>);
			}
			return IPerformanceModeSetting.CreateIPerformanceModeSetting(builder, _o.Type);
		}

		// Token: 0x0400CA64 RID: 51812
		private Table __p;
	}
}
