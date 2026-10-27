using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200755D RID: 30045
	public class IVisualNovelBackgroundBase_UnionUnion
	{
		// Token: 0x1700E3E9 RID: 58345
		// (get) Token: 0x06036A8C RID: 223884 RVA: 0x0076C789 File Offset: 0x0076A989
		// (set) Token: 0x06036A8D RID: 223885 RVA: 0x0076C791 File Offset: 0x0076A991
		public IVisualNovelBackgroundBase_Union Type { get; set; }

		// Token: 0x1700E3EA RID: 58346
		// (get) Token: 0x06036A8E RID: 223886 RVA: 0x0076C79A File Offset: 0x0076A99A
		// (set) Token: 0x06036A8F RID: 223887 RVA: 0x0076C7A2 File Offset: 0x0076A9A2
		public object Value { get; set; }

		// Token: 0x06036A90 RID: 223888 RVA: 0x0076C7AB File Offset: 0x0076A9AB
		public IVisualNovelBackgroundBase_UnionUnion()
		{
			this.Type = IVisualNovelBackgroundBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036A91 RID: 223889 RVA: 0x0076C7C1 File Offset: 0x0076A9C1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036A92 RID: 223890 RVA: 0x0076C7D3 File Offset: 0x0076A9D3
		public IVisualNovelBackgroundBaseT AsIVisualNovelBackgroundBase()
		{
			return this.As<IVisualNovelBackgroundBaseT>();
		}

		// Token: 0x06036A93 RID: 223891 RVA: 0x0076C7DB File Offset: 0x0076A9DB
		public static IVisualNovelBackgroundBase_UnionUnion FromIVisualNovelBackgroundBase(IVisualNovelBackgroundBaseT _ivisualnovelbackgroundbase)
		{
			return new IVisualNovelBackgroundBase_UnionUnion
			{
				Type = IVisualNovelBackgroundBase_Union.IVisualNovelBackgroundBase,
				Value = _ivisualnovelbackgroundbase
			};
		}

		// Token: 0x06036A94 RID: 223892 RVA: 0x0076C7F0 File Offset: 0x0076A9F0
		public IVisualNovelBackgroundLoadT AsIVisualNovelBackgroundLoad()
		{
			return this.As<IVisualNovelBackgroundLoadT>();
		}

		// Token: 0x06036A95 RID: 223893 RVA: 0x0076C7F8 File Offset: 0x0076A9F8
		public static IVisualNovelBackgroundBase_UnionUnion FromIVisualNovelBackgroundLoad(IVisualNovelBackgroundLoadT _ivisualnovelbackgroundload)
		{
			return new IVisualNovelBackgroundBase_UnionUnion
			{
				Type = IVisualNovelBackgroundBase_Union.IVisualNovelBackgroundLoad,
				Value = _ivisualnovelbackgroundload
			};
		}

		// Token: 0x06036A96 RID: 223894 RVA: 0x0076C80D File Offset: 0x0076AA0D
		public IVisualNovelBackgroundCleanT AsIVisualNovelBackgroundClean()
		{
			return this.As<IVisualNovelBackgroundCleanT>();
		}

		// Token: 0x06036A97 RID: 223895 RVA: 0x0076C815 File Offset: 0x0076AA15
		public static IVisualNovelBackgroundBase_UnionUnion FromIVisualNovelBackgroundClean(IVisualNovelBackgroundCleanT _ivisualnovelbackgroundclean)
		{
			return new IVisualNovelBackgroundBase_UnionUnion
			{
				Type = IVisualNovelBackgroundBase_Union.IVisualNovelBackgroundClean,
				Value = _ivisualnovelbackgroundclean
			};
		}

		// Token: 0x06036A98 RID: 223896 RVA: 0x0076C82C File Offset: 0x0076AA2C
		public static int Pack(FlatBufferBuilder builder, IVisualNovelBackgroundBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IVisualNovelBackgroundBase_Union.IVisualNovelBackgroundBase:
				return IVisualNovelBackgroundBase.Pack(builder, _o.AsIVisualNovelBackgroundBase()).Value;
			case IVisualNovelBackgroundBase_Union.IVisualNovelBackgroundLoad:
				return IVisualNovelBackgroundLoad.Pack(builder, _o.AsIVisualNovelBackgroundLoad()).Value;
			case IVisualNovelBackgroundBase_Union.IVisualNovelBackgroundClean:
				return IVisualNovelBackgroundClean.Pack(builder, _o.AsIVisualNovelBackgroundClean()).Value;
			default:
				return 0;
			}
		}
	}
}
