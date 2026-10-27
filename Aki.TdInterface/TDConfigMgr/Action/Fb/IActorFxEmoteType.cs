using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002532 RID: 9522
	public class IActorFxEmoteType
	{
		// Token: 0x0600D43E RID: 54334 RVA: 0x001F6CB0 File Offset: 0x001F4EB0
		[NullableContext(1)]
		public static IActorFxEmoteType Create(IActorFxEmoteType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFxEmoteType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003B9C RID: 15260
		// (get) Token: 0x0600D43F RID: 54335 RVA: 0x001F6CCF File Offset: 0x001F4ECF
		public virtual EActorFxEmoteType Type
		{
			get
			{
				return (EActorFxEmoteType)this.Instance.Type;
			}
		}

		// Token: 0x04007446 RID: 29766
		private IActorFxEmoteType Instance;
	}
}
