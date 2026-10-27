using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D8E RID: 7566
	[NullableContext(1)]
	[Nullable(0)]
	public class IReigns : IUiGame
	{
		// Token: 0x0600A22F RID: 41519 RVA: 0x00171070 File Offset: 0x0016F270
		private IReigns_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IReigns 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IReigns_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IReigns_SetValue());
			}
			return result;
		}

		// Token: 0x0600A230 RID: 41520 RVA: 0x001710A8 File Offset: 0x0016F2A8
		public static IReigns Create([Nullable(2)] IReigns instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IReigns
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A231 RID: 41521 RVA: 0x001710BB File Offset: 0x0016F2BB
		public static IReigns CreateFromSetValue([Nullable(2)] IReigns_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IReigns
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A232 RID: 41522 RVA: 0x001710CE File Offset: 0x0016F2CE
		public new IReigns_SetValue ToSetValue()
		{
			return new IReigns_SetValue
			{
				Type = this.Type,
				ReignsId = this.ReignsId
			};
		}

		// Token: 0x17003219 RID: 12825
		// (get) Token: 0x0600A233 RID: 41523 RVA: 0x001710ED File Offset: 0x0016F2ED
		// (set) Token: 0x0600A234 RID: 41524 RVA: 0x00171118 File Offset: 0x0016F318
		public override ESimpleGameplayType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESimpleGameplayType.Cipher;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x1700321A RID: 12826
		// (get) Token: 0x0600A235 RID: 41525 RVA: 0x00171126 File Offset: 0x0016F326
		// (set) Token: 0x0600A236 RID: 41526 RVA: 0x00171151 File Offset: 0x0016F351
		public virtual int ReignsId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ReignsId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.ReignsId;
			}
			set
			{
				this.GetOrCreatePoco().ReignsId = value;
			}
		}

		// Token: 0x04006174 RID: 24948
		[Nullable(2)]
		protected new IReigns FbInstance;

		// Token: 0x04006175 RID: 24949
		[Nullable(2)]
		protected new IReigns_SetValue PocoInterface;
	}
}
