using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002841 RID: 10305
	[NullableContext(1)]
	[Nullable(0)]
	public class IDaemonHack : IUiGame
	{
		// Token: 0x0600E475 RID: 58485 RVA: 0x0021A00E File Offset: 0x0021820E
		public static IDaemonHack Create(IDaemonHack? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDaemonHack
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170045B5 RID: 17845
		// (get) Token: 0x0600E476 RID: 58486 RVA: 0x0021A02D File Offset: 0x0021822D
		public override ESimpleGameplayType Type
		{
			get
			{
				return (ESimpleGameplayType)this.Instance.Type;
			}
		}

		// Token: 0x170045B6 RID: 17846
		// (get) Token: 0x0600E477 RID: 58487 RVA: 0x0021A03C File Offset: 0x0021823C
		public virtual List<int> Ids
		{
			get
			{
				if (this._IdsInited)
				{
					return this._IdsCache;
				}
				this._IdsInited = true;
				int idsLength = this.Instance.IdsLength;
				this._IdsCache = new List<int>(idsLength);
				for (int i = 0; i < idsLength; i++)
				{
					this._IdsCache.Add(this.Instance.Ids(i));
				}
				return this._IdsCache;
			}
		}

		// Token: 0x170045B7 RID: 17847
		// (get) Token: 0x0600E478 RID: 58488 RVA: 0x0021A0A0 File Offset: 0x002182A0
		public virtual bool? FinishOnClose
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new bool?(this.Instance.FinishOnClose);
			}
		}

		// Token: 0x04007E67 RID: 32359
		private IDaemonHack Instance;

		// Token: 0x04007E68 RID: 32360
		private List<int> _IdsCache;

		// Token: 0x04007E69 RID: 32361
		private bool _IdsInited;
	}
}
