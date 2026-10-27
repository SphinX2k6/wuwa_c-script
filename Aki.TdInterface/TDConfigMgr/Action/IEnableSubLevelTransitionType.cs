using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019F2 RID: 6642
	[NullableContext(1)]
	[Nullable(0)]
	public class IEnableSubLevelTransitionType
	{
		// Token: 0x06008E4F RID: 36431 RVA: 0x0014CF64 File Offset: 0x0014B164
		private IEnableSubLevelTransitionType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IEnableSubLevelTransitionType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IEnableSubLevelTransitionType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IEnableSubLevelTransitionType_SetValue());
			}
			return result;
		}

		// Token: 0x06008E50 RID: 36432 RVA: 0x0014CF9C File Offset: 0x0014B19C
		public static IEnableSubLevelTransitionType Create([Nullable(2)] IEnableSubLevelTransitionType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IEnableSubLevelTransitionType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008E51 RID: 36433 RVA: 0x0014CFAF File Offset: 0x0014B1AF
		public static IEnableSubLevelTransitionType CreateFromSetValue([Nullable(2)] IEnableSubLevelTransitionType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IEnableSubLevelTransitionType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008E52 RID: 36434 RVA: 0x0014CFC2 File Offset: 0x0014B1C2
		public IEnableSubLevelTransitionType_SetValue ToSetValue()
		{
			return new IEnableSubLevelTransitionType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D91 RID: 11665
		// (get) Token: 0x06008E53 RID: 36435 RVA: 0x0014CFD5 File Offset: 0x0014B1D5
		// (set) Token: 0x06008E54 RID: 36436 RVA: 0x0014D000 File Offset: 0x0014B200
		public virtual EEnableSubLevelTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEnableSubLevelTransitionType.SceneCapture;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400583E RID: 22590
		[Nullable(2)]
		protected IEnableSubLevelTransitionType FbInstance;

		// Token: 0x0400583F RID: 22591
		[Nullable(2)]
		protected IEnableSubLevelTransitionType_SetValue PocoInterface;
	}
}
