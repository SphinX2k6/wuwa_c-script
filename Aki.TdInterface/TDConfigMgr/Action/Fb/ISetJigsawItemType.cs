using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200296E RID: 10606
	public class ISetJigsawItemType
	{
		// Token: 0x0600EB0E RID: 60174 RVA: 0x00226631 File Offset: 0x00224831
		[NullableContext(1)]
		public static ISetJigsawItemType Create(ISetJigsawItemType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetJigsawItemType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170049F4 RID: 18932
		// (get) Token: 0x0600EB0F RID: 60175 RVA: 0x00226650 File Offset: 0x00224850
		public virtual ESetJigsawItemType Type
		{
			get
			{
				return (ESetJigsawItemType)this.Instance.Type;
			}
		}

		// Token: 0x0400817E RID: 33150
		private ISetJigsawItemType Instance;
	}
}
