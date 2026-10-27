using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x020012D0 RID: 4816
	public class IDangoAbyssInformationView : IInformationViewType
	{
		// Token: 0x06006E28 RID: 28200 RVA: 0x0010A789 File Offset: 0x00108989
		[NullableContext(1)]
		public static IDangoAbyssInformationView Create(IDangoAbyssInformationView? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDangoAbyssInformationView
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700225B RID: 8795
		// (get) Token: 0x06006E29 RID: 28201 RVA: 0x0010A7A8 File Offset: 0x001089A8
		public override EInformationViewType Type
		{
			get
			{
				return (EInformationViewType)this.Instance.Type;
			}
		}

		// Token: 0x04003F22 RID: 16162
		private IDangoAbyssInformationView Instance;
	}
}
