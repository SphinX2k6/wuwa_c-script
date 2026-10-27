using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DC4 RID: 7620
	[NullableContext(1)]
	[Nullable(0)]
	public class IRoguePrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600A333 RID: 41779 RVA: 0x00172B34 File Offset: 0x00170D34
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

		// Token: 0x0600A334 RID: 41780 RVA: 0x00172B6C File Offset: 0x00170D6C
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

		// Token: 0x0600A335 RID: 41781 RVA: 0x00172B7F File Offset: 0x00170D7F
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

		// Token: 0x0600A336 RID: 41782 RVA: 0x00172B92 File Offset: 0x00170D92
		public new IRoguePrefabConfig_SetValue ToSetValue()
		{
			return new IRoguePrefabConfig_SetValue
			{
				Type = this.Type,
				Index = this.Index
			};
		}

		// Token: 0x1700324A RID: 12874
		// (get) Token: 0x0600A337 RID: 41783 RVA: 0x00172BB1 File Offset: 0x00170DB1
		// (set) Token: 0x0600A338 RID: 41784 RVA: 0x00172BDC File Offset: 0x00170DDC
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

		// Token: 0x1700324B RID: 12875
		// (get) Token: 0x0600A339 RID: 41785 RVA: 0x00172BEA File Offset: 0x00170DEA
		// (set) Token: 0x0600A33A RID: 41786 RVA: 0x00172C15 File Offset: 0x00170E15
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

		// Token: 0x040061E3 RID: 25059
		[Nullable(2)]
		protected new IRoguePrefabConfig FbInstance;

		// Token: 0x040061E4 RID: 25060
		[Nullable(2)]
		protected new IRoguePrefabConfig_SetValue PocoInterface;
	}
}
