using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D5C RID: 7516
	[NullableContext(1)]
	[Nullable(0)]
	public class IProjectorPuzzle : IUiGame
	{
		// Token: 0x0600A13B RID: 41275 RVA: 0x0016F6D4 File Offset: 0x0016D8D4
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

		// Token: 0x0600A13C RID: 41276 RVA: 0x0016F70C File Offset: 0x0016D90C
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

		// Token: 0x0600A13D RID: 41277 RVA: 0x0016F71F File Offset: 0x0016D91F
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

		// Token: 0x0600A13E RID: 41278 RVA: 0x0016F732 File Offset: 0x0016D932
		public new IProjectorPuzzle_SetValue ToSetValue()
		{
			return new IProjectorPuzzle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031EA RID: 12778
		// (get) Token: 0x0600A13F RID: 41279 RVA: 0x0016F745 File Offset: 0x0016D945
		// (set) Token: 0x0600A140 RID: 41280 RVA: 0x0016F770 File Offset: 0x0016D970
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

		// Token: 0x0400610F RID: 24847
		[Nullable(2)]
		protected new IProjectorPuzzle FbInstance;

		// Token: 0x04006110 RID: 24848
		[Nullable(2)]
		protected new IProjectorPuzzle_SetValue PocoInterface;
	}
}
