using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C46 RID: 23622
	public class TInteractEntityPartBindUnion
	{
		// Token: 0x1700B20C RID: 45580
		// (get) Token: 0x06028801 RID: 165889 RVA: 0x005924F2 File Offset: 0x005906F2
		// (set) Token: 0x06028802 RID: 165890 RVA: 0x005924FA File Offset: 0x005906FA
		public TInteractEntityPartBind Type { get; set; }

		// Token: 0x1700B20D RID: 45581
		// (get) Token: 0x06028803 RID: 165891 RVA: 0x00592503 File Offset: 0x00590703
		// (set) Token: 0x06028804 RID: 165892 RVA: 0x0059250B File Offset: 0x0059070B
		public object Value { get; set; }

		// Token: 0x06028805 RID: 165893 RVA: 0x00592514 File Offset: 0x00590714
		public TInteractEntityPartBindUnion()
		{
			this.Type = TInteractEntityPartBind.NONE;
			this.Value = null;
		}

		// Token: 0x06028806 RID: 165894 RVA: 0x0059252A File Offset: 0x0059072A
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028807 RID: 165895 RVA: 0x0059253C File Offset: 0x0059073C
		public IInteractEntityPartModelBindT AsIInteractEntityPartModelBind()
		{
			return this.As<IInteractEntityPartModelBindT>();
		}

		// Token: 0x06028808 RID: 165896 RVA: 0x00592544 File Offset: 0x00590744
		public static TInteractEntityPartBindUnion FromIInteractEntityPartModelBind(IInteractEntityPartModelBindT _iinteractentitypartmodelbind)
		{
			return new TInteractEntityPartBindUnion
			{
				Type = TInteractEntityPartBind.IInteractEntityPartModelBind,
				Value = _iinteractentitypartmodelbind
			};
		}

		// Token: 0x06028809 RID: 165897 RVA: 0x00592559 File Offset: 0x00590759
		public IInteractEntityPartPrefabBindT AsIInteractEntityPartPrefabBind()
		{
			return this.As<IInteractEntityPartPrefabBindT>();
		}

		// Token: 0x0602880A RID: 165898 RVA: 0x00592561 File Offset: 0x00590761
		public static TInteractEntityPartBindUnion FromIInteractEntityPartPrefabBind(IInteractEntityPartPrefabBindT _iinteractentitypartprefabbind)
		{
			return new TInteractEntityPartBindUnion
			{
				Type = TInteractEntityPartBind.IInteractEntityPartPrefabBind,
				Value = _iinteractentitypartprefabbind
			};
		}

		// Token: 0x0602880B RID: 165899 RVA: 0x00592578 File Offset: 0x00590778
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
