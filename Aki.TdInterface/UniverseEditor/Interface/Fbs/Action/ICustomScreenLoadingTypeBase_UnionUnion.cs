using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B76 RID: 27510
	public class ICustomScreenLoadingTypeBase_UnionUnion
	{
		// Token: 0x1700C9E5 RID: 51685
		// (get) Token: 0x0602F56B RID: 193899 RVA: 0x00675D1D File Offset: 0x00673F1D
		// (set) Token: 0x0602F56C RID: 193900 RVA: 0x00675D25 File Offset: 0x00673F25
		public ICustomScreenLoadingTypeBase_Union Type { get; set; }

		// Token: 0x1700C9E6 RID: 51686
		// (get) Token: 0x0602F56D RID: 193901 RVA: 0x00675D2E File Offset: 0x00673F2E
		// (set) Token: 0x0602F56E RID: 193902 RVA: 0x00675D36 File Offset: 0x00673F36
		public object Value { get; set; }

		// Token: 0x0602F56F RID: 193903 RVA: 0x00675D3F File Offset: 0x00673F3F
		public ICustomScreenLoadingTypeBase_UnionUnion()
		{
			this.Type = ICustomScreenLoadingTypeBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602F570 RID: 193904 RVA: 0x00675D55 File Offset: 0x00673F55
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602F571 RID: 193905 RVA: 0x00675D67 File Offset: 0x00673F67
		public ICustomScreenLoadingTypeBaseT AsICustomScreenLoadingTypeBase()
		{
			return this.As<ICustomScreenLoadingTypeBaseT>();
		}

		// Token: 0x0602F572 RID: 193906 RVA: 0x00675D6F File Offset: 0x00673F6F
		public static ICustomScreenLoadingTypeBase_UnionUnion FromICustomScreenLoadingTypeBase(ICustomScreenLoadingTypeBaseT _icustomscreenloadingtypebase)
		{
			return new ICustomScreenLoadingTypeBase_UnionUnion
			{
				Type = ICustomScreenLoadingTypeBase_Union.ICustomScreenLoadingTypeBase,
				Value = _icustomscreenloadingtypebase
			};
		}

		// Token: 0x0602F573 RID: 193907 RVA: 0x00675D84 File Offset: 0x00673F84
		public ICustomScreenLoadingCyberpunkT AsICustomScreenLoadingCyberpunk()
		{
			return this.As<ICustomScreenLoadingCyberpunkT>();
		}

		// Token: 0x0602F574 RID: 193908 RVA: 0x00675D8C File Offset: 0x00673F8C
		public static ICustomScreenLoadingTypeBase_UnionUnion FromICustomScreenLoadingCyberpunk(ICustomScreenLoadingCyberpunkT _icustomscreenloadingcyberpunk)
		{
			return new ICustomScreenLoadingTypeBase_UnionUnion
			{
				Type = ICustomScreenLoadingTypeBase_Union.ICustomScreenLoadingCyberpunk,
				Value = _icustomscreenloadingcyberpunk
			};
		}

		// Token: 0x0602F575 RID: 193909 RVA: 0x00675DA4 File Offset: 0x00673FA4
		public static int Pack(FlatBufferBuilder builder, ICustomScreenLoadingTypeBase_UnionUnion _o)
		{
			ICustomScreenLoadingTypeBase_Union type = _o.Type;
			if (type == ICustomScreenLoadingTypeBase_Union.ICustomScreenLoadingTypeBase)
			{
				return ICustomScreenLoadingTypeBase.Pack(builder, _o.AsICustomScreenLoadingTypeBase()).Value;
			}
			if (type != ICustomScreenLoadingTypeBase_Union.ICustomScreenLoadingCyberpunk)
			{
				return 0;
			}
			return ICustomScreenLoadingCyberpunk.Pack(builder, _o.AsICustomScreenLoadingCyberpunk()).Value;
		}
	}
}
