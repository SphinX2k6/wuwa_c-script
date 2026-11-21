using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Render
{
	// Token: 0x02003515 RID: 13589
	[NullableContext(1)]
	[Nullable(0)]
	public class ItemMaterialManager : Singleton
	{
		// Token: 0x06022994 RID: 141716 RVA: 0x009D8064 File Offset: 0x009D6264
		public void Initialize()
		{
			this.GlobalController = null;
			this.ActorControllers = new List<ItemMaterialActorController>();
			this.IndexCountGlobal = -1;
			this.IndexCount = -1;
			this.AllGlobalControllerInfoMap = new Dictionary<int, ItemMaterialGlobalController>();
			this.AllActorControllerInfoMap = new Dictionary<int, ItemMaterialActorController>();
			this.IsInit = true;
		}

		// Token: 0x06022995 RID: 141717 RVA: 0x009D80A4 File Offset: 0x009D62A4
		public void Tick(float delta)
		{
			RenderStats.Init();
			float deltaSecond = delta * 0.001f;
			List<int> list = new List<int>();
			if (!this.IsInit)
			{
				this.Initialize();
			}
			if (this.AllGlobalControllerInfoMap.Count > 0)
			{
				foreach (KeyValuePair<int, ItemMaterialGlobalController> keyValuePair in this.AllGlobalControllerInfoMap)
				{
					int num;
					ItemMaterialGlobalController itemMaterialGlobalController;
					keyValuePair.Deconstruct(out num, out itemMaterialGlobalController);
					int key = num;
					ItemMaterialGlobalController itemMaterialGlobalController2 = itemMaterialGlobalController;
					if (itemMaterialGlobalController2.IsValid())
					{
						itemMaterialGlobalController2.Update(deltaSecond);
					}
					else
					{
						itemMaterialGlobalController2.Destroy();
						this.AllGlobalControllerInfoMap.Remove(key);
					}
				}
			}
			if (this.AllActorControllerInfoMap.Count > 0)
			{
				foreach (KeyValuePair<int, ItemMaterialActorController> keyValuePair2 in this.AllActorControllerInfoMap)
				{
					int num;
					ItemMaterialActorController itemMaterialActorController;
					keyValuePair2.Deconstruct(out num, out itemMaterialActorController);
					int item = num;
					ItemMaterialActorController itemMaterialActorController2 = itemMaterialActorController;
					if (itemMaterialActorController2.IsValid() && itemMaterialActorController2.GetLifeTimeController() != null)
					{
						itemMaterialActorController2.Update(deltaSecond);
					}
					else
					{
						list.Add(item);
					}
				}
			}
			for (int i = 0; i < list.Count; i++)
			{
				int num2 = list[i];
				ItemMaterialActorController itemMaterialActorController3;
				if (this.AllActorControllerInfoMap.Remove(num2, out itemMaterialActorController3))
				{
					itemMaterialActorController3.Destroy();
				}
				else
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.RenderEffect;
					ELogAuthor author = ELogAuthor.LJY;
					string message = "单体交互物材质控制器队列已经没有目标控制器，卸载失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("handle", num2);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				ItemMaterialDataMap dataMap = this.DataMap;
				if (dataMap == null || !dataMap.IsValid())
				{
					return;
				}
				ItemMaterialDataMap dataMap2 = this.DataMap;
				if (dataMap2 != null)
				{
					dataMap2.Map.Remove((float)num2);
				}
			}
			if (this.AllMaterialSimpleControllers.Count > 0)
			{
				foreach (KeyValuePair<int, ItemMaterialSimpleController> keyValuePair3 in this.AllMaterialSimpleControllers)
				{
					int num;
					ItemMaterialSimpleController itemMaterialSimpleController;
					keyValuePair3.Deconstruct(out num, out itemMaterialSimpleController);
					itemMaterialSimpleController.UpdateParameters();
				}
			}
		}

		// Token: 0x06022996 RID: 141718 RVA: 0x009D82D8 File Offset: 0x009D64D8
		[NullableContext(2)]
		public int AddMaterialData(AActor actor, ItemMaterialControllerActorData materialData)
		{
			if (actor == null || !actor.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderEffect;
				ELogAuthor author = ELogAuthor.LJY;
				string message = "想要添加单体交互物材质控制器，但是传入的Actor是无效的";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", actor);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return -1;
			}
			if (materialData == null || !materialData.IsValid())
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.RenderEffect;
				ELogAuthor author2 = ELogAuthor.LJY;
				string message2 = "想要添加单体交互物材质控制器，但是传入的Data是无效的";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("Actor", actor);
				instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return -1;
			}
			ItemMaterialDataMap dataMap = this.DataMap;
			if (dataMap == null || !dataMap.IsValid())
			{
				this.DataMap = (ActorSystem.Instance.Get(ItemMaterialDataMap.StaticClass(), FTransformDouble.Identity, null, true) as ItemMaterialDataMap);
				this.DataMap.Map.Empty(0);
			}
			this.IndexCount++;
			int indexCount = this.IndexCount;
			ItemMaterialControllerActorData itemMaterialControllerActorData;
			if (!this.DataMap.Map.TryGetValue((float)indexCount, out itemMaterialControllerActorData) || !itemMaterialControllerActorData.IsValid())
			{
				this.DataMap.Map[(float)indexCount] = materialData;
				this.AllActorControllerInfoMap[indexCount] = new ItemMaterialActorController(actor, materialData);
				return indexCount;
			}
			return -1;
		}

		// Token: 0x06022997 RID: 141719 RVA: 0x009D8400 File Offset: 0x009D6600
		public bool DisableActorData(int handle)
		{
			if (this.AllActorControllerInfoMap == null)
			{
				return false;
			}
			ItemMaterialActorController itemMaterialActorController;
			if (!this.AllActorControllerInfoMap.TryGetValue(handle, out itemMaterialActorController))
			{
				return false;
			}
			if (itemMaterialActorController != null)
			{
				itemMaterialActorController.Stop(false);
				return true;
			}
			return false;
		}

		// Token: 0x06022998 RID: 141720 RVA: 0x009D8438 File Offset: 0x009D6638
		public bool DisableAllActorData()
		{
			if (this.AllActorControllerInfoMap == null)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderEffect;
				ELogAuthor author = ELogAuthor.LJY;
				string message = "不满足删除单体交互物材质控制器的条件，返回false";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("handle", -1);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return false;
			}
			foreach (KeyValuePair<int, ItemMaterialActorController> keyValuePair in this.AllActorControllerInfoMap)
			{
				int num;
				ItemMaterialActorController itemMaterialActorController;
				keyValuePair.Deconstruct(out num, out itemMaterialActorController);
				int item = num;
				itemMaterialActorController.Stop(false);
				this.WaitList.Add(item);
			}
			ItemMaterialDataMap dataMap = this.DataMap;
			if (dataMap == null || !dataMap.IsValid())
			{
				return false;
			}
			ItemMaterialDataMap dataMap2 = this.DataMap;
			if (dataMap2 != null)
			{
				dataMap2.Map.Empty(0);
			}
			this.IndexCount = -1;
			return true;
		}

		// Token: 0x06022999 RID: 141721 RVA: 0x009D8514 File Offset: 0x009D6714
		public int AddSimpleMaterialController([Nullable(2)] AActor actor, Dictionary<FName, float> scalarParameterValue, Dictionary<FName, FLinearColor> vectorParameterValue)
		{
			if (actor == null || !actor.IsValid())
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.RenderEffect;
				ELogAuthor author = ELogAuthor.LJY;
				string message = "想要添加单体交互物材质控制器，但是传入的Actor是无效的";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Actor", actor);
				instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return -1;
			}
			int num3;
			foreach (KeyValuePair<int, ItemMaterialSimpleController> keyValuePair in this.AllMaterialSimpleControllers)
			{
				int num;
				ItemMaterialSimpleController itemMaterialSimpleController;
				keyValuePair.Deconstruct(out num, out itemMaterialSimpleController);
				int num2 = num;
				ItemMaterialSimpleController itemMaterialSimpleController2 = itemMaterialSimpleController;
				if (itemMaterialSimpleController2.GetActor() == actor)
				{
					num3 = num2;
					itemMaterialSimpleController2.ScalarParameterValue = scalarParameterValue;
					itemMaterialSimpleController2.VectorParameterValue = vectorParameterValue;
					return num3;
				}
			}
			this.IndexCountSimple++;
			num3 = this.IndexCountSimple;
			ItemMaterialSimpleController itemMaterialSimpleController3 = new ItemMaterialSimpleController(actor);
			itemMaterialSimpleController3.ScalarParameterValue = scalarParameterValue;
			itemMaterialSimpleController3.VectorParameterValue = vectorParameterValue;
			this.AllMaterialSimpleControllers[num3] = itemMaterialSimpleController3;
			return num3;
		}

		// Token: 0x0602299A RID: 141722 RVA: 0x009D8610 File Offset: 0x009D6810
		public bool DisableSimpleMaterialController(int handle)
		{
			if (this.AllMaterialSimpleControllers == null)
			{
				return false;
			}
			this.AllMaterialSimpleControllers.Remove(handle);
			return true;
		}

		// Token: 0x17004866 RID: 18534
		// (get) Token: 0x0602299B RID: 141723 RVA: 0x009D862A File Offset: 0x009D682A
		public static ItemMaterialManager Instance
		{
			get
			{
				if (ItemMaterialManager._instance == null)
				{
					ItemMaterialManager._instance = new ItemMaterialManager();
					ItemMaterialManager._instance.OnInit();
				}
				return ItemMaterialManager._instance;
			}
		}

		// Token: 0x0602299C RID: 141724 RVA: 0x009D864D File Offset: 0x009D684D
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602299D RID: 141725 RVA: 0x009D864F File Offset: 0x009D684F
		public static void ResetStaticDefaultValue()
		{
			ItemMaterialManager instance = ItemMaterialManager._instance;
			if (instance != null)
			{
				instance.OnClear();
			}
			ItemMaterialManager._instance = null;
		}

		// Token: 0x0602299E RID: 141726 RVA: 0x009D8668 File Offset: 0x009D6868
		static ItemMaterialManager()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemMaterialManager.CreateStaticDefaultValue), new Action(ItemMaterialManager.ResetStaticDefaultValue));
		}

		// Token: 0x04013296 RID: 78486
		[Nullable(2)]
		protected ItemMaterialGlobalController GlobalController;

		// Token: 0x04013297 RID: 78487
		protected List<ItemMaterialActorController> ActorControllers = new List<ItemMaterialActorController>();

		// Token: 0x04013298 RID: 78488
		public Dictionary<int, ItemMaterialGlobalController> AllGlobalControllerInfoMap = new Dictionary<int, ItemMaterialGlobalController>();

		// Token: 0x04013299 RID: 78489
		public Dictionary<int, ItemMaterialActorController> AllActorControllerInfoMap = new Dictionary<int, ItemMaterialActorController>();

		// Token: 0x0401329A RID: 78490
		public Dictionary<int, ItemMaterialSimpleController> AllMaterialSimpleControllers = new Dictionary<int, ItemMaterialSimpleController>();

		// Token: 0x0401329B RID: 78491
		public int IndexCountGlobal = -1;

		// Token: 0x0401329C RID: 78492
		public int IndexCount = -1;

		// Token: 0x0401329D RID: 78493
		public int IndexCountSimple = -1;

		// Token: 0x0401329E RID: 78494
		public readonly int RefErrorCount = 5;

		// Token: 0x0401329F RID: 78495
		[Nullable(2)]
		public ItemMaterialDataMap DataMap;

		// Token: 0x040132A0 RID: 78496
		public bool IsInit;

		// Token: 0x040132A1 RID: 78497
		public List<int> WaitList = new List<int>();

		// Token: 0x040132A2 RID: 78498
		[Nullable(2)]
		private static ItemMaterialManager _instance;
	}
}
