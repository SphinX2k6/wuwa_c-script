using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B33 RID: 6963
	[JsonConverter(typeof(IDisableExploreSkillConverter))]
	public class IDisableExploreSkill
	{
		// Token: 0x060093D5 RID: 37845 RVA: 0x00159860 File Offset: 0x00157A60
		private IDisableExploreSkill_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableExploreSkill 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableExploreSkill_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableExploreSkill_SetValue());
			}
			return result;
		}

		// Token: 0x060093D6 RID: 37846 RVA: 0x00159898 File Offset: 0x00157A98
		public static IDisableExploreSkill Create([Nullable(2)] IDisableExploreSkill instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableExploreSkill
			{
				FbInstance = instance
			};
		}

		// Token: 0x060093D7 RID: 37847 RVA: 0x001598AB File Offset: 0x00157AAB
		public static IDisableExploreSkill CreateFromSetValue([Nullable(2)] IDisableExploreSkill_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableExploreSkill
			{
				PocoInterface = value
			};
		}

		// Token: 0x060093D8 RID: 37848 RVA: 0x001598BE File Offset: 0x00157ABE
		public IDisableExploreSkill_SetValue ToSetValue()
		{
			return new IDisableExploreSkill_SetValue
			{
				PlaceTemporaryTeleport = this.PlaceTemporaryTeleport,
				IsComplementary = this.IsComplementary,
				ExploreSkillList = this.ExploreSkillList
			};
		}

		// Token: 0x17002F2A RID: 12074
		// (get) Token: 0x060093D9 RID: 37849 RVA: 0x001598EC File Offset: 0x00157AEC
		// (set) Token: 0x060093DA RID: 37850 RVA: 0x00159926 File Offset: 0x00157B26
		public virtual bool? PlaceTemporaryTeleport
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlaceTemporaryTeleport;
				}
				IDisableExploreSkill_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlaceTemporaryTeleport;
			}
			set
			{
				this.GetOrCreatePoco().PlaceTemporaryTeleport = value;
			}
		}

		// Token: 0x17002F2B RID: 12075
		// (get) Token: 0x060093DB RID: 37851 RVA: 0x00159934 File Offset: 0x00157B34
		// (set) Token: 0x060093DC RID: 37852 RVA: 0x0015996E File Offset: 0x00157B6E
		public virtual bool? IsComplementary
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsComplementary;
				}
				IDisableExploreSkill_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsComplementary;
			}
			set
			{
				this.GetOrCreatePoco().IsComplementary = value;
			}
		}

		// Token: 0x17002F2C RID: 12076
		// (get) Token: 0x060093DD RID: 37853 RVA: 0x0015997C File Offset: 0x00157B7C
		// (set) Token: 0x060093DE RID: 37854 RVA: 0x001599A3 File Offset: 0x00157BA3
		[Nullable(2)]
		public virtual List<EExploreSkillType> ExploreSkillList
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ExploreSkillList;
				}
				IDisableExploreSkill_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ExploreSkillList;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().ExploreSkillList = value;
			}
		}

		// Token: 0x04005BD1 RID: 23505
		[Nullable(2)]
		protected IDisableExploreSkill FbInstance;

		// Token: 0x04005BD2 RID: 23506
		[Nullable(2)]
		protected IDisableExploreSkill_SetValue PocoInterface;
	}
}
