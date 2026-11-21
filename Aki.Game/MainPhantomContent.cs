using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019A3 RID: 6563
[NullableContext(2)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MainPhantomContent : GridProxyAbstract<IMainPhantomItemData>
{
	// Token: 0x06010291 RID: 66193 RVA: 0x004B6224 File Offset: 0x004B4424
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

	// Token: 0x06010292 RID: 66194 RVA: 0x004B62FC File Offset: 0x004B44FC
	protected override UniTask OnBeforeStartAsync()
	{
		MainPhantomContent.<OnBeforeStartAsync>d__3 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<MainPhantomContent.<OnBeforeStartAsync>d__3>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06010293 RID: 66195 RVA: 0x004B633F File Offset: 0x004B453F
	protected override void OnStart()
	{
		base.GetItem(5).SetUIActive(false);
		base.GetItem(4).SetUIActive(true);
	}

	// Token: 0x06010294 RID: 66196 RVA: 0x004B635B File Offset: 0x004B455B
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

	// Token: 0x06010295 RID: 66197 RVA: 0x004B638C File Offset: 0x004B458C
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

	// Token: 0x04008F71 RID: 36721
	private IMainPhantomItemData CurrentData;

	// Token: 0x04008F72 RID: 36722
	private VisionMainFetterSuitItem VisionMainFetterSuitItem;
}
