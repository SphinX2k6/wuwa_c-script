using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D6D RID: 3437
	public class JigsawItem : IComponentBase
	{
		// Token: 0x06004E27 RID: 20007 RVA: 0x000C2C36 File Offset: 0x000C0E36
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

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x06004E28 RID: 20008 RVA: 0x000C2C58 File Offset: 0x000C0E58
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

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x06004E29 RID: 20009 RVA: 0x000C2C90 File Offset: 0x000C0E90
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x06004E2A RID: 20010 RVA: 0x000C2CA6 File Offset: 0x000C0EA6
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

		// Token: 0x04002C60 RID: 11360
		private IJigsawItem Instance;

		// Token: 0x04002C61 RID: 11361
		private IFillType _FillCfgCache;

		// Token: 0x04002C62 RID: 11362
		private bool _FillCfgInited;
	}
}
