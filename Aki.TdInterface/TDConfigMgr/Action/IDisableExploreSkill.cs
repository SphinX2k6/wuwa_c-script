using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019AC RID: 6572
	[NullableContext(2)]
	[Nullable(0)]
	[JsonConverter(typeof(IDisableExploreSkillConverter))]
	public class IDisableExploreSkill
	{
		// Token: 0x06008CB1 RID: 36017 RVA: 0x0014A050 File Offset: 0x00148250
		[NullableContext(1)]
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

		// Token: 0x06008CB2 RID: 36018 RVA: 0x0014A088 File Offset: 0x00148288
		[NullableContext(1)]
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

		// Token: 0x06008CB3 RID: 36019 RVA: 0x0014A09B File Offset: 0x0014829B
		[NullableContext(1)]
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

		// Token: 0x06008CB4 RID: 36020 RVA: 0x0014A0AE File Offset: 0x001482AE
		[NullableContext(1)]
		public IDisableExploreSkill_SetValue ToSetValue()
		{
			return new IDisableExploreSkill_SetValue
			{
				PlaceTemporaryTeleport = this.PlaceTemporaryTeleport,
				IsComplementary = this.IsComplementary,
				ExploreSkillList = this.ExploreSkillList
			};
		}

		// Token: 0x17002D2B RID: 11563
		// (get) Token: 0x06008CB5 RID: 36021 RVA: 0x0014A0DC File Offset: 0x001482DC
		// (set) Token: 0x06008CB6 RID: 36022 RVA: 0x0014A116 File Offset: 0x00148316
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

		// Token: 0x17002D2C RID: 11564
		// (get) Token: 0x06008CB7 RID: 36023 RVA: 0x0014A124 File Offset: 0x00148324
		// (set) Token: 0x06008CB8 RID: 36024 RVA: 0x0014A15E File Offset: 0x0014835E
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

		// Token: 0x17002D2D RID: 11565
		// (get) Token: 0x06008CB9 RID: 36025 RVA: 0x0014A16C File Offset: 0x0014836C
		// (set) Token: 0x06008CBA RID: 36026 RVA: 0x0014A193 File Offset: 0x00148393
		public virtual List<EExploreSkillType> ExploreSkillList
		{
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
			set
			{
				this.GetOrCreatePoco().ExploreSkillList = value;
			}
		}

		// Token: 0x04005788 RID: 22408
		protected IDisableExploreSkill FbInstance;

		// Token: 0x04005789 RID: 22409
		protected IDisableExploreSkill_SetValue PocoInterface;
	}
}
