using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EFD RID: 7933
	public class IPhotographicTip : ICommonTipType
	{
		// Token: 0x0600A8D1 RID: 43217 RVA: 0x0017F760 File Offset: 0x0017D960
		private IPhotographicTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPhotographicTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPhotographicTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPhotographicTip_SetValue());
			}
			return result;
		}

		// Token: 0x0600A8D2 RID: 43218 RVA: 0x0017F798 File Offset: 0x0017D998
		public static IPhotographicTip Create([Nullable(2)] IPhotographicTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPhotographicTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A8D3 RID: 43219 RVA: 0x0017F7AB File Offset: 0x0017D9AB
		public static IPhotographicTip CreateFromSetValue([Nullable(2)] IPhotographicTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPhotographicTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A8D4 RID: 43220 RVA: 0x0017F7BE File Offset: 0x0017D9BE
		public new IPhotographicTip_SetValue ToSetValue()
		{
			return new IPhotographicTip_SetValue
			{
				Type = this.Type,
				MainText = this.MainText
			};
		}

		// Token: 0x170033FB RID: 13307
		// (get) Token: 0x0600A8D5 RID: 43221 RVA: 0x0017F7DD File Offset: 0x0017D9DD
		// (set) Token: 0x0600A8D6 RID: 43222 RVA: 0x0017F808 File Offset: 0x0017DA08
		public override ECommonTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170033FC RID: 13308
		// (get) Token: 0x0600A8D7 RID: 43223 RVA: 0x0017F816 File Offset: 0x0017DA16
		// (set) Token: 0x0600A8D8 RID: 43224 RVA: 0x0017F841 File Offset: 0x0017DA41
		public virtual string MainText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MainText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MainText;
			}
			set
			{
				this.GetOrCreatePoco().MainText = value;
			}
		}

		// Token: 0x04006574 RID: 25972
		[Nullable(2)]
		protected new IPhotographicTip FbInstance;

		// Token: 0x04006575 RID: 25973
		[Nullable(2)]
		protected new IPhotographicTip_SetValue PocoInterface;
	}
}
