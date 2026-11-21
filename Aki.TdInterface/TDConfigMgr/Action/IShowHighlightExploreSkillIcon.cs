using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200208F RID: 8335
	public class IShowHighlightExploreSkillIcon : ToggleHighlightExploreUi
	{
		// Token: 0x0600B0FF RID: 45311 RVA: 0x0018E210 File Offset: 0x0018C410
		private IShowHighlightExploreSkillIcon_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowHighlightExploreSkillIcon 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowHighlightExploreSkillIcon_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowHighlightExploreSkillIcon_SetValue());
			}
			return result;
		}

		// Token: 0x0600B100 RID: 45312 RVA: 0x0018E248 File Offset: 0x0018C448
		public static IShowHighlightExploreSkillIcon Create([Nullable(2)] IShowHighlightExploreSkillIcon instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowHighlightExploreSkillIcon
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B101 RID: 45313 RVA: 0x0018E25B File Offset: 0x0018C45B
		public static IShowHighlightExploreSkillIcon CreateFromSetValue([Nullable(2)] IShowHighlightExploreSkillIcon_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowHighlightExploreSkillIcon
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B102 RID: 45314 RVA: 0x0018E270 File Offset: 0x0018C470
		public new IShowHighlightExploreSkillIcon_SetValue ToSetValue()
		{
			return new IShowHighlightExploreSkillIcon_SetValue
			{
				Type = this.Type,
				HighlightType = this.HighlightType,
				SkillType = this.SkillType,
				Duration = this.Duration,
				IsSwitchBack = this.IsSwitchBack
			};
		}

		// Token: 0x170035B7 RID: 13751
		// (get) Token: 0x0600B103 RID: 45315 RVA: 0x0018E2BE File Offset: 0x0018C4BE
		// (set) Token: 0x0600B104 RID: 45316 RVA: 0x0018E2E9 File Offset: 0x0018C4E9
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

		// Token: 0x170035B8 RID: 13752
		// (get) Token: 0x0600B105 RID: 45317 RVA: 0x0018E2F8 File Offset: 0x0018C4F8
		// (set) Token: 0x0600B106 RID: 45318 RVA: 0x0018E332 File Offset: 0x0018C532
		public override EHighlightType? HighlightType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.HighlightType;
				}
				IShowHighlightExploreSkillIcon_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x170035B9 RID: 13753
		// (get) Token: 0x0600B107 RID: 45319 RVA: 0x0018E340 File Offset: 0x0018C540
		// (set) Token: 0x0600B108 RID: 45320 RVA: 0x0018E36B File Offset: 0x0018C56B
		public virtual int SkillType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkillType;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SkillType;
			}
			set
			{
				this.GetOrCreatePoco().SkillType = value;
			}
		}

		// Token: 0x170035BA RID: 13754
		// (get) Token: 0x0600B109 RID: 45321 RVA: 0x0018E379 File Offset: 0x0018C579
		// (set) Token: 0x0600B10A RID: 45322 RVA: 0x0018E3A8 File Offset: 0x0018C5A8
		public virtual float Duration
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Duration;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Duration;
			}
			set
			{
				this.GetOrCreatePoco().Duration = value;
			}
		}

		// Token: 0x170035BB RID: 13755
		// (get) Token: 0x0600B10B RID: 45323 RVA: 0x0018E3B8 File Offset: 0x0018C5B8
		// (set) Token: 0x0600B10C RID: 45324 RVA: 0x0018E3F2 File Offset: 0x0018C5F2
		public virtual bool? IsSwitchBack
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsSwitchBack;
				}
				IShowHighlightExploreSkillIcon_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsSwitchBack;
			}
			set
			{
				this.GetOrCreatePoco().IsSwitchBack = value;
			}
		}

		// Token: 0x04006938 RID: 26936
		[Nullable(2)]
		protected new IShowHighlightExploreSkillIcon FbInstance;

		// Token: 0x04006939 RID: 26937
		[Nullable(2)]
		protected new IShowHighlightExploreSkillIcon_SetValue PocoInterface;
	}
}
