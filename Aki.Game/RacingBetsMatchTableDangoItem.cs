using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C07 RID: 7175
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RacingBetsMatchTableDangoItem : GridProxyAbstract<IRacingBetsMatchTableDangoItemData>
{
	// Token: 0x06011D31 RID: 73009 RVA: 0x0053D1AC File Offset: 0x0053B3AC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06011D32 RID: 73010 RVA: 0x0053D206 File Offset: 0x0053B406
	protected override void OnBeforeShow()
	{
		this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnSequencePlayEvent));
	}

	// Token: 0x06011D33 RID: 73011 RVA: 0x0053D224 File Offset: 0x0053B424
	public override void Refresh(IRacingBetsMatchTableDangoItemData data, bool isSelected, int gridIndex)
	{
		bool flag = data.DangoId == 0;
		UUIItem item = base.GetItem(1);
		if (item != null)
		{
			item.SetUIActive(flag);
		}
		UUITexture texture = base.GetTexture(0);
		if (texture != null)
		{
			texture.SetUIActive(!flag);
		}
		if (!flag)
		{
			this.IsNeedPlayLevelSequence = data.IsNeedPlayLevelSequence;
			Dango? dangoById = DangoConfig.Instance.GetDangoById(data.DangoId);
			string path = string.Empty;
			UUITexture texture2 = base.GetTexture(0);
			if (data.IsMatchFinished && data.IsPromote)
			{
				path = dangoById.Value.IconAttack;
			}
			if (data.IsMatchFinished && !data.IsPromote)
			{
				path = dangoById.Value.IconDamage;
				if (texture2 != null)
				{
					UUIItem uuiitem = texture2;
					bool bUseChangeColor = true;
					FColor? fcolor = new FColor?(texture2.changeColor);
					uuiitem.SetChangeColor(bUseChangeColor, fcolor);
				}
			}
			if (!data.IsMatchFinished)
			{
				path = (data.IsCurMatch ? dangoById.Value.IconAttack : dangoById.Value.Icon);
			}
			base.SetTextureByPath(path, texture2, null, null);
		}
		UUIItem item2 = base.GetItem(2);
		if (item2 == null)
		{
			return;
		}
		item2.SetUIActive(data.IsNeedCheer && !flag);
	}

	// Token: 0x06011D34 RID: 73012 RVA: 0x0053D356 File Offset: 0x0053B556
	protected override void OnBeforeHide()
	{
		AUIBaseActor rootActor = this.RootActor;
		if (rootActor == null)
		{
			return;
		}
		rootActor.OnSequencePlayEvent.Unbind();
	}

	// Token: 0x06011D35 RID: 73013 RVA: 0x0053D36D File Offset: 0x0053B56D
	private void OnSequencePlayEvent(string seqName, string eventName)
	{
		if (!this.IsNeedPlayLevelSequence)
		{
			return;
		}
		if (eventName == "Loop")
		{
			this.RootActor.PlayLevelSequenceByKey("Loop");
		}
	}

	// Token: 0x04009BAD RID: 39853
	private bool IsNeedPlayLevelSequence;

	// Token: 0x02007EF8 RID: 32504
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x04029159 RID: 168281
		public const int TextureIcon = 0;

		// Token: 0x0402915A RID: 168282
		public const int ItemEmptyPanel = 1;

		// Token: 0x0402915B RID: 168283
		public const int ItemCheerPanel = 2;
	}
}
