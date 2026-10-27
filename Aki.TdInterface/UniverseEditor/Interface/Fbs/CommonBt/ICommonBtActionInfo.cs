using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.CommonBt
{
	// Token: 0x02005E9F RID: 24223
	public struct ICommonBtActionInfo : IFlatbufferObject
	{
		// Token: 0x1700B504 RID: 46340
		// (get) Token: 0x060297F0 RID: 169968 RVA: 0x005AF9AC File Offset: 0x005ADBAC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060297F1 RID: 169969 RVA: 0x005AF9B9 File Offset: 0x005ADBB9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060297F2 RID: 169970 RVA: 0x005AF9C0 File Offset: 0x005ADBC0
		public static ICommonBtActionInfo GetRootAsICommonBtActionInfo(ByteBuffer _bb)
		{
			return ICommonBtActionInfo.GetRootAsICommonBtActionInfo(_bb, default(ICommonBtActionInfo));
		}

		// Token: 0x060297F3 RID: 169971 RVA: 0x005AF9DC File Offset: 0x005ADBDC
		public static ICommonBtActionInfo GetRootAsICommonBtActionInfo(ByteBuffer _bb, ICommonBtActionInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060297F4 RID: 169972 RVA: 0x005AF9F9 File Offset: 0x005ADBF9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060297F5 RID: 169973 RVA: 0x005AFA08 File Offset: 0x005ADC08
		public ICommonBtActionInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B505 RID: 46341
		// (get) Token: 0x060297F6 RID: 169974 RVA: 0x005AFA18 File Offset: 0x005ADC18
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

		// Token: 0x1700B506 RID: 46342
		// (get) Token: 0x060297F7 RID: 169975 RVA: 0x005AFA54 File Offset: 0x005ADC54
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

		// Token: 0x060297F8 RID: 169976 RVA: 0x005AFAB1 File Offset: 0x005ADCB1
		public static Offset<ICommonBtActionInfo> CreateICommonBtActionInfo(FlatBufferBuilder builder, int TaskId = 0, Offset<IActionInfo> ActionOffset = default(Offset<IActionInfo>))
		{
			builder.StartTable(2);
			ICommonBtActionInfo.AddAction(builder, ActionOffset);
			ICommonBtActionInfo.AddTaskId(builder, TaskId);
			return ICommonBtActionInfo.EndICommonBtActionInfo(builder);
		}

		// Token: 0x060297F9 RID: 169977 RVA: 0x005AFACE File Offset: 0x005ADCCE
		public static void StartICommonBtActionInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060297FA RID: 169978 RVA: 0x005AFAD7 File Offset: 0x005ADCD7
		public static void AddTaskId(FlatBufferBuilder builder, int taskId)
		{
			builder.AddInt(0, taskId, 0);
		}

		// Token: 0x060297FB RID: 169979 RVA: 0x005AFAE2 File Offset: 0x005ADCE2
		public static void AddAction(FlatBufferBuilder builder, Offset<IActionInfo> actionOffset)
		{
			builder.AddOffset(1, actionOffset.Value, 0);
		}

		// Token: 0x060297FC RID: 169980 RVA: 0x005AFAF2 File Offset: 0x005ADCF2
		public static Offset<ICommonBtActionInfo> EndICommonBtActionInfo(FlatBufferBuilder builder)
		{
			return new Offset<ICommonBtActionInfo>(builder.EndTable());
		}

		// Token: 0x060297FD RID: 169981 RVA: 0x005AFB00 File Offset: 0x005ADD00
		public ICommonBtActionInfoT UnPack()
		{
			ICommonBtActionInfoT commonBtActionInfoT = new ICommonBtActionInfoT();
			this.UnPackTo(commonBtActionInfoT);
			return commonBtActionInfoT;
		}

		// Token: 0x060297FE RID: 169982 RVA: 0x005AFB1C File Offset: 0x005ADD1C
		public void UnPackTo(ICommonBtActionInfoT _o)
		{
			_o.TaskId = this.TaskId;
			_o.Action = ((this.Action != null) ? this.Action.Value.UnPack() : null);
		}

		// Token: 0x060297FF RID: 169983 RVA: 0x005AFB64 File Offset: 0x005ADD64
		public static Offset<ICommonBtActionInfo> Pack(FlatBufferBuilder builder, ICommonBtActionInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICommonBtActionInfo>);
			}
			Offset<IActionInfo> actionOffset = (_o.Action == null) ? default(Offset<IActionInfo>) : IActionInfo.Pack(builder, _o.Action);
			return ICommonBtActionInfo.CreateICommonBtActionInfo(builder, _o.TaskId, actionOffset);
		}

		// Token: 0x0400F90F RID: 63759
		private Table __p;
	}
}
