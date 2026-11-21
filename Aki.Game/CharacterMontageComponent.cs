using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x0200241F RID: 9247
[NullableContext(1)]
[Nullable(0)]
public class CharacterMontageComponent : BaseMontageComponent
{
	// Token: 0x06017293 RID: 94867 RVA: 0x006CADEA File Offset: 0x006C8FEA
	protected override bool OnStart()
	{
		this.AnimationComponent = base.Entity.CheckGetComponent<CharacterAnimationComponent>();
		return base.OnStart();
	}

	// Token: 0x06017294 RID: 94868 RVA: 0x006CAE08 File Offset: 0x006C9008
	[NullableContext(2)]
	public override UAnimInstance GetMainAnimInstance()
	{
		return this.AnimationComponent.GetAnimInstance();
	}

	// Token: 0x06017295 RID: 94869 RVA: 0x006CAE18 File Offset: 0x006C9018
	public override void AddMontage(string name, UAnimMontage montage, string path)
	{
		if (this.HasMorphMontage)
		{
			this.MorphComponent = (this.MorphComponent ?? base.Entity.GetComponent<CharacterMorphComponent>());
			CharacterMorphComponent morphComponent = this.MorphComponent;
			if (morphComponent != null)
			{
				EMorphType montagePathMorphType = morphComponent.GetMontagePathMorphType(path);
				string path2;
				if (montagePathMorphType != EMorphType.默认形态)
				{
					morphComponent.AddMorphMontagePath(path, montagePathMorphType);
					if (montage == null)
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Battle;
						ELogAuthor author = ELogAuthor.WWJ;
						string message = "添加的多形态蒙太奇不存在";
						ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Name", name);
						instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
						return;
					}
					morphComponent.AddMontage(name, montage, path);
					UKuroStaticLibrary.SetMontageANIndex(montage);
					return;
				}
				else if (CharacterMontageComponent.IsBaseAnimPath(path) && this.MontagePathMapByName.TryGetValue(name, out path2) && !CharacterMontageComponent.IsBaseAnimPath(path2))
				{
					return;
				}
			}
		}
		base.AddMontage(name, montage, path);
	}

	// Token: 0x06017296 RID: 94870 RVA: 0x006CAED0 File Offset: 0x006C90D0
	[return: Nullable(2)]
	public override UAnimMontage GetMontageByName(string name, bool includeMorphMontage = true, bool replaceMorphMontage = false)
	{
		if (includeMorphMontage && this.HasMorphMontage)
		{
			CharacterMorphComponent morphComponent = this.MorphComponent;
			if (morphComponent != null && morphComponent.IsMorphing())
			{
				UAnimMontage montageByName = morphComponent.GetMontageByName(name);
				if (montageByName == null && replaceMorphMontage)
				{
					montageByName = base.GetMontageByName(name, true, false);
				}
				return montageByName;
			}
		}
		return base.GetMontageByName(name, true, false);
	}

	// Token: 0x06017297 RID: 94871 RVA: 0x006CAF20 File Offset: 0x006C9120
	[return: Nullable(2)]
	public override string GetMontagePathByName(string name, bool includeMorphMontage = true, bool replaceMorphMontage = false)
	{
		if (includeMorphMontage && this.HasMorphMontage)
		{
			CharacterMorphComponent morphComponent = this.MorphComponent;
			if (morphComponent != null && morphComponent.IsMorphing())
			{
				string montagePathByName = morphComponent.GetMontagePathByName(name);
				if (montagePathByName == null && replaceMorphMontage)
				{
					montagePathByName = base.GetMontagePathByName(name, true, false);
				}
				return montagePathByName;
			}
		}
		return base.GetMontagePathByName(name, true, false);
	}

	// Token: 0x06017298 RID: 94872 RVA: 0x006CAF6F File Offset: 0x006C916F
	public void SetHasMorphMontage(bool hasMorphMontage)
	{
		this.HasMorphMontage = hasMorphMontage;
	}

	// Token: 0x06017299 RID: 94873 RVA: 0x006CAF78 File Offset: 0x006C9178
	private static bool IsBaseAnimPath(string path)
	{
		return path.Contains("/BaseAnim/");
	}

	// Token: 0x0601729A RID: 94874 RVA: 0x006CAF88 File Offset: 0x006C9188
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterMontageComponent characterMontageComponent = (CharacterMontageComponent)componentTemplate;
		if (characterMontageComponent.AnimationComponent == null)
		{
			this.AnimationComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimationComponent), "AnimationComponent"))
		{
			return false;
		}
		if (characterMontageComponent.MorphComponent == null)
		{
			this.MorphComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MorphComponent), "MorphComponent"))
		{
			return false;
		}
		this.HasMorphMontage = characterMontageComponent.HasMorphMontage;
		return true;
	}

	// Token: 0x17002413 RID: 9235
	// (get) Token: 0x0601729B RID: 94875 RVA: 0x006CB00A File Offset: 0x006C920A
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002414 RID: 9236
	// (get) Token: 0x0601729C RID: 94876 RVA: 0x006CB00D File Offset: 0x006C920D
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400C32E RID: 49966
	[Nullable(2)]
	public CharacterAnimationComponent AnimationComponent;

	// Token: 0x0400C32F RID: 49967
	[Nullable(2)]
	public CharacterMorphComponent MorphComponent;

	// Token: 0x0400C330 RID: 49968
	private bool HasMorphMontage;
}
