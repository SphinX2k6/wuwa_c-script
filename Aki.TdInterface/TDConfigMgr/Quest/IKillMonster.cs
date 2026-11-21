using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020010FD RID: 4349
	public class IKillMonster
	{
		// Token: 0x06006020 RID: 24608 RVA: 0x000E8388 File Offset: 0x000E6588
		private IKillMonster_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IKillMonster 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IKillMonster_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IKillMonster_SetValue());
			}
			return result;
		}

		// Token: 0x06006021 RID: 24609 RVA: 0x000E83C0 File Offset: 0x000E65C0
		public static IKillMonster Create([Nullable(2)] IKillMonster instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKillMonster
			{
				FbInstance = instance
			};
		}

		// Token: 0x06006022 RID: 24610 RVA: 0x000E83D3 File Offset: 0x000E65D3
		public static IKillMonster CreateFromSetValue([Nullable(2)] IKillMonster_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IKillMonster
			{
				PocoInterface = value
			};
		}

		// Token: 0x06006023 RID: 24611 RVA: 0x000E83E6 File Offset: 0x000E65E6
		public IKillMonster_SetValue ToSetValue()
		{
			return new IKillMonster_SetValue
			{
				NormalAddTime = this.NormalAddTime,
				SpecialTime = this.SpecialTime
			};
		}

		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x06006024 RID: 24612 RVA: 0x000E8405 File Offset: 0x000E6605
		// (set) Token: 0x06006025 RID: 24613 RVA: 0x000E8430 File Offset: 0x000E6630
		public virtual int NormalAddTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.NormalAddTime;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.NormalAddTime;
			}
			set
			{
				this.GetOrCreatePoco().NormalAddTime = value;
			}
		}

		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x06006026 RID: 24614 RVA: 0x000E8440 File Offset: 0x000E6640
		// (set) Token: 0x06006027 RID: 24615 RVA: 0x000E84D3 File Offset: 0x000E66D3
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public virtual List<IKillSingleMonster> SpecialTime
		{
			[return: Nullable(new byte[]
			{
				2,
				0
			})]
			get
			{
				if (this._SpecialTimeInited)
				{
					return this._SpecialTimeCache;
				}
				this._SpecialTimeInited = true;
				if (this.FbInstance != null)
				{
					List<IKillSingleMonster> specialTime = this.FbInstance.SpecialTime;
					if (specialTime != null)
					{
						this._SpecialTimeCache = new List<IKillSingleMonster>(specialTime.Count);
						for (int i = 0; i < specialTime.Count; i++)
						{
							this._SpecialTimeCache.Add(IKillSingleMonster.Create(specialTime[i]));
						}
					}
				}
				else
				{
					IKillMonster_SetValue pocoInterface = this.PocoInterface;
					this._SpecialTimeCache = ((pocoInterface != null) ? pocoInterface.SpecialTime : null);
				}
				return this._SpecialTimeCache;
			}
			[param: Nullable(new byte[]
			{
				2,
				0
			})]
			set
			{
				this.GetOrCreatePoco().SpecialTime = value;
				this._SpecialTimeInited = false;
			}
		}

		// Token: 0x0400399F RID: 14751
		[Nullable(2)]
		protected IKillMonster FbInstance;

		// Token: 0x040039A0 RID: 14752
		[Nullable(2)]
		protected IKillMonster_SetValue PocoInterface;

		// Token: 0x040039A1 RID: 14753
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IKillSingleMonster> _SpecialTimeCache;

		// Token: 0x040039A2 RID: 14754
		private bool _SpecialTimeInited;
	}
}
