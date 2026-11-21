using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018E1 RID: 6369
	public class IActorFaceExpressionPlay : IActorFaceExpressionType
	{
		// Token: 0x060085A1 RID: 34209 RVA: 0x0013E6B4 File Offset: 0x0013C8B4
		private IActorFaceExpressionPlay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorFaceExpressionPlay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorFaceExpressionPlay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorFaceExpressionPlay_SetValue());
			}
			return result;
		}

		// Token: 0x060085A2 RID: 34210 RVA: 0x0013E6EC File Offset: 0x0013C8EC
		public static IActorFaceExpressionPlay Create([Nullable(2)] IActorFaceExpressionPlay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFaceExpressionPlay
			{
				FbInstance = instance
			};
		}

		// Token: 0x060085A3 RID: 34211 RVA: 0x0013E6FF File Offset: 0x0013C8FF
		public static IActorFaceExpressionPlay CreateFromSetValue([Nullable(2)] IActorFaceExpressionPlay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorFaceExpressionPlay
			{
				PocoInterface = value
			};
		}

		// Token: 0x060085A4 RID: 34212 RVA: 0x0013E712 File Offset: 0x0013C912
		public new IActorFaceExpressionPlay_SetValue ToSetValue()
		{
			return new IActorFaceExpressionPlay_SetValue
			{
				Type = this.Type,
				FaceExpressionId = this.FaceExpressionId,
				DelayTime = this.DelayTime
			};
		}

		// Token: 0x17002B8B RID: 11147
		// (get) Token: 0x060085A5 RID: 34213 RVA: 0x0013E73D File Offset: 0x0013C93D
		// (set) Token: 0x060085A6 RID: 34214 RVA: 0x0013E768 File Offset: 0x0013C968
		public override EActorFaceExpressionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EActorFaceExpressionType.Play;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002B8C RID: 11148
		// (get) Token: 0x060085A7 RID: 34215 RVA: 0x0013E776 File Offset: 0x0013C976
		// (set) Token: 0x060085A8 RID: 34216 RVA: 0x0013E7A1 File Offset: 0x0013C9A1
		public virtual int FaceExpressionId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.FaceExpressionId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.FaceExpressionId;
			}
			set
			{
				this.GetOrCreatePoco().FaceExpressionId = value;
			}
		}

		// Token: 0x17002B8D RID: 11149
		// (get) Token: 0x060085A9 RID: 34217 RVA: 0x0013E7B0 File Offset: 0x0013C9B0
		// (set) Token: 0x060085AA RID: 34218 RVA: 0x0013E7EA File Offset: 0x0013C9EA
		public virtual float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				IActorFaceExpressionPlay_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.DelayTime;
			}
			set
			{
				this.GetOrCreatePoco().DelayTime = value;
			}
		}

		// Token: 0x040054DC RID: 21724
		[Nullable(2)]
		protected new IActorFaceExpressionPlay FbInstance;

		// Token: 0x040054DD RID: 21725
		[Nullable(2)]
		protected new IActorFaceExpressionPlay_SetValue PocoInterface;
	}
}
