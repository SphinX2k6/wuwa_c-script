using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007FE6 RID: 32742
	public class TSubScreenInitDataUnion
	{
		// Token: 0x1700F311 RID: 62225
		// (get) Token: 0x0603AF0F RID: 241423 RVA: 0x007EAB5A File Offset: 0x007E8D5A
		// (set) Token: 0x0603AF10 RID: 241424 RVA: 0x007EAB62 File Offset: 0x007E8D62
		public TSubScreenInitData Type { get; set; }

		// Token: 0x1700F312 RID: 62226
		// (get) Token: 0x0603AF11 RID: 241425 RVA: 0x007EAB6B File Offset: 0x007E8D6B
		// (set) Token: 0x0603AF12 RID: 241426 RVA: 0x007EAB73 File Offset: 0x007E8D73
		public object Value { get; set; }

		// Token: 0x0603AF13 RID: 241427 RVA: 0x007EAB7C File Offset: 0x007E8D7C
		public TSubScreenInitDataUnion()
		{
			this.Type = TSubScreenInitData.NONE;
			this.Value = null;
		}

		// Token: 0x0603AF14 RID: 241428 RVA: 0x007EAB92 File Offset: 0x007E8D92
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AF15 RID: 241429 RVA: 0x007EABA4 File Offset: 0x007E8DA4
		public ISubScreenCustomInitDataT AsISubScreenCustomInitData()
		{
			return this.As<ISubScreenCustomInitDataT>();
		}

		// Token: 0x0603AF16 RID: 241430 RVA: 0x007EABAC File Offset: 0x007E8DAC
		public static TSubScreenInitDataUnion FromISubScreenCustomInitData(ISubScreenCustomInitDataT _isubscreencustominitdata)
		{
			return new TSubScreenInitDataUnion
			{
				Type = TSubScreenInitData.ISubScreenCustomInitData,
				Value = _isubscreencustominitdata
			};
		}

		// Token: 0x0603AF17 RID: 241431 RVA: 0x007EABC1 File Offset: 0x007E8DC1
		public ISubScreenPresetInitDataT AsISubScreenPresetInitData()
		{
			return this.As<ISubScreenPresetInitDataT>();
		}

		// Token: 0x0603AF18 RID: 241432 RVA: 0x007EABC9 File Offset: 0x007E8DC9
		public static TSubScreenInitDataUnion FromISubScreenPresetInitData(ISubScreenPresetInitDataT _isubscreenpresetinitdata)
		{
			return new TSubScreenInitDataUnion
			{
				Type = TSubScreenInitData.ISubScreenPresetInitData,
				Value = _isubscreenpresetinitdata
			};
		}

		// Token: 0x0603AF19 RID: 241433 RVA: 0x007EABE0 File Offset: 0x007E8DE0
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
