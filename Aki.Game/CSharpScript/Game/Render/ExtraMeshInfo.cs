using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x020034C9 RID: 13513
	[NullableContext(1)]
	[Nullable(0)]
	public class ExtraMeshInfo
	{
		// Token: 0x0602264C RID: 140876 RVA: 0x009BE880 File Offset: 0x009BCA80
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

		// Token: 0x0602264D RID: 140877 RVA: 0x009BE918 File Offset: 0x009BCB18
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

		// Token: 0x0602264E RID: 140878 RVA: 0x009BE968 File Offset: 0x009BCB68
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

		// Token: 0x04012ED8 RID: 77528
		public string Name = string.Empty;

		// Token: 0x04012ED9 RID: 77529
		[Nullable(2)]
		public USkeletalMeshComponent SourceComponent;

		// Token: 0x04012EDA RID: 77530
		[Nullable(2)]
		public USkeletalMeshComponent Component;

		// Token: 0x04012EDB RID: 77531
		public int UsageCount;
	}
}
