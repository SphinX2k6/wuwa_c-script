using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DA2 RID: 7586
	[NullableContext(2)]
	[Nullable(0)]
	public class IRenjuChess : IUiGame
	{
		// Token: 0x0600A293 RID: 41619 RVA: 0x00171AEC File Offset: 0x0016FCEC
		[NullableContext(1)]
		private IRenjuChess_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRenjuChess 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRenjuChess_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRenjuChess_SetValue());
			}
			return result;
		}

		// Token: 0x0600A294 RID: 41620 RVA: 0x00171B24 File Offset: 0x0016FD24
		[NullableContext(1)]
		public static IRenjuChess Create([Nullable(2)] IRenjuChess instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRenjuChess
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A295 RID: 41621 RVA: 0x00171B37 File Offset: 0x0016FD37
		[NullableContext(1)]
		public static IRenjuChess CreateFromSetValue([Nullable(2)] IRenjuChess_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRenjuChess
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A296 RID: 41622 RVA: 0x00171B4A File Offset: 0x0016FD4A
		[NullableContext(1)]
		public new IRenjuChess_SetValue ToSetValue()
		{
			return new IRenjuChess_SetValue
			{
				Type = this.Type,
				Chessboard = this.Chessboard,
				CameraConfig = this.CameraConfig
			};
		}

		// Token: 0x1700322D RID: 12845
		// (get) Token: 0x0600A297 RID: 41623 RVA: 0x00171B75 File Offset: 0x0016FD75
		// (set) Token: 0x0600A298 RID: 41624 RVA: 0x00171BA0 File Offset: 0x0016FDA0
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700322E RID: 12846
		// (get) Token: 0x0600A299 RID: 41625 RVA: 0x00171BAE File Offset: 0x0016FDAE
		// (set) Token: 0x0600A29A RID: 41626 RVA: 0x00171BD9 File Offset: 0x0016FDD9
		public virtual int Chessboard
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Chessboard;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Chessboard;
			}
			set
			{
				this.GetOrCreatePoco().Chessboard = value;
			}
		}

		// Token: 0x1700322F RID: 12847
		// (get) Token: 0x0600A29B RID: 41627 RVA: 0x00171BE7 File Offset: 0x0016FDE7
		// (set) Token: 0x0600A29C RID: 41628 RVA: 0x00171C0E File Offset: 0x0016FE0E
		public virtual IAdjustPlayerCameraType CameraConfig
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CameraConfig;
				}
				IRenjuChess_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CameraConfig;
			}
			set
			{
				this.GetOrCreatePoco().CameraConfig = value;
			}
		}

		// Token: 0x040061A0 RID: 24992
		protected new IRenjuChess FbInstance;

		// Token: 0x040061A1 RID: 24993
		protected new IRenjuChess_SetValue PocoInterface;
	}
}
