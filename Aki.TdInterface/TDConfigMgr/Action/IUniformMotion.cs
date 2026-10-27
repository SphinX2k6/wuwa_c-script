using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002019 RID: 8217
	[NullableContext(1)]
	[Nullable(0)]
	public class IUniformMotion : ISceneItemMoveMotionType
	{
		// Token: 0x0600B4AE RID: 46254 RVA: 0x001A40B4 File Offset: 0x001A22B4
		private IUniformMotion_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IUniformMotion 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IUniformMotion_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IUniformMotion_SetValue());
			}
			return result;
		}

		// Token: 0x0600B4AF RID: 46255 RVA: 0x001A40EC File Offset: 0x001A22EC
		public static IUniformMotion Create([Nullable(2)] IUniformMotion instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IUniformMotion
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B4B0 RID: 46256 RVA: 0x001A40FF File Offset: 0x001A22FF
		public static IUniformMotion CreateFromSetValue([Nullable(2)] IUniformMotion_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IUniformMotion
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B4B1 RID: 46257 RVA: 0x001A4112 File Offset: 0x001A2312
		public new IUniformMotion_SetValue ToSetValue()
		{
			return new IUniformMotion_SetValue
			{
				Type = this.Type,
				Time = this.Time
			};
		}

		// Token: 0x1700378A RID: 14218
		// (get) Token: 0x0600B4B2 RID: 46258 RVA: 0x001A4131 File Offset: 0x001A2331
		// (set) Token: 0x0600B4B3 RID: 46259 RVA: 0x001A415C File Offset: 0x001A235C
		public override EMoveMotion Type
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

		// Token: 0x1700378B RID: 14219
		// (get) Token: 0x0600B4B4 RID: 46260 RVA: 0x001A416A File Offset: 0x001A236A
		// (set) Token: 0x0600B4B5 RID: 46261 RVA: 0x001A4199 File Offset: 0x001A2399
		public virtual float Time
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Time;
				}
				if (this.PocoInterface == null)
				{
					return 0f;
				}
				return this.PocoInterface.Time;
			}
			set
			{
				this.GetOrCreatePoco().Time = value;
			}
		}

		// Token: 0x04006CDB RID: 27867
		[Nullable(2)]
		protected new IUniformMotion FbInstance;

		// Token: 0x04006CDC RID: 27868
		[Nullable(2)]
		protected new IUniformMotion_SetValue PocoInterface;
	}
}
