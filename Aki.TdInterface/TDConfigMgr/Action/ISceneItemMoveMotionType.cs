using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FFB RID: 8187
	public class ISceneItemMoveMotionType
	{
		// Token: 0x0600ADD9 RID: 44505 RVA: 0x001883F8 File Offset: 0x001865F8
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

		// Token: 0x0600ADDA RID: 44506 RVA: 0x00188430 File Offset: 0x00186630
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

		// Token: 0x0600ADDB RID: 44507 RVA: 0x00188443 File Offset: 0x00186643
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

		// Token: 0x0600ADDC RID: 44508 RVA: 0x00188456 File Offset: 0x00186656
		public ISceneItemMoveMotionType_SetValue ToSetValue()
		{
			return new ISceneItemMoveMotionType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003502 RID: 13570
		// (get) Token: 0x0600ADDD RID: 44509 RVA: 0x00188469 File Offset: 0x00186669
		// (set) Token: 0x0600ADDE RID: 44510 RVA: 0x00188494 File Offset: 0x00186694
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

		// Token: 0x040067B5 RID: 26549
		[Nullable(2)]
		protected ISceneItemMoveMotionType FbInstance;

		// Token: 0x040067B6 RID: 26550
		[Nullable(2)]
		protected ISceneItemMoveMotionType_SetValue PocoInterface;
	}
}
