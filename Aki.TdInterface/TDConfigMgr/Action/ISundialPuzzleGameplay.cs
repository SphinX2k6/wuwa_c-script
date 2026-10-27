using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EEF RID: 7919
	[NullableContext(1)]
	[Nullable(0)]
	public class ISundialPuzzleGameplay : IUiGame
	{
		// Token: 0x0600A962 RID: 43362 RVA: 0x0017DF40 File Offset: 0x0017C140
		private ISundialPuzzleGameplay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISundialPuzzleGameplay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISundialPuzzleGameplay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISundialPuzzleGameplay_SetValue());
			}
			return result;
		}

		// Token: 0x0600A963 RID: 43363 RVA: 0x0017DF78 File Offset: 0x0017C178
		public static ISundialPuzzleGameplay Create([Nullable(2)] ISundialPuzzleGameplay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISundialPuzzleGameplay
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A964 RID: 43364 RVA: 0x0017DF8B File Offset: 0x0017C18B
		public static ISundialPuzzleGameplay CreateFromSetValue([Nullable(2)] ISundialPuzzleGameplay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISundialPuzzleGameplay
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A965 RID: 43365 RVA: 0x0017DF9E File Offset: 0x0017C19E
		public new ISundialPuzzleGameplay_SetValue ToSetValue()
		{
			return new ISundialPuzzleGameplay_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170033A2 RID: 13218
		// (get) Token: 0x0600A966 RID: 43366 RVA: 0x0017DFB1 File Offset: 0x0017C1B1
		// (set) Token: 0x0600A967 RID: 43367 RVA: 0x0017DFDC File Offset: 0x0017C1DC
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

		// Token: 0x040064C7 RID: 25799
		[Nullable(2)]
		protected new ISundialPuzzleGameplay FbInstance;

		// Token: 0x040064C8 RID: 25800
		[Nullable(2)]
		protected new ISundialPuzzleGameplay_SetValue PocoInterface;
	}
}
