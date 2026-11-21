using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E57 RID: 7767
	public class INightmareLordTip : ICommonTipType
	{
		// Token: 0x0600A519 RID: 42265 RVA: 0x00178BE4 File Offset: 0x00176DE4
		private INightmareLordTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("INightmareLordTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			INightmareLordTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new INightmareLordTip_SetValue());
			}
			return result;
		}

		// Token: 0x0600A51A RID: 42266 RVA: 0x00178C1C File Offset: 0x00176E1C
		public static INightmareLordTip Create([Nullable(2)] INightmareLordTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INightmareLordTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A51B RID: 42267 RVA: 0x00178C2F File Offset: 0x00176E2F
		public static INightmareLordTip CreateFromSetValue([Nullable(2)] INightmareLordTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new INightmareLordTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A51C RID: 42268 RVA: 0x00178C44 File Offset: 0x00176E44
		public new INightmareLordTip_SetValue ToSetValue()
		{
			return new INightmareLordTip_SetValue
			{
				Type = this.Type,
				TidMainText = this.TidMainText,
				TidSubText = this.TidSubText,
				EdTidMainText = this.EdTidMainText,
				EdTidSubText = this.EdTidSubText
			};
		}

		// Token: 0x17003318 RID: 13080
		// (get) Token: 0x0600A51D RID: 42269 RVA: 0x00178C92 File Offset: 0x00176E92
		// (set) Token: 0x0600A51E RID: 42270 RVA: 0x00178CBD File Offset: 0x00176EBD
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

		// Token: 0x17003319 RID: 13081
		// (get) Token: 0x0600A51F RID: 42271 RVA: 0x00178CCB File Offset: 0x00176ECB
		// (set) Token: 0x0600A520 RID: 42272 RVA: 0x00178CF6 File Offset: 0x00176EF6
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

		// Token: 0x1700331A RID: 13082
		// (get) Token: 0x0600A521 RID: 42273 RVA: 0x00178D04 File Offset: 0x00176F04
		// (set) Token: 0x0600A522 RID: 42274 RVA: 0x00178D2F File Offset: 0x00176F2F
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

		// Token: 0x1700331B RID: 13083
		// (get) Token: 0x0600A523 RID: 42275 RVA: 0x00178D3D File Offset: 0x00176F3D
		// (set) Token: 0x0600A524 RID: 42276 RVA: 0x00178D54 File Offset: 0x00176F54
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

		// Token: 0x1700331C RID: 13084
		// (get) Token: 0x0600A525 RID: 42277 RVA: 0x00178D62 File Offset: 0x00176F62
		// (set) Token: 0x0600A526 RID: 42278 RVA: 0x00178D79 File Offset: 0x00176F79
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

		// Token: 0x040063C1 RID: 25537
		[Nullable(2)]
		protected new INightmareLordTip FbInstance;

		// Token: 0x040063C2 RID: 25538
		[Nullable(2)]
		protected new INightmareLordTip_SetValue PocoInterface;
	}
}
