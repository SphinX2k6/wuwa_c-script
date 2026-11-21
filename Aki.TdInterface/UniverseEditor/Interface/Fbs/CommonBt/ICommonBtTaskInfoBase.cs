using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02006515 RID: 25877
	public struct ICommonBtTaskInfoBase : IFlatbufferObject
	{
		// Token: 0x1700BF01 RID: 48897
		// (get) Token: 0x0602C1CE RID: 180686 RVA: 0x00602680 File Offset: 0x00600880
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C1CF RID: 180687 RVA: 0x0060268D File Offset: 0x0060088D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C1D0 RID: 180688 RVA: 0x00602694 File Offset: 0x00600894
		public static ICommonBtTaskInfoBase GetRootAsICommonBtTaskInfoBase(ByteBuffer _bb)
		{
			return ICommonBtTaskInfoBase.GetRootAsICommonBtTaskInfoBase(_bb, default(ICommonBtTaskInfoBase));
		}

		// Token: 0x0602C1D1 RID: 180689 RVA: 0x006026B0 File Offset: 0x006008B0
		public static ICommonBtTaskInfoBase GetRootAsICommonBtTaskInfoBase(ByteBuffer _bb, ICommonBtTaskInfoBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C1D2 RID: 180690 RVA: 0x006026CD File Offset: 0x006008CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C1D3 RID: 180691 RVA: 0x006026DC File Offset: 0x006008DC
		public ICommonBtTaskInfoBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BF02 RID: 48898
		// (get) Token: 0x0602C1D4 RID: 180692 RVA: 0x006026EC File Offset: 0x006008EC
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

		// Token: 0x0602C1D5 RID: 180693 RVA: 0x00602728 File Offset: 0x00600928
		public static Offset<ICommonBtTaskInfoBase> CreateICommonBtTaskInfoBase(FlatBufferBuilder builder, int TaskId = 0)
		{
			builder.StartTable(1);
			ICommonBtTaskInfoBase.AddTaskId(builder, TaskId);
			return ICommonBtTaskInfoBase.EndICommonBtTaskInfoBase(builder);
		}

		// Token: 0x0602C1D6 RID: 180694 RVA: 0x0060273E File Offset: 0x0060093E
		public static void StartICommonBtTaskInfoBase(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602C1D7 RID: 180695 RVA: 0x00602747 File Offset: 0x00600947
		public static void AddTaskId(FlatBufferBuilder builder, int taskId)
		{
			builder.AddInt(0, taskId, 0);
		}

		// Token: 0x0602C1D8 RID: 180696 RVA: 0x00602752 File Offset: 0x00600952
		public static Offset<ICommonBtTaskInfoBase> EndICommonBtTaskInfoBase(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtTaskInfoBase>(builder.EndTable());
		}

		// Token: 0x0602C1D9 RID: 180697 RVA: 0x00602760 File Offset: 0x00600960
		public ICommonBtTaskInfoBaseT UnPack()
		{
			ICommonBtTaskInfoBaseT commonBtTaskInfoBaseT = new ICommonBtTaskInfoBaseT();
			this.UnPackTo(commonBtTaskInfoBaseT);
			return commonBtTaskInfoBaseT;
		}

		// Token: 0x0602C1DA RID: 180698 RVA: 0x0060277B File Offset: 0x0060097B
		public void UnPackTo(ICommonBtTaskInfoBaseT _o)
		{
			_o.TaskId = this.TaskId;
		}

		// Token: 0x0602C1DB RID: 180699 RVA: 0x0060278C File Offset: 0x0060098C
		public static Offset<ICommonBtTaskInfoBase> Pack(FlatBufferBuilder builder, ICommonBtTaskInfoBaseT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtTaskInfoBase>);
			}
			return ICommonBtTaskInfoBase.CreateICommonBtTaskInfoBase(builder, _o.TaskId);
		}

		// Token: 0x040106D0 RID: 67280
		private Table __p;
	}
}
