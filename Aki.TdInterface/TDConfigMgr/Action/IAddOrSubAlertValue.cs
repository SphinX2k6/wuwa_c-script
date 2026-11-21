using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200192B RID: 6443
	public class IAddOrSubAlertValue : ISetAlertValueType
	{
		// Token: 0x06008723 RID: 34595 RVA: 0x00141270 File Offset: 0x0013F470
		private IAddOrSubAlertValue_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAddOrSubAlertValue 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAddOrSubAlertValue_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAddOrSubAlertValue_SetValue());
			}
			return result;
		}

		// Token: 0x06008724 RID: 34596 RVA: 0x001412A8 File Offset: 0x0013F4A8
		public static IAddOrSubAlertValue Create([Nullable(2)] IAddOrSubAlertValue instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAddOrSubAlertValue
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008725 RID: 34597 RVA: 0x001412BB File Offset: 0x0013F4BB
		public static IAddOrSubAlertValue CreateFromSetValue([Nullable(2)] IAddOrSubAlertValue_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAddOrSubAlertValue
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008726 RID: 34598 RVA: 0x001412CE File Offset: 0x0013F4CE
		public new IAddOrSubAlertValue_SetValue ToSetValue()
		{
			return new IAddOrSubAlertValue_SetValue
			{
				Type = this.Type,
				DeltaValue = this.DeltaValue
			};
		}

		// Token: 0x17002BDD RID: 11229
		// (get) Token: 0x06008727 RID: 34599 RVA: 0x001412ED File Offset: 0x0013F4ED
		// (set) Token: 0x06008728 RID: 34600 RVA: 0x00141318 File Offset: 0x0013F518
		public override EValueChangeType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EValueChangeType.AddOrSub;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002BDE RID: 11230
		// (get) Token: 0x06008729 RID: 34601 RVA: 0x00141326 File Offset: 0x0013F526
		// (set) Token: 0x0600872A RID: 34602 RVA: 0x00141355 File Offset: 0x0013F555
		public virtual float DeltaValue
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DeltaValue;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.DeltaValue;
			}
			set
			{
				this.GetOrCreatePoco().DeltaValue = value;
			}
		}

		// Token: 0x04005592 RID: 21906
		[Nullable(2)]
		protected new IAddOrSubAlertValue FbInstance;

		// Token: 0x04005593 RID: 21907
		[Nullable(2)]
		protected new IAddOrSubAlertValue_SetValue PocoInterface;
	}
}
