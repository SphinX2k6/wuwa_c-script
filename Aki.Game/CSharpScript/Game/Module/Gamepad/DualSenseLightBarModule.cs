using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using UnrealEngine;

namespace CSharpScript.Game.Module.Gamepad
{
	// Token: 0x020049CB RID: 18891
	[NullableContext(1)]
	[Nullable(0)]
	public class DualSenseLightBarModule
	{
		// Token: 0x0602F4F0 RID: 193776 RVA: 0x00D326A4 File Offset: 0x00D308A4
		public unsafe bool Set(string id)
		{
			DualSenseLightBar? config = ConfigDualSenseLightBarById.GetConfig(id, true);
			if (config == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PsGamepadFeedback;
				ELogAuthor author = ELogAuthor.CWC;
				string message = "DualSenseLightBar 配置不存在, Set 被拒";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			DualSenseLightBar value = config.Value;
			int priority = value.Priority;
			string text;
			if (this.ActiveEffects.TryGetValue(priority, out text) && text != id)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.PsGamepadFeedback;
				ELogAuthor author2 = ELogAuthor.CWC;
				string message2 = "同优先级灯效互相替换";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Old", text);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("New", id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Priority", priority);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			this.ActiveEffects[priority] = id;
			ValueTuple<int, string>? top = this.GetTop();
			if (top != null)
			{
				ValueTuple<int, string> valueOrDefault = top.GetValueOrDefault();
				if (valueOrDefault.Item2 == id)
				{
					DualSenseLightBarModule.ApplyConfig(value);
					return true;
				}
			}
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.PsGamepadFeedback;
			ELogAuthor author3 = ELogAuthor.CWC;
			string message3 = "低优先级灯效记住排队, 暂不显示";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Id", id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Priority", priority);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("CurrentTop", ((top != null) ? top.GetValueOrDefault().Item2 : null) ?? "");
			instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return true;
		}

		// Token: 0x0602F4F1 RID: 193777 RVA: 0x00D32860 File Offset: 0x00D30A60
		public unsafe bool Remove(string id)
		{
			int? num = null;
			foreach (KeyValuePair<int, string> keyValuePair in this.ActiveEffects)
			{
				if (keyValuePair.Value == id)
				{
					num = new int?(keyValuePair.Key);
					break;
				}
			}
			if (num == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PsGamepadFeedback;
				ELogAuthor author = ELogAuthor.CWC;
				string message = "移除的灯效不在栈中";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", id);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			int valueOrDefault = num.GetValueOrDefault();
			ValueTuple<int, string>? top = this.GetTop();
			bool flag;
			if (top != null)
			{
				ValueTuple<int, string> valueOrDefault2 = top.GetValueOrDefault();
				flag = (valueOrDefault2.Item2 == id);
			}
			else
			{
				flag = false;
			}
			this.ActiveEffects.Remove(valueOrDefault);
			if (!flag)
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.PsGamepadFeedback;
				ELogAuthor author2 = ELogAuthor.CWC;
				string message2 = "移除非顶层灯效, 显示不变";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Priority", valueOrDefault);
				instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return true;
			}
			ValueTuple<int, string>? top2 = this.GetTop();
			if (top2 != null)
			{
				ValueTuple<int, string> valueOrDefault3 = top2.GetValueOrDefault();
				Log instance3 = Log.Instance;
				ELogModule module3 = ELogModule.PsGamepadFeedback;
				ELogAuthor author3 = ELogAuthor.CWC;
				string message3 = "顶层灯效移除, 恢复次高优先级";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Removed", id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Restore", valueOrDefault3.Item2);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("Priority", valueOrDefault3.Item1);
				instance3.Info(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				DualSenseLightBar? config = ConfigDualSenseLightBarById.GetConfig(valueOrDefault3.Item2, true);
				if (config != null)
				{
					DualSenseLightBarModule.ApplyConfig(config.Value);
				}
				else
				{
					Log instance4 = Log.Instance;
					ELogModule module4 = ELogModule.PsGamepadFeedback;
					ELogAuthor author4 = ELogAuthor.CWC;
					string message4 = "恢复灯效时配置不存在, 清灯";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Id", valueOrDefault3.Item2);
					instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					DualSenseLightBarModule.ClearDevice();
				}
			}
			else
			{
				Log instance5 = Log.Instance;
				ELogModule module5 = ELogModule.PsGamepadFeedback;
				ELogAuthor author5 = ELogAuthor.CWC;
				string message5 = "顶层灯效移除, 栈空清灯";
				ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("Removed", id);
				instance5.Info(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
				DualSenseLightBarModule.ClearDevice();
			}
			return true;
		}

		// Token: 0x0602F4F2 RID: 193778 RVA: 0x00D32AD0 File Offset: 0x00D30CD0
		public void ClearAll(bool clearDevice = true)
		{
			this.ActiveEffects.Clear();
			if (clearDevice)
			{
				DualSenseLightBarModule.ClearDevice();
			}
		}

		// Token: 0x0602F4F3 RID: 193779 RVA: 0x00D32AE8 File Offset: 0x00D30CE8
		public string GetCurrentId()
		{
			ValueTuple<int, string>? top = this.GetTop();
			if (top != null)
			{
				ValueTuple<int, string> valueOrDefault = top.GetValueOrDefault();
				return valueOrDefault.Item2;
			}
			return "";
		}

		// Token: 0x0602F4F4 RID: 193780 RVA: 0x00D32B1C File Offset: 0x00D30D1C
		[return: TupleElementNames(new string[]
		{
			"Priority",
			"Id"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private ValueTuple<int, string>? GetTop()
		{
			ValueTuple<int, string>? result = null;
			foreach (KeyValuePair<int, string> keyValuePair in this.ActiveEffects)
			{
				result = new ValueTuple<int, string>?(new ValueTuple<int, string>(keyValuePair.Key, keyValuePair.Value));
			}
			return result;
		}

		// Token: 0x0602F4F5 RID: 193781 RVA: 0x00D32B8C File Offset: 0x00D30D8C
		private unsafe static void ApplyConfig(DualSenseLightBar cfg)
		{
			APlayerController aplayerController = DualSenseLightBarModule.ResolvePlayerController();
			if (aplayerController == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.PsGamepadFeedback;
				ELogAuthor author = ELogAuthor.CWC;
				string message = "PlayerController 无效, 灯效只记账未下发";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Id", cfg.Id);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			bool bSine = cfg.WaveType == 2;
			float onDuration = cfg.OnDuration;
			float num = (cfg.WaveType == 0) ? 0f : cfg.OffDuration;
			TArray<FColor> tarray = new TArray<FColor>();
			for (int i = 0; i < cfg.ColorsLength; i++)
			{
				Color? color = cfg.Colors(i);
				if (color != null)
				{
					Color valueOrDefault = color.GetValueOrDefault();
					tarray.Add(new FColor(DualSenseLightBarModule.<ApplyConfig>g__ToByte|6_0(valueOrDefault.R), DualSenseLightBarModule.<ApplyConfig>g__ToByte|6_0(valueOrDefault.G), DualSenseLightBarModule.<ApplyConfig>g__ToByte|6_0(valueOrDefault.B), byte.MaxValue));
				}
			}
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.PsGamepadFeedback;
			ELogAuthor author2 = ELogAuthor.CWC;
			string message2 = "应用 DualSenseLightBar 灯带效果";
			<>y__InlineArray6<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray6<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Id", cfg.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("WaveType", cfg.WaveType);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("OnSec", onDuration);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("OffSec", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("ColorNum", tarray.Num());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 5) = new ValueTuple<string, object>("Priority", cfg.Priority);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray6<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 6));
			UTriggerEffectBPLibrary.SetLightEffectColorCycle(aplayerController, tarray, bSine, onDuration, num, 1f);
		}

		// Token: 0x0602F4F6 RID: 193782 RVA: 0x00D32D64 File Offset: 0x00D30F64
		private static void ClearDevice()
		{
			APlayerController aplayerController = DualSenseLightBarModule.ResolvePlayerController();
			if (aplayerController == null)
			{
				Log.Instance.Info(ELogModule.PsGamepadFeedback, ELogAuthor.CWC, "PlayerController 无效, 停轮转但清灯包未下发", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			UTriggerEffectBPLibrary.ClearLightEffectColorCycle(aplayerController);
		}

		// Token: 0x0602F4F7 RID: 193783 RVA: 0x00D32D9D File Offset: 0x00D30F9D
		[NullableContext(2)]
		private static APlayerController ResolvePlayerController()
		{
			if (Global.CharacterController != null)
			{
				return Global.CharacterController;
			}
			if (GlobalData.World == null)
			{
				return null;
			}
			return UGameplayStatics.GetPlayerController(GlobalData.World, 0);
		}

		// Token: 0x0602F4F9 RID: 193785 RVA: 0x00D32DD3 File Offset: 0x00D30FD3
		[CompilerGenerated]
		internal static byte <ApplyConfig>g__ToByte|6_0(float v)
		{
			return (byte)Math.Clamp((int)MathF.Round(v * 255f), 0, 255);
		}

		// Token: 0x04019163 RID: 102755
		private readonly SortedDictionary<int, string> ActiveEffects = new SortedDictionary<int, string>();
	}
}
