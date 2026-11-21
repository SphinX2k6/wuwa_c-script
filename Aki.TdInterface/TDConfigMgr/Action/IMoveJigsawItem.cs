using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E27 RID: 7719
	public class IMoveJigsawItem : ISetJigsawItemType
	{
		// Token: 0x0600A429 RID: 42025 RVA: 0x0017717C File Offset: 0x0017537C
		private IMoveJigsawItem_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMoveJigsawItem 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMoveJigsawItem_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMoveJigsawItem_SetValue());
			}
			return result;
		}

		// Token: 0x0600A42A RID: 42026 RVA: 0x001771B4 File Offset: 0x001753B4
		public static IMoveJigsawItem Create([Nullable(2)] IMoveJigsawItem instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMoveJigsawItem
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A42B RID: 42027 RVA: 0x001771C7 File Offset: 0x001753C7
		public static IMoveJigsawItem CreateFromSetValue([Nullable(2)] IMoveJigsawItem_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMoveJigsawItem
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A42C RID: 42028 RVA: 0x001771DA File Offset: 0x001753DA
		public new IMoveJigsawItem_SetValue ToSetValue()
		{
			return new IMoveJigsawItem_SetValue
			{
				Type = this.Type,
				ItemEntityId = this.ItemEntityId,
				FoundationEntityId = this.FoundationEntityId,
				Destination = this.Destination
			};
		}

		// Token: 0x170032E8 RID: 13032
		// (get) Token: 0x0600A42D RID: 42029 RVA: 0x00177211 File Offset: 0x00175411
		// (set) Token: 0x0600A42E RID: 42030 RVA: 0x0017723C File Offset: 0x0017543C
		public override ESetJigsawItemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetJigsawItemType.MoveJigsawItem;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170032E9 RID: 13033
		// (get) Token: 0x0600A42F RID: 42031 RVA: 0x0017724A File Offset: 0x0017544A
		// (set) Token: 0x0600A430 RID: 42032 RVA: 0x00177275 File Offset: 0x00175475
		public virtual int ItemEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ItemEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ItemEntityId;
			}
			set
			{
				this.GetOrCreatePoco().ItemEntityId = value;
			}
		}

		// Token: 0x170032EA RID: 13034
		// (get) Token: 0x0600A431 RID: 42033 RVA: 0x00177283 File Offset: 0x00175483
		// (set) Token: 0x0600A432 RID: 42034 RVA: 0x001772AE File Offset: 0x001754AE
		public virtual int FoundationEntityId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FoundationEntityId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FoundationEntityId;
			}
			set
			{
				this.GetOrCreatePoco().FoundationEntityId = value;
			}
		}

		// Token: 0x170032EB RID: 13035
		// (get) Token: 0x0600A433 RID: 42035 RVA: 0x001772BC File Offset: 0x001754BC
		// (set) Token: 0x0600A434 RID: 42036 RVA: 0x0017731D File Offset: 0x0017551D
		public virtual IPieceIndex Destination
		{
			get
			{
				if (this._DestinationInited)
				{
					return this._DestinationCache;
				}
				this._DestinationInited = true;
				if (this.FbInstance != null)
				{
					this._DestinationCache = IPieceIndex.Create(this.FbInstance.Destination);
				}
				else
				{
					IMoveJigsawItem_SetValue pocoInterface = this.PocoInterface;
					this._DestinationCache = ((pocoInterface != null) ? pocoInterface.Destination : null);
				}
				return this._DestinationCache;
			}
			set
			{
				this.GetOrCreatePoco().Destination = value;
				this._DestinationInited = false;
			}
		}

		// Token: 0x04006353 RID: 25427
		[Nullable(2)]
		protected new IMoveJigsawItem FbInstance;

		// Token: 0x04006354 RID: 25428
		[Nullable(2)]
		protected new IMoveJigsawItem_SetValue PocoInterface;

		// Token: 0x04006355 RID: 25429
		private IPieceIndex _DestinationCache;

		// Token: 0x04006356 RID: 25430
		private bool _DestinationInited;
	}
}
