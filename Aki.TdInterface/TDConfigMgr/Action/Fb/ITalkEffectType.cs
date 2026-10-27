using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002539 RID: 9529
	public class ITalkEffectType
	{
		// Token: 0x0600D45F RID: 54367 RVA: 0x001F704E File Offset: 0x001F524E
		[NullableContext(1)]
		public static ITalkEffectType Create(ITalkEffectType? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkEffectType
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17003BAF RID: 15279
		// (get) Token: 0x0600D460 RID: 54368 RVA: 0x001F706D File Offset: 0x001F526D
		public virtual ETalkEffectType Type
		{
			get
			{
				return (ETalkEffectType)this.Instance.Type;
			}
		}

		// Token: 0x04007455 RID: 29781
		private ITalkEffectType Instance;
	}
}
