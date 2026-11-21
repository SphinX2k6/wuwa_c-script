using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002D55 RID: 11605
	public class ISetNpcSequencePerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600FD58 RID: 64856 RVA: 0x002495A9 File Offset: 0x002477A9
		public static ISetNpcSequencePerform Create(ISetNpcSequencePerform? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcSequencePerform
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004F5C RID: 20316
		// (get) Token: 0x0600FD59 RID: 64857 RVA: 0x002495C8 File Offset: 0x002477C8
		public override ENpcGroupPerformType Type
		{
			get
			{
				return (ENpcGroupPerformType)this.Instance.Type;
			}
		}

		// Token: 0x17004F5D RID: 20317
		// (get) Token: 0x0600FD5A RID: 64858 RVA: 0x002495D5 File Offset: 0x002477D5
		public virtual string Sequence
		{
			get
			{
				return this.Instance.Sequence;
			}
		}

		// Token: 0x17004F5E RID: 20318
		// (get) Token: 0x0600FD5B RID: 64859 RVA: 0x002495E4 File Offset: 0x002477E4
		public virtual List<INpcGroupSequencePlaySetting> PlaySettings
		{
			get
			{
				if (this._PlaySettingsInited)
				{
					return this._PlaySettingsCache;
				}
				this._PlaySettingsInited = true;
				int playSettingsLength = this.Instance.PlaySettingsLength;
				this._PlaySettingsCache = new List<INpcGroupSequencePlaySetting>(playSettingsLength);
				for (int i = 0; i < playSettingsLength; i++)
				{
					this._PlaySettingsCache.Add(INpcGroupSequencePlaySetting.Create(this.Instance.PlaySettings(i)));
				}
				return this._PlaySettingsCache;
			}
		}

		// Token: 0x17004F5F RID: 20319
		// (get) Token: 0x0600FD5C RID: 64860 RVA: 0x0024964D File Offset: 0x0024784D
		public virtual INpcGroupSequenceStaticEntityBinding Binding
		{
			get
			{
				if (this._BindingInited)
				{
					return this._BindingCache;
				}
				this._BindingInited = true;
				this._BindingCache = INpcGroupSequenceStaticEntityBinding.Create(this.Instance.Binding);
				return this._BindingCache;
			}
		}

		// Token: 0x17004F60 RID: 20320
		// (get) Token: 0x0600FD5D RID: 64861 RVA: 0x00249684 File Offset: 0x00247884
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<INpcGroupSequenceBlendAnim> BlendOutAnim
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._BlendOutAnimInited)
				{
					return this._BlendOutAnimCache;
				}
				this._BlendOutAnimInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int blendOutAnimLength = this.Instance.BlendOutAnimLength;
				this._BlendOutAnimCache = new List<INpcGroupSequenceBlendAnim>(blendOutAnimLength);
				for (int i = 0; i < blendOutAnimLength; i++)
				{
					this._BlendOutAnimCache.Add(INpcGroupSequenceBlendAnim.Create(this.Instance.BlendOutAnim(i)));
				}
				return this._BlendOutAnimCache;
			}
		}

		// Token: 0x04008A47 RID: 35399
		private ISetNpcSequencePerform Instance;

		// Token: 0x04008A48 RID: 35400
		private List<INpcGroupSequencePlaySetting> _PlaySettingsCache;

		// Token: 0x04008A49 RID: 35401
		private bool _PlaySettingsInited;

		// Token: 0x04008A4A RID: 35402
		[Nullable(2)]
		private INpcGroupSequenceStaticEntityBinding _BindingCache;

		// Token: 0x04008A4B RID: 35403
		private bool _BindingInited;

		// Token: 0x04008A4C RID: 35404
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<INpcGroupSequenceBlendAnim> _BlendOutAnimCache;

		// Token: 0x04008A4D RID: 35405
		private bool _BlendOutAnimInited;
	}
}
