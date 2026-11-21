using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02004815 RID: 18453
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class InteractionConfig : ConfigBase
	{
		// Token: 0x0602E5C3 RID: 189891 RVA: 0x00CEF8CC File Offset: 0x00CEDACC
		public InteractData? GetInteractionConfig(string guid)
		{
			InteractData? config = ConfigInteractDataByGuid.GetConfig(guid, false);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Interaction;
				ELogAuthor author = ELogAuthor.CWZ;
				string message = "找不到交互配置";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Interact GUID", guid);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			}
			return config;
		}

		// Token: 0x17005E01 RID: 24065
		// (get) Token: 0x0602E5C4 RID: 189892 RVA: 0x00CEF915 File Offset: 0x00CEDB15
		public static InteractionConfig Instance
		{
			get
			{
				return InteractionConfig._Instance;
			}
		}

		// Token: 0x0602E5C5 RID: 189893 RVA: 0x00CEF91C File Offset: 0x00CEDB1C
		public static InteractionConfig GetOrCreateInstance()
		{
			if (InteractionConfig._Instance == null)
			{
				InteractionConfig.CreateInstance();
			}
			return InteractionConfig._Instance;
		}

		// Token: 0x0602E5C6 RID: 189894 RVA: 0x00CEF930 File Offset: 0x00CEDB30
		public static bool CreateInstance()
		{
			if (InteractionConfig._Instance != null)
			{
				return true;
			}
			InteractionConfig._Instance = new InteractionConfig();
			return true;
		}

		// Token: 0x0602E5C7 RID: 189895 RVA: 0x00CEF946 File Offset: 0x00CEDB46
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E5C8 RID: 189896 RVA: 0x00CEF948 File Offset: 0x00CEDB48
		public static void ResetStaticDefaultValue()
		{
			InteractionConfig._Instance = null;
		}

		// Token: 0x0602E5C9 RID: 189897 RVA: 0x00CEF950 File Offset: 0x00CEDB50
		static InteractionConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InteractionConfig.CreateStaticDefaultValue), new Action(InteractionConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04018B0A RID: 101130
		[Nullable(2)]
		private static InteractionConfig _Instance;
	}
}
