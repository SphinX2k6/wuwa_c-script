using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200217B RID: 8571
	public class ITalkItemDisableAutoSelectOptionGroup
	{
		// Token: 0x0600B828 RID: 47144 RVA: 0x001A310C File Offset: 0x001A130C
		private ITalkItemDisableAutoSelectOptionGroup_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkItemDisableAutoSelectOptionGroup 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkItemDisableAutoSelectOptionGroup_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkItemDisableAutoSelectOptionGroup_SetValue());
			}
			return result;
		}

		// Token: 0x0600B829 RID: 47145 RVA: 0x001A3144 File Offset: 0x001A1344
		public static ITalkItemDisableAutoSelectOptionGroup Create([Nullable(2)] ITalkItemDisableAutoSelectOptionGroup instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkItemDisableAutoSelectOptionGroup
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B82A RID: 47146 RVA: 0x001A3157 File Offset: 0x001A1357
		public static ITalkItemDisableAutoSelectOptionGroup CreateFromSetValue([Nullable(2)] ITalkItemDisableAutoSelectOptionGroup_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkItemDisableAutoSelectOptionGroup
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B82B RID: 47147 RVA: 0x001A316A File Offset: 0x001A136A
		public ITalkItemDisableAutoSelectOptionGroup_SetValue ToSetValue()
		{
			return new ITalkItemDisableAutoSelectOptionGroup_SetValue
			{
				TextKey = this.TextKey,
				IconId = this.IconId
			};
		}

		// Token: 0x170037EB RID: 14315
		// (get) Token: 0x0600B82C RID: 47148 RVA: 0x001A3189 File Offset: 0x001A1389
		// (set) Token: 0x0600B82D RID: 47149 RVA: 0x001A31B0 File Offset: 0x001A13B0
		[Nullable(2)]
		public virtual string TextKey
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TextKey;
				}
				ITalkItemDisableAutoSelectOptionGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TextKey;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().TextKey = value;
			}
		}

		// Token: 0x170037EC RID: 14316
		// (get) Token: 0x0600B82E RID: 47150 RVA: 0x001A31C0 File Offset: 0x001A13C0
		// (set) Token: 0x0600B82F RID: 47151 RVA: 0x001A31FA File Offset: 0x001A13FA
		public virtual int? IconId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IconId;
				}
				ITalkItemDisableAutoSelectOptionGroup_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IconId;
			}
			set
			{
				this.GetOrCreatePoco().IconId = value;
			}
		}

		// Token: 0x04006DD8 RID: 28120
		[Nullable(2)]
		protected ITalkItemDisableAutoSelectOptionGroup FbInstance;

		// Token: 0x04006DD9 RID: 28121
		[Nullable(2)]
		protected ITalkItemDisableAutoSelectOptionGroup_SetValue PocoInterface;
	}
}
