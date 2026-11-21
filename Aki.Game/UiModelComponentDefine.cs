using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020021C1 RID: 8641
[NullableContext(1)]
[Nullable(0)]
public class UiModelComponentDefine : IStaticVariableResetter
{
	// Token: 0x0601548E RID: 87182 RVA: 0x0062F94C File Offset: 0x0062DB4C
	static UiModelComponentDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiModelComponentDefine.CreateStaticDefaultValue), new Action(UiModelComponentDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0601548F RID: 87183 RVA: 0x0062F96B File Offset: 0x0062DB6B
	private static T HandlerImp<[Nullable(0)] T>(UiModelBase model) where T : UiModelComponentBase, new()
	{
		T t = Activator.CreateInstance<T>();
		t.Create(model);
		return t;
	}

	// Token: 0x1700202D RID: 8237
	// (get) Token: 0x06015490 RID: 87184 RVA: 0x0062F97E File Offset: 0x0062DB7E
	public static Dictionary<Type, UiModelComponentHandler> Handlers
	{
		get
		{
			return UiModelComponentDefine._handlers;
		}
	}

	// Token: 0x06015491 RID: 87185 RVA: 0x0062F988 File Offset: 0x0062DB88
	public static void CreateStaticDefaultValue()
	{
		Dictionary<Type, UiModelComponentHandler> dictionary = new Dictionary<Type, UiModelComponentHandler>();
		Type typeFromHandle = typeof(UiModelDataComponent);
		UiModelComponentHandler value;
		if ((value = UiModelComponentDefine.<>O.<0>__HandlerImp) == null)
		{
			value = (UiModelComponentDefine.<>O.<0>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiModelDataComponent>));
		}
		dictionary.Add(typeFromHandle, value);
		Type typeFromHandle2 = typeof(UiModelActorComponent);
		UiModelComponentHandler value2;
		if ((value2 = UiModelComponentDefine.<>O.<1>__HandlerImp) == null)
		{
			value2 = (UiModelComponentDefine.<>O.<1>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiModelActorComponent>));
		}
		dictionary.Add(typeFromHandle2, value2);
		Type typeFromHandle3 = typeof(UiModelLoadComponent);
		UiModelComponentHandler value3;
		if ((value3 = UiModelComponentDefine.<>O.<2>__HandlerImp) == null)
		{
			value3 = (UiModelComponentDefine.<>O.<2>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiModelLoadComponent>));
		}
		dictionary.Add(typeFromHandle3, value3);
		Type typeFromHandle4 = typeof(UiModelLoadingIconComponent);
		UiModelComponentHandler value4;
		if ((value4 = UiModelComponentDefine.<>O.<3>__HandlerImp) == null)
		{
			value4 = (UiModelComponentDefine.<>O.<3>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiModelLoadingIconComponent>));
		}
		dictionary.Add(typeFromHandle4, value4);
		Type typeFromHandle5 = typeof(UiModelEffectComponent);
		UiModelComponentHandler value5;
		if ((value5 = UiModelComponentDefine.<>O.<4>__HandlerImp) == null)
		{
			value5 = (UiModelComponentDefine.<>O.<4>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiModelEffectComponent>));
		}
		dictionary.Add(typeFromHandle5, value5);
		Type typeFromHandle6 = typeof(UiModelRenderingMaterialComponent);
		UiModelComponentHandler value6;
		if ((value6 = UiModelComponentDefine.<>O.<5>__HandlerImp) == null)
		{
			value6 = (UiModelComponentDefine.<>O.<5>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiModelRenderingMaterialComponent>));
		}
		dictionary.Add(typeFromHandle6, value6);
		Type typeFromHandle7 = typeof(UiModelAnsControllerComponent);
		UiModelComponentHandler value7;
		if ((value7 = UiModelComponentDefine.<>O.<6>__HandlerImp) == null)
		{
			value7 = (UiModelComponentDefine.<>O.<6>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiModelAnsControllerComponent>));
		}
		dictionary.Add(typeFromHandle7, value7);
		Type typeFromHandle8 = typeof(UiModelTagComponent);
		UiModelComponentHandler value8;
		if ((value8 = UiModelComponentDefine.<>O.<7>__HandlerImp) == null)
		{
			value8 = (UiModelComponentDefine.<>O.<7>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiModelTagComponent>));
		}
		dictionary.Add(typeFromHandle8, value8);
		Type typeFromHandle9 = typeof(UiModelFadeComponent);
		UiModelComponentHandler value9;
		if ((value9 = UiModelComponentDefine.<>O.<8>__HandlerImp) == null)
		{
			value9 = (UiModelComponentDefine.<>O.<8>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiModelFadeComponent>));
		}
		dictionary.Add(typeFromHandle9, value9);
		Type typeFromHandle10 = typeof(UiModelRotateComponent);
		UiModelComponentHandler value10;
		if ((value10 = UiModelComponentDefine.<>O.<9>__HandlerImp) == null)
		{
			value10 = (UiModelComponentDefine.<>O.<9>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiModelRotateComponent>));
		}
		dictionary.Add(typeFromHandle10, value10);
		Type typeFromHandle11 = typeof(UiModelInputDataComponent);
		UiModelComponentHandler value11;
		if ((value11 = UiModelComponentDefine.<>O.<10>__HandlerImp) == null)
		{
			value11 = (UiModelComponentDefine.<>O.<10>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiModelInputDataComponent>));
		}
		dictionary.Add(typeFromHandle11, value11);
		Type typeFromHandle12 = typeof(UiModelControlRotateComponent);
		UiModelComponentHandler value12;
		if ((value12 = UiModelComponentDefine.<>O.<11>__HandlerImp) == null)
		{
			value12 = (UiModelComponentDefine.<>O.<11>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiModelControlRotateComponent>));
		}
		dictionary.Add(typeFromHandle12, value12);
		Type typeFromHandle13 = typeof(UiModelAnimationComponent);
		UiModelComponentHandler value13;
		if ((value13 = UiModelComponentDefine.<>O.<12>__HandlerImp) == null)
		{
			value13 = (UiModelComponentDefine.<>O.<12>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiModelAnimationComponent>));
		}
		dictionary.Add(typeFromHandle13, value13);
		Type typeFromHandle14 = typeof(UiModelBuffComponent);
		UiModelComponentHandler value14;
		if ((value14 = UiModelComponentDefine.<>O.<13>__HandlerImp) == null)
		{
			value14 = (UiModelComponentDefine.<>O.<13>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiModelBuffComponent>));
		}
		dictionary.Add(typeFromHandle14, value14);
		Type typeFromHandle15 = typeof(UiModelMorphComponent);
		UiModelComponentHandler value15;
		if ((value15 = UiModelComponentDefine.<>O.<14>__HandlerImp) == null)
		{
			value15 = (UiModelComponentDefine.<>O.<14>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiModelMorphComponent>));
		}
		dictionary.Add(typeFromHandle15, value15);
		Type typeFromHandle16 = typeof(UiRoleDataComponent);
		UiModelComponentHandler value16;
		if ((value16 = UiModelComponentDefine.<>O.<15>__HandlerImp) == null)
		{
			value16 = (UiModelComponentDefine.<>O.<15>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiRoleDataComponent>));
		}
		dictionary.Add(typeFromHandle16, value16);
		Type typeFromHandle17 = typeof(UiFormationRoleDataComponent);
		UiModelComponentHandler value17;
		if ((value17 = UiModelComponentDefine.<>O.<16>__HandlerImp) == null)
		{
			value17 = (UiModelComponentDefine.<>O.<16>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiFormationRoleDataComponent>));
		}
		dictionary.Add(typeFromHandle17, value17);
		Type typeFromHandle18 = typeof(UiRoleLoadComponent);
		UiModelComponentHandler value18;
		if ((value18 = UiModelComponentDefine.<>O.<17>__HandlerImp) == null)
		{
			value18 = (UiModelComponentDefine.<>O.<17>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiRoleLoadComponent>));
		}
		dictionary.Add(typeFromHandle18, value18);
		Type typeFromHandle19 = typeof(UiFormationRoleLoadComponent);
		UiModelComponentHandler value19;
		if ((value19 = UiModelComponentDefine.<>O.<18>__HandlerImp) == null)
		{
			value19 = (UiModelComponentDefine.<>O.<18>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiFormationRoleLoadComponent>));
		}
		dictionary.Add(typeFromHandle19, value19);
		Type typeFromHandle20 = typeof(UiRoleMorphComponent);
		UiModelComponentHandler value20;
		if ((value20 = UiModelComponentDefine.<>O.<19>__HandlerImp) == null)
		{
			value20 = (UiModelComponentDefine.<>O.<19>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiRoleMorphComponent>));
		}
		dictionary.Add(typeFromHandle20, value20);
		Type typeFromHandle21 = typeof(UiRoleStateMachineComponent);
		UiModelComponentHandler value21;
		if ((value21 = UiModelComponentDefine.<>O.<20>__HandlerImp) == null)
		{
			value21 = (UiModelComponentDefine.<>O.<20>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiRoleStateMachineComponent>));
		}
		dictionary.Add(typeFromHandle21, value21);
		Type typeFromHandle22 = typeof(UiRoleWeaponComponent);
		UiModelComponentHandler value22;
		if ((value22 = UiModelComponentDefine.<>O.<21>__HandlerImp) == null)
		{
			value22 = (UiModelComponentDefine.<>O.<21>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiRoleWeaponComponent>));
		}
		dictionary.Add(typeFromHandle22, value22);
		Type typeFromHandle23 = typeof(UiRoleHuluComponent);
		UiModelComponentHandler value23;
		if ((value23 = UiModelComponentDefine.<>O.<22>__HandlerImp) == null)
		{
			value23 = (UiModelComponentDefine.<>O.<22>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiRoleHuluComponent>));
		}
		dictionary.Add(typeFromHandle23, value23);
		Type typeFromHandle24 = typeof(UiRoleEyeHighLightComponent);
		UiModelComponentHandler value24;
		if ((value24 = UiModelComponentDefine.<>O.<23>__HandlerImp) == null)
		{
			value24 = (UiModelComponentDefine.<>O.<23>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiRoleEyeHighLightComponent>));
		}
		dictionary.Add(typeFromHandle24, value24);
		Type typeFromHandle25 = typeof(UiRoleHuluLightSequenceComponent);
		UiModelComponentHandler value25;
		if ((value25 = UiModelComponentDefine.<>O.<24>__HandlerImp) == null)
		{
			value25 = (UiModelComponentDefine.<>O.<24>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiRoleHuluLightSequenceComponent>));
		}
		dictionary.Add(typeFromHandle25, value25);
		Type typeFromHandle26 = typeof(UiRoleBuffComponent);
		UiModelComponentHandler value26;
		if ((value26 = UiModelComponentDefine.<>O.<25>__HandlerImp) == null)
		{
			value26 = (UiModelComponentDefine.<>O.<25>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiRoleBuffComponent>));
		}
		dictionary.Add(typeFromHandle26, value26);
		Type typeFromHandle27 = typeof(UiWeaponDataComponent);
		UiModelComponentHandler value27;
		if ((value27 = UiModelComponentDefine.<>O.<26>__HandlerImp) == null)
		{
			value27 = (UiModelComponentDefine.<>O.<26>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiWeaponDataComponent>));
		}
		dictionary.Add(typeFromHandle27, value27);
		Type typeFromHandle28 = typeof(UiWeaponLevelMaterialComponent);
		UiModelComponentHandler value28;
		if ((value28 = UiModelComponentDefine.<>O.<27>__HandlerImp) == null)
		{
			value28 = (UiModelComponentDefine.<>O.<27>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiWeaponLevelMaterialComponent>));
		}
		dictionary.Add(typeFromHandle28, value28);
		Type typeFromHandle29 = typeof(UiDangoLoadComponent);
		UiModelComponentHandler value29;
		if ((value29 = UiModelComponentDefine.<>O.<28>__HandlerImp) == null)
		{
			value29 = (UiModelComponentDefine.<>O.<28>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiDangoLoadComponent>));
		}
		dictionary.Add(typeFromHandle29, value29);
		Type typeFromHandle30 = typeof(UiDangoDataComponent);
		UiModelComponentHandler value30;
		if ((value30 = UiModelComponentDefine.<>O.<29>__HandlerImp) == null)
		{
			value30 = (UiModelComponentDefine.<>O.<29>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiDangoDataComponent>));
		}
		dictionary.Add(typeFromHandle30, value30);
		Type typeFromHandle31 = typeof(UiDangoOddsComponent);
		UiModelComponentHandler value31;
		if ((value31 = UiModelComponentDefine.<>O.<30>__HandlerImp) == null)
		{
			value31 = (UiModelComponentDefine.<>O.<30>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiDangoOddsComponent>));
		}
		dictionary.Add(typeFromHandle31, value31);
		Type typeFromHandle32 = typeof(UiDangoStateMachineComponent);
		UiModelComponentHandler value32;
		if ((value32 = UiModelComponentDefine.<>O.<31>__HandlerImp) == null)
		{
			value32 = (UiModelComponentDefine.<>O.<31>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiDangoStateMachineComponent>));
		}
		dictionary.Add(typeFromHandle32, value32);
		Type typeFromHandle33 = typeof(UiAbyssDangoLoadComponent);
		UiModelComponentHandler value33;
		if ((value33 = UiModelComponentDefine.<>O.<32>__HandlerImp) == null)
		{
			value33 = (UiModelComponentDefine.<>O.<32>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiAbyssDangoLoadComponent>));
		}
		dictionary.Add(typeFromHandle33, value33);
		Type typeFromHandle34 = typeof(UiDangoCollisionComponent);
		UiModelComponentHandler value34;
		if ((value34 = UiModelComponentDefine.<>O.<33>__HandlerImp) == null)
		{
			value34 = (UiModelComponentDefine.<>O.<33>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiDangoCollisionComponent>));
		}
		dictionary.Add(typeFromHandle34, value34);
		Type typeFromHandle35 = typeof(UiDangoMaterialChangeComponent);
		UiModelComponentHandler value35;
		if ((value35 = UiModelComponentDefine.<>O.<34>__HandlerImp) == null)
		{
			value35 = (UiModelComponentDefine.<>O.<34>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiDangoMaterialChangeComponent>));
		}
		dictionary.Add(typeFromHandle35, value35);
		Type typeFromHandle36 = typeof(UiHuluSkinDataComponent);
		UiModelComponentHandler value36;
		if ((value36 = UiModelComponentDefine.<>O.<35>__HandlerImp) == null)
		{
			value36 = (UiModelComponentDefine.<>O.<35>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiHuluSkinDataComponent>));
		}
		dictionary.Add(typeFromHandle36, value36);
		Type typeFromHandle37 = typeof(UiMotorDataComponent);
		UiModelComponentHandler value37;
		if ((value37 = UiModelComponentDefine.<>O.<36>__HandlerImp) == null)
		{
			value37 = (UiModelComponentDefine.<>O.<36>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiMotorDataComponent>));
		}
		dictionary.Add(typeFromHandle37, value37);
		Type typeFromHandle38 = typeof(UiMotorLoadComponent);
		UiModelComponentHandler value38;
		if ((value38 = UiModelComponentDefine.<>O.<37>__HandlerImp) == null)
		{
			value38 = (UiModelComponentDefine.<>O.<37>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiMotorLoadComponent>));
		}
		dictionary.Add(typeFromHandle38, value38);
		Type typeFromHandle39 = typeof(UiMotorRoleComponent);
		UiModelComponentHandler value39;
		if ((value39 = UiModelComponentDefine.<>O.<38>__HandlerImp) == null)
		{
			value39 = (UiModelComponentDefine.<>O.<38>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiMotorRoleComponent>));
		}
		dictionary.Add(typeFromHandle39, value39);
		Type typeFromHandle40 = typeof(UiRoleBuffPreviewComponent);
		UiModelComponentHandler value40;
		if ((value40 = UiModelComponentDefine.<>O.<39>__HandlerImp) == null)
		{
			value40 = (UiModelComponentDefine.<>O.<39>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiRoleBuffPreviewComponent>));
		}
		dictionary.Add(typeFromHandle40, value40);
		Type typeFromHandle41 = typeof(UiMotorStickerComponent);
		UiModelComponentHandler value41;
		if ((value41 = UiModelComponentDefine.<>O.<40>__HandlerImp) == null)
		{
			value41 = (UiModelComponentDefine.<>O.<40>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiMotorStickerComponent>));
		}
		dictionary.Add(typeFromHandle41, value41);
		Type typeFromHandle42 = typeof(UiMotorDecorationComponent);
		UiModelComponentHandler value42;
		if ((value42 = UiModelComponentDefine.<>O.<41>__HandlerImp) == null)
		{
			value42 = (UiModelComponentDefine.<>O.<41>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiMotorDecorationComponent>));
		}
		dictionary.Add(typeFromHandle42, value42);
		Type typeFromHandle43 = typeof(UiMotorSoarWingComponent);
		UiModelComponentHandler value43;
		if ((value43 = UiModelComponentDefine.<>O.<42>__HandlerImp) == null)
		{
			value43 = (UiModelComponentDefine.<>O.<42>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiMotorSoarWingComponent>));
		}
		dictionary.Add(typeFromHandle43, value43);
		Type typeFromHandle44 = typeof(UiDecorationLoadComponent);
		UiModelComponentHandler value44;
		if ((value44 = UiModelComponentDefine.<>O.<43>__HandlerImp) == null)
		{
			value44 = (UiModelComponentDefine.<>O.<43>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiDecorationLoadComponent>));
		}
		dictionary.Add(typeFromHandle44, value44);
		Type typeFromHandle45 = typeof(UiRoleOrnamentComponent);
		UiModelComponentHandler value45;
		if ((value45 = UiModelComponentDefine.<>O.<44>__HandlerImp) == null)
		{
			value45 = (UiModelComponentDefine.<>O.<44>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiRoleOrnamentComponent>));
		}
		dictionary.Add(typeFromHandle45, value45);
		Type typeFromHandle46 = typeof(UiRoleSpecialCaseComponent);
		UiModelComponentHandler value46;
		if ((value46 = UiModelComponentDefine.<>O.<45>__HandlerImp) == null)
		{
			value46 = (UiModelComponentDefine.<>O.<45>__HandlerImp = new UiModelComponentHandler(UiModelComponentDefine.HandlerImp<UiRoleSpecialCaseComponent>));
		}
		dictionary.Add(typeFromHandle46, value46);
		UiModelComponentDefine._handlers = dictionary;
	}

	// Token: 0x06015492 RID: 87186 RVA: 0x00630159 File Offset: 0x0062E359
	public static void ResetStaticDefaultValue()
	{
		UiModelComponentDefine._handlers = null;
	}

	// Token: 0x0400B44E RID: 46158
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<Type, UiModelComponentHandler> _handlers;

	// Token: 0x02008474 RID: 33908
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402AB90 RID: 174992
		[Nullable(0)]
		public static UiModelComponentHandler <0>__HandlerImp;

		// Token: 0x0402AB91 RID: 174993
		[Nullable(0)]
		public static UiModelComponentHandler <1>__HandlerImp;

		// Token: 0x0402AB92 RID: 174994
		[Nullable(0)]
		public static UiModelComponentHandler <2>__HandlerImp;

		// Token: 0x0402AB93 RID: 174995
		[Nullable(0)]
		public static UiModelComponentHandler <3>__HandlerImp;

		// Token: 0x0402AB94 RID: 174996
		[Nullable(0)]
		public static UiModelComponentHandler <4>__HandlerImp;

		// Token: 0x0402AB95 RID: 174997
		[Nullable(0)]
		public static UiModelComponentHandler <5>__HandlerImp;

		// Token: 0x0402AB96 RID: 174998
		[Nullable(0)]
		public static UiModelComponentHandler <6>__HandlerImp;

		// Token: 0x0402AB97 RID: 174999
		[Nullable(0)]
		public static UiModelComponentHandler <7>__HandlerImp;

		// Token: 0x0402AB98 RID: 175000
		[Nullable(0)]
		public static UiModelComponentHandler <8>__HandlerImp;

		// Token: 0x0402AB99 RID: 175001
		[Nullable(0)]
		public static UiModelComponentHandler <9>__HandlerImp;

		// Token: 0x0402AB9A RID: 175002
		[Nullable(0)]
		public static UiModelComponentHandler <10>__HandlerImp;

		// Token: 0x0402AB9B RID: 175003
		[Nullable(0)]
		public static UiModelComponentHandler <11>__HandlerImp;

		// Token: 0x0402AB9C RID: 175004
		[Nullable(0)]
		public static UiModelComponentHandler <12>__HandlerImp;

		// Token: 0x0402AB9D RID: 175005
		[Nullable(0)]
		public static UiModelComponentHandler <13>__HandlerImp;

		// Token: 0x0402AB9E RID: 175006
		[Nullable(0)]
		public static UiModelComponentHandler <14>__HandlerImp;

		// Token: 0x0402AB9F RID: 175007
		[Nullable(0)]
		public static UiModelComponentHandler <15>__HandlerImp;

		// Token: 0x0402ABA0 RID: 175008
		[Nullable(0)]
		public static UiModelComponentHandler <16>__HandlerImp;

		// Token: 0x0402ABA1 RID: 175009
		[Nullable(0)]
		public static UiModelComponentHandler <17>__HandlerImp;

		// Token: 0x0402ABA2 RID: 175010
		[Nullable(0)]
		public static UiModelComponentHandler <18>__HandlerImp;

		// Token: 0x0402ABA3 RID: 175011
		[Nullable(0)]
		public static UiModelComponentHandler <19>__HandlerImp;

		// Token: 0x0402ABA4 RID: 175012
		[Nullable(0)]
		public static UiModelComponentHandler <20>__HandlerImp;

		// Token: 0x0402ABA5 RID: 175013
		[Nullable(0)]
		public static UiModelComponentHandler <21>__HandlerImp;

		// Token: 0x0402ABA6 RID: 175014
		[Nullable(0)]
		public static UiModelComponentHandler <22>__HandlerImp;

		// Token: 0x0402ABA7 RID: 175015
		[Nullable(0)]
		public static UiModelComponentHandler <23>__HandlerImp;

		// Token: 0x0402ABA8 RID: 175016
		[Nullable(0)]
		public static UiModelComponentHandler <24>__HandlerImp;

		// Token: 0x0402ABA9 RID: 175017
		[Nullable(0)]
		public static UiModelComponentHandler <25>__HandlerImp;

		// Token: 0x0402ABAA RID: 175018
		[Nullable(0)]
		public static UiModelComponentHandler <26>__HandlerImp;

		// Token: 0x0402ABAB RID: 175019
		[Nullable(0)]
		public static UiModelComponentHandler <27>__HandlerImp;

		// Token: 0x0402ABAC RID: 175020
		[Nullable(0)]
		public static UiModelComponentHandler <28>__HandlerImp;

		// Token: 0x0402ABAD RID: 175021
		[Nullable(0)]
		public static UiModelComponentHandler <29>__HandlerImp;

		// Token: 0x0402ABAE RID: 175022
		[Nullable(0)]
		public static UiModelComponentHandler <30>__HandlerImp;

		// Token: 0x0402ABAF RID: 175023
		[Nullable(0)]
		public static UiModelComponentHandler <31>__HandlerImp;

		// Token: 0x0402ABB0 RID: 175024
		[Nullable(0)]
		public static UiModelComponentHandler <32>__HandlerImp;

		// Token: 0x0402ABB1 RID: 175025
		[Nullable(0)]
		public static UiModelComponentHandler <33>__HandlerImp;

		// Token: 0x0402ABB2 RID: 175026
		[Nullable(0)]
		public static UiModelComponentHandler <34>__HandlerImp;

		// Token: 0x0402ABB3 RID: 175027
		[Nullable(0)]
		public static UiModelComponentHandler <35>__HandlerImp;

		// Token: 0x0402ABB4 RID: 175028
		[Nullable(0)]
		public static UiModelComponentHandler <36>__HandlerImp;

		// Token: 0x0402ABB5 RID: 175029
		[Nullable(0)]
		public static UiModelComponentHandler <37>__HandlerImp;

		// Token: 0x0402ABB6 RID: 175030
		[Nullable(0)]
		public static UiModelComponentHandler <38>__HandlerImp;

		// Token: 0x0402ABB7 RID: 175031
		[Nullable(0)]
		public static UiModelComponentHandler <39>__HandlerImp;

		// Token: 0x0402ABB8 RID: 175032
		[Nullable(0)]
		public static UiModelComponentHandler <40>__HandlerImp;

		// Token: 0x0402ABB9 RID: 175033
		[Nullable(0)]
		public static UiModelComponentHandler <41>__HandlerImp;

		// Token: 0x0402ABBA RID: 175034
		[Nullable(0)]
		public static UiModelComponentHandler <42>__HandlerImp;

		// Token: 0x0402ABBB RID: 175035
		[Nullable(0)]
		public static UiModelComponentHandler <43>__HandlerImp;

		// Token: 0x0402ABBC RID: 175036
		[Nullable(0)]
		public static UiModelComponentHandler <44>__HandlerImp;

		// Token: 0x0402ABBD RID: 175037
		[Nullable(0)]
		public static UiModelComponentHandler <45>__HandlerImp;
	}
}
