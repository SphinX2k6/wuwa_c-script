using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055BD RID: 21949
	public struct IMotorHookPerformanceConfig : IFlatbufferObject
	{
		// Token: 0x1700A238 RID: 41528
		// (get) Token: 0x060245C7 RID: 148935 RVA: 0x005050A8 File Offset: 0x005032A8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060245C8 RID: 148936 RVA: 0x005050B5 File Offset: 0x005032B5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060245C9 RID: 148937 RVA: 0x005050BC File Offset: 0x005032BC
		public static IMotorHookPerformanceConfig GetRootAsIMotorHookPerformanceConfig(ByteBuffer _bb)
		{
			return IMotorHookPerformanceConfig.GetRootAsIMotorHookPerformanceConfig(_bb, default(IMotorHookPerformanceConfig));
		}

		// Token: 0x060245CA RID: 148938 RVA: 0x005050D8 File Offset: 0x005032D8
		public static IMotorHookPerformanceConfig GetRootAsIMotorHookPerformanceConfig(ByteBuffer _bb, IMotorHookPerformanceConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060245CB RID: 148939 RVA: 0x005050F5 File Offset: 0x005032F5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060245CC RID: 148940 RVA: 0x00505104 File Offset: 0x00503304
		public IMotorHookPerformanceConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A239 RID: 41529
		// (get) Token: 0x060245CD RID: 148941 RVA: 0x00505114 File Offset: 0x00503314
		public long HookEffectBuffId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0L;
				}
				return this.__p.bb.GetLong(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A23A RID: 41530
		// (get) Token: 0x060245CE RID: 148942 RVA: 0x00505154 File Offset: 0x00503354
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060245CF RID: 148943 RVA: 0x00505190 File Offset: 0x00503390
		public static Offset<IMotorHookPerformanceConfig> CreateIMotorHookPerformanceConfig(FlatBufferBuilder builder, long HookEffectBuffId = 0L, byte NullMask = 0)
		{
			builder.StartTable(2);
			IMotorHookPerformanceConfig.AddHookEffectBuffId(builder, HookEffectBuffId);
			IMotorHookPerformanceConfig.AddNullMask(builder, NullMask);
			return IMotorHookPerformanceConfig.EndIMotorHookPerformanceConfig(builder);
		}

		// Token: 0x060245D0 RID: 148944 RVA: 0x005051AD File Offset: 0x005033AD
		public static void StartIMotorHookPerformanceConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060245D1 RID: 148945 RVA: 0x005051B6 File Offset: 0x005033B6
		public static void AddHookEffectBuffId(FlatBufferBuilder builder, long hookEffectBuffId)
		{
			builder.AddLong(0, hookEffectBuffId, 0L);
		}

		// Token: 0x060245D2 RID: 148946 RVA: 0x005051C2 File Offset: 0x005033C2
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(1, nullMask, 0);
		}

		// Token: 0x060245D3 RID: 148947 RVA: 0x005051CD File Offset: 0x005033CD
		public static Offset<IMotorHookPerformanceConfig> EndIMotorHookPerformanceConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMotorHookPerformanceConfig>(builder.EndTable());
		}

		// Token: 0x060245D4 RID: 148948 RVA: 0x005051DC File Offset: 0x005033DC
		public IMotorHookPerformanceConfigT UnPack()
		{
			IMotorHookPerformanceConfigT motorHookPerformanceConfigT = new IMotorHookPerformanceConfigT();
			this.UnPackTo(motorHookPerformanceConfigT);
			return motorHookPerformanceConfigT;
		}

		// Token: 0x060245D5 RID: 148949 RVA: 0x005051F7 File Offset: 0x005033F7
		public void UnPackTo(IMotorHookPerformanceConfigT _o)
		{
			_o.HookEffectBuffId = this.HookEffectBuffId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060245D6 RID: 148950 RVA: 0x00505214 File Offset: 0x00503414
		public static Offset<IMotorHookPerformanceConfig> Pack(FlatBufferBuilder builder, IMotorHookPerformanceConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMotorHookPerformanceConfig>);
			}
			return IMotorHookPerformanceConfig.CreateIMotorHookPerformanceConfig(builder, _o.HookEffectBuffId, _o.NullMask);
		}

		// Token: 0x0400E904 RID: 59652
		private Table __p;
	}
}
