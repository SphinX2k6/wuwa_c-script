using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D12 RID: 3346
	[NullableContext(1)]
	[Nullable(0)]
	public class FollowDecorationComponent : IComponentBase
	{
		// Token: 0x06004C60 RID: 19552 RVA: 0x000BE546 File Offset: 0x000BC746
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

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x06004C61 RID: 19553 RVA: 0x000BE568 File Offset: 0x000BC768
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

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x06004C62 RID: 19554 RVA: 0x000BE5A0 File Offset: 0x000BC7A0
		public override bool? EdIsLocked
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x06004C63 RID: 19555 RVA: 0x000BE5B6 File Offset: 0x000BC7B6
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

		// Token: 0x04002BB9 RID: 11193
		private IFollowDecorationComponent Instance;

		// Token: 0x04002BBA RID: 11194
		[Nullable(2)]
		private IFollowDecorationChairConfig _DecorationConfigCache;

		// Token: 0x04002BBB RID: 11195
		private bool _DecorationConfigInited;
	}
}
