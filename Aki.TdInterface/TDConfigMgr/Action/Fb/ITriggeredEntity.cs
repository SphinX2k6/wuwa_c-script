using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027BC RID: 10172
	public class ITriggeredEntity : ITargetEntityType
	{
		// Token: 0x0600E249 RID: 57929 RVA: 0x00216D33 File Offset: 0x00214F33
		[NullableContext(1)]
		public static ITriggeredEntity Create(ITriggeredEntity? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITriggeredEntity
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004493 RID: 17555
		// (get) Token: 0x0600E24A RID: 57930 RVA: 0x00216D52 File Offset: 0x00214F52
		public override ETargetEntityType Type
		{
			get
			{
				return (ETargetEntityType)this.Instance.Type;
			}
		}

		// Token: 0x04007D7C RID: 32124
		private ITriggeredEntity Instance;
	}
}
