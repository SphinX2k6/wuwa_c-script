using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F22 RID: 7970
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkCommonEffect : ITalkEffectType
	{
		// Token: 0x0600AA66 RID: 43622 RVA: 0x0017FADC File Offset: 0x0017DCDC
		private ITalkCommonEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkCommonEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkCommonEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkCommonEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600AA67 RID: 43623 RVA: 0x0017FB14 File Offset: 0x0017DD14
		public static ITalkCommonEffect Create([Nullable(2)] ITalkCommonEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkCommonEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AA68 RID: 43624 RVA: 0x0017FB27 File Offset: 0x0017DD27
		public static ITalkCommonEffect CreateFromSetValue([Nullable(2)] ITalkCommonEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkCommonEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AA69 RID: 43625 RVA: 0x0017FB3A File Offset: 0x0017DD3A
		public new ITalkCommonEffect_SetValue ToSetValue()
		{
			return new ITalkCommonEffect_SetValue
			{
				Type = this.Type,
				Path = this.Path,
				Pos2 = this.Pos2,
				StartFromLoop = this.StartFromLoop
			};
		}

		// Token: 0x170033D8 RID: 13272
		// (get) Token: 0x0600AA6A RID: 43626 RVA: 0x0017FB71 File Offset: 0x0017DD71
		// (set) Token: 0x0600AA6B RID: 43627 RVA: 0x0017FB9C File Offset: 0x0017DD9C
		public override ETalkEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkEffectType.Effect;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170033D9 RID: 13273
		// (get) Token: 0x0600AA6C RID: 43628 RVA: 0x0017FBAA File Offset: 0x0017DDAA
		// (set) Token: 0x0600AA6D RID: 43629 RVA: 0x0017FBD5 File Offset: 0x0017DDD5
		public virtual string Path
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Path;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Path;
			}
			set
			{
				this.GetOrCreatePoco().Path = value;
			}
		}

		// Token: 0x170033DA RID: 13274
		// (get) Token: 0x0600AA6E RID: 43630 RVA: 0x0017FBE4 File Offset: 0x0017DDE4
		// (set) Token: 0x0600AA6F RID: 43631 RVA: 0x0017FC45 File Offset: 0x0017DE45
		public virtual IAbsolutePos2 Pos2
		{
			get
			{
				if (this._Pos2Inited)
				{
					return this._Pos2Cache;
				}
				this._Pos2Inited = true;
				if (this.FbInstance != null)
				{
					this._Pos2Cache = IAbsolutePos2.Create(this.FbInstance.Pos2);
				}
				else
				{
					ITalkCommonEffect_SetValue pocoInterface = this.PocoInterface;
					this._Pos2Cache = ((pocoInterface != null) ? pocoInterface.Pos2 : null);
				}
				return this._Pos2Cache;
			}
			set
			{
				this.GetOrCreatePoco().Pos2 = value;
				this._Pos2Inited = false;
			}
		}

		// Token: 0x170033DB RID: 13275
		// (get) Token: 0x0600AA70 RID: 43632 RVA: 0x0017FC5C File Offset: 0x0017DE5C
		// (set) Token: 0x0600AA71 RID: 43633 RVA: 0x0017FC96 File Offset: 0x0017DE96
		public virtual bool? StartFromLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.StartFromLoop;
				}
				ITalkCommonEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.StartFromLoop;
			}
			set
			{
				this.GetOrCreatePoco().StartFromLoop = value;
			}
		}

		// Token: 0x04006536 RID: 25910
		[Nullable(2)]
		protected new ITalkCommonEffect FbInstance;

		// Token: 0x04006537 RID: 25911
		[Nullable(2)]
		protected new ITalkCommonEffect_SetValue PocoInterface;

		// Token: 0x04006538 RID: 25912
		private IAbsolutePos2 _Pos2Cache;

		// Token: 0x04006539 RID: 25913
		private bool _Pos2Inited;
	}
}
