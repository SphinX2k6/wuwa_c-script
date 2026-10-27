using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C88 RID: 23688
	public class TPortalConfigUnion
	{
		// Token: 0x1700B238 RID: 45624
		// (get) Token: 0x0602893B RID: 166203 RVA: 0x00594170 File Offset: 0x00592370
		// (set) Token: 0x0602893C RID: 166204 RVA: 0x00594178 File Offset: 0x00592378
		public TPortalConfig Type { get; set; }

		// Token: 0x1700B239 RID: 45625
		// (get) Token: 0x0602893D RID: 166205 RVA: 0x00594181 File Offset: 0x00592381
		// (set) Token: 0x0602893E RID: 166206 RVA: 0x00594189 File Offset: 0x00592389
		public object Value { get; set; }

		// Token: 0x0602893F RID: 166207 RVA: 0x00594192 File Offset: 0x00592392
		public TPortalConfigUnion()
		{
			this.Type = TPortalConfig.NONE;
			this.Value = null;
		}

		// Token: 0x06028940 RID: 166208 RVA: 0x005941A8 File Offset: 0x005923A8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06028941 RID: 166209 RVA: 0x005941BA File Offset: 0x005923BA
		public IDynamicPortalT AsIDynamicPortal()
		{
			return this.As<IDynamicPortalT>();
		}

		// Token: 0x06028942 RID: 166210 RVA: 0x005941C2 File Offset: 0x005923C2
		public static TPortalConfigUnion FromIDynamicPortal(IDynamicPortalT _idynamicportal)
		{
			return new TPortalConfigUnion
			{
				Type = TPortalConfig.IDynamicPortal,
				Value = _idynamicportal
			};
		}

		// Token: 0x06028943 RID: 166211 RVA: 0x005941D7 File Offset: 0x005923D7
		public IStaticPortalT AsIStaticPortal()
		{
			return this.As<IStaticPortalT>();
		}

		// Token: 0x06028944 RID: 166212 RVA: 0x005941DF File Offset: 0x005923DF
		public static TPortalConfigUnion FromIStaticPortal(IStaticPortalT _istaticportal)
		{
			return new TPortalConfigUnion
			{
				Type = TPortalConfig.IStaticPortal,
				Value = _istaticportal
			};
		}

		// Token: 0x06028945 RID: 166213 RVA: 0x005941F4 File Offset: 0x005923F4
		public static int Pack(FlatBufferBuilder builder, TPortalConfigUnion _o)
		{
			TPortalConfig type = _o.Type;
			if (type == TPortalConfig.IDynamicPortal)
			{
				return IDynamicPortal.Pack(builder, _o.AsIDynamicPortal()).Value;
			}
			if (type != TPortalConfig.IStaticPortal)
			{
				return 0;
			}
			return IStaticPortal.Pack(builder, _o.AsIStaticPortal()).Value;
		}
	}
}
