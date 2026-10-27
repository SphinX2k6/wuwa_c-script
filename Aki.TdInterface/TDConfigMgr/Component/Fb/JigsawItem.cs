using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C8B RID: 3211
	[NullableContext(1)]
	[Nullable(0)]
	public class JigsawItem : IComponentBase
	{
		// Token: 0x06004979 RID: 18809 RVA: 0x000B8226 File Offset: 0x000B6426
		public static JigsawItem Create(IJigsawItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new JigsawItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001620 RID: 5664
		// (get) Token: 0x0600497A RID: 18810 RVA: 0x000B8248 File Offset: 0x000B6448
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

		// Token: 0x17001621 RID: 5665
		// (get) Token: 0x0600497B RID: 18811 RVA: 0x000B8280 File Offset: 0x000B6480
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001622 RID: 5666
		// (get) Token: 0x0600497C RID: 18812 RVA: 0x000B8296 File Offset: 0x000B6496
		public virtual IFillType FillCfg
		{
			get
			{
				if (this._FillCfgInited)
				{
					return this._FillCfgCache;
				}
				this._FillCfgInited = true;
				this._FillCfgCache = ComponentReadHelper.ReadJigsawItem_FillCfg(this.Instance);
				return this._FillCfgCache;
			}
		}

		// Token: 0x040029E6 RID: 10726
		private IJigsawItem Instance;

		// Token: 0x040029E7 RID: 10727
		private IFillType _FillCfgCache;

		// Token: 0x040029E8 RID: 10728
		private bool _FillCfgInited;
	}
}
