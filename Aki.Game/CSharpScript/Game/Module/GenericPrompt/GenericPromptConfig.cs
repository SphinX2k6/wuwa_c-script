using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.GenericPrompt
{
	// Token: 0x0200496A RID: 18794
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class GenericPromptConfig : ConfigBase
	{
		// Token: 0x0602F210 RID: 193040 RVA: 0x00D23A04 File Offset: 0x00D21C04
		public TableTextArgNew GetPromptTypeMainTextObj(int typeId)
		{
			return new TableTextArgNew(this.GetPromptTypeInfo(typeId).Value.GeneralText, Array.Empty<object>());
		}

		// Token: 0x0602F211 RID: 193041 RVA: 0x00D23A34 File Offset: 0x00D21C34
		public FColor? GetPromptTypeMainTextColor(int typeId)
		{
			GenericPromptTypes? genericPromptTypes;
			string text = (this.GetPromptTypeInfo(typeId) != null) ? genericPromptTypes.GetValueOrDefault().TextColor : null;
			if (!string.IsNullOrEmpty(text))
			{
				return new FColor?(FColor.FromHex(text));
			}
			return null;
		}

		// Token: 0x0602F212 RID: 193042 RVA: 0x00D23A84 File Offset: 0x00D21C84
		public TableTextArgNew GetPromptTypeExtraTextObj(int typeId)
		{
			return new TableTextArgNew(this.GetPromptTypeInfo(typeId).Value.GeneralExtraText, Array.Empty<object>());
		}

		// Token: 0x0602F213 RID: 193043 RVA: 0x00D23AB4 File Offset: 0x00D21CB4
		public TableTextArgNew GetPromptMainTextObj(int promptId)
		{
			return new TableTextArgNew(this.GetPromptInfo(promptId).Value.TipsText, Array.Empty<object>());
		}

		// Token: 0x0602F214 RID: 193044 RVA: 0x00D23AE4 File Offset: 0x00D21CE4
		public TableTextArgNew GetPromptExtraTextObj(int promptId)
		{
			return new TableTextArgNew(this.GetPromptInfo(promptId).Value.ExtraText, Array.Empty<object>());
		}

		// Token: 0x0602F215 RID: 193045 RVA: 0x00D23B12 File Offset: 0x00D21D12
		public GenericPrompt? GetPromptInfo(int promptId)
		{
			return ConfigGenericPromptByTipsId.GetConfig(promptId.ToString(), true);
		}

		// Token: 0x0602F216 RID: 193046 RVA: 0x00D23B21 File Offset: 0x00D21D21
		public GenericPrompt? GetPromptInfoByRawId(string promptRawId)
		{
			return ConfigGenericPromptByTipsId.GetConfig(promptRawId, true);
		}

		// Token: 0x0602F217 RID: 193047 RVA: 0x00D23B2C File Offset: 0x00D21D2C
		public TableTextArgNew GetPromptMainTextObjByRawId(string promptRawId)
		{
			return new TableTextArgNew(this.GetPromptInfoByRawId(promptRawId).Value.TipsText, Array.Empty<object>());
		}

		// Token: 0x0602F218 RID: 193048 RVA: 0x00D23B5A File Offset: 0x00D21D5A
		public GenericPromptTypes? GetPromptTypeInfo(int typeId)
		{
			return ConfigGenericPromptTypesByTypeId.GetConfig(typeId, true);
		}

		// Token: 0x0602F219 RID: 193049 RVA: 0x00D23B64 File Offset: 0x00D21D64
		public int GetPriority(IPromptParamHub prompt)
		{
			if (prompt.PromptId == null)
			{
				return this.GetPromptTypeInfo(prompt.TypeId).Value.Priority;
			}
			int priority = this.GetPromptInfo(prompt.PromptId.Value).Value.Priority;
			if (priority == 0)
			{
				return this.GetPromptTypeInfo(prompt.TypeId).Value.Priority;
			}
			return priority;
		}

		// Token: 0x17005F40 RID: 24384
		// (get) Token: 0x0602F21A RID: 193050 RVA: 0x00D23BE6 File Offset: 0x00D21DE6
		public static GenericPromptConfig Instance
		{
			get
			{
				return GenericPromptConfig._Instance;
			}
		}

		// Token: 0x0602F21B RID: 193051 RVA: 0x00D23BED File Offset: 0x00D21DED
		public static GenericPromptConfig GetOrCreateInstance()
		{
			if (GenericPromptConfig._Instance == null)
			{
				GenericPromptConfig.CreateInstance();
			}
			return GenericPromptConfig._Instance;
		}

		// Token: 0x0602F21C RID: 193052 RVA: 0x00D23C01 File Offset: 0x00D21E01
		public static bool CreateInstance()
		{
			if (GenericPromptConfig._Instance != null)
			{
				return true;
			}
			GenericPromptConfig._Instance = new GenericPromptConfig();
			return true;
		}

		// Token: 0x0602F21D RID: 193053 RVA: 0x00D23C17 File Offset: 0x00D21E17
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602F21E RID: 193054 RVA: 0x00D23C19 File Offset: 0x00D21E19
		public static void ResetStaticDefaultValue()
		{
			GenericPromptConfig._Instance = null;
		}

		// Token: 0x0602F21F RID: 193055 RVA: 0x00D23C21 File Offset: 0x00D21E21
		static GenericPromptConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GenericPromptConfig.CreateStaticDefaultValue), new Action(GenericPromptConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04019040 RID: 102464
		[Nullable(2)]
		private static GenericPromptConfig _Instance;
	}
}
