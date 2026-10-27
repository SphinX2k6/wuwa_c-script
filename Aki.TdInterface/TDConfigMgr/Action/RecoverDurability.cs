using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002135 RID: 8501
	[NullableContext(1)]
	[Nullable(0)]
	public class RecoverDurability : ActionParams
	{
		// Token: 0x0600BB3C RID: 47932 RVA: 0x001B07C0 File Offset: 0x001AE9C0
		private RecoverDurability_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("RecoverDurability 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			RecoverDurability_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new RecoverDurability_SetValue());
			}
			return result;
		}

		// Token: 0x0600BB3D RID: 47933 RVA: 0x001B07F8 File Offset: 0x001AE9F8
		public static RecoverDurability Create([Nullable(2)] RecoverDurability instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new RecoverDurability
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BB3E RID: 47934 RVA: 0x001B080B File Offset: 0x001AEA0B
		public static RecoverDurability CreateFromSetValue([Nullable(2)] RecoverDurability_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new RecoverDurability
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BB3F RID: 47935 RVA: 0x001B081E File Offset: 0x001AEA1E
		public RecoverDurability_SetValue ToSetValue()
		{
			return new RecoverDurability_SetValue
			{
				EntityId = this.EntityId
			};
		}

		// Token: 0x1700392B RID: 14635
		// (get) Token: 0x0600BB40 RID: 47936 RVA: 0x001B0831 File Offset: 0x001AEA31
		// (set) Token: 0x0600BB41 RID: 47937 RVA: 0x001B085C File Offset: 0x001AEA5C
		public virtual int EntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.EntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.EntityId;
			}
			set
			{
				this.GetOrCreatePoco().EntityId = value;
			}
		}

		// Token: 0x04007002 RID: 28674
		[Nullable(2)]
		protected new RecoverDurability FbInstance;

		// Token: 0x04007003 RID: 28675
		[Nullable(2)]
		protected RecoverDurability_SetValue PocoInterface;
	}
}
