using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.AudioVisualization;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034B8 RID: 13496
	[NullableContext(1)]
	[Nullable(0)]
	public class AudioVisualizationManager : IStaticVariableResetter
	{
		// Token: 0x060225D0 RID: 140752 RVA: 0x009BBF20 File Offset: 0x009BA120
		public static AudioVisualizationManager Get()
		{
			if (AudioVisualizationManager.Singleton == null)
			{
				AudioVisualizationManager.Singleton = new AudioVisualizationManager();
				AudioVisualizationManager.Singleton.Initialize();
			}
			return AudioVisualizationManager.Singleton;
		}

		// Token: 0x060225D1 RID: 140753 RVA: 0x009BBF42 File Offset: 0x009BA142
		protected void LoadAssets()
		{
			ResourceSystem.Instance.LoadAsync<PDA_AudioVisualizationGlobalConfigs_C>("/Game/Aki/Audio/AudioVisualization/Data/DA_AudioVisualizationGlobalConfigs.DA_AudioVisualizationGlobalConfigs", delegate([Nullable(2)] PDA_AudioVisualizationGlobalConfigs_C result, string _)
			{
				if (result == null || !result.IsValid())
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Render;
					ELogAuthor author = ELogAuthor.LSY;
					string message = "音频可视化未找到全局配置文件";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", "/Game/Aki/Audio/AudioVisualization/Data/DA_AudioVisualizationGlobalConfigs.DA_AudioVisualizationGlobalConfigs");
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
					return;
				}
				this.GlobalConfig = result;
				this.MaterialParametersCollectionFile = result.MPCFile;
				if (this.MaterialParametersCollectionFile == null || !this.MaterialParametersCollectionFile.IsValid())
				{
					Log.Instance.Error(ELogModule.Render, ELogAuthor.LSY, "音频可视化缺失MPC文件", default(ReadOnlySpan<ValueTuple<string, object>>));
				}
			}, 100, "js_undefined");
		}

		// Token: 0x060225D2 RID: 140754 RVA: 0x009BBF67 File Offset: 0x009BA167
		protected void Initialize()
		{
			this.InstanceActors = new Dictionary<string, AudioVisualizationInstanceBase>();
			this.LoadAssets();
		}

		// Token: 0x060225D3 RID: 140755 RVA: 0x009BBF7A File Offset: 0x009BA17A
		public void Register(AudioVisualizationInstanceBase instance)
		{
			this.InstanceActors[instance.Identifier] = instance;
			instance.ActorEndPlayCallback = delegate(AudioVisualizationInstanceBase ins)
			{
				this.Unregister(ins);
			};
			instance.Start();
		}

		// Token: 0x060225D4 RID: 140756 RVA: 0x009BBFA6 File Offset: 0x009BA1A6
		public void Unregister(AudioVisualizationInstanceBase instance)
		{
			this.InstanceActors.Remove(instance.Identifier);
			instance.End();
		}

		// Token: 0x060225D5 RID: 140757 RVA: 0x009BBFC0 File Offset: 0x009BA1C0
		public void NotifyCallBackToAll([Nullable(2)] UAkCallbackInfo callbackInfo, EAkCallbackType callbackType, string state)
		{
			foreach (KeyValuePair<string, AudioVisualizationInstanceBase> keyValuePair in this.InstanceActors)
			{
				keyValuePair.Value.CallBack(callbackInfo, callbackType, state);
			}
		}

		// Token: 0x060225D6 RID: 140758 RVA: 0x009BC01C File Offset: 0x009BA21C
		public void Tick(double deltaSeconds)
		{
		}

		// Token: 0x060225D7 RID: 140759 RVA: 0x009BC01E File Offset: 0x009BA21E
		static AudioVisualizationManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AudioVisualizationManager.CreateStaticDefaultValue), new Action(AudioVisualizationManager.ResetStaticDefaultValue));
		}

		// Token: 0x060225D8 RID: 140760 RVA: 0x009BC03D File Offset: 0x009BA23D
		public static void CreateStaticDefaultValue()
		{
			AudioVisualizationManager.Singleton = null;
			AudioVisualizationManager.StatTick = Stat.Create("AudioVisualizationManager.Tick", "", "");
		}

		// Token: 0x060225D9 RID: 140761 RVA: 0x009BC05E File Offset: 0x009BA25E
		public static void ResetStaticDefaultValue()
		{
			AudioVisualizationManager.Singleton = null;
			AudioVisualizationManager.StatTick = null;
		}

		// Token: 0x04012E86 RID: 77446
		[Nullable(2)]
		private static AudioVisualizationManager Singleton;

		// Token: 0x04012E87 RID: 77447
		[Nullable(2)]
		public PDA_AudioVisualizationGlobalConfigs_C GlobalConfig;

		// Token: 0x04012E88 RID: 77448
		[Nullable(2)]
		public UMaterialParameterCollection MaterialParametersCollectionFile;

		// Token: 0x04012E89 RID: 77449
		private static Stat StatTick;

		// Token: 0x04012E8A RID: 77450
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected Dictionary<string, AudioVisualizationInstanceBase> InstanceActors;
	}
}
