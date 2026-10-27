using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200195A RID: 6490
	[NullableContext(1)]
	[Nullable(0)]
	public class ICustomSkill : ILeisureInteractType
	{
		// Token: 0x06008B07 RID: 35591 RVA: 0x00147154 File Offset: 0x00145354
		private ICustomSkill_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICustomSkill 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICustomSkill_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICustomSkill_SetValue());
			}
			return result;
		}

		// Token: 0x06008B08 RID: 35592 RVA: 0x0014718C File Offset: 0x0014538C
		public static ICustomSkill Create([Nullable(2)] ICustomSkill instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICustomSkill
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008B09 RID: 35593 RVA: 0x0014719F File Offset: 0x0014539F
		public static ICustomSkill CreateFromSetValue([Nullable(2)] ICustomSkill_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICustomSkill
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008B0A RID: 35594 RVA: 0x001471B2 File Offset: 0x001453B2
		public new ICustomSkill_SetValue ToSetValue()
		{
			return new ICustomSkill_SetValue
			{
				Type = this.Type,
				SkillId = this.SkillId
			};
		}

		// Token: 0x17002CD1 RID: 11473
		// (get) Token: 0x06008B0B RID: 35595 RVA: 0x001471D1 File Offset: 0x001453D1
		// (set) Token: 0x06008B0C RID: 35596 RVA: 0x001471FC File Offset: 0x001453FC
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

		// Token: 0x17002CD2 RID: 11474
		// (get) Token: 0x06008B0D RID: 35597 RVA: 0x0014720A File Offset: 0x0014540A
		// (set) Token: 0x06008B0E RID: 35598 RVA: 0x00147235 File Offset: 0x00145435
		public virtual int SkillId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkillId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.SkillId;
			}
			set
			{
				this.GetOrCreatePoco().SkillId = value;
			}
		}

		// Token: 0x040056CA RID: 22218
		[Nullable(2)]
		protected new ICustomSkill FbInstance;

		// Token: 0x040056CB RID: 22219
		[Nullable(2)]
		protected new ICustomSkill_SetValue PocoInterface;
	}
}
