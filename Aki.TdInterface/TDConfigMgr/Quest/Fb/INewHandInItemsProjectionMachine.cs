using System;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020014CE RID: 5326
	public class INewHandInItemsProjectionMachine : INewHandInItemsBase
	{
		// Token: 0x060078D0 RID: 30928 RVA: 0x00121396 File Offset: 0x0011F596
		public static INewHandInItemsProjectionMachine Create(INewHandInItemsProjectionMachine? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INewHandInItemsProjectionMachine
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170026D6 RID: 9942
		// (get) Token: 0x060078D1 RID: 30929 RVA: 0x001213B5 File Offset: 0x0011F5B5
		public override ENewHandInItemsType Type
		{
			get
			{
				return (ENewHandInItemsType)this.Instance.Type;
			}
		}

		// Token: 0x170026D7 RID: 9943
		// (get) Token: 0x060078D2 RID: 30930 RVA: 0x001213C2 File Offset: 0x0011F5C2
		public virtual int EntityId
		{
			get
			{
				return this.Instance.EntityId;
			}
		}

		// Token: 0x170026D8 RID: 9944
		// (get) Token: 0x060078D3 RID: 30931 RVA: 0x001213CF File Offset: 0x0011F5CF
		public virtual int ItemId
		{
			get
			{
				return this.Instance.ItemId;
			}
		}

		// Token: 0x04004582 RID: 17794
		private INewHandInItemsProjectionMachine Instance;
	}
}
