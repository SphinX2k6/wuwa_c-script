using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.GenericPrompt
{
	// Token: 0x02005991 RID: 22929
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class GenericPromptConfig : ConfigBase
	{
		// Token: 0x0603A2EA RID: 238314 RVA: 0x00DD4574 File Offset: 0x00DD2774
		public TableTextArgNew GetPromptTypeMainTextObj(int typeId)
		{
			return new TableTextArgNew(this.GetPromptTypeInfo(typeId).Value.GeneralText, Array.Empty<object>());
		}

		// Token: 0x0603A2EB RID: 238315 RVA: 0x00DD45A4 File Offset: 0x00DD27A4
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

		// Token: 0x0603A2EC RID: 238316 RVA: 0x00DD45F4 File Offset: 0x00DD27F4
		public TableTextArgNew GetPromptTypeExtraTextObj(int typeId)
		{
			return new TableTextArgNew(this.GetPromptTypeInfo(typeId).Value.GeneralExtraText, Array.Empty<object>());
		}

		// Token: 0x0603A2ED RID: 238317 RVA: 0x00DD4624 File Offset: 0x00DD2824
		public TableTextArgNew GetPromptMainTextObj(int promptId)
		{
			return new TableTextArgNew(this.GetPromptInfo(promptId).Value.TipsText, Array.Empty<object>());
		}

		// Token: 0x0603A2EE RID: 238318 RVA: 0x00DD4654 File Offset: 0x00DD2854
		public TableTextArgNew GetPromptExtraTextObj(int promptId)
		{
			return new TableTextArgNew(this.GetPromptInfo(promptId).Value.ExtraText, Array.Empty<object>());
		}

		// Token: 0x0603A2EF RID: 238319 RVA: 0x00DD4682 File Offset: 0x00DD2882
		public GenericPrompt? GetPromptInfo(int promptId)
		{
			return ConfigGenericPromptByTipsId.GetConfig(promptId.ToString(), true);
		}

		// Token: 0x0603A2F0 RID: 238320 RVA: 0x00DD4691 File Offset: 0x00DD2891
		public GenericPrompt? GetPromptInfoByRawId(string promptRawId)
		{
			return ConfigGenericPromptByTipsId.GetConfig(promptRawId, true);
		}

		// Token: 0x0603A2F1 RID: 238321 RVA: 0x00DD469C File Offset: 0x00DD289C
		public TableTextArgNew GetPromptMainTextObjByRawId(string promptRawId)
		{
			return new TableTextArgNew(this.GetPromptInfoByRawId(promptRawId).Value.TipsText, Array.Empty<object>());
		}

		// Token: 0x0603A2F2 RID: 238322 RVA: 0x00DD46CA File Offset: 0x00DD28CA
		public GenericPromptTypes? GetPromptTypeInfo(int typeId)
		{
			return ConfigGenericPromptTypesByTypeId.GetConfig(typeId, true);
		}

		// Token: 0x0603A2F3 RID: 238323 RVA: 0x00DD46D4 File Offset: 0x00DD28D4
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

		// Token: 0x17008B73 RID: 35699
		// (get) Token: 0x0603A2F4 RID: 238324 RVA: 0x00DD4756 File Offset: 0x00DD2956
		public static GenericPromptConfig Instance
		{
			get
			{
				return GenericPromptConfig._Instance;
			}
		}

		// Token: 0x0603A2F5 RID: 238325 RVA: 0x00DD475D File Offset: 0x00DD295D
		public static GenericPromptConfig GetOrCreateInstance()
		{
			if (GenericPromptConfig._Instance == null)
			{
				GenericPromptConfig.CreateInstance();
			}
			return GenericPromptConfig._Instance;
		}

		// Token: 0x0603A2F6 RID: 238326 RVA: 0x00DD4771 File Offset: 0x00DD2971
		public static bool CreateInstance()
		{
			if (GenericPromptConfig._Instance != null)
			{
				return true;
			}
			GenericPromptConfig._Instance = new GenericPromptConfig();
			return true;
		}

		// Token: 0x0603A2F7 RID: 238327 RVA: 0x00DD4787 File Offset: 0x00DD2987
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603A2F8 RID: 238328 RVA: 0x00DD4789 File Offset: 0x00DD2989
		public static void ResetStaticDefaultValue()
		{
			GenericPromptConfig._Instance = null;
		}

		// Token: 0x0603A2F9 RID: 238329 RVA: 0x00DD4791 File Offset: 0x00DD2991
		static GenericPromptConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GenericPromptConfig.CreateStaticDefaultValue), new Action(GenericPromptConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401E5A2 RID: 124322
		[Nullable(2)]
		private static GenericPromptConfig _Instance;
	}
}
