using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C12 RID: 7186
	public class IFlowActorIndexData
	{
		// Token: 0x060098A0 RID: 39072 RVA: 0x0016212C File Offset: 0x0016032C
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

		// Token: 0x060098A1 RID: 39073 RVA: 0x00162164 File Offset: 0x00160364
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

		// Token: 0x060098A2 RID: 39074 RVA: 0x00162177 File Offset: 0x00160377
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

		// Token: 0x060098A3 RID: 39075 RVA: 0x0016218A File Offset: 0x0016038A
		public IFlowActorIndexData_SetValue ToSetValue()
		{
			return new IFlowActorIndexData_SetValue
			{
				Index = this.Index,
				Offset = this.Offset,
				IsUseFixedPosition = this.IsUseFixedPosition
			};
		}

		// Token: 0x17003042 RID: 12354
		// (get) Token: 0x060098A4 RID: 39076 RVA: 0x001621B5 File Offset: 0x001603B5
		// (set) Token: 0x060098A5 RID: 39077 RVA: 0x001621E0 File Offset: 0x001603E0
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

		// Token: 0x17003043 RID: 12355
		// (get) Token: 0x060098A6 RID: 39078 RVA: 0x001621F0 File Offset: 0x001603F0
		// (set) Token: 0x060098A7 RID: 39079 RVA: 0x00162251 File Offset: 0x00160451
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

		// Token: 0x17003044 RID: 12356
		// (get) Token: 0x060098A8 RID: 39080 RVA: 0x00162268 File Offset: 0x00160468
		// (set) Token: 0x060098A9 RID: 39081 RVA: 0x001622A2 File Offset: 0x001604A2
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

		// Token: 0x04005DF9 RID: 24057
		[Nullable(2)]
		protected IFlowActorIndexData FbInstance;

		// Token: 0x04005DFA RID: 24058
		[Nullable(2)]
		protected IFlowActorIndexData_SetValue PocoInterface;

		// Token: 0x04005DFB RID: 24059
		private PosAndRot _OffsetCache;

		// Token: 0x04005DFC RID: 24060
		private bool _OffsetInited;
	}
}
