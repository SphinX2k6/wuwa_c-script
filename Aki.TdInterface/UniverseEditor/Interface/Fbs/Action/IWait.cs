using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007E03 RID: 32259
	public struct IWait : IFlatbufferObject
	{
		// Token: 0x1700F1A2 RID: 61858
		// (get) Token: 0x0603A4BB RID: 238779 RVA: 0x007DAB13 File Offset: 0x007D8D13
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603A4BC RID: 238780 RVA: 0x007DAB20 File Offset: 0x007D8D20
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603A4BD RID: 238781 RVA: 0x007DAB28 File Offset: 0x007D8D28
		public static IWait GetRootAsIWait(ByteBuffer _bb)
		{
			return IWait.GetRootAsIWait(_bb, default(IWait));
		}

		// Token: 0x0603A4BE RID: 238782 RVA: 0x007DAB44 File Offset: 0x007D8D44
		public static IWait GetRootAsIWait(ByteBuffer _bb, IWait obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603A4BF RID: 238783 RVA: 0x007DAB61 File Offset: 0x007D8D61
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603A4C0 RID: 238784 RVA: 0x007DAB70 File Offset: 0x007D8D70
		public IWait __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700F1A3 RID: 61859
		// (get) Token: 0x0603A4C1 RID: 238785 RVA: 0x007DAB80 File Offset: 0x007D8D80
		public float Min
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F1A4 RID: 61860
		// (get) Token: 0x0603A4C2 RID: 238786 RVA: 0x007DABC0 File Offset: 0x007D8DC0
		public float Time
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700F1A5 RID: 61861
		// (get) Token: 0x0603A4C3 RID: 238787 RVA: 0x007DAC00 File Offset: 0x007D8E00
		public bool BanInput
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700F1A6 RID: 61862
		// (get) Token: 0x0603A4C4 RID: 238788 RVA: 0x007DAC40 File Offset: 0x007D8E40
		public IVarInterval? WaitInterval
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVarInterval?(default(IVarInterval).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700F1A7 RID: 61863
		// (get) Token: 0x0603A4C5 RID: 238789 RVA: 0x007DACA0 File Offset: 0x007D8EA0
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

		// Token: 0x0603A4C6 RID: 238790 RVA: 0x007DACDD File Offset: 0x007D8EDD
		public static Offset<IWait> CreateIWait(FlatBufferBuilder builder, float Min = 0f, float Time = 0f, bool BanInput = false, Offset<IVarInterval> WaitIntervalOffset = default(Offset<IVarInterval>), byte NullMask = 0)
		{
			builder.StartTable(5);
			IWait.AddWaitInterval(builder, WaitIntervalOffset);
			IWait.AddTime(builder, Time);
			IWait.AddMin(builder, Min);
			IWait.AddNullMask(builder, NullMask);
			IWait.AddBanInput(builder, BanInput);
			return IWait.EndIWait(builder);
		}

		// Token: 0x0603A4C7 RID: 238791 RVA: 0x007DAD11 File Offset: 0x007D8F11
		public static void StartIWait(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0603A4C8 RID: 238792 RVA: 0x007DAD1A File Offset: 0x007D8F1A
		public static void AddMin(FlatBufferBuilder builder, float min)
		{
			builder.AddFloat(0, min, 0.0);
		}

		// Token: 0x0603A4C9 RID: 238793 RVA: 0x007DAD2D File Offset: 0x007D8F2D
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(1, time, 0.0);
		}

		// Token: 0x0603A4CA RID: 238794 RVA: 0x007DAD40 File Offset: 0x007D8F40
		public static void AddBanInput(FlatBufferBuilder builder, bool banInput)
		{
			builder.AddBool(2, banInput, false);
		}

		// Token: 0x0603A4CB RID: 238795 RVA: 0x007DAD4B File Offset: 0x007D8F4B
		public static void AddWaitInterval(FlatBufferBuilder builder, Offset<IVarInterval> waitIntervalOffset)
		{
			builder.AddOffset(3, waitIntervalOffset.Value, 0);
		}

		// Token: 0x0603A4CC RID: 238796 RVA: 0x007DAD5B File Offset: 0x007D8F5B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0603A4CD RID: 238797 RVA: 0x007DAD66 File Offset: 0x007D8F66
		public static Offset<IWait> EndIWait(FlatBufferBuilder builder)
		{
			return new Offset<IWait>(builder.EndTable());
		}

		// Token: 0x0603A4CE RID: 238798 RVA: 0x007DAD74 File Offset: 0x007D8F74
		public IWaitT UnPack()
		{
			IWaitT waitT = new IWaitT();
			this.UnPackTo(waitT);
			return waitT;
		}

		// Token: 0x0603A4CF RID: 238799 RVA: 0x007DAD90 File Offset: 0x007D8F90
		public void UnPackTo(IWaitT _o)
		{
			_o.Min = this.Min;
			_o.Time = this.Time;
			_o.BanInput = this.BanInput;
			_o.WaitInterval = ((this.WaitInterval != null) ? this.WaitInterval.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603A4D0 RID: 238800 RVA: 0x007DADFC File Offset: 0x007D8FFC
		public static Offset<IWait> Pack(FlatBufferBuilder builder, IWaitT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWait>);
			}
			Offset<IVarInterval> waitIntervalOffset = (_o.WaitInterval == null) ? default(Offset<IVarInterval>) : IVarInterval.Pack(builder, _o.WaitInterval);
			return IWait.CreateIWait(builder, _o.Min, _o.Time, _o.BanInput, waitIntervalOffset, _o.NullMask);
		}

		// Token: 0x040135B0 RID: 79280
		private Table __p;
	}
}
