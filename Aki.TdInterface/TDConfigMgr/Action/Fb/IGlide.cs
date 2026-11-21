using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AB6 RID: 10934
	public class IGlide : ILeisureInteractType
	{
		// Token: 0x0600F111 RID: 61713 RVA: 0x00234B20 File Offset: 0x00232D20
		public static IGlide Create(IGlide? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGlide
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004853 RID: 18515
		// (get) Token: 0x0600F112 RID: 61714 RVA: 0x00234B3F File Offset: 0x00232D3F
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04008482 RID: 33922
		private IGlide Instance;
	}
}
