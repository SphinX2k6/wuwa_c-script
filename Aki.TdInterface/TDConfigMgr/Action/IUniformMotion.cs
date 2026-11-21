using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002262 RID: 8802
	public class IUniformMotion : ISceneItemMoveMotionType
	{
		// Token: 0x0600BFD4 RID: 49108 RVA: 0x001BA820 File Offset: 0x001B8A20
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

		// Token: 0x0600BFD5 RID: 49109 RVA: 0x001BA858 File Offset: 0x001B8A58
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

		// Token: 0x0600BFD6 RID: 49110 RVA: 0x001BA86B File Offset: 0x001B8A6B
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

		// Token: 0x0600BFD7 RID: 49111 RVA: 0x001BA87E File Offset: 0x001B8A7E
		public new IUniformMotion_SetValue ToSetValue()
		{
			return new IUniformMotion_SetValue
			{
				Type = this.Type,
				Time = this.Time
			};
		}

		// Token: 0x17003A67 RID: 14951
		// (get) Token: 0x0600BFD8 RID: 49112 RVA: 0x001BA89D File Offset: 0x001B8A9D
		// (set) Token: 0x0600BFD9 RID: 49113 RVA: 0x001BA8C8 File Offset: 0x001B8AC8
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

		// Token: 0x17003A68 RID: 14952
		// (get) Token: 0x0600BFDA RID: 49114 RVA: 0x001BA8D6 File Offset: 0x001B8AD6
		// (set) Token: 0x0600BFDB RID: 49115 RVA: 0x001BA905 File Offset: 0x001B8B05
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

		// Token: 0x040072E4 RID: 29412
		[Nullable(2)]
		protected new IUniformMotion FbInstance;

		// Token: 0x040072E5 RID: 29413
		[Nullable(2)]
		protected new IUniformMotion_SetValue PocoInterface;
	}
}
