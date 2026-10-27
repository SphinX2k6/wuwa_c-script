using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001ADD RID: 6877
	[NullableContext(1)]
	[Nullable(0)]
	public class IGreatSwordChallenge : ICommonTipType
	{
		// Token: 0x06009362 RID: 37730 RVA: 0x0015612C File Offset: 0x0015432C
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

		// Token: 0x06009363 RID: 37731 RVA: 0x00156164 File Offset: 0x00154364
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

		// Token: 0x06009364 RID: 37732 RVA: 0x00156177 File Offset: 0x00154377
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

		// Token: 0x06009365 RID: 37733 RVA: 0x0015618A File Offset: 0x0015438A
		public new IGreatSwordChallenge_SetValue ToSetValue()
		{
			return new IGreatSwordChallenge_SetValue
			{
				Type = this.Type,
				MainText = this.MainText,
				SubText = this.SubText
			};
		}

		// Token: 0x17002EBB RID: 11963
		// (get) Token: 0x06009366 RID: 37734 RVA: 0x001561B5 File Offset: 0x001543B5
		// (set) Token: 0x06009367 RID: 37735 RVA: 0x001561E0 File Offset: 0x001543E0
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

		// Token: 0x17002EBC RID: 11964
		// (get) Token: 0x06009368 RID: 37736 RVA: 0x001561EE File Offset: 0x001543EE
		// (set) Token: 0x06009369 RID: 37737 RVA: 0x00156219 File Offset: 0x00154419
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

		// Token: 0x17002EBD RID: 11965
		// (get) Token: 0x0600936A RID: 37738 RVA: 0x00156227 File Offset: 0x00154427
		// (set) Token: 0x0600936B RID: 37739 RVA: 0x00156252 File Offset: 0x00154452
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

		// Token: 0x04005A96 RID: 23190
		[Nullable(2)]
		protected new IGreatSwordChallenge FbInstance;

		// Token: 0x04005A97 RID: 23191
		[Nullable(2)]
		protected new IGreatSwordChallenge_SetValue PocoInterface;
	}
}
