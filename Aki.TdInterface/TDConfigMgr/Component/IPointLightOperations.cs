using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006B1 RID: 1713
	public class IPointLightOperations
	{
		// Token: 0x06002436 RID: 9270 RVA: 0x00062D0C File Offset: 0x00060F0C
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

		// Token: 0x06002437 RID: 9271 RVA: 0x00062D44 File Offset: 0x00060F44
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

		// Token: 0x06002438 RID: 9272 RVA: 0x00062D57 File Offset: 0x00060F57
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

		// Token: 0x06002439 RID: 9273 RVA: 0x00062D6A File Offset: 0x00060F6A
		public IPointLightOperations_SetValue ToSetValue()
		{
			return new IPointLightOperations_SetValue
			{
				Match = this.Match,
				SwitchToTargetState = this.SwitchToTargetState
			};
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x0600243A RID: 9274 RVA: 0x00062D8C File Offset: 0x00060F8C
		// (set) Token: 0x0600243B RID: 9275 RVA: 0x00062DED File Offset: 0x00060FED
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

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x0600243C RID: 9276 RVA: 0x00062E02 File Offset: 0x00061002
		// (set) Token: 0x0600243D RID: 9277 RVA: 0x00062E2D File Offset: 0x0006102D
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

		// Token: 0x04001925 RID: 6437
		[Nullable(2)]
		protected IPointLightOperations FbInstance;

		// Token: 0x04001926 RID: 6438
		[Nullable(2)]
		protected IPointLightOperations_SetValue PocoInterface;

		// Token: 0x04001927 RID: 6439
		private IEntityMatch _MatchCache;

		// Token: 0x04001928 RID: 6440
		private bool _MatchInited;
	}
}
