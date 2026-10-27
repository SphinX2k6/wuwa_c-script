using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020045A1 RID: 17825
	[NullableContext(1)]
	[Nullable(0)]
	public class ExtraMeshInfo
	{
		// Token: 0x0602DF62 RID: 188258 RVA: 0x00A92660 File Offset: 0x00A90860
		public ExtraMeshInfo(USkeletalMeshComponent sourceMeshComp, USkeletalMeshComponent extraMeshComp, string extraMeshName)
		{
			this.SourceComponent = sourceMeshComp;
			this.Component = extraMeshComp;
			this.Name = extraMeshName;
			extraMeshComp.K2_AttachToComponent(sourceMeshComp, null, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, false, true);
			extraMeshComp.SetSkeletalMesh(sourceMeshComp.SkeletalMesh, true);
			extraMeshComp.SetVisibility(false, false);
			extraMeshComp.SetComponentTickEnabled(false);
			extraMeshComp.SetCollisionEnabled(ECollisionEnabled.NoCollision);
			int numMaterials = this.Component.GetNumMaterials();
			for (int i = 0; i < numMaterials; i++)
			{
				this.Component.SetMaterial(i, RenderDataManager.Instance.GetEmptyMaterial());
			}
		}

		// Token: 0x0602DF63 RID: 188259 RVA: 0x00A926F8 File Offset: 0x00A908F8
		public void AddUsage()
		{
			if (this.UsageCount == 0)
			{
				this.Component.SetVisibility(true, false);
				this.Component.SetComponentTickEnabled(true);
				this.Component.SetMasterPoseComponent(this.SourceComponent, false);
			}
			this.UsageCount++;
		}

		// Token: 0x0602DF64 RID: 188260 RVA: 0x00A92748 File Offset: 0x00A90948
		public unsafe void RemoveUsage()
		{
			if (this.UsageCount <= 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderCharacter;
				ELogAuthor author = ELogAuthor.LSY;
				string message = "ExtraMeshInfo UsageCount计数错误";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Name", this.Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("UsageCount", this.UsageCount);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return;
			}
			this.UsageCount--;
			if (this.UsageCount == 0)
			{
				this.Component.SetVisibility(false, false);
				this.Component.SetComponentTickEnabled(false);
				this.Component.SetMasterPoseComponent(null, false);
			}
		}

		// Token: 0x0401889D RID: 100509
		public string Name = string.Empty;

		// Token: 0x0401889E RID: 100510
		[Nullable(2)]
		public USkeletalMeshComponent SourceComponent;

		// Token: 0x0401889F RID: 100511
		[Nullable(2)]
		public USkeletalMeshComponent Component;

		// Token: 0x040188A0 RID: 100512
		public int UsageCount;
	}
}
