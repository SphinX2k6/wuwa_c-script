using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200206B RID: 8299
	public class ISetNpcSequencePerform : ISetNpcGroupPerformType
	{
		// Token: 0x0600B027 RID: 45095 RVA: 0x0018C818 File Offset: 0x0018AA18
		private ISetNpcSequencePerform_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetNpcSequencePerform 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetNpcSequencePerform_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetNpcSequencePerform_SetValue());
			}
			return result;
		}

		// Token: 0x0600B028 RID: 45096 RVA: 0x0018C850 File Offset: 0x0018AA50
		public static ISetNpcSequencePerform Create([Nullable(2)] ISetNpcSequencePerform instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetNpcSequencePerform
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B029 RID: 45097 RVA: 0x0018C863 File Offset: 0x0018AA63
		public static ISetNpcSequencePerform CreateFromSetValue([Nullable(2)] ISetNpcSequencePerform_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetNpcSequencePerform
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B02A RID: 45098 RVA: 0x0018C878 File Offset: 0x0018AA78
		public new ISetNpcSequencePerform_SetValue ToSetValue()
		{
			return new ISetNpcSequencePerform_SetValue
			{
				Type = this.Type,
				Sequence = this.Sequence,
				PlaySettings = this.PlaySettings,
				Binding = this.Binding,
				BlendOutAnim = this.BlendOutAnim
			};
		}

		// Token: 0x17003581 RID: 13697
		// (get) Token: 0x0600B02B RID: 45099 RVA: 0x0018C8C6 File Offset: 0x0018AAC6
		// (set) Token: 0x0600B02C RID: 45100 RVA: 0x0018C8F1 File Offset: 0x0018AAF1
		public override ENpcGroupPerformType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcGroupPerformType.HandInHand;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003582 RID: 13698
		// (get) Token: 0x0600B02D RID: 45101 RVA: 0x0018C8FF File Offset: 0x0018AAFF
		// (set) Token: 0x0600B02E RID: 45102 RVA: 0x0018C92A File Offset: 0x0018AB2A
		public virtual string Sequence
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Sequence;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Sequence;
			}
			set
			{
				this.GetOrCreatePoco().Sequence = value;
			}
		}

		// Token: 0x17003583 RID: 13699
		// (get) Token: 0x0600B02F RID: 45103 RVA: 0x0018C938 File Offset: 0x0018AB38
		// (set) Token: 0x0600B030 RID: 45104 RVA: 0x0018C9CB File Offset: 0x0018ABCB
		public virtual List<INpcGroupSequencePlaySetting> PlaySettings
		{
			get
			{
				if (this._PlaySettingsInited)
				{
					return this._PlaySettingsCache;
				}
				this._PlaySettingsInited = true;
				if (this.FbInstance != null)
				{
					List<INpcGroupSequencePlaySetting> playSettings = this.FbInstance.PlaySettings;
					if (playSettings != null)
					{
						this._PlaySettingsCache = new List<INpcGroupSequencePlaySetting>(playSettings.Count);
						for (int i = 0; i < playSettings.Count; i++)
						{
							this._PlaySettingsCache.Add(INpcGroupSequencePlaySetting.Create(playSettings[i]));
						}
					}
				}
				else
				{
					ISetNpcSequencePerform_SetValue pocoInterface = this.PocoInterface;
					this._PlaySettingsCache = ((pocoInterface != null) ? pocoInterface.PlaySettings : null);
				}
				return this._PlaySettingsCache;
			}
			set
			{
				this.GetOrCreatePoco().PlaySettings = value;
				this._PlaySettingsInited = false;
			}
		}

		// Token: 0x17003584 RID: 13700
		// (get) Token: 0x0600B031 RID: 45105 RVA: 0x0018C9E0 File Offset: 0x0018ABE0
		// (set) Token: 0x0600B032 RID: 45106 RVA: 0x0018CA41 File Offset: 0x0018AC41
		public virtual INpcGroupSequenceStaticEntityBinding Binding
		{
			get
			{
				if (this._BindingInited)
				{
					return this._BindingCache;
				}
				this._BindingInited = true;
				if (this.FbInstance != null)
				{
					this._BindingCache = INpcGroupSequenceStaticEntityBinding.Create(this.FbInstance.Binding);
				}
				else
				{
					ISetNpcSequencePerform_SetValue pocoInterface = this.PocoInterface;
					this._BindingCache = ((pocoInterface != null) ? pocoInterface.Binding : null);
				}
				return this._BindingCache;
			}
			set
			{
				this.GetOrCreatePoco().Binding = value;
				this._BindingInited = false;
			}
		}

		// Token: 0x17003585 RID: 13701
		// (get) Token: 0x0600B033 RID: 45107 RVA: 0x0018CA58 File Offset: 0x0018AC58
		// (set) Token: 0x0600B034 RID: 45108 RVA: 0x0018CAEB File Offset: 0x0018ACEB
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
				if (this.FbInstance != null)
				{
					List<INpcGroupSequenceBlendAnim> blendOutAnim = this.FbInstance.BlendOutAnim;
					if (blendOutAnim != null)
					{
						this._BlendOutAnimCache = new List<INpcGroupSequenceBlendAnim>(blendOutAnim.Count);
						for (int i = 0; i < blendOutAnim.Count; i++)
						{
							this._BlendOutAnimCache.Add(INpcGroupSequenceBlendAnim.Create(blendOutAnim[i]));
						}
					}
				}
				else
				{
					ISetNpcSequencePerform_SetValue pocoInterface = this.PocoInterface;
					this._BlendOutAnimCache = ((pocoInterface != null) ? pocoInterface.BlendOutAnim : null);
				}
				return this._BlendOutAnimCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().BlendOutAnim = value;
				this._BlendOutAnimInited = false;
			}
		}

		// Token: 0x040068CC RID: 26828
		[Nullable(2)]
		protected new ISetNpcSequencePerform FbInstance;

		// Token: 0x040068CD RID: 26829
		[Nullable(2)]
		protected new ISetNpcSequencePerform_SetValue PocoInterface;

		// Token: 0x040068CE RID: 26830
		private List<INpcGroupSequencePlaySetting> _PlaySettingsCache;

		// Token: 0x040068CF RID: 26831
		private bool _PlaySettingsInited;

		// Token: 0x040068D0 RID: 26832
		private INpcGroupSequenceStaticEntityBinding _BindingCache;

		// Token: 0x040068D1 RID: 26833
		private bool _BindingInited;

		// Token: 0x040068D2 RID: 26834
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<INpcGroupSequenceBlendAnim> _BlendOutAnimCache;

		// Token: 0x040068D3 RID: 26835
		private bool _BlendOutAnimInited;
	}
}
