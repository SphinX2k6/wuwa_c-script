using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020024BC RID: 9404
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MainPhantomContent : GridProxyAbstract<IMainPhantomItemData>
{
	// Token: 0x06012DD1 RID: 77265 RVA: 0x004A8670 File Offset: 0x004A6870
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIText)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickTogOption))
		};
	}

	// Token: 0x06012DD2 RID: 77266 RVA: 0x004A8748 File Offset: 0x004A6948
	protected override UniTask OnBeforeStartAsync()
	{
		MainPhantomContent.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MainPhantomContent.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06012DD3 RID: 77267 RVA: 0x004A878B File Offset: 0x004A698B
	protected override void OnStart()
	{
		base.GetItem(5).SetUIActive(false);
		base.GetItem(4).SetUIActive(true);
	}

	// Token: 0x06012DD4 RID: 77268 RVA: 0x004A87A7 File Offset: 0x004A69A7
	private void OnClickTogOption(EToggleState toggleState)
	{
		if (this.CurrentData == null)
		{
			return;
		}
		if (this.CurrentData.OnMainPhantomCallBack != null)
		{
			this.CurrentData.OnMainPhantomCallBack(this.CurrentData);
		}
	}

	// Token: 0x06012DD5 RID: 77269 RVA: 0x004A87D8 File Offset: 0x004A69D8
	[NullableContext(1)]
	public override void Refresh(IMainPhantomItemData data, bool isSelected, int gridIndex)
	{
		this.CurrentData = data;
		CalabashDevelopReward? calabashDevelopRewardByMonsterId = CalabashConfig.Instance.GetCalabashDevelopRewardByMonsterId(data.Info.GetMonsterId());
		MonsterInfo? monsterInfoConfig = MonsterInfoConfig.Instance.GetMonsterInfoConfig(calabashDevelopRewardByMonsterId.Value.MonsterInfoId);
		if (monsterInfoConfig != null)
		{
			base.SetTextureByPath(monsterInfoConfig.Value.Icon, base.GetTexture(1), null, null);
			string name = monsterInfoConfig.Value.Name;
			base.GetText(2).ShowTextNew(name);
		}
		PhantomFetterGroup fetterGroupById = PhantomBattleConfig.Instance.GetFetterGroupById(data.Info.GetFetterGroupId());
		VisionMainFetterSuitItem visionMainFetterSuitItem = this.VisionMainFetterSuitItem;
		if (visionMainFetterSuitItem != null)
		{
			visionMainFetterSuitItem.Refresh(fetterGroupById, false, 0);
		}
		UUIText text = base.GetText(3);
		if (text != null)
		{
			text.SetText(data.Info.GetUsageText(), true);
		}
		bool flag = false;
		VisionMainSelectPhantomData currentSelectMainPhantom = data.CurrentSelectMainPhantom;
		if (currentSelectMainPhantom != null && currentSelectMainPhantom.MonsterId == data.Info.GetMonsterId() && currentSelectMainPhantom.FetterGroupId == data.Info.GetFetterGroupId())
		{
			flag = true;
		}
		base.GetExtendToggle(0).SetToggleState(flag ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x04008E27 RID: 36391
	private IMainPhantomItemData CurrentData;

	// Token: 0x04008E28 RID: 36392
	private VisionMainFetterSuitItem VisionMainFetterSuitItem;
}
