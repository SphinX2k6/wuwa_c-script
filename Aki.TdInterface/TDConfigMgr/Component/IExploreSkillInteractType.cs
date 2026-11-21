using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000398 RID: 920
	public class IExploreSkillInteractType
	{
		// Token: 0x06001218 RID: 4632 RVA: 0x0003CF78 File Offset: 0x0003B178
		private IExploreSkillInteractType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IExploreSkillInteractType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IExploreSkillInteractType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IExploreSkillInteractType_SetValue());
			}
			return result;
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x0003CFB0 File Offset: 0x0003B1B0
		public static IExploreSkillInteractType Create([Nullable(2)] IExploreSkillInteractType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IExploreSkillInteractType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600121A RID: 4634 RVA: 0x0003CFC3 File Offset: 0x0003B1C3
		public static IExploreSkillInteractType CreateFromSetValue([Nullable(2)] IExploreSkillInteractType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IExploreSkillInteractType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600121B RID: 4635 RVA: 0x0003CFD6 File Offset: 0x0003B1D6
		public IExploreSkillInteractType_SetValue ToSetValue()
		{
			return new IExploreSkillInteractType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x0600121C RID: 4636 RVA: 0x0003CFE9 File Offset: 0x0003B1E9
		// (set) Token: 0x0600121D RID: 4637 RVA: 0x0003D014 File Offset: 0x0003B214
		public virtual EExploreSkillInteractType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EExploreSkillInteractType.PullGiant;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000F04 RID: 3844
		[Nullable(2)]
		protected IExploreSkillInteractType FbInstance;

		// Token: 0x04000F05 RID: 3845
		[Nullable(2)]
		protected IExploreSkillInteractType_SetValue PocoInterface;
	}
}
