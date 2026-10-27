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
	// Token: 0x020045D9 RID: 17881
	[NullableContext(1)]
	[Nullable(0)]
	[Model(0)]
	public class RenderModuleModel : ModelBase
	{
		// Token: 0x0602E16E RID: 188782 RVA: 0x00A9FEBD File Offset: 0x00A9E0BD
		public EWuYinQuState GetCurrentKeyState(string actorKey)
		{
			if (actorKey == this.CurrentBattleKey)
			{
				return this.CurrentBattleState;
			}
			return EWuYinQuState.StateIdle;
		}

		// Token: 0x0602E16F RID: 188783 RVA: 0x00A9FED5 File Offset: 0x00A9E0D5
		public bool GetIdleClearAtmosphere(string actorKey)
		{
			return actorKey == this.CurrentBattleKey && this.IsIdleClearAtmosphere;
		}

		// Token: 0x0602E170 RID: 188784 RVA: 0x00A9FEF0 File Offset: 0x00A9E0F0
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

		// Token: 0x0602E171 RID: 188785 RVA: 0x00A9FF91 File Offset: 0x00A9E191
		public bool IsStateInstantTransition()
		{
			return this.InstantTransition;
		}

		// Token: 0x0602E172 RID: 188786 RVA: 0x00A9FF9C File Offset: 0x00A9E19C
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

		// Token: 0x0602E173 RID: 188787 RVA: 0x00A9FFF4 File Offset: 0x00A9E1F4
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

		// Token: 0x0602E174 RID: 188788 RVA: 0x00AA00AC File Offset: 0x00A9E2AC
		public EWuYinQuState GetBattleState(string key)
		{
			if (this.CurrentBattleKey == key)
			{
				return this.CurrentBattleState;
			}
			return EWuYinQuState.StateIdle;
		}

		// Token: 0x0602E175 RID: 188789 RVA: 0x00AA00C4 File Offset: 0x00A9E2C4
		[NullableContext(2)]
		public string GetCurrentBattleKey()
		{
			return this.CurrentBattleKey;
		}

		// Token: 0x0602E176 RID: 188790 RVA: 0x00AA00CC File Offset: 0x00A9E2CC
		public void AddBattleReference(FVectorDouble location)
		{
			this.BattleRefCount++;
			if (this.BattleRefCount > 0)
			{
				this.SetStreamingSourceState(location, true);
			}
		}

		// Token: 0x0602E177 RID: 188791 RVA: 0x00AA00ED File Offset: 0x00A9E2ED
		public float GetSnowIntensity()
		{
			RenderDataManager instance = RenderDataManager.Instance;
			if (instance == null)
			{
				return 0f;
			}
			return instance.GetSnowIntensity();
		}

		// Token: 0x0602E178 RID: 188792 RVA: 0x00AA0103 File Offset: 0x00A9E303
		public float GetRainIntensity()
		{
			RenderDataManager instance = RenderDataManager.Instance;
			if (instance == null)
			{
				return 0f;
			}
			return instance.GetRainIntensity();
		}

		// Token: 0x0602E179 RID: 188793 RVA: 0x00AA0119 File Offset: 0x00A9E319
		public void DecBattleReference()
		{
			this.BattleRefCount--;
			if (this.BattleRefCount <= 0)
			{
				this.SetStreamingSourceState(new FVectorDouble(0.0, 0.0, 0.0), false);
			}
		}

		// Token: 0x0602E17A RID: 188794 RVA: 0x00AA0159 File Offset: 0x00A9E359
		public void SetStreamingSourceState(FVectorDouble location, bool isEnable)
		{
		}

		// Token: 0x0602E17B RID: 188795 RVA: 0x00AA015C File Offset: 0x00A9E35C
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

		// Token: 0x0602E17C RID: 188796 RVA: 0x00AA017C File Offset: 0x00A9E37C
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

		// Token: 0x0602E17D RID: 188797 RVA: 0x00AA01EC File Offset: 0x00A9E3EC
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

		// Token: 0x0602E17E RID: 188798 RVA: 0x00AA0240 File Offset: 0x00A9E440
		public void AddTickableObject(IRenderModuleTickableObject obj)
		{
			if (this.TickableObjects.IndexOf(obj) < 0)
			{
				this.TickableObjects.Add(obj);
			}
		}

		// Token: 0x0602E17F RID: 188799 RVA: 0x00AA0260 File Offset: 0x00A9E460
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

		// Token: 0x0602E180 RID: 188800 RVA: 0x00AA02D4 File Offset: 0x00A9E4D4
		public void AddCharRenderShell(CharRenderingComponent charRenderingComponent)
		{
			CharRenderShell charRenderShell = new CharRenderShell();
			charRenderShell.Init(charRenderingComponent);
			this.AllRenderShell[charRenderingComponent] = charRenderShell;
		}

		// Token: 0x0602E181 RID: 188801 RVA: 0x00AA02FB File Offset: 0x00A9E4FB
		public bool RemoveCharRenderShell(CharRenderingComponent charRenderingComponent)
		{
			CharRenderShell valueOrDefault = this.AllRenderShell.GetValueOrDefault(charRenderingComponent);
			if (valueOrDefault != null)
			{
				valueOrDefault.Clear();
			}
			return this.AllRenderShell.Remove(charRenderingComponent);
		}

		// Token: 0x170075AB RID: 30123
		// (get) Token: 0x0602E182 RID: 188802 RVA: 0x00AA0320 File Offset: 0x00A9E520
		public bool ForceTickCharRenderShell
		{
			get
			{
				return this.ForceTickCharRenderShellInternal;
			}
		}

		// Token: 0x0602E183 RID: 188803 RVA: 0x00AA0328 File Offset: 0x00A9E528
		private void OnSetGamePaused(bool isPaused)
		{
			if (!isPaused && this.ForceTickCharRenderShellInternal)
			{
				Log.Instance.Warn(ELogModule.Render, ELogAuthor.WLJ, "退出真时停时仍然开启CharRenderShell的强制Tick", default(ReadOnlySpan<ValueTuple<string, object>>));
				this.DisableForceTickCharRenderShell("RenderModuleModel OnSetGamePaused");
			}
		}

		// Token: 0x0602E184 RID: 188804 RVA: 0x00AA0367 File Offset: 0x00A9E567
		private void OnWorldDone()
		{
			RenderDataManager instance = RenderDataManager.Instance;
			PlayerInfoModel instance2 = PlayerInfoModel.Instance;
			instance.SetIsPlayerMale(instance2 != null && instance2.GetPlayerGender() == EPlayerGender.Male);
		}

		// Token: 0x0602E185 RID: 188805 RVA: 0x00AA0387 File Offset: 0x00A9E587
		private void OnBattleStateChanged(bool inBattle)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.SetCharacterInBattle(GlobalData.World, inBattle);
		}

		// Token: 0x0602E186 RID: 188806 RVA: 0x00AA0394 File Offset: 0x00A9E594
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

		// Token: 0x0602E187 RID: 188807 RVA: 0x00AA03D0 File Offset: 0x00A9E5D0
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

		// Token: 0x0602E188 RID: 188808 RVA: 0x00AA0440 File Offset: 0x00A9E640
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

		// Token: 0x0602E189 RID: 188809 RVA: 0x00AA0998 File Offset: 0x00A9EB98
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

		// Token: 0x0602E18A RID: 188810 RVA: 0x00AA0B1C File Offset: 0x00A9ED1C
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

		// Token: 0x0602E18B RID: 188811 RVA: 0x00AA0C6C File Offset: 0x00A9EE6C
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

		// Token: 0x0602E18C RID: 188812 RVA: 0x00AA0D00 File Offset: 0x00A9EF00
		private void DoClear()
		{
			this.TickableObjects = new List<IRenderModuleTickableObject>();
			this.AllRenderShell = new Dictionary<CharRenderingComponent, CharRenderShell>();
			this.AllWuYinQuBattleActors = new Dictionary<string, WuYinQuBattleActor>();
			this.CurrentBattleKey = null;
			this.CurrentBattleState = EWuYinQuState.StateIdle;
			this.BattleRefCount = 0;
		}

		// Token: 0x0602E18D RID: 188813 RVA: 0x00AA0D38 File Offset: 0x00A9EF38
		public int EnableGlobalData(ItemMaterialControllerGlobalData globalMaterialData)
		{
			return -1;
		}

		// Token: 0x0602E18E RID: 188814 RVA: 0x00AA0D3B File Offset: 0x00A9EF3B
		public int EnableActorData([Nullable(2)] ItemMaterialControllerActorData actorMaterialData, AActor actor)
		{
			if (actor != null && actorMaterialData != null)
			{
				return ItemMaterialManager.Instance.AddMaterialData(actor, actorMaterialData);
			}
			return -1;
		}

		// Token: 0x0602E18F RID: 188815 RVA: 0x00AA0D51 File Offset: 0x00A9EF51
		public void DisableGlobal(int handle)
		{
		}

		// Token: 0x0602E190 RID: 188816 RVA: 0x00AA0D53 File Offset: 0x00A9EF53
		public void DisableAllGlobal()
		{
		}

		// Token: 0x0602E191 RID: 188817 RVA: 0x00AA0D55 File Offset: 0x00A9EF55
		public void DisableActorData(int handle)
		{
			ItemMaterialManager.Instance.DisableActorData(handle);
		}

		// Token: 0x0602E192 RID: 188818 RVA: 0x00AA0D63 File Offset: 0x00A9EF63
		public void DisableAllActorData()
		{
			ItemMaterialManager.Instance.DisableAllActorData();
		}

		// Token: 0x0602E193 RID: 188819 RVA: 0x00AA0D70 File Offset: 0x00A9EF70
		public void UpdateItemMaterialParameterCollection(ItemMaterialControllerMPCData_C data)
		{
			ItemMaterialParameterCollectionController.UpdateMaterialParameterCollection(data, RenderDataManager.Instance.GetSceneInteractionMaterialParameterCollection());
		}

		// Token: 0x0602E194 RID: 188820 RVA: 0x00AA0D82 File Offset: 0x00A9EF82
		private void OnStartTeleport(bool b)
		{
			UKuroRenderingRuntimeBPPluginBPLibrary.StopSomeWeatherBeforeTeleport(GlobalData.World);
		}

		// Token: 0x0602E195 RID: 188821 RVA: 0x00AA0D90 File Offset: 0x00A9EF90
		[NullableContext(2)]
		private void OnCompleteTeleport(TeleportContext teleportContext)
		{
			float interval = 100f;
			TimerSystem.Instance.Delay(delegate(float _)
			{
				UKuroRenderingRuntimeBPPluginBPLibrary.ResumeSomeWeatherAfterTeleport(GlobalData.World);
			}, interval, null, null, true, 1f);
		}

		// Token: 0x0602E196 RID: 188822 RVA: 0x00AA0DD8 File Offset: 0x00A9EFD8
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

		// Token: 0x0602E197 RID: 188823 RVA: 0x00AA0EA4 File Offset: 0x00A9F0A4
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

		// Token: 0x0602E198 RID: 188824 RVA: 0x00AA0F2C File Offset: 0x00A9F12C
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

		// Token: 0x0602E199 RID: 188825 RVA: 0x00AA0FAC File Offset: 0x00A9F1AC
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

		// Token: 0x0602E19A RID: 188826 RVA: 0x00AA0FED File Offset: 0x00A9F1ED
		public bool IsDependenciesNotMatchDataLayer(string path)
		{
			return this.DependenciesNotMatchDataLayerSet.Contains(path);
		}

		// Token: 0x0602E19B RID: 188827 RVA: 0x00AA0FFC File Offset: 0x00A9F1FC
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

		// Token: 0x0602E19C RID: 188828 RVA: 0x00AA1040 File Offset: 0x00A9F240
		public void FlushTempDependenciesNotMatchDataLayers()
		{
			foreach (string item in this.TempDependenciesNotMatchDataLayerSet)
			{
				this.DependenciesNotMatchDataLayerSet.Add(item);
			}
		}

		// Token: 0x170075AC RID: 30124
		// (get) Token: 0x0602E19D RID: 188829 RVA: 0x00AA109C File Offset: 0x00A9F29C
		public static RenderModuleModel Instance
		{
			get
			{
				return RenderModuleModel._Instance;
			}
		}

		// Token: 0x0602E19E RID: 188830 RVA: 0x00AA10A3 File Offset: 0x00A9F2A3
		public static RenderModuleModel GetOrCreateInstance()
		{
			if (RenderModuleModel._Instance == null)
			{
				RenderModuleModel.CreateInstance();
			}
			return RenderModuleModel._Instance;
		}

		// Token: 0x0602E19F RID: 188831 RVA: 0x00AA10B7 File Offset: 0x00A9F2B7
		public static bool CreateInstance()
		{
			if (RenderModuleModel._Instance != null)
			{
				return true;
			}
			RenderModuleModel._Instance = new RenderModuleModel();
			return true;
		}

		// Token: 0x0602E1A0 RID: 188832 RVA: 0x00AA10CD File Offset: 0x00A9F2CD
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602E1A1 RID: 188833 RVA: 0x00AA10CF File Offset: 0x00A9F2CF
		public static void ResetStaticDefaultValue()
		{
			RenderModuleModel._Instance = null;
		}

		// Token: 0x0602E1A2 RID: 188834 RVA: 0x00AA10D7 File Offset: 0x00A9F2D7
		static RenderModuleModel()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(RenderModuleModel.CreateStaticDefaultValue), new Action(RenderModuleModel.ResetStaticDefaultValue));
		}

		// Token: 0x04018B22 RID: 101154
		private List<IRenderModuleTickableObject> TickableObjects = new List<IRenderModuleTickableObject>();

		// Token: 0x04018B23 RID: 101155
		private Dictionary<CharRenderingComponent, CharRenderShell> AllRenderShell = new Dictionary<CharRenderingComponent, CharRenderShell>();

		// Token: 0x04018B24 RID: 101156
		private Dictionary<string, WuYinQuBattleActor> AllWuYinQuBattleActors = new Dictionary<string, WuYinQuBattleActor>();

		// Token: 0x04018B25 RID: 101157
		[Nullable(2)]
		private string CurrentBattleKey;

		// Token: 0x04018B26 RID: 101158
		private EWuYinQuState CurrentBattleState = EWuYinQuState.EWuYinQuState_MAX;

		// Token: 0x04018B27 RID: 101159
		private EWuYinQuState CurrentInputBattleState = EWuYinQuState.EWuYinQuState_MAX;

		// Token: 0x04018B28 RID: 101160
		private bool IsIdleClearAtmosphere;

		// Token: 0x04018B29 RID: 101161
		private bool InstantTransition;

		// Token: 0x04018B2A RID: 101162
		[Nullable(2)]
		private UMaterialParameterCollection MpcForGameplay;

		// Token: 0x04018B2B RID: 101163
		private readonly FName mpcForGameplayNameBurstTime = new FName("BurstTime");

		// Token: 0x04018B2C RID: 101164
		private readonly int UltraSkillCounterMax = 16;

		// Token: 0x04018B2D RID: 101165
		private float UltraSkillCounter = -16f;

		// Token: 0x04018B2E RID: 101166
		private bool IsInUltraSkill;

		// Token: 0x04018B2F RID: 101167
		private int BattleRefCount;

		// Token: 0x04018B30 RID: 101168
		private bool ForceTickCharRenderShellInternal;

		// Token: 0x04018B31 RID: 101169
		private bool WasEffectPostProcessDisabled;

		// Token: 0x04018B32 RID: 101170
		private readonly HashSet<string> TempDependenciesNotMatchDataLayerSet = new HashSet<string>();

		// Token: 0x04018B33 RID: 101171
		private readonly HashSet<string> DependenciesNotMatchDataLayerSet = new HashSet<string>();

		// Token: 0x04018B34 RID: 101172
		[Nullable(2)]
		private static RenderModuleModel _Instance;
	}
}
