using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FDB RID: 8155
	public class IRoguePrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600AD3D RID: 44349 RVA: 0x0018725C File Offset: 0x0018545C
		private IRoguePrefabConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRoguePrefabConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRoguePrefabConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRoguePrefabConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600AD3E RID: 44350 RVA: 0x00187294 File Offset: 0x00185494
		public static IRoguePrefabConfig Create([Nullable(2)] IRoguePrefabConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoguePrefabConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AD3F RID: 44351 RVA: 0x001872A7 File Offset: 0x001854A7
		public static IRoguePrefabConfig CreateFromSetValue([Nullable(2)] IRoguePrefabConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRoguePrefabConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AD40 RID: 44352 RVA: 0x001872BA File Offset: 0x001854BA
		public new IRoguePrefabConfig_SetValue ToSetValue()
		{
			return new IRoguePrefabConfig_SetValue
			{
				Type = this.Type,
				Index = this.Index
			};
		}

		// Token: 0x170034E4 RID: 13540
		// (get) Token: 0x0600AD41 RID: 44353 RVA: 0x001872D9 File Offset: 0x001854D9
		// (set) Token: 0x0600AD42 RID: 44354 RVA: 0x00187304 File Offset: 0x00185504
		public override ECreatePrefabType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECreatePrefabType.PrefabId;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170034E5 RID: 13541
		// (get) Token: 0x0600AD43 RID: 44355 RVA: 0x00187312 File Offset: 0x00185512
		// (set) Token: 0x0600AD44 RID: 44356 RVA: 0x0018733D File Offset: 0x0018553D
		public virtual int Index
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Index;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Index;
			}
			set
			{
				this.GetOrCreatePoco().Index = value;
			}
		}

		// Token: 0x0400676B RID: 26475
		[Nullable(2)]
		protected new IRoguePrefabConfig FbInstance;

		// Token: 0x0400676C RID: 26476
		[Nullable(2)]
		protected new IRoguePrefabConfig_SetValue PocoInterface;
	}
}
