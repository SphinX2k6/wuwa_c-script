using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.AttachMove;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.AttachMove
{
	// Token: 0x02007104 RID: 28932
	[NullableContext(1)]
	[Nullable(0)]
	public class AttachMoveParams
	{
		// Token: 0x06046A2A RID: 289322 RVA: 0x011C7100 File Offset: 0x011C5300
		[NullableContext(2)]
		public AttachMoveParams(BP_AttachMoveConfig_C data = null)
		{
			if (data == null)
			{
				return;
			}
			this.Debug = data.Debug;
			this.AttachSocket = data.AttachSocket;
			Transform attachTransform = this.AttachTransform;
			FTransform attachTransform2 = data.AttachTransform;
			attachTransform.FromUeTransform(attachTransform2);
			for (int i = 0; i < data.GameplayTagList.GameplayTags.Num(); i++)
			{
				this.GameplayTagList.Add(data.GameplayTagList.GameplayTags.Get(i).TagId());
			}
		}

		// Token: 0x04025137 RID: 151863
		public bool Debug;

		// Token: 0x04025138 RID: 151864
		public List<int> GameplayTagList = new List<int>();

		// Token: 0x04025139 RID: 151865
		public string AttachSocket = "";

		// Token: 0x0402513A RID: 151866
		public Transform AttachTransform = Transform.Create();
	}
}
