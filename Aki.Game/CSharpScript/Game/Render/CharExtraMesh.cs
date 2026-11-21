using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034CA RID: 13514
	[NullableContext(1)]
	[Nullable(0)]
	public class CharExtraMesh : CharRenderBase
	{
		// Token: 0x0602264F RID: 140879 RVA: 0x009BEA1D File Offset: 0x009BCC1D
		public override void Start()
		{
			base.OnInitSuccess();
		}

		// Token: 0x06022650 RID: 140880 RVA: 0x009BEA28 File Offset: 0x009BCC28
		public void EnsureExtraMesh(string sourceSkeletalName)
		{
			if (this.ExtraMeshes.ContainsKey(sourceSkeletalName))
			{
				return;
			}
			USkeletalMeshComponent skeletalMeshComponent = this.RenderComponent.GetSkeletalMeshComponent(RenderConfig.MaterialControlBodyCaseArray[0]);
			if (skeletalMeshComponent == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.LSY;
				string message = "EnsureExtraMesh未找到源骨骼网格体组件";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SourceSkeletalName", sourceSkeletalName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			string text = RenderConfig.GenerateExtraMeshName(sourceSkeletalName);
			AActor cachedOwner = base.GetRenderingComponent().GetCachedOwner();
			TSubclassOf<UActorComponent> @class = USkeletalMeshComponent.StaticClass();
			bool bManualAttachment = false;
			FTransform ftransform = new FTransform();
			USkeletalMeshComponent uskeletalMeshComponent = cachedOwner.AddComponentByClass(@class, bManualAttachment, ftransform, false, new FName(text)) as USkeletalMeshComponent;
			ExtraMeshInfo extraMeshInfo = new ExtraMeshInfo(skeletalMeshComponent, uskeletalMeshComponent, text);
			this.ExtraMeshes[sourceSkeletalName] = extraMeshInfo;
			CharRenderingComponent renderComponent = this.RenderComponent;
			if (renderComponent == null)
			{
				return;
			}
			renderComponent.AddComponentWithEmptyMaterial(extraMeshInfo.Name, uskeletalMeshComponent);
		}

		// Token: 0x06022651 RID: 140881 RVA: 0x009BEAE8 File Offset: 0x009BCCE8
		public void AddExtraSkeletalMeshUsage(string sourceSkeletalName)
		{
			if (!this.ExtraMeshes.ContainsKey(sourceSkeletalName))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.LSY;
				string message = "找不到ExtraMesh";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SourceSkeletalName", sourceSkeletalName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.ExtraMeshes[sourceSkeletalName].AddUsage();
		}

		// Token: 0x06022652 RID: 140882 RVA: 0x009BEB3C File Offset: 0x009BCD3C
		public void RemoveExtraSkeletalMeshUsage(string sourceSkeletalName)
		{
			if (!this.ExtraMeshes.ContainsKey(sourceSkeletalName))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.LSY;
				string message = "找不到ExtraMesh";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("SourceSkeletalName", sourceSkeletalName);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			this.ExtraMeshes[sourceSkeletalName].RemoveUsage();
		}

		// Token: 0x06022653 RID: 140883 RVA: 0x009BEB90 File Offset: 0x009BCD90
		public override int GetComponentId()
		{
			return 12;
		}

		// Token: 0x06022654 RID: 140884 RVA: 0x009BEB94 File Offset: 0x009BCD94
		public override string GetStatName()
		{
			return "CharExtraMesh";
		}

		// Token: 0x04012EDC RID: 77532
		protected Dictionary<string, ExtraMeshInfo> ExtraMeshes = new Dictionary<string, ExtraMeshInfo>();
	}
}
