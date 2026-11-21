using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200626B RID: 25195
	public class TInteractEntityPartBindUnion
	{
		// Token: 0x1700BB5E RID: 47966
		// (get) Token: 0x0602AE0F RID: 175631 RVA: 0x005DA70A File Offset: 0x005D890A
		// (set) Token: 0x0602AE10 RID: 175632 RVA: 0x005DA712 File Offset: 0x005D8912
		public TInteractEntityPartBind Type { get; set; }

		// Token: 0x1700BB5F RID: 47967
		// (get) Token: 0x0602AE11 RID: 175633 RVA: 0x005DA71B File Offset: 0x005D891B
		// (set) Token: 0x0602AE12 RID: 175634 RVA: 0x005DA723 File Offset: 0x005D8923
		public object Value { get; set; }

		// Token: 0x0602AE13 RID: 175635 RVA: 0x005DA72C File Offset: 0x005D892C
		public TInteractEntityPartBindUnion()
		{
			this.Type = TInteractEntityPartBind.NONE;
			this.Value = null;
		}

		// Token: 0x0602AE14 RID: 175636 RVA: 0x005DA742 File Offset: 0x005D8942
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602AE15 RID: 175637 RVA: 0x005DA754 File Offset: 0x005D8954
		public IInteractEntityPartModelBindT AsIInteractEntityPartModelBind()
		{
			return this.As<IInteractEntityPartModelBindT>();
		}

		// Token: 0x0602AE16 RID: 175638 RVA: 0x005DA75C File Offset: 0x005D895C
		public static TInteractEntityPartBindUnion FromIInteractEntityPartModelBind(IInteractEntityPartModelBindT _iinteractentitypartmodelbind)
		{
			return new TInteractEntityPartBindUnion
			{
				Type = TInteractEntityPartBind.IInteractEntityPartModelBind,
				Value = _iinteractentitypartmodelbind
			};
		}

		// Token: 0x0602AE17 RID: 175639 RVA: 0x005DA771 File Offset: 0x005D8971
		public IInteractEntityPartPrefabBindT AsIInteractEntityPartPrefabBind()
		{
			return this.As<IInteractEntityPartPrefabBindT>();
		}

		// Token: 0x0602AE18 RID: 175640 RVA: 0x005DA779 File Offset: 0x005D8979
		public static TInteractEntityPartBindUnion FromIInteractEntityPartPrefabBind(IInteractEntityPartPrefabBindT _iinteractentitypartprefabbind)
		{
			return new TInteractEntityPartBindUnion
			{
				Type = TInteractEntityPartBind.IInteractEntityPartPrefabBind,
				Value = _iinteractentitypartprefabbind
			};
		}

		// Token: 0x0602AE19 RID: 175641 RVA: 0x005DA790 File Offset: 0x005D8990
		public static int Pack(FlatBufferBuilder builder, TInteractEntityPartBindUnion _o)
		{
			TInteractEntityPartBind type = _o.Type;
			if (type == TInteractEntityPartBind.IInteractEntityPartModelBind)
			{
				return IInteractEntityPartModelBind.Pack(builder, _o.AsIInteractEntityPartModelBind()).Value;
			}
			if (type != TInteractEntityPartBind.IInteractEntityPartPrefabBind)
			{
				return 0;
			}
			return IInteractEntityPartPrefabBind.Pack(builder, _o.AsIInteractEntityPartPrefabBind()).Value;
		}
	}
}
