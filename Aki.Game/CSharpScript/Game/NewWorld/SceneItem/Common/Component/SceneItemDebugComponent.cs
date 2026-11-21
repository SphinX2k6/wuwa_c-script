using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Common.Component;

namespace CSharpScript.Game.NewWorld.SceneItem.Common.Component
{
	// Token: 0x020062CD RID: 25293
	public class SceneItemDebugComponent : EntityComponent
	{
		// Token: 0x0603D13A RID: 250170 RVA: 0x01193600 File Offset: 0x01191800
		[NullableContext(1)]
		public string GetTagDebugStrings()
		{
			return base.Entity.GetComponent<LevelTagComponent>().GetTagDebugStrings();
		}
	}
}
