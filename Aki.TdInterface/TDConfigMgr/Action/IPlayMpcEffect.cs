using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D18 RID: 7448
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayMpcEffect : PlayEffect2
	{
		// Token: 0x06009FC3 RID: 40899 RVA: 0x0016CBF8 File Offset: 0x0016ADF8
		private IPlayMpcEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayMpcEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayMpcEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayMpcEffect_SetValue());
			}
			return result;
		}

		// Token: 0x06009FC4 RID: 40900 RVA: 0x0016CC30 File Offset: 0x0016AE30
		public static IPlayMpcEffect Create([Nullable(2)] IPlayMpcEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayMpcEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009FC5 RID: 40901 RVA: 0x0016CC43 File Offset: 0x0016AE43
		public static IPlayMpcEffect CreateFromSetValue([Nullable(2)] IPlayMpcEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayMpcEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009FC6 RID: 40902 RVA: 0x0016CC56 File Offset: 0x0016AE56
		public new IPlayMpcEffect_SetValue ToSetValue()
		{
			return new IPlayMpcEffect_SetValue
			{
				Type = this.Type,
				Path = this.Path,
				Pos2 = this.Pos2,
				Params = this.Params
			};
		}

		// Token: 0x17003194 RID: 12692
		// (get) Token: 0x06009FC7 RID: 40903 RVA: 0x0016CC8D File Offset: 0x0016AE8D
		// (set) Token: 0x06009FC8 RID: 40904 RVA: 0x0016CCB8 File Offset: 0x0016AEB8
		public override EEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEffectType.Effect;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003195 RID: 12693
		// (get) Token: 0x06009FC9 RID: 40905 RVA: 0x0016CCC6 File Offset: 0x0016AEC6
		// (set) Token: 0x06009FCA RID: 40906 RVA: 0x0016CCF1 File Offset: 0x0016AEF1
		public override string Path
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

		// Token: 0x17003196 RID: 12694
		// (get) Token: 0x06009FCB RID: 40907 RVA: 0x0016CCFF File Offset: 0x0016AEFF
		// (set) Token: 0x06009FCC RID: 40908 RVA: 0x0016CD26 File Offset: 0x0016AF26
		public virtual IBasePos2 Pos2
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Pos2;
				}
				IPlayMpcEffect_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.Pos2;
			}
			set
			{
				this.GetOrCreatePoco().Pos2 = value;
			}
		}

		// Token: 0x17003197 RID: 12695
		// (get) Token: 0x06009FCD RID: 40909 RVA: 0x0016CD34 File Offset: 0x0016AF34
		// (set) Token: 0x06009FCE RID: 40910 RVA: 0x0016CDC7 File Offset: 0x0016AFC7
		public virtual List<IPostProcessVolumeCenterPosition> Params
		{
			get
			{
				if (this._ParamsInited)
				{
					return this._ParamsCache;
				}
				this._ParamsInited = true;
				if (this.FbInstance != null)
				{
					List<IPostProcessVolumeCenterPosition> @params = this.FbInstance.Params;
					if (@params != null)
					{
						this._ParamsCache = new List<IPostProcessVolumeCenterPosition>(@params.Count);
						for (int i = 0; i < @params.Count; i++)
						{
							this._ParamsCache.Add(IPostProcessVolumeCenterPosition.Create(@params[i]));
						}
					}
				}
				else
				{
					IPlayMpcEffect_SetValue pocoInterface = this.PocoInterface;
					this._ParamsCache = ((pocoInterface != null) ? pocoInterface.Params : null);
				}
				return this._ParamsCache;
			}
			set
			{
				this.GetOrCreatePoco().Params = value;
				this._ParamsInited = false;
			}
		}

		// Token: 0x0400605F RID: 24671
		[Nullable(2)]
		protected new IPlayMpcEffect FbInstance;

		// Token: 0x04006060 RID: 24672
		[Nullable(2)]
		protected new IPlayMpcEffect_SetValue PocoInterface;

		// Token: 0x04006061 RID: 24673
		private List<IPostProcessVolumeCenterPosition> _ParamsCache;

		// Token: 0x04006062 RID: 24674
		private bool _ParamsInited;
	}
}
