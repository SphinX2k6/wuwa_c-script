using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.AudioVisualization;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x02004590 RID: 17808
	[NullableContext(1)]
	[Nullable(0)]
	public class AudioVisualizationManager : IStaticVariableResetter
	{
		// Token: 0x0602DEE6 RID: 188134 RVA: 0x00A8FD00 File Offset: 0x00A8DF00
		public static AudioVisualizationManager Get()
		{
			if (AudioVisualizationManager.Singleton == null)
			{
				AudioVisualizationManager.Singleton = new AudioVisualizationManager();
				AudioVisualizationManager.Singleton.Initialize();
			}
			return AudioVisualizationManager.Singleton;
		}

		// Token: 0x0602DEE7 RID: 188135 RVA: 0x00A8FD22 File Offset: 0x00A8DF22
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

		// Token: 0x0602DEE8 RID: 188136 RVA: 0x00A8FD47 File Offset: 0x00A8DF47
		protected void Initialize()
		{
			this.InstanceActors = new Dictionary<string, AudioVisualizationInstanceBase>();
			this.LoadAssets();
		}

		// Token: 0x0602DEE9 RID: 188137 RVA: 0x00A8FD5A File Offset: 0x00A8DF5A
		public void Register(AudioVisualizationInstanceBase instance)
		{
			this.InstanceActors[instance.Identifier] = instance;
			instance.ActorEndPlayCallback = delegate(AudioVisualizationInstanceBase ins)
			{
				this.Unregister(ins);
			};
			instance.Start();
		}

		// Token: 0x0602DEEA RID: 188138 RVA: 0x00A8FD86 File Offset: 0x00A8DF86
		public void Unregister(AudioVisualizationInstanceBase instance)
		{
			this.InstanceActors.Remove(instance.Identifier);
			instance.End();
		}

		// Token: 0x0602DEEB RID: 188139 RVA: 0x00A8FDA0 File Offset: 0x00A8DFA0
		public void NotifyCallBackToAll([Nullable(2)] UAkCallbackInfo callbackInfo, EAkCallbackType callbackType, string state)
		{
			foreach (KeyValuePair<string, AudioVisualizationInstanceBase> keyValuePair in this.InstanceActors)
			{
				keyValuePair.Value.CallBack(callbackInfo, callbackType, state);
			}
		}

		// Token: 0x0602DEEC RID: 188140 RVA: 0x00A8FDFC File Offset: 0x00A8DFFC
		public void Tick(double deltaSeconds)
		{
		}

		// Token: 0x0602DEED RID: 188141 RVA: 0x00A8FDFE File Offset: 0x00A8DFFE
		static AudioVisualizationManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(AudioVisualizationManager.CreateStaticDefaultValue), new Action(AudioVisualizationManager.ResetStaticDefaultValue));
		}

		// Token: 0x0602DEEE RID: 188142 RVA: 0x00A8FE1D File Offset: 0x00A8E01D
		public static void CreateStaticDefaultValue()
		{
			AudioVisualizationManager.Singleton = null;
			AudioVisualizationManager.StatTick = Stat.Create("AudioVisualizationManager.Tick", "", "");
		}

		// Token: 0x0602DEEF RID: 188143 RVA: 0x00A8FE3E File Offset: 0x00A8E03E
		public static void ResetStaticDefaultValue()
		{
			AudioVisualizationManager.Singleton = null;
			AudioVisualizationManager.StatTick = null;
		}

		// Token: 0x0401884B RID: 100427
		[Nullable(2)]
		private static AudioVisualizationManager Singleton;

		// Token: 0x0401884C RID: 100428
		[Nullable(2)]
		public PDA_AudioVisualizationGlobalConfigs_C GlobalConfig;

		// Token: 0x0401884D RID: 100429
		[Nullable(2)]
		public UMaterialParameterCollection MaterialParametersCollectionFile;

		// Token: 0x0401884E RID: 100430
		private static Stat StatTick;

		// Token: 0x0401884F RID: 100431
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		protected Dictionary<string, AudioVisualizationInstanceBase> InstanceActors;
	}
}
