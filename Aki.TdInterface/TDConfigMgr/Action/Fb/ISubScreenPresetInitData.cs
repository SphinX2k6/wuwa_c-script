using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A6F RID: 10863
	public class ISubScreenPresetInitData : ISubScreenInitData
	{
		// Token: 0x0600EFCD RID: 61389 RVA: 0x0023269B File Offset: 0x0023089B
		public static ISubScreenPresetInitData Create(ISubScreenPresetInitData? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubScreenPresetInitData
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700479D RID: 18333
		// (get) Token: 0x0600EFCE RID: 61390 RVA: 0x002326BA File Offset: 0x002308BA
		public override ESubScreenInitDataType Type
		{
			get
			{
				return (ESubScreenInitDataType)this.Instance.Type;
			}
		}

		// Token: 0x1700479E RID: 18334
		// (get) Token: 0x0600EFCF RID: 61391 RVA: 0x002326C7 File Offset: 0x002308C7
		public override string SubScreenKey
		{
			get
			{
				return this.Instance.SubScreenKey;
			}
		}

		// Token: 0x1700479F RID: 18335
		// (get) Token: 0x0600EFD0 RID: 61392 RVA: 0x002326D4 File Offset: 0x002308D4
		public virtual ESubScreenInitPreset AnchorType
		{
			get
			{
				return (ESubScreenInitPreset)this.Instance.AnchorType;
			}
		}

		// Token: 0x040083DB RID: 33755
		private ISubScreenPresetInitData Instance;
	}
}
