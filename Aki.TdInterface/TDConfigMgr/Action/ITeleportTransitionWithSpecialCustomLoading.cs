using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FB8 RID: 8120
	[NullableContext(1)]
	[Nullable(0)]
	public class ITeleportTransitionWithSpecialCustomLoading : ITeleportTransitionType
	{
		// Token: 0x0600B29C RID: 45724 RVA: 0x001A0384 File Offset: 0x0019E584
		private ITeleportTransitionWithSpecialCustomLoading_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITeleportTransitionWithSpecialCustomLoading 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITeleportTransitionWithSpecialCustomLoading_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITeleportTransitionWithSpecialCustomLoading_SetValue());
			}
			return result;
		}

		// Token: 0x0600B29D RID: 45725 RVA: 0x001A03BC File Offset: 0x0019E5BC
		public static ITeleportTransitionWithSpecialCustomLoading Create([Nullable(2)] ITeleportTransitionWithSpecialCustomLoading instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITeleportTransitionWithSpecialCustomLoading
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B29E RID: 45726 RVA: 0x001A03CF File Offset: 0x0019E5CF
		public static ITeleportTransitionWithSpecialCustomLoading CreateFromSetValue([Nullable(2)] ITeleportTransitionWithSpecialCustomLoading_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITeleportTransitionWithSpecialCustomLoading
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B29F RID: 45727 RVA: 0x001A03E2 File Offset: 0x0019E5E2
		public new ITeleportTransitionWithSpecialCustomLoading_SetValue ToSetValue()
		{
			return new ITeleportTransitionWithSpecialCustomLoading_SetValue
			{
				Type = this.Type,
				LoadingType = this.LoadingType
			};
		}

		// Token: 0x17003712 RID: 14098
		// (get) Token: 0x0600B2A0 RID: 45728 RVA: 0x001A0401 File Offset: 0x0019E601
		// (set) Token: 0x0600B2A1 RID: 45729 RVA: 0x001A042C File Offset: 0x0019E62C
		public override ETeleportTransitionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETeleportTransitionType.PlayMp4;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003713 RID: 14099
		// (get) Token: 0x0600B2A2 RID: 45730 RVA: 0x001A043C File Offset: 0x0019E63C
		// (set) Token: 0x0600B2A3 RID: 45731 RVA: 0x001A049D File Offset: 0x0019E69D
		public virtual IHonamiStoryCustomLoading LoadingType
		{
			get
			{
				if (this._LoadingTypeInited)
				{
					return this._LoadingTypeCache;
				}
				this._LoadingTypeInited = true;
				if (this.FbInstance != null)
				{
					this._LoadingTypeCache = IHonamiStoryCustomLoading.Create(this.FbInstance.LoadingType);
				}
				else
				{
					ITeleportTransitionWithSpecialCustomLoading_SetValue pocoInterface = this.PocoInterface;
					this._LoadingTypeCache = ((pocoInterface != null) ? pocoInterface.LoadingType : null);
				}
				return this._LoadingTypeCache;
			}
			set
			{
				this.GetOrCreatePoco().LoadingType = value;
				this._LoadingTypeInited = false;
			}
		}

		// Token: 0x04006BDD RID: 27613
		[Nullable(2)]
		protected new ITeleportTransitionWithSpecialCustomLoading FbInstance;

		// Token: 0x04006BDE RID: 27614
		[Nullable(2)]
		protected new ITeleportTransitionWithSpecialCustomLoading_SetValue PocoInterface;

		// Token: 0x04006BDF RID: 27615
		private IHonamiStoryCustomLoading _LoadingTypeCache;

		// Token: 0x04006BE0 RID: 27616
		private bool _LoadingTypeInited;
	}
}
