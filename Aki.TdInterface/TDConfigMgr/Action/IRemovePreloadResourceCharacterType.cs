using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FAF RID: 8111
	public class IRemovePreloadResourceCharacterType
	{
		// Token: 0x0600AC6B RID: 44139 RVA: 0x00185CD8 File Offset: 0x00183ED8
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

		// Token: 0x0600AC6C RID: 44140 RVA: 0x00185D10 File Offset: 0x00183F10
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

		// Token: 0x0600AC6D RID: 44141 RVA: 0x00185D23 File Offset: 0x00183F23
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

		// Token: 0x0600AC6E RID: 44142 RVA: 0x00185D36 File Offset: 0x00183F36
		public IRemovePreloadResourceCharacterType_SetValue ToSetValue()
		{
			return new IRemovePreloadResourceCharacterType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170034BD RID: 13501
		// (get) Token: 0x0600AC6F RID: 44143 RVA: 0x00185D49 File Offset: 0x00183F49
		// (set) Token: 0x0600AC70 RID: 44144 RVA: 0x00185D74 File Offset: 0x00183F74
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

		// Token: 0x04006712 RID: 26386
		[Nullable(2)]
		protected IRemovePreloadResourceCharacterType FbInstance;

		// Token: 0x04006713 RID: 26387
		[Nullable(2)]
		protected IRemovePreloadResourceCharacterType_SetValue PocoInterface;
	}
}
