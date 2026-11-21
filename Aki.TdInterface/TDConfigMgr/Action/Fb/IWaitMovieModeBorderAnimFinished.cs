using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002DC4 RID: 11716
	public class IWaitMovieModeBorderAnimFinished : IEnterMovieModeDurationType
	{
		// Token: 0x0600FF1A RID: 65306 RVA: 0x0024C55A File Offset: 0x0024A75A
		public static IWaitMovieModeBorderAnimFinished Create(IWaitMovieModeBorderAnimFinished? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IWaitMovieModeBorderAnimFinished
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17005040 RID: 20544
		// (get) Token: 0x0600FF1B RID: 65307 RVA: 0x0024C579 File Offset: 0x0024A779
		public override EEnterMovieModeDurationType Type
		{
			get
			{
				return (EEnterMovieModeDurationType)this.Instance.Type;
			}
		}

		// Token: 0x04008B3C RID: 35644
		private IWaitMovieModeBorderAnimFinished Instance;
	}
}
