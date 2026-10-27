using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027E3 RID: 10211
	public class IGlide : ILeisureInteractType
	{
		// Token: 0x0600E2EC RID: 58092 RVA: 0x00217CBD File Offset: 0x00215EBD
		[NullableContext(1)]
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

		// Token: 0x170044E8 RID: 17640
		// (get) Token: 0x0600E2ED RID: 58093 RVA: 0x00217CDC File Offset: 0x00215EDC
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DC5 RID: 32197
		private IGlide Instance;
	}
}
