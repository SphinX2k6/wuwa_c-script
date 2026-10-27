using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200069E RID: 1694
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneItemAiPatrolType
	{
		// Token: 0x0600244E RID: 9294 RVA: 0x00062768 File Offset: 0x00060968
		private ISceneItemAiPatrolType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneItemAiPatrolType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneItemAiPatrolType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneItemAiPatrolType_SetValue());
			}
			return result;
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x000627A0 File Offset: 0x000609A0
		public static ISceneItemAiPatrolType Create([Nullable(2)] ISceneItemAiPatrolType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemAiPatrolType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x000627B3 File Offset: 0x000609B3
		public static ISceneItemAiPatrolType CreateFromSetValue([Nullable(2)] ISceneItemAiPatrolType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneItemAiPatrolType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002451 RID: 9297 RVA: 0x000627C6 File Offset: 0x000609C6
		public ISceneItemAiPatrolType_SetValue ToSetValue()
		{
			return new ISceneItemAiPatrolType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06002452 RID: 9298 RVA: 0x000627D9 File Offset: 0x000609D9
		// (set) Token: 0x06002453 RID: 9299 RVA: 0x00062804 File Offset: 0x00060A04
		public virtual ESceneItemAiPatrolType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneItemAiPatrolType.ByGameTime;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040018EF RID: 6383
		[Nullable(2)]
		protected ISceneItemAiPatrolType FbInstance;

		// Token: 0x040018F0 RID: 6384
		[Nullable(2)]
		protected ISceneItemAiPatrolType_SetValue PocoInterface;
	}
}
