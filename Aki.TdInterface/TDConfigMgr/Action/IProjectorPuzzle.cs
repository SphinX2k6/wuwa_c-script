using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F6D RID: 8045
	public class IProjectorPuzzle : IUiGame
	{
		// Token: 0x0600AB27 RID: 43815 RVA: 0x00183AF8 File Offset: 0x00181CF8
		private IProjectorPuzzle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IProjectorPuzzle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IProjectorPuzzle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IProjectorPuzzle_SetValue());
			}
			return result;
		}

		// Token: 0x0600AB28 RID: 43816 RVA: 0x00183B30 File Offset: 0x00181D30
		public static IProjectorPuzzle Create([Nullable(2)] IProjectorPuzzle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IProjectorPuzzle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AB29 RID: 43817 RVA: 0x00183B43 File Offset: 0x00181D43
		public static IProjectorPuzzle CreateFromSetValue([Nullable(2)] IProjectorPuzzle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IProjectorPuzzle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AB2A RID: 43818 RVA: 0x00183B56 File Offset: 0x00181D56
		public new IProjectorPuzzle_SetValue ToSetValue()
		{
			return new IProjectorPuzzle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700347E RID: 13438
		// (get) Token: 0x0600AB2B RID: 43819 RVA: 0x00183B69 File Offset: 0x00181D69
		// (set) Token: 0x0600AB2C RID: 43820 RVA: 0x00183B94 File Offset: 0x00181D94
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

		// Token: 0x0400668B RID: 26251
		[Nullable(2)]
		protected new IProjectorPuzzle FbInstance;

		// Token: 0x0400668C RID: 26252
		[Nullable(2)]
		protected new IProjectorPuzzle_SetValue PocoInterface;
	}
}
