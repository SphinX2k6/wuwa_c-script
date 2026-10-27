using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200191E RID: 6430
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipMissionComplete : ICommonTipType
	{
		// Token: 0x060089D5 RID: 35285 RVA: 0x00145174 File Offset: 0x00143374
		private ICommonTipMissionComplete_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTipMissionComplete 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTipMissionComplete_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTipMissionComplete_SetValue());
			}
			return result;
		}

		// Token: 0x060089D6 RID: 35286 RVA: 0x001451AC File Offset: 0x001433AC
		public static ICommonTipMissionComplete Create([Nullable(2)] ICommonTipMissionComplete instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipMissionComplete
			{
				FbInstance = instance
			};
		}

		// Token: 0x060089D7 RID: 35287 RVA: 0x001451BF File Offset: 0x001433BF
		public static ICommonTipMissionComplete CreateFromSetValue([Nullable(2)] ICommonTipMissionComplete_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTipMissionComplete
			{
				PocoInterface = value
			};
		}

		// Token: 0x060089D8 RID: 35288 RVA: 0x001451D4 File Offset: 0x001433D4
		public new ICommonTipMissionComplete_SetValue ToSetValue()
		{
			return new ICommonTipMissionComplete_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				TidSubText = this.TidSubText,
				EdTidMainText = this.EdTidMainText,
				EdTidSubText = this.EdTidSubText
			};
		}

		// Token: 0x17002C92 RID: 11410
		// (get) Token: 0x060089D9 RID: 35289 RVA: 0x00145222 File Offset: 0x00143422
		// (set) Token: 0x060089DA RID: 35290 RVA: 0x0014524D File Offset: 0x0014344D
		public override ECommonTipType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002C93 RID: 11411
		// (get) Token: 0x060089DB RID: 35291 RVA: 0x0014525B File Offset: 0x0014345B
		// (set) Token: 0x060089DC RID: 35292 RVA: 0x00145286 File Offset: 0x00143486
		public virtual string TidMainText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidMainText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidMainText;
			}
			set
			{
				this.GetOrCreatePoco().TidMainText = value;
			}
		}

		// Token: 0x17002C94 RID: 11412
		// (get) Token: 0x060089DD RID: 35293 RVA: 0x00145294 File Offset: 0x00143494
		// (set) Token: 0x060089DE RID: 35294 RVA: 0x001452BF File Offset: 0x001434BF
		public virtual string TidSubText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidSubText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TidSubText;
			}
			set
			{
				this.GetOrCreatePoco().TidSubText = value;
			}
		}

		// Token: 0x17002C95 RID: 11413
		// (get) Token: 0x060089DF RID: 35295 RVA: 0x001452CD File Offset: 0x001434CD
		// (set) Token: 0x060089E0 RID: 35296 RVA: 0x001452E4 File Offset: 0x001434E4
		[Nullable(2)]
		public virtual string EdTidMainText
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidMainText;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidMainText = value;
			}
		}

		// Token: 0x17002C96 RID: 11414
		// (get) Token: 0x060089E1 RID: 35297 RVA: 0x001452F2 File Offset: 0x001434F2
		// (set) Token: 0x060089E2 RID: 35298 RVA: 0x00145309 File Offset: 0x00143509
		[Nullable(2)]
		public virtual string EdTidSubText
		{
			[NullableContext(2)]
			get
			{
				if (this.PocoInterface != null)
				{
					return this.PocoInterface.EdTidSubText;
				}
				return null;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().EdTidSubText = value;
			}
		}

		// Token: 0x04005647 RID: 22087
		[Nullable(2)]
		protected new ICommonTipMissionComplete FbInstance;

		// Token: 0x04005648 RID: 22088
		[Nullable(2)]
		protected new ICommonTipMissionComplete_SetValue PocoInterface;
	}
}
