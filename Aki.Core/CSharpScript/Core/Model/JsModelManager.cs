using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using UnrealEngine;

namespace CSharpScript.Core.Model
{
	// Token: 0x02000132 RID: 306
	[NullableContext(1)]
	[Nullable(0)]
	public class JsModelManager : Singleton
	{
		// Token: 0x06000B40 RID: 2880 RVA: 0x000356CC File Offset: 0x000338CC
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

		// Token: 0x06000B41 RID: 2881 RVA: 0x00035710 File Offset: 0x00033910
		public void DestroyEnvironment()
		{
			this.HasInitialized = false;
			UKuroJsModelFunctionLibrary.DestroyEnvironment();
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0003571E File Offset: 0x0003391E
		public void AddEntity(int entityId)
		{
			if (!this.HasInitialized)
			{
				return;
			}
			UKuroJsModelFunctionLibrary.AddEntity(entityId);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0003572F File Offset: 0x0003392F
		[NullableContext(2)]
		public void UpdateEntityActor(int entityId, AActor actor)
		{
			if (!this.HasInitialized)
			{
				return;
			}
			UKuroJsModelFunctionLibrary.UpdateEntityActor(entityId, actor);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x00035741 File Offset: 0x00033941
		public void RemoveEntity(int entityId)
		{
			if (!this.HasInitialized)
			{
				return;
			}
			UKuroJsModelFunctionLibrary.RemoveEntity(entityId);
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000B45 RID: 2885 RVA: 0x00035752 File Offset: 0x00033952
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

		// Token: 0x06000B46 RID: 2886 RVA: 0x00035775 File Offset: 0x00033975
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00035777 File Offset: 0x00033977
		public static void ResetStaticDefaultValue()
		{
			JsModelManager instance = JsModelManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			JsModelManager._instance = null;
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x00035790 File Offset: 0x00033990
		static JsModelManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(JsModelManager.CreateStaticDefaultValue), new Action(JsModelManager.ResetStaticDefaultValue));
		}

		// Token: 0x040006D1 RID: 1745
		public bool HasInitialized;

		// Token: 0x040006D2 RID: 1746
		[Nullable(2)]
		private static JsModelManager _instance;
	}
}
