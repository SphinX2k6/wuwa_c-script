using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002129 RID: 8489
	[NullableContext(1)]
	[Nullable(0)]
	public class PreloadAction : ActionParams
	{
		// Token: 0x0600BB06 RID: 47878 RVA: 0x001B0200 File Offset: 0x001AE400
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

		// Token: 0x0600BB07 RID: 47879 RVA: 0x001B0238 File Offset: 0x001AE438
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

		// Token: 0x0600BB08 RID: 47880 RVA: 0x001B024B File Offset: 0x001AE44B
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

		// Token: 0x0600BB09 RID: 47881 RVA: 0x001B025E File Offset: 0x001AE45E
		public PreloadAction_SetValue ToSetValue()
		{
			return new PreloadAction_SetValue
			{
				PreloadObjectType = this.PreloadObjectType
			};
		}

		// Token: 0x1700391F RID: 14623
		// (get) Token: 0x0600BB0A RID: 47882 RVA: 0x001B0271 File Offset: 0x001AE471
		// (set) Token: 0x0600BB0B RID: 47883 RVA: 0x001B0298 File Offset: 0x001AE498
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

		// Token: 0x04006FE8 RID: 28648
		[Nullable(2)]
		protected new PreloadAction FbInstance;

		// Token: 0x04006FE9 RID: 28649
		[Nullable(2)]
		protected PreloadAction_SetValue PocoInterface;
	}
}
