using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077AE RID: 30638
	public class TSubScreenInitDataUnion
	{
		// Token: 0x1700E6B7 RID: 59063
		// (get) Token: 0x0603798E RID: 227726 RVA: 0x0078558A File Offset: 0x0078378A
		// (set) Token: 0x0603798F RID: 227727 RVA: 0x00785592 File Offset: 0x00783792
		public TSubScreenInitData Type { get; set; }

		// Token: 0x1700E6B8 RID: 59064
		// (get) Token: 0x06037990 RID: 227728 RVA: 0x0078559B File Offset: 0x0078379B
		// (set) Token: 0x06037991 RID: 227729 RVA: 0x007855A3 File Offset: 0x007837A3
		public object Value { get; set; }

		// Token: 0x06037992 RID: 227730 RVA: 0x007855AC File Offset: 0x007837AC
		public TSubScreenInitDataUnion()
		{
			this.Type = TSubScreenInitData.NONE;
			this.Value = null;
		}

		// Token: 0x06037993 RID: 227731 RVA: 0x007855C2 File Offset: 0x007837C2
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037994 RID: 227732 RVA: 0x007855D4 File Offset: 0x007837D4
		public ISubScreenCustomInitDataT AsISubScreenCustomInitData()
		{
			return this.As<ISubScreenCustomInitDataT>();
		}

		// Token: 0x06037995 RID: 227733 RVA: 0x007855DC File Offset: 0x007837DC
		public static TSubScreenInitDataUnion FromISubScreenCustomInitData(ISubScreenCustomInitDataT _isubscreencustominitdata)
		{
			return new TSubScreenInitDataUnion
			{
				Type = TSubScreenInitData.ISubScreenCustomInitData,
				Value = _isubscreencustominitdata
			};
		}

		// Token: 0x06037996 RID: 227734 RVA: 0x007855F1 File Offset: 0x007837F1
		public ISubScreenPresetInitDataT AsISubScreenPresetInitData()
		{
			return this.As<ISubScreenPresetInitDataT>();
		}

		// Token: 0x06037997 RID: 227735 RVA: 0x007855F9 File Offset: 0x007837F9
		public static TSubScreenInitDataUnion FromISubScreenPresetInitData(ISubScreenPresetInitDataT _isubscreenpresetinitdata)
		{
			return new TSubScreenInitDataUnion
			{
				Type = TSubScreenInitData.ISubScreenPresetInitData,
				Value = _isubscreenpresetinitdata
			};
		}

		// Token: 0x06037998 RID: 227736 RVA: 0x00785610 File Offset: 0x00783810
		public static int Pack(FlatBufferBuilder builder, TSubScreenInitDataUnion _o)
		{
			TSubScreenInitData type = _o.Type;
			if (type == TSubScreenInitData.ISubScreenCustomInitData)
			{
				return ISubScreenCustomInitData.Pack(builder, _o.AsISubScreenCustomInitData()).Value;
			}
			if (type != TSubScreenInitData.ISubScreenPresetInitData)
			{
				return 0;
			}
			return ISubScreenPresetInitData.Pack(builder, _o.AsISubScreenPresetInitData()).Value;
		}
	}
}
