using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FB9 RID: 8121
	public class IRenjuChess : IUiGame
	{
		// Token: 0x0600AC9D RID: 44189 RVA: 0x00186214 File Offset: 0x00184414
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

		// Token: 0x0600AC9E RID: 44190 RVA: 0x0018624C File Offset: 0x0018444C
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

		// Token: 0x0600AC9F RID: 44191 RVA: 0x0018625F File Offset: 0x0018445F
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

		// Token: 0x0600ACA0 RID: 44192 RVA: 0x00186272 File Offset: 0x00184472
		public new IRenjuChess_SetValue ToSetValue()
		{
			return new IRenjuChess_SetValue
			{
				Type = this.Type,
				Chessboard = this.Chessboard,
				CameraConfig = this.CameraConfig
			};
		}

		// Token: 0x170034C7 RID: 13511
		// (get) Token: 0x0600ACA1 RID: 44193 RVA: 0x0018629D File Offset: 0x0018449D
		// (set) Token: 0x0600ACA2 RID: 44194 RVA: 0x001862C8 File Offset: 0x001844C8
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

		// Token: 0x170034C8 RID: 13512
		// (get) Token: 0x0600ACA3 RID: 44195 RVA: 0x001862D6 File Offset: 0x001844D6
		// (set) Token: 0x0600ACA4 RID: 44196 RVA: 0x00186301 File Offset: 0x00184501
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

		// Token: 0x170034C9 RID: 13513
		// (get) Token: 0x0600ACA5 RID: 44197 RVA: 0x0018630F File Offset: 0x0018450F
		// (set) Token: 0x0600ACA6 RID: 44198 RVA: 0x00186336 File Offset: 0x00184536
		[Nullable(2)]
		public virtual IAdjustPlayerCameraType CameraConfig
		{
			[NullableContext(2)]
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
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().CameraConfig = value;
			}
		}

		// Token: 0x04006728 RID: 26408
		[Nullable(2)]
		protected new IRenjuChess FbInstance;

		// Token: 0x04006729 RID: 26409
		[Nullable(2)]
		protected new IRenjuChess_SetValue PocoInterface;
	}
}
