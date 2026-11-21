using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Render.RuntimeBP.Character.Manager;

namespace CSharpScript.Game.Module.UiCamera
{
	// Token: 0x0200398A RID: 14730
	[NullableContext(1)]
	[Nullable(0)]
	public class UiCameraActorDisplayComponent : UiCameraComponent
	{
		// Token: 0x17004D59 RID: 19801
		// (get) Token: 0x06025E71 RID: 155249 RVA: 0x00AA4632 File Offset: 0x00AA2832
		public bool IsPlayerDisabled
		{
			get
			{
				return this.PlayerDisableHandles.Count > 0;
			}
		}

		// Token: 0x06025E72 RID: 155250 RVA: 0x00AA4644 File Offset: 0x00AA2844
		public void DisablePlayerActor()
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
			if (worldEntity == null || !worldEntity.Valid)
			{
				Log.Instance.Warn(ELogModule.UiCamera, ELogAuthor.BB, "Ui镜头隐藏玩家Actor失败，找不到当前玩家Entity", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (this.PlayerDisableHandles.ContainsKey(worldEntity.Id))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCamera;
				ELogAuthor author = ELogAuthor.BB;
				string message = "Ui镜头已经隐藏过当前玩家Actor";
				ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("EntityId", worldEntity.Id);
				instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				return;
			}
			BaseActorComponent component = worldEntity.GetComponent<BaseActorComponent>();
			if (component != null)
			{
				this.PlayerDisableHandles.Add(worldEntity.Id, component.DisableActor("UiCameraActorDisplayComponent.DisablePlayerActor"));
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.UiCamera;
				ELogAuthor author2 = ELogAuthor.BB;
				string message2 = "Ui镜头隐藏玩家Actor";
				ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("EntityId", worldEntity.Id);
				instance2.Info(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
				return;
			}
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.UiCamera;
			ELogAuthor author3 = ELogAuthor.BB;
			string message3 = "Ui镜头隐藏玩家Actor失败，找不到BaseActorComponent";
			ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("EntityId", worldEntity.Id);
			instance3.Warn(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
		}

		// Token: 0x06025E73 RID: 155251 RVA: 0x00AA4768 File Offset: 0x00AA2968
		public unsafe void EnablePlayerActor()
		{
			foreach (KeyValuePair<int, int> keyValuePair in this.PlayerDisableHandles)
			{
				int num;
				int num2;
				keyValuePair.Deconstruct(out num, out num2);
				int num3 = num;
				int num4 = num2;
				Entity entity = EntitySystem.Instance.Get(num3);
				BaseActorComponent baseActorComponent = (entity != null) ? entity.GetComponent<BaseActorComponent>() : null;
				if (baseActorComponent == null)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.UiCamera;
					ELogAuthor author = ELogAuthor.BB;
					string message = "Ui镜头恢复玩家Actor失败，找不到BaseActorComponent";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", num3);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("DisableHandleId", num4);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				else
				{
					baseActorComponent.EnableActor(num4);
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.UiCamera;
					ELogAuthor author2 = ELogAuthor.BB;
					string message2 = "Ui镜头在清理表现时显示玩家Actor";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", num3);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("DisableHandleId", num4);
					instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				}
			}
			this.PlayerDisableHandles.Clear();
		}

		// Token: 0x06025E74 RID: 155252 RVA: 0x00AA48CC File Offset: 0x00AA2ACC
		public unsafe void DisableCustomCreatureActor(int position)
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			WorldEntity worldEntity = (getCurrentEntity != null) ? getCurrentEntity.Entity : null;
			CreatureDataComponent creatureDataComponent = (worldEntity != null) ? worldEntity.GetComponent<CreatureDataComponent>() : null;
			if (worldEntity == null || !worldEntity.Valid || creatureDataComponent == null || position <= 0 || position > creatureDataComponent.CustomServerEntityIds.Count)
			{
				return;
			}
			long num = creatureDataComponent.CustomServerEntityIds[position - 1];
			EntityHandle entity = CreatureModel.Instance.GetEntity(num);
			WorldEntity worldEntity2 = (entity != null) ? entity.Entity : null;
			BaseActorComponent baseActorComponent = (worldEntity2 != null) ? worldEntity2.GetComponent<BaseActorComponent>() : null;
			if (baseActorComponent == null)
			{
				return;
			}
			Dictionary<int, int> dictionary;
			if (!this.CreatureDisableHandles.TryGetValue(worldEntity.Id, out dictionary))
			{
				dictionary = new Dictionary<int, int>();
				this.CreatureDisableHandles.Add(worldEntity.Id, dictionary);
			}
			if (!dictionary.ContainsKey(position))
			{
				dictionary.Add(position, baseActorComponent.DisableActor("UiCameraActorDisplayComponent.DisableCustomCreatureActor"));
				Log instance = Log.Instance;
				ELogModule module = ELogModule.UiCamera;
				ELogAuthor author = ELogAuthor.BB;
				string message = "Ui镜头隐藏玩家伴生物";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", worldEntity.Id);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Position", position);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("CustomEntityId", num);
				instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
		}

		// Token: 0x06025E75 RID: 155253 RVA: 0x00AA4A2C File Offset: 0x00AA2C2C
		public unsafe void EnableCustomCreatureActor()
		{
			foreach (KeyValuePair<int, Dictionary<int, int>> keyValuePair in this.CreatureDisableHandles)
			{
				int num;
				Dictionary<int, int> dictionary;
				keyValuePair.Deconstruct(out num, out dictionary);
				int num2 = num;
				Dictionary<int, int> dictionary2 = dictionary;
				Entity entity = EntitySystem.Instance.Get(num2);
				CreatureDataComponent creatureDataComponent = (entity != null) ? entity.GetComponent<CreatureDataComponent>() : null;
				if (creatureDataComponent != null)
				{
					foreach (KeyValuePair<int, int> keyValuePair2 in dictionary2)
					{
						int num3;
						keyValuePair2.Deconstruct(out num, out num3);
						int num4 = num;
						int handle = num3;
						if (num4 > 0 && num4 <= creatureDataComponent.CustomServerEntityIds.Count)
						{
							long num5 = creatureDataComponent.CustomServerEntityIds[num4 - 1];
							EntityHandle entity2 = CreatureModel.Instance.GetEntity(num5);
							BaseActorComponent baseActorComponent;
							if (entity2 == null)
							{
								baseActorComponent = null;
							}
							else
							{
								WorldEntity entity3 = entity2.Entity;
								baseActorComponent = ((entity3 != null) ? entity3.GetComponent<BaseActorComponent>() : null);
							}
							BaseActorComponent baseActorComponent2 = baseActorComponent;
							if (baseActorComponent2 == null)
							{
								Log instance = Log.Instance;
								ELogModule module = ELogModule.UiCamera;
								ELogAuthor author = ELogAuthor.BB;
								string message = "Ui镜头恢复玩家伴生物失败，找不到BaseActorComponent";
								<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", num2);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Position", num4);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("CustomEntityId", num5);
								instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
							}
							else
							{
								baseActorComponent2.EnableActor(handle);
								Log instance2 = Log.Instance;
								ELogModule module2 = ELogModule.UiCamera;
								ELogAuthor author2 = ELogAuthor.BB;
								string message2 = "Ui镜头在清理表现时显示玩家伴生物";
								<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("EntityId", num2);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Position", num4);
								*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("CustomEntityId", num5);
								instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
							}
						}
					}
				}
			}
			this.CreatureDisableHandles.Clear();
		}

		// Token: 0x06025E76 RID: 155254 RVA: 0x00AA4C88 File Offset: 0x00AA2E88
		public override void Clear()
		{
			this.EnablePlayerActor();
			this.EnableCustomCreatureActor();
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter == null)
			{
				return;
			}
			baseCharacter.SetDitherEffect(1f, ECharacterDitherType.Sequence);
		}

		// Token: 0x04014D83 RID: 85379
		private readonly Dictionary<int, int> PlayerDisableHandles = new Dictionary<int, int>();

		// Token: 0x04014D84 RID: 85380
		private readonly Dictionary<int, Dictionary<int, int>> CreatureDisableHandles = new Dictionary<int, Dictionary<int, int>>();
	}
}
