using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D9A RID: 7578
	[NullableContext(1)]
	[Nullable(0)]
	public class IRemovePreloadResourceCharacterType
	{
		// Token: 0x0600A26B RID: 41579 RVA: 0x001716B0 File Offset: 0x0016F8B0
		private IRemovePreloadResourceCharacterType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRemovePreloadResourceCharacterType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRemovePreloadResourceCharacterType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRemovePreloadResourceCharacterType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A26C RID: 41580 RVA: 0x001716E8 File Offset: 0x0016F8E8
		public static IRemovePreloadResourceCharacterType Create([Nullable(2)] IRemovePreloadResourceCharacterType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemovePreloadResourceCharacterType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A26D RID: 41581 RVA: 0x001716FB File Offset: 0x0016F8FB
		public static IRemovePreloadResourceCharacterType CreateFromSetValue([Nullable(2)] IRemovePreloadResourceCharacterType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRemovePreloadResourceCharacterType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A26E RID: 41582 RVA: 0x0017170E File Offset: 0x0016F90E
		public IRemovePreloadResourceCharacterType_SetValue ToSetValue()
		{
			return new IRemovePreloadResourceCharacterType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003225 RID: 12837
		// (get) Token: 0x0600A26F RID: 41583 RVA: 0x00171721 File Offset: 0x0016F921
		// (set) Token: 0x0600A270 RID: 41584 RVA: 0x0017174C File Offset: 0x0016F94C
		public virtual ERemovePreloadResourceObjectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ERemovePreloadResourceObjectType.RemovePreloadResourceTrialCharacter;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400618E RID: 24974
		[Nullable(2)]
		protected IRemovePreloadResourceCharacterType FbInstance;

		// Token: 0x0400618F RID: 24975
		[Nullable(2)]
		protected IRemovePreloadResourceCharacterType_SetValue PocoInterface;
	}
}
