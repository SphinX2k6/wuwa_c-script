using System;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B39 RID: 6969
	[NullableContext(2)]
	[Nullable(0)]
	[JsonConverter(typeof(IDisableModulePlayerOperationConverter))]
	public class IDisableModulePlayerOperation : SetPlayerOperationRestriction
	{
		// Token: 0x060093F7 RID: 37879 RVA: 0x00159C04 File Offset: 0x00157E04
		[NullableContext(0)]
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

		// Token: 0x060093F8 RID: 37880 RVA: 0x00159C3C File Offset: 0x00157E3C
		[NullableContext(0)]
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

		// Token: 0x060093F9 RID: 37881 RVA: 0x00159C4F File Offset: 0x00157E4F
		[NullableContext(0)]
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

		// Token: 0x060093FA RID: 37882 RVA: 0x00159C64 File Offset: 0x00157E64
		[NullableContext(0)]
		public new IDisableModulePlayerOperation_SetValue ToSetValue()
		{
			return new IDisableModulePlayerOperation_SetValue
			{
				Type = this.Type,
				MoveOption = this.MoveOption,
				SkillOption = this.SkillOption,
				CameraOption = this.CameraOption,
				UiOption = this.UiOption,
				SceneInteractionOption = this.SceneInteractionOption,
				PlayerAiOption = this.PlayerAiOption
			};
		}

		// Token: 0x17002F32 RID: 12082
		// (get) Token: 0x060093FB RID: 37883 RVA: 0x00159CCA File Offset: 0x00157ECA
		// (set) Token: 0x060093FC RID: 37884 RVA: 0x00159CF5 File Offset: 0x00157EF5
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

		// Token: 0x17002F33 RID: 12083
		// (get) Token: 0x060093FD RID: 37885 RVA: 0x00159D03 File Offset: 0x00157F03
		// (set) Token: 0x060093FE RID: 37886 RVA: 0x00159D2A File Offset: 0x00157F2A
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

		// Token: 0x17002F34 RID: 12084
		// (get) Token: 0x060093FF RID: 37887 RVA: 0x00159D38 File Offset: 0x00157F38
		// (set) Token: 0x06009400 RID: 37888 RVA: 0x00159D5F File Offset: 0x00157F5F
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

		// Token: 0x17002F35 RID: 12085
		// (get) Token: 0x06009401 RID: 37889 RVA: 0x00159D6D File Offset: 0x00157F6D
		// (set) Token: 0x06009402 RID: 37890 RVA: 0x00159D94 File Offset: 0x00157F94
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

		// Token: 0x17002F36 RID: 12086
		// (get) Token: 0x06009403 RID: 37891 RVA: 0x00159DA2 File Offset: 0x00157FA2
		// (set) Token: 0x06009404 RID: 37892 RVA: 0x00159DC9 File Offset: 0x00157FC9
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

		// Token: 0x17002F37 RID: 12087
		// (get) Token: 0x06009405 RID: 37893 RVA: 0x00159DD7 File Offset: 0x00157FD7
		// (set) Token: 0x06009406 RID: 37894 RVA: 0x00159DFE File Offset: 0x00157FFE
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

		// Token: 0x17002F38 RID: 12088
		// (get) Token: 0x06009407 RID: 37895 RVA: 0x00159E0C File Offset: 0x0015800C
		// (set) Token: 0x06009408 RID: 37896 RVA: 0x00159E33 File Offset: 0x00158033
		public virtual IPlayerAiControlBase PlayerAiOption
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlayerAiOption;
				}
				IDisableModulePlayerOperation_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlayerAiOption;
			}
			set
			{
				this.GetOrCreatePoco().PlayerAiOption = value;
			}
		}

		// Token: 0x04005BDF RID: 23519
		protected new IDisableModulePlayerOperation FbInstance;

		// Token: 0x04005BE0 RID: 23520
		protected new IDisableModulePlayerOperation_SetValue PocoInterface;
	}
}
