using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A7D RID: 6781
	public class IColorPiece
	{
		// Token: 0x06009011 RID: 36881 RVA: 0x001530D4 File Offset: 0x001512D4
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

		// Token: 0x06009012 RID: 36882 RVA: 0x0015310C File Offset: 0x0015130C
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

		// Token: 0x06009013 RID: 36883 RVA: 0x0015311F File Offset: 0x0015131F
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

		// Token: 0x06009014 RID: 36884 RVA: 0x00153132 File Offset: 0x00151332
		public IColorPiece_SetValue ToSetValue()
		{
			return new IColorPiece_SetValue
			{
				Color = this.Color
			};
		}

		// Token: 0x17002E59 RID: 11865
		// (get) Token: 0x06009015 RID: 36885 RVA: 0x00153145 File Offset: 0x00151345
		// (set) Token: 0x06009016 RID: 36886 RVA: 0x00153170 File Offset: 0x00151370
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

		// Token: 0x04005A2E RID: 23086
		[Nullable(2)]
		protected IColorPiece FbInstance;

		// Token: 0x04005A2F RID: 23087
		[Nullable(2)]
		protected IColorPiece_SetValue PocoInterface;
	}
}
