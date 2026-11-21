using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020021FB RID: 8699
	public class ITeleportTransitionWithSpecialCustomLoading : ITeleportTransitionType
	{
		// Token: 0x0600BDA0 RID: 48544 RVA: 0x001B6734 File Offset: 0x001B4934
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

		// Token: 0x0600BDA1 RID: 48545 RVA: 0x001B676C File Offset: 0x001B496C
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

		// Token: 0x0600BDA2 RID: 48546 RVA: 0x001B677F File Offset: 0x001B497F
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

		// Token: 0x0600BDA3 RID: 48547 RVA: 0x001B6792 File Offset: 0x001B4992
		public new ITeleportTransitionWithSpecialCustomLoading_SetValue ToSetValue()
		{
			return new ITeleportTransitionWithSpecialCustomLoading_SetValue
			{
				Type = this.Type,
				LoadingType = this.LoadingType
			};
		}

		// Token: 0x170039E7 RID: 14823
		// (get) Token: 0x0600BDA4 RID: 48548 RVA: 0x001B67B1 File Offset: 0x001B49B1
		// (set) Token: 0x0600BDA5 RID: 48549 RVA: 0x001B67DC File Offset: 0x001B49DC
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

		// Token: 0x170039E8 RID: 14824
		// (get) Token: 0x0600BDA6 RID: 48550 RVA: 0x001B67EC File Offset: 0x001B49EC
		// (set) Token: 0x0600BDA7 RID: 48551 RVA: 0x001B684D File Offset: 0x001B4A4D
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

		// Token: 0x040071D8 RID: 29144
		[Nullable(2)]
		protected new ITeleportTransitionWithSpecialCustomLoading FbInstance;

		// Token: 0x040071D9 RID: 29145
		[Nullable(2)]
		protected new ITeleportTransitionWithSpecialCustomLoading_SetValue PocoInterface;

		// Token: 0x040071DA RID: 29146
		private IHonamiStoryCustomLoading _LoadingTypeCache;

		// Token: 0x040071DB RID: 29147
		private bool _LoadingTypeInited;
	}
}
