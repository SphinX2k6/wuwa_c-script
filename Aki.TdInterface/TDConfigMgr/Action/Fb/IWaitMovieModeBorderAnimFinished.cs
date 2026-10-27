using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002AD0 RID: 10960
	public class IWaitMovieModeBorderAnimFinished : IEnterMovieModeDurationType
	{
		// Token: 0x0600F064 RID: 61540 RVA: 0x0022E84E File Offset: 0x0022CA4E
		[NullableContext(1)]
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

		// Token: 0x17004C86 RID: 19590
		// (get) Token: 0x0600F065 RID: 61541 RVA: 0x0022E86D File Offset: 0x0022CA6D
		public override EEnterMovieModeDurationType Type
		{
			get
			{
				return (EEnterMovieModeDurationType)this.Instance.Type;
			}
		}

		// Token: 0x04008438 RID: 33848
		private IWaitMovieModeBorderAnimFinished Instance;
	}
}
