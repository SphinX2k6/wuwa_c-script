using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FB7 RID: 8119
	public class IRemoveScreenEffect : IRemoveEffectBase
	{
		// Token: 0x0600AC93 RID: 44179 RVA: 0x00186114 File Offset: 0x00184314
		private IRemoveScreenEffect_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRemoveScreenEffect 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRemoveScreenEffect_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRemoveScreenEffect_SetValue());
			}
			return result;
		}

		// Token: 0x0600AC94 RID: 44180 RVA: 0x0018614C File Offset: 0x0018434C
		public static IRemoveScreenEffect Create([Nullable(2)] IRemoveScreenEffect instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemoveScreenEffect
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AC95 RID: 44181 RVA: 0x0018615F File Offset: 0x0018435F
		public static IRemoveScreenEffect CreateFromSetValue([Nullable(2)] IRemoveScreenEffect_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRemoveScreenEffect
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AC96 RID: 44182 RVA: 0x00186172 File Offset: 0x00184372
		public new IRemoveScreenEffect_SetValue ToSetValue()
		{
			return new IRemoveScreenEffect_SetValue
			{
				Type = this.Type,
				Path = this.Path
			};
		}

		// Token: 0x170034C5 RID: 13509
		// (get) Token: 0x0600AC97 RID: 44183 RVA: 0x00186191 File Offset: 0x00184391
		// (set) Token: 0x0600AC98 RID: 44184 RVA: 0x001861BC File Offset: 0x001843BC
		public override EEffectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EEffectType.Effect;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170034C6 RID: 13510
		// (get) Token: 0x0600AC99 RID: 44185 RVA: 0x001861CA File Offset: 0x001843CA
		// (set) Token: 0x0600AC9A RID: 44186 RVA: 0x001861F5 File Offset: 0x001843F5
		public override string Path
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Path;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Path;
			}
			set
			{
				this.GetOrCreatePoco().Path = value;
			}
		}

		// Token: 0x04006724 RID: 26404
		[Nullable(2)]
		protected new IRemoveScreenEffect FbInstance;

		// Token: 0x04006725 RID: 26405
		[Nullable(2)]
		protected new IRemoveScreenEffect_SetValue PocoInterface;
	}
}
