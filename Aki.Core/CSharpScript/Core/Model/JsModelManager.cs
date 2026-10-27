using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Core.Model
{
	// Token: 0x02000131 RID: 305
	[NullableContext(1)]
	[Nullable(0)]
	public class JsModelManager : Singleton
	{
		// Token: 0x06000AE9 RID: 2793 RVA: 0x00034C58 File Offset: 0x00032E58
		public void InitializeEnvironment()
		{
			UWorld world = Info.Instance.World;
			if (world == null)
			{
				Log.Instance.Info(ELogModule.Core, ELogAuthor.WLJ, "JsModelManager.InitializeEnvironment Fail!!!", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			UKuroJsModelFunctionLibrary.InitializeEnvironment(world);
			this.HasInitialized = true;
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00034C9C File Offset: 0x00032E9C
		public void DestroyEnvironment()
		{
			this.HasInitialized = false;
			UKuroJsModelFunctionLibrary.DestroyEnvironment();
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00034CAA File Offset: 0x00032EAA
		public void AddEntity(int entityId)
		{
			if (!this.HasInitialized)
			{
				return;
			}
			UKuroJsModelFunctionLibrary.AddEntity(entityId);
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00034CBB File Offset: 0x00032EBB
		[NullableContext(2)]
		public void UpdateEntityActor(int entityId, AActor actor)
		{
			if (!this.HasInitialized)
			{
				return;
			}
			UKuroJsModelFunctionLibrary.UpdateEntityActor(entityId, actor);
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00034CCD File Offset: 0x00032ECD
		public void RemoveEntity(int entityId)
		{
			if (!this.HasInitialized)
			{
				return;
			}
			UKuroJsModelFunctionLibrary.RemoveEntity(entityId);
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000AEE RID: 2798 RVA: 0x00034CDE File Offset: 0x00032EDE
		public static JsModelManager Instance
		{
			get
			{
				if (JsModelManager._instance == null)
				{
					JsModelManager._instance = new JsModelManager();
					JsModelManager._instance.OnInit();
				}
				return JsModelManager._instance;
			}
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00034D01 File Offset: 0x00032F01
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00034D03 File Offset: 0x00032F03
		public static void ResetStaticDefaultValue()
		{
			JsModelManager instance = JsModelManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			JsModelManager._instance = null;
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00034D1C File Offset: 0x00032F1C
		static JsModelManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(JsModelManager.CreateStaticDefaultValue), new Action(JsModelManager.ResetStaticDefaultValue));
		}

		// Token: 0x040006C3 RID: 1731
		public bool HasInitialized;

		// Token: 0x040006C4 RID: 1732
		[Nullable(2)]
		private static JsModelManager _instance;
	}
}
