using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x020029A5 RID: 10661
	public class IVillageInfrVillageLevel : IVillageInfrBuildOption
	{
		// Token: 0x0600EBEE RID: 60398 RVA: 0x00227B26 File Offset: 0x00225D26
		[NullableContext(1)]
		public static IVillageInfrVillageLevel Create(IVillageInfrVillageLevel? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVillageInfrVillageLevel
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A66 RID: 19046
		// (get) Token: 0x0600EBEF RID: 60399 RVA: 0x00227B45 File Offset: 0x00225D45
		public override EVillageInfrBuildType Type
		{
			get
			{
				return (EVillageInfrBuildType)this.Instance.Type;
			}
		}

		// Token: 0x17004A67 RID: 19047
		// (get) Token: 0x0600EBF0 RID: 60400 RVA: 0x00227B52 File Offset: 0x00225D52
		public virtual int Level
		{
			get
			{
				return this.Instance.Level;
			}
		}

		// Token: 0x040081EB RID: 33259
		private IVillageInfrVillageLevel Instance;
	}
}
