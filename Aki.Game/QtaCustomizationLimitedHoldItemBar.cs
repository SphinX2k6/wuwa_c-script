using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.QuickTimeAction.Context;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020026C1 RID: 9921
[NullableContext(2)]
[Nullable(0)]
public class QtaCustomizationLimitedHoldItemBar : UiPanelBase
{
	// Token: 0x06014586 RID: 83334 RVA: 0x005267C0 File Offset: 0x005249C0
	protected unsafe override void OnRegisterComponent()
	{
		int num = 4;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUINiagara));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUINiagara));
		this.ComponentRegisterInfos = list;
	}

	// Token: 0x06014587 RID: 83335 RVA: 0x0052686C File Offset: 0x00524A6C
	protected override void OnStart()
	{
		base.OnStart();
		this.SetActive(true);
		this.TexBarA = base.GetTexture(0);
		this.TexBarB = base.GetTexture(1);
		this.FxBarA = base.GetUiNiagara(2);
		this.FxBarB = base.GetUiNiagara(3);
	}

	// Token: 0x06014588 RID: 83336 RVA: 0x005268BC File Offset: 0x00524ABC
	public void SetValid(bool isValid)
	{
		if (this.LastBgValue != null)
		{
			this.SetBgParam(this.LastBgValue);
		}
		if (this.LastBgPercent != null && this.LastBgPercent.Value != 0f)
		{
			this.SetBgPercent(this.LastBgPercent.Value);
		}
	}

	// Token: 0x06014589 RID: 83337 RVA: 0x00526910 File Offset: 0x00524B10
	[NullableContext(1)]
	public void SetBgParam(QtaCzBgBarValue bgValue)
	{
		this.LastBgValue = bgValue;
		this.TmpRotation.Yaw = bgValue.Angle;
		if (this.IsTexMode)
		{
			this.TexBarA.SetUIRelativeRotation(this.TmpRotation);
			this.TexBarA.SetCustomMaterialVectorParameter(this.P1Name, bgValue.Anchor ?? this.TmpAnchor);
			this.TexBarA.SetCustomMaterialScalarParameter(this.P2Name, bgValue.Progress);
			this.TexBarB.SetUIRelativeRotation(this.TmpRotation);
			this.TexBarB.SetCustomMaterialVectorParameter(this.P1Name, bgValue.Anchor ?? this.TmpAnchor);
			this.TexBarB.SetCustomMaterialScalarParameter(this.P2Name, bgValue.Progress);
			return;
		}
		this.FxBarA.SetUIRelativeRotation(this.TmpRotation);
		this.FxBarB.SetUIRelativeRotation(this.TmpRotation);
	}

	// Token: 0x0601458A RID: 83338 RVA: 0x00526A14 File Offset: 0x00524C14
	public void SetBgPercent(float p)
	{
		this.LastBgPercent = new float?(p);
		if (this.IsTexMode)
		{
			this.TexBarA.SetCustomMaterialScalarParameter(this.P2Name, p);
			this.TexBarB.SetCustomMaterialScalarParameter(this.P2Name, p);
			return;
		}
		this.FxBarA.SetNiagaraVarFloat("Dissolve", p);
		this.FxBarA.ActivateSystem(true);
		this.FxBarB.SetNiagaraVarFloat("Dissolve", p);
		this.FxBarB.ActivateSystem(true);
	}

	// Token: 0x040098F1 RID: 39153
	private UUITexture TexBarA;

	// Token: 0x040098F2 RID: 39154
	private UUITexture TexBarB;

	// Token: 0x040098F3 RID: 39155
	private UUINiagara FxBarA;

	// Token: 0x040098F4 RID: 39156
	private UUINiagara FxBarB;

	// Token: 0x040098F5 RID: 39157
	private bool IsTexMode;

	// Token: 0x040098F6 RID: 39158
	private readonly FName P1Name = new FName("Anchor");

	// Token: 0x040098F7 RID: 39159
	private readonly FName P2Name = new FName("Progress");

	// Token: 0x040098F8 RID: 39160
	private FRotator TmpRotation = new FRotator();

	// Token: 0x040098F9 RID: 39161
	private FLinearColor TmpAnchor = new FLinearColor(0f, 0.25f, 0.5f, 0.75f);

	// Token: 0x040098FA RID: 39162
	private QtaCzBgBarValue LastBgValue;

	// Token: 0x040098FB RID: 39163
	private float? LastBgPercent;

	// Token: 0x02008D28 RID: 36136
	[NullableContext(0)]
	private class EChildType
	{
		// Token: 0x0402DD1F RID: 187679
		public const int TexBarA = 0;

		// Token: 0x0402DD20 RID: 187680
		public const int TexBarB = 1;

		// Token: 0x0402DD21 RID: 187681
		public const int FxBarA = 2;

		// Token: 0x0402DD22 RID: 187682
		public const int FxBarB = 3;
	}
}
