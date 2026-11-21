using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010E9 RID: 4329
	public class IInformationView : IShowUi
	{
		// Token: 0x06005FB0 RID: 24496 RVA: 0x000E75F0 File Offset: 0x000E57F0
		private IInformationView_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IInformationView 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IInformationView_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IInformationView_SetValue());
			}
			return result;
		}

		// Token: 0x06005FB1 RID: 24497 RVA: 0x000E7628 File Offset: 0x000E5828
		public static IInformationView Create([Nullable(2)] IInformationView instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IInformationView
			{
				FbInstance = instance
			};
		}

		// Token: 0x06005FB2 RID: 24498 RVA: 0x000E763B File Offset: 0x000E583B
		public static IInformationView CreateFromSetValue([Nullable(2)] IInformationView_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IInformationView
			{
				PocoInterface = value
			};
		}

		// Token: 0x06005FB3 RID: 24499 RVA: 0x000E764E File Offset: 0x000E584E
		public new IInformationView_SetValue ToSetValue()
		{
			return new IInformationView_SetValue
			{
				Type = this.Type,
				InformationViewId = this.InformationViewId
			};
		}

		// Token: 0x17001F77 RID: 8055
		// (get) Token: 0x06005FB4 RID: 24500 RVA: 0x000E766D File Offset: 0x000E586D
		// (set) Token: 0x06005FB5 RID: 24501 RVA: 0x000E7698 File Offset: 0x000E5898
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

		// Token: 0x17001F78 RID: 8056
		// (get) Token: 0x06005FB6 RID: 24502 RVA: 0x000E76A6 File Offset: 0x000E58A6
		// (set) Token: 0x06005FB7 RID: 24503 RVA: 0x000E76D1 File Offset: 0x000E58D1
		public virtual int InformationViewId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.InformationViewId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.InformationViewId;
			}
			set
			{
				this.GetOrCreatePoco().InformationViewId = value;
			}
		}

		// Token: 0x04003965 RID: 14693
		[Nullable(2)]
		protected new IInformationView FbInstance;

		// Token: 0x04003966 RID: 14694
		[Nullable(2)]
		protected new IInformationView_SetValue PocoInterface;
	}
}
