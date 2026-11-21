using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200201B RID: 8219
	public class ISceneUiSubtitleTextKey : ISceneUiSubtitleTextBase
	{
		// Token: 0x0600AE89 RID: 44681 RVA: 0x001898B8 File Offset: 0x00187AB8
		private ISceneUiSubtitleTextKey_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneUiSubtitleTextKey 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneUiSubtitleTextKey_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneUiSubtitleTextKey_SetValue());
			}
			return result;
		}

		// Token: 0x0600AE8A RID: 44682 RVA: 0x001898F0 File Offset: 0x00187AF0
		public static ISceneUiSubtitleTextKey Create([Nullable(2)] ISceneUiSubtitleTextKey instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneUiSubtitleTextKey
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AE8B RID: 44683 RVA: 0x00189903 File Offset: 0x00187B03
		public static ISceneUiSubtitleTextKey CreateFromSetValue([Nullable(2)] ISceneUiSubtitleTextKey_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneUiSubtitleTextKey
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AE8C RID: 44684 RVA: 0x00189916 File Offset: 0x00187B16
		public new ISceneUiSubtitleTextKey_SetValue ToSetValue()
		{
			return new ISceneUiSubtitleTextKey_SetValue
			{
				Type = this.Type,
				TextKey = this.TextKey
			};
		}

		// Token: 0x1700352A RID: 13610
		// (get) Token: 0x0600AE8D RID: 44685 RVA: 0x00189935 File Offset: 0x00187B35
		// (set) Token: 0x0600AE8E RID: 44686 RVA: 0x00189960 File Offset: 0x00187B60
		public override ESceneUiSubtitleTextType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESceneUiSubtitleTextType.Flow;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700352B RID: 13611
		// (get) Token: 0x0600AE8F RID: 44687 RVA: 0x0018996E File Offset: 0x00187B6E
		// (set) Token: 0x0600AE90 RID: 44688 RVA: 0x00189999 File Offset: 0x00187B99
		public virtual string TextKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TextKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TextKey;
			}
			set
			{
				this.GetOrCreatePoco().TextKey = value;
			}
		}

		// Token: 0x0400680B RID: 26635
		[Nullable(2)]
		protected new ISceneUiSubtitleTextKey FbInstance;

		// Token: 0x0400680C RID: 26636
		[Nullable(2)]
		protected new ISceneUiSubtitleTextKey_SetValue PocoInterface;
	}
}
