using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CAE RID: 7342
	public class IHideMapMark : ToggleMapMarkState
	{
		// Token: 0x06009BEA RID: 39914 RVA: 0x00167D74 File Offset: 0x00165F74
		private IHideMapMark_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHideMapMark 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHideMapMark_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHideMapMark_SetValue());
			}
			return result;
		}

		// Token: 0x06009BEB RID: 39915 RVA: 0x00167DAC File Offset: 0x00165FAC
		public static IHideMapMark Create([Nullable(2)] IHideMapMark instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideMapMark
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009BEC RID: 39916 RVA: 0x00167DBF File Offset: 0x00165FBF
		public static IHideMapMark CreateFromSetValue([Nullable(2)] IHideMapMark_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHideMapMark
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009BED RID: 39917 RVA: 0x00167DD2 File Offset: 0x00165FD2
		public new IHideMapMark_SetValue ToSetValue()
		{
			return new IHideMapMark_SetValue
			{
				Type = this.Type,
				MarkId = this.MarkId
			};
		}

		// Token: 0x170030FD RID: 12541
		// (get) Token: 0x06009BEE RID: 39918 RVA: 0x00167DF1 File Offset: 0x00165FF1
		// (set) Token: 0x06009BEF RID: 39919 RVA: 0x00167E1C File Offset: 0x0016601C
		public override EMapMarkState Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMapMarkState.Show;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170030FE RID: 12542
		// (get) Token: 0x06009BF0 RID: 39920 RVA: 0x00167E2A File Offset: 0x0016602A
		// (set) Token: 0x06009BF1 RID: 39921 RVA: 0x00167E55 File Offset: 0x00166055
		public virtual int MarkId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MarkId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MarkId;
			}
			set
			{
				this.GetOrCreatePoco().MarkId = value;
			}
		}

		// Token: 0x04005F72 RID: 24434
		[Nullable(2)]
		protected new IHideMapMark FbInstance;

		// Token: 0x04005F73 RID: 24435
		[Nullable(2)]
		protected new IHideMapMark_SetValue PocoInterface;
	}
}
