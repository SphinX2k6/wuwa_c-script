using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007741 RID: 30529
	public class TOpenQteConfigUnion
	{
		// Token: 0x1700E66F RID: 58991
		// (get) Token: 0x0603777E RID: 227198 RVA: 0x007824C0 File Offset: 0x007806C0
		// (set) Token: 0x0603777F RID: 227199 RVA: 0x007824C8 File Offset: 0x007806C8
		public TOpenQteConfig Type { get; set; }

		// Token: 0x1700E670 RID: 58992
		// (get) Token: 0x06037780 RID: 227200 RVA: 0x007824D1 File Offset: 0x007806D1
		// (set) Token: 0x06037781 RID: 227201 RVA: 0x007824D9 File Offset: 0x007806D9
		public object Value { get; set; }

		// Token: 0x06037782 RID: 227202 RVA: 0x007824E2 File Offset: 0x007806E2
		public TOpenQteConfigUnion()
		{
			this.Type = TOpenQteConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06037783 RID: 227203 RVA: 0x007824F8 File Offset: 0x007806F8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037784 RID: 227204 RVA: 0x0078250A File Offset: 0x0078070A
		public IOpenLevelQteT AsIOpenLevelQte()
		{
			return this.As<IOpenLevelQteT>();
		}

		// Token: 0x06037785 RID: 227205 RVA: 0x00782512 File Offset: 0x00780712
		public static TOpenQteConfigUnion FromIOpenLevelQte(IOpenLevelQteT _iopenlevelqte)
		{
			return new TOpenQteConfigUnion
			{
				Type = TOpenQteConfig.IOpenLevelQte,
				Value = _iopenlevelqte
			};
		}

		// Token: 0x06037786 RID: 227206 RVA: 0x00782527 File Offset: 0x00780727
		public IOpenPanelQteQteT AsIOpenPanelQteQte()
		{
			return this.As<IOpenPanelQteQteT>();
		}

		// Token: 0x06037787 RID: 227207 RVA: 0x0078252F File Offset: 0x0078072F
		public static TOpenQteConfigUnion FromIOpenPanelQteQte(IOpenPanelQteQteT _iopenpanelqteqte)
		{
			return new TOpenQteConfigUnion
			{
				Type = TOpenQteConfig.IOpenPanelQteQte,
				Value = _iopenpanelqteqte
			};
		}

		// Token: 0x06037788 RID: 227208 RVA: 0x00782544 File Offset: 0x00780744
		public static int Pack(FlatBufferBuilder builder, TOpenQteConfigUnion _o)
		{
			TOpenQteConfig type = _o.Type;
			if (type == TOpenQteConfig.IOpenLevelQte)
			{
				return IOpenLevelQte.Pack(builder, _o.AsIOpenLevelQte()).Value;
			}
			if (type != TOpenQteConfig.IOpenPanelQteQte)
			{
				return 0;
			}
			return IOpenPanelQteQte.Pack(builder, _o.AsIOpenPanelQteQte()).Value;
		}
	}
}
