using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018F6 RID: 6390
	[NullableContext(1)]
	[Nullable(0)]
	public class IColorPiece
	{
		// Token: 0x060088F3 RID: 35059 RVA: 0x0014394C File Offset: 0x00141B4C
		private IColorPiece_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IColorPiece 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IColorPiece_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IColorPiece_SetValue());
			}
			return result;
		}

		// Token: 0x060088F4 RID: 35060 RVA: 0x00143984 File Offset: 0x00141B84
		public static IColorPiece Create([Nullable(2)] IColorPiece instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IColorPiece
			{
				FbInstance = instance
			};
		}

		// Token: 0x060088F5 RID: 35061 RVA: 0x00143997 File Offset: 0x00141B97
		public static IColorPiece CreateFromSetValue([Nullable(2)] IColorPiece_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IColorPiece
			{
				PocoInterface = value
			};
		}

		// Token: 0x060088F6 RID: 35062 RVA: 0x001439AA File Offset: 0x00141BAA
		public IColorPiece_SetValue ToSetValue()
		{
			return new IColorPiece_SetValue
			{
				Color = this.Color
			};
		}

		// Token: 0x17002C5D RID: 11357
		// (get) Token: 0x060088F7 RID: 35063 RVA: 0x001439BD File Offset: 0x00141BBD
		// (set) Token: 0x060088F8 RID: 35064 RVA: 0x001439E8 File Offset: 0x00141BE8
		public virtual EPieceColorType Color
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Color;
				}
				if (this.PocoInterface == null)
				{
					return EPieceColorType.White;
				}
				return this.PocoInterface.Color;
			}
			set
			{
				this.GetOrCreatePoco().Color = value;
			}
		}

		// Token: 0x040055E4 RID: 21988
		[Nullable(2)]
		protected IColorPiece FbInstance;

		// Token: 0x040055E5 RID: 21989
		[Nullable(2)]
		protected IColorPiece_SetValue PocoInterface;
	}
}
