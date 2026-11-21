using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002875 RID: 10357
	public class ISubtitleStyleNewLevelB : ISubtitleStyleBase
	{
		// Token: 0x0600E6E2 RID: 59106 RVA: 0x002229A8 File Offset: 0x00220BA8
		public static ISubtitleStyleNewLevelB Create(ISubtitleStyleNewLevelB? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubtitleStyleNewLevelB
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042A6 RID: 17062
		// (get) Token: 0x0600E6E3 RID: 59107 RVA: 0x002229C7 File Offset: 0x00220BC7
		public override ESubtitleStyle Type
		{
			get
			{
				return (ESubtitleStyle)this.Instance.Type;
			}
		}

		// Token: 0x04007F25 RID: 32549
		private ISubtitleStyleNewLevelB Instance;
	}
}
