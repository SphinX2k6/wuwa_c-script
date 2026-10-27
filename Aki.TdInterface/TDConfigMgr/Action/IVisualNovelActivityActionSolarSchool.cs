using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002057 RID: 8279
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelActivityActionSolarSchool : IVisualNovelActivityActionConfigBase
	{
		// Token: 0x0600B5EE RID: 46574 RVA: 0x001A61C8 File Offset: 0x001A43C8
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

		// Token: 0x0600B5EF RID: 46575 RVA: 0x001A6200 File Offset: 0x001A4400
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

		// Token: 0x0600B5F0 RID: 46576 RVA: 0x001A6213 File Offset: 0x001A4413
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

		// Token: 0x0600B5F1 RID: 46577 RVA: 0x001A6226 File Offset: 0x001A4426
		public new IVisualNovelActivityActionSolarSchool_SetValue ToSetValue()
		{
			return new IVisualNovelActivityActionSolarSchool_SetValue
			{
				Type = this.Type,
				SolarSchoolActionId = this.SolarSchoolActionId
			};
		}

		// Token: 0x170037CD RID: 14285
		// (get) Token: 0x0600B5F2 RID: 46578 RVA: 0x001A6245 File Offset: 0x001A4445
		// (set) Token: 0x0600B5F3 RID: 46579 RVA: 0x001A6270 File Offset: 0x001A4470
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

		// Token: 0x170037CE RID: 14286
		// (get) Token: 0x0600B5F4 RID: 46580 RVA: 0x001A627E File Offset: 0x001A447E
		// (set) Token: 0x0600B5F5 RID: 46581 RVA: 0x001A62A9 File Offset: 0x001A44A9
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

		// Token: 0x04006D60 RID: 28000
		[Nullable(2)]
		protected new IVisualNovelActivityActionSolarSchool FbInstance;

		// Token: 0x04006D61 RID: 28001
		[Nullable(2)]
		protected new IVisualNovelActivityActionSolarSchool_SetValue PocoInterface;
	}
}
