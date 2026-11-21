using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002053 RID: 8275
	public class ISetGlobalTimeScaleType
	{
		// Token: 0x0600AFA1 RID: 44961 RVA: 0x0018B8D0 File Offset: 0x00189AD0
		private ISetGlobalTimeScaleType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetGlobalTimeScaleType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetGlobalTimeScaleType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetGlobalTimeScaleType_SetValue());
			}
			return result;
		}

		// Token: 0x0600AFA2 RID: 44962 RVA: 0x0018B908 File Offset: 0x00189B08
		public static ISetGlobalTimeScaleType Create([Nullable(2)] ISetGlobalTimeScaleType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetGlobalTimeScaleType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AFA3 RID: 44963 RVA: 0x0018B91B File Offset: 0x00189B1B
		public static ISetGlobalTimeScaleType CreateFromSetValue([Nullable(2)] ISetGlobalTimeScaleType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetGlobalTimeScaleType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AFA4 RID: 44964 RVA: 0x0018B92E File Offset: 0x00189B2E
		public ISetGlobalTimeScaleType_SetValue ToSetValue()
		{
			return new ISetGlobalTimeScaleType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003562 RID: 13666
		// (get) Token: 0x0600AFA5 RID: 44965 RVA: 0x0018B941 File Offset: 0x00189B41
		// (set) Token: 0x0600AFA6 RID: 44966 RVA: 0x0018B96C File Offset: 0x00189B6C
		public virtual ESetTimeScaleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetTimeScaleType.Open;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400688D RID: 26765
		[Nullable(2)]
		protected ISetGlobalTimeScaleType FbInstance;

		// Token: 0x0400688E RID: 26766
		[Nullable(2)]
		protected ISetGlobalTimeScaleType_SetValue PocoInterface;
	}
}
