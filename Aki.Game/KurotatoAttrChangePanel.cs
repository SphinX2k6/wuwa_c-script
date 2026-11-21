using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Kurotato;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02001176 RID: 4470
[NullableContext(1)]
[Nullable(0)]
public class KurotatoAttrChangePanel : UiPanelBase
{
	// Token: 0x0600B224 RID: 45604 RVA: 0x00349E9C File Offset: 0x0034809C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x0600B225 RID: 45605 RVA: 0x00349EF8 File Offset: 0x003480F8
	protected override void OnStart()
	{
		this.AttrLayout = new GenericLayout<KurotatoAttrChangeItem, IKurotatoAttrChangeData>(base.GetVerticalLayout(1), () => new KurotatoAttrChangeItem(), null, false, true);
		this.SeqPlayer = new LevelSequencePlayer(base.GetRootItem());
		base.GetVerticalLayout(1).RootUIComp.Get().SetUIActive(false);
	}

	// Token: 0x0600B226 RID: 45606 RVA: 0x00349F64 File Offset: 0x00348164
	public void ShowLevelUp()
	{
		base.SetUiActive(true);
		base.GetText(0).SetUIActive(true);
		this.LevelHideTimer = 3000f;
		this.SeqPlayer.PlayOrReplaySequenceByName("Start", false, null);
	}

	// Token: 0x0600B227 RID: 45607 RVA: 0x00349FAC File Offset: 0x003481AC
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

	// Token: 0x0600B228 RID: 45608 RVA: 0x0034A150 File Offset: 0x00348350
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

	// Token: 0x040066AE RID: 26286
	private const int MAX_ATTR_COUNT = 3;

	// Token: 0x040066AF RID: 26287
	private const float HIDE_DELAY = 3000f;

	// Token: 0x040066B0 RID: 26288
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<KurotatoAttrChangeItem, IKurotatoAttrChangeData> AttrLayout;

	// Token: 0x040066B1 RID: 26289
	private readonly List<IKurotatoAttrChangeData> AttrQueue = new List<IKurotatoAttrChangeData>();

	// Token: 0x040066B2 RID: 26290
	private float LevelHideTimer;

	// Token: 0x040066B3 RID: 26291
	private float AttrHideTimer;

	// Token: 0x040066B4 RID: 26292
	private LevelSequencePlayer SeqPlayer;

	// Token: 0x02007425 RID: 29733
	[NullableContext(0)]
	private static class EComp
	{
		// Token: 0x04025CDE RID: 154846
		public const int TextLevelUp = 0;

		// Token: 0x04025CDF RID: 154847
		public const int PanelAttrList = 1;

		// Token: 0x04025CE0 RID: 154848
		public const int ItemAttr = 2;
	}
}
