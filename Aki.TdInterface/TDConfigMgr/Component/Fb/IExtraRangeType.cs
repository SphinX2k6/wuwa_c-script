using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CFE RID: 3326
	public class IExtraRangeType
	{
		// Token: 0x06004BCE RID: 19406 RVA: 0x000BDF76 File Offset: 0x000BC176
		public static IExtraRangeType Create(IExtraRangeType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExtraRangeType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170015CD RID: 5581
		// (get) Token: 0x06004BCF RID: 19407 RVA: 0x000BDF95 File Offset: 0x000BC195
		public virtual EExtraRangeType Type
		{
			get
			{
				return (EExtraRangeType)this.Instance.Type;
			}
		}

		// Token: 0x04002AD9 RID: 10969
		private IExtraRangeType Instance;
	}
}
