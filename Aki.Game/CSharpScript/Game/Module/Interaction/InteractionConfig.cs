using System;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x0200583E RID: 22590
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class InteractionConfig : ConfigBase
	{
		// Token: 0x060396AF RID: 235183 RVA: 0x00DA09C0 File Offset: 0x00D9EBC0
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

		// Token: 0x17008A38 RID: 35384
		// (get) Token: 0x060396B0 RID: 235184 RVA: 0x00DA0A09 File Offset: 0x00D9EC09
		public static InteractionConfig Instance
		{
			get
			{
				return InteractionConfig._Instance;
			}
		}

		// Token: 0x060396B1 RID: 235185 RVA: 0x00DA0A10 File Offset: 0x00D9EC10
		public static InteractionConfig GetOrCreateInstance()
		{
			if (InteractionConfig._Instance == null)
			{
				InteractionConfig.CreateInstance();
			}
			return InteractionConfig._Instance;
		}

		// Token: 0x060396B2 RID: 235186 RVA: 0x00DA0A24 File Offset: 0x00D9EC24
		public static bool CreateInstance()
		{
			if (InteractionConfig._Instance != null)
			{
				return true;
			}
			InteractionConfig._Instance = new InteractionConfig();
			return true;
		}

		// Token: 0x060396B3 RID: 235187 RVA: 0x00DA0A3A File Offset: 0x00D9EC3A
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060396B4 RID: 235188 RVA: 0x00DA0A3C File Offset: 0x00D9EC3C
		public static void ResetStaticDefaultValue()
		{
			InteractionConfig._Instance = null;
		}

		// Token: 0x060396B5 RID: 235189 RVA: 0x00DA0A44 File Offset: 0x00D9EC44
		static InteractionConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(InteractionConfig.CreateStaticDefaultValue), new Action(InteractionConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401E071 RID: 122993
		[Nullable(2)]
		private static InteractionConfig _Instance;
	}
}
