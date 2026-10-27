using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DE2 RID: 7650
	[NullableContext(1)]
	[Nullable(0)]
	public class ISceneItemMoveMotionType
	{
		// Token: 0x0600A3C3 RID: 41923 RVA: 0x00173BA0 File Offset: 0x00171DA0
		private ISceneItemMoveMotionType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISceneItemMoveMotionType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISceneItemMoveMotionType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISceneItemMoveMotionType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A3C4 RID: 41924 RVA: 0x00173BD8 File Offset: 0x00171DD8
		public static ISceneItemMoveMotionType Create([Nullable(2)] ISceneItemMoveMotionType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISceneItemMoveMotionType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A3C5 RID: 41925 RVA: 0x00173BEB File Offset: 0x00171DEB
		public static ISceneItemMoveMotionType CreateFromSetValue([Nullable(2)] ISceneItemMoveMotionType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISceneItemMoveMotionType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A3C6 RID: 41926 RVA: 0x00173BFE File Offset: 0x00171DFE
		public ISceneItemMoveMotionType_SetValue ToSetValue()
		{
			return new ISceneItemMoveMotionType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003265 RID: 12901
		// (get) Token: 0x0600A3C7 RID: 41927 RVA: 0x00173C11 File Offset: 0x00171E11
		// (set) Token: 0x0600A3C8 RID: 41928 RVA: 0x00173C3C File Offset: 0x00171E3C
		public virtual EMoveMotion Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EMoveMotion.UniformMotion;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006228 RID: 25128
		[Nullable(2)]
		protected ISceneItemMoveMotionType FbInstance;

		// Token: 0x04006229 RID: 25129
		[Nullable(2)]
		protected ISceneItemMoveMotionType_SetValue PocoInterface;
	}
}
