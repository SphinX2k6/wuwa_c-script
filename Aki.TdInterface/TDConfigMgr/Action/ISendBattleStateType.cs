using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001DFC RID: 7676
	[NullableContext(1)]
	[Nullable(0)]
	public class ISendBattleStateType
	{
		// Token: 0x0600A43D RID: 42045 RVA: 0x001748B8 File Offset: 0x00172AB8
		private ISendBattleStateType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ISendBattleStateType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ISendBattleStateType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ISendBattleStateType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A43E RID: 42046 RVA: 0x001748F0 File Offset: 0x00172AF0
		public static ISendBattleStateType Create([Nullable(2)] ISendBattleStateType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISendBattleStateType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A43F RID: 42047 RVA: 0x00174903 File Offset: 0x00172B03
		public static ISendBattleStateType CreateFromSetValue([Nullable(2)] ISendBattleStateType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ISendBattleStateType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A440 RID: 42048 RVA: 0x00174916 File Offset: 0x00172B16
		public ISendBattleStateType_SetValue ToSetValue()
		{
			return new ISendBattleStateType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700327B RID: 12923
		// (get) Token: 0x0600A441 RID: 42049 RVA: 0x00174929 File Offset: 0x00172B29
		// (set) Token: 0x0600A442 RID: 42050 RVA: 0x00174954 File Offset: 0x00172B54
		public virtual ESetBattleStateType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ESetBattleStateType.SetBattleTag;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400625C RID: 25180
		[Nullable(2)]
		protected ISendBattleStateType FbInstance;

		// Token: 0x0400625D RID: 25181
		[Nullable(2)]
		protected ISendBattleStateType_SetValue PocoInterface;
	}
}
