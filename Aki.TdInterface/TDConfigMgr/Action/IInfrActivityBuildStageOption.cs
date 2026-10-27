using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B29 RID: 6953
	[NullableContext(1)]
	[Nullable(0)]
	public class IInfrActivityBuildStageOption
	{
		// Token: 0x060094D6 RID: 38102 RVA: 0x0015862C File Offset: 0x0015682C
		private IInfrActivityBuildStageOption_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInfrActivityBuildStageOption 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInfrActivityBuildStageOption_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInfrActivityBuildStageOption_SetValue());
			}
			return result;
		}

		// Token: 0x060094D7 RID: 38103 RVA: 0x00158664 File Offset: 0x00156864
		public static IInfrActivityBuildStageOption Create([Nullable(2)] IInfrActivityBuildStageOption instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInfrActivityBuildStageOption
			{
				FbInstance = instance
			};
		}

		// Token: 0x060094D8 RID: 38104 RVA: 0x00158677 File Offset: 0x00156877
		public static IInfrActivityBuildStageOption CreateFromSetValue([Nullable(2)] IInfrActivityBuildStageOption_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInfrActivityBuildStageOption
			{
				PocoInterface = value
			};
		}

		// Token: 0x060094D9 RID: 38105 RVA: 0x0015868A File Offset: 0x0015688A
		public IInfrActivityBuildStageOption_SetValue ToSetValue()
		{
			return new IInfrActivityBuildStageOption_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F03 RID: 12035
		// (get) Token: 0x060094DA RID: 38106 RVA: 0x0015869D File Offset: 0x0015689D
		// (set) Token: 0x060094DB RID: 38107 RVA: 0x001586C8 File Offset: 0x001568C8
		public virtual EInfrActivityBuildStageType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInfrActivityBuildStageType.Infrastructure;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005B2A RID: 23338
		[Nullable(2)]
		protected IInfrActivityBuildStageOption FbInstance;

		// Token: 0x04005B2B RID: 23339
		[Nullable(2)]
		protected IInfrActivityBuildStageOption_SetValue PocoInterface;
	}
}
