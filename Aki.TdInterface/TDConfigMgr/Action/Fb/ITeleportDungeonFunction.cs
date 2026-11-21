using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C0E RID: 11278
	[NullableContext(2)]
	[Nullable(0)]
	public class ITeleportDungeonFunction : EnableFunction
	{
		// Token: 0x0600F849 RID: 63561 RVA: 0x002419DF File Offset: 0x0023FBDF
		[NullableContext(0)]
		public static ITeleportDungeonFunction Create(ITeleportDungeonFunction? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportDungeonFunction
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CDB RID: 19675
		// (get) Token: 0x0600F84A RID: 63562 RVA: 0x002419FE File Offset: 0x0023FBFE
		public override EEnableFunctionType Type
		{
			get
			{
				return (EEnableFunctionType)this.Instance.Type;
			}
		}

		// Token: 0x17004CDC RID: 19676
		// (get) Token: 0x0600F84B RID: 63563 RVA: 0x00241A0B File Offset: 0x0023FC0B
		public virtual bool Enable
		{
			get
			{
				return this.Instance.Enable;
			}
		}

		// Token: 0x17004CDD RID: 19677
		// (get) Token: 0x0600F84C RID: 63564 RVA: 0x00241A18 File Offset: 0x0023FC18
		public virtual List<int> DungeonList
		{
			get
			{
				if (this._DungeonListInited)
				{
					return this._DungeonListCache;
				}
				this._DungeonListInited = true;
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				int dungeonListLength = this.Instance.DungeonListLength;
				this._DungeonListCache = new List<int>(dungeonListLength);
				for (int i = 0; i < dungeonListLength; i++)
				{
					this._DungeonListCache.Add(this.Instance.DungeonList(i));
				}
				return this._DungeonListCache;
			}
		}

		// Token: 0x040087DA RID: 34778
		private ITeleportDungeonFunction Instance;

		// Token: 0x040087DB RID: 34779
		private List<int> _DungeonListCache;

		// Token: 0x040087DC RID: 34780
		private bool _DungeonListInited;
	}
}
