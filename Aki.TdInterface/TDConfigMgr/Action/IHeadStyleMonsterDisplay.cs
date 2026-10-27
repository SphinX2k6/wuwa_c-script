using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AEF RID: 6895
	[NullableContext(1)]
	[Nullable(0)]
	public class IHeadStyleMonsterDisplay : IHeadStyle
	{
		// Token: 0x060093B4 RID: 37812 RVA: 0x00156910 File Offset: 0x00154B10
		private IHeadStyleMonsterDisplay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHeadStyleMonsterDisplay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHeadStyleMonsterDisplay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHeadStyleMonsterDisplay_SetValue());
			}
			return result;
		}

		// Token: 0x060093B5 RID: 37813 RVA: 0x00156948 File Offset: 0x00154B48
		public static IHeadStyleMonsterDisplay Create([Nullable(2)] IHeadStyleMonsterDisplay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyleMonsterDisplay
			{
				FbInstance = instance
			};
		}

		// Token: 0x060093B6 RID: 37814 RVA: 0x0015695B File Offset: 0x00154B5B
		public static IHeadStyleMonsterDisplay CreateFromSetValue([Nullable(2)] IHeadStyleMonsterDisplay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHeadStyleMonsterDisplay
			{
				PocoInterface = value
			};
		}

		// Token: 0x060093B7 RID: 37815 RVA: 0x0015696E File Offset: 0x00154B6E
		public new IHeadStyleMonsterDisplay_SetValue ToSetValue()
		{
			return new IHeadStyleMonsterDisplay_SetValue
			{
				Type = this.Type,
				MonsterDisplayId = this.MonsterDisplayId
			};
		}

		// Token: 0x17002EC9 RID: 11977
		// (get) Token: 0x060093B8 RID: 37816 RVA: 0x0015698D File Offset: 0x00154B8D
		// (set) Token: 0x060093B9 RID: 37817 RVA: 0x001569B8 File Offset: 0x00154BB8
		public override EHeadStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHeadStyle.Normal;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002ECA RID: 11978
		// (get) Token: 0x060093BA RID: 37818 RVA: 0x001569C6 File Offset: 0x00154BC6
		// (set) Token: 0x060093BB RID: 37819 RVA: 0x001569F1 File Offset: 0x00154BF1
		public virtual int MonsterDisplayId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MonsterDisplayId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MonsterDisplayId;
			}
			set
			{
				this.GetOrCreatePoco().MonsterDisplayId = value;
			}
		}

		// Token: 0x04005AB6 RID: 23222
		[Nullable(2)]
		protected new IHeadStyleMonsterDisplay FbInstance;

		// Token: 0x04005AB7 RID: 23223
		[Nullable(2)]
		protected new IHeadStyleMonsterDisplay_SetValue PocoInterface;
	}
}
