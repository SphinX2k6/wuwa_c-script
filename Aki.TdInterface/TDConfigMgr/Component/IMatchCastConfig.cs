using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004DA RID: 1242
	[NullableContext(1)]
	[Nullable(0)]
	public class IMatchCastConfig
	{
		// Token: 0x06001930 RID: 6448 RVA: 0x0004A9E8 File Offset: 0x00048BE8
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

		// Token: 0x06001931 RID: 6449 RVA: 0x0004AA20 File Offset: 0x00048C20
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

		// Token: 0x06001932 RID: 6450 RVA: 0x0004AA33 File Offset: 0x00048C33
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

		// Token: 0x06001933 RID: 6451 RVA: 0x0004AA46 File Offset: 0x00048C46
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

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x06001934 RID: 6452 RVA: 0x0004AA7D File Offset: 0x00048C7D
		// (set) Token: 0x06001935 RID: 6453 RVA: 0x0004AAA8 File Offset: 0x00048CA8
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

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001936 RID: 6454 RVA: 0x0004AAB6 File Offset: 0x00048CB6
		// (set) Token: 0x06001937 RID: 6455 RVA: 0x0004AAE1 File Offset: 0x00048CE1
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

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001938 RID: 6456 RVA: 0x0004AAF0 File Offset: 0x00048CF0
		// (set) Token: 0x06001939 RID: 6457 RVA: 0x0004AB83 File Offset: 0x00048D83
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IMatchSequence> MatchSequence
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().MatchSequence = value;
				this._MatchSequenceInited = false;
			}
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x0004AB98 File Offset: 0x00048D98
		// (set) Token: 0x0600193B RID: 6459 RVA: 0x0004ABBF File Offset: 0x00048DBF
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

		// Token: 0x04001284 RID: 4740
		[Nullable(2)]
		protected IMatchCastConfig FbInstance;

		// Token: 0x04001285 RID: 4741
		[Nullable(2)]
		protected IMatchCastConfig_SetValue PocoInterface;

		// Token: 0x04001286 RID: 4742
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IMatchSequence> _MatchSequenceCache;

		// Token: 0x04001287 RID: 4743
		private bool _MatchSequenceInited;
	}
}
