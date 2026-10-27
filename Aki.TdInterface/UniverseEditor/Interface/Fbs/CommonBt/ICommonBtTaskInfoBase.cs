using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005ED2 RID: 24274
	public struct ICommonBtTaskInfoBase : IFlatbufferObject
	{
		// Token: 0x1700B596 RID: 46486
		// (get) Token: 0x06029B1A RID: 170778 RVA: 0x005B919C File Offset: 0x005B739C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029B1B RID: 170779 RVA: 0x005B91A9 File Offset: 0x005B73A9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029B1C RID: 170780 RVA: 0x005B91B0 File Offset: 0x005B73B0
		public static ICommonBtTaskInfoBase GetRootAsICommonBtTaskInfoBase(ByteBuffer _bb)
		{
			return ICommonBtTaskInfoBase.GetRootAsICommonBtTaskInfoBase(_bb, default(ICommonBtTaskInfoBase));
		}

		// Token: 0x06029B1D RID: 170781 RVA: 0x005B91CC File Offset: 0x005B73CC
		public static ICommonBtTaskInfoBase GetRootAsICommonBtTaskInfoBase(ByteBuffer _bb, ICommonBtTaskInfoBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029B1E RID: 170782 RVA: 0x005B91E9 File Offset: 0x005B73E9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029B1F RID: 170783 RVA: 0x005B91F8 File Offset: 0x005B73F8
		public ICommonBtTaskInfoBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B597 RID: 46487
		// (get) Token: 0x06029B20 RID: 170784 RVA: 0x005B9208 File Offset: 0x005B7408
		public int TaskId
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029B21 RID: 170785 RVA: 0x005B9244 File Offset: 0x005B7444
		public static Offset<ICommonBtTaskInfoBase> CreateICommonBtTaskInfoBase(FlatBufferBuilder builder, int TaskId = 0)
		{
			builder.StartTable(1);
			ICommonBtTaskInfoBase.AddTaskId(builder, TaskId);
			return ICommonBtTaskInfoBase.EndICommonBtTaskInfoBase(builder);
		}

		// Token: 0x06029B22 RID: 170786 RVA: 0x005B925A File Offset: 0x005B745A
		public static void StartICommonBtTaskInfoBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029B23 RID: 170787 RVA: 0x005B9263 File Offset: 0x005B7463
		public static void AddTaskId(FlatBufferBuilder builder, int taskId)
		{
			builder.AddInt(0, taskId, 0);
		}

		// Token: 0x06029B24 RID: 170788 RVA: 0x005B926E File Offset: 0x005B746E
		public static Offset<ICommonBtTaskInfoBase> EndICommonBtTaskInfoBase(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtTaskInfoBase>(builder.EndTable());
		}

		// Token: 0x06029B25 RID: 170789 RVA: 0x005B927C File Offset: 0x005B747C
		public ICommonBtTaskInfoBaseT UnPack()
		{
			ICommonBtTaskInfoBaseT commonBtTaskInfoBaseT = new ICommonBtTaskInfoBaseT();
			this.UnPackTo(commonBtTaskInfoBaseT);
			return commonBtTaskInfoBaseT;
		}

		// Token: 0x06029B26 RID: 170790 RVA: 0x005B9297 File Offset: 0x005B7497
		public void UnPackTo(ICommonBtTaskInfoBaseT _o)
		{
			_o.TaskId = this.TaskId;
		}

		// Token: 0x06029B27 RID: 170791 RVA: 0x005B92A8 File Offset: 0x005B74A8
		public static Offset<ICommonBtTaskInfoBase> Pack(FlatBufferBuilder builder, ICommonBtTaskInfoBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtTaskInfoBase>);
			}
			return ICommonBtTaskInfoBase.CreateICommonBtTaskInfoBase(builder, _o.TaskId);
		}

		// Token: 0x0400F96D RID: 63853
		private Table __p;
	}
}
