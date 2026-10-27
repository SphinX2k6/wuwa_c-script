using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AFD RID: 6909
	[NullableContext(1)]
	[Nullable(0)]
	public class IHideHighlightExploreSkillIcon : ToggleHighlightExploreUi
	{
		// Token: 0x060093F6 RID: 37878 RVA: 0x00156F88 File Offset: 0x00155188
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

		// Token: 0x060093F7 RID: 37879 RVA: 0x00156FC0 File Offset: 0x001551C0
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

		// Token: 0x060093F8 RID: 37880 RVA: 0x00156FD3 File Offset: 0x001551D3
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

		// Token: 0x060093F9 RID: 37881 RVA: 0x00156FE6 File Offset: 0x001551E6
		public new IHideHighlightExploreSkillIcon_SetValue ToSetValue()
		{
			return new IHideHighlightExploreSkillIcon_SetValue
			{
				Type = this.Type,
				HighlightType = this.HighlightType
			};
		}

		// Token: 0x17002ED5 RID: 11989
		// (get) Token: 0x060093FA RID: 37882 RVA: 0x00157005 File Offset: 0x00155205
		// (set) Token: 0x060093FB RID: 37883 RVA: 0x00157030 File Offset: 0x00155230
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

		// Token: 0x17002ED6 RID: 11990
		// (get) Token: 0x060093FC RID: 37884 RVA: 0x00157040 File Offset: 0x00155240
		// (set) Token: 0x060093FD RID: 37885 RVA: 0x0015707A File Offset: 0x0015527A
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

		// Token: 0x04005AD0 RID: 23248
		[Nullable(2)]
		protected new IHideHighlightExploreSkillIcon FbInstance;

		// Token: 0x04005AD1 RID: 23249
		[Nullable(2)]
		protected new IHideHighlightExploreSkillIcon_SetValue PocoInterface;
	}
}
