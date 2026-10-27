using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl.Util
{
	// Token: 0x02006850 RID: 26704
	public class DangoBrawlBattleUtil
	{
		// Token: 0x06042AAF RID: 273071 RVA: 0x01036C28 File Offset: 0x01034E28
		[NullableContext(1)]
		public static void ShowUiDamageText(int uiDamageConfigId, UUIItem targetUiItem, bool isSelf, int value, bool isCrit, bool isCure, FVector2D? offset = null)
		{
			UDamageUiManager ueDamageUiManager = DamageUiManager.Instance.UeDamageUiManager;
			if (ueDamageUiManager == null)
			{
				Log.Instance.Warn(ELogModule.DangoBrawl, ELogAuthor.LSH, "[Util.ShowUiDamageText] UeDamageUiManager 为空，跳过", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (targetUiItem == null)
			{
				Log.Instance.Warn(ELogModule.DangoBrawl, ELogAuthor.LSH, "[Util.ShowUiDamageText] targetUiItem 为空，跳过", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (!DamageUiManager.Instance.IsUeDamageConfigRegistered(uiDamageConfigId))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.DangoBrawl;
				ELogAuthor author = ELogAuthor.LSH;
				string message = "[Util.ShowUiDamageText] 飘字配置未注册进UE，跳过";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("uiDamageConfigId", uiDamageConfigId);
				instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			FDamageInfo fdamageInfo = DamageUiManager.Instance.CreateDamageInfoForLgui(value, uiDamageConfigId, DamageUiManager.Instance.ConvertUiItemToLguiPosition(targetUiItem, offset), isSelf, isCrit, isCure, "");
			ueDamageUiManager.AddDamageInfo(fdamageInfo);
		}
	}
}
