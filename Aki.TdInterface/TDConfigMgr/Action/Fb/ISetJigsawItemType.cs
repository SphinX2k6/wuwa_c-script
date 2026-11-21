using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C53 RID: 11347
	public class ISetJigsawItemType
	{
		// Token: 0x0600F984 RID: 63876 RVA: 0x00243CE9 File Offset: 0x00241EE9
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

		// Token: 0x17004D8C RID: 19852
		// (get) Token: 0x0600F985 RID: 63877 RVA: 0x00243D08 File Offset: 0x00241F08
		public virtual ESetJigsawItemType Type
		{
			get
			{
				return (ESetJigsawItemType)this.Instance.Type;
			}
		}

		// Token: 0x0400885F RID: 34911
		private ISetJigsawItemType Instance;
	}
}
