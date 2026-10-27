using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020027F8 RID: 10232
	public class IQiuyuanQinggongExploration2 : ILeisureInteractType
	{
		// Token: 0x0600E332 RID: 58162 RVA: 0x002181AE File Offset: 0x002163AE
		[NullableContext(1)]
		public static IQiuyuanQinggongExploration2 Create(IQiuyuanQinggongExploration2? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQiuyuanQinggongExploration2
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004504 RID: 17668
		// (get) Token: 0x0600E333 RID: 58163 RVA: 0x002181CD File Offset: 0x002163CD
		public override ELeisureInteract Type
		{
			get
			{
				return (ELeisureInteract)this.Instance.Type;
			}
		}

		// Token: 0x04007DDC RID: 32220
		private IQiuyuanQinggongExploration2 Instance;
	}
}
