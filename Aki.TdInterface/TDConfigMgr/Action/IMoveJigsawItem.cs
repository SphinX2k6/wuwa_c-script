using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C30 RID: 7216
	[NullableContext(1)]
	[Nullable(0)]
	public class IMoveJigsawItem : ISetJigsawItemType
	{
		// Token: 0x06009AD1 RID: 39633 RVA: 0x00163E3C File Offset: 0x0016203C
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

		// Token: 0x06009AD2 RID: 39634 RVA: 0x00163E74 File Offset: 0x00162074
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

		// Token: 0x06009AD3 RID: 39635 RVA: 0x00163E87 File Offset: 0x00162087
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

		// Token: 0x06009AD4 RID: 39636 RVA: 0x00163E9A File Offset: 0x0016209A
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

		// Token: 0x17003077 RID: 12407
		// (get) Token: 0x06009AD5 RID: 39637 RVA: 0x00163ED1 File Offset: 0x001620D1
		// (set) Token: 0x06009AD6 RID: 39638 RVA: 0x00163EFC File Offset: 0x001620FC
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

		// Token: 0x17003078 RID: 12408
		// (get) Token: 0x06009AD7 RID: 39639 RVA: 0x00163F0A File Offset: 0x0016210A
		// (set) Token: 0x06009AD8 RID: 39640 RVA: 0x00163F35 File Offset: 0x00162135
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

		// Token: 0x17003079 RID: 12409
		// (get) Token: 0x06009AD9 RID: 39641 RVA: 0x00163F43 File Offset: 0x00162143
		// (set) Token: 0x06009ADA RID: 39642 RVA: 0x00163F6E File Offset: 0x0016216E
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

		// Token: 0x1700307A RID: 12410
		// (get) Token: 0x06009ADB RID: 39643 RVA: 0x00163F7C File Offset: 0x0016217C
		// (set) Token: 0x06009ADC RID: 39644 RVA: 0x00163FDD File Offset: 0x001621DD
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

		// Token: 0x04005E1C RID: 24092
		[Nullable(2)]
		protected new IMoveJigsawItem FbInstance;

		// Token: 0x04005E1D RID: 24093
		[Nullable(2)]
		protected new IMoveJigsawItem_SetValue PocoInterface;

		// Token: 0x04005E1E RID: 24094
		private IPieceIndex _DestinationCache;

		// Token: 0x04005E1F RID: 24095
		private bool _DestinationInited;
	}
}
