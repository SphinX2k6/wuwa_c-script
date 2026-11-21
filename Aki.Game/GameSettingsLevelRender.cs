using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

// Token: 0x0200028C RID: 652
[NullableContext(1)]
[Nullable(0)]
public class GameSettingsLevelRender : Singleton
{
	// Token: 0x0600283C RID: 10300 RVA: 0x000F7487 File Offset: 0x000F5687
	protected override bool OnInit()
	{
		this.SetLevelRenderSettingsStat = Stat.Create("Render_LevelRenderSettingsManager_SetLevelRenderSettings", "", "");
		this.RevertLevelRenderSettingsStat = Stat.Create("Render_LevelRenderSettingsManager_RevertLevelRenderSettings", "", "");
		return true;
	}

	// Token: 0x0600283D RID: 10301 RVA: 0x000F74C0 File Offset: 0x000F56C0
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

	// Token: 0x0600283E RID: 10302 RVA: 0x000F7628 File Offset: 0x000F5828
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

	// Token: 0x17000611 RID: 1553
	// (get) Token: 0x0600283F RID: 10303 RVA: 0x000F777C File Offset: 0x000F597C
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

	// Token: 0x06002840 RID: 10304 RVA: 0x000F779F File Offset: 0x000F599F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06002841 RID: 10305 RVA: 0x000F77A1 File Offset: 0x000F59A1
	public static void ResetStaticDefaultValue()
	{
		GameSettingsLevelRender instance = GameSettingsLevelRender._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		GameSettingsLevelRender._instance = null;
	}

	// Token: 0x06002842 RID: 10306 RVA: 0x000F77BA File Offset: 0x000F59BA
	static GameSettingsLevelRender()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameSettingsLevelRender.CreateStaticDefaultValue), new Action(GameSettingsLevelRender.ResetStaticDefaultValue));
	}

	// Token: 0x04002733 RID: 10035
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

	// Token: 0x04002734 RID: 10036
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

	// Token: 0x04002735 RID: 10037
	[Nullable(2)]
	public Stat SetLevelRenderSettingsStat;

	// Token: 0x04002736 RID: 10038
	[Nullable(2)]
	public Stat RevertLevelRenderSettingsStat;

	// Token: 0x04002737 RID: 10039
	[Nullable(2)]
	private static GameSettingsLevelRender _instance;
}
