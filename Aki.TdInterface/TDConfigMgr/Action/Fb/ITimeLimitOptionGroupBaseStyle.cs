using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027D0 RID: 10192
	public class ITimeLimitOptionGroupBaseStyle
	{
		// Token: 0x0600E17C RID: 57724 RVA: 0x00212399 File Offset: 0x00210599
		public static ITimeLimitOptionGroupBaseStyle Create(ITimeLimitOptionGroupBaseStyle? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITimeLimitOptionGroupBaseStyle
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003E8A RID: 16010
		// (get) Token: 0x0600E17D RID: 57725 RVA: 0x002123B8 File Offset: 0x002105B8
		public virtual ETimeLimitOptionGroupStyle Type
		{
			get
			{
				return (ETimeLimitOptionGroupStyle)this.Instance.Type;
			}
		}

		// Token: 0x04007A86 RID: 31366
		private ITimeLimitOptionGroupBaseStyle Instance;
	}
}
