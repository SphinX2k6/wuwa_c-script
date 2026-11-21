using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007F6A RID: 32618
	public class TOpenQteConfigUnion
	{
		// Token: 0x1700F2BF RID: 62143
		// (get) Token: 0x0603ACB9 RID: 240825 RVA: 0x007E7450 File Offset: 0x007E5650
		// (set) Token: 0x0603ACBA RID: 240826 RVA: 0x007E7458 File Offset: 0x007E5658
		public TOpenQteConfig Type { get; set; }

		// Token: 0x1700F2C0 RID: 62144
		// (get) Token: 0x0603ACBB RID: 240827 RVA: 0x007E7461 File Offset: 0x007E5661
		// (set) Token: 0x0603ACBC RID: 240828 RVA: 0x007E7469 File Offset: 0x007E5669
		public object Value { get; set; }

		// Token: 0x0603ACBD RID: 240829 RVA: 0x007E7472 File Offset: 0x007E5672
		public TOpenQteConfigUnion()
		{
			this.Type = TOpenQteConfig.NONE;
			this.Value = null;
		}

		// Token: 0x0603ACBE RID: 240830 RVA: 0x007E7488 File Offset: 0x007E5688
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603ACBF RID: 240831 RVA: 0x007E749A File Offset: 0x007E569A
		public IOpenLevelQteT AsIOpenLevelQte()
		{
			return this.As<IOpenLevelQteT>();
		}

		// Token: 0x0603ACC0 RID: 240832 RVA: 0x007E74A2 File Offset: 0x007E56A2
		public static TOpenQteConfigUnion FromIOpenLevelQte(IOpenLevelQteT _iopenlevelqte)
		{
			return new TOpenQteConfigUnion
			{
				Type = TOpenQteConfig.IOpenLevelQte,
				Value = _iopenlevelqte
			};
		}

		// Token: 0x0603ACC1 RID: 240833 RVA: 0x007E74B7 File Offset: 0x007E56B7
		public IOpenPanelQteQteT AsIOpenPanelQteQte()
		{
			return this.As<IOpenPanelQteQteT>();
		}

		// Token: 0x0603ACC2 RID: 240834 RVA: 0x007E74BF File Offset: 0x007E56BF
		public static TOpenQteConfigUnion FromIOpenPanelQteQte(IOpenPanelQteQteT _iopenpanelqteqte)
		{
			return new TOpenQteConfigUnion
			{
				Type = TOpenQteConfig.IOpenPanelQteQte,
				Value = _iopenpanelqteqte
			};
		}

		// Token: 0x0603ACC3 RID: 240835 RVA: 0x007E74D4 File Offset: 0x007E56D4
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
