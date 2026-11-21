using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CAA RID: 7338
	public class IHideHighlightExploreSkillIcon : ToggleHighlightExploreUi
	{
		// Token: 0x06009BD4 RID: 39892 RVA: 0x00167AD0 File Offset: 0x00165CD0
		private IHideHighlightExploreSkillIcon_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHideHighlightExploreSkillIcon 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHideHighlightExploreSkillIcon_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHideHighlightExploreSkillIcon_SetValue());
			}
			return result;
		}

		// Token: 0x06009BD5 RID: 39893 RVA: 0x00167B08 File Offset: 0x00165D08
		public static IHideHighlightExploreSkillIcon Create([Nullable(2)] IHideHighlightExploreSkillIcon instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideHighlightExploreSkillIcon
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009BD6 RID: 39894 RVA: 0x00167B1B File Offset: 0x00165D1B
		public static IHideHighlightExploreSkillIcon CreateFromSetValue([Nullable(2)] IHideHighlightExploreSkillIcon_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHideHighlightExploreSkillIcon
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009BD7 RID: 39895 RVA: 0x00167B2E File Offset: 0x00165D2E
		public new IHideHighlightExploreSkillIcon_SetValue ToSetValue()
		{
			return new IHideHighlightExploreSkillIcon_SetValue
			{
				Type = this.Type,
				HighlightType = this.HighlightType,
				TargetConfig = this.TargetConfig
			};
		}

		// Token: 0x170030F8 RID: 12536
		// (get) Token: 0x06009BD8 RID: 39896 RVA: 0x00167B59 File Offset: 0x00165D59
		// (set) Token: 0x06009BD9 RID: 39897 RVA: 0x00167B84 File Offset: 0x00165D84
		public override EHighlightExploreSkillIconType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHighlightExploreSkillIconType.Show;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170030F9 RID: 12537
		// (get) Token: 0x06009BDA RID: 39898 RVA: 0x00167B94 File Offset: 0x00165D94
		// (set) Token: 0x06009BDB RID: 39899 RVA: 0x00167BCE File Offset: 0x00165DCE
		public override EHighlightType? HighlightType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HighlightType;
				}
				IHideHighlightExploreSkillIcon_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.HighlightType;
			}
			set
			{
				this.GetOrCreatePoco().HighlightType = value;
			}
		}

		// Token: 0x170030FA RID: 12538
		// (get) Token: 0x06009BDC RID: 39900 RVA: 0x00167BDC File Offset: 0x00165DDC
		// (set) Token: 0x06009BDD RID: 39901 RVA: 0x00167C3D File Offset: 0x00165E3D
		[Nullable(2)]
		public virtual IHideHighlightExploreSkillIconTargetConfig TargetConfig
		{
			[NullableContext(2)]
			get
			{
				if (this._TargetConfigInited)
				{
					return this._TargetConfigCache;
				}
				this._TargetConfigInited = true;
				if (this.FbInstance != null)
				{
					this._TargetConfigCache = IHideHighlightExploreSkillIconTargetConfig.Create(this.FbInstance.TargetConfig);
				}
				else
				{
					IHideHighlightExploreSkillIcon_SetValue pocoInterface = this.PocoInterface;
					this._TargetConfigCache = ((pocoInterface != null) ? pocoInterface.TargetConfig : null);
				}
				return this._TargetConfigCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TargetConfig = value;
				this._TargetConfigInited = false;
			}
		}

		// Token: 0x04005F67 RID: 24423
		[Nullable(2)]
		protected new IHideHighlightExploreSkillIcon FbInstance;

		// Token: 0x04005F68 RID: 24424
		[Nullable(2)]
		protected new IHideHighlightExploreSkillIcon_SetValue PocoInterface;

		// Token: 0x04005F69 RID: 24425
		private IHideHighlightExploreSkillIconTargetConfig _TargetConfigCache;

		// Token: 0x04005F6A RID: 24426
		private bool _TargetConfigInited;
	}
}
