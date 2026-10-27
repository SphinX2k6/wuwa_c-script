using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CF0 RID: 3312
	public class IBeamLayoutConfigWall : IBeamLayoutConfig
	{
		// Token: 0x06004BA3 RID: 19363 RVA: 0x000BCCB6 File Offset: 0x000BAEB6
		[NullableContext(1)]
		public static IBeamLayoutConfigWall Create(IBeamLayoutConfigWall? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBeamLayoutConfigWall
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001780 RID: 6016
		// (get) Token: 0x06004BA4 RID: 19364 RVA: 0x000BCCD5 File Offset: 0x000BAED5
		public override EBeamLayoutType Type
		{
			get
			{
				return (EBeamLayoutType)this.Instance.Type;
			}
		}

		// Token: 0x17001781 RID: 6017
		// (get) Token: 0x06004BA5 RID: 19365 RVA: 0x000BCCE2 File Offset: 0x000BAEE2
		public virtual int Count
		{
			get
			{
				return this.Instance.Count;
			}
		}

		// Token: 0x17001782 RID: 6018
		// (get) Token: 0x06004BA6 RID: 19366 RVA: 0x000BCCEF File Offset: 0x000BAEEF
		public virtual float Distance
		{
			get
			{
				return this.Instance.Distance;
			}
		}

		// Token: 0x04002B3B RID: 11067
		private IBeamLayoutConfigWall Instance;
	}
}
