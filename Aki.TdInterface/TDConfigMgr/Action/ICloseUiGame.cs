using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018F0 RID: 6384
	[NullableContext(1)]
	[Nullable(0)]
	public class ICloseUiGame
	{
		// Token: 0x060088D9 RID: 35033 RVA: 0x00143694 File Offset: 0x00141894
		private ICloseUiGame_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICloseUiGame 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICloseUiGame_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICloseUiGame_SetValue());
			}
			return result;
		}

		// Token: 0x060088DA RID: 35034 RVA: 0x001436CC File Offset: 0x001418CC
		public static ICloseUiGame Create([Nullable(2)] ICloseUiGame instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICloseUiGame
			{
				FbInstance = instance
			};
		}

		// Token: 0x060088DB RID: 35035 RVA: 0x001436DF File Offset: 0x001418DF
		public static ICloseUiGame CreateFromSetValue([Nullable(2)] ICloseUiGame_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICloseUiGame
			{
				PocoInterface = value
			};
		}

		// Token: 0x060088DC RID: 35036 RVA: 0x001436F2 File Offset: 0x001418F2
		public ICloseUiGame_SetValue ToSetValue()
		{
			return new ICloseUiGame_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002C59 RID: 11353
		// (get) Token: 0x060088DD RID: 35037 RVA: 0x00143705 File Offset: 0x00141905
		// (set) Token: 0x060088DE RID: 35038 RVA: 0x00143730 File Offset: 0x00141930
		public virtual ESimpleGameplayType Type
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

		// Token: 0x040055D8 RID: 21976
		[Nullable(2)]
		protected ICloseUiGame FbInstance;

		// Token: 0x040055D9 RID: 21977
		[Nullable(2)]
		protected ICloseUiGame_SetValue PocoInterface;
	}
}
