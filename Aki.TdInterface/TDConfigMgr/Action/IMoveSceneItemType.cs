using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E2D RID: 7725
	public class IMoveSceneItemType
	{
		// Token: 0x0600A447 RID: 42055 RVA: 0x001774FC File Offset: 0x001756FC
		private IMoveSceneItemType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMoveSceneItemType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMoveSceneItemType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMoveSceneItemType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A448 RID: 42056 RVA: 0x00177534 File Offset: 0x00175734
		public static IMoveSceneItemType Create([Nullable(2)] IMoveSceneItemType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMoveSceneItemType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A449 RID: 42057 RVA: 0x00177547 File Offset: 0x00175747
		public static IMoveSceneItemType CreateFromSetValue([Nullable(2)] IMoveSceneItemType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMoveSceneItemType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A44A RID: 42058 RVA: 0x0017755A File Offset: 0x0017575A
		public IMoveSceneItemType_SetValue ToSetValue()
		{
			return new IMoveSceneItemType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170032EE RID: 13038
		// (get) Token: 0x0600A44B RID: 42059 RVA: 0x0017756D File Offset: 0x0017576D
		// (set) Token: 0x0600A44C RID: 42060 RVA: 0x00177598 File Offset: 0x00175798
		public virtual EMoveSceneItemType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMoveSceneItemType.MoveToPoint;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006363 RID: 25443
		[Nullable(2)]
		protected IMoveSceneItemType FbInstance;

		// Token: 0x04006364 RID: 25444
		[Nullable(2)]
		protected IMoveSceneItemType_SetValue PocoInterface;
	}
}
