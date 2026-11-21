using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001B4 RID: 436
	public class IActivateAllCorrectPiece : IJigsawCompleteCondition
	{
		// Token: 0x0600065C RID: 1628 RVA: 0x000235C8 File Offset: 0x000217C8
		private IActivateAllCorrectPiece_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IActivateAllCorrectPiece 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IActivateAllCorrectPiece_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IActivateAllCorrectPiece_SetValue());
			}
			return result;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00023600 File Offset: 0x00021800
		public static IActivateAllCorrectPiece Create([Nullable(2)] IActivateAllCorrectPiece instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IActivateAllCorrectPiece
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00023613 File Offset: 0x00021813
		public static IActivateAllCorrectPiece CreateFromSetValue([Nullable(2)] IActivateAllCorrectPiece_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IActivateAllCorrectPiece
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00023626 File Offset: 0x00021826
		public new IActivateAllCorrectPiece_SetValue ToSetValue()
		{
			return new IActivateAllCorrectPiece_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x00023639 File Offset: 0x00021839
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x00023664 File Offset: 0x00021864
		public override EJigsawCompleteCondition Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EJigsawCompleteCondition.ActivateAllCorrectPiece;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000856 RID: 2134
		[Nullable(2)]
		protected new IActivateAllCorrectPiece FbInstance;

		// Token: 0x04000857 RID: 2135
		[Nullable(2)]
		protected new IActivateAllCorrectPiece_SetValue PocoInterface;
	}
}
