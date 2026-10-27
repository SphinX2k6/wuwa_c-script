using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FE2 RID: 8162
	[NullableContext(1)]
	[Nullable(0)]
	public class ITransitionPopupArtTextTypeBase
	{
		// Token: 0x0600B392 RID: 45970 RVA: 0x001A208C File Offset: 0x001A028C
		private ITransitionPopupArtTextTypeBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITransitionPopupArtTextTypeBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITransitionPopupArtTextTypeBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITransitionPopupArtTextTypeBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600B393 RID: 45971 RVA: 0x001A20C4 File Offset: 0x001A02C4
		public static ITransitionPopupArtTextTypeBase Create([Nullable(2)] ITransitionPopupArtTextTypeBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITransitionPopupArtTextTypeBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B394 RID: 45972 RVA: 0x001A20D7 File Offset: 0x001A02D7
		public static ITransitionPopupArtTextTypeBase CreateFromSetValue([Nullable(2)] ITransitionPopupArtTextTypeBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITransitionPopupArtTextTypeBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B395 RID: 45973 RVA: 0x001A20EA File Offset: 0x001A02EA
		public ITransitionPopupArtTextTypeBase_SetValue ToSetValue()
		{
			return new ITransitionPopupArtTextTypeBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700374E RID: 14158
		// (get) Token: 0x0600B396 RID: 45974 RVA: 0x001A20FD File Offset: 0x001A02FD
		// (set) Token: 0x0600B397 RID: 45975 RVA: 0x001A2128 File Offset: 0x001A0328
		public virtual ETransitionPopupArtTextType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETransitionPopupArtTextType.YuanCheng;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006C57 RID: 27735
		[Nullable(2)]
		protected ITransitionPopupArtTextTypeBase FbInstance;

		// Token: 0x04006C58 RID: 27736
		[Nullable(2)]
		protected ITransitionPopupArtTextTypeBase_SetValue PocoInterface;
	}
}
