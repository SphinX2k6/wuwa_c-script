using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018E3 RID: 6371
	public class IActorFaceExpressionStop : IActorFaceExpressionType
	{
		// Token: 0x060085AD RID: 34221 RVA: 0x0013E808 File Offset: 0x0013CA08
		private IActorFaceExpressionStop_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActorFaceExpressionStop 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActorFaceExpressionStop_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActorFaceExpressionStop_SetValue());
			}
			return result;
		}

		// Token: 0x060085AE RID: 34222 RVA: 0x0013E840 File Offset: 0x0013CA40
		public static IActorFaceExpressionStop Create([Nullable(2)] IActorFaceExpressionStop instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActorFaceExpressionStop
			{
				FbInstance = instance
			};
		}

		// Token: 0x060085AF RID: 34223 RVA: 0x0013E853 File Offset: 0x0013CA53
		public static IActorFaceExpressionStop CreateFromSetValue([Nullable(2)] IActorFaceExpressionStop_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActorFaceExpressionStop
			{
				PocoInterface = value
			};
		}

		// Token: 0x060085B0 RID: 34224 RVA: 0x0013E866 File Offset: 0x0013CA66
		public new IActorFaceExpressionStop_SetValue ToSetValue()
		{
			return new IActorFaceExpressionStop_SetValue
			{
				Type = this.Type,
				DelayTime = this.DelayTime
			};
		}

		// Token: 0x17002B8E RID: 11150
		// (get) Token: 0x060085B1 RID: 34225 RVA: 0x0013E885 File Offset: 0x0013CA85
		// (set) Token: 0x060085B2 RID: 34226 RVA: 0x0013E8B0 File Offset: 0x0013CAB0
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

		// Token: 0x17002B8F RID: 11151
		// (get) Token: 0x060085B3 RID: 34227 RVA: 0x0013E8C0 File Offset: 0x0013CAC0
		// (set) Token: 0x060085B4 RID: 34228 RVA: 0x0013E8FA File Offset: 0x0013CAFA
		public virtual float? DelayTime
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.DelayTime;
				}
				IActorFaceExpressionStop_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x040054E1 RID: 21729
		[Nullable(2)]
		protected new IActorFaceExpressionStop FbInstance;

		// Token: 0x040054E2 RID: 21730
		[Nullable(2)]
		protected new IActorFaceExpressionStop_SetValue PocoInterface;
	}
}
