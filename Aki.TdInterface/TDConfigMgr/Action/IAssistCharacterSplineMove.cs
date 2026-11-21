using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001965 RID: 6501
	public class IAssistCharacterSplineMove : IAssistCharacterMoveType
	{
		// Token: 0x06008A3F RID: 35391 RVA: 0x00148C18 File Offset: 0x00146E18
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

		// Token: 0x06008A40 RID: 35392 RVA: 0x00148C50 File Offset: 0x00146E50
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

		// Token: 0x06008A41 RID: 35393 RVA: 0x00148C63 File Offset: 0x00146E63
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

		// Token: 0x06008A42 RID: 35394 RVA: 0x00148C76 File Offset: 0x00146E76
		public new IAssistCharacterSplineMove_SetValue ToSetValue()
		{
			return new IAssistCharacterSplineMove_SetValue
			{
				Type = this.Type,
				SplineId = this.SplineId
			};
		}

		// Token: 0x17002D14 RID: 11540
		// (get) Token: 0x06008A43 RID: 35395 RVA: 0x00148C95 File Offset: 0x00146E95
		// (set) Token: 0x06008A44 RID: 35396 RVA: 0x00148CC0 File Offset: 0x00146EC0
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

		// Token: 0x17002D15 RID: 11541
		// (get) Token: 0x06008A45 RID: 35397 RVA: 0x00148CCE File Offset: 0x00146ECE
		// (set) Token: 0x06008A46 RID: 35398 RVA: 0x00148CF9 File Offset: 0x00146EF9
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

		// Token: 0x0400578F RID: 22415
		[Nullable(2)]
		protected new IAssistCharacterSplineMove FbInstance;

		// Token: 0x04005790 RID: 22416
		[Nullable(2)]
		protected new IAssistCharacterSplineMove_SetValue PocoInterface;
	}
}
