using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D28 RID: 3368
	[NullableContext(1)]
	[Nullable(0)]
	public class NavMeshComponent : IComponentBase
	{
		// Token: 0x06004CDA RID: 19674 RVA: 0x000BF3DB File Offset: 0x000BD5DB
		public static NavMeshComponent Create(INavMeshComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new NavMeshComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001847 RID: 6215
		// (get) Token: 0x06004CDB RID: 19675 RVA: 0x000BF3FC File Offset: 0x000BD5FC
		public override bool? Disabled
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.Disabled);
			}
		}

		// Token: 0x17001848 RID: 6216
		// (get) Token: 0x06004CDC RID: 19676 RVA: 0x000BF434 File Offset: 0x000BD634
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001849 RID: 6217
		// (get) Token: 0x06004CDD RID: 19677 RVA: 0x000BF44A File Offset: 0x000BD64A
		public virtual INavMeshAkiEntitySource Source
		{
			get
			{
				if (this._SourceInited)
				{
					return this._SourceCache;
				}
				this._SourceInited = true;
				this._SourceCache = INavMeshAkiEntitySource.Create(this.Instance.Source);
				return this._SourceCache;
			}
		}

		// Token: 0x04002BFB RID: 11259
		private INavMeshComponent Instance;

		// Token: 0x04002BFC RID: 11260
		[Nullable(2)]
		private INavMeshAkiEntitySource _SourceCache;

		// Token: 0x04002BFD RID: 11261
		private bool _SourceInited;
	}
}
