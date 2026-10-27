using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045A2 RID: 17826
	[NullableContext(1)]
	[Nullable(0)]
	public class CharExtraMesh : CharRenderBase
	{
		// Token: 0x0602DF65 RID: 188261 RVA: 0x00A927FD File Offset: 0x00A909FD
		public override void Start()
		{
			base.OnInitSuccess();
		}

		// Token: 0x0602DF66 RID: 188262 RVA: 0x00A92808 File Offset: 0x00A90A08
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

		// Token: 0x0602DF67 RID: 188263 RVA: 0x00A928C8 File Offset: 0x00A90AC8
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

		// Token: 0x0602DF68 RID: 188264 RVA: 0x00A9291C File Offset: 0x00A90B1C
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

		// Token: 0x0602DF69 RID: 188265 RVA: 0x00A92970 File Offset: 0x00A90B70
		public override int GetComponentId()
		{
			return 12;
		}

		// Token: 0x0602DF6A RID: 188266 RVA: 0x00A92974 File Offset: 0x00A90B74
		public override string GetStatName()
		{
			return "CharExtraMesh";
		}

		// Token: 0x040188A1 RID: 100513
		protected Dictionary<string, ExtraMeshInfo> ExtraMeshes = new Dictionary<string, ExtraMeshInfo>();
	}
}
