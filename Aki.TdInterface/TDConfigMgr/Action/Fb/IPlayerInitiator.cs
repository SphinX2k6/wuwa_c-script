using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A5D RID: 10845
	public class IPlayerInitiator : INpcGroupPerformInitiatorType
	{
		// Token: 0x0600EE8D RID: 61069 RVA: 0x0022B787 File Offset: 0x00229987
		[NullableContext(1)]
		public static IPlayerInitiator Create(IPlayerInitiator? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayerInitiator
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004B95 RID: 19349
		// (get) Token: 0x0600EE8E RID: 61070 RVA: 0x0022B7A6 File Offset: 0x002299A6
		public override ENpcGroupPerformInitiatorType Type
		{
			get
			{
				return (ENpcGroupPerformInitiatorType)this.Instance.Type;
			}
		}

		// Token: 0x0400833D RID: 33597
		private IPlayerInitiator Instance;
	}
}
