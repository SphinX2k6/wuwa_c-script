using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020019A5 RID: 6565
[NullableContext(2)]
[Nullable(0)]
public class VisionMainFetterSuitItem : GridProxyAbstract<PhantomFetterGroup>
{
	// Token: 0x06010297 RID: 66199 RVA: 0x004B64C1 File Offset: 0x004B46C1
	public VisionMainFetterSuitItem(UUIItem uiItem = null)
	{
		this.SourceItem = uiItem;
	}

	// Token: 0x06010298 RID: 66200 RVA: 0x004B64D0 File Offset: 0x004B46D0
	public UniTask Init()
	{
		VisionMainFetterSuitItem.<Init>d__2 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<VisionMainFetterSuitItem.<Init>d__2>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x06010299 RID: 66201 RVA: 0x004B6513 File Offset: 0x004B4713
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
	}

	// Token: 0x0601029A RID: 66202 RVA: 0x004B654C File Offset: 0x004B474C
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

	// Token: 0x0601029B RID: 66203 RVA: 0x004B6609 File Offset: 0x004B4809
	public override void Refresh(PhantomFetterGroup data, bool isSelected, int gridIndex)
	{
		this.Update(new PhantomFetterGroup?(data));
	}

	// Token: 0x04008F76 RID: 36726
	private readonly UUIItem SourceItem;
}
