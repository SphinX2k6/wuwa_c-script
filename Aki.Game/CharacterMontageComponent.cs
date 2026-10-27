using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

// Token: 0x02002ECC RID: 11980
[NullableContext(1)]
[Nullable(0)]
public class CharacterMontageComponent : BaseMontageComponent
{
	// Token: 0x0601999B RID: 104859 RVA: 0x006A4BFB File Offset: 0x006A2DFB
	protected override bool OnStart()
	{
		this.AnimationComponent = base.Entity.CheckGetComponent<CharacterAnimationComponent>();
		return base.OnStart();
	}

	// Token: 0x0601999C RID: 104860 RVA: 0x006A4C19 File Offset: 0x006A2E19
	[NullableContext(2)]
	public override UAnimInstance GetMainAnimInstance()
	{
		return this.AnimationComponent.MainAnimInstance;
	}

	// Token: 0x0601999D RID: 104861 RVA: 0x006A4C28 File Offset: 0x006A2E28
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

	// Token: 0x0601999E RID: 104862 RVA: 0x006A4CE0 File Offset: 0x006A2EE0
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

	// Token: 0x0601999F RID: 104863 RVA: 0x006A4D30 File Offset: 0x006A2F30
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

	// Token: 0x060199A0 RID: 104864 RVA: 0x006A4D7F File Offset: 0x006A2F7F
	public void SetHasMorphMontage(bool hasMorphMontage)
	{
		this.HasMorphMontage = hasMorphMontage;
	}

	// Token: 0x060199A1 RID: 104865 RVA: 0x006A4D88 File Offset: 0x006A2F88
	private static bool IsBaseAnimPath(string path)
	{
		return path.Contains("/BaseAnim/");
	}

	// Token: 0x060199A2 RID: 104866 RVA: 0x006A4D98 File Offset: 0x006A2F98
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterMontageComponent characterMontageComponent = (CharacterMontageComponent)componentTemplate;
		if (base.CanResetComponentProperty("AnimationComponent"))
		{
			if (characterMontageComponent.AnimationComponent == null)
			{
				this.AnimationComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAnimationComponent>(this.AnimationComponent), "AnimationComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MorphComponent"))
		{
			if (characterMontageComponent.MorphComponent == null)
			{
				this.MorphComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterMorphComponent>(this.MorphComponent), "MorphComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("HasMorphMontage"))
		{
			this.HasMorphMontage = characterMontageComponent.HasMorphMontage;
		}
		return true;
	}

	// Token: 0x0400BF93 RID: 49043
	[Nullable(2)]
	public CharacterAnimationComponent AnimationComponent;

	// Token: 0x0400BF94 RID: 49044
	[Nullable(2)]
	public CharacterMorphComponent MorphComponent;

	// Token: 0x0400BF95 RID: 49045
	private bool HasMorphMontage;
}
