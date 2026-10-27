using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D9E RID: 7582
	[NullableContext(1)]
	[Nullable(0)]
	public class IRemovePreloadResourceTrialCharacter : IRemovePreloadResourceCharacterType
	{
		// Token: 0x0600A27F RID: 41599 RVA: 0x001718F0 File Offset: 0x0016FAF0
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

		// Token: 0x0600A280 RID: 41600 RVA: 0x00171928 File Offset: 0x0016FB28
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

		// Token: 0x0600A281 RID: 41601 RVA: 0x0017193B File Offset: 0x0016FB3B
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

		// Token: 0x0600A282 RID: 41602 RVA: 0x0017194E File Offset: 0x0016FB4E
		public new IRemovePreloadResourceTrialCharacter_SetValue ToSetValue()
		{
			return new IRemovePreloadResourceTrialCharacter_SetValue
			{
				Type = this.Type,
				CharacterGroup = this.CharacterGroup
			};
		}

		// Token: 0x17003229 RID: 12841
		// (get) Token: 0x0600A283 RID: 41603 RVA: 0x0017196D File Offset: 0x0016FB6D
		// (set) Token: 0x0600A284 RID: 41604 RVA: 0x00171998 File Offset: 0x0016FB98
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

		// Token: 0x1700322A RID: 12842
		// (get) Token: 0x0600A285 RID: 41605 RVA: 0x001719A6 File Offset: 0x0016FBA6
		// (set) Token: 0x0600A286 RID: 41606 RVA: 0x001719CD File Offset: 0x0016FBCD
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

		// Token: 0x04006198 RID: 24984
		[Nullable(2)]
		protected new IRemovePreloadResourceTrialCharacter FbInstance;

		// Token: 0x04006199 RID: 24985
		[Nullable(2)]
		protected new IRemovePreloadResourceTrialCharacter_SetValue PocoInterface;
	}
}
