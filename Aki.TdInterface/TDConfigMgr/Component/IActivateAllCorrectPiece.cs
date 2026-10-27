using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200019D RID: 413
	[NullableContext(1)]
	[Nullable(0)]
	public class IActivateAllCorrectPiece : IJigsawCompleteCondition
	{
		// Token: 0x06000646 RID: 1606 RVA: 0x00022968 File Offset: 0x00020B68
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

		// Token: 0x06000647 RID: 1607 RVA: 0x000229A0 File Offset: 0x00020BA0
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

		// Token: 0x06000648 RID: 1608 RVA: 0x000229B3 File Offset: 0x00020BB3
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

		// Token: 0x06000649 RID: 1609 RVA: 0x000229C6 File Offset: 0x00020BC6
		public new IActivateAllCorrectPiece_SetValue ToSetValue()
		{
			return new IActivateAllCorrectPiece_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600064A RID: 1610 RVA: 0x000229D9 File Offset: 0x00020BD9
		// (set) Token: 0x0600064B RID: 1611 RVA: 0x00022A04 File Offset: 0x00020C04
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

		// Token: 0x040007FD RID: 2045
		[Nullable(2)]
		protected new IActivateAllCorrectPiece FbInstance;

		// Token: 0x040007FE RID: 2046
		[Nullable(2)]
		protected new IActivateAllCorrectPiece_SetValue PocoInterface;
	}
}
