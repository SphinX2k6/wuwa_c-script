using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000614 RID: 1556
	[NullableContext(1)]
	[Nullable(0)]
	public class IPointLightOperations
	{
		// Token: 0x06002130 RID: 8496 RVA: 0x0005BFF8 File Offset: 0x0005A1F8
		private IPointLightOperations_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPointLightOperations 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPointLightOperations_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPointLightOperations_SetValue());
			}
			return result;
		}

		// Token: 0x06002131 RID: 8497 RVA: 0x0005C030 File Offset: 0x0005A230
		public static IPointLightOperations Create([Nullable(2)] IPointLightOperations instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPointLightOperations
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002132 RID: 8498 RVA: 0x0005C043 File Offset: 0x0005A243
		public static IPointLightOperations CreateFromSetValue([Nullable(2)] IPointLightOperations_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPointLightOperations
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002133 RID: 8499 RVA: 0x0005C056 File Offset: 0x0005A256
		public IPointLightOperations_SetValue ToSetValue()
		{
			return new IPointLightOperations_SetValue
			{
				Match = this.Match,
				SwitchToTargetState = this.SwitchToTargetState
			};
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x06002134 RID: 8500 RVA: 0x0005C078 File Offset: 0x0005A278
		// (set) Token: 0x06002135 RID: 8501 RVA: 0x0005C0D9 File Offset: 0x0005A2D9
		public virtual IEntityMatch Match
		{
			get
			{
				if (this._MatchInited)
				{
					return this._MatchCache;
				}
				this._MatchInited = true;
				if (this.FbInstance != null)
				{
					this._MatchCache = IEntityMatch.Create(this.FbInstance.Match);
				}
				else
				{
					IPointLightOperations_SetValue pocoInterface = this.PocoInterface;
					this._MatchCache = ((pocoInterface != null) ? pocoInterface.Match : null);
				}
				return this._MatchCache;
			}
			set
			{
				this.GetOrCreatePoco().Match = value;
				this._MatchInited = false;
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x06002136 RID: 8502 RVA: 0x0005C0EE File Offset: 0x0005A2EE
		// (set) Token: 0x06002137 RID: 8503 RVA: 0x0005C119 File Offset: 0x0005A319
		public virtual string SwitchToTargetState
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SwitchToTargetState;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SwitchToTargetState;
			}
			set
			{
				this.GetOrCreatePoco().SwitchToTargetState = value;
			}
		}

		// Token: 0x04001733 RID: 5939
		[Nullable(2)]
		protected IPointLightOperations FbInstance;

		// Token: 0x04001734 RID: 5940
		[Nullable(2)]
		protected IPointLightOperations_SetValue PocoInterface;

		// Token: 0x04001735 RID: 5941
		private IEntityMatch _MatchCache;

		// Token: 0x04001736 RID: 5942
		private bool _MatchInited;
	}
}
