using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B63 RID: 7011
	public class IElementalBoxTargetPrefabPos : IElementalBoxTargetPosTypeBase
	{
		// Token: 0x060094E9 RID: 38121 RVA: 0x0015B72C File Offset: 0x0015992C
		private IElementalBoxTargetPrefabPos_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IElementalBoxTargetPrefabPos 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IElementalBoxTargetPrefabPos_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IElementalBoxTargetPrefabPos_SetValue());
			}
			return result;
		}

		// Token: 0x060094EA RID: 38122 RVA: 0x0015B764 File Offset: 0x00159964
		public static IElementalBoxTargetPrefabPos Create([Nullable(2)] IElementalBoxTargetPrefabPos instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IElementalBoxTargetPrefabPos
			{
				FbInstance = instance
			};
		}

		// Token: 0x060094EB RID: 38123 RVA: 0x0015B777 File Offset: 0x00159977
		public static IElementalBoxTargetPrefabPos CreateFromSetValue([Nullable(2)] IElementalBoxTargetPrefabPos_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IElementalBoxTargetPrefabPos
			{
				PocoInterface = value
			};
		}

		// Token: 0x060094EC RID: 38124 RVA: 0x0015B78A File Offset: 0x0015998A
		public new IElementalBoxTargetPrefabPos_SetValue ToSetValue()
		{
			return new IElementalBoxTargetPrefabPos_SetValue
			{
				Type = this.Type,
				TargetKey = this.TargetKey
			};
		}

		// Token: 0x17002F6C RID: 12140
		// (get) Token: 0x060094ED RID: 38125 RVA: 0x0015B7A9 File Offset: 0x001599A9
		// (set) Token: 0x060094EE RID: 38126 RVA: 0x0015B7D4 File Offset: 0x001599D4
		public override EElementalBoxTargetPosType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EElementalBoxTargetPosType.PrefabElementalBoxTargetPos;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002F6D RID: 12141
		// (get) Token: 0x060094EF RID: 38127 RVA: 0x0015B7E2 File Offset: 0x001599E2
		// (set) Token: 0x060094F0 RID: 38128 RVA: 0x0015B80D File Offset: 0x00159A0D
		public virtual string TargetKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TargetKey;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.TargetKey;
			}
			set
			{
				this.GetOrCreatePoco().TargetKey = value;
			}
		}

		// Token: 0x04005C4B RID: 23627
		[Nullable(2)]
		protected new IElementalBoxTargetPrefabPos FbInstance;

		// Token: 0x04005C4C RID: 23628
		[Nullable(2)]
		protected new IElementalBoxTargetPrefabPos_SetValue PocoInterface;
	}
}
