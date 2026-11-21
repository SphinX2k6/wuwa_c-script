using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Render.RuntimeBP.Battle;
using AkiClient.Game.Aki.Render.RuntimeBP.RenderData;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Plot;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Render.DebugDraw;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x02003502 RID: 13570
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class RenderModuleModel : ModelBase
	{
		// Token: 0x06022862 RID: 141410 RVA: 0x009CC599 File Offset: 0x009CA799
		public EWuYinQuState GetCurrentKeyState(string actorKey)
		{
			if (actorKey == this.CurrentBattleKey)
			{
				return this.CurrentBattleState;
			}
			return EWuYinQuState.StateIdle;
		}

		// Token: 0x06022863 RID: 141411 RVA: 0x009CC5B1 File Offset: 0x009CA7B1
		public bool GetIdleClearAtmosphere(string actorKey)
		{
			return actorKey == this.CurrentBattleKey && this.IsIdleClearAtmosphere;
		}

		// Token: 0x06022864 RID: 141412 RVA: 0x009CC5CC File Offset: 0x009CA7CC
		public unsafe void SetBattleState(string key, EWuYinQuState state, bool instantTransition = false)
		{
			this.CurrentBattleKey = key;
			this.CurrentBattleState = state;
			this.CurrentInputBattleState = state;
			if (this.CurrentBattleState == EWuYinQuState.Nothing)
			{
				this.IsIdleClearAtmosphere = true;
				this.CurrentBattleState = EWuYinQuState.StateIdle;
			}
			else
			{
				this.IsIdleClearAtmosphere = false;
			}
			this.InstantTransition = instantTransition;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.RenderBattle;
			ELogAuthor author = ELogAuthor.HCS;
			string message = "BOSS战设置战斗状态Inner";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", key);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("state", state);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}

		// Token: 0x06022865 RID: 141413 RVA: 0x009CC66D File Offset: 0x009CA86D
		public bool IsStateInstantTransition()
		{
			return this.InstantTransition;
		}

		// Token: 0x06022866 RID: 141414 RVA: 0x009CC678 File Offset: 0x009CA878
		private string GetStateString(EWuYinQuState inputState)
		{
			string result;
			switch (inputState)
			{
			case EWuYinQuState.StateIdle:
				result = "静止状态";
				break;
			case EWuYinQuState.StateFighting1:
				result = "战斗1阶段";
				break;
			case EWuYinQuState.StateFighting2:
				result = "战斗2阶段";
				break;
			case EWuYinQuState.StateFighting3:
				result = "战斗3阶段";
				break;
			case EWuYinQuState.Nothing:
				result = "无状态";
				break;
			default:
				result = "错误";
				break;
			}
			return result;
		}

		// Token: 0x06022867 RID: 141415 RVA: 0x009CC6D0 File Offset: 0x009CA8D0
		public TArray<string> GetWuYinQuBattleDebugInfo()
		{
			TArray<string> tarray = new TArray<string>();
			List<string> list = new List<string>();
			list.Add(this.GetCurrentBattleKey() + "," + this.GetStateString(this.CurrentInputBattleState));
			foreach (WuYinQuBattleActor wuYinQuBattleActor in this.AllWuYinQuBattleActors.Values)
			{
				if (wuYinQuBattleActor.IsValid())
				{
					string item = wuYinQuBattleActor.GetKey() + "," + this.GetStateString(wuYinQuBattleActor.GetCurrentBattleState());
					list.Add(item);
				}
			}
			WorldGlobal.ToUeStringArray(list, tarray);
			return tarray;
		}

		// Token: 0x06022868 RID: 141416 RVA: 0x009CC788 File Offset: 0x009CA988
		public EWuYinQuState GetBattleState(string key)
		{
			if (this.CurrentBattleKey == key)
			{
				return this.CurrentBattleState;
			}
			return EWuYinQuState.StateIdle;
		}

		// Token: 0x06022869 RID: 141417 RVA: 0x009CC7A0 File Offset: 0x009CA9A0
		[NullableContext(2)]
		public string GetCurrentBattleKey()
		{
			return this.CurrentBattleKey;
		}

		// Token: 0x0602286A RID: 141418 RVA: 0x009CC7A8 File Offset: 0x009CA9A8
		public void AddBattleReference(FVectorDouble location)
		{
			this.BattleRefCount++;
			if (this.BattleRefCount > 0)
			{
				this.SetStreamingSourceState(location, true);
			}
		}

		// Token: 0x0602286B RID: 141419 RVA: 0x009CC7C9 File Offset: 0x009CA9C9
		public float GetSnowIntensity()
		{
			RenderDataManager instance = RenderDataManager.Instance;
			if (instance == null)
			{
				return 0f;
			}
			return instance.GetSnowIntensity();
		}

		// Token: 0x0602286C RID: 141420 RVA: 0x009CC7DF File Offset: 0x009CA9DF
		public float GetRainIntensity()
		{
			RenderDataManager instance = RenderDataManager.Instance;
			if (instance == null)
			{
				return 0f;
			}
			return instance.GetRainIntensity();
		}

		// Token: 0x0602286D RID: 141421 RVA: 0x009CC7F5 File Offset: 0x009CA9F5
		public void DecBattleReference()
		{
			this.BattleRefCount--;
			if (this.BattleRefCount <= 0)
			{
				this.SetStreamingSourceState(new FVectorDouble(0.0, 0.0, 0.0), false);
			}
		}

		// Token: 0x0602286E RID: 141422 RVA: 0x009CC835 File Offset: 0x009CAA35
		public void SetStreamingSourceState(FVectorDouble location, bool isEnable)
		{
		}

		// Token: 0x0602286F RID: 141423 RVA: 0x009CC838 File Offset: 0x009CAA38
		[return: Nullable(2)]
		public WuYinQuBattleActor GetWuYinQuBattleActorByName(string name)
		{
			WuYinQuBattleActor result;
			if (this.AllWuYinQuBattleActors.TryGetValue(name, out result))
			{
				return result;
			}
			return null;
		}

		// Token: 0x06022870 RID: 141424 RVA: 0x009CC858 File Offset: 0x009CAA58
		[NullableContext(2)]
		public bool AddWuYinQuBattleActor(WuYinQuBattleActor actor)
		{
			if (actor == null || !actor.IsValid())
			{
				Log.Instance.Error(ELogModule.RenderBattle, ELogAuthor.HCS, "无音区actor添加失败1", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			string key = actor.GetKey();
			if (actor.IsInitialize())
			{
				return false;
			}
			if (this.GetWuYinQuBattleActorByName(key) != null)
			{
				return false;
			}
			if (actor.Init())
			{
				this.AllWuYinQuBattleActors[key] = actor;
				return true;
			}
			return false;
		}

		// Token: 0x06022871 RID: 141425 RVA: 0x009CC8C8 File Offset: 0x009CAAC8
		[NullableContext(2)]
		public bool RemoveWuYinQuBattleActor(WuYinQuBattleActor actor)
		{
			if (actor == null || !actor.IsValid())
			{
				Log.Instance.Error(ELogModule.RenderBattle, ELogAuthor.HCS, "无音区actor移除失败1", default(ReadOnlySpan<ValueTuple<string, object>>));
				return false;
			}
			string key = actor.GetKey();
			return this.AllWuYinQuBattleActors.Remove(key);
		}

		// Token: 0x06022872 RID: 141426 RVA: 0x009CC91C File Offset: 0x009CAB1C
		public void AddTickableObject(IRenderModuleTickableObject obj)
		{
			if (this.TickableObjects.IndexOf(obj) < 0)
			{
				this.TickableObjects.Add(obj);
			}
		}

		// Token: 0x06022873 RID: 141427 RVA: 0x009CC93C File Offset: 0x009CAB3C
		public void RemoveTickableObject(IRenderModuleTickableObject obj)
		{
			int num = this.TickableObjects.IndexOf(obj);
			if (num < 0)
			{
				return;
			}
			if (this.TickableObjects.Count <= 2)
			{
				this.TickableObjects.RemoveAt(num);
				return;
			}
			List<IRenderModuleTickableObject> tickableObjects = this.TickableObjects;
			int index = num;
			List<IRenderModuleTickableObject> tickableObjects2 = this.TickableObjects;
			tickableObjects[index] = tickableObjects2[tickableObjects2.Count - 1];
			this.TickableObjects.RemoveAt(this.TickableObjects.Count - 1);
		}

		// Token: 0x06022874 RID: 141428 RVA: 0x009CC9B0 File Offset: 0x009CABB0
		public void AddCharRenderShell(CharRenderingComponent charRenderingComponent)
		{
			CharRenderShell charRenderShell = new CharRenderShell();
			charRenderShell.Init(charRenderingComponent);
			this.AllRenderShell[charRenderingComponent] = charRenderShell;
		}

		// Token: 0x06022875 RID: 141429 RVA: 0x009CC9D7 File Offset: 0x009CABD7
		public bool RemoveCharRenderShell(CharRenderingComponent charRenderingComponent)
		{
			CharRenderShell valueOrDefault = this.AllRenderShell.GetValueOrDefault(charRenderingComponent);
			if (valueOrDefault != null)
			{
				valueOrDefault.Clear();
			}
			return this.AllRenderShell.Remove(charRenderingComponent);
		}

		// Token: 0x17004863 RID: 18531
		// (get) Token: 0x06022876 RID: 141430 RVA: 0x009CC9FC File Offset: 0x009CABFC
		public bool ForceTickCharRenderShell
		{
			get
			{
				return this.ForceTickCharRenderShellInternal;
			}
		}

		// Token: 0x06022877 RID: 141431 RVA: 0x009CCA04 File Offset: 0x009CAC04
		private void OnSetGamePaused(bool isPaused)
		{
			if (!isPaused && this.ForceTickCharRenderShellInternal)
			{
				Log.Instance.Warn(ELogModule.Render, ELogAuthor.WLJ, "退出真时停时仍然开启CharRenderShell的强制Tick", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.DisableForceTickCharRenderShell("RenderModuleModel OnSetGamePaused");
			}
		}

		// Token: 0x06022878 RID: 141432 RVA: 0x009CCA43 File Offset: 0x009CAC43
		private void OnWorldDone()
		{
			RenderDataManager instance = RenderDataManager.Instance;
			PlayerInfoModel instance2 = PlayerInfoModel.Instance;
			instance.SetIsPlayerMale(instance2 != null && instance2.GetPlayerGender() == EPlayerGender.Male);
		}

		// Token: 0x06022879 RID: 141433 RVA: 0x009CCA63 File Offset: 0x009CAC63
		private void OnBattleStateChanged(bool inBattle)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.SetCharacterInBattle(GlobalData.World, inBattle);
		}

		// Token: 0x0602287A RID: 141434 RVA: 0x009CCA70 File Offset: 0x009CAC70
		public void DisableForceTickCharRenderShell(string reason)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Render;
			ELogAuthor author = ELogAuthor.WLJ;
			string message = "关闭CharRenderShell的强制Tick";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", reason);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.ForceTickCharRenderShellInternal = false;
		}

		// Token: 0x0602287B RID: 141435 RVA: 0x009CCAAC File Offset: 0x009CACAC
		public void EnableForceTickCharRenderShell(string reason)
		{
			if (!TickSystem.Instance.IsPaused)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Render;
				ELogAuthor author = ELogAuthor.WLJ;
				string message = "只有真时停环境下才能开启CharRenderShell的强制Tick";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Reason", reason);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Render;
			ELogAuthor author2 = ELogAuthor.WLJ;
			string message2 = "开启CharRenderShell的强制Tick";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Reason", reason);
			instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			this.ForceTickCharRenderShellInternal = true;
		}

		// Token: 0x0602287C RID: 141436 RVA: 0x009CCB1C File Offset: 0x009CAD1C
		public unsafe void Tick(float delta)
		{
			float num = 0.001f;
			float num2 = delta * num;
			foreach (IRenderModuleTickableObject renderModuleTickableObject in this.TickableObjects)
			{
				try
				{
					renderModuleTickableObject.Tick(num2);
				}
				catch (Exception ex)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Render;
					ELogAuthor author = ELogAuthor.LSY;
					string message = "TickableObject Tick执行异常";
					Exception error = ex;
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("error", ex.Message);
					instance.ErrorWithStack(module, author, message, error, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
			if (!CharRenderShell.CharRenderShellGameBudgetOptimize || Info.Instance.IsInEditorTick() || this.ForceTickCharRenderShellInternal)
			{
				using (Dictionary<CharRenderingComponent, CharRenderShell>.ValueCollection.Enumerator enumerator2 = this.AllRenderShell.Values.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						CharRenderShell charRenderShell = enumerator2.Current;
						try
						{
							charRenderShell.Tick((double)num2, false);
						}
						catch (Exception ex2)
						{
							Log instance2 = Log.Instance;
							ELogModule module2 = ELogModule.Render;
							ELogAuthor author2 = ELogAuthor.LSY;
							string message2 = "RenderShell Tick执行异常";
							Exception error2 = ex2;
							ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("error", ex2.Message);
							instance2.ErrorWithStack(module2, author2, message2, error2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
						}
					}
					goto IL_1CB;
				}
			}
			bool flag;
			if (Info.Instance.IsGameRunning())
			{
				if (!GlobalData.IsUiSceneOpen && !GlobalData.IsUiSceneLoading && !CameraController.Instance.IsSequenceCameraInCinematic("MainCamera"))
				{
					PlotModel instance3 = PlotModel.Instance;
					flag = (instance3 != null && instance3.IsInPlot);
				}
				else
				{
					flag = true;
				}
			}
			else
			{
				flag = false;
			}
			if (flag)
			{
				foreach (CharRenderShell charRenderShell2 in this.AllRenderShell.Values)
				{
					try
					{
						if (charRenderShell2.IsAlwaysTick)
						{
							charRenderShell2.Tick((double)num2, false);
						}
					}
					catch (Exception ex3)
					{
						Log instance4 = Log.Instance;
						ELogModule module3 = ELogModule.Render;
						ELogAuthor author3 = ELogAuthor.LSY;
						string message3 = "RenderShell Tick执行异常";
						Exception error3 = ex3;
						ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("error", ex3.Message);
						instance4.ErrorWithStack(module3, author3, message3, error3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
					}
				}
			}
			IL_1CB:
			if (!TickSystem.Instance.IsPaused)
			{
				foreach (WuYinQuBattleActor wuYinQuBattleActor in this.AllWuYinQuBattleActors.Values)
				{
					try
					{
						if (wuYinQuBattleActor.IsValid())
						{
							string b = wuYinQuBattleActor.Key.ToString();
							if (this.CurrentBattleKey == b)
							{
								if (this.CurrentBattleState != wuYinQuBattleActor.GetCurrentBattleState())
								{
									wuYinQuBattleActor.ChangeState(this.CurrentBattleState, this.IsStateInstantTransition());
								}
							}
							else if (wuYinQuBattleActor.GetCurrentBattleState() != EWuYinQuState.StateIdle)
							{
								wuYinQuBattleActor.ChangeState(EWuYinQuState.StateIdle, this.IsStateInstantTransition());
							}
							wuYinQuBattleActor.Tick(delta);
						}
					}
					catch (Exception ex4)
					{
						Log instance5 = Log.Instance;
						ELogModule module4 = ELogModule.Render;
						ELogAuthor author4 = ELogAuthor.LSY;
						string message4 = "WuYinQuBattleActor 执行异常";
						Exception error4 = ex4;
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("error", ex4.Message);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("object", wuYinQuBattleActor);
						instance5.ErrorWithStack(module4, author4, message4, error4, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					}
				}
			}
			try
			{
				RenderDataManager.Instance.TickForce(delta);
				if (!TickSystem.Instance.IsPaused)
				{
					RenderDataManager.Instance.Tick(delta);
				}
			}
			catch (Exception ex5)
			{
				Log instance6 = Log.Instance;
				ELogModule module5 = ELogModule.Render;
				ELogAuthor author5 = ELogAuthor.LSY;
				string message5 = "RenderDataManager Tick执行异常";
				Exception error5 = ex5;
				ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("error", ex5.Message);
				instance6.ErrorWithStack(module5, author5, message5, error5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
			}
			try
			{
				if (!TickSystem.Instance.IsPaused)
				{
					SceneInteractionManager.StaticTick(delta);
				}
			}
			catch (Exception ex6)
			{
				Log instance7 = Log.Instance;
				ELogModule module6 = ELogModule.Render;
				ELogAuthor author6 = ELogAuthor.LSY;
				string message6 = "SceneInteractionManager Tick执行异常";
				Exception error6 = ex6;
				ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>("error", ex6.Message);
				instance7.ErrorWithStack(module6, author6, message6, error6, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
			}
			try
			{
				ItemMaterialManager.Instance.Tick(delta);
			}
			catch (Exception ex7)
			{
				Log instance8 = Log.Instance;
				ELogModule module7 = ELogModule.Render;
				ELogAuthor author7 = ELogAuthor.LSY;
				string message7 = "ItemMaterialManager Tick执行异常";
				Exception error7 = ex7;
				ValueTuple<string, object> valueTuple6 = new ValueTuple<string, object>("error", ex7.Message);
				instance8.ErrorWithStack(module7, author7, message7, error7, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple6));
			}
			try
			{
				if (!TickSystem.Instance.IsPaused)
				{
					DebugDrawManager.Tick(delta);
				}
			}
			catch (Exception ex8)
			{
				Log instance9 = Log.Instance;
				ELogModule module8 = ELogModule.Render;
				ELogAuthor author8 = ELogAuthor.LSY;
				string message8 = "DebugDrawManager Tick执行异常";
				Exception error8 = ex8;
				ValueTuple<string, object> valueTuple7 = new ValueTuple<string, object>("error", ex8.Message);
				instance9.ErrorWithStack(module8, author8, message8, error8, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple7));
			}
			try
			{
				if (Info.Instance.IsGameRunning() && this.UltraSkillCounter > (float)(-(float)this.UltraSkillCounterMax) && this.UltraSkillCounter < (float)this.UltraSkillCounterMax)
				{
					this.UltraSkillCounter += (this.IsInUltraSkill ? num2 : (-num2));
					UKismetMaterialLibrary.SetScalarParameterValue(GlobalData.World, this.MpcForGameplay, this.mpcForGameplayNameBurstTime, this.UltraSkillCounter);
				}
			}
			catch (Exception ex9)
			{
				Log instance10 = Log.Instance;
				ELogModule module9 = ELogModule.Render;
				ELogAuthor author9 = ELogAuthor.LSY;
				string message9 = "MpcForGameplay设置异常";
				Exception error9 = ex9;
				ValueTuple<string, object> valueTuple8 = new ValueTuple<string, object>("error", ex9.Message);
				instance10.ErrorWithStack(module9, author9, message9, error9, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple8));
			}
		}

		// Token: 0x0602287D RID: 141437 RVA: 0x009CD074 File Offset: 0x009CB274
		protected override bool OnInit()
		{
			this.BattleRefCount = 0;
			this.TickableObjects = new List<IRenderModuleTickableObject>();
			this.AllRenderShell = new Dictionary<CharRenderingComponent, CharRenderShell>();
			this.AllWuYinQuBattleActors = new Dictionary<string, WuYinQuBattleActor>();
			this.CurrentBattleKey = null;
			this.CurrentBattleState = EWuYinQuState.StateIdle;
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "初始化BOSS战渲染模块", default(ReadOnlySpan<ValueTuple<string, object>>));
			RenderDataManager instance = RenderDataManager.Instance;
			EffectManagerBusinessProxy instance2 = EffectManagerBusinessProxy.Instance;
			SceneInteractionManager.Initialize();
			ItemMaterialManager.Instance.Initialize();
			DebugDrawManager.Initialize();
			EventSystem.Instance.Add<bool>(EEventName.TeleportStart, new Action<bool>(this.OnStartTeleport));
			EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnCompleteTeleport));
			EventSystem.Instance.Add<bool>(EEventName.OnEnterOrExitUltraSkill, new Action<bool>(this.OnEnterOrExitUltraSkill));
			EventSystem.Instance.Add<bool, string>(EEventName.OnSequenceCameraStatus, new Action<bool, string>(this.OnSequenceCameraStatus));
			EventSystem.Instance.Add<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.CameraModeChanged));
			EventSystem.Instance.Add<bool>(EEventName.OnSetGamePaused, new Action<bool>(this.OnSetGamePaused));
			EventSystem.Instance.Add(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Add(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			ResourceSystem.Instance.LoadAsync<UMaterialParameterCollection>("/Game/Aki/Render/Shaders/PostProcess/DistortionWave/MPC_ForGamePlay.MPC_ForGamePlay", delegate([Nullable(2)] UMaterialParameterCollection result, string path)
			{
				this.MpcForGameplay = result;
			}, 100, "js_undefined");
			return true;
		}

		// Token: 0x0602287E RID: 141438 RVA: 0x009CD1F8 File Offset: 0x009CB3F8
		protected override bool OnClear()
		{
			this.DoClear();
			this.TickableObjects = new List<IRenderModuleTickableObject>();
			this.AllRenderShell = new Dictionary<CharRenderingComponent, CharRenderShell>();
			this.AllWuYinQuBattleActors = new Dictionary<string, WuYinQuBattleActor>();
			this.CurrentBattleKey = null;
			this.CurrentBattleState = EWuYinQuState.StateIdle;
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "清理BOSS战渲染模块", default(ReadOnlySpan<ValueTuple<string, object>>));
			RenderDataManager.Instance.Destroy();
			DebugDrawManager.Destroy();
			EventSystem.Instance.Remove<bool>(EEventName.TeleportStart, new Action<bool>(this.OnStartTeleport));
			EventSystem.Instance.Remove<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnCompleteTeleport));
			EventSystem.Instance.Remove<bool>(EEventName.OnEnterOrExitUltraSkill, new Action<bool>(this.OnEnterOrExitUltraSkill));
			EventSystem.Instance.Remove<bool, string>(EEventName.OnSequenceCameraStatus, new Action<bool, string>(this.OnSequenceCameraStatus));
			EventSystem.Instance.Remove<ECustomCameraMode, ECustomCameraMode?, string>(EEventName.CameraModeChanged, new Action<ECustomCameraMode, ECustomCameraMode?, string>(this.CameraModeChanged));
			EventSystem.Instance.Remove<bool>(EEventName.OnSetGamePaused, new Action<bool>(this.OnSetGamePaused));
			EventSystem.Instance.Remove(EEventName.WorldDone, new Action(this.OnWorldDone));
			EventSystem.Instance.Remove(EEventName.OnBattleStateChanged, new Action<bool>(this.OnBattleStateChanged));
			return true;
		}

		// Token: 0x0602287F RID: 141439 RVA: 0x009CD348 File Offset: 0x009CB548
		protected override bool OnLeaveLevel()
		{
			this.TempDependenciesNotMatchDataLayerSet.Clear();
			foreach (string item in this.DependenciesNotMatchDataLayerSet)
			{
				this.TempDependenciesNotMatchDataLayerSet.Add(item);
			}
			this.DependenciesNotMatchDataLayerSet.Clear();
			this.DoClear();
			Log.Instance.Info(ELogModule.RenderBattle, ELogAuthor.HCS, "BOSS战渲染模块离开关卡", default(ReadOnlySpan<ValueTuple<string, object>>));
			return true;
		}

		// Token: 0x06022880 RID: 141440 RVA: 0x009CD3DC File Offset: 0x009CB5DC
		private void DoClear()
		{
			this.TickableObjects = new List<IRenderModuleTickableObject>();
			this.AllRenderShell = new Dictionary<CharRenderingComponent, CharRenderShell>();
			this.AllWuYinQuBattleActors = new Dictionary<string, WuYinQuBattleActor>();
			this.CurrentBattleKey = null;
			this.CurrentBattleState = EWuYinQuState.StateIdle;
			this.BattleRefCount = 0;
		}

		// Token: 0x06022881 RID: 141441 RVA: 0x009CD414 File Offset: 0x009CB614
		public int EnableGlobalData(ItemMaterialControllerGlobalData globalMaterialData)
		{
			return -1;
		}

		// Token: 0x06022882 RID: 141442 RVA: 0x009CD417 File Offset: 0x009CB617
		public int EnableActorData([Nullable(2)] ItemMaterialControllerActorData actorMaterialData, AActor actor)
		{
			if (actor != null && actorMaterialData != null)
			{
				return ItemMaterialManager.Instance.AddMaterialData(actor, actorMaterialData);
			}
			return -1;
		}

		// Token: 0x06022883 RID: 141443 RVA: 0x009CD42D File Offset: 0x009CB62D
		public void DisableGlobal(int handle)
		{
		}

		// Token: 0x06022884 RID: 141444 RVA: 0x009CD42F File Offset: 0x009CB62F
		public void DisableAllGlobal()
		{
		}

		// Token: 0x06022885 RID: 141445 RVA: 0x009CD431 File Offset: 0x009CB631
		public void DisableActorData(int handle)
		{
			ItemMaterialManager.Instance.DisableActorData(handle);
		}

		// Token: 0x06022886 RID: 141446 RVA: 0x009CD43F File Offset: 0x009CB63F
		public void DisableAllActorData()
		{
			ItemMaterialManager.Instance.DisableAllActorData();
		}

		// Token: 0x06022887 RID: 141447 RVA: 0x009CD44C File Offset: 0x009CB64C
		public void UpdateItemMaterialParameterCollection(ItemMaterialControllerMPCData_C data)
		{
			ItemMaterialParameterCollectionController.UpdateMaterialParameterCollection(data, RenderDataManager.Instance.GetSceneInteractionMaterialParameterCollection());
		}

		// Token: 0x06022888 RID: 141448 RVA: 0x009CD45E File Offset: 0x009CB65E
		private void OnStartTeleport(bool b)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.StopSomeWeatherBeforeTeleport(GlobalData.World);
		}

		// Token: 0x06022889 RID: 141449 RVA: 0x009CD46C File Offset: 0x009CB66C
		[NullableContext(2)]
		private void OnCompleteTeleport(TeleportContext teleportContext)
		{
			float interval = 100f;
			TimerSystem.Instance.Delay(delegate(float _)
			{
				UKuroRenderingRuntimeBPPluginBPLibrary.ResumeSomeWeatherAfterTeleport(GlobalData.World);
			}, interval, null, null, true, 1f);
		}

		// Token: 0x0602288A RID: 141450 RVA: 0x009CD4B4 File Offset: 0x009CB6B4
		private void OnEnterOrExitUltraSkill(bool isEnter)
		{
			if (isEnter && !this.WasEffectPostProcessDisabled)
			{
				UKuroRenderingRuntimeBPPluginBPLibrary.SetDisableEffectPostProcessVolume(GlobalData.World, true, 4f);
				this.WasEffectPostProcessDisabled = true;
				Log.Instance.Info(ELogModule.Render, ELogAuthor.LSY, "进入大招禁用特效后处理", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			if (!isEnter && this.WasEffectPostProcessDisabled)
			{
				UKuroRenderingRuntimeBPPluginBPLibrary.SetDisableEffectPostProcessVolume(GlobalData.World, false, 1f);
				this.WasEffectPostProcessDisabled = false;
				Log.Instance.Info(ELogModule.Render, ELogAuthor.LSY, "退出大招启用特效后处理", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			if (!isEnter)
			{
				TimerSystem.Instance.Next(delegate(float _)
				{
					TsBaseCharacter baseCharacter = Global.BaseCharacter;
					if (baseCharacter == null)
					{
						return;
					}
					CharRenderingComponent charRenderingComponent = baseCharacter.CharRenderingComponent;
					if (charRenderingComponent == null)
					{
						return;
					}
					charRenderingComponent.RefreshMaterialController();
				}, null, null);
			}
			this.IsInUltraSkill = isEnter;
			this.UltraSkillCounter = 0f;
		}

		// Token: 0x0602288B RID: 141451 RVA: 0x009CD580 File Offset: 0x009CB780
		private void OnSequenceCameraStatus(bool isEnter, string cameraName)
		{
			if (cameraName != "MainCamera")
			{
				return;
			}
			if (!isEnter && this.WasEffectPostProcessDisabled)
			{
				UKuroRenderingRuntimeBPPluginBPLibrary.SetDisableEffectPostProcessVolume(GlobalData.World, false, 1f);
				this.WasEffectPostProcessDisabled = false;
				Log.Instance.Info(ELogModule.Render, ELogAuthor.LSY, "退出镜头启用特效后处理", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			if (!isEnter)
			{
				TimerSystem.Instance.Next(delegate(float _)
				{
					TsBaseCharacter baseCharacter = Global.BaseCharacter;
					if (baseCharacter == null)
					{
						return;
					}
					CharRenderingComponent charRenderingComponent = baseCharacter.CharRenderingComponent;
					if (charRenderingComponent == null)
					{
						return;
					}
					charRenderingComponent.RefreshMaterialController();
				}, null, null);
			}
		}

		// Token: 0x0602288C RID: 141452 RVA: 0x009CD608 File Offset: 0x009CB808
		private void CameraModeChanged(ECustomCameraMode newMode, ECustomCameraMode? oldMode, string cameraName)
		{
			if (cameraName != "MainCamera")
			{
				return;
			}
			if (newMode == ECustomCameraMode.Widget)
			{
				UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.DisableGlobalGITransition 1", null);
				return;
			}
			ECustomCameraMode? ecustomCameraMode = oldMode;
			ECustomCameraMode ecustomCameraMode2 = ECustomCameraMode.Widget;
			if (ecustomCameraMode.GetValueOrDefault() == ecustomCameraMode2 & ecustomCameraMode != null)
			{
				TimerSystem.Instance.Delay(delegate(float _)
				{
					UKismetSystemLibrary.ExecuteConsoleCommand(GlobalData.World, "r.Kuro.DisableGlobalGITransition 0", null);
				}, 500f, null, null, true, 1f);
			}
		}

		// Token: 0x0602288D RID: 141453 RVA: 0x009CD688 File Offset: 0x009CB888
		public void AddDependenciesNotMatchDataLayer(string path)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "DependenciesNotMatchDataLayerSet添加DataLayer";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", path);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.DependenciesNotMatchDataLayerSet.Add(path);
		}

		// Token: 0x0602288E RID: 141454 RVA: 0x009CD6C9 File Offset: 0x009CB8C9
		public bool IsDependenciesNotMatchDataLayer(string path)
		{
			return this.DependenciesNotMatchDataLayerSet.Contains(path);
		}

		// Token: 0x0602288F RID: 141455 RVA: 0x009CD6D8 File Offset: 0x009CB8D8
		public void RemoveDependenciesNotMatchDataLayer(string path)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.World;
			ELogAuthor author = ELogAuthor.ZYL;
			string message = "DependenciesNotMatchDataLayerSet移除DataLayer";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", path);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.DependenciesNotMatchDataLayerSet.Remove(path);
		}

		// Token: 0x06022890 RID: 141456 RVA: 0x009CD71C File Offset: 0x009CB91C
		public void FlushTempDependenciesNotMatchDataLayers()
		{
			foreach (string item in this.TempDependenciesNotMatchDataLayerSet)
			{
				this.DependenciesNotMatchDataLayerSet.Add(item);
			}
		}

		// Token: 0x17004864 RID: 18532
		// (get) Token: 0x06022891 RID: 141457 RVA: 0x009CD778 File Offset: 0x009CB978
		public static RenderModuleModel Instance
		{
			get
			{
				return RenderModuleModel._Instance;
			}
		}

		// Token: 0x06022892 RID: 141458 RVA: 0x009CD77F File Offset: 0x009CB97F
		public static RenderModuleModel GetOrCreateInstance()
		{
			if (RenderModuleModel._Instance == null)
			{
				RenderModuleModel.CreateInstance();
			}
			return RenderModuleModel._Instance;
		}

		// Token: 0x06022893 RID: 141459 RVA: 0x009CD793 File Offset: 0x009CB993
		public static bool CreateInstance()
		{
			if (RenderModuleModel._Instance != null)
			{
				return true;
			}
			RenderModuleModel._Instance = new RenderModuleModel();
			return true;
		}

		// Token: 0x06022894 RID: 141460 RVA: 0x009CD7A9 File Offset: 0x009CB9A9
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06022895 RID: 141461 RVA: 0x009CD7AB File Offset: 0x009CB9AB
		public static void ResetStaticDefaultValue()
		{
			RenderModuleModel._Instance = null;
		}

		// Token: 0x06022896 RID: 141462 RVA: 0x009CD7B3 File Offset: 0x009CB9B3
		static RenderModuleModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RenderModuleModel.CreateStaticDefaultValue), new Action(RenderModuleModel.ResetStaticDefaultValue));
		}

		// Token: 0x04013160 RID: 78176
		private List<IRenderModuleTickableObject> TickableObjects = new List<IRenderModuleTickableObject>();

		// Token: 0x04013161 RID: 78177
		private Dictionary<CharRenderingComponent, CharRenderShell> AllRenderShell = new Dictionary<CharRenderingComponent, CharRenderShell>();

		// Token: 0x04013162 RID: 78178
		private Dictionary<string, WuYinQuBattleActor> AllWuYinQuBattleActors = new Dictionary<string, WuYinQuBattleActor>();

		// Token: 0x04013163 RID: 78179
		[Nullable(2)]
		private string CurrentBattleKey;

		// Token: 0x04013164 RID: 78180
		private EWuYinQuState CurrentBattleState = EWuYinQuState.EWuYinQuState_MAX;

		// Token: 0x04013165 RID: 78181
		private EWuYinQuState CurrentInputBattleState = EWuYinQuState.EWuYinQuState_MAX;

		// Token: 0x04013166 RID: 78182
		private bool IsIdleClearAtmosphere;

		// Token: 0x04013167 RID: 78183
		private bool InstantTransition;

		// Token: 0x04013168 RID: 78184
		[Nullable(2)]
		private UMaterialParameterCollection MpcForGameplay;

		// Token: 0x04013169 RID: 78185
		private readonly FName mpcForGameplayNameBurstTime = new FName("BurstTime");

		// Token: 0x0401316A RID: 78186
		private readonly int UltraSkillCounterMax = 16;

		// Token: 0x0401316B RID: 78187
		private float UltraSkillCounter = -16f;

		// Token: 0x0401316C RID: 78188
		private bool IsInUltraSkill;

		// Token: 0x0401316D RID: 78189
		private int BattleRefCount;

		// Token: 0x0401316E RID: 78190
		private bool ForceTickCharRenderShellInternal;

		// Token: 0x0401316F RID: 78191
		private bool WasEffectPostProcessDisabled;

		// Token: 0x04013170 RID: 78192
		private readonly HashSet<string> TempDependenciesNotMatchDataLayerSet = new HashSet<string>();

		// Token: 0x04013171 RID: 78193
		private readonly HashSet<string> DependenciesNotMatchDataLayerSet = new HashSet<string>();

		// Token: 0x04013172 RID: 78194
		[Nullable(2)]
		private static RenderModuleModel _Instance;
	}
}
