using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001760 RID: 5984
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorFaceExpressionPlay : IActorFaceExpressionType
	{
		// Token: 0x06007EB1 RID: 32433 RVA: 0x0012F454 File Offset: 0x0012D654
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

		// Token: 0x06007EB2 RID: 32434 RVA: 0x0012F48C File Offset: 0x0012D68C
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

		// Token: 0x06007EB3 RID: 32435 RVA: 0x0012F49F File Offset: 0x0012D69F
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

		// Token: 0x06007EB4 RID: 32436 RVA: 0x0012F4B2 File Offset: 0x0012D6B2
		public new IActorFaceExpressionPlay_SetValue ToSetValue()
		{
			return new IActorFaceExpressionPlay_SetValue
			{
				Type = this.Type,
				FaceExpressionId = this.FaceExpressionId,
				DelayTime = this.DelayTime
			};
		}

		// Token: 0x1700299D RID: 10653
		// (get) Token: 0x06007EB5 RID: 32437 RVA: 0x0012F4DD File Offset: 0x0012D6DD
		// (set) Token: 0x06007EB6 RID: 32438 RVA: 0x0012F508 File Offset: 0x0012D708
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

		// Token: 0x1700299E RID: 10654
		// (get) Token: 0x06007EB7 RID: 32439 RVA: 0x0012F516 File Offset: 0x0012D716
		// (set) Token: 0x06007EB8 RID: 32440 RVA: 0x0012F541 File Offset: 0x0012D741
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

		// Token: 0x1700299F RID: 10655
		// (get) Token: 0x06007EB9 RID: 32441 RVA: 0x0012F550 File Offset: 0x0012D750
		// (set) Token: 0x06007EBA RID: 32442 RVA: 0x0012F58A File Offset: 0x0012D78A
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

		// Token: 0x040050A6 RID: 20646
		[Nullable(2)]
		protected new IActorFaceExpressionPlay FbInstance;

		// Token: 0x040050A7 RID: 20647
		[Nullable(2)]
		protected new IActorFaceExpressionPlay_SetValue PocoInterface;
	}
}
