using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002051 RID: 8273
	public class ISetGlobalTimeScale : ITimeScaleType
	{
		// Token: 0x0600AF97 RID: 44951 RVA: 0x0018B7D4 File Offset: 0x001899D4
		private ISetGlobalTimeScale_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetGlobalTimeScale 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetGlobalTimeScale_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetGlobalTimeScale_SetValue());
			}
			return result;
		}

		// Token: 0x0600AF98 RID: 44952 RVA: 0x0018B80C File Offset: 0x00189A0C
		public static ISetGlobalTimeScale Create([Nullable(2)] ISetGlobalTimeScale instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetGlobalTimeScale
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AF99 RID: 44953 RVA: 0x0018B81F File Offset: 0x00189A1F
		public static ISetGlobalTimeScale CreateFromSetValue([Nullable(2)] ISetGlobalTimeScale_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetGlobalTimeScale
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AF9A RID: 44954 RVA: 0x0018B832 File Offset: 0x00189A32
		public new ISetGlobalTimeScale_SetValue ToSetValue()
		{
			return new ISetGlobalTimeScale_SetValue
			{
				Type = this.Type,
				Config = this.Config
			};
		}

		// Token: 0x17003560 RID: 13664
		// (get) Token: 0x0600AF9B RID: 44955 RVA: 0x0018B851 File Offset: 0x00189A51
		// (set) Token: 0x0600AF9C RID: 44956 RVA: 0x0018B87C File Offset: 0x00189A7C
		public override ETimeScaleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETimeScaleType.Global;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003561 RID: 13665
		// (get) Token: 0x0600AF9D RID: 44957 RVA: 0x0018B88A File Offset: 0x00189A8A
		// (set) Token: 0x0600AF9E RID: 44958 RVA: 0x0018B8B1 File Offset: 0x00189AB1
		public virtual ISetGlobalTimeScaleType Config
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Config;
				}
				ISetGlobalTimeScale_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Config;
			}
			set
			{
				this.GetOrCreatePoco().Config = value;
			}
		}

		// Token: 0x04006889 RID: 26761
		[Nullable(2)]
		protected new ISetGlobalTimeScale FbInstance;

		// Token: 0x0400688A RID: 26762
		[Nullable(2)]
		protected new ISetGlobalTimeScale_SetValue PocoInterface;
	}
}
