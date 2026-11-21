using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C9C RID: 7324
	public class IHeadStyleMonsterDisplay : IHeadStyle
	{
		// Token: 0x06009B92 RID: 39826 RVA: 0x00167458 File Offset: 0x00165658
		private IHeadStyleMonsterDisplay_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHeadStyleMonsterDisplay 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHeadStyleMonsterDisplay_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHeadStyleMonsterDisplay_SetValue());
			}
			return result;
		}

		// Token: 0x06009B93 RID: 39827 RVA: 0x00167490 File Offset: 0x00165690
		public static IHeadStyleMonsterDisplay Create([Nullable(2)] IHeadStyleMonsterDisplay instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHeadStyleMonsterDisplay
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009B94 RID: 39828 RVA: 0x001674A3 File Offset: 0x001656A3
		public static IHeadStyleMonsterDisplay CreateFromSetValue([Nullable(2)] IHeadStyleMonsterDisplay_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHeadStyleMonsterDisplay
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009B95 RID: 39829 RVA: 0x001674B6 File Offset: 0x001656B6
		public new IHeadStyleMonsterDisplay_SetValue ToSetValue()
		{
			return new IHeadStyleMonsterDisplay_SetValue
			{
				Type = this.Type,
				MonsterDisplayId = this.MonsterDisplayId
			};
		}

		// Token: 0x170030EC RID: 12524
		// (get) Token: 0x06009B96 RID: 39830 RVA: 0x001674D5 File Offset: 0x001656D5
		// (set) Token: 0x06009B97 RID: 39831 RVA: 0x00167500 File Offset: 0x00165700
		public override EHeadStyle Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHeadStyle.Normal;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170030ED RID: 12525
		// (get) Token: 0x06009B98 RID: 39832 RVA: 0x0016750E File Offset: 0x0016570E
		// (set) Token: 0x06009B99 RID: 39833 RVA: 0x00167539 File Offset: 0x00165739
		public virtual int MonsterDisplayId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MonsterDisplayId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.MonsterDisplayId;
			}
			set
			{
				this.GetOrCreatePoco().MonsterDisplayId = value;
			}
		}

		// Token: 0x04005F4D RID: 24397
		[Nullable(2)]
		protected new IHeadStyleMonsterDisplay FbInstance;

		// Token: 0x04005F4E RID: 24398
		[Nullable(2)]
		protected new IHeadStyleMonsterDisplay_SetValue PocoInterface;
	}
}
