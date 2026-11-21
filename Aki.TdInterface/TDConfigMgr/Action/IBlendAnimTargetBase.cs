using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001997 RID: 6551
	public class IBlendAnimTargetBase
	{
		// Token: 0x06008B49 RID: 35657 RVA: 0x0014A7C0 File Offset: 0x001489C0
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

		// Token: 0x06008B4A RID: 35658 RVA: 0x0014A7F8 File Offset: 0x001489F8
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

		// Token: 0x06008B4B RID: 35659 RVA: 0x0014A80B File Offset: 0x00148A0B
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

		// Token: 0x06008B4C RID: 35660 RVA: 0x0014A81E File Offset: 0x00148A1E
		public IBlendAnimTargetBase_SetValue ToSetValue()
		{
			return new IBlendAnimTargetBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D4E RID: 11598
		// (get) Token: 0x06008B4D RID: 35661 RVA: 0x0014A831 File Offset: 0x00148A31
		// (set) Token: 0x06008B4E RID: 35662 RVA: 0x0014A85C File Offset: 0x00148A5C
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

		// Token: 0x040057FB RID: 22523
		[Nullable(2)]
		protected IBlendAnimTargetBase FbInstance;

		// Token: 0x040057FC RID: 22524
		[Nullable(2)]
		protected IBlendAnimTargetBase_SetValue PocoInterface;
	}
}
