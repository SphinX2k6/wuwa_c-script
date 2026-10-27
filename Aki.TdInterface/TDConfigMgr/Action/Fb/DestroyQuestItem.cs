using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200263D RID: 9789
	public class DestroyQuestItem : ActionParams
	{
		// Token: 0x0600DBA7 RID: 56231 RVA: 0x0020B222 File Offset: 0x00209422
		[NullableContext(1)]
		public static DestroyQuestItem Create(IDestroyQuestItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new DestroyQuestItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170040EF RID: 16623
		// (get) Token: 0x0600DBA8 RID: 56232 RVA: 0x0020B241 File Offset: 0x00209441
		public virtual int ItemId
		{
			get
			{
				return this.Instance.ItemId;
			}
		}

		// Token: 0x170040F0 RID: 16624
		// (get) Token: 0x0600DBA9 RID: 56233 RVA: 0x0020B24E File Offset: 0x0020944E
		public virtual int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x170040F1 RID: 16625
		// (get) Token: 0x0600DBAA RID: 56234 RVA: 0x0020B25B File Offset: 0x0020945B
		public virtual bool IsAll
		{
			get
			{
				return this.Instance.IsAll;
			}
		}

		// Token: 0x04007A11 RID: 31249
		private IDestroyQuestItem Instance;
	}
}
