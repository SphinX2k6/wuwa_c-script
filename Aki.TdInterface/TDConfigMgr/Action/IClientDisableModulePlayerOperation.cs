using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A2D RID: 6701
	[NullableContext(2)]
	[Nullable(0)]
	public class IClientDisableModulePlayerOperation : ClientSetPlayerOperationRestriction
	{
		// Token: 0x06008E87 RID: 36487 RVA: 0x00150788 File Offset: 0x0014E988
		[NullableContext(0)]
		private IClientDisableModulePlayerOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IClientDisableModulePlayerOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IClientDisableModulePlayerOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IClientDisableModulePlayerOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06008E88 RID: 36488 RVA: 0x001507C0 File Offset: 0x0014E9C0
		[NullableContext(0)]
		public static IClientDisableModulePlayerOperation Create([Nullable(2)] IClientDisableModulePlayerOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IClientDisableModulePlayerOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008E89 RID: 36489 RVA: 0x001507D3 File Offset: 0x0014E9D3
		[NullableContext(0)]
		public static IClientDisableModulePlayerOperation CreateFromSetValue([Nullable(2)] IClientDisableModulePlayerOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IClientDisableModulePlayerOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008E8A RID: 36490 RVA: 0x001507E8 File Offset: 0x0014E9E8
		[NullableContext(0)]
		public new IClientDisableModulePlayerOperation_SetValue ToSetValue()
		{
			return new IClientDisableModulePlayerOperation_SetValue
			{
				Type = this.Type,
				MoveOption = this.MoveOption,
				SkillOption = this.SkillOption,
				CameraOption = this.CameraOption,
				UiOption = this.UiOption,
				SceneInteractionOption = this.SceneInteractionOption
			};
		}

		// Token: 0x17002E0C RID: 11788
		// (get) Token: 0x06008E8B RID: 36491 RVA: 0x00150842 File Offset: 0x0014EA42
		// (set) Token: 0x06008E8C RID: 36492 RVA: 0x0015086D File Offset: 0x0014EA6D
		public override EPlayerOperationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EPlayerOperationType.EnableAll;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17002E0D RID: 11789
		// (get) Token: 0x06008E8D RID: 36493 RVA: 0x0015087B File Offset: 0x0014EA7B
		// (set) Token: 0x06008E8E RID: 36494 RVA: 0x001508A2 File Offset: 0x0014EAA2
		public virtual IMoveOperationType MoveOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveOption;
				}
				IClientDisableModulePlayerOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.MoveOption;
			}
			set
			{
				this.GetOrCreatePoco().MoveOption = value;
			}
		}

		// Token: 0x17002E0E RID: 11790
		// (get) Token: 0x06008E8F RID: 36495 RVA: 0x001508B0 File Offset: 0x0014EAB0
		// (set) Token: 0x06008E90 RID: 36496 RVA: 0x001508D7 File Offset: 0x0014EAD7
		public virtual ISkillOperationType SkillOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkillOption;
				}
				IClientDisableModulePlayerOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SkillOption;
			}
			set
			{
				this.GetOrCreatePoco().SkillOption = value;
			}
		}

		// Token: 0x17002E0F RID: 11791
		// (get) Token: 0x06008E91 RID: 36497 RVA: 0x001508E5 File Offset: 0x0014EAE5
		// (set) Token: 0x06008E92 RID: 36498 RVA: 0x0015090C File Offset: 0x0014EB0C
		public virtual ICameraOperationType CameraOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CameraOption;
				}
				IClientDisableModulePlayerOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.CameraOption;
			}
			set
			{
				this.GetOrCreatePoco().CameraOption = value;
			}
		}

		// Token: 0x17002E10 RID: 11792
		// (get) Token: 0x06008E93 RID: 36499 RVA: 0x0015091A File Offset: 0x0014EB1A
		// (set) Token: 0x06008E94 RID: 36500 RVA: 0x00150941 File Offset: 0x0014EB41
		public virtual IUiOperationType UiOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UiOption;
				}
				IClientDisableModulePlayerOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.UiOption;
			}
			set
			{
				this.GetOrCreatePoco().UiOption = value;
			}
		}

		// Token: 0x17002E11 RID: 11793
		// (get) Token: 0x06008E95 RID: 36501 RVA: 0x0015094F File Offset: 0x0014EB4F
		// (set) Token: 0x06008E96 RID: 36502 RVA: 0x00150976 File Offset: 0x0014EB76
		public virtual ISceneInteractionOperationType SceneInteractionOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SceneInteractionOption;
				}
				IClientDisableModulePlayerOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.SceneInteractionOption;
			}
			set
			{
				this.GetOrCreatePoco().SceneInteractionOption = value;
			}
		}

		// Token: 0x04005983 RID: 22915
		protected new IClientDisableModulePlayerOperation FbInstance;

		// Token: 0x04005984 RID: 22916
		protected new IClientDisableModulePlayerOperation_SetValue PocoInterface;
	}
}
