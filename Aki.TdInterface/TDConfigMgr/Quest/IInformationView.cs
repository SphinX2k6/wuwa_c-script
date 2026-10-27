using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FBD RID: 4029
	[NullableContext(1)]
	[Nullable(0)]
	public class IInformationView : IShowUi
	{
		// Token: 0x060059D2 RID: 22994 RVA: 0x000DAA64 File Offset: 0x000D8C64
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

		// Token: 0x060059D3 RID: 22995 RVA: 0x000DAA9C File Offset: 0x000D8C9C
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

		// Token: 0x060059D4 RID: 22996 RVA: 0x000DAAAF File Offset: 0x000D8CAF
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

		// Token: 0x060059D5 RID: 22997 RVA: 0x000DAAC2 File Offset: 0x000D8CC2
		public new IInformationView_SetValue ToSetValue()
		{
			return new IInformationView_SetValue
			{
				Type = this.Type,
				InformationViewId = this.InformationViewId
			};
		}

		// Token: 0x17001DCF RID: 7631
		// (get) Token: 0x060059D6 RID: 22998 RVA: 0x000DAAE1 File Offset: 0x000D8CE1
		// (set) Token: 0x060059D7 RID: 22999 RVA: 0x000DAB0C File Offset: 0x000D8D0C
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

		// Token: 0x17001DD0 RID: 7632
		// (get) Token: 0x060059D8 RID: 23000 RVA: 0x000DAB1A File Offset: 0x000D8D1A
		// (set) Token: 0x060059D9 RID: 23001 RVA: 0x000DAB45 File Offset: 0x000D8D45
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

		// Token: 0x04003630 RID: 13872
		[Nullable(2)]
		protected new IInformationView FbInstance;

		// Token: 0x04003631 RID: 13873
		[Nullable(2)]
		protected new IInformationView_SetValue PocoInterface;
	}
}
