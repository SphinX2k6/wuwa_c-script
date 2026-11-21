using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000533 RID: 1331
	public class IMatchCastConfig
	{
		// Token: 0x06001ACA RID: 6858 RVA: 0x0004E730 File Offset: 0x0004C930
		private IMatchCastConfig_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMatchCastConfig 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMatchCastConfig_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMatchCastConfig_SetValue());
			}
			return result;
		}

		// Token: 0x06001ACB RID: 6859 RVA: 0x0004E768 File Offset: 0x0004C968
		public static IMatchCastConfig Create([Nullable(2)] IMatchCastConfig instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMatchCastConfig
			{
				FbInstance = instance
			};
		}

		// Token: 0x06001ACC RID: 6860 RVA: 0x0004E77B File Offset: 0x0004C97B
		public static IMatchCastConfig CreateFromSetValue([Nullable(2)] IMatchCastConfig_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMatchCastConfig
			{
				PocoInterface = value
			};
		}

		// Token: 0x06001ACD RID: 6861 RVA: 0x0004E78E File Offset: 0x0004C98E
		public IMatchCastConfig_SetValue ToSetValue()
		{
			return new IMatchCastConfig_SetValue
			{
				Time = this.Time,
				Spline = this.Spline,
				MatchSequence = this.MatchSequence,
				SpeedCurve = this.SpeedCurve
			};
		}

		// Token: 0x17000717 RID: 1815
		// (get) Token: 0x06001ACE RID: 6862 RVA: 0x0004E7C5 File Offset: 0x0004C9C5
		// (set) Token: 0x06001ACF RID: 6863 RVA: 0x0004E7F0 File Offset: 0x0004C9F0
		public virtual int Time
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Time;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Time;
			}
			set
			{
				this.GetOrCreatePoco().Time = value;
			}
		}

		// Token: 0x17000718 RID: 1816
		// (get) Token: 0x06001AD0 RID: 6864 RVA: 0x0004E7FE File Offset: 0x0004C9FE
		// (set) Token: 0x06001AD1 RID: 6865 RVA: 0x0004E829 File Offset: 0x0004CA29
		public virtual string Spline
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Spline;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Spline;
			}
			set
			{
				this.GetOrCreatePoco().Spline = value;
			}
		}

		// Token: 0x17000719 RID: 1817
		// (get) Token: 0x06001AD2 RID: 6866 RVA: 0x0004E838 File Offset: 0x0004CA38
		// (set) Token: 0x06001AD3 RID: 6867 RVA: 0x0004E8CB File Offset: 0x0004CACB
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IMatchSequence> MatchSequence
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._MatchSequenceInited)
				{
					return this._MatchSequenceCache;
				}
				this._MatchSequenceInited = true;
				if (this.FbInstance != null)
				{
					List<IMatchSequence> matchSequence = this.FbInstance.MatchSequence;
					if (matchSequence != null)
					{
						this._MatchSequenceCache = new List<IMatchSequence>(matchSequence.Count);
						for (int i = 0; i < matchSequence.Count; i++)
						{
							this._MatchSequenceCache.Add(IMatchSequence.Create(matchSequence[i]));
						}
					}
				}
				else
				{
					IMatchCastConfig_SetValue pocoInterface = this.PocoInterface;
					this._MatchSequenceCache = ((pocoInterface != null) ? pocoInterface.MatchSequence : null);
				}
				return this._MatchSequenceCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().MatchSequence = value;
				this._MatchSequenceInited = false;
			}
		}

		// Token: 0x1700071A RID: 1818
		// (get) Token: 0x06001AD4 RID: 6868 RVA: 0x0004E8E0 File Offset: 0x0004CAE0
		// (set) Token: 0x06001AD5 RID: 6869 RVA: 0x0004E907 File Offset: 0x0004CB07
		[Nullable(2)]
		public virtual string SpeedCurve
		{
			[NullableContext(2)]
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SpeedCurve;
				}
				IMatchCastConfig_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SpeedCurve;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().SpeedCurve = value;
			}
		}

		// Token: 0x040013A6 RID: 5030
		[Nullable(2)]
		protected IMatchCastConfig FbInstance;

		// Token: 0x040013A7 RID: 5031
		[Nullable(2)]
		protected IMatchCastConfig_SetValue PocoInterface;

		// Token: 0x040013A8 RID: 5032
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IMatchSequence> _MatchSequenceCache;

		// Token: 0x040013A9 RID: 5033
		private bool _MatchSequenceInited;
	}
}
