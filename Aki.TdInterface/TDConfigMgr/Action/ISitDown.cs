using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E73 RID: 7795
	[NullableContext(1)]
	[Nullable(0)]
	public class ISitDown : ILeisureInteractType
	{
		// Token: 0x0600A6D8 RID: 42712 RVA: 0x00179720 File Offset: 0x00177920
		private ISitDown_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISitDown 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISitDown_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISitDown_SetValue());
			}
			return result;
		}

		// Token: 0x0600A6D9 RID: 42713 RVA: 0x00179758 File Offset: 0x00177958
		public static ISitDown Create([Nullable(2)] ISitDown instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISitDown
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A6DA RID: 42714 RVA: 0x0017976B File Offset: 0x0017796B
		public static ISitDown CreateFromSetValue([Nullable(2)] ISitDown_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISitDown
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A6DB RID: 42715 RVA: 0x0017977E File Offset: 0x0017797E
		public new ISitDown_SetValue ToSetValue()
		{
			return new ISitDown_SetValue
			{
				Type = this.Type,
				OnlyAllowForwardStandUp = this.OnlyAllowForwardStandUp
			};
		}

		// Token: 0x17003317 RID: 13079
		// (get) Token: 0x0600A6DC RID: 42716 RVA: 0x0017979D File Offset: 0x0017799D
		// (set) Token: 0x0600A6DD RID: 42717 RVA: 0x001797C8 File Offset: 0x001779C8
		public override ELeisureInteract Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELeisureInteract.CustomSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003318 RID: 13080
		// (get) Token: 0x0600A6DE RID: 42718 RVA: 0x001797D8 File Offset: 0x001779D8
		// (set) Token: 0x0600A6DF RID: 42719 RVA: 0x00179812 File Offset: 0x00177A12
		public virtual bool? OnlyAllowForwardStandUp
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.OnlyAllowForwardStandUp;
				}
				ISitDown_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.OnlyAllowForwardStandUp;
			}
			set
			{
				this.GetOrCreatePoco().OnlyAllowForwardStandUp = value;
			}
		}

		// Token: 0x040063A0 RID: 25504
		[Nullable(2)]
		protected new ISitDown FbInstance;

		// Token: 0x040063A1 RID: 25505
		[Nullable(2)]
		protected new ISitDown_SetValue PocoInterface;
	}
}
