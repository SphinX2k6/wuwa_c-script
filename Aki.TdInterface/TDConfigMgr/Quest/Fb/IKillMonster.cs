using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001590 RID: 5520
	public class IKillMonster
	{
		// Token: 0x06007C72 RID: 31858 RVA: 0x00127AEA File Offset: 0x00125CEA
		public static IKillMonster Create(IKillMonster? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IKillMonster
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170028F4 RID: 10484
		// (get) Token: 0x06007C73 RID: 31859 RVA: 0x00127B09 File Offset: 0x00125D09
		public virtual int NormalAddTime
		{
			get
			{
				return this.Instance.NormalAddTime;
			}
		}

		// Token: 0x170028F5 RID: 10485
		// (get) Token: 0x06007C74 RID: 31860 RVA: 0x00127B18 File Offset: 0x00125D18
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
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int specialTimeLength = this.Instance.SpecialTimeLength;
				this._SpecialTimeCache = new List<IKillSingleMonster>(specialTimeLength);
				for (int i = 0; i < specialTimeLength; i++)
				{
					this._SpecialTimeCache.Add(IKillSingleMonster.Create(this.Instance.SpecialTime(i)));
				}
				return this._SpecialTimeCache;
			}
		}

		// Token: 0x040047C2 RID: 18370
		private IKillMonster Instance;

		// Token: 0x040047C3 RID: 18371
		[Nullable(new byte[]
		{
			2,
			0
		})]
		private List<IKillSingleMonster> _SpecialTimeCache;

		// Token: 0x040047C4 RID: 18372
		private bool _SpecialTimeInited;
	}
}
