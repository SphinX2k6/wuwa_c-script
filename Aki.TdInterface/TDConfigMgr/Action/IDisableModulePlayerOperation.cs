using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020019B0 RID: 6576
	[NullableContext(2)]
	[Nullable(0)]
	[JsonConverter(typeof(IDisableModulePlayerOperationConverter))]
	public class IDisableModulePlayerOperation : SetPlayerOperationRestriction
	{
		// Token: 0x06008CC7 RID: 36039 RVA: 0x0014A2B4 File Offset: 0x001484B4
		[NullableContext(1)]
		private IDisableModulePlayerOperation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDisableModulePlayerOperation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDisableModulePlayerOperation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDisableModulePlayerOperation_SetValue());
			}
			return result;
		}

		// Token: 0x06008CC8 RID: 36040 RVA: 0x0014A2EC File Offset: 0x001484EC
		[NullableContext(1)]
		public static IDisableModulePlayerOperation Create([Nullable(2)] IDisableModulePlayerOperation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDisableModulePlayerOperation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06008CC9 RID: 36041 RVA: 0x0014A2FF File Offset: 0x001484FF
		[NullableContext(1)]
		public static IDisableModulePlayerOperation CreateFromSetValue([Nullable(2)] IDisableModulePlayerOperation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDisableModulePlayerOperation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06008CCA RID: 36042 RVA: 0x0014A314 File Offset: 0x00148514
		[NullableContext(1)]
		public new IDisableModulePlayerOperation_SetValue ToSetValue()
		{
			return new IDisableModulePlayerOperation_SetValue
			{
				Type = this.Type,
				MoveOption = this.MoveOption,
				SkillOption = this.SkillOption,
				CameraOption = this.CameraOption,
				UiOption = this.UiOption,
				SceneInteractionOption = this.SceneInteractionOption
			};
		}

		// Token: 0x17002D30 RID: 11568
		// (get) Token: 0x06008CCB RID: 36043 RVA: 0x0014A36E File Offset: 0x0014856E
		// (set) Token: 0x06008CCC RID: 36044 RVA: 0x0014A399 File Offset: 0x00148599
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

		// Token: 0x17002D31 RID: 11569
		// (get) Token: 0x06008CCD RID: 36045 RVA: 0x0014A3A7 File Offset: 0x001485A7
		// (set) Token: 0x06008CCE RID: 36046 RVA: 0x0014A3CE File Offset: 0x001485CE
		public virtual IMoveOperationType MoveOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.MoveOption;
				}
				IDisableModulePlayerOperation_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002D32 RID: 11570
		// (get) Token: 0x06008CCF RID: 36047 RVA: 0x0014A3DC File Offset: 0x001485DC
		// (set) Token: 0x06008CD0 RID: 36048 RVA: 0x0014A403 File Offset: 0x00148603
		public virtual ISkillOperationType SkillOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SkillOption;
				}
				IDisableModulePlayerOperation_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002D33 RID: 11571
		// (get) Token: 0x06008CD1 RID: 36049 RVA: 0x0014A411 File Offset: 0x00148611
		// (set) Token: 0x06008CD2 RID: 36050 RVA: 0x0014A438 File Offset: 0x00148638
		public virtual ICameraOperationType CameraOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.CameraOption;
				}
				IDisableModulePlayerOperation_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002D34 RID: 11572
		// (get) Token: 0x06008CD3 RID: 36051 RVA: 0x0014A446 File Offset: 0x00148646
		// (set) Token: 0x06008CD4 RID: 36052 RVA: 0x0014A46D File Offset: 0x0014866D
		public virtual IUiOperationType UiOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.UiOption;
				}
				IDisableModulePlayerOperation_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17002D35 RID: 11573
		// (get) Token: 0x06008CD5 RID: 36053 RVA: 0x0014A47B File Offset: 0x0014867B
		// (set) Token: 0x06008CD6 RID: 36054 RVA: 0x0014A4A2 File Offset: 0x001486A2
		public virtual ISceneInteractionOperationType SceneInteractionOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.SceneInteractionOption;
				}
				IDisableModulePlayerOperation_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04005791 RID: 22417
		protected new IDisableModulePlayerOperation FbInstance;

		// Token: 0x04005792 RID: 22418
		protected new IDisableModulePlayerOperation_SetValue PocoInterface;
	}
}
