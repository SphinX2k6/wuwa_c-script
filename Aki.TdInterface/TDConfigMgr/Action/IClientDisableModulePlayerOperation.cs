using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018A2 RID: 6306
	[NullableContext(2)]
	[Nullable(0)]
	public class IClientDisableModulePlayerOperation : ClientSetPlayerOperationRestriction
	{
		// Token: 0x0600875F RID: 34655 RVA: 0x00140F54 File Offset: 0x0013F154
		[NullableContext(1)]
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

		// Token: 0x06008760 RID: 34656 RVA: 0x00140F8C File Offset: 0x0013F18C
		[NullableContext(1)]
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

		// Token: 0x06008761 RID: 34657 RVA: 0x00140F9F File Offset: 0x0013F19F
		[NullableContext(1)]
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

		// Token: 0x06008762 RID: 34658 RVA: 0x00140FB4 File Offset: 0x0013F1B4
		[NullableContext(1)]
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

		// Token: 0x17002C11 RID: 11281
		// (get) Token: 0x06008763 RID: 34659 RVA: 0x0014100E File Offset: 0x0013F20E
		// (set) Token: 0x06008764 RID: 34660 RVA: 0x00141039 File Offset: 0x0013F239
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

		// Token: 0x17002C12 RID: 11282
		// (get) Token: 0x06008765 RID: 34661 RVA: 0x00141047 File Offset: 0x0013F247
		// (set) Token: 0x06008766 RID: 34662 RVA: 0x0014106E File Offset: 0x0013F26E
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

		// Token: 0x17002C13 RID: 11283
		// (get) Token: 0x06008767 RID: 34663 RVA: 0x0014107C File Offset: 0x0013F27C
		// (set) Token: 0x06008768 RID: 34664 RVA: 0x001410A3 File Offset: 0x0013F2A3
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

		// Token: 0x17002C14 RID: 11284
		// (get) Token: 0x06008769 RID: 34665 RVA: 0x001410B1 File Offset: 0x0013F2B1
		// (set) Token: 0x0600876A RID: 34666 RVA: 0x001410D8 File Offset: 0x0013F2D8
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

		// Token: 0x17002C15 RID: 11285
		// (get) Token: 0x0600876B RID: 34667 RVA: 0x001410E6 File Offset: 0x0013F2E6
		// (set) Token: 0x0600876C RID: 34668 RVA: 0x0014110D File Offset: 0x0013F30D
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

		// Token: 0x17002C16 RID: 11286
		// (get) Token: 0x0600876D RID: 34669 RVA: 0x0014111B File Offset: 0x0013F31B
		// (set) Token: 0x0600876E RID: 34670 RVA: 0x00141142 File Offset: 0x0013F342
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

		// Token: 0x04005536 RID: 21814
		protected new IClientDisableModulePlayerOperation FbInstance;

		// Token: 0x04005537 RID: 21815
		protected new IClientDisableModulePlayerOperation_SetValue PocoInterface;
	}
}
