using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E0B RID: 3595
	public class FollowDecorationComponent : IComponentBase
	{
		// Token: 0x06005173 RID: 20851 RVA: 0x000C9AEE File Offset: 0x000C7CEE
		public static FollowDecorationComponent Create(IFollowDecorationComponent? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new FollowDecorationComponent
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001958 RID: 6488
		// (get) Token: 0x06005174 RID: 20852 RVA: 0x000C9B10 File Offset: 0x000C7D10
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

		// Token: 0x17001959 RID: 6489
		// (get) Token: 0x06005175 RID: 20853 RVA: 0x000C9B48 File Offset: 0x000C7D48
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700195A RID: 6490
		// (get) Token: 0x06005176 RID: 20854 RVA: 0x000C9B5E File Offset: 0x000C7D5E
		public virtual IFollowDecorationChairConfig DecorationConfig
		{
			get
			{
				if (this._DecorationConfigInited)
				{
					return this._DecorationConfigCache;
				}
				this._DecorationConfigInited = true;
				this._DecorationConfigCache = IFollowDecorationChairConfig.Create(this.Instance.DecorationConfig);
				return this._DecorationConfigCache;
			}
		}

		// Token: 0x04002E76 RID: 11894
		private IFollowDecorationComponent Instance;

		// Token: 0x04002E77 RID: 11895
		[Nullable(2)]
		private IFollowDecorationChairConfig _DecorationConfigCache;

		// Token: 0x04002E78 RID: 11896
		private bool _DecorationConfigInited;
	}
}
