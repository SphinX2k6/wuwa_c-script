using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075F5 RID: 30197
	public struct IWait : IFlatbufferObject
	{
		// Token: 0x1700E564 RID: 58724
		// (get) Token: 0x06037016 RID: 225302 RVA: 0x00776A17 File Offset: 0x00774C17
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037017 RID: 225303 RVA: 0x00776A24 File Offset: 0x00774C24
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037018 RID: 225304 RVA: 0x00776A2C File Offset: 0x00774C2C
		public static IWait GetRootAsIWait(ByteBuffer _bb)
		{
			return IWait.GetRootAsIWait(_bb, default(IWait));
		}

		// Token: 0x06037019 RID: 225305 RVA: 0x00776A48 File Offset: 0x00774C48
		public static IWait GetRootAsIWait(ByteBuffer _bb, IWait obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603701A RID: 225306 RVA: 0x00776A65 File Offset: 0x00774C65
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603701B RID: 225307 RVA: 0x00776A74 File Offset: 0x00774C74
		public IWait __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E565 RID: 58725
		// (get) Token: 0x0603701C RID: 225308 RVA: 0x00776A84 File Offset: 0x00774C84
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

		// Token: 0x1700E566 RID: 58726
		// (get) Token: 0x0603701D RID: 225309 RVA: 0x00776AC4 File Offset: 0x00774CC4
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

		// Token: 0x1700E567 RID: 58727
		// (get) Token: 0x0603701E RID: 225310 RVA: 0x00776B04 File Offset: 0x00774D04
		public bool BanInput
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E568 RID: 58728
		// (get) Token: 0x0603701F RID: 225311 RVA: 0x00776B44 File Offset: 0x00774D44
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

		// Token: 0x1700E569 RID: 58729
		// (get) Token: 0x06037020 RID: 225312 RVA: 0x00776BA4 File Offset: 0x00774DA4
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

		// Token: 0x06037021 RID: 225313 RVA: 0x00776BE1 File Offset: 0x00774DE1
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

		// Token: 0x06037022 RID: 225314 RVA: 0x00776C15 File Offset: 0x00774E15
		public static void StartIWait(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06037023 RID: 225315 RVA: 0x00776C1E File Offset: 0x00774E1E
		public static void AddMin(FlatBufferBuilder builder, float min)
		{
			builder.AddFloat(0, min, 0.0);
		}

		// Token: 0x06037024 RID: 225316 RVA: 0x00776C31 File Offset: 0x00774E31
		public static void AddTime(FlatBufferBuilder builder, float time)
		{
			builder.AddFloat(1, time, 0.0);
		}

		// Token: 0x06037025 RID: 225317 RVA: 0x00776C44 File Offset: 0x00774E44
		public static void AddBanInput(FlatBufferBuilder builder, bool banInput)
		{
			builder.AddBool(2, banInput, false);
		}

		// Token: 0x06037026 RID: 225318 RVA: 0x00776C4F File Offset: 0x00774E4F
		public static void AddWaitInterval(FlatBufferBuilder builder, Offset<IVarInterval> waitIntervalOffset)
		{
			builder.AddOffset(3, waitIntervalOffset.Value, 0);
		}

		// Token: 0x06037027 RID: 225319 RVA: 0x00776C5F File Offset: 0x00774E5F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06037028 RID: 225320 RVA: 0x00776C6A File Offset: 0x00774E6A
		public static Offset<IWait> EndIWait(FlatBufferBuilder builder)
		{
			return new Offset<IWait>(builder.EndTable());
		}

		// Token: 0x06037029 RID: 225321 RVA: 0x00776C78 File Offset: 0x00774E78
		public IWaitT UnPack()
		{
			IWaitT waitT = new IWaitT();
			this.UnPackTo(waitT);
			return waitT;
		}

		// Token: 0x0603702A RID: 225322 RVA: 0x00776C94 File Offset: 0x00774E94
		public void UnPackTo(IWaitT _o)
		{
			_o.Min = this.Min;
			_o.Time = this.Time;
			_o.BanInput = this.BanInput;
			_o.WaitInterval = ((this.WaitInterval != null) ? this.WaitInterval.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603702B RID: 225323 RVA: 0x00776D00 File Offset: 0x00774F00
		public static Offset<IWait> Pack(FlatBufferBuilder builder, IWaitT _o)
		{
			if (_o == null)
			{
				return default(Offset<IWait>);
			}
			Offset<IVarInterval> waitIntervalOffset = (_o.WaitInterval == null) ? default(Offset<IVarInterval>) : IVarInterval.Pack(builder, _o.WaitInterval);
			return IWait.CreateIWait(builder, _o.Min, _o.Time, _o.BanInput, waitIntervalOffset, _o.NullMask);
		}

		// Token: 0x04012566 RID: 75110
		private Table __p;
	}
}
