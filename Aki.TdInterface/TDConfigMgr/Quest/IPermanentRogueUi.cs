using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200103B RID: 4155
	[NullableContext(1)]
	[Nullable(0)]
	public class IPermanentRogueUi : IShowUi
	{
		// Token: 0x06005D18 RID: 23832 RVA: 0x000E19C4 File Offset: 0x000DFBC4
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

		// Token: 0x06005D19 RID: 23833 RVA: 0x000E19FC File Offset: 0x000DFBFC
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

		// Token: 0x06005D1A RID: 23834 RVA: 0x000E1A0F File Offset: 0x000DFC0F
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

		// Token: 0x06005D1B RID: 23835 RVA: 0x000E1A22 File Offset: 0x000DFC22
		public new IPermanentRogueUi_SetValue ToSetValue()
		{
			return new IPermanentRogueUi_SetValue
			{
				Type = this.Type,
				UiType = this.UiType,
				BindId = this.BindId
			};
		}

		// Token: 0x17001EB5 RID: 7861
		// (get) Token: 0x06005D1C RID: 23836 RVA: 0x000E1A4D File Offset: 0x000DFC4D
		// (set) Token: 0x06005D1D RID: 23837 RVA: 0x000E1A78 File Offset: 0x000DFC78
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

		// Token: 0x17001EB6 RID: 7862
		// (get) Token: 0x06005D1E RID: 23838 RVA: 0x000E1A86 File Offset: 0x000DFC86
		// (set) Token: 0x06005D1F RID: 23839 RVA: 0x000E1AB1 File Offset: 0x000DFCB1
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

		// Token: 0x17001EB7 RID: 7863
		// (get) Token: 0x06005D20 RID: 23840 RVA: 0x000E1ABF File Offset: 0x000DFCBF
		// (set) Token: 0x06005D21 RID: 23841 RVA: 0x000E1AEA File Offset: 0x000DFCEA
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

		// Token: 0x0400381A RID: 14362
		[Nullable(2)]
		protected new IPermanentRogueUi FbInstance;

		// Token: 0x0400381B RID: 14363
		[Nullable(2)]
		protected new IPermanentRogueUi_SetValue PocoInterface;
	}
}
