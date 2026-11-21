using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060C4 RID: 24772
	public struct ITimeStopComponent : IFlatbufferObject
	{
		// Token: 0x1700B81C RID: 47132
		// (get) Token: 0x06029E8C RID: 171660 RVA: 0x005B84DA File Offset: 0x005B66DA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029E8D RID: 171661 RVA: 0x005B84E7 File Offset: 0x005B66E7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029E8E RID: 171662 RVA: 0x005B84F0 File Offset: 0x005B66F0
		public static ITimeStopComponent GetRootAsITimeStopComponent(ByteBuffer _bb)
		{
			return ITimeStopComponent.GetRootAsITimeStopComponent(_bb, default(ITimeStopComponent));
		}

		// Token: 0x06029E8F RID: 171663 RVA: 0x005B850C File Offset: 0x005B670C
		public static ITimeStopComponent GetRootAsITimeStopComponent(ByteBuffer _bb, ITimeStopComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029E90 RID: 171664 RVA: 0x005B8529 File Offset: 0x005B6729
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029E91 RID: 171665 RVA: 0x005B8538 File Offset: 0x005B6738
		public ITimeStopComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B81D RID: 47133
		// (get) Token: 0x06029E92 RID: 171666 RVA: 0x005B8548 File Offset: 0x005B6748
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700B81E RID: 47134
		// (get) Token: 0x06029E93 RID: 171667 RVA: 0x005B8588 File Offset: 0x005B6788
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

		// Token: 0x06029E94 RID: 171668 RVA: 0x005B85BF File Offset: 0x005B67BF
		public Span<byte> GetActiveStateBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06029E95 RID: 171669 RVA: 0x005B85CE File Offset: 0x005B67CE
		public byte[] GetActiveStateArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700B81F RID: 47135
		// (get) Token: 0x06029E96 RID: 171670 RVA: 0x005B85DC File Offset: 0x005B67DC
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

		// Token: 0x1700B820 RID: 47136
		// (get) Token: 0x06029E97 RID: 171671 RVA: 0x005B8618 File Offset: 0x005B6818
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

		// Token: 0x1700B821 RID: 47137
		// (get) Token: 0x06029E98 RID: 171672 RVA: 0x005B8678 File Offset: 0x005B6878
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

		// Token: 0x06029E99 RID: 171673 RVA: 0x005B86B5 File Offset: 0x005B68B5
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

		// Token: 0x06029E9A RID: 171674 RVA: 0x005B86E9 File Offset: 0x005B68E9
		public static void StartITimeStopComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06029E9B RID: 171675 RVA: 0x005B86F2 File Offset: 0x005B68F2
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06029E9C RID: 171676 RVA: 0x005B86FD File Offset: 0x005B68FD
		public static void AddActiveState(FlatBufferBuilder builder, StringOffset activeStateOffset)
		{
			builder.AddOffset(1, activeStateOffset.Value, 0);
		}

		// Token: 0x06029E9D RID: 171677 RVA: 0x005B870D File Offset: 0x005B690D
		public static void AddStopTime(FlatBufferBuilder builder, int stopTime)
		{
			builder.AddInt(2, stopTime, 0);
		}

		// Token: 0x06029E9E RID: 171678 RVA: 0x005B8718 File Offset: 0x005B6918
		public static void AddTarget(FlatBufferBuilder builder, Offset<ITimeStopTarget> targetOffset)
		{
			builder.AddOffset(3, targetOffset.Value, 0);
		}

		// Token: 0x06029E9F RID: 171679 RVA: 0x005B8728 File Offset: 0x005B6928
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x06029EA0 RID: 171680 RVA: 0x005B8733 File Offset: 0x005B6933
		public static Offset<ITimeStopComponent> EndITimeStopComponent(FlatBufferBuilder builder)
		{
			return new Offset<ITimeStopComponent>(builder.EndTable());
		}

		// Token: 0x06029EA1 RID: 171681 RVA: 0x005B8740 File Offset: 0x005B6940
		public ITimeStopComponentT UnPack()
		{
			ITimeStopComponentT timeStopComponentT = new ITimeStopComponentT();
			this.UnPackTo(timeStopComponentT);
			return timeStopComponentT;
		}

		// Token: 0x06029EA2 RID: 171682 RVA: 0x005B875C File Offset: 0x005B695C
		public void UnPackTo(ITimeStopComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.ActiveState = this.ActiveState;
			_o.StopTime = this.StopTime;
			_o.Target = ((this.Target != null) ? this.Target.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06029EA3 RID: 171683 RVA: 0x005B87C8 File Offset: 0x005B69C8
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

		// Token: 0x0400FE76 RID: 65142
		private Table __p;
	}
}
