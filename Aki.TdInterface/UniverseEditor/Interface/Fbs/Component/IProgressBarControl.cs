using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200579C RID: 22428
	public struct IProgressBarControl : IFlatbufferObject
	{
		// Token: 0x1700A750 RID: 42832
		// (get) Token: 0x060259CB RID: 154059 RVA: 0x0053012B File Offset: 0x0052E32B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060259CC RID: 154060 RVA: 0x00530138 File Offset: 0x0052E338
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060259CD RID: 154061 RVA: 0x00530140 File Offset: 0x0052E340
		public static IProgressBarControl GetRootAsIProgressBarControl(ByteBuffer _bb)
		{
			return IProgressBarControl.GetRootAsIProgressBarControl(_bb, default(IProgressBarControl));
		}

		// Token: 0x060259CE RID: 154062 RVA: 0x0053015C File Offset: 0x0052E35C
		public static IProgressBarControl GetRootAsIProgressBarControl(ByteBuffer _bb, IProgressBarControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060259CF RID: 154063 RVA: 0x00530179 File Offset: 0x0052E379
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060259D0 RID: 154064 RVA: 0x00530188 File Offset: 0x0052E388
		public IProgressBarControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A751 RID: 42833
		// (get) Token: 0x060259D1 RID: 154065 RVA: 0x00530198 File Offset: 0x0052E398
		public EProgressBarControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EProgressBarControlType.CaptureStrategicPoint;
				}
				return (EProgressBarControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A752 RID: 42834
		// (get) Token: 0x060259D2 RID: 154066 RVA: 0x005301D4 File Offset: 0x0052E3D4
		public int MaxValue
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A753 RID: 42835
		// (get) Token: 0x060259D3 RID: 154067 RVA: 0x00530210 File Offset: 0x0052E410
		public int InitValue
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A754 RID: 42836
		// (get) Token: 0x060259D4 RID: 154068 RVA: 0x0053024C File Offset: 0x0052E44C
		public int ProgressPerformanceAttribute
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A755 RID: 42837
		// (get) Token: 0x060259D5 RID: 154069 RVA: 0x0053028C File Offset: 0x0052E48C
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

		// Token: 0x060259D6 RID: 154070 RVA: 0x005302C9 File Offset: 0x0052E4C9
		public static Offset<IProgressBarControl> CreateIProgressBarControl(FlatBufferBuilder builder, EProgressBarControlType Type = EProgressBarControlType.CaptureStrategicPoint, int MaxValue = 0, int InitValue = 0, int ProgressPerformanceAttribute = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IProgressBarControl.AddProgressPerformanceAttribute(builder, ProgressPerformanceAttribute);
			IProgressBarControl.AddInitValue(builder, InitValue);
			IProgressBarControl.AddMaxValue(builder, MaxValue);
			IProgressBarControl.AddNullMask(builder, NullMask);
			IProgressBarControl.AddType(builder, Type);
			return IProgressBarControl.EndIProgressBarControl(builder);
		}

		// Token: 0x060259D7 RID: 154071 RVA: 0x005302FD File Offset: 0x0052E4FD
		public static void StartIProgressBarControl(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060259D8 RID: 154072 RVA: 0x00530306 File Offset: 0x0052E506
		public static void AddType(FlatBufferBuilder builder, EProgressBarControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060259D9 RID: 154073 RVA: 0x00530311 File Offset: 0x0052E511
		public static void AddMaxValue(FlatBufferBuilder builder, int maxValue)
		{
			builder.AddInt(1, maxValue, 0);
		}

		// Token: 0x060259DA RID: 154074 RVA: 0x0053031C File Offset: 0x0052E51C
		public static void AddInitValue(FlatBufferBuilder builder, int initValue)
		{
			builder.AddInt(2, initValue, 0);
		}

		// Token: 0x060259DB RID: 154075 RVA: 0x00530327 File Offset: 0x0052E527
		public static void AddProgressPerformanceAttribute(FlatBufferBuilder builder, int progressPerformanceAttribute)
		{
			builder.AddInt(3, progressPerformanceAttribute, 0);
		}

		// Token: 0x060259DC RID: 154076 RVA: 0x00530332 File Offset: 0x0052E532
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060259DD RID: 154077 RVA: 0x0053033D File Offset: 0x0052E53D
		public static Offset<IProgressBarControl> EndIProgressBarControl(FlatBufferBuilder builder)
		{
			return new Offset<IProgressBarControl>(builder.EndTable());
		}

		// Token: 0x060259DE RID: 154078 RVA: 0x0053034C File Offset: 0x0052E54C
		public IProgressBarControlT UnPack()
		{
			IProgressBarControlT progressBarControlT = new IProgressBarControlT();
			this.UnPackTo(progressBarControlT);
			return progressBarControlT;
		}

		// Token: 0x060259DF RID: 154079 RVA: 0x00530367 File Offset: 0x0052E567
		public void UnPackTo(IProgressBarControlT _o)
		{
			_o.Type = this.Type;
			_o.MaxValue = this.MaxValue;
			_o.InitValue = this.InitValue;
			_o.ProgressPerformanceAttribute = this.ProgressPerformanceAttribute;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060259E0 RID: 154080 RVA: 0x005303A8 File Offset: 0x0052E5A8
		public static Offset<IProgressBarControl> Pack(FlatBufferBuilder builder, IProgressBarControlT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProgressBarControl>);
			}
			return IProgressBarControl.CreateIProgressBarControl(builder, _o.Type, _o.MaxValue, _o.InitValue, _o.ProgressPerformanceAttribute, _o.NullMask);
		}

		// Token: 0x0400EC59 RID: 60505
		private Table __p;
	}
}
