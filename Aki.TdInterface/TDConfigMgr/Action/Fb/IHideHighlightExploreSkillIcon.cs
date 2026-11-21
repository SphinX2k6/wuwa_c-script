using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C5C RID: 11356
	[NullableContext(2)]
	[Nullable(0)]
	public class IHideHighlightExploreSkillIcon : ToggleHighlightExploreUi
	{
		// Token: 0x0600F9AA RID: 63914 RVA: 0x002440C6 File Offset: 0x002422C6
		[NullableContext(0)]
		public static IHideHighlightExploreSkillIcon Create(IHideHighlightExploreSkillIcon? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideHighlightExploreSkillIcon
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004DA0 RID: 19872
		// (get) Token: 0x0600F9AB RID: 63915 RVA: 0x002440E5 File Offset: 0x002422E5
		public override EHighlightExploreSkillIconType Type
		{
			get
			{
				return (EHighlightExploreSkillIconType)this.Instance.Type;
			}
		}

		// Token: 0x17004DA1 RID: 19873
		// (get) Token: 0x0600F9AC RID: 63916 RVA: 0x002440F4 File Offset: 0x002422F4
		public override EHighlightType? HighlightType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EHighlightType?((EHighlightType)this.Instance.HighlightType);
			}
		}

		// Token: 0x17004DA2 RID: 19874
		// (get) Token: 0x0600F9AD RID: 63917 RVA: 0x0024412A File Offset: 0x0024232A
		public virtual IHideHighlightExploreSkillIconTargetConfig TargetConfig
		{
			get
			{
				if (this._TargetConfigInited)
				{
					return this._TargetConfigCache;
				}
				this._TargetConfigInited = true;
				this._TargetConfigCache = IHideHighlightExploreSkillIconTargetConfig.Create(this.Instance.TargetConfig);
				return this._TargetConfigCache;
			}
		}

		// Token: 0x04008870 RID: 34928
		private IHideHighlightExploreSkillIcon Instance;

		// Token: 0x04008871 RID: 34929
		private IHideHighlightExploreSkillIconTargetConfig _TargetConfigCache;

		// Token: 0x04008872 RID: 34930
		private bool _TargetConfigInited;
	}
}
