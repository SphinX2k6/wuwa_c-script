using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E22 RID: 3618
	public class NavMeshComponent : IComponentBase
	{
		// Token: 0x060051F6 RID: 20982 RVA: 0x000CAB1F File Offset: 0x000C8D1F
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

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x060051F7 RID: 20983 RVA: 0x000CAB40 File Offset: 0x000C8D40
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

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x060051F8 RID: 20984 RVA: 0x000CAB78 File Offset: 0x000C8D78
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x060051F9 RID: 20985 RVA: 0x000CAB8E File Offset: 0x000C8D8E
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

		// Token: 0x04002EBB RID: 11963
		private INavMeshComponent Instance;

		// Token: 0x04002EBC RID: 11964
		[Nullable(2)]
		private INavMeshAkiEntitySource _SourceCache;

		// Token: 0x04002EBD RID: 11965
		private bool _SourceInited;
	}
}
