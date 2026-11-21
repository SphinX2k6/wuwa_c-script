using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001967 RID: 6503
	public class IAssistCharacterSplineMoveTarget : ISplineMoveTargetType
	{
		// Token: 0x06008A49 RID: 35401 RVA: 0x00148D18 File Offset: 0x00146F18
		private IAssistCharacterSplineMoveTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAssistCharacterSplineMoveTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAssistCharacterSplineMoveTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAssistCharacterSplineMoveTarget_SetValue());
			}
			return result;
		}

		// Token: 0x06008A4A RID: 35402 RVA: 0x00148D50 File Offset: 0x00146F50
		public static IAssistCharacterSplineMoveTarget Create([Nullable(2)] IAssistCharacterSplineMoveTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAssistCharacterSplineMoveTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008A4B RID: 35403 RVA: 0x00148D63 File Offset: 0x00146F63
		public static IAssistCharacterSplineMoveTarget CreateFromSetValue([Nullable(2)] IAssistCharacterSplineMoveTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAssistCharacterSplineMoveTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008A4C RID: 35404 RVA: 0x00148D76 File Offset: 0x00146F76
		public new IAssistCharacterSplineMoveTarget_SetValue ToSetValue()
		{
			return new IAssistCharacterSplineMoveTarget_SetValue
			{
				Type = this.Type,
				TrailRoleId = this.TrailRoleId
			};
		}

		// Token: 0x17002D16 RID: 11542
		// (get) Token: 0x06008A4D RID: 35405 RVA: 0x00148D95 File Offset: 0x00146F95
		// (set) Token: 0x06008A4E RID: 35406 RVA: 0x00148DC0 File Offset: 0x00146FC0
		public override ESplineMoveTargetType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESplineMoveTargetType.Entity;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002D17 RID: 11543
		// (get) Token: 0x06008A4F RID: 35407 RVA: 0x00148DCE File Offset: 0x00146FCE
		// (set) Token: 0x06008A50 RID: 35408 RVA: 0x00148DF9 File Offset: 0x00146FF9
		public virtual int TrailRoleId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TrailRoleId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TrailRoleId;
			}
			set
			{
				this.GetOrCreatePoco().TrailRoleId = value;
			}
		}

		// Token: 0x04005793 RID: 22419
		[Nullable(2)]
		protected new IAssistCharacterSplineMoveTarget FbInstance;

		// Token: 0x04005794 RID: 22420
		[Nullable(2)]
		protected new IAssistCharacterSplineMoveTarget_SetValue PocoInterface;
	}
}
