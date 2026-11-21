using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C84 RID: 7300
	public class IGreatSwordChallenge : ICommonTipType
	{
		// Token: 0x06009B20 RID: 39712 RVA: 0x0016694C File Offset: 0x00164B4C
		private IGreatSwordChallenge_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IGreatSwordChallenge 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IGreatSwordChallenge_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IGreatSwordChallenge_SetValue());
			}
			return result;
		}

		// Token: 0x06009B21 RID: 39713 RVA: 0x00166984 File Offset: 0x00164B84
		public static IGreatSwordChallenge Create([Nullable(2)] IGreatSwordChallenge instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGreatSwordChallenge
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009B22 RID: 39714 RVA: 0x00166997 File Offset: 0x00164B97
		public static IGreatSwordChallenge CreateFromSetValue([Nullable(2)] IGreatSwordChallenge_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IGreatSwordChallenge
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009B23 RID: 39715 RVA: 0x001669AA File Offset: 0x00164BAA
		public new IGreatSwordChallenge_SetValue ToSetValue()
		{
			return new IGreatSwordChallenge_SetValue
			{
				Type = this.Type,
				MainText = this.MainText,
				SubText = this.SubText
			};
		}

		// Token: 0x170030D7 RID: 12503
		// (get) Token: 0x06009B24 RID: 39716 RVA: 0x001669D5 File Offset: 0x00164BD5
		// (set) Token: 0x06009B25 RID: 39717 RVA: 0x00166A00 File Offset: 0x00164C00
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

		// Token: 0x170030D8 RID: 12504
		// (get) Token: 0x06009B26 RID: 39718 RVA: 0x00166A0E File Offset: 0x00164C0E
		// (set) Token: 0x06009B27 RID: 39719 RVA: 0x00166A39 File Offset: 0x00164C39
		public virtual string MainText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MainText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.MainText;
			}
			set
			{
				this.GetOrCreatePoco().MainText = value;
			}
		}

		// Token: 0x170030D9 RID: 12505
		// (get) Token: 0x06009B28 RID: 39720 RVA: 0x00166A47 File Offset: 0x00164C47
		// (set) Token: 0x06009B29 RID: 39721 RVA: 0x00166A72 File Offset: 0x00164C72
		public virtual string SubText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SubText;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.SubText;
			}
			set
			{
				this.GetOrCreatePoco().SubText = value;
			}
		}

		// Token: 0x04005F20 RID: 24352
		[Nullable(2)]
		protected new IGreatSwordChallenge FbInstance;

		// Token: 0x04005F21 RID: 24353
		[Nullable(2)]
		protected new IGreatSwordChallenge_SetValue PocoInterface;
	}
}
