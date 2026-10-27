using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000640 RID: 1600
	[NullableContext(1)]
	[Nullable(0)]
	public class IQuickHackSkill
	{
		// Token: 0x0600222E RID: 8750 RVA: 0x0005E09C File Offset: 0x0005C29C
		private IQuickHackSkill_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IQuickHackSkill 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IQuickHackSkill_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IQuickHackSkill_SetValue());
			}
			return result;
		}

		// Token: 0x0600222F RID: 8751 RVA: 0x0005E0D4 File Offset: 0x0005C2D4
		public static IQuickHackSkill Create([Nullable(2)] IQuickHackSkill instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IQuickHackSkill
			{
				FbInstance = instance
			};
		}

		// Token: 0x06002230 RID: 8752 RVA: 0x0005E0E7 File Offset: 0x0005C2E7
		public static IQuickHackSkill CreateFromSetValue([Nullable(2)] IQuickHackSkill_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IQuickHackSkill
			{
				PocoInterface = value
			};
		}

		// Token: 0x06002231 RID: 8753 RVA: 0x0005E0FA File Offset: 0x0005C2FA
		public IQuickHackSkill_SetValue ToSetValue()
		{
			return new IQuickHackSkill_SetValue
			{
				Id = this.Id,
				Content = this.Content
			};
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06002232 RID: 8754 RVA: 0x0005E119 File Offset: 0x0005C319
		// (set) Token: 0x06002233 RID: 8755 RVA: 0x0005E144 File Offset: 0x0005C344
		public virtual int Id
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Id;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.Id;
			}
			set
			{
				this.GetOrCreatePoco().Id = value;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06002234 RID: 8756 RVA: 0x0005E154 File Offset: 0x0005C354
		// (set) Token: 0x06002235 RID: 8757 RVA: 0x0005E1E7 File Offset: 0x0005C3E7
		public virtual List<IQuickHackSkillContent> Content
		{
			get
			{
				if (this._ContentInited)
				{
					return this._ContentCache;
				}
				this._ContentInited = true;
				if (this.FbInstance != null)
				{
					List<IQuickHackSkillContent> content = this.FbInstance.Content;
					if (content != null)
					{
						this._ContentCache = new List<IQuickHackSkillContent>(content.Count);
						for (int i = 0; i < content.Count; i++)
						{
							this._ContentCache.Add(IQuickHackSkillContent.Create(content[i]));
						}
					}
				}
				else
				{
					IQuickHackSkill_SetValue pocoInterface = this.PocoInterface;
					this._ContentCache = ((pocoInterface != null) ? pocoInterface.Content : null);
				}
				return this._ContentCache;
			}
			set
			{
				this.GetOrCreatePoco().Content = value;
				this._ContentInited = false;
			}
		}

		// Token: 0x040017C0 RID: 6080
		[Nullable(2)]
		protected IQuickHackSkill FbInstance;

		// Token: 0x040017C1 RID: 6081
		[Nullable(2)]
		protected IQuickHackSkill_SetValue PocoInterface;

		// Token: 0x040017C2 RID: 6082
		private List<IQuickHackSkillContent> _ContentCache;

		// Token: 0x040017C3 RID: 6083
		private bool _ContentInited;
	}
}
