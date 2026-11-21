using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CAC RID: 7340
	public class IHideHighlightExploreSkillIconTargetConfig
	{
		// Token: 0x06009BE0 RID: 39904 RVA: 0x00167C64 File Offset: 0x00165E64
		private IHideHighlightExploreSkillIconTargetConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHideHighlightExploreSkillIconTargetConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHideHighlightExploreSkillIconTargetConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHideHighlightExploreSkillIconTargetConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06009BE1 RID: 39905 RVA: 0x00167C9C File Offset: 0x00165E9C
		public static IHideHighlightExploreSkillIconTargetConfig Create([Nullable(2)] IHideHighlightExploreSkillIconTargetConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideHighlightExploreSkillIconTargetConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009BE2 RID: 39906 RVA: 0x00167CAF File Offset: 0x00165EAF
		public static IHideHighlightExploreSkillIconTargetConfig CreateFromSetValue([Nullable(2)] IHideHighlightExploreSkillIconTargetConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHideHighlightExploreSkillIconTargetConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009BE3 RID: 39907 RVA: 0x00167CC2 File Offset: 0x00165EC2
		public IHideHighlightExploreSkillIconTargetConfig_SetValue ToSetValue()
		{
			return new IHideHighlightExploreSkillIconTargetConfig_SetValue
			{
				SkillType = this.SkillType,
				ItemId = this.ItemId
			};
		}

		// Token: 0x170030FB RID: 12539
		// (get) Token: 0x06009BE4 RID: 39908 RVA: 0x00167CE1 File Offset: 0x00165EE1
		// (set) Token: 0x06009BE5 RID: 39909 RVA: 0x00167D0C File Offset: 0x00165F0C
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

		// Token: 0x170030FC RID: 12540
		// (get) Token: 0x06009BE6 RID: 39910 RVA: 0x00167D1C File Offset: 0x00165F1C
		// (set) Token: 0x06009BE7 RID: 39911 RVA: 0x00167D56 File Offset: 0x00165F56
		public virtual int? ItemId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ItemId;
				}
				IHideHighlightExploreSkillIconTargetConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ItemId;
			}
			set
			{
				this.GetOrCreatePoco().ItemId = value;
			}
		}

		// Token: 0x04005F6E RID: 24430
		[Nullable(2)]
		protected IHideHighlightExploreSkillIconTargetConfig FbInstance;

		// Token: 0x04005F6F RID: 24431
		[Nullable(2)]
		protected IHideHighlightExploreSkillIconTargetConfig_SetValue PocoInterface;
	}
}
