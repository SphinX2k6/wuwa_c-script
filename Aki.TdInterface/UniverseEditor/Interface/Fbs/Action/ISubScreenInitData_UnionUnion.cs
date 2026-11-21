using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079E1 RID: 31201
	public class ISubScreenInitData_UnionUnion
	{
		// Token: 0x1700E4BD RID: 58557
		// (get) Token: 0x06036F90 RID: 225168 RVA: 0x00759729 File Offset: 0x00757929
		// (set) Token: 0x06036F91 RID: 225169 RVA: 0x00759731 File Offset: 0x00757931
		public ISubScreenInitData_Union Type { get; set; }

		// Token: 0x1700E4BE RID: 58558
		// (get) Token: 0x06036F92 RID: 225170 RVA: 0x0075973A File Offset: 0x0075793A
		// (set) Token: 0x06036F93 RID: 225171 RVA: 0x00759742 File Offset: 0x00757942
		public object Value { get; set; }

		// Token: 0x06036F94 RID: 225172 RVA: 0x0075974B File Offset: 0x0075794B
		public ISubScreenInitData_UnionUnion()
		{
			this.Type = ISubScreenInitData_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036F95 RID: 225173 RVA: 0x00759761 File Offset: 0x00757961
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036F96 RID: 225174 RVA: 0x00759773 File Offset: 0x00757973
		public ISubScreenInitDataT AsISubScreenInitData()
		{
			return this.As<ISubScreenInitDataT>();
		}

		// Token: 0x06036F97 RID: 225175 RVA: 0x0075977B File Offset: 0x0075797B
		public static ISubScreenInitData_UnionUnion FromISubScreenInitData(ISubScreenInitDataT _isubscreeninitdata)
		{
			return new ISubScreenInitData_UnionUnion
			{
				Type = ISubScreenInitData_Union.ISubScreenInitData,
				Value = _isubscreeninitdata
			};
		}

		// Token: 0x06036F98 RID: 225176 RVA: 0x00759790 File Offset: 0x00757990
		public ISubScreenPresetInitDataT AsISubScreenPresetInitData()
		{
			return this.As<ISubScreenPresetInitDataT>();
		}

		// Token: 0x06036F99 RID: 225177 RVA: 0x00759798 File Offset: 0x00757998
		public static ISubScreenInitData_UnionUnion FromISubScreenPresetInitData(ISubScreenPresetInitDataT _isubscreenpresetinitdata)
		{
			return new ISubScreenInitData_UnionUnion
			{
				Type = ISubScreenInitData_Union.ISubScreenPresetInitData,
				Value = _isubscreenpresetinitdata
			};
		}

		// Token: 0x06036F9A RID: 225178 RVA: 0x007597AD File Offset: 0x007579AD
		public ISubScreenCustomInitDataT AsISubScreenCustomInitData()
		{
			return this.As<ISubScreenCustomInitDataT>();
		}

		// Token: 0x06036F9B RID: 225179 RVA: 0x007597B5 File Offset: 0x007579B5
		public static ISubScreenInitData_UnionUnion FromISubScreenCustomInitData(ISubScreenCustomInitDataT _isubscreencustominitdata)
		{
			return new ISubScreenInitData_UnionUnion
			{
				Type = ISubScreenInitData_Union.ISubScreenCustomInitData,
				Value = _isubscreencustominitdata
			};
		}

		// Token: 0x06036F9C RID: 225180 RVA: 0x007597CC File Offset: 0x007579CC
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
