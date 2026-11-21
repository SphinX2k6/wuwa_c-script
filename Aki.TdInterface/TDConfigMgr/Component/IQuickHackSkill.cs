using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020006DD RID: 1757
	public class IQuickHackSkill
	{
		// Token: 0x06002534 RID: 9524 RVA: 0x00064DB0 File Offset: 0x00062FB0
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

		// Token: 0x06002535 RID: 9525 RVA: 0x00064DE8 File Offset: 0x00062FE8
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

		// Token: 0x06002536 RID: 9526 RVA: 0x00064DFB File Offset: 0x00062FFB
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

		// Token: 0x06002537 RID: 9527 RVA: 0x00064E0E File Offset: 0x0006300E
		public IQuickHackSkill_SetValue ToSetValue()
		{
			return new IQuickHackSkill_SetValue
			{
				Id = this.Id,
				Content = this.Content
			};
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06002538 RID: 9528 RVA: 0x00064E2D File Offset: 0x0006302D
		// (set) Token: 0x06002539 RID: 9529 RVA: 0x00064E58 File Offset: 0x00063058
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

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x0600253A RID: 9530 RVA: 0x00064E68 File Offset: 0x00063068
		// (set) Token: 0x0600253B RID: 9531 RVA: 0x00064EFB File Offset: 0x000630FB
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

		// Token: 0x040019B2 RID: 6578
		[Nullable(2)]
		protected IQuickHackSkill FbInstance;

		// Token: 0x040019B3 RID: 6579
		[Nullable(2)]
		protected IQuickHackSkill_SetValue PocoInterface;

		// Token: 0x040019B4 RID: 6580
		private List<IQuickHackSkillContent> _ContentCache;

		// Token: 0x040019B5 RID: 6581
		private bool _ContentInited;
	}
}
