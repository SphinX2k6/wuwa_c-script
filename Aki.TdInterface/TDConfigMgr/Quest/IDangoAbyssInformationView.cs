using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200104C RID: 4172
	public class IDangoAbyssInformationView : IInformationViewType
	{
		// Token: 0x06005C02 RID: 23554 RVA: 0x000E01D4 File Offset: 0x000DE3D4
		private IDangoAbyssInformationView_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDangoAbyssInformationView 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDangoAbyssInformationView_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDangoAbyssInformationView_SetValue());
			}
			return result;
		}

		// Token: 0x06005C03 RID: 23555 RVA: 0x000E020C File Offset: 0x000DE40C
		public static IDangoAbyssInformationView Create([Nullable(2)] IDangoAbyssInformationView instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDangoAbyssInformationView
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005C04 RID: 23556 RVA: 0x000E021F File Offset: 0x000DE41F
		public static IDangoAbyssInformationView CreateFromSetValue([Nullable(2)] IDangoAbyssInformationView_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDangoAbyssInformationView
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005C05 RID: 23557 RVA: 0x000E0232 File Offset: 0x000DE432
		public new IDangoAbyssInformationView_SetValue ToSetValue()
		{
			return new IDangoAbyssInformationView_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001E8B RID: 7819
		// (get) Token: 0x06005C06 RID: 23558 RVA: 0x000E0245 File Offset: 0x000DE445
		// (set) Token: 0x06005C07 RID: 23559 RVA: 0x000E0270 File Offset: 0x000DE470
		public override EInformationViewType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EInformationViewType.LevelPlay;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400377F RID: 14207
		[Nullable(2)]
		protected new IDangoAbyssInformationView FbInstance;

		// Token: 0x04003780 RID: 14208
		[Nullable(2)]
		protected new IDangoAbyssInformationView_SetValue PocoInterface;
	}
}
