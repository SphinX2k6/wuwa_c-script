using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D56 RID: 7510
	[NullableContext(1)]
	[Nullable(0)]
	public class IProgramSpecialConfigBase
	{
		// Token: 0x0600A115 RID: 41237 RVA: 0x0016F250 File Offset: 0x0016D450
		private IProgramSpecialConfigBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IProgramSpecialConfigBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IProgramSpecialConfigBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IProgramSpecialConfigBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600A116 RID: 41238 RVA: 0x0016F288 File Offset: 0x0016D488
		public static IProgramSpecialConfigBase Create([Nullable(2)] IProgramSpecialConfigBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProgramSpecialConfigBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A117 RID: 41239 RVA: 0x0016F29B File Offset: 0x0016D49B
		public static IProgramSpecialConfigBase CreateFromSetValue([Nullable(2)] IProgramSpecialConfigBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IProgramSpecialConfigBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A118 RID: 41240 RVA: 0x0016F2AE File Offset: 0x0016D4AE
		public IProgramSpecialConfigBase_SetValue ToSetValue()
		{
			return new IProgramSpecialConfigBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031E0 RID: 12768
		// (get) Token: 0x0600A119 RID: 41241 RVA: 0x0016F2C1 File Offset: 0x0016D4C1
		// (set) Token: 0x0600A11A RID: 41242 RVA: 0x0016F2EC File Offset: 0x0016D4EC
		public virtual EPlayMovieProgramSpecialConfigType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPlayMovieProgramSpecialConfigType.Mp4UiReplaceMaterial;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040060FD RID: 24829
		[Nullable(2)]
		protected IProgramSpecialConfigBase FbInstance;

		// Token: 0x040060FE RID: 24830
		[Nullable(2)]
		protected IProgramSpecialConfigBase_SetValue PocoInterface;
	}
}
