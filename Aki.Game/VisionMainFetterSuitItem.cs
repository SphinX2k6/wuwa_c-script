using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020024BE RID: 9406
[NullableContext(2)]
[Nullable(0)]
public class VisionMainFetterSuitItem : GridProxyAbstract<PhantomFetterGroup>
{
	// Token: 0x06012DD7 RID: 77271 RVA: 0x004A890D File Offset: 0x004A6B0D
	public VisionMainFetterSuitItem(UUIItem uiItem = null)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x06012DD8 RID: 77272 RVA: 0x004A891C File Offset: 0x004A6B1C
	public UniTask Init()
	{
		VisionMainFetterSuitItem.<Init>d__2 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<VisionMainFetterSuitItem.<Init>d__2>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06012DD9 RID: 77273 RVA: 0x004A895F File Offset: 0x004A6B5F
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x06012DDA RID: 77274 RVA: 0x004A8998 File Offset: 0x004A6B98
	public void Update(PhantomFetterGroup? fetterGroupData)
	{
		string hexStr;
		string path;
		if (fetterGroupData == null)
		{
			hexStr = PhantomBattleConfig.Instance.GetVisionFetterDefaultColor();
			path = PhantomBattleConfig.Instance.GetVisionFetterDefaultTexture();
		}
		else
		{
			hexStr = fetterGroupData.Value.FetterElementColor;
			path = fetterGroupData.Value.FetterElementPath;
		}
		FColor color = FColor.FromHex(hexStr);
		base.GetSprite(0).SetColor(color);
		base.SetTextureByPath(path, base.GetTexture(1), null, null);
		UUITexture texture = base.GetTexture(1);
		if (texture != null)
		{
			texture.SetWidth(100f);
		}
		if (texture != null)
		{
			texture.SetHeight(100f);
		}
		if (texture == null)
		{
			return;
		}
		texture.SetAnchorOffset(new FVector2D(0f, 0f));
	}

	// Token: 0x06012DDB RID: 77275 RVA: 0x004A8A55 File Offset: 0x004A6C55
	public override void Refresh(PhantomFetterGroup data, bool isSelected, int gridIndex)
	{
		this.Update(new PhantomFetterGroup?(data));
	}

	// Token: 0x04008E2C RID: 36396
	private readonly UUIItem SourceItem;
}
