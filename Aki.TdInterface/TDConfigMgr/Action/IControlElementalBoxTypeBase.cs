using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001938 RID: 6456
	[NullableContext(1)]
	[Nullable(0)]
	public class IControlElementalBoxTypeBase
	{
		// Token: 0x06008A6D RID: 35437 RVA: 0x001461E4 File Offset: 0x001443E4
		private IControlElementalBoxTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IControlElementalBoxTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IControlElementalBoxTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IControlElementalBoxTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x06008A6E RID: 35438 RVA: 0x0014621C File Offset: 0x0014441C
		public static IControlElementalBoxTypeBase Create([Nullable(2)] IControlElementalBoxTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IControlElementalBoxTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008A6F RID: 35439 RVA: 0x0014622F File Offset: 0x0014442F
		public static IControlElementalBoxTypeBase CreateFromSetValue([Nullable(2)] IControlElementalBoxTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IControlElementalBoxTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008A70 RID: 35440 RVA: 0x00146242 File Offset: 0x00144442
		public IControlElementalBoxTypeBase_SetValue ToSetValue()
		{
			return new IControlElementalBoxTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002CB7 RID: 11447
		// (get) Token: 0x06008A71 RID: 35441 RVA: 0x00146255 File Offset: 0x00144455
		// (set) Token: 0x06008A72 RID: 35442 RVA: 0x00146280 File Offset: 0x00144480
		public virtual EControlElementalBoxType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EControlElementalBoxType.Capture;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400568A RID: 22154
		[Nullable(2)]
		protected IControlElementalBoxTypeBase FbInstance;

		// Token: 0x0400568B RID: 22155
		[Nullable(2)]
		protected IControlElementalBoxTypeBase_SetValue PocoInterface;
	}
}
