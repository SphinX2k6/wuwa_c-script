using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001CB4 RID: 7348
[NullableContext(1)]
[Nullable(0)]
public class KurotatoAttrChangePanel : UiPanelBase
{
	// Token: 0x0600DE07 RID: 56839 RVA: 0x0033E460 File Offset: 0x0033C660
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0600DE08 RID: 56840 RVA: 0x0033E4BC File Offset: 0x0033C6BC
	protected override void OnStart()
	{
		this.AttrLayout = new GenericLayout<KurotatoAttrChangeItem, IKurotatoAttrChangeData>(base.GetVerticalLayout(1), () => new KurotatoAttrChangeItem(), null, false, true);
		this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
		base.GetVerticalLayout(1).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x0600DE09 RID: 56841 RVA: 0x0033E528 File Offset: 0x0033C728
	public void ShowLevelUp()
	{
		base.SetUiActive(true);
		base.GetText(0).SetUIActive(true);
		this.LevelHideTimer = 3000f;
		this.SeqPlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x0600DE0A RID: 56842 RVA: 0x0033E570 File Offset: 0x0033C770
	public void ShowAttrChange(IDictionary<int, int> propertyValues)
	{
		foreach (KeyValuePair<int, int> keyValuePair in propertyValues)
		{
			int key = keyValuePair.Key;
			int systemPropertyValue = KurotatoModel.Instance.GetSystemPropertyValue(key);
			int num = keyValuePair.Value - systemPropertyValue;
			if (num != 0)
			{
				KurotatoProperty? propertyById = KurotatoConfig.Instance.GetPropertyById(key);
				if (propertyById != null && !propertyById.Value.IsBlockFloat)
				{
					string str = (num >= 0) ? "+" : "-";
					string propertyShowValue = KurotatoUtil.GetPropertyShowValue(key, (float)Math.Abs(num));
					string str2 = ConfigMultiTextLang.GetLocalTextNew(propertyById.Value.ShowName, null) ?? propertyById.Value.ShowName;
					string str3 = KurotatoUtil.WrapAttrValueColor(str + propertyShowValue, (float)num, (float)propertyById.Value.BasicValue);
					this.AttrQueue.Add(new KurotatoAttrChangeData
					{
						Text = str2 + " " + str3,
						IconPath = propertyById.Value.Icon
					});
				}
			}
		}
		if (this.AttrQueue.Count == 0)
		{
			return;
		}
		if (this.AttrQueue.Count > 3)
		{
			this.AttrQueue.RemoveRange(0, this.AttrQueue.Count - 3);
		}
		this.AttrLayout.RefreshByData(this.AttrQueue, null, false);
		this.AttrHideTimer = 3000f;
	}

	// Token: 0x0600DE0B RID: 56843 RVA: 0x0033E714 File Offset: 0x0033C914
	public void OnTick(float dt)
	{
		if (this.LevelHideTimer > 0f)
		{
			this.LevelHideTimer -= dt;
			if (this.LevelHideTimer <= 0f)
			{
				base.GetText(0).SetUIActive(false);
			}
		}
		if (this.AttrHideTimer > 0f)
		{
			this.AttrHideTimer -= dt;
			if (this.AttrHideTimer <= 0f)
			{
				this.AttrQueue.Clear();
				base.GetVerticalLayout(1).RootUIComp.Get().SetUIActive(false);
			}
		}
		if (this.LevelHideTimer <= 0f && this.AttrHideTimer <= 0f)
		{
			base.SetUiActive(false);
		}
	}

	// Token: 0x040065CF RID: 26063
	private const int MAX_ATTR_COUNT = 3;

	// Token: 0x040065D0 RID: 26064
	private const float HIDE_DELAY = 3000f;

	// Token: 0x040065D1 RID: 26065
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<KurotatoAttrChangeItem, IKurotatoAttrChangeData> AttrLayout;

	// Token: 0x040065D2 RID: 26066
	private readonly List<IKurotatoAttrChangeData> AttrQueue = new List<IKurotatoAttrChangeData>();

	// Token: 0x040065D3 RID: 26067
	private float LevelHideTimer;

	// Token: 0x040065D4 RID: 26068
	private float AttrHideTimer;

	// Token: 0x040065D5 RID: 26069
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x0200829B RID: 33435
	[NullableContext(0)]
	private static class EComp
	{
		// Token: 0x0402A9B3 RID: 174515
		public const int TextLevelUp = 0;

		// Token: 0x0402A9B4 RID: 174516
		public const int PanelAttrList = 1;

		// Token: 0x0402A9B5 RID: 174517
		public const int ItemAttr = 2;
	}
}
