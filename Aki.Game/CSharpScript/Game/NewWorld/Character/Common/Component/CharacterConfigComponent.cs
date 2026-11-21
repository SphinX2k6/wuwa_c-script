using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x0200631D RID: 25373
	[NullableContext(1)]
	[Nullable(0)]
	public class CharacterConfigComponent : EntityComponent
	{
		// Token: 0x0603D6AE RID: 251566 RVA: 0x011C2566 File Offset: 0x011C0766
		protected override bool OnStart()
		{
			this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
			return true;
		}

		// Token: 0x0603D6AF RID: 251567 RVA: 0x011C257C File Offset: 0x011C077C
		protected override bool OnEnd()
		{
			foreach (int tagId in this.ListenedTagIds)
			{
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp != null)
				{
					tagComp.RemoveTagAddOrRemoveListener(tagId, new BaseTagComponent.TTagSwitchedCallback(this.OnTagChanged));
				}
			}
			this.ListenedTagIds.Clear();
			this.TagIdToConfigParams.Clear();
			return true;
		}

		// Token: 0x0603D6B0 RID: 251568 RVA: 0x011C2600 File Offset: 0x011C0800
		[NullableContext(2)]
		public unsafe void RegisterConfig(UKuroConfigHelperNew configHelper, UObject targetObject, [Nullable(1)] string dataTablePath, string baseDataPath = null)
		{
			if (this.TagComp == null)
			{
				Log.Instance.Error(ELogModule.Movement, ELogAuthor.LCZ, "CharacterConfig 缺少 BaseTagComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (configHelper == null)
			{
				Log.Instance.Error(ELogModule.Movement, ELogAuthor.LCZ, "CharacterConfig RegisterConfig 参数无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			UDataAsset udataAsset = null;
			if (!string.IsNullOrEmpty(baseDataPath))
			{
				udataAsset = ResourceSystem.Instance.Load<UDataAsset>(baseDataPath, "js_undefined");
				if (udataAsset == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Movement;
					ELogAuthor author = ELogAuthor.LCZ;
					string message = "CharacterConfig BaseData 加载失败";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("path", baseDataPath);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
			configHelper.InitBase(targetObject, udataAsset);
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Movement;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "CharacterConfig Init成功";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "Actor";
			BaseActorComponent component = base.Entity.GetComponent<BaseActorComponent>();
			object item2;
			if (component == null)
			{
				item2 = null;
			}
			else
			{
				AActor owner = component.Owner;
				item2 = ((owner != null) ? owner.GetName() : null);
			}
			ptr = new ValueTuple<string, object>(item, item2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Path", baseDataPath);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			ResourceSystem.Instance.LoadAsync<UDataTable>(dataTablePath, delegate([Nullable(2)] UDataTable dataTable, string path)
			{
				if (dataTable == null)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Movement;
					ELogAuthor author3 = ELogAuthor.LCZ;
					string message3 = "CharacterConfig DT 加载失败";
					ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("path", path);
					instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
					return;
				}
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp == null)
				{
					return;
				}
				this.ApplyConfigTable(dataTable, configHelper, tagComp);
			}, 100, "js_undefined");
		}

		// Token: 0x0603D6B1 RID: 251569 RVA: 0x011C2754 File Offset: 0x011C0954
		[NullableContext(2)]
		public void RegisterConfigByAsset(UKuroConfigHelperNew configHelper, UObject targetObject, [Nullable(1)] UDataTable dataTable, UDataAsset baseData = null)
		{
			if (this.TagComp == null)
			{
				Log.Instance.Error(ELogModule.Movement, ELogAuthor.LCZ, "CharacterConfig 缺少 BaseTagComponent", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (configHelper == null)
			{
				Log.Instance.Error(ELogModule.Movement, ELogAuthor.LCZ, "CharacterConfig RegisterConfigByAsset 参数无效", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (dataTable == null)
			{
				Log.Instance.Error(ELogModule.Movement, ELogAuthor.LCZ, "CharacterConfig RegisterConfigByAsset DT 为空", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			configHelper.InitBase(targetObject, baseData);
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "CharacterConfig RegisterConfigByAsset Init成功";
			string item = "Actor";
			BaseActorComponent component = base.Entity.GetComponent<BaseActorComponent>();
			object item2;
			if (component == null)
			{
				item2 = null;
			}
			else
			{
				AActor owner = component.Owner;
				item2 = ((owner != null) ? owner.GetName() : null);
			}
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>(item, item2);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.ApplyConfigTable(dataTable, configHelper, this.TagComp);
		}

		// Token: 0x0603D6B2 RID: 251570 RVA: 0x011C2824 File Offset: 0x011C0A24
		private void ApplyConfigTable(UDataTable dataTable, UKuroConfigHelperNew configHelper, BaseTagComponent tagComp)
		{
			TArray<FName> tarray = new TArray<FName>();
			UDataTableFunctionLibrary.GetDataTableRowNames(dataTable, ref tarray);
			int num = tarray.Num();
			for (int i = 0; i < num; i++)
			{
				FName fname = tarray.Get(i);
				SCharacterConfigHelperParam dataTableRow = DataTableUtil.GetDataTableRow<SCharacterConfigHelperParam>(dataTable, fname.ToString());
				if (!(dataTableRow == null) && !(fname == CharacterConfigComponent.baseName))
				{
					UKuroDataBag dataBag数据 = dataTableRow.DataBag数据;
					if (dataBag数据 != null)
					{
						CharacterConfigParams characterConfigParams = new CharacterConfigParams(fname, dataTableRow.Priority, dataBag数据, dataTableRow.ActivateTags, (EConfigApplyTypeNew)dataTableRow.附加模式, tagComp, configHelper);
						TArray<FGameplayTag> gameplayTags = dataTableRow.ActivateTags.GameplayTags;
						int num2 = gameplayTags.Num();
						for (int j = 0; j < num2; j++)
						{
							FGameplayTag fgameplayTag = gameplayTags.Get(j);
							if (!(fgameplayTag.TagName == "None"))
							{
								List<CharacterConfigParams> valueOrDefault = this.TagIdToConfigParams.GetValueOrDefault(fgameplayTag.TagId());
								if (valueOrDefault != null)
								{
									valueOrDefault.Add(characterConfigParams);
								}
								else
								{
									this.TagIdToConfigParams.Add(fgameplayTag.TagId(), new List<CharacterConfigParams>
									{
										characterConfigParams
									});
								}
							}
						}
						characterConfigParams.TryActivate();
					}
				}
			}
			foreach (KeyValuePair<int, List<CharacterConfigParams>> keyValuePair in this.TagIdToConfigParams)
			{
				int num3;
				List<CharacterConfigParams> list;
				keyValuePair.Deconstruct(out num3, out list);
				int num4 = num3;
				if (!this.ListenedTagIds.Contains(num4))
				{
					this.ListenedTagIds.Add(num4);
					tagComp.AddTagAddOrRemoveListener(num4, new BaseTagComponent.TTagSwitchedCallback(this.OnTagChanged), null);
				}
			}
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "CharacterConfig RegisterConfig 成功";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("rows", num);
			instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}

		// Token: 0x0603D6B3 RID: 251571 RVA: 0x011C2A08 File Offset: 0x011C0C08
		private void OnTagChanged(int tagId, bool tagExist)
		{
			List<CharacterConfigParams> valueOrDefault = this.TagIdToConfigParams.GetValueOrDefault(tagId);
			if (valueOrDefault == null)
			{
				return;
			}
			if (tagExist)
			{
				using (List<CharacterConfigParams>.Enumerator enumerator = valueOrDefault.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						CharacterConfigParams characterConfigParams = enumerator.Current;
						characterConfigParams.TryActivate();
					}
					return;
				}
			}
			foreach (CharacterConfigParams characterConfigParams2 in valueOrDefault)
			{
				characterConfigParams2.Inactivate();
			}
		}

		// Token: 0x0603D6B4 RID: 251572 RVA: 0x011C2AA4 File Offset: 0x011C0CA4
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			CharacterConfigComponent characterConfigComponent = (CharacterConfigComponent)componentTemplate;
			if (characterConfigComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
			{
				return false;
			}
			return (characterConfigComponent.TagIdToConfigParams == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagIdToConfigParams), "TagIdToConfigParams")) && (characterConfigComponent.ListenedTagIds == null || base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.ListenedTagIds), "ListenedTagIds"));
		}

		// Token: 0x1700747B RID: 29819
		// (get) Token: 0x0603D6B5 RID: 251573 RVA: 0x011C2B33 File Offset: 0x011C0D33
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700747C RID: 29820
		// (get) Token: 0x0603D6B6 RID: 251574 RVA: 0x011C2B36 File Offset: 0x011C0D36
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0402091B RID: 133403
		[StaticVariableRuleIgnore]
		private static readonly FName baseName = new FName("Base");

		// Token: 0x0402091C RID: 133404
		[Nullable(2)]
		private BaseTagComponent TagComp;

		// Token: 0x0402091D RID: 133405
		private readonly Dictionary<int, List<CharacterConfigParams>> TagIdToConfigParams = new Dictionary<int, List<CharacterConfigParams>>();

		// Token: 0x0402091E RID: 133406
		private readonly HashSet<int> ListenedTagIds = new HashSet<int>();
	}
}
