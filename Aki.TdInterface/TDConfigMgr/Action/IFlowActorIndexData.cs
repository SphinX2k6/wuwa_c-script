using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A7D RID: 6781
	[NullableContext(1)]
	[Nullable(0)]
	public class IFlowActorIndexData
	{
		// Token: 0x06009136 RID: 37174 RVA: 0x00152200 File Offset: 0x00150400
		private IFlowActorIndexData_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IFlowActorIndexData 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IFlowActorIndexData_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IFlowActorIndexData_SetValue());
			}
			return result;
		}

		// Token: 0x06009137 RID: 37175 RVA: 0x00152238 File Offset: 0x00150438
		public static IFlowActorIndexData Create([Nullable(2)] IFlowActorIndexData instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IFlowActorIndexData
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009138 RID: 37176 RVA: 0x0015224B File Offset: 0x0015044B
		public static IFlowActorIndexData CreateFromSetValue([Nullable(2)] IFlowActorIndexData_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IFlowActorIndexData
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009139 RID: 37177 RVA: 0x0015225E File Offset: 0x0015045E
		public IFlowActorIndexData_SetValue ToSetValue()
		{
			return new IFlowActorIndexData_SetValue
			{
				Index = this.Index,
				Offset = this.Offset,
				IsUseFixedPosition = this.IsUseFixedPosition
			};
		}

		// Token: 0x17002E35 RID: 11829
		// (get) Token: 0x0600913A RID: 37178 RVA: 0x00152289 File Offset: 0x00150489
		// (set) Token: 0x0600913B RID: 37179 RVA: 0x001522B4 File Offset: 0x001504B4
		public virtual int Index
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Index;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Index;
			}
			set
			{
				this.GetOrCreatePoco().Index = value;
			}
		}

		// Token: 0x17002E36 RID: 11830
		// (get) Token: 0x0600913C RID: 37180 RVA: 0x001522C4 File Offset: 0x001504C4
		// (set) Token: 0x0600913D RID: 37181 RVA: 0x00152325 File Offset: 0x00150525
		[Nullable(2)]
		public virtual PosAndRot Offset
		{
			[NullableContext(2)]
			get
			{
				if (this._OffsetInited)
				{
					return this._OffsetCache;
				}
				this._OffsetInited = true;
				if (this.FbInstance != null)
				{
					this._OffsetCache = PosAndRot.Create(this.FbInstance.Offset);
				}
				else
				{
					IFlowActorIndexData_SetValue pocoInterface = this.PocoInterface;
					this._OffsetCache = ((pocoInterface != null) ? pocoInterface.Offset : null);
				}
				return this._OffsetCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().Offset = value;
				this._OffsetInited = false;
			}
		}

		// Token: 0x17002E37 RID: 11831
		// (get) Token: 0x0600913E RID: 37182 RVA: 0x0015233C File Offset: 0x0015053C
		// (set) Token: 0x0600913F RID: 37183 RVA: 0x00152376 File Offset: 0x00150576
		public virtual bool? IsUseFixedPosition
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsUseFixedPosition;
				}
				IFlowActorIndexData_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.IsUseFixedPosition;
			}
			set
			{
				this.GetOrCreatePoco().IsUseFixedPosition = value;
			}
		}

		// Token: 0x04005994 RID: 22932
		[Nullable(2)]
		protected IFlowActorIndexData FbInstance;

		// Token: 0x04005995 RID: 22933
		[Nullable(2)]
		protected IFlowActorIndexData_SetValue PocoInterface;

		// Token: 0x04005996 RID: 22934
		private PosAndRot _OffsetCache;

		// Token: 0x04005997 RID: 22935
		private bool _OffsetInited;
	}
}
