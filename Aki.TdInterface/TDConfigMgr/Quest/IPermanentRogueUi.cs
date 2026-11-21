using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001169 RID: 4457
	public class IPermanentRogueUi : IShowUi
	{
		// Token: 0x0600630A RID: 25354 RVA: 0x000EE998 File Offset: 0x000ECB98
		private IPermanentRogueUi_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPermanentRogueUi 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPermanentRogueUi_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPermanentRogueUi_SetValue());
			}
			return result;
		}

		// Token: 0x0600630B RID: 25355 RVA: 0x000EE9D0 File Offset: 0x000ECBD0
		public static IPermanentRogueUi Create([Nullable(2)] IPermanentRogueUi instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPermanentRogueUi
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600630C RID: 25356 RVA: 0x000EE9E3 File Offset: 0x000ECBE3
		public static IPermanentRogueUi CreateFromSetValue([Nullable(2)] IPermanentRogueUi_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPermanentRogueUi
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600630D RID: 25357 RVA: 0x000EE9F6 File Offset: 0x000ECBF6
		public new IPermanentRogueUi_SetValue ToSetValue()
		{
			return new IPermanentRogueUi_SetValue
			{
				Type = this.Type,
				UiType = this.UiType,
				BindId = this.BindId
			};
		}

		// Token: 0x17002064 RID: 8292
		// (get) Token: 0x0600630E RID: 25358 RVA: 0x000EEA21 File Offset: 0x000ECC21
		// (set) Token: 0x0600630F RID: 25359 RVA: 0x000EEA4C File Offset: 0x000ECC4C
		public override EShowUiType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EShowUiType.All;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002065 RID: 8293
		// (get) Token: 0x06006310 RID: 25360 RVA: 0x000EEA5A File Offset: 0x000ECC5A
		// (set) Token: 0x06006311 RID: 25361 RVA: 0x000EEA85 File Offset: 0x000ECC85
		public virtual ERogueUiType UiType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UiType;
				}
				if (this.PocoInterface == null)
				{
					return (ERogueUiType)0;
				}
				return this.PocoInterface.UiType;
			}
			set
			{
				this.GetOrCreatePoco().UiType = value;
			}
		}

		// Token: 0x17002066 RID: 8294
		// (get) Token: 0x06006312 RID: 25362 RVA: 0x000EEA93 File Offset: 0x000ECC93
		// (set) Token: 0x06006313 RID: 25363 RVA: 0x000EEABE File Offset: 0x000ECCBE
		public virtual int BindId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BindId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.BindId;
			}
			set
			{
				this.GetOrCreatePoco().BindId = value;
			}
		}

		// Token: 0x04003B62 RID: 15202
		[Nullable(2)]
		protected new IPermanentRogueUi FbInstance;

		// Token: 0x04003B63 RID: 15203
		[Nullable(2)]
		protected new IPermanentRogueUi_SetValue PocoInterface;
	}
}
