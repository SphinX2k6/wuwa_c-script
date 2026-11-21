using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C54 RID: 11348
	public class IMoveJigsawItem : ISetJigsawItemType
	{
		// Token: 0x0600F987 RID: 63879 RVA: 0x00243D1D File Offset: 0x00241F1D
		public static IMoveJigsawItem Create(IMoveJigsawItem? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMoveJigsawItem
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D8D RID: 19853
		// (get) Token: 0x0600F988 RID: 63880 RVA: 0x00243D3C File Offset: 0x00241F3C
		public override ESetJigsawItemType Type
		{
			get
			{
				return (ESetJigsawItemType)this.Instance.Type;
			}
		}

		// Token: 0x17004D8E RID: 19854
		// (get) Token: 0x0600F989 RID: 63881 RVA: 0x00243D49 File Offset: 0x00241F49
		public virtual int ItemEntityId
		{
			get
			{
				return this.Instance.ItemEntityId;
			}
		}

		// Token: 0x17004D8F RID: 19855
		// (get) Token: 0x0600F98A RID: 63882 RVA: 0x00243D56 File Offset: 0x00241F56
		public virtual int FoundationEntityId
		{
			get
			{
				return this.Instance.FoundationEntityId;
			}
		}

		// Token: 0x17004D90 RID: 19856
		// (get) Token: 0x0600F98B RID: 63883 RVA: 0x00243D63 File Offset: 0x00241F63
		public virtual IPieceIndex Destination
		{
			get
			{
				if (this._DestinationInited)
				{
					return this._DestinationCache;
				}
				this._DestinationInited = true;
				this._DestinationCache = IPieceIndex.Create(this.Instance.Destination);
				return this._DestinationCache;
			}
		}

		// Token: 0x04008860 RID: 34912
		private IMoveJigsawItem Instance;

		// Token: 0x04008861 RID: 34913
		[Nullable(2)]
		private IPieceIndex _DestinationCache;

		// Token: 0x04008862 RID: 34914
		private bool _DestinationInited;
	}
}
