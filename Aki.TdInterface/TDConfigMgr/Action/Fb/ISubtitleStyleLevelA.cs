using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002874 RID: 10356
	public class ISubtitleStyleLevelA : ISubtitleStyleBase
	{
		// Token: 0x0600E6DF RID: 59103 RVA: 0x00222974 File Offset: 0x00220B74
		public static ISubtitleStyleLevelA Create(ISubtitleStyleLevelA? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISubtitleStyleLevelA
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170042A5 RID: 17061
		// (get) Token: 0x0600E6E0 RID: 59104 RVA: 0x00222993 File Offset: 0x00220B93
		public override ESubtitleStyle Type
		{
			get
			{
				return (ESubtitleStyle)this.Instance.Type;
			}
		}

		// Token: 0x04007F24 RID: 32548
		private ISubtitleStyleLevelA Instance;
	}
}
