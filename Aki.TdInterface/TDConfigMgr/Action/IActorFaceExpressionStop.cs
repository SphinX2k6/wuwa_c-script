using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001762 RID: 5986
	[NullableContext(1)]
	[Nullable(0)]
	public class IActorFaceExpressionStop : IActorFaceExpressionType
	{
		// Token: 0x06007EBD RID: 32445 RVA: 0x0012F5A8 File Offset: 0x0012D7A8
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

		// Token: 0x06007EBE RID: 32446 RVA: 0x0012F5E0 File Offset: 0x0012D7E0
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

		// Token: 0x06007EBF RID: 32447 RVA: 0x0012F5F3 File Offset: 0x0012D7F3
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

		// Token: 0x06007EC0 RID: 32448 RVA: 0x0012F606 File Offset: 0x0012D806
		public new IActorFaceExpressionStop_SetValue ToSetValue()
		{
			return new IActorFaceExpressionStop_SetValue
			{
				Type = this.Type,
				DelayTime = this.DelayTime
			};
		}

		// Token: 0x170029A0 RID: 10656
		// (get) Token: 0x06007EC1 RID: 32449 RVA: 0x0012F625 File Offset: 0x0012D825
		// (set) Token: 0x06007EC2 RID: 32450 RVA: 0x0012F650 File Offset: 0x0012D850
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

		// Token: 0x170029A1 RID: 10657
		// (get) Token: 0x06007EC3 RID: 32451 RVA: 0x0012F660 File Offset: 0x0012D860
		// (set) Token: 0x06007EC4 RID: 32452 RVA: 0x0012F69A File Offset: 0x0012D89A
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

		// Token: 0x040050AB RID: 20651
		[Nullable(2)]
		protected new IActorFaceExpressionStop FbInstance;

		// Token: 0x040050AC RID: 20652
		[Nullable(2)]
		protected new IActorFaceExpressionStop_SetValue PocoInterface;
	}
}
