using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;

// Token: 0x0200284F RID: 10319
[NullableContext(1)]
[Nullable(0)]
public class VehicleTagComponent : BaseTagComponent
{
	// Token: 0x17002A86 RID: 10886
	// (get) Token: 0x0601A1A2 RID: 106914 RVA: 0x0080E302 File Offset: 0x0080C502
	protected Dictionary<int, int[]> VehicleToDriverTagIdMap
	{
		get
		{
			return this.PerformComp.Config.VehicleToDriverTagMap;
		}
	}

	// Token: 0x17002A87 RID: 10887
	// (get) Token: 0x0601A1A3 RID: 106915 RVA: 0x0080E314 File Offset: 0x0080C514
	protected Dictionary<int, int[]> DriverToVehicleTagIdMap
	{
		get
		{
			return this.PerformComp.Config.DriverToVehicleTagMap;
		}
	}

	// Token: 0x17002A88 RID: 10888
	// (get) Token: 0x0601A1A4 RID: 106916 RVA: 0x0080E326 File Offset: 0x0080C526
	protected Dictionary<int, long[]> VehicleToDriverBuffIdMap
	{
		get
		{
			return this.PerformComp.Config.VehicleToDriverBuffMap;
		}
	}

	// Token: 0x0601A1A5 RID: 106917 RVA: 0x0080E338 File Offset: 0x0080C538
	protected void VehicleTagChanged(int tagId, bool tagExist)
	{
		BaseVehiclePerformComponent performComp = this.PerformComp;
		if (!(!((performComp != null) ? performComp.Driver : null)))
		{
			BaseVehiclePerformComponent performComp2 = this.PerformComp;
			bool flag;
			if (performComp2 == null)
			{
				flag = false;
			}
			else
			{
				VehiclePassengerInfo valueOrDefault = performComp2.PassengerInfoMap.GetValueOrDefault(this.PerformComp.Driver.Id);
				flag = ((valueOrDefault != null) ? new bool?(valueOrDefault.IsLeaving) : null).GetValueOrDefault();
			}
			if (!flag)
			{
				int[] valueOrDefault2 = this.VehicleToDriverTagIdMap.GetValueOrDefault(tagId);
				if (valueOrDefault2 != null)
				{
					if (tagExist)
					{
						foreach (int value in valueOrDefault2)
						{
							BaseTagComponent component = this.PerformComp.Driver.GetComponent<BaseTagComponent>();
							if (component != null)
							{
								component.AddTag(new int?(value));
							}
						}
					}
					else
					{
						foreach (int value2 in valueOrDefault2)
						{
							BaseTagComponent component2 = this.PerformComp.Driver.GetComponent<BaseTagComponent>();
							if (component2 != null)
							{
								component2.RemoveTag(new int?(value2));
							}
						}
					}
				}
				long[] valueOrDefault3 = this.VehicleToDriverBuffIdMap.GetValueOrDefault(tagId);
				if (valueOrDefault3 != null)
				{
					if (tagExist)
					{
						foreach (long num in valueOrDefault3)
						{
							BaseBuffComponent component3 = this.PerformComp.Driver.GetComponent<BaseBuffComponent>();
							if (component3 != null)
							{
								long buffId = num;
								AddBuffParam addBuffParam = new AddBuffParam();
								addBuffParam.InstigatorId = this.BaseActorComp.CreatureData.GetCreatureDataId();
								VehicleBuffComponent vehicleBuffComp = this.VehicleBuffComp;
								addBuffParam.PreMessageId = ((vehicleBuffComp != null) ? new long?(vehicleBuffComp.MotorContextId) : null);
								addBuffParam.Reason = "MotorTag.Buff";
								component3.AddBuff(buffId, addBuffParam);
							}
						}
						return;
					}
					foreach (long buffId2 in valueOrDefault3)
					{
						BaseBuffComponent component4 = this.PerformComp.Driver.GetComponent<BaseBuffComponent>();
						if (component4 != null)
						{
							component4.RemoveBuff(buffId2, -1, "MotorTag.Buff", null, null, null);
						}
					}
				}
				return;
			}
		}
	}

	// Token: 0x0601A1A6 RID: 106918 RVA: 0x0080E534 File Offset: 0x0080C734
	protected override bool OnStart()
	{
		base.OnStart();
		this.BaseActorComp = base.Entity.GetComponent<BaseActorComponent>();
		this.VehicleActorComp = base.Entity.GetComponent<VehicleActorComponent>();
		this.PerformComp = base.Entity.GetComponent<BaseVehiclePerformComponent>();
		this.VehicleBuffComp = base.Entity.GetComponent<VehicleBuffComponent>();
		EventSystem.Instance.AddWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenEntered, new Action<VehiclePassengerInfo, bool>(this.OnEnterVehicle));
		EventSystem.Instance.AddWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenLeaved, new Action<VehiclePassengerInfo, bool>(this.OnLeaveVehicle));
		return true;
	}

	// Token: 0x0601A1A7 RID: 106919 RVA: 0x0080E5D4 File Offset: 0x0080C7D4
	protected override void OnActivate()
	{
		base.OnActivate();
		BaseVehiclePerformComponent performComp = this.PerformComp;
		Dictionary<int, int[]> dictionary;
		if (performComp == null)
		{
			dictionary = null;
		}
		else
		{
			VehicleConfig config = performComp.Config;
			dictionary = ((config != null) ? config.VehicleToDriverTagMap : null);
		}
		Dictionary<int, int[]> dictionary2 = dictionary;
		if (dictionary2 != null)
		{
			foreach (KeyValuePair<int, int[]> keyValuePair in dictionary2)
			{
				int num;
				int[] array;
				keyValuePair.Deconstruct(out num, out array);
				int num2 = num;
				if (!this.ListenedTags.Contains(num2))
				{
					base.AddTagAddOrRemoveListener(num2, new BaseTagComponent.TTagSwitchedCallback(this.VehicleTagChanged), null);
					this.ListenedTags.Add(num2);
				}
			}
		}
		BaseVehiclePerformComponent performComp2 = this.PerformComp;
		Dictionary<int, long[]> dictionary3;
		if (performComp2 == null)
		{
			dictionary3 = null;
		}
		else
		{
			VehicleConfig config2 = performComp2.Config;
			dictionary3 = ((config2 != null) ? config2.VehicleToDriverBuffMap : null);
		}
		Dictionary<int, long[]> dictionary4 = dictionary3;
		if (dictionary4 != null)
		{
			foreach (KeyValuePair<int, long[]> keyValuePair2 in dictionary4)
			{
				int num;
				long[] array2;
				keyValuePair2.Deconstruct(out num, out array2);
				int num3 = num;
				if (!this.ListenedTags.Contains(num3))
				{
					base.AddTagAddOrRemoveListener(num3, new BaseTagComponent.TTagSwitchedCallback(this.VehicleTagChanged), null);
					this.ListenedTags.Add(num3);
				}
			}
		}
		foreach (int tagId in this.ListenedTags)
		{
			if (this.HasTag(tagId))
			{
				this.VehicleTagChanged(tagId, true);
			}
		}
	}

	// Token: 0x0601A1A8 RID: 106920 RVA: 0x0080E76C File Offset: 0x0080C96C
	protected override bool OnEnd()
	{
		foreach (int tagId in this.ListenedTags)
		{
			base.RemoveTagAddOrRemoveListener(tagId, new BaseTagComponent.TTagSwitchedCallback(this.VehicleTagChanged));
		}
		this.ListenedTags.Clear();
		BaseVehiclePerformComponent performComp = this.PerformComp;
		BaseTagComponent baseTagComponent;
		if (performComp == null)
		{
			baseTagComponent = null;
		}
		else
		{
			Entity driver = performComp.Driver;
			baseTagComponent = ((driver != null) ? driver.GetComponent<BaseTagComponent>() : null);
		}
		BaseTagComponent baseTagComponent2 = baseTagComponent;
		if (baseTagComponent2 != null)
		{
			foreach (int tagId2 in this.DriverListenTags)
			{
				baseTagComponent2.RemoveTagAddOrRemoveListener(tagId2, new BaseTagComponent.TTagSwitchedCallback(this.DriverTagChanged));
			}
		}
		this.DriverListenTags.Clear();
		foreach (Entity passengerEntity in this.PassengerTagMap.Keys)
		{
			this.RemoveAllTagsForPassenger(passengerEntity);
		}
		base.OnEnd();
		EventSystem.Instance.RemoveWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenEntered, new Action<VehiclePassengerInfo, bool>(this.OnEnterVehicle));
		EventSystem.Instance.RemoveWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenLeaved, new Action<VehiclePassengerInfo, bool>(this.OnLeaveVehicle));
		return true;
	}

	// Token: 0x0601A1A9 RID: 106921 RVA: 0x0080E8E8 File Offset: 0x0080CAE8
	protected override bool OnClear()
	{
		base.OnClear();
		return true;
	}

	// Token: 0x0601A1AA RID: 106922 RVA: 0x0080E8F4 File Offset: 0x0080CAF4
	protected unsafe void OnEnterVehicle(VehiclePassengerInfo info, bool byChangeRole)
	{
		if (info.PassengerEntity == null)
		{
			return;
		}
		this.ListenDriverTagChange(info);
		if (this.PassengerTagMap.ContainsKey(info.PassengerEntity))
		{
			CreatureDataComponent component = info.PassengerEntity.GetComponent<CreatureDataComponent>();
			int? num = (component != null) ? new int?(component.GetPbDataId()) : null;
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "上次离开载具时Tag未清理";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "VehiclePbDataId";
			BaseActorComponent baseActorComp = this.BaseActorComp;
			ptr = new ValueTuple<string, object>(item, (baseActorComp != null) ? new int?(baseActorComp.CreatureData.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PassengerId", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Tags", this.PassengerTagMap[info.PassengerEntity]);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.RemoveAllTagsForPassenger(info.PassengerEntity);
			return;
		}
		if (this.PassengerTagMap.Count == 0)
		{
			this.AddEnterVehicleTagsForVehicle();
		}
		this.PassengerTagMap[info.PassengerEntity] = new HashSet<int>();
		this.AddEnterVehicleTagsForPassenger(info.PassengerEntity);
		int seat = info.Seat;
		BaseVehiclePerformComponent performComp = this.PerformComp;
		int? num2 = (performComp != null) ? new int?(performComp.DriverSeat) : null;
		if (seat == num2.GetValueOrDefault() & num2 != null)
		{
			BaseTagComponent component2 = info.PassengerEntity.GetComponent<BaseTagComponent>();
			if (component2 != null)
			{
				foreach (KeyValuePair<int, int[]> keyValuePair in this.VehicleToDriverTagIdMap)
				{
					int i;
					int[] array;
					keyValuePair.Deconstruct(out i, out array);
					int tagId = i;
					int[] array2 = array;
					if (this.HasTag(tagId))
					{
						foreach (int value in array2)
						{
							component2.AddTag(new int?(value));
						}
					}
					else
					{
						foreach (int value2 in array2)
						{
							component2.RemoveTag(new int?(value2));
						}
					}
				}
			}
			BaseBuffComponent component3 = info.PassengerEntity.GetComponent<BaseBuffComponent>();
			if (component3 != null)
			{
				foreach (KeyValuePair<int, long[]> keyValuePair2 in this.VehicleToDriverBuffIdMap)
				{
					int i;
					long[] array3;
					keyValuePair2.Deconstruct(out i, out array3);
					int tagId2 = i;
					long[] array4 = array3;
					if (this.HasTag(tagId2))
					{
						foreach (long num3 in array4)
						{
							BaseBuffComponent baseBuffComponent = component3;
							long buffId = num3;
							AddBuffParam addBuffParam = new AddBuffParam();
							addBuffParam.InstigatorId = this.BaseActorComp.CreatureData.GetCreatureDataId();
							VehicleBuffComponent vehicleBuffComp = this.VehicleBuffComp;
							addBuffParam.PreMessageId = ((vehicleBuffComp != null) ? new long?(vehicleBuffComp.MotorContextId) : null);
							addBuffParam.Reason = "MotorTag.Buff";
							baseBuffComponent.AddBuff(buffId, addBuffParam);
						}
					}
					else
					{
						foreach (long buffId2 in array4)
						{
							component3.RemoveBuff(buffId2, -1, "MotorTag.Buff", null, null, null);
						}
					}
				}
			}
		}
	}

	// Token: 0x0601A1AB RID: 106923 RVA: 0x0080EC7C File Offset: 0x0080CE7C
	protected void OnLeaveVehicle(VehiclePassengerInfo info, bool byChangeRole)
	{
		if (info.PassengerEntity == null)
		{
			return;
		}
		this.RemoveListenDriverTagChange(info);
		int seat = info.Seat;
		BaseVehiclePerformComponent performComp = this.PerformComp;
		int? num = (performComp != null) ? new int?(performComp.DriverSeat) : null;
		if (seat == num.GetValueOrDefault() & num != null)
		{
			BaseTagComponent component = info.PassengerEntity.GetComponent<BaseTagComponent>();
			if (component != null)
			{
				foreach (KeyValuePair<int, int[]> keyValuePair in this.VehicleToDriverTagIdMap)
				{
					int i;
					int[] array;
					keyValuePair.Deconstruct(out i, out array);
					foreach (int value in array)
					{
						component.RemoveTag(new int?(value));
					}
				}
			}
			BaseBuffComponent component2 = info.PassengerEntity.GetComponent<BaseBuffComponent>();
			if (component2 != null)
			{
				foreach (KeyValuePair<int, long[]> keyValuePair2 in this.VehicleToDriverBuffIdMap)
				{
					int i;
					long[] array2;
					keyValuePair2.Deconstruct(out i, out array2);
					foreach (long buffId in array2)
					{
						component2.RemoveBuff(buffId, -1, "MotorTag.Buff", null, null, null);
					}
				}
			}
		}
		this.RemoveAllTagsForPassenger(info.PassengerEntity);
		if (this.PassengerTagMap.Count == 0)
		{
			this.RemoveEnterVehicleTagsForVehicle();
		}
	}

	// Token: 0x0601A1AC RID: 106924 RVA: 0x0080EE20 File Offset: 0x0080D020
	protected void AddEnterVehicleTagsForPassenger(Entity passengerEntity)
	{
		BaseVehiclePerformComponent performComp = this.PerformComp;
		if (((performComp != null) ? performComp.Config : null) == null)
		{
			return;
		}
		foreach (int tagId in this.PerformComp.Config.PassengerEnterTags)
		{
			this.AddTagForPassenger(passengerEntity, ETagChannel.Common, tagId);
		}
	}

	// Token: 0x0601A1AD RID: 106925 RVA: 0x0080EE94 File Offset: 0x0080D094
	protected void AddEnterVehicleTagsForVehicle()
	{
		BaseVehiclePerformComponent performComp = this.PerformComp;
		if (((performComp != null) ? performComp.Config : null) == null || this.PerformComp.PassengerInfoMap.Count != 1)
		{
			return;
		}
		foreach (int value in this.PerformComp.Config.VehicleEnterTags)
		{
			this.AddTag(new int?(value));
		}
	}

	// Token: 0x0601A1AE RID: 106926 RVA: 0x0080EF20 File Offset: 0x0080D120
	protected void RemoveEnterVehicleTagsForVehicle()
	{
		BaseVehiclePerformComponent performComp = this.PerformComp;
		if (((performComp != null) ? performComp.Config : null) == null || this.PerformComp.PassengerInfoMap.Count != 1)
		{
			return;
		}
		foreach (int value in this.PerformComp.Config.VehicleEnterTags)
		{
			this.RemoveTag(new int?(value));
		}
	}

	// Token: 0x0601A1AF RID: 106927 RVA: 0x0080EFAC File Offset: 0x0080D1AC
	public void AddTagForPassenger(Entity passengerEntity, ETagChannel tagChannel, int tagId)
	{
		if (!passengerEntity || !this.PassengerTagMap.ContainsKey(passengerEntity))
		{
			return;
		}
		BaseTagComponent component = passengerEntity.GetComponent<BaseTagComponent>();
		if (component != null)
		{
			component.TagContainer.AddExactTag(tagChannel, tagId);
		}
		this.PassengerTagMap[passengerEntity].Add(tagId);
	}

	// Token: 0x0601A1B0 RID: 106928 RVA: 0x0080EFFC File Offset: 0x0080D1FC
	public void RemoveTagForPassenger(Entity passengerEntity, ETagChannel tagChannel, int tagId)
	{
		if (!passengerEntity)
		{
			return;
		}
		HashSet<int> valueOrDefault = this.PassengerTagMap.GetValueOrDefault(passengerEntity);
		if (valueOrDefault == null || !valueOrDefault.Contains(tagId))
		{
			return;
		}
		BaseTagComponent component = passengerEntity.GetComponent<BaseTagComponent>();
		if (component != null)
		{
			component.TagContainer.RemoveExactTag(tagChannel, tagId);
		}
		this.PassengerTagMap[passengerEntity].Remove(tagId);
	}

	// Token: 0x0601A1B1 RID: 106929 RVA: 0x0080F058 File Offset: 0x0080D258
	protected void RemoveAllTagsForPassenger(Entity passengerEntity)
	{
		if (!passengerEntity)
		{
			this.PassengerTagMap.Remove(passengerEntity);
			return;
		}
		BaseTagComponent component = passengerEntity.GetComponent<BaseTagComponent>();
		HashSet<int> valueOrDefault = this.PassengerTagMap.GetValueOrDefault(passengerEntity);
		if (valueOrDefault == null || component == null)
		{
			return;
		}
		foreach (int value in valueOrDefault)
		{
			component.RemoveTag(new int?(value));
		}
		this.PassengerTagMap.Remove(passengerEntity);
	}

	// Token: 0x0601A1B2 RID: 106930 RVA: 0x0080F0EC File Offset: 0x0080D2EC
	protected void ListenDriverTagChange(VehiclePassengerInfo info)
	{
		if (!info.IsDriver || info.PassengerEntity == null)
		{
			return;
		}
		BaseTagComponent component = info.PassengerEntity.GetComponent<BaseTagComponent>();
		if (component == null)
		{
			return;
		}
		BaseVehiclePerformComponent performComp = this.PerformComp;
		Dictionary<int, int[]> dictionary;
		if (performComp == null)
		{
			dictionary = null;
		}
		else
		{
			VehicleConfig config = performComp.Config;
			dictionary = ((config != null) ? config.DriverToVehicleTagMap : null);
		}
		Dictionary<int, int[]> dictionary2 = dictionary;
		if (dictionary2 != null)
		{
			foreach (KeyValuePair<int, int[]> keyValuePair in dictionary2)
			{
				int i;
				int[] array;
				keyValuePair.Deconstruct(out i, out array);
				int num = i;
				int[] array2 = array;
				if (!this.DriverListenTags.Contains(num))
				{
					component.AddTagAddOrRemoveListener(num, new BaseTagComponent.TTagSwitchedCallback(this.DriverTagChanged), null);
					this.DriverListenTags.Add(num);
				}
				if (component.HasTag(num))
				{
					foreach (int value in array2)
					{
						this.AddTag(new int?(value));
					}
				}
			}
		}
	}

	// Token: 0x0601A1B3 RID: 106931 RVA: 0x0080F1F4 File Offset: 0x0080D3F4
	protected void RemoveListenDriverTagChange(VehiclePassengerInfo info)
	{
		if (!info.IsDriver || info.PassengerEntity == null)
		{
			return;
		}
		BaseTagComponent component = info.PassengerEntity.GetComponent<BaseTagComponent>();
		if (component == null)
		{
			return;
		}
		BaseVehiclePerformComponent performComp = this.PerformComp;
		Dictionary<int, int[]> dictionary;
		if (performComp == null)
		{
			dictionary = null;
		}
		else
		{
			VehicleConfig config = performComp.Config;
			dictionary = ((config != null) ? config.DriverToVehicleTagMap : null);
		}
		Dictionary<int, int[]> dictionary2 = dictionary;
		if (dictionary2 != null)
		{
			foreach (KeyValuePair<int, int[]> keyValuePair in dictionary2)
			{
				int i;
				int[] array;
				keyValuePair.Deconstruct(out i, out array);
				int num = i;
				int[] array2 = array;
				if (this.DriverListenTags.Contains(num))
				{
					component.RemoveTagAddOrRemoveListener(num, new BaseTagComponent.TTagSwitchedCallback(this.DriverTagChanged));
					this.DriverListenTags.Remove(num);
				}
				foreach (int value in array2)
				{
					this.RemoveTag(new int?(value));
				}
			}
		}
	}

	// Token: 0x0601A1B4 RID: 106932 RVA: 0x0080F2EC File Offset: 0x0080D4EC
	protected unsafe void DriverTagChanged(int tagId, bool tagExist)
	{
		BaseVehiclePerformComponent performComp = this.PerformComp;
		if (((performComp != null) ? performComp.Driver : null) == null)
		{
			return;
		}
		if (this.DriverListenLoopLock == (long)Time.Instance.Frame)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.TZQ;
			string message = "在驾驶员传递Tag到载具tag循环";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("tagId", tagId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("tagExist", tagExist);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return;
		}
		this.DriverListenLoopLock = (long)Time.Instance.Frame;
		int[] valueOrDefault = this.DriverToVehicleTagIdMap.GetValueOrDefault(tagId);
		if (valueOrDefault != null)
		{
			if (tagExist)
			{
				foreach (int value in valueOrDefault)
				{
					this.AddTag(new int?(value));
				}
			}
			else
			{
				foreach (int value2 in valueOrDefault)
				{
					this.RemoveTag(new int?(value2));
				}
			}
		}
		this.DriverListenLoopLock = -1L;
	}

	// Token: 0x0601A1B5 RID: 106933 RVA: 0x0080F3F8 File Offset: 0x0080D5F8
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		VehicleTagComponent vehicleTagComponent = (VehicleTagComponent)componentTemplate;
		if (vehicleTagComponent.BaseActorComp == null)
		{
			this.BaseActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BaseActorComp), "BaseActorComp"))
		{
			return false;
		}
		if (vehicleTagComponent.VehicleActorComp == null)
		{
			this.VehicleActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VehicleActorComp), "VehicleActorComp"))
		{
			return false;
		}
		if (vehicleTagComponent.PerformComp == null)
		{
			this.PerformComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PerformComp), "PerformComp"))
		{
			return false;
		}
		if (vehicleTagComponent.VehicleBuffComp == null)
		{
			this.VehicleBuffComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VehicleBuffComp), "VehicleBuffComp"))
		{
			return false;
		}
		if (vehicleTagComponent.PassengerTagMap == null)
		{
			this.PassengerTagMap = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PassengerTagMap), "PassengerTagMap"))
		{
			return false;
		}
		if (vehicleTagComponent.ListenedTags == null)
		{
			this.ListenedTags = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.ListenedTags), "ListenedTags"))
		{
			return false;
		}
		if (vehicleTagComponent.DriverListenTags == null)
		{
			this.DriverListenTags = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<int>(this.DriverListenTags), "DriverListenTags"))
		{
			return false;
		}
		this.DriverListenLoopLock = vehicleTagComponent.DriverListenLoopLock;
		return true;
	}

	// Token: 0x17002A89 RID: 10889
	// (get) Token: 0x0601A1B6 RID: 106934 RVA: 0x0080F551 File Offset: 0x0080D751
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A8A RID: 10890
	// (get) Token: 0x0601A1B7 RID: 106935 RVA: 0x0080F554 File Offset: 0x0080D754
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A8B RID: 10891
	// (get) Token: 0x0601A1B8 RID: 106936 RVA: 0x0080F557 File Offset: 0x0080D757
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A8C RID: 10892
	// (get) Token: 0x0601A1B9 RID: 106937 RVA: 0x0080F55A File Offset: 0x0080D75A
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A8D RID: 10893
	// (get) Token: 0x0601A1BA RID: 106938 RVA: 0x0080F55D File Offset: 0x0080D75D
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E501 RID: 58625
	[Nullable(2)]
	protected BaseActorComponent BaseActorComp;

	// Token: 0x0400E502 RID: 58626
	[Nullable(2)]
	protected VehicleActorComponent VehicleActorComp;

	// Token: 0x0400E503 RID: 58627
	[Nullable(2)]
	protected BaseVehiclePerformComponent PerformComp;

	// Token: 0x0400E504 RID: 58628
	[Nullable(2)]
	protected VehicleBuffComponent VehicleBuffComp;

	// Token: 0x0400E505 RID: 58629
	protected Dictionary<Entity, HashSet<int>> PassengerTagMap = new Dictionary<Entity, HashSet<int>>();

	// Token: 0x0400E506 RID: 58630
	protected HashSet<int> ListenedTags = new HashSet<int>();

	// Token: 0x0400E507 RID: 58631
	protected HashSet<int> DriverListenTags = new HashSet<int>();

	// Token: 0x0400E508 RID: 58632
	protected long DriverListenLoopLock = -1L;
}
