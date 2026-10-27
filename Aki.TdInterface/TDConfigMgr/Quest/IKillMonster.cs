using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Quest.Fb;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02000FD1 RID: 4049
	[NullableContext(1)]
	[Nullable(0)]
	public class IKillMonster
	{
		// Token: 0x06005A40 RID: 23104 RVA: 0x000DB748 File Offset: 0x000D9948
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

		// Token: 0x06005A41 RID: 23105 RVA: 0x000DB780 File Offset: 0x000D9980
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

		// Token: 0x06005A42 RID: 23106 RVA: 0x000DB793 File Offset: 0x000D9993
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

		// Token: 0x06005A43 RID: 23107 RVA: 0x000DB7A6 File Offset: 0x000D99A6
		public IKillMonster_SetValue ToSetValue()
		{
			return new IKillMonster_SetValue
			{
				NormalAddTime = this.NormalAddTime,
				SpecialTime = this.SpecialTime
			};
		}

		// Token: 0x17001DE8 RID: 7656
		// (get) Token: 0x06005A44 RID: 23108 RVA: 0x000DB7C5 File Offset: 0x000D99C5
		// (set) Token: 0x06005A45 RID: 23109 RVA: 0x000DB7F0 File Offset: 0x000D99F0
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

		// Token: 0x17001DE9 RID: 7657
		// (get) Token: 0x06005A46 RID: 23110 RVA: 0x000DB800 File Offset: 0x000D9A00
		// (set) Token: 0x06005A47 RID: 23111 RVA: 0x000DB893 File Offset: 0x000D9A93
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public virtual List<IKillSingleMonster> SpecialTime
		{
			[return: Nullable(new byte[]
			{
				2,
				1
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
				1
			})]
			set
			{
				this.GetOrCreatePoco().SpecialTime = value;
				this._SpecialTimeInited = false;
			}
		}

		// Token: 0x04003667 RID: 13927
		[Nullable(2)]
		protected IKillMonster FbInstance;

		// Token: 0x04003668 RID: 13928
		[Nullable(2)]
		protected IKillMonster_SetValue PocoInterface;

		// Token: 0x04003669 RID: 13929
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IKillSingleMonster> _SpecialTimeCache;

		// Token: 0x0400366A RID: 13930
		private bool _SpecialTimeInited;
	}
}
