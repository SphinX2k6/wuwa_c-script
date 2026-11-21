using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027E0 RID: 10208
	public class ITalkEffectType
	{
		// Token: 0x0600E1BF RID: 57791 RVA: 0x00212AAE File Offset: 0x00210CAE
		public static ITalkEffectType Create(ITalkEffectType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkEffectType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003EAD RID: 16045
		// (get) Token: 0x0600E1C0 RID: 57792 RVA: 0x00212ACD File Offset: 0x00210CCD
		public virtual ETalkEffectType Type
		{
			get
			{
				return (ETalkEffectType)this.Instance.Type;
			}
		}

		// Token: 0x04007AAA RID: 31402
		private ITalkEffectType Instance;
	}
}
