using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D44 RID: 7492
	[NullableContext(1)]
	[Nullable(0)]
	public class IPreloadCharacterType
	{
		// Token: 0x0600A0C1 RID: 41153 RVA: 0x0016E974 File Offset: 0x0016CB74
		private IPreloadCharacterType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPreloadCharacterType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPreloadCharacterType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPreloadCharacterType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A0C2 RID: 41154 RVA: 0x0016E9AC File Offset: 0x0016CBAC
		public static IPreloadCharacterType Create([Nullable(2)] IPreloadCharacterType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPreloadCharacterType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A0C3 RID: 41155 RVA: 0x0016E9BF File Offset: 0x0016CBBF
		public static IPreloadCharacterType CreateFromSetValue([Nullable(2)] IPreloadCharacterType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPreloadCharacterType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A0C4 RID: 41156 RVA: 0x0016E9D2 File Offset: 0x0016CBD2
		public IPreloadCharacterType_SetValue ToSetValue()
		{
			return new IPreloadCharacterType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031D1 RID: 12753
		// (get) Token: 0x0600A0C5 RID: 41157 RVA: 0x0016E9E5 File Offset: 0x0016CBE5
		// (set) Token: 0x0600A0C6 RID: 41158 RVA: 0x0016EA10 File Offset: 0x0016CC10
		public virtual EPreloadObjectType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPreloadObjectType.PreloadTrialCharacterForSkill;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040060D8 RID: 24792
		[Nullable(2)]
		protected IPreloadCharacterType FbInstance;

		// Token: 0x040060D9 RID: 24793
		[Nullable(2)]
		protected IPreloadCharacterType_SetValue PocoInterface;
	}
}
