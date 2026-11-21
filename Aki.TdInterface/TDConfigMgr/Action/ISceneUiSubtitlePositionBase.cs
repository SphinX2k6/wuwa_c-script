using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200200F RID: 8207
	public class ISceneUiSubtitlePositionBase
	{
		// Token: 0x0600AE45 RID: 44613 RVA: 0x00189098 File Offset: 0x00187298
		private ISceneUiSubtitlePositionBase_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneUiSubtitlePositionBase 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneUiSubtitlePositionBase_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneUiSubtitlePositionBase_SetValue());
			}
			return result;
		}

		// Token: 0x0600AE46 RID: 44614 RVA: 0x001890D0 File Offset: 0x001872D0
		public static ISceneUiSubtitlePositionBase Create([Nullable(2)] ISceneUiSubtitlePositionBase instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitlePositionBase
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AE47 RID: 44615 RVA: 0x001890E3 File Offset: 0x001872E3
		public static ISceneUiSubtitlePositionBase CreateFromSetValue([Nullable(2)] ISceneUiSubtitlePositionBase_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneUiSubtitlePositionBase
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AE48 RID: 44616 RVA: 0x001890F6 File Offset: 0x001872F6
		public ISceneUiSubtitlePositionBase_SetValue ToSetValue()
		{
			return new ISceneUiSubtitlePositionBase_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700351A RID: 13594
		// (get) Token: 0x0600AE49 RID: 44617 RVA: 0x00189109 File Offset: 0x00187309
		// (set) Token: 0x0600AE4A RID: 44618 RVA: 0x00189134 File Offset: 0x00187334
		public virtual ESceneUiSubtitlePositionType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneUiSubtitlePositionType.Position;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040067E9 RID: 26601
		[Nullable(2)]
		protected ISceneUiSubtitlePositionBase FbInstance;

		// Token: 0x040067EA RID: 26602
		[Nullable(2)]
		protected ISceneUiSubtitlePositionBase_SetValue PocoInterface;
	}
}
