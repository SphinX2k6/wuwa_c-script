using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200180C RID: 6156
	[NullableContext(1)]
	[Nullable(0)]
	public class IBlendAnimTargetBase
	{
		// Token: 0x06008425 RID: 33829 RVA: 0x0013B01C File Offset: 0x0013921C
		private IBlendAnimTargetBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IBlendAnimTargetBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IBlendAnimTargetBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IBlendAnimTargetBase_SetValue());
			}
			return result;
		}

		// Token: 0x06008426 RID: 33830 RVA: 0x0013B054 File Offset: 0x00139254
		public static IBlendAnimTargetBase Create([Nullable(2)] IBlendAnimTargetBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IBlendAnimTargetBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008427 RID: 33831 RVA: 0x0013B067 File Offset: 0x00139267
		public static IBlendAnimTargetBase CreateFromSetValue([Nullable(2)] IBlendAnimTargetBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IBlendAnimTargetBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008428 RID: 33832 RVA: 0x0013B07A File Offset: 0x0013927A
		public IBlendAnimTargetBase_SetValue ToSetValue()
		{
			return new IBlendAnimTargetBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002B55 RID: 11093
		// (get) Token: 0x06008429 RID: 33833 RVA: 0x0013B08D File Offset: 0x0013928D
		// (set) Token: 0x0600842A RID: 33834 RVA: 0x0013B0B8 File Offset: 0x001392B8
		public virtual EBlendAnimTarget Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBlendAnimTarget.Player;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040053B0 RID: 21424
		[Nullable(2)]
		protected IBlendAnimTargetBase FbInstance;

		// Token: 0x040053B1 RID: 21425
		[Nullable(2)]
		protected IBlendAnimTargetBase_SetValue PocoInterface;
	}
}
