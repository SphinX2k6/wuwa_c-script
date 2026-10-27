using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027F6 RID: 10230
	public class IQiuyuanQinggongEnd : ILeisureInteractType
	{
		// Token: 0x0600E32C RID: 58156 RVA: 0x00218146 File Offset: 0x00216346
		[NullableContext(1)]
		public static IQiuyuanQinggongEnd Create(IQiuyuanQinggongEnd? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongEnd
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004502 RID: 17666
		// (get) Token: 0x0600E32D RID: 58157 RVA: 0x00218165 File Offset: 0x00216365
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DDA RID: 32218
		private IQiuyuanQinggongEnd Instance;
	}
}
