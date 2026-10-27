using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001936 RID: 6454
	[NullableContext(2)]
	[Nullable(0)]
	public class IControlElementalBoxReturn : IControlElementalBoxTypeBase
	{
		// Token: 0x06008A63 RID: 35427 RVA: 0x001460E8 File Offset: 0x001442E8
		[NullableContext(1)]
		private IControlElementalBoxReturn_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IControlElementalBoxReturn 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IControlElementalBoxReturn_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IControlElementalBoxReturn_SetValue());
			}
			return result;
		}

		// Token: 0x06008A64 RID: 35428 RVA: 0x00146120 File Offset: 0x00144320
		[NullableContext(1)]
		public static IControlElementalBoxReturn Create([Nullable(2)] IControlElementalBoxReturn instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IControlElementalBoxReturn
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008A65 RID: 35429 RVA: 0x00146133 File Offset: 0x00144333
		[NullableContext(1)]
		public static IControlElementalBoxReturn CreateFromSetValue([Nullable(2)] IControlElementalBoxReturn_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IControlElementalBoxReturn
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008A66 RID: 35430 RVA: 0x00146146 File Offset: 0x00144346
		[NullableContext(1)]
		public new IControlElementalBoxReturn_SetValue ToSetValue()
		{
			return new IControlElementalBoxReturn_SetValue
			{
				Type = this.Type,
				ReturnBeforeMoveSeq = this.ReturnBeforeMoveSeq
			};
		}

		// Token: 0x17002CB5 RID: 11445
		// (get) Token: 0x06008A67 RID: 35431 RVA: 0x00146165 File Offset: 0x00144365
		// (set) Token: 0x06008A68 RID: 35432 RVA: 0x00146190 File Offset: 0x00144390
		public override EControlElementalBoxType Type
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

		// Token: 0x17002CB6 RID: 11446
		// (get) Token: 0x06008A69 RID: 35433 RVA: 0x0014619E File Offset: 0x0014439E
		// (set) Token: 0x06008A6A RID: 35434 RVA: 0x001461C5 File Offset: 0x001443C5
		public virtual string ReturnBeforeMoveSeq
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ReturnBeforeMoveSeq;
				}
				IControlElementalBoxReturn_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ReturnBeforeMoveSeq;
			}
			set
			{
				this.GetOrCreatePoco().ReturnBeforeMoveSeq = value;
			}
		}

		// Token: 0x04005686 RID: 22150
		protected new IControlElementalBoxReturn FbInstance;

		// Token: 0x04005687 RID: 22151
		protected new IControlElementalBoxReturn_SetValue PocoInterface;
	}
}
