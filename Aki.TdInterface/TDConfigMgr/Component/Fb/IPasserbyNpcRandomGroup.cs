using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DC2 RID: 3522
	public class IPasserbyNpcRandomGroup
	{
		// Token: 0x06004FFC RID: 20476 RVA: 0x000C6C9F File Offset: 0x000C4E9F
		public static IPasserbyNpcRandomGroup Create(IPasserbyNpcRandomGroup? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPasserbyNpcRandomGroup
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001873 RID: 6259
		// (get) Token: 0x06004FFD RID: 20477 RVA: 0x000C6CBE File Offset: 0x000C4EBE
		public virtual int Weight
		{
			get
			{
				return this.Instance.Weight;
			}
		}

		// Token: 0x17001874 RID: 6260
		// (get) Token: 0x06004FFE RID: 20478 RVA: 0x000C6CCB File Offset: 0x000C4ECB
		public virtual int NpcCount
		{
			get
			{
				return this.Instance.NpcCount;
			}
		}

		// Token: 0x17001875 RID: 6261
		// (get) Token: 0x06004FFF RID: 20479 RVA: 0x000C6CD8 File Offset: 0x000C4ED8
		public virtual List<IPasserbyNpcStandPos> StandPositions
		{
			get
			{
				if (this._StandPositionsInited)
				{
					return this._StandPositionsCache;
				}
				this._StandPositionsInited = true;
				int standPositionsLength = this.Instance.StandPositionsLength;
				this._StandPositionsCache = new List<IPasserbyNpcStandPos>(standPositionsLength);
				for (int i = 0; i < standPositionsLength; i++)
				{
					this._StandPositionsCache.Add(IPasserbyNpcStandPos.Create(this.Instance.StandPositions(i)));
				}
				return this._StandPositionsCache;
			}
		}

		// Token: 0x04002D91 RID: 11665
		private IPasserbyNpcRandomGroup Instance;

		// Token: 0x04002D92 RID: 11666
		private List<IPasserbyNpcStandPos> _StandPositionsCache;

		// Token: 0x04002D93 RID: 11667
		private bool _StandPositionsInited;
	}
}
