using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200199A RID: 6554
	[NullableContext(1)]
	[Nullable(0)]
	public class IDetectBattleTagType
	{
		// Token: 0x06008C47 RID: 35911 RVA: 0x001493E4 File Offset: 0x001475E4
		private IDetectBattleTagType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDetectBattleTagType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDetectBattleTagType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDetectBattleTagType_SetValue());
			}
			return result;
		}

		// Token: 0x06008C48 RID: 35912 RVA: 0x0014941C File Offset: 0x0014761C
		public static IDetectBattleTagType Create([Nullable(2)] IDetectBattleTagType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDetectBattleTagType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008C49 RID: 35913 RVA: 0x0014942F File Offset: 0x0014762F
		public static IDetectBattleTagType CreateFromSetValue([Nullable(2)] IDetectBattleTagType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDetectBattleTagType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008C4A RID: 35914 RVA: 0x00149442 File Offset: 0x00147642
		public IDetectBattleTagType_SetValue ToSetValue()
		{
			return new IDetectBattleTagType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002D11 RID: 11537
		// (get) Token: 0x06008C4B RID: 35915 RVA: 0x00149455 File Offset: 0x00147655
		// (set) Token: 0x06008C4C RID: 35916 RVA: 0x00149480 File Offset: 0x00147680
		public virtual EDetectBattleTagType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EDetectBattleTagType.MonsterOnTheGround;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400575A RID: 22362
		[Nullable(2)]
		protected IDetectBattleTagType FbInstance;

		// Token: 0x0400575B RID: 22363
		[Nullable(2)]
		protected IDetectBattleTagType_SetValue PocoInterface;
	}
}
