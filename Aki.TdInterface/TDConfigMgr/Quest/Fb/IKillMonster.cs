using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Quest;

namespace Aki.TDConfigMgr.Quest.Fb
{
	// Token: 0x02001438 RID: 5176
	public class IKillMonster
	{
		// Token: 0x060075AD RID: 30125 RVA: 0x0011909E File Offset: 0x0011729E
		[NullableContext(1)]
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

		// Token: 0x17002710 RID: 10000
		// (get) Token: 0x060075AE RID: 30126 RVA: 0x001190BD File Offset: 0x001172BD
		public virtual int NormalAddTime
		{
			get
			{
				return this.Instance.NormalAddTime;
			}
		}

		// Token: 0x17002711 RID: 10001
		// (get) Token: 0x060075AF RID: 30127 RVA: 0x001190CC File Offset: 0x001172CC
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

		// Token: 0x0400442E RID: 17454
		private IKillMonster Instance;

		// Token: 0x0400442F RID: 17455
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<IKillSingleMonster> _SpecialTimeCache;

		// Token: 0x04004430 RID: 17456
		private bool _SpecialTimeInited;
	}
}
