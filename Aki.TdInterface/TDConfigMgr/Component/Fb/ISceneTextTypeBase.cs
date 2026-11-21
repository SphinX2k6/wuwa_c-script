using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E19 RID: 3609
	public class ISceneTextTypeBase
	{
		// Token: 0x060051C4 RID: 20932 RVA: 0x000CA5D5 File Offset: 0x000C87D5
		public static ISceneTextTypeBase Create(ISceneTextTypeBase? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneTextTypeBase
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x060051C5 RID: 20933 RVA: 0x000CA5F4 File Offset: 0x000C87F4
		public virtual ESceneTextType Type
		{
			get
			{
				return (ESceneTextType)this.Instance.Type;
			}
		}

		// Token: 0x04002EA4 RID: 11940
		private ISceneTextTypeBase Instance;
	}
}
