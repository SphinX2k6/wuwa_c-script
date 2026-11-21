using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200238A RID: 9098
	public class PreloadAction : ActionParams
	{
		// Token: 0x0600C694 RID: 50836 RVA: 0x001C73B4 File Offset: 0x001C55B4
		private PreloadAction_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("PreloadAction 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			PreloadAction_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new PreloadAction_SetValue());
			}
			return result;
		}

		// Token: 0x0600C695 RID: 50837 RVA: 0x001C73EC File Offset: 0x001C55EC
		public static PreloadAction Create([Nullable(2)] PreloadAction instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new PreloadAction
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600C696 RID: 50838 RVA: 0x001C73FF File Offset: 0x001C55FF
		public static PreloadAction CreateFromSetValue([Nullable(2)] PreloadAction_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new PreloadAction
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600C697 RID: 50839 RVA: 0x001C7412 File Offset: 0x001C5612
		public PreloadAction_SetValue ToSetValue()
		{
			return new PreloadAction_SetValue
			{
				PreloadObjectType = this.PreloadObjectType
			};
		}

		// Token: 0x17003C0C RID: 15372
		// (get) Token: 0x0600C698 RID: 50840 RVA: 0x001C7425 File Offset: 0x001C5625
		// (set) Token: 0x0600C699 RID: 50841 RVA: 0x001C744C File Offset: 0x001C564C
		public virtual IPreloadCharacterType PreloadObjectType
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PreloadObjectType;
				}
				PreloadAction_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PreloadObjectType;
			}
			set
			{
				this.GetOrCreatePoco().PreloadObjectType = value;
			}
		}

		// Token: 0x0400761D RID: 30237
		[Nullable(2)]
		protected new PreloadAction FbInstance;

		// Token: 0x0400761E RID: 30238
		[Nullable(2)]
		protected PreloadAction_SetValue PocoInterface;
	}
}
