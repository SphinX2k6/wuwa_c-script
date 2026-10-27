using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001AFB RID: 6907
	[NullableContext(1)]
	[Nullable(0)]
	public class IHideGroupType
	{
		// Token: 0x060093EE RID: 37870 RVA: 0x00156ECC File Offset: 0x001550CC
		private IHideGroupType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IHideGroupType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IHideGroupType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IHideGroupType_SetValue());
			}
			return result;
		}

		// Token: 0x060093EF RID: 37871 RVA: 0x00156F04 File Offset: 0x00155104
		public static IHideGroupType Create([Nullable(2)] IHideGroupType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IHideGroupType
			{
				FbInstance = instance
			};
		}

		// Token: 0x060093F0 RID: 37872 RVA: 0x00156F17 File Offset: 0x00155117
		public static IHideGroupType CreateFromSetValue([Nullable(2)] IHideGroupType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IHideGroupType
			{
				PocoInterface = value
			};
		}

		// Token: 0x060093F1 RID: 37873 RVA: 0x00156F2A File Offset: 0x0015512A
		public IHideGroupType_SetValue ToSetValue()
		{
			return new IHideGroupType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002ED4 RID: 11988
		// (get) Token: 0x060093F2 RID: 37874 RVA: 0x00156F3D File Offset: 0x0015513D
		// (set) Token: 0x060093F3 RID: 37875 RVA: 0x00156F68 File Offset: 0x00155168
		public virtual EHideType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EHideType.WorldMonsterAndMonsterTreasure;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04005ACD RID: 23245
		[Nullable(2)]
		protected IHideGroupType FbInstance;

		// Token: 0x04005ACE RID: 23246
		[Nullable(2)]
		protected IHideGroupType_SetValue PocoInterface;
	}
}
