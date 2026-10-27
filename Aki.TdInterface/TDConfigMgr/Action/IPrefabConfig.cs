using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D42 RID: 7490
	[NullableContext(1)]
	[Nullable(0)]
	public class IPrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600A0B7 RID: 41143 RVA: 0x0016E874 File Offset: 0x0016CA74
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

		// Token: 0x0600A0B8 RID: 41144 RVA: 0x0016E8AC File Offset: 0x0016CAAC
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

		// Token: 0x0600A0B9 RID: 41145 RVA: 0x0016E8BF File Offset: 0x0016CABF
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

		// Token: 0x0600A0BA RID: 41146 RVA: 0x0016E8D2 File Offset: 0x0016CAD2
		public new IPrefabConfig_SetValue ToSetValue()
		{
			return new IPrefabConfig_SetValue
			{
				Type = this.Type,
				PrefabId = this.PrefabId
			};
		}

		// Token: 0x170031CF RID: 12751
		// (get) Token: 0x0600A0BB RID: 41147 RVA: 0x0016E8F1 File Offset: 0x0016CAF1
		// (set) Token: 0x0600A0BC RID: 41148 RVA: 0x0016E91C File Offset: 0x0016CB1C
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

		// Token: 0x170031D0 RID: 12752
		// (get) Token: 0x0600A0BD RID: 41149 RVA: 0x0016E92A File Offset: 0x0016CB2A
		// (set) Token: 0x0600A0BE RID: 41150 RVA: 0x0016E955 File Offset: 0x0016CB55
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

		// Token: 0x040060D4 RID: 24788
		[Nullable(2)]
		protected new IPrefabConfig FbInstance;

		// Token: 0x040060D5 RID: 24789
		[Nullable(2)]
		protected new IPrefabConfig_SetValue PocoInterface;
	}
}
