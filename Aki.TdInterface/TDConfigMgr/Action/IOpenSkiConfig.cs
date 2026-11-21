using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EB3 RID: 7859
	public class IOpenSkiConfig : ISkiConfigType
	{
		// Token: 0x0600A737 RID: 42807 RVA: 0x0017C8FC File Offset: 0x0017AAFC
		private IOpenSkiConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IOpenSkiConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IOpenSkiConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IOpenSkiConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600A738 RID: 42808 RVA: 0x0017C934 File Offset: 0x0017AB34
		public static IOpenSkiConfig Create([Nullable(2)] IOpenSkiConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IOpenSkiConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A739 RID: 42809 RVA: 0x0017C947 File Offset: 0x0017AB47
		public static IOpenSkiConfig CreateFromSetValue([Nullable(2)] IOpenSkiConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IOpenSkiConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A73A RID: 42810 RVA: 0x0017C95A File Offset: 0x0017AB5A
		public new IOpenSkiConfig_SetValue ToSetValue()
		{
			return new IOpenSkiConfig_SetValue
			{
				Type = this.Type,
				Target = this.Target,
				SkiConfig = this.SkiConfig
			};
		}

		// Token: 0x1700339D RID: 13213
		// (get) Token: 0x0600A73B RID: 42811 RVA: 0x0017C985 File Offset: 0x0017AB85
		// (set) Token: 0x0600A73C RID: 42812 RVA: 0x0017C9B0 File Offset: 0x0017ABB0
		public override ESkiConfig Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESkiConfig.Open;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700339E RID: 13214
		// (get) Token: 0x0600A73D RID: 42813 RVA: 0x0017C9BE File Offset: 0x0017ABBE
		// (set) Token: 0x0600A73E RID: 42814 RVA: 0x0017C9E5 File Offset: 0x0017ABE5
		public override ITargetEntityType Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				IOpenSkiConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Target;
			}
			set
			{
				this.GetOrCreatePoco().Target = value;
			}
		}

		// Token: 0x1700339F RID: 13215
		// (get) Token: 0x0600A73F RID: 42815 RVA: 0x0017C9F3 File Offset: 0x0017ABF3
		// (set) Token: 0x0600A740 RID: 42816 RVA: 0x0017CA1E File Offset: 0x0017AC1E
		public virtual string SkiConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkiConfig;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SkiConfig;
			}
			set
			{
				this.GetOrCreatePoco().SkiConfig = value;
			}
		}

		// Token: 0x040064BA RID: 25786
		[Nullable(2)]
		protected new IOpenSkiConfig FbInstance;

		// Token: 0x040064BB RID: 25787
		[Nullable(2)]
		protected new IOpenSkiConfig_SetValue PocoInterface;
	}
}
