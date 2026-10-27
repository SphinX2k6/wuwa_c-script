using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.KuroSimpleCombat.PB;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Battle
{
	// Token: 0x0200637A RID: 25466
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PinballBattleRoleDetailBuffItem : GridProxyAbstract<BuffView>
	{
		// Token: 0x060400DB RID: 262363 RVA: 0x00F7FB24 File Offset: 0x00F7DD24
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
		}

		// Token: 0x060400DC RID: 262364 RVA: 0x00F7FBD0 File Offset: 0x00F7DDD0
		[NullableContext(1)]
		public override void Refresh(BuffView data, bool isSelected, int gridIndex)
		{
			PinballBuffConfig? pinballBuffConfigById = PinballConfig.Instance.GetPinballBuffConfigById(data.BuffId);
			if (pinballBuffConfigById == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Pinball;
				ELogAuthor author = ELogAuthor.CB;
				string message = "Buff配置不存在";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("buffId", data.BuffId);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(0), pinballBuffConfigById.Value.BuffName, Array.Empty<object>());
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), pinballBuffConfigById.Value.BuffDesc, pinballBuffConfigById.Value.BuffParam());
			if (data.BuffType == EPinballBuffType.Special)
			{
				base.TrySetSpriteByPath(pinballBuffConfigById.Value.BuffIcon, base.GetSprite(2), false, null, null);
			}
			else
			{
				PinballBattleSubModel pinballBattleSubModel = KuroSimpleCombatController.Instance.CurSubModel as PinballBattleSubModel;
				string path = "";
				if (pinballBattleSubModel != null)
				{
					if (pinballBattleSubModel.WorldConfigCache != null)
					{
						pinballBattleSubModel.WorldConfigCache.GetValueOrDefault().CommonBuffIconMap().TryGetValue((int)data.BuffType, out path);
					}
				}
				base.TrySetSpriteByPath(path, base.GetSprite(2), false, null, null);
			}
			UUIText text = base.GetText(3);
			if (text == null)
			{
				return;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 1);
			defaultInterpolatedStringHandler.AppendLiteral("x");
			defaultInterpolatedStringHandler.AppendFormatted<int>(data.BuffCount);
			text.SetText(defaultInterpolatedStringHandler.ToStringAndClear(), true);
		}

		// Token: 0x0200C595 RID: 50581
		private enum EPinballBattleRoleDetailBuffItemComp
		{
			// Token: 0x0403BA52 RID: 244306
			TextTitle,
			// Token: 0x0403BA53 RID: 244307
			TextDescription,
			// Token: 0x0403BA54 RID: 244308
			SpriteIcon,
			// Token: 0x0403BA55 RID: 244309
			TextCount
		}
	}
}
