using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200034F RID: 847
	[NullableContext(1)]
	[Nullable(0)]
	public class IExploreSkillInteractType
	{
		// Token: 0x060010D4 RID: 4308 RVA: 0x00039CAC File Offset: 0x00037EAC
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

		// Token: 0x060010D5 RID: 4309 RVA: 0x00039CE4 File Offset: 0x00037EE4
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

		// Token: 0x060010D6 RID: 4310 RVA: 0x00039CF7 File Offset: 0x00037EF7
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

		// Token: 0x060010D7 RID: 4311 RVA: 0x00039D0A File Offset: 0x00037F0A
		public IExploreSkillInteractType_SetValue ToSetValue()
		{
			return new IExploreSkillInteractType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x060010D8 RID: 4312 RVA: 0x00039D1D File Offset: 0x00037F1D
		// (set) Token: 0x060010D9 RID: 4313 RVA: 0x00039D48 File Offset: 0x00037F48
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

		// Token: 0x04000E0D RID: 3597
		[Nullable(2)]
		protected IExploreSkillInteractType FbInstance;

		// Token: 0x04000E0E RID: 3598
		[Nullable(2)]
		protected IExploreSkillInteractType_SetValue PocoInterface;
	}
}
