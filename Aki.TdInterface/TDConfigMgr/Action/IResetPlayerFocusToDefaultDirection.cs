using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FBF RID: 8127
	public class IResetPlayerFocusToDefaultDirection : IResetPlayerFocusType
	{
		// Token: 0x0600ACBB RID: 44219 RVA: 0x00186554 File Offset: 0x00184754
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

		// Token: 0x0600ACBC RID: 44220 RVA: 0x0018658C File Offset: 0x0018478C
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

		// Token: 0x0600ACBD RID: 44221 RVA: 0x0018659F File Offset: 0x0018479F
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

		// Token: 0x0600ACBE RID: 44222 RVA: 0x001865B2 File Offset: 0x001847B2
		public new IResetPlayerFocusToDefaultDirection_SetValue ToSetValue()
		{
			return new IResetPlayerFocusToDefaultDirection_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170034CD RID: 13517
		// (get) Token: 0x0600ACBF RID: 44223 RVA: 0x001865C5 File Offset: 0x001847C5
		// (set) Token: 0x0600ACC0 RID: 44224 RVA: 0x001865F0 File Offset: 0x001847F0
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

		// Token: 0x04006736 RID: 26422
		[Nullable(2)]
		protected new IResetPlayerFocusToDefaultDirection FbInstance;

		// Token: 0x04006737 RID: 26423
		[Nullable(2)]
		protected new IResetPlayerFocusToDefaultDirection_SetValue PocoInterface;
	}
}
