using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200215B RID: 8539
	public class ITalkCommonEffect : ITalkEffectType
	{
		// Token: 0x0600B538 RID: 46392 RVA: 0x00195AD4 File Offset: 0x00193CD4
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

		// Token: 0x0600B539 RID: 46393 RVA: 0x00195B0C File Offset: 0x00193D0C
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

		// Token: 0x0600B53A RID: 46394 RVA: 0x00195B1F File Offset: 0x00193D1F
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

		// Token: 0x0600B53B RID: 46395 RVA: 0x00195B32 File Offset: 0x00193D32
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

		// Token: 0x170036A3 RID: 13987
		// (get) Token: 0x0600B53C RID: 46396 RVA: 0x00195B69 File Offset: 0x00193D69
		// (set) Token: 0x0600B53D RID: 46397 RVA: 0x00195B94 File Offset: 0x00193D94
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

		// Token: 0x170036A4 RID: 13988
		// (get) Token: 0x0600B53E RID: 46398 RVA: 0x00195BA2 File Offset: 0x00193DA2
		// (set) Token: 0x0600B53F RID: 46399 RVA: 0x00195BCD File Offset: 0x00193DCD
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

		// Token: 0x170036A5 RID: 13989
		// (get) Token: 0x0600B540 RID: 46400 RVA: 0x00195BDC File Offset: 0x00193DDC
		// (set) Token: 0x0600B541 RID: 46401 RVA: 0x00195C3D File Offset: 0x00193E3D
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

		// Token: 0x170036A6 RID: 13990
		// (get) Token: 0x0600B542 RID: 46402 RVA: 0x00195C54 File Offset: 0x00193E54
		// (set) Token: 0x0600B543 RID: 46403 RVA: 0x00195C8E File Offset: 0x00193E8E
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

		// Token: 0x04006B25 RID: 27429
		[Nullable(2)]
		protected new ITalkCommonEffect FbInstance;

		// Token: 0x04006B26 RID: 27430
		[Nullable(2)]
		protected new ITalkCommonEffect_SetValue PocoInterface;

		// Token: 0x04006B27 RID: 27431
		private IAbsolutePos2 _Pos2Cache;

		// Token: 0x04006B28 RID: 27432
		private bool _Pos2Inited;
	}
}
