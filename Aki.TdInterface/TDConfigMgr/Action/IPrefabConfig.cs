using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F53 RID: 8019
	public class IPrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600AAA3 RID: 43683 RVA: 0x00182C98 File Offset: 0x00180E98
		private IPrefabConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPrefabConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPrefabConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPrefabConfig_SetValue());
			}
			return result;
		}

		// Token: 0x0600AAA4 RID: 43684 RVA: 0x00182CD0 File Offset: 0x00180ED0
		public static IPrefabConfig Create([Nullable(2)] IPrefabConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPrefabConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AAA5 RID: 43685 RVA: 0x00182CE3 File Offset: 0x00180EE3
		public static IPrefabConfig CreateFromSetValue([Nullable(2)] IPrefabConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPrefabConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AAA6 RID: 43686 RVA: 0x00182CF6 File Offset: 0x00180EF6
		public new IPrefabConfig_SetValue ToSetValue()
		{
			return new IPrefabConfig_SetValue
			{
				Type = this.Type,
				PrefabId = this.PrefabId
			};
		}

		// Token: 0x17003463 RID: 13411
		// (get) Token: 0x0600AAA7 RID: 43687 RVA: 0x00182D15 File Offset: 0x00180F15
		// (set) Token: 0x0600AAA8 RID: 43688 RVA: 0x00182D40 File Offset: 0x00180F40
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

		// Token: 0x17003464 RID: 13412
		// (get) Token: 0x0600AAA9 RID: 43689 RVA: 0x00182D4E File Offset: 0x00180F4E
		// (set) Token: 0x0600AAAA RID: 43690 RVA: 0x00182D79 File Offset: 0x00180F79
		public virtual int PrefabId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PrefabId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.PrefabId;
			}
			set
			{
				this.GetOrCreatePoco().PrefabId = value;
			}
		}

		// Token: 0x04006650 RID: 26192
		[Nullable(2)]
		protected new IPrefabConfig FbInstance;

		// Token: 0x04006651 RID: 26193
		[Nullable(2)]
		protected new IPrefabConfig_SetValue PocoInterface;
	}
}
