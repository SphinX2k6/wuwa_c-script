using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x0200296F RID: 10607
	[NullableContext(1)]
	[Nullable(0)]
	public class IMoveJigsawItem : ISetJigsawItemType
	{
		// Token: 0x0600EB11 RID: 60177 RVA: 0x00226665 File Offset: 0x00224865
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

		// Token: 0x170049F5 RID: 18933
		// (get) Token: 0x0600EB12 RID: 60178 RVA: 0x00226684 File Offset: 0x00224884
		public override ESetJigsawItemType Type
		{
			get
			{
				return (ESetJigsawItemType)this.Instance.Type;
			}
		}

		// Token: 0x170049F6 RID: 18934
		// (get) Token: 0x0600EB13 RID: 60179 RVA: 0x00226691 File Offset: 0x00224891
		public virtual int ItemEntityId
		{
			get
			{
				return this.Instance.ItemEntityId;
			}
		}

		// Token: 0x170049F7 RID: 18935
		// (get) Token: 0x0600EB14 RID: 60180 RVA: 0x0022669E File Offset: 0x0022489E
		public virtual int FoundationEntityId
		{
			get
			{
				return this.Instance.FoundationEntityId;
			}
		}

		// Token: 0x170049F8 RID: 18936
		// (get) Token: 0x0600EB15 RID: 60181 RVA: 0x002266AB File Offset: 0x002248AB
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

		// Token: 0x0400817F RID: 33151
		private IMoveJigsawItem Instance;

		// Token: 0x04008180 RID: 33152
		[Nullable(2)]
		private IPieceIndex _DestinationCache;

		// Token: 0x04008181 RID: 33153
		private bool _DestinationInited;
	}
}
