using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x02000DDA RID: 3546
[NullableContext(1)]
[Nullable(0)]
public class GameSettingsLevelRender : Singleton
{
	// Token: 0x060054B4 RID: 21684 RVA: 0x000F06C2 File Offset: 0x000EE8C2
	protected override bool OnInit()
	{
		this.SetLevelRenderSettingsStat = Stat.Create("Render_LevelRenderSettingsManager_SetLevelRenderSettings", "", "");
		this.RevertLevelRenderSettingsStat = Stat.Create("Render_LevelRenderSettingsManager_RevertLevelRenderSettings", "", "");
		return true;
	}

	// Token: 0x060054B5 RID: 21685 RVA: 0x000F06FC File Offset: 0x000EE8FC
	public unsafe void SetLevelRenderSettings()
	{
		InstanceDungeon? instanceDungeon = GameModeModel.Instance.InstanceDungeon;
		if (((instanceDungeon != null) ? instanceDungeon.GetValueOrDefault().RenderSettings() : null) != null)
		{
			instanceDungeon = GameModeModel.Instance.InstanceDungeon;
			foreach (int key in instanceDungeon.Value.RenderSettings().Keys)
			{
				instanceDungeon = GameModeModel.Instance.InstanceDungeon;
				int num;
				string text;
				if (instanceDungeon.Value.RenderSettings().TryGetValue(key, out num) && this.LevelRenderSettingCommands.TryGetValue(key, out text))
				{
					UObject world = GlobalData.World;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted(text);
					defaultInterpolatedStringHandler.AppendLiteral(" ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(num);
					UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Render;
					ELogAuthor author = ELogAuthor.ZYT;
					string message = "进入特殊副本-调整渲染参数";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("设置", text);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("为", num);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
		}
	}

	// Token: 0x060054B6 RID: 21686 RVA: 0x000F0864 File Offset: 0x000EEA64
	public unsafe void RevertLevelRenderSetting()
	{
		InstanceDungeon? instanceDungeon = GameModeModel.Instance.InstanceDungeon;
		if (((instanceDungeon != null) ? instanceDungeon.GetValueOrDefault().RenderSettings() : null) != null)
		{
			instanceDungeon = GameModeModel.Instance.InstanceDungeon;
			foreach (int key in instanceDungeon.Value.RenderSettings().Keys)
			{
				float num;
				string text;
				if (this.LevelRenderSettingCommandsDefaultValue.TryGetValue(key, out num) && this.LevelRenderSettingCommands.TryGetValue(key, out text))
				{
					UObject world = GlobalData.World;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
					defaultInterpolatedStringHandler.AppendFormatted(text);
					defaultInterpolatedStringHandler.AppendLiteral(" ");
					defaultInterpolatedStringHandler.AppendFormatted<float>(num);
					UKismetSystemLibrary.ExecuteConsoleCommand(world, defaultInterpolatedStringHandler.ToStringAndClear(), null);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Render;
					ELogAuthor author = ELogAuthor.ZYT;
					string message = "退出特殊副本-调整渲染参数";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("设置", text);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("为", num);
					instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
			}
		}
	}

	// Token: 0x170005EB RID: 1515
	// (get) Token: 0x060054B7 RID: 21687 RVA: 0x000F09B8 File Offset: 0x000EEBB8
	public static GameSettingsLevelRender Instance
	{
		get
		{
			if (GameSettingsLevelRender._instance == null)
			{
				GameSettingsLevelRender._instance = new GameSettingsLevelRender();
				GameSettingsLevelRender._instance.OnInit();
			}
			return GameSettingsLevelRender._instance;
		}
	}

	// Token: 0x060054B8 RID: 21688 RVA: 0x000F09DB File Offset: 0x000EEBDB
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060054B9 RID: 21689 RVA: 0x000F09DD File Offset: 0x000EEBDD
	public static void ResetStaticDefaultValue()
	{
		GameSettingsLevelRender instance = GameSettingsLevelRender._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		GameSettingsLevelRender._instance = null;
	}

	// Token: 0x060054BA RID: 21690 RVA: 0x000F09F6 File Offset: 0x000EEBF6
	static GameSettingsLevelRender()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameSettingsLevelRender.CreateStaticDefaultValue), new Action(GameSettingsLevelRender.ResetStaticDefaultValue));
	}

	// Token: 0x040026A8 RID: 9896
	private readonly Dictionary<int, string> LevelRenderSettingCommands = new Dictionary<int, string>
	{
		{
			1,
			"r.Shadow.EnableCSMStable"
		},
		{
			2,
			"r.MotionBlur.OuterScale"
		},
		{
			3,
			"r.AllowHardwareOcclusion"
		},
		{
			4,
			"r.Kuro.HideLandscape"
		}
	};

	// Token: 0x040026A9 RID: 9897
	private readonly Dictionary<int, float> LevelRenderSettingCommandsDefaultValue = new Dictionary<int, float>
	{
		{
			1,
			1f
		},
		{
			2,
			1f
		},
		{
			3,
			1f
		},
		{
			4,
			0f
		}
	};

	// Token: 0x040026AA RID: 9898
	[Nullable(2)]
	public Stat SetLevelRenderSettingsStat;

	// Token: 0x040026AB RID: 9899
	[Nullable(2)]
	public Stat RevertLevelRenderSettingsStat;

	// Token: 0x040026AC RID: 9900
	[Nullable(2)]
	private static GameSettingsLevelRender _instance;
}
