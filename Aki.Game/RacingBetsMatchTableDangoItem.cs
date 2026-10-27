using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Dango.DangoLogic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200271C RID: 10012
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RacingBetsMatchTableDangoItem : GridProxyAbstract<IRacingBetsMatchTableDangoItemData>
{
	// Token: 0x0601484F RID: 84047 RVA: 0x0052E490 File Offset: 0x0052C690
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06014850 RID: 84048 RVA: 0x0052E4EA File Offset: 0x0052C6EA
	protected override void OnBeforeShow()
	{
		this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnSequencePlayEvent));
	}

	// Token: 0x06014851 RID: 84049 RVA: 0x0052E508 File Offset: 0x0052C708
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

	// Token: 0x06014852 RID: 84050 RVA: 0x0052E63A File Offset: 0x0052C83A
	protected override void OnBeforeHide()
	{
		AUIBaseActor rootActor = this.RootActor;
		if (rootActor == null)
		{
			return;
		}
		rootActor.OnSequencePlayEvent.Unbind();
	}

	// Token: 0x06014853 RID: 84051 RVA: 0x0052E651 File Offset: 0x0052C851
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

	// Token: 0x04009A55 RID: 39509
	private bool IsNeedPlayLevelSequence;

	// Token: 0x02008D6F RID: 36207
	[NullableContext(0)]
	private class EComponent
	{
		// Token: 0x0402DE42 RID: 187970
		public const int TextureIcon = 0;

		// Token: 0x0402DE43 RID: 187971
		public const int ItemEmptyPanel = 1;

		// Token: 0x0402DE44 RID: 187972
		public const int ItemCheerPanel = 2;
	}
}
