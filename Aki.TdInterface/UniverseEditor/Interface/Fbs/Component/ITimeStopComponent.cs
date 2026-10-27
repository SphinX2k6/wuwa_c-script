using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AB7 RID: 23223
	public struct ITimeStopComponent : IFlatbufferObject
	{
		// Token: 0x1700AEE0 RID: 44768
		// (get) Token: 0x06027906 RID: 162054 RVA: 0x005711F2 File Offset: 0x0056F3F2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027907 RID: 162055 RVA: 0x005711FF File Offset: 0x0056F3FF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027908 RID: 162056 RVA: 0x00571208 File Offset: 0x0056F408
		public static ITimeStopComponent GetRootAsITimeStopComponent(ByteBuffer _bb)
		{
			return ITimeStopComponent.GetRootAsITimeStopComponent(_bb, default(ITimeStopComponent));
		}

		// Token: 0x06027909 RID: 162057 RVA: 0x00571224 File Offset: 0x0056F424
		public static ITimeStopComponent GetRootAsITimeStopComponent(ByteBuffer _bb, ITimeStopComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602790A RID: 162058 RVA: 0x00571241 File Offset: 0x0056F441
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602790B RID: 162059 RVA: 0x00571250 File Offset: 0x0056F450
		public ITimeStopComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEE1 RID: 44769
		// (get) Token: 0x0602790C RID: 162060 RVA: 0x00571260 File Offset: 0x0056F460
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AEE2 RID: 44770
		// (get) Token: 0x0602790D RID: 162061 RVA: 0x005712A0 File Offset: 0x0056F4A0
		public string ActiveState
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602790E RID: 162062 RVA: 0x005712D7 File Offset: 0x0056F4D7
		public Span<byte> GetActiveStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602790F RID: 162063 RVA: 0x005712E6 File Offset: 0x0056F4E6
		public byte[] GetActiveStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700AEE3 RID: 44771
		// (get) Token: 0x06027910 RID: 162064 RVA: 0x005712F4 File Offset: 0x0056F4F4
		public int StopTime
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

		// Token: 0x1700AEE4 RID: 44772
		// (get) Token: 0x06027911 RID: 162065 RVA: 0x00571330 File Offset: 0x0056F530
		public ITimeStopTarget? Target
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ITimeStopTarget?(default(ITimeStopTarget).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AEE5 RID: 44773
		// (get) Token: 0x06027912 RID: 162066 RVA: 0x00571390 File Offset: 0x0056F590
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

		// Token: 0x06027913 RID: 162067 RVA: 0x005713CD File Offset: 0x0056F5CD
		public static Offset<ITimeStopComponent> CreateITimeStopComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset ActiveStateOffset = default(StringOffset), int StopTime = 0, Offset<ITimeStopTarget> TargetOffset = default(Offset<ITimeStopTarget>), byte NullMask = 0)
		{
			builder.StartTable(5);
			ITimeStopComponent.AddTarget(builder, TargetOffset);
			ITimeStopComponent.AddStopTime(builder, StopTime);
			ITimeStopComponent.AddActiveState(builder, ActiveStateOffset);
			ITimeStopComponent.AddNullMask(builder, NullMask);
			ITimeStopComponent.AddDisabled(builder, Disabled);
			return ITimeStopComponent.EndITimeStopComponent(builder);
		}

		// Token: 0x06027914 RID: 162068 RVA: 0x00571401 File Offset: 0x0056F601
		public static void StartITimeStopComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06027915 RID: 162069 RVA: 0x0057140A File Offset: 0x0056F60A
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06027916 RID: 162070 RVA: 0x00571415 File Offset: 0x0056F615
		public static void AddActiveState(FlatBufferBuilder builder, StringOffset activeStateOffset)
		{
			builder.AddOffset(1, activeStateOffset.Value, 0);
		}

		// Token: 0x06027917 RID: 162071 RVA: 0x00571425 File Offset: 0x0056F625
		public static void AddStopTime(FlatBufferBuilder builder, int stopTime)
		{
			builder.AddInt(2, stopTime, 0);
		}

		// Token: 0x06027918 RID: 162072 RVA: 0x00571430 File Offset: 0x0056F630
		public static void AddTarget(FlatBufferBuilder builder, Offset<ITimeStopTarget> targetOffset)
		{
			builder.AddOffset(3, targetOffset.Value, 0);
		}

		// Token: 0x06027919 RID: 162073 RVA: 0x00571440 File Offset: 0x0056F640
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602791A RID: 162074 RVA: 0x0057144B File Offset: 0x0056F64B
		public static Offset<ITimeStopComponent> EndITimeStopComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITimeStopComponent>(builder.EndTable());
		}

		// Token: 0x0602791B RID: 162075 RVA: 0x00571458 File Offset: 0x0056F658
		public ITimeStopComponentT UnPack()
		{
			ITimeStopComponentT timeStopComponentT = new ITimeStopComponentT();
			this.UnPackTo(timeStopComponentT);
			return timeStopComponentT;
		}

		// Token: 0x0602791C RID: 162076 RVA: 0x00571474 File Offset: 0x0056F674
		public void UnPackTo(ITimeStopComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ActiveState = this.ActiveState;
			_o.StopTime = this.StopTime;
			_o.Target = ((this.Target != null) ? this.Target.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602791D RID: 162077 RVA: 0x005714E0 File Offset: 0x0056F6E0
		public static Offset<ITimeStopComponent> Pack(FlatBufferBuilder builder, ITimeStopComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeStopComponent>);
			}
			StringOffset activeStateOffset = (_o.ActiveState == null) ? default(StringOffset) : builder.CreateString(_o.ActiveState);
			Offset<ITimeStopTarget> targetOffset = (_o.Target == null) ? default(Offset<ITimeStopTarget>) : ITimeStopTarget.Pack(builder, _o.Target);
			return ITimeStopComponent.CreateITimeStopComponent(builder, _o.Disabled, activeStateOffset, _o.StopTime, targetOffset, _o.NullMask);
		}

		// Token: 0x0400F17D RID: 61821
		private Table __p;
	}
}
