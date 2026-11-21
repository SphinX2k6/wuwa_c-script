using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022A0 RID: 8864
	public class IVisualNovelActivityActionSolarSchool : IVisualNovelActivityActionConfigBase
	{
		// Token: 0x0600C114 RID: 49428 RVA: 0x001BC934 File Offset: 0x001BAB34
		private IVisualNovelActivityActionSolarSchool_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelActivityActionSolarSchool 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelActivityActionSolarSchool_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelActivityActionSolarSchool_SetValue());
			}
			return result;
		}

		// Token: 0x0600C115 RID: 49429 RVA: 0x001BC96C File Offset: 0x001BAB6C
		public static IVisualNovelActivityActionSolarSchool Create([Nullable(2)] IVisualNovelActivityActionSolarSchool instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelActivityActionSolarSchool
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C116 RID: 49430 RVA: 0x001BC97F File Offset: 0x001BAB7F
		public static IVisualNovelActivityActionSolarSchool CreateFromSetValue([Nullable(2)] IVisualNovelActivityActionSolarSchool_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelActivityActionSolarSchool
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C117 RID: 49431 RVA: 0x001BC992 File Offset: 0x001BAB92
		public new IVisualNovelActivityActionSolarSchool_SetValue ToSetValue()
		{
			return new IVisualNovelActivityActionSolarSchool_SetValue
			{
				Type = this.Type,
				SolarSchoolActionId = this.SolarSchoolActionId
			};
		}

		// Token: 0x17003AAA RID: 15018
		// (get) Token: 0x0600C118 RID: 49432 RVA: 0x001BC9B1 File Offset: 0x001BABB1
		// (set) Token: 0x0600C119 RID: 49433 RVA: 0x001BC9DC File Offset: 0x001BABDC
		public override EVisualNovelSubType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelSubType.SolarSchool;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003AAB RID: 15019
		// (get) Token: 0x0600C11A RID: 49434 RVA: 0x001BC9EA File Offset: 0x001BABEA
		// (set) Token: 0x0600C11B RID: 49435 RVA: 0x001BCA15 File Offset: 0x001BAC15
		public virtual int SolarSchoolActionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SolarSchoolActionId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SolarSchoolActionId;
			}
			set
			{
				this.GetOrCreatePoco().SolarSchoolActionId = value;
			}
		}

		// Token: 0x04007369 RID: 29545
		[Nullable(2)]
		protected new IVisualNovelActivityActionSolarSchool FbInstance;

		// Token: 0x0400736A RID: 29546
		[Nullable(2)]
		protected new IVisualNovelActivityActionSolarSchool_SetValue PocoInterface;
	}
}
