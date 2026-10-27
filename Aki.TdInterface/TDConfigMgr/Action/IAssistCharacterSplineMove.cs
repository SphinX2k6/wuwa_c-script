using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020017DE RID: 6110
	[NullableContext(1)]
	[Nullable(0)]
	public class IAssistCharacterSplineMove : IAssistCharacterMoveType
	{
		// Token: 0x0600832D RID: 33581 RVA: 0x00139630 File Offset: 0x00137830
		private IAssistCharacterSplineMove_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAssistCharacterSplineMove 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAssistCharacterSplineMove_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAssistCharacterSplineMove_SetValue());
			}
			return result;
		}

		// Token: 0x0600832E RID: 33582 RVA: 0x00139668 File Offset: 0x00137868
		public static IAssistCharacterSplineMove Create([Nullable(2)] IAssistCharacterSplineMove instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAssistCharacterSplineMove
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600832F RID: 33583 RVA: 0x0013967B File Offset: 0x0013787B
		public static IAssistCharacterSplineMove CreateFromSetValue([Nullable(2)] IAssistCharacterSplineMove_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAssistCharacterSplineMove
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008330 RID: 33584 RVA: 0x0013968E File Offset: 0x0013788E
		public new IAssistCharacterSplineMove_SetValue ToSetValue()
		{
			return new IAssistCharacterSplineMove_SetValue
			{
				Type = this.Type,
				SplineId = this.SplineId
			};
		}

		// Token: 0x17002B1E RID: 11038
		// (get) Token: 0x06008331 RID: 33585 RVA: 0x001396AD File Offset: 0x001378AD
		// (set) Token: 0x06008332 RID: 33586 RVA: 0x001396D8 File Offset: 0x001378D8
		public override EAssistCharacterMoveType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAssistCharacterMoveType.Navigation;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002B1F RID: 11039
		// (get) Token: 0x06008333 RID: 33587 RVA: 0x001396E6 File Offset: 0x001378E6
		// (set) Token: 0x06008334 RID: 33588 RVA: 0x00139711 File Offset: 0x00137911
		public virtual int SplineId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SplineId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SplineId;
			}
			set
			{
				this.GetOrCreatePoco().SplineId = value;
			}
		}

		// Token: 0x0400534B RID: 21323
		[Nullable(2)]
		protected new IAssistCharacterSplineMove FbInstance;

		// Token: 0x0400534C RID: 21324
		[Nullable(2)]
		protected new IAssistCharacterSplineMove_SetValue PocoInterface;
	}
}
