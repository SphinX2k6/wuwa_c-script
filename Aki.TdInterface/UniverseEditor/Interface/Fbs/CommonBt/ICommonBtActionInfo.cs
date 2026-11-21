using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x020064E2 RID: 25826
	public struct ICommonBtActionInfo : IFlatbufferObject
	{
		// Token: 0x1700BE6F RID: 48751
		// (get) Token: 0x0602BE98 RID: 179864 RVA: 0x005F8950 File Offset: 0x005F6B50
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BE99 RID: 179865 RVA: 0x005F895D File Offset: 0x005F6B5D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BE9A RID: 179866 RVA: 0x005F8964 File Offset: 0x005F6B64
		public static ICommonBtActionInfo GetRootAsICommonBtActionInfo(ByteBuffer _bb)
		{
			return ICommonBtActionInfo.GetRootAsICommonBtActionInfo(_bb, default(ICommonBtActionInfo));
		}

		// Token: 0x0602BE9B RID: 179867 RVA: 0x005F8980 File Offset: 0x005F6B80
		public static ICommonBtActionInfo GetRootAsICommonBtActionInfo(ByteBuffer _bb, ICommonBtActionInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602BE9C RID: 179868 RVA: 0x005F899D File Offset: 0x005F6B9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602BE9D RID: 179869 RVA: 0x005F89AC File Offset: 0x005F6BAC
		public ICommonBtActionInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE70 RID: 48752
		// (get) Token: 0x0602BE9E RID: 179870 RVA: 0x005F89BC File Offset: 0x005F6BBC
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

		// Token: 0x1700BE71 RID: 48753
		// (get) Token: 0x0602BE9F RID: 179871 RVA: 0x005F89F8 File Offset: 0x005F6BF8
		public IActionInfo? Action
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602BEA0 RID: 179872 RVA: 0x005F8A55 File Offset: 0x005F6C55
		public static Offset<ICommonBtActionInfo> CreateICommonBtActionInfo(FlatBufferBuilder builder, int TaskId = 0, Offset<IActionInfo> ActionOffset = default(Offset<IActionInfo>))
		{
			builder.StartTable(2);
			ICommonBtActionInfo.AddAction(builder, ActionOffset);
			ICommonBtActionInfo.AddTaskId(builder, TaskId);
			return ICommonBtActionInfo.EndICommonBtActionInfo(builder);
		}

		// Token: 0x0602BEA1 RID: 179873 RVA: 0x005F8A72 File Offset: 0x005F6C72
		public static void StartICommonBtActionInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602BEA2 RID: 179874 RVA: 0x005F8A7B File Offset: 0x005F6C7B
		public static void AddTaskId(FlatBufferBuilder builder, int taskId)
		{
			builder.AddInt(0, taskId, 0);
		}

		// Token: 0x0602BEA3 RID: 179875 RVA: 0x005F8A86 File Offset: 0x005F6C86
		public static void AddAction(FlatBufferBuilder builder, Offset<IActionInfo> actionOffset)
		{
			builder.AddOffset(1, actionOffset.Value, 0);
		}

		// Token: 0x0602BEA4 RID: 179876 RVA: 0x005F8A96 File Offset: 0x005F6C96
		public static Offset<ICommonBtActionInfo> EndICommonBtActionInfo(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtActionInfo>(builder.EndTable());
		}

		// Token: 0x0602BEA5 RID: 179877 RVA: 0x005F8AA4 File Offset: 0x005F6CA4
		public ICommonBtActionInfoT UnPack()
		{
			ICommonBtActionInfoT commonBtActionInfoT = new ICommonBtActionInfoT();
			this.UnPackTo(commonBtActionInfoT);
			return commonBtActionInfoT;
		}

		// Token: 0x0602BEA6 RID: 179878 RVA: 0x005F8AC0 File Offset: 0x005F6CC0
		public void UnPackTo(ICommonBtActionInfoT _o)
		{
			_o.TaskId = this.TaskId;
			_o.Action = ((this.Action != null) ? this.Action.Value.UnPack() : null);
		}

		// Token: 0x0602BEA7 RID: 179879 RVA: 0x005F8B08 File Offset: 0x005F6D08
		public static Offset<ICommonBtActionInfo> Pack(FlatBufferBuilder builder, ICommonBtActionInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtActionInfo>);
			}
			Offset<IActionInfo> actionOffset = (_o.Action == null) ? default(Offset<IActionInfo>) : IActionInfo.Pack(builder, _o.Action);
			return ICommonBtActionInfo.CreateICommonBtActionInfo(builder, _o.TaskId, actionOffset);
		}

		// Token: 0x04010672 RID: 67186
		private Table __p;
	}
}
