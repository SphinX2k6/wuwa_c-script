using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019D6 RID: 6614
	[NullableContext(1)]
	[Nullable(0)]
	public class IElementalBoxTargetPrefabPos : IElementalBoxTargetPosTypeBase
	{
		// Token: 0x06008DA7 RID: 36263 RVA: 0x0014BC20 File Offset: 0x00149E20
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

		// Token: 0x06008DA8 RID: 36264 RVA: 0x0014BC58 File Offset: 0x00149E58
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

		// Token: 0x06008DA9 RID: 36265 RVA: 0x0014BC6B File Offset: 0x00149E6B
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

		// Token: 0x06008DAA RID: 36266 RVA: 0x0014BC7E File Offset: 0x00149E7E
		public new IElementalBoxTargetPrefabPos_SetValue ToSetValue()
		{
			return new IElementalBoxTargetPrefabPos_SetValue
			{
				Type = this.Type,
				TargetKey = this.TargetKey
			};
		}

		// Token: 0x17002D67 RID: 11623
		// (get) Token: 0x06008DAB RID: 36267 RVA: 0x0014BC9D File Offset: 0x00149E9D
		// (set) Token: 0x06008DAC RID: 36268 RVA: 0x0014BCC8 File Offset: 0x00149EC8
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

		// Token: 0x17002D68 RID: 11624
		// (get) Token: 0x06008DAD RID: 36269 RVA: 0x0014BCD6 File Offset: 0x00149ED6
		// (set) Token: 0x06008DAE RID: 36270 RVA: 0x0014BD01 File Offset: 0x00149F01
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

		// Token: 0x040057F6 RID: 22518
		[Nullable(2)]
		protected new IElementalBoxTargetPrefabPos FbInstance;

		// Token: 0x040057F7 RID: 22519
		[Nullable(2)]
		protected new IElementalBoxTargetPrefabPos_SetValue PocoInterface;
	}
}
