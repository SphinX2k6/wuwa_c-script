using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F31 RID: 7985
	public class IPlaySpineAnimation : ISetSpineAnimationType
	{
		// Token: 0x0600A9ED RID: 43501 RVA: 0x00181830 File Offset: 0x0017FA30
		private IPlaySpineAnimation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlaySpineAnimation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlaySpineAnimation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlaySpineAnimation_SetValue());
			}
			return result;
		}

		// Token: 0x0600A9EE RID: 43502 RVA: 0x00181868 File Offset: 0x0017FA68
		public static IPlaySpineAnimation Create([Nullable(2)] IPlaySpineAnimation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlaySpineAnimation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A9EF RID: 43503 RVA: 0x0018187B File Offset: 0x0017FA7B
		public static IPlaySpineAnimation CreateFromSetValue([Nullable(2)] IPlaySpineAnimation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlaySpineAnimation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A9F0 RID: 43504 RVA: 0x0018188E File Offset: 0x0017FA8E
		public new IPlaySpineAnimation_SetValue ToSetValue()
		{
			return new IPlaySpineAnimation_SetValue
			{
				Type = this.Type,
				Name = this.Name,
				IsLoop = this.IsLoop
			};
		}

		// Token: 0x1700343B RID: 13371
		// (get) Token: 0x0600A9F1 RID: 43505 RVA: 0x001818B9 File Offset: 0x0017FAB9
		// (set) Token: 0x0600A9F2 RID: 43506 RVA: 0x001818E4 File Offset: 0x0017FAE4
		public override ESetSpineAnimation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetSpineAnimation.Play;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700343C RID: 13372
		// (get) Token: 0x0600A9F3 RID: 43507 RVA: 0x001818F2 File Offset: 0x0017FAF2
		// (set) Token: 0x0600A9F4 RID: 43508 RVA: 0x0018191D File Offset: 0x0017FB1D
		public virtual string Name
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Name;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Name;
			}
			set
			{
				this.GetOrCreatePoco().Name = value;
			}
		}

		// Token: 0x1700343D RID: 13373
		// (get) Token: 0x0600A9F5 RID: 43509 RVA: 0x0018192B File Offset: 0x0017FB2B
		// (set) Token: 0x0600A9F6 RID: 43510 RVA: 0x00181956 File Offset: 0x0017FB56
		public virtual bool IsLoop
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.IsLoop;
				}
				return this.PocoInterface != null && this.PocoInterface.IsLoop;
			}
			set
			{
				this.GetOrCreatePoco().IsLoop = value;
			}
		}

		// Token: 0x040065FA RID: 26106
		[Nullable(2)]
		protected new IPlaySpineAnimation FbInstance;

		// Token: 0x040065FB RID: 26107
		[Nullable(2)]
		protected new IPlaySpineAnimation_SetValue PocoInterface;
	}
}
