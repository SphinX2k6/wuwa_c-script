using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FB3 RID: 8115
	public class IRemovePreloadResourceTrialCharacter : IRemovePreloadResourceCharacterType
	{
		// Token: 0x0600AC7F RID: 44159 RVA: 0x00185F18 File Offset: 0x00184118
		private IRemovePreloadResourceTrialCharacter_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IRemovePreloadResourceTrialCharacter 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IRemovePreloadResourceTrialCharacter_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IRemovePreloadResourceTrialCharacter_SetValue());
			}
			return result;
		}

		// Token: 0x0600AC80 RID: 44160 RVA: 0x00185F50 File Offset: 0x00184150
		public static IRemovePreloadResourceTrialCharacter Create([Nullable(2)] IRemovePreloadResourceTrialCharacter instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRemovePreloadResourceTrialCharacter
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600AC81 RID: 44161 RVA: 0x00185F63 File Offset: 0x00184163
		public static IRemovePreloadResourceTrialCharacter CreateFromSetValue([Nullable(2)] IRemovePreloadResourceTrialCharacter_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IRemovePreloadResourceTrialCharacter
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600AC82 RID: 44162 RVA: 0x00185F76 File Offset: 0x00184176
		public new IRemovePreloadResourceTrialCharacter_SetValue ToSetValue()
		{
			return new IRemovePreloadResourceTrialCharacter_SetValue
			{
				Type = this.Type,
				CharacterGroup = this.CharacterGroup
			};
		}

		// Token: 0x170034C1 RID: 13505
		// (get) Token: 0x0600AC83 RID: 44163 RVA: 0x00185F95 File Offset: 0x00184195
		// (set) Token: 0x0600AC84 RID: 44164 RVA: 0x00185FC0 File Offset: 0x001841C0
		public override ERemovePreloadResourceObjectType Type
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

		// Token: 0x170034C2 RID: 13506
		// (get) Token: 0x0600AC85 RID: 44165 RVA: 0x00185FCE File Offset: 0x001841CE
		// (set) Token: 0x0600AC86 RID: 44166 RVA: 0x00185FF5 File Offset: 0x001841F5
		public virtual List<int> CharacterGroup
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CharacterGroup;
				}
				IRemovePreloadResourceTrialCharacter_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CharacterGroup;
			}
			set
			{
				this.GetOrCreatePoco().CharacterGroup = value;
			}
		}

		// Token: 0x0400671C RID: 26396
		[Nullable(2)]
		protected new IRemovePreloadResourceTrialCharacter FbInstance;

		// Token: 0x0400671D RID: 26397
		[Nullable(2)]
		protected new IRemovePreloadResourceTrialCharacter_SetValue PocoInterface;
	}
}
