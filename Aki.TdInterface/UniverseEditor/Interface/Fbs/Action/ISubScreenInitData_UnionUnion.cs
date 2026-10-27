using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200720C RID: 29196
	public class ISubScreenInitData_UnionUnion
	{
		// Token: 0x1700D8C4 RID: 55492
		// (get) Token: 0x06033C8E RID: 212110 RVA: 0x006F83C9 File Offset: 0x006F65C9
		// (set) Token: 0x06033C8F RID: 212111 RVA: 0x006F83D1 File Offset: 0x006F65D1
		public ISubScreenInitData_Union Type { get; set; }

		// Token: 0x1700D8C5 RID: 55493
		// (get) Token: 0x06033C90 RID: 212112 RVA: 0x006F83DA File Offset: 0x006F65DA
		// (set) Token: 0x06033C91 RID: 212113 RVA: 0x006F83E2 File Offset: 0x006F65E2
		public object Value { get; set; }

		// Token: 0x06033C92 RID: 212114 RVA: 0x006F83EB File Offset: 0x006F65EB
		public ISubScreenInitData_UnionUnion()
		{
			this.Type = ISubScreenInitData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033C93 RID: 212115 RVA: 0x006F8401 File Offset: 0x006F6601
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033C94 RID: 212116 RVA: 0x006F8413 File Offset: 0x006F6613
		public ISubScreenInitDataT AsISubScreenInitData()
		{
			return this.As<ISubScreenInitDataT>();
		}

		// Token: 0x06033C95 RID: 212117 RVA: 0x006F841B File Offset: 0x006F661B
		public static ISubScreenInitData_UnionUnion FromISubScreenInitData(ISubScreenInitDataT _isubscreeninitdata)
		{
			return new ISubScreenInitData_UnionUnion
			{
				Type = ISubScreenInitData_Union.ISubScreenInitData,
				Value = _isubscreeninitdata
			};
		}

		// Token: 0x06033C96 RID: 212118 RVA: 0x006F8430 File Offset: 0x006F6630
		public ISubScreenPresetInitDataT AsISubScreenPresetInitData()
		{
			return this.As<ISubScreenPresetInitDataT>();
		}

		// Token: 0x06033C97 RID: 212119 RVA: 0x006F8438 File Offset: 0x006F6638
		public static ISubScreenInitData_UnionUnion FromISubScreenPresetInitData(ISubScreenPresetInitDataT _isubscreenpresetinitdata)
		{
			return new ISubScreenInitData_UnionUnion
			{
				Type = ISubScreenInitData_Union.ISubScreenPresetInitData,
				Value = _isubscreenpresetinitdata
			};
		}

		// Token: 0x06033C98 RID: 212120 RVA: 0x006F844D File Offset: 0x006F664D
		public ISubScreenCustomInitDataT AsISubScreenCustomInitData()
		{
			return this.As<ISubScreenCustomInitDataT>();
		}

		// Token: 0x06033C99 RID: 212121 RVA: 0x006F8455 File Offset: 0x006F6655
		public static ISubScreenInitData_UnionUnion FromISubScreenCustomInitData(ISubScreenCustomInitDataT _isubscreencustominitdata)
		{
			return new ISubScreenInitData_UnionUnion
			{
				Type = ISubScreenInitData_Union.ISubScreenCustomInitData,
				Value = _isubscreencustominitdata
			};
		}

		// Token: 0x06033C9A RID: 212122 RVA: 0x006F846C File Offset: 0x006F666C
		public static int Pack(FlatBufferBuilder builder, ISubScreenInitData_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ISubScreenInitData_Union.ISubScreenInitData:
				return ISubScreenInitData.Pack(builder, _o.AsISubScreenInitData()).Value;
			case ISubScreenInitData_Union.ISubScreenPresetInitData:
				return ISubScreenPresetInitData.Pack(builder, _o.AsISubScreenPresetInitData()).Value;
			case ISubScreenInitData_Union.ISubScreenCustomInitData:
				return ISubScreenCustomInitData.Pack(builder, _o.AsISubScreenCustomInitData()).Value;
			default:
				return 0;
			}
		}
	}
}
