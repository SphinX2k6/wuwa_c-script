using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000F36 RID: 3894
	[NullableContext(1)]
	[Nullable(0)]
	public class IDangoAbyssInformationView : IInformationViewType
	{
		// Token: 0x06005686 RID: 22150 RVA: 0x000D402C File Offset: 0x000D222C
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

		// Token: 0x06005687 RID: 22151 RVA: 0x000D4064 File Offset: 0x000D2264
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

		// Token: 0x06005688 RID: 22152 RVA: 0x000D4077 File Offset: 0x000D2277
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

		// Token: 0x06005689 RID: 22153 RVA: 0x000D408A File Offset: 0x000D228A
		public new IDangoAbyssInformationView_SetValue ToSetValue()
		{
			return new IDangoAbyssInformationView_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17001CF3 RID: 7411
		// (get) Token: 0x0600568A RID: 22154 RVA: 0x000D409D File Offset: 0x000D229D
		// (set) Token: 0x0600568B RID: 22155 RVA: 0x000D40C8 File Offset: 0x000D22C8
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

		// Token: 0x04003472 RID: 13426
		[Nullable(2)]
		protected new IDangoAbyssInformationView FbInstance;

		// Token: 0x04003473 RID: 13427
		[Nullable(2)]
		protected new IDangoAbyssInformationView_SetValue PocoInterface;
	}
}
