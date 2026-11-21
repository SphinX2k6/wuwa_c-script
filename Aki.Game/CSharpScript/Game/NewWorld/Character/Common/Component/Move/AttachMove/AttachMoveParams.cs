using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Level.AttachMove;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move.AttachMove
{
	// Token: 0x020063B4 RID: 25524
	[NullableContext(1)]
	[Nullable(0)]
	public class AttachMoveParams
	{
		// Token: 0x0603DE29 RID: 253481 RVA: 0x011F6120 File Offset: 0x011F4320
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

		// Token: 0x04020DCC RID: 134604
		public bool Debug;

		// Token: 0x04020DCD RID: 134605
		public List<int> GameplayTagList = new List<int>();

		// Token: 0x04020DCE RID: 134606
		public string AttachSocket = "";

		// Token: 0x04020DCF RID: 134607
		public Transform AttachTransform = Transform.Create();
	}
}
