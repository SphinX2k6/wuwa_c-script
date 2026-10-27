using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F42 RID: 8002
	[NullableContext(2)]
	[Nullable(0)]
	public class ITalkItemDisableAutoSelectOptionGroup
	{
		// Token: 0x0600AD56 RID: 44374 RVA: 0x0018D114 File Offset: 0x0018B314
		[NullableContext(1)]
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

		// Token: 0x0600AD57 RID: 44375 RVA: 0x0018D14C File Offset: 0x0018B34C
		[NullableContext(1)]
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

		// Token: 0x0600AD58 RID: 44376 RVA: 0x0018D15F File Offset: 0x0018B35F
		[NullableContext(1)]
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

		// Token: 0x0600AD59 RID: 44377 RVA: 0x0018D172 File Offset: 0x0018B372
		[NullableContext(1)]
		public ITalkItemDisableAutoSelectOptionGroup_SetValue ToSetValue()
		{
			return new ITalkItemDisableAutoSelectOptionGroup_SetValue
			{
				TextKey = this.TextKey,
				IconId = this.IconId
			};
		}

		// Token: 0x17003520 RID: 13600
		// (get) Token: 0x0600AD5A RID: 44378 RVA: 0x0018D191 File Offset: 0x0018B391
		// (set) Token: 0x0600AD5B RID: 44379 RVA: 0x0018D1B8 File Offset: 0x0018B3B8
		public virtual string TextKey
		{
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
			set
			{
				this.GetOrCreatePoco().TextKey = value;
			}
		}

		// Token: 0x17003521 RID: 13601
		// (get) Token: 0x0600AD5C RID: 44380 RVA: 0x0018D1C8 File Offset: 0x0018B3C8
		// (set) Token: 0x0600AD5D RID: 44381 RVA: 0x0018D202 File Offset: 0x0018B402
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

		// Token: 0x040067E9 RID: 26601
		protected ITalkItemDisableAutoSelectOptionGroup FbInstance;

		// Token: 0x040067EA RID: 26602
		protected ITalkItemDisableAutoSelectOptionGroup_SetValue PocoInterface;
	}
}
