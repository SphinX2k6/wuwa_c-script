using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000AB7 RID: 2743
	public class IFixedDateTime
	{
		// Token: 0x06003F39 RID: 16185 RVA: 0x000A19BE File Offset: 0x0009FBBE
		[NullableContext(1)]
		public static IFixedDateTime Create(IFixedDateTime? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFixedDateTime
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17000F88 RID: 3976
		// (get) Token: 0x06003F3A RID: 16186 RVA: 0x000A19DD File Offset: 0x0009FBDD
		public virtual int Hours
		{
			get
			{
				return this.Instance.Hours;
			}
		}

		// Token: 0x17000F89 RID: 3977
		// (get) Token: 0x06003F3B RID: 16187 RVA: 0x000A19EA File Offset: 0x0009FBEA
		public virtual int Minutes
		{
			get
			{
				return this.Instance.Minutes;
			}
		}

		// Token: 0x17000F8A RID: 3978
		// (get) Token: 0x06003F3C RID: 16188 RVA: 0x000A19F7 File Offset: 0x0009FBF7
		public virtual int Seconds
		{
			get
			{
				return this.Instance.Seconds;
			}
		}

		// Token: 0x0400231C RID: 8988
		private IFixedDateTime Instance;
	}
}
