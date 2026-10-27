using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E18 RID: 7704
	[NullableContext(1)]
	[Nullable(0)]
	public class ISetBattleTagType
	{
		// Token: 0x0600A4CF RID: 42191 RVA: 0x00175A58 File Offset: 0x00173C58
		private ISetBattleTagType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISetBattleTagType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISetBattleTagType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISetBattleTagType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A4D0 RID: 42192 RVA: 0x00175A90 File Offset: 0x00173C90
		public static ISetBattleTagType Create([Nullable(2)] ISetBattleTagType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetBattleTagType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A4D1 RID: 42193 RVA: 0x00175AA3 File Offset: 0x00173CA3
		public static ISetBattleTagType CreateFromSetValue([Nullable(2)] ISetBattleTagType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISetBattleTagType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A4D2 RID: 42194 RVA: 0x00175AB6 File Offset: 0x00173CB6
		public ISetBattleTagType_SetValue ToSetValue()
		{
			return new ISetBattleTagType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700329A RID: 12954
		// (get) Token: 0x0600A4D3 RID: 42195 RVA: 0x00175AC9 File Offset: 0x00173CC9
		// (set) Token: 0x0600A4D4 RID: 42196 RVA: 0x00175AF4 File Offset: 0x00173CF4
		public virtual ESetBattleTagType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetBattleTagType.BattleMonsterLanding;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040062A5 RID: 25253
		[Nullable(2)]
		protected ISetBattleTagType FbInstance;

		// Token: 0x040062A6 RID: 25254
		[Nullable(2)]
		protected ISetBattleTagType_SetValue PocoInterface;
	}
}
