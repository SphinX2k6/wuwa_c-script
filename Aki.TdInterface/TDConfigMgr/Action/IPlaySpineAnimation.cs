using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D20 RID: 7456
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlaySpineAnimation : ISetSpineAnimationType
	{
		// Token: 0x0600A001 RID: 40961 RVA: 0x0016D40C File Offset: 0x0016B60C
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

		// Token: 0x0600A002 RID: 40962 RVA: 0x0016D444 File Offset: 0x0016B644
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

		// Token: 0x0600A003 RID: 40963 RVA: 0x0016D457 File Offset: 0x0016B657
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

		// Token: 0x0600A004 RID: 40964 RVA: 0x0016D46A File Offset: 0x0016B66A
		public new IPlaySpineAnimation_SetValue ToSetValue()
		{
			return new IPlaySpineAnimation_SetValue
			{
				Type = this.Type,
				Name = this.Name,
				IsLoop = this.IsLoop
			};
		}

		// Token: 0x170031A7 RID: 12711
		// (get) Token: 0x0600A005 RID: 40965 RVA: 0x0016D495 File Offset: 0x0016B695
		// (set) Token: 0x0600A006 RID: 40966 RVA: 0x0016D4C0 File Offset: 0x0016B6C0
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

		// Token: 0x170031A8 RID: 12712
		// (get) Token: 0x0600A007 RID: 40967 RVA: 0x0016D4CE File Offset: 0x0016B6CE
		// (set) Token: 0x0600A008 RID: 40968 RVA: 0x0016D4F9 File Offset: 0x0016B6F9
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

		// Token: 0x170031A9 RID: 12713
		// (get) Token: 0x0600A009 RID: 40969 RVA: 0x0016D507 File Offset: 0x0016B707
		// (set) Token: 0x0600A00A RID: 40970 RVA: 0x0016D532 File Offset: 0x0016B732
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

		// Token: 0x0400607E RID: 24702
		[Nullable(2)]
		protected new IPlaySpineAnimation FbInstance;

		// Token: 0x0400607F RID: 24703
		[Nullable(2)]
		protected new IPlaySpineAnimation_SetValue PocoInterface;
	}
}
