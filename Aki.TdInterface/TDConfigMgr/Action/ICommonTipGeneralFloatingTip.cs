using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200191A RID: 6426
	[NullableContext(1)]
	[Nullable(0)]
	public class ICommonTipGeneralFloatingTip : ICommonTipType
	{
		// Token: 0x060089BF RID: 35263 RVA: 0x00144F44 File Offset: 0x00143144
		private ICommonTipGeneralFloatingTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ICommonTipGeneralFloatingTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ICommonTipGeneralFloatingTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ICommonTipGeneralFloatingTip_SetValue());
			}
			return result;
		}

		// Token: 0x060089C0 RID: 35264 RVA: 0x00144F7C File Offset: 0x0014317C
		public static ICommonTipGeneralFloatingTip Create([Nullable(2)] ICommonTipGeneralFloatingTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICommonTipGeneralFloatingTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x060089C1 RID: 35265 RVA: 0x00144F8F File Offset: 0x0014318F
		public static ICommonTipGeneralFloatingTip CreateFromSetValue([Nullable(2)] ICommonTipGeneralFloatingTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ICommonTipGeneralFloatingTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x060089C2 RID: 35266 RVA: 0x00144FA2 File Offset: 0x001431A2
		public new ICommonTipGeneralFloatingTip_SetValue ToSetValue()
		{
			return new ICommonTipGeneralFloatingTip_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				EdTidMainText = this.EdTidMainText
			};
		}

		// Token: 0x17002C8D RID: 11405
		// (get) Token: 0x060089C3 RID: 35267 RVA: 0x00144FCD File Offset: 0x001431CD
		// (set) Token: 0x060089C4 RID: 35268 RVA: 0x00144FF8 File Offset: 0x001431F8
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

		// Token: 0x17002C8E RID: 11406
		// (get) Token: 0x060089C5 RID: 35269 RVA: 0x00145006 File Offset: 0x00143206
		// (set) Token: 0x060089C6 RID: 35270 RVA: 0x00145031 File Offset: 0x00143231
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

		// Token: 0x17002C8F RID: 11407
		// (get) Token: 0x060089C7 RID: 35271 RVA: 0x0014503F File Offset: 0x0014323F
		// (set) Token: 0x060089C8 RID: 35272 RVA: 0x00145056 File Offset: 0x00143256
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

		// Token: 0x0400563E RID: 22078
		[Nullable(2)]
		protected new ICommonTipGeneralFloatingTip FbInstance;

		// Token: 0x0400563F RID: 22079
		[Nullable(2)]
		protected new ICommonTipGeneralFloatingTip_SetValue PocoInterface;
	}
}
