using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E79 RID: 7801
	[NullableContext(1)]
	[Nullable(0)]
	public class ISkiConfigType
	{
		// Token: 0x0600A6F4 RID: 42740 RVA: 0x001799E8 File Offset: 0x00177BE8
		private ISkiConfigType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISkiConfigType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISkiConfigType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISkiConfigType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A6F5 RID: 42741 RVA: 0x00179A20 File Offset: 0x00177C20
		public static ISkiConfigType Create([Nullable(2)] ISkiConfigType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISkiConfigType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A6F6 RID: 42742 RVA: 0x00179A33 File Offset: 0x00177C33
		public static ISkiConfigType CreateFromSetValue([Nullable(2)] ISkiConfigType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISkiConfigType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A6F7 RID: 42743 RVA: 0x00179A46 File Offset: 0x00177C46
		public ISkiConfigType_SetValue ToSetValue()
		{
			return new ISkiConfigType_SetValue
			{
				Type = this.Type,
				Target = this.Target
			};
		}

		// Token: 0x1700331C RID: 13084
		// (get) Token: 0x0600A6F8 RID: 42744 RVA: 0x00179A65 File Offset: 0x00177C65
		// (set) Token: 0x0600A6F9 RID: 42745 RVA: 0x00179A90 File Offset: 0x00177C90
		public virtual ESkiConfig Type
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

		// Token: 0x1700331D RID: 13085
		// (get) Token: 0x0600A6FA RID: 42746 RVA: 0x00179A9E File Offset: 0x00177C9E
		// (set) Token: 0x0600A6FB RID: 42747 RVA: 0x00179AC5 File Offset: 0x00177CC5
		public virtual ITargetEntityType Target
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Target;
				}
				ISkiConfigType_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040063AB RID: 25515
		[Nullable(2)]
		protected ISkiConfigType FbInstance;

		// Token: 0x040063AC RID: 25516
		[Nullable(2)]
		protected ISkiConfigType_SetValue PocoInterface;
	}
}
