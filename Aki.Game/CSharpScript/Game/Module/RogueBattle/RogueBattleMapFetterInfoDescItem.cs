using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004E66 RID: 20070
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RogueBattleMapFetterInfoDescItem : GridProxyAbstract<IRogueBattleMapFetterDescInfo>
	{
		// Token: 0x06033AF5 RID: 211701 RVA: 0x00C1A377 File Offset: 0x00C18577
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUITexture)),
				new ValueTuple<int, Type>(1, typeof(UUIText))
			};
		}

		// Token: 0x06033AF6 RID: 211702 RVA: 0x00C1A3B0 File Offset: 0x00C185B0
		public override void Refresh(IRogueBattleMapFetterDescInfo data, bool isSelected, int gridIndex)
		{
			if (data.Param != null)
			{
				string[] args = data.Param.Split('#', StringSplitOptions.None);
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TextId, args);
			}
			else
			{
				LguiUtil.Instance.SetLocalTextNew(base.GetText(1), data.TextId, Array.Empty<object>());
			}
			string resourceId = RogueBattleDefine.FetterTypeIconMap[data.EffectType];
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resourceId);
			base.SetTextureByPath(resourcePath, base.GetTexture(0), null, delegate(bool _)
			{
				this.GetTexture(0).SetColor(FColor.FromHex(this.IconColor[data.IsReached]));
			});
			base.GetText(1).SetColor(FColor.FromHex(this.DescColor[data.IsReached]));
		}

		// Token: 0x0401B6B8 RID: 112312
		public readonly Dictionary<bool, string> IconColor = new Dictionary<bool, string>
		{
			{
				true,
				"#FDF6C6"
			},
			{
				false,
				"#C4C4C4"
			}
		};

		// Token: 0x0401B6B9 RID: 112313
		public readonly Dictionary<bool, string> DescColor = new Dictionary<bool, string>
		{
			{
				true,
				"#ECE5D8"
			},
			{
				false,
				"#ADADAD"
			}
		};
	}
}
