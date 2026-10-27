using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020026CC RID: 9932
	public class ICenterTextShowType
	{
		// Token: 0x0600DE0E RID: 56846 RVA: 0x0020F566 File Offset: 0x0020D766
		[NullableContext(1)]
		public static ICenterTextShowType Create(ICenterTextShowType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICenterTextShowType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004238 RID: 16952
		// (get) Token: 0x0600DE0F RID: 56847 RVA: 0x0020F585 File Offset: 0x0020D785
		public virtual ECenterTextShowAnim Type
		{
			get
			{
				return (ECenterTextShowAnim)this.Instance.Type;
			}
		}

		// Token: 0x04007B4A RID: 31562
		private ICenterTextShowType Instance;
	}
}
