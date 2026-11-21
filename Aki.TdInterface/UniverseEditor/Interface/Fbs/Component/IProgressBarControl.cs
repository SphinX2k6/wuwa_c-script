using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DA3 RID: 23971
	public struct IProgressBarControl : IFlatbufferObject
	{
		// Token: 0x1700B074 RID: 45172
		// (get) Token: 0x06027EEB RID: 163563 RVA: 0x005762B7 File Offset: 0x005744B7
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027EEC RID: 163564 RVA: 0x005762C4 File Offset: 0x005744C4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027EED RID: 163565 RVA: 0x005762CC File Offset: 0x005744CC
		public static IProgressBarControl GetRootAsIProgressBarControl(ByteBuffer _bb)
		{
			return IProgressBarControl.GetRootAsIProgressBarControl(_bb, default(IProgressBarControl));
		}

		// Token: 0x06027EEE RID: 163566 RVA: 0x005762E8 File Offset: 0x005744E8
		public static IProgressBarControl GetRootAsIProgressBarControl(ByteBuffer _bb, IProgressBarControl obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027EEF RID: 163567 RVA: 0x00576305 File Offset: 0x00574505
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027EF0 RID: 163568 RVA: 0x00576314 File Offset: 0x00574514
		public IProgressBarControl __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B075 RID: 45173
		// (get) Token: 0x06027EF1 RID: 163569 RVA: 0x00576324 File Offset: 0x00574524
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

		// Token: 0x1700B076 RID: 45174
		// (get) Token: 0x06027EF2 RID: 163570 RVA: 0x00576360 File Offset: 0x00574560
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

		// Token: 0x1700B077 RID: 45175
		// (get) Token: 0x06027EF3 RID: 163571 RVA: 0x0057639C File Offset: 0x0057459C
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

		// Token: 0x1700B078 RID: 45176
		// (get) Token: 0x06027EF4 RID: 163572 RVA: 0x005763D8 File Offset: 0x005745D8
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

		// Token: 0x1700B079 RID: 45177
		// (get) Token: 0x06027EF5 RID: 163573 RVA: 0x00576418 File Offset: 0x00574618
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

		// Token: 0x06027EF6 RID: 163574 RVA: 0x00576455 File Offset: 0x00574655
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

		// Token: 0x06027EF7 RID: 163575 RVA: 0x00576489 File Offset: 0x00574689
		public static void StartIProgressBarControl(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06027EF8 RID: 163576 RVA: 0x00576492 File Offset: 0x00574692
		public static void AddType(FlatBufferBuilder builder, EProgressBarControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027EF9 RID: 163577 RVA: 0x0057649D File Offset: 0x0057469D
		public static void AddMaxValue(FlatBufferBuilder builder, int maxValue)
		{
			builder.AddInt(1, maxValue, 0);
		}

		// Token: 0x06027EFA RID: 163578 RVA: 0x005764A8 File Offset: 0x005746A8
		public static void AddInitValue(FlatBufferBuilder builder, int initValue)
		{
			builder.AddInt(2, initValue, 0);
		}

		// Token: 0x06027EFB RID: 163579 RVA: 0x005764B3 File Offset: 0x005746B3
		public static void AddProgressPerformanceAttribute(FlatBufferBuilder builder, int progressPerformanceAttribute)
		{
			builder.AddInt(3, progressPerformanceAttribute, 0);
		}

		// Token: 0x06027EFC RID: 163580 RVA: 0x005764BE File Offset: 0x005746BE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06027EFD RID: 163581 RVA: 0x005764C9 File Offset: 0x005746C9
		public static Offset<IProgressBarControl> EndIProgressBarControl(FlatBufferBuilder builder)
		{
			return new Offset<IProgressBarControl>(builder.EndTable());
		}

		// Token: 0x06027EFE RID: 163582 RVA: 0x005764D8 File Offset: 0x005746D8
		public IProgressBarControlT UnPack()
		{
			IProgressBarControlT progressBarControlT = new IProgressBarControlT();
			this.UnPackTo(progressBarControlT);
			return progressBarControlT;
		}

		// Token: 0x06027EFF RID: 163583 RVA: 0x005764F3 File Offset: 0x005746F3
		public void UnPackTo(IProgressBarControlT _o)
		{
			_o.Type = this.Type;
			_o.MaxValue = this.MaxValue;
			_o.InitValue = this.InitValue;
			_o.ProgressPerformanceAttribute = this.ProgressPerformanceAttribute;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06027F00 RID: 163584 RVA: 0x00576534 File Offset: 0x00574734
		public static Offset<IProgressBarControl> Pack(FlatBufferBuilder builder, IProgressBarControlT _o)
		{
			if (_o == null)
			{
				return default(Offset<IProgressBarControl>);
			}
			return IProgressBarControl.CreateIProgressBarControl(builder, _o.Type, _o.MaxValue, _o.InitValue, _o.ProgressPerformanceAttribute, _o.NullMask);
		}

		// Token: 0x0400F944 RID: 63812
		private Table __p;
	}
}
