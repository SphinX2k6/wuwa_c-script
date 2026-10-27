using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C36 RID: 7222
	[NullableContext(1)]
	[Nullable(0)]
	public class IMoveSceneItemType
	{
		// Token: 0x06009AEF RID: 39663 RVA: 0x001641BC File Offset: 0x001623BC
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

		// Token: 0x06009AF0 RID: 39664 RVA: 0x001641F4 File Offset: 0x001623F4
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

		// Token: 0x06009AF1 RID: 39665 RVA: 0x00164207 File Offset: 0x00162407
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

		// Token: 0x06009AF2 RID: 39666 RVA: 0x0016421A File Offset: 0x0016241A
		public IMoveSceneItemType_SetValue ToSetValue()
		{
			return new IMoveSceneItemType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700307D RID: 12413
		// (get) Token: 0x06009AF3 RID: 39667 RVA: 0x0016422D File Offset: 0x0016242D
		// (set) Token: 0x06009AF4 RID: 39668 RVA: 0x00164258 File Offset: 0x00162458
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

		// Token: 0x04005E2C RID: 24108
		[Nullable(2)]
		protected IMoveSceneItemType FbInstance;

		// Token: 0x04005E2D RID: 24109
		[Nullable(2)]
		protected IMoveSceneItemType_SetValue PocoInterface;
	}
}
