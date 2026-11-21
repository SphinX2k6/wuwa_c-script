using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027B9 RID: 10169
	public class ITalkOptionQteFailed : ITalkOptionParamType
	{
		// Token: 0x0600E10F RID: 57615 RVA: 0x002117A4 File Offset: 0x0020F9A4
		public static ITalkOptionQteFailed Create(ITalkOptionQteFailed? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkOptionQteFailed
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E4B RID: 15947
		// (get) Token: 0x0600E110 RID: 57616 RVA: 0x002117C3 File Offset: 0x0020F9C3
		public override ETalkOptionParamType Type
		{
			get
			{
				return (ETalkOptionParamType)this.Instance.Type;
			}
		}

		// Token: 0x04007A57 RID: 31319
		private ITalkOptionQteFailed Instance;
	}
}
