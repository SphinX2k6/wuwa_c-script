using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DA8 RID: 7592
	[NullableContext(1)]
	[Nullable(0)]
	public class IResetPlayerFocusToDefaultDirection : IResetPlayerFocusType
	{
		// Token: 0x0600A2B1 RID: 41649 RVA: 0x00171E2C File Offset: 0x0017002C
		private IResetPlayerFocusToDefaultDirection_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IResetPlayerFocusToDefaultDirection 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IResetPlayerFocusToDefaultDirection_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IResetPlayerFocusToDefaultDirection_SetValue());
			}
			return result;
		}

		// Token: 0x0600A2B2 RID: 41650 RVA: 0x00171E64 File Offset: 0x00170064
		public static IResetPlayerFocusToDefaultDirection Create([Nullable(2)] IResetPlayerFocusToDefaultDirection instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IResetPlayerFocusToDefaultDirection
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A2B3 RID: 41651 RVA: 0x00171E77 File Offset: 0x00170077
		public static IResetPlayerFocusToDefaultDirection CreateFromSetValue([Nullable(2)] IResetPlayerFocusToDefaultDirection_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IResetPlayerFocusToDefaultDirection
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A2B4 RID: 41652 RVA: 0x00171E8A File Offset: 0x0017008A
		public new IResetPlayerFocusToDefaultDirection_SetValue ToSetValue()
		{
			return new IResetPlayerFocusToDefaultDirection_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003233 RID: 12851
		// (get) Token: 0x0600A2B5 RID: 41653 RVA: 0x00171E9D File Offset: 0x0017009D
		// (set) Token: 0x0600A2B6 RID: 41654 RVA: 0x00171EC8 File Offset: 0x001700C8
		public override EResetPlayerFocusType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EResetPlayerFocusType.ResetToDefaultDirection;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040061AE RID: 25006
		[Nullable(2)]
		protected new IResetPlayerFocusToDefaultDirection FbInstance;

		// Token: 0x040061AF RID: 25007
		[Nullable(2)]
		protected new IResetPlayerFocusToDefaultDirection_SetValue PocoInterface;
	}
}
