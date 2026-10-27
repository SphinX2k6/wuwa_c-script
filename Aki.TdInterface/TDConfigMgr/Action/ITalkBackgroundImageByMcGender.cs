using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F1E RID: 7966
	[NullableContext(1)]
	[Nullable(0)]
	public class ITalkBackgroundImageByMcGender : ITalkBackground
	{
		// Token: 0x0600AA4E RID: 43598 RVA: 0x0017F844 File Offset: 0x0017DA44
		private ITalkBackgroundImageByMcGender_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITalkBackgroundImageByMcGender 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITalkBackgroundImageByMcGender_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITalkBackgroundImageByMcGender_SetValue());
			}
			return result;
		}

		// Token: 0x0600AA4F RID: 43599 RVA: 0x0017F87C File Offset: 0x0017DA7C
		public static ITalkBackgroundImageByMcGender Create([Nullable(2)] ITalkBackgroundImageByMcGender instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITalkBackgroundImageByMcGender
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AA50 RID: 43600 RVA: 0x0017F88F File Offset: 0x0017DA8F
		public static ITalkBackgroundImageByMcGender CreateFromSetValue([Nullable(2)] ITalkBackgroundImageByMcGender_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITalkBackgroundImageByMcGender
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AA51 RID: 43601 RVA: 0x0017F8A2 File Offset: 0x0017DAA2
		public new ITalkBackgroundImageByMcGender_SetValue ToSetValue()
		{
			return new ITalkBackgroundImageByMcGender_SetValue
			{
				Type = this.Type,
				ImageAssetMale = this.ImageAssetMale,
				ImageAssetFemale = this.ImageAssetFemale
			};
		}

		// Token: 0x170033D2 RID: 13266
		// (get) Token: 0x0600AA52 RID: 43602 RVA: 0x0017F8CD File Offset: 0x0017DACD
		// (set) Token: 0x0600AA53 RID: 43603 RVA: 0x0017F8F8 File Offset: 0x0017DAF8
		public override ETalkBackgroundType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETalkBackgroundType.Clean;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170033D3 RID: 13267
		// (get) Token: 0x0600AA54 RID: 43604 RVA: 0x0017F906 File Offset: 0x0017DB06
		// (set) Token: 0x0600AA55 RID: 43605 RVA: 0x0017F931 File Offset: 0x0017DB31
		public virtual string ImageAssetMale
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ImageAssetMale;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ImageAssetMale;
			}
			set
			{
				this.GetOrCreatePoco().ImageAssetMale = value;
			}
		}

		// Token: 0x170033D4 RID: 13268
		// (get) Token: 0x0600AA56 RID: 43606 RVA: 0x0017F93F File Offset: 0x0017DB3F
		// (set) Token: 0x0600AA57 RID: 43607 RVA: 0x0017F96A File Offset: 0x0017DB6A
		public virtual string ImageAssetFemale
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ImageAssetFemale;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.ImageAssetFemale;
			}
			set
			{
				this.GetOrCreatePoco().ImageAssetFemale = value;
			}
		}

		// Token: 0x0400652C RID: 25900
		[Nullable(2)]
		protected new ITalkBackgroundImageByMcGender FbInstance;

		// Token: 0x0400652D RID: 25901
		[Nullable(2)]
		protected new ITalkBackgroundImageByMcGender_SetValue PocoInterface;
	}
}
