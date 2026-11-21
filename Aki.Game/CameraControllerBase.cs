using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Core.Common;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020001FD RID: 509
[NullableContext(1)]
[Nullable(0)]
[GeneratePropertyAccessMethod(true, true, null)]
public abstract class CameraControllerBase : ICameraControllerBase
{
	// Token: 0x06002073 RID: 8307 RVA: 0x000AAAA0 File Offset: 0x000A8CA0
	protected CameraControllerBase(FightCameraLogicComponent camera)
	{
		this.Camera = camera;
		this.OnInit();
	}

	// Token: 0x1700051F RID: 1311
	// (get) Token: 0x06002074 RID: 8308 RVA: 0x000AAB2A File Offset: 0x000A8D2A
	[Nullable(2)]
	protected CameraModelInstance CameraModel
	{
		[NullableContext(2)]
		get
		{
			return this.Camera.CameraModel;
		}
	}

	// Token: 0x06002075 RID: 8309 RVA: 0x000AAB38 File Offset: 0x000A8D38
	protected void SetConfigMap(Enum key, string value)
	{
		int key2 = Convert.ToInt32(key);
		if (this.ConfigMap.ContainsKey(key2))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "重复注册了Key";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Key", key);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		if (this.DebugValueSet.Contains(value))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Camera;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "重复注册了Value";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("value", value);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		this.ConfigMap[key2] = value;
		this.DebugValueSet.Add(value);
	}

	// Token: 0x06002076 RID: 8310 RVA: 0x000AABD0 File Offset: 0x000A8DD0
	protected void SetCurveConfigMap(Enum key, string value)
	{
		int key2 = Convert.ToInt32(key);
		if (this.CurveConfigMap.ContainsKey(key2))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Camera;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "重复注册了Key";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Key", key);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		if (this.DebugValueSet.Contains(value))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Camera;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "重复注册了Value";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("value", value);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
		}
		this.CurveConfigMap[key2] = value;
		this.DebugValueSet.Add(value);
	}

	// Token: 0x06002077 RID: 8311 RVA: 0x000AAC66 File Offset: 0x000A8E66
	private void SetConfigValue(string k, double value)
	{
		this.SetMember(k, value);
	}

	// Token: 0x06002078 RID: 8312 RVA: 0x000AAC75 File Offset: 0x000A8E75
	private void SetCurveConfigValue(string k, CurveBase value)
	{
		this.SetMember(k, value);
	}

	// Token: 0x06002079 RID: 8313 RVA: 0x000AAC80 File Offset: 0x000A8E80
	[NullableContext(0)]
	public void SetDefaultConfigs<TEnum>([Nullable(new byte[]
	{
		1,
		0,
		0
	})] TMap<TEnumAsByte<TEnum>, float> config, [Nullable(new byte[]
	{
		1,
		0,
		0,
		1
	})] TMap<TEnumAsByte<TEnum>, SBaseCurve> curveConfig) where TEnum : struct, Enum
	{
		foreach (KeyValuePair<TEnumAsByte<TEnum>, float> keyValuePair in config)
		{
			TEnumAsByte<TEnum> tenumAsByte;
			float num;
			keyValuePair.Deconstruct(out tenumAsByte, out num);
			TEnumAsByte<TEnum> value = tenumAsByte;
			float value2 = num;
			this.DefaultConfigs[Convert.ToInt32(value)] = value2;
		}
		foreach (KeyValuePair<TEnumAsByte<TEnum>, SBaseCurve> keyValuePair2 in curveConfig)
		{
			TEnumAsByte<TEnum> tenumAsByte;
			SBaseCurve sbaseCurve;
			keyValuePair2.Deconstruct(out tenumAsByte, out sbaseCurve);
			TEnumAsByte<TEnum> value3 = tenumAsByte;
			SBaseCurve curveStruct = sbaseCurve;
			this.DefaultCurveConfigs[Convert.ToInt32(value3)] = CurveUtils.CreateCurveByStruct(curveStruct);
		}
	}

	// Token: 0x0600207A RID: 8314 RVA: 0x000AAD64 File Offset: 0x000A8F64
	public unsafe virtual void SetConfigsCore(Dictionary<int, float> config, Dictionary<int, CurveBase> curveConfig)
	{
		foreach (KeyValuePair<int, float> keyValuePair in config)
		{
			int num;
			float num2;
			keyValuePair.Deconstruct(out num, out num2);
			int key = num;
			float num3 = num2;
			string k;
			if (this.ConfigMap.TryGetValue(key, out k))
			{
				this.SetConfigValue(k, (double)num3);
			}
		}
		foreach (KeyValuePair<int, string> keyValuePair2 in this.ConfigMap)
		{
			int num;
			string text;
			keyValuePair2.Deconstruct(out num, out text);
			int num4 = num;
			string text2 = text;
			object obj;
			if (!this.TryGetMember(text2, out obj))
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.LCZ;
				string message = "CameraController缺少配置";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CameraType", base.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("key", num4);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("value", text2);
				instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
				this.SetConfigValue(text2, 1.0);
			}
		}
		foreach (KeyValuePair<int, CurveBase> keyValuePair3 in curveConfig)
		{
			int num;
			CurveBase curveBase;
			keyValuePair3.Deconstruct(out num, out curveBase);
			int key2 = num;
			CurveBase value = curveBase;
			string k2;
			if (this.CurveConfigMap.TryGetValue(key2, out k2))
			{
				this.SetCurveConfigValue(k2, value);
			}
		}
		foreach (KeyValuePair<int, string> keyValuePair2 in this.CurveConfigMap)
		{
			int num;
			string text;
			keyValuePair2.Deconstruct(out num, out text);
			int num5 = num;
			string text3 = text;
			object obj;
			if (!this.TryGetMember(text3, out obj))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Camera;
				ELogAuthor author2 = ELogAuthor.LCZ;
				string message2 = "CameraController缺少曲线配置";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CameraType", base.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("key", num5);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("value", text3);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
				this.SetCurveConfigValue(text3, CurveUtils.CreateCurve(ECurveType.Linear, Array.Empty<float>()));
			}
		}
		this.PostProcessConfig(config, curveConfig);
	}

	// Token: 0x0600207B RID: 8315 RVA: 0x000AB02C File Offset: 0x000A922C
	public void ResetDefaultConfig()
	{
		this.SetConfigsCore(this.DefaultConfigs, this.DefaultCurveConfigs);
	}

	// Token: 0x0600207C RID: 8316 RVA: 0x000AB040 File Offset: 0x000A9240
	public virtual void OnStart()
	{
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
	}

	// Token: 0x0600207D RID: 8317 RVA: 0x000AB05F File Offset: 0x000A925F
	public virtual void OnEnd()
	{
		EventSystem.Instance.Remove<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
	}

	// Token: 0x0600207E RID: 8318 RVA: 0x000AB07E File Offset: 0x000A927E
	protected virtual void OnInit()
	{
	}

	// Token: 0x0600207F RID: 8319 RVA: 0x000AB080 File Offset: 0x000A9280
	protected virtual void OnEnable()
	{
	}

	// Token: 0x06002080 RID: 8320 RVA: 0x000AB082 File Offset: 0x000A9282
	protected virtual void OnDisable()
	{
	}

	// Token: 0x06002081 RID: 8321 RVA: 0x000AB084 File Offset: 0x000A9284
	protected virtual bool UpdateCustomEnableCondition()
	{
		return true;
	}

	// Token: 0x06002082 RID: 8322 RVA: 0x000AB087 File Offset: 0x000A9287
	protected virtual void UpdateInternal(float deltaTime)
	{
	}

	// Token: 0x06002083 RID: 8323 RVA: 0x000AB089 File Offset: 0x000A9289
	protected virtual void UpdateDeactivateInternal(float deltaTime)
	{
	}

	// Token: 0x06002084 RID: 8324 RVA: 0x000AB08B File Offset: 0x000A928B
	protected virtual void OnChangeRole(EntityHandle newEntity, [Nullable(2)] EntityHandle oldEntity)
	{
	}

	// Token: 0x06002085 RID: 8325
	public abstract string Name();

	// Token: 0x06002086 RID: 8326 RVA: 0x000AB090 File Offset: 0x000A9290
	public void Lock(object control)
	{
		bool isActivate = this.IsActivate;
		this.BlockSet.Add(control);
		if (!this.IsActivate && isActivate)
		{
			this.OnDisable();
		}
	}

	// Token: 0x06002087 RID: 8327 RVA: 0x000AB0C4 File Offset: 0x000A92C4
	public void Unlock(object control)
	{
		bool isActivate = this.IsActivate;
		this.BlockSet.Remove(control);
		if (this.IsActivate && !isActivate)
		{
			this.OnEnable();
		}
	}

	// Token: 0x06002088 RID: 8328 RVA: 0x000AB0F8 File Offset: 0x000A92F8
	public void Update(float deltaTime)
	{
		bool isActivate = this.IsActivate;
		this.IsActivateInternal = this.UpdateCustomEnableCondition();
		if (this.IsActivate != isActivate)
		{
			if (this.IsActivate)
			{
				this.OnEnable();
			}
			else
			{
				this.OnDisable();
			}
		}
		if (this.IsActivate)
		{
			this.UpdateInternal(deltaTime);
			return;
		}
		this.UpdateDeactivateInternal(deltaTime);
	}

	// Token: 0x17000520 RID: 1312
	// (get) Token: 0x06002089 RID: 8329 RVA: 0x000AB14E File Offset: 0x000A934E
	public virtual bool IsActivate
	{
		get
		{
			return this.IsActivateInternal && this.BlockSet.Count == 0;
		}
	}

	// Token: 0x0600208A RID: 8330 RVA: 0x000AB168 File Offset: 0x000A9368
	public unsafe void ShowBlockSetInfo(string controllerName)
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Camera;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "[ShowCameraBlockSet]";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("controllerName", controllerName);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		foreach (object obj in this.BlockSet)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Camera;
			ELogAuthor author2 = ELogAuthor.LJM;
			string message2 = "[ShowCameraBlockSet]";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("elementName", obj.GetType().Name);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("controllerName", controllerName);
			instance2.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
	}

	// Token: 0x0600208B RID: 8331 RVA: 0x000AB238 File Offset: 0x000A9438
	public virtual string GetConfigMapValue(Enum key)
	{
		return this.GetConfigMapValue(Convert.ToInt32(key));
	}

	// Token: 0x0600208C RID: 8332 RVA: 0x000AB246 File Offset: 0x000A9446
	public virtual string GetConfigMapValue(int key)
	{
		return this.ConfigMap.GetValueOrDefault(key, "");
	}

	// Token: 0x0600208D RID: 8333 RVA: 0x000AB25C File Offset: 0x000A945C
	public bool GetPairConfigKey<[Nullable(0)] TKey>(TKey key, out TKey pairKey) where TKey : Enum
	{
		int value;
		if (this.PairConfigKeySet.TryGetValue(Convert.ToInt32(key), out value))
		{
			pairKey = (TKey)((object)Enum.ToObject(typeof(TKey), value));
			return true;
		}
		pairKey = default(TKey);
		return false;
	}

	// Token: 0x0600208E RID: 8334 RVA: 0x000AB2A8 File Offset: 0x000A94A8
	public bool GetPairConfigKey(int key, out int pairKey)
	{
		int num;
		if (this.PairConfigKeySet.TryGetValue(key, out num))
		{
			pairKey = num;
			return true;
		}
		pairKey = 0;
		return false;
	}

	// Token: 0x0600208F RID: 8335 RVA: 0x000AB2D0 File Offset: 0x000A94D0
	public virtual float GetConfigValue(string key)
	{
		object obj;
		if (!this.TryGetMember(key, out obj) || obj == null)
		{
			return 0f;
		}
		object obj2 = obj;
		float result;
		if (obj2 is float)
		{
			float num = (float)obj2;
			result = num;
		}
		else if (obj2 is double)
		{
			double num2 = (double)obj2;
			result = (float)num2;
		}
		else if (obj2 is int)
		{
			int num3 = (int)obj2;
			result = (float)num3;
		}
		else if (obj2 is long)
		{
			long num4 = (long)obj2;
			result = (float)num4;
		}
		else
		{
			IConvertible convertible = obj as IConvertible;
			if (convertible != null)
			{
				result = Convert.ToSingle(convertible);
			}
			else
			{
				result = 0f;
			}
		}
		return result;
	}

	// Token: 0x06002090 RID: 8336 RVA: 0x000AB37C File Offset: 0x000A957C
	public unsafe virtual void PostProcessConfig(Dictionary<int, float> config, Dictionary<int, CurveBase> curveConfig)
	{
		foreach (ValueTuple<int, int> valueTuple in this.PairKeyArray)
		{
			int item = valueTuple.Item1;
			int item2 = valueTuple.Item2;
			bool flag = config.ContainsKey(item);
			bool flag2 = config.ContainsKey(item2);
			if (flag && !flag2)
			{
				this.SetValueFromDefaultConfig(item2);
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Camera;
				ELogAuthor author = ELogAuthor.ZJL;
				string message = "相机上下限缺少配对项，已使用默认值自动补齐";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("CameraType", base.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("missingKey", this.GetConfigMapValue(item2));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("defaultValue", this.GetConfigValue(this.GetConfigMapValue(item2)));
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			}
			else if (!flag && flag2)
			{
				this.SetValueFromDefaultConfig(item);
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Camera;
				ELogAuthor author2 = ELogAuthor.ZJL;
				string message2 = "相机上下限缺少配对项，已使用默认值自动补齐";
				<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("CameraType", base.GetType().Name);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("missingKey", this.GetConfigMapValue(item));
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("defaultValue", this.GetConfigValue(this.GetConfigMapValue(item)));
				instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			}
			if (this.NeedValueCheckPairKeySet.Contains(item))
			{
				float configValue = this.GetConfigValue(this.GetConfigMapValue(item));
				float configValue2 = this.GetConfigValue(this.GetConfigMapValue(item2));
				if (configValue > configValue2 && (flag || flag2))
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Camera;
					ELogAuthor author3 = ELogAuthor.ZJL;
					string message3 = "相机配置值下限大于上限，检查配置是否有误(通常为第一个报错的配置项有误)";
					<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray3 = default(<>y__InlineArray5<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 0) = new ValueTuple<string, object>("CameraType", base.GetType().Name);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 1) = new ValueTuple<string, object>("key1", this.GetConfigMapValue(item));
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 2) = new ValueTuple<string, object>("key2", this.GetConfigMapValue(item2));
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 3) = new ValueTuple<string, object>("value1", configValue);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray3, 4) = new ValueTuple<string, object>("value2", configValue2);
					instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray3, 5));
				}
			}
		}
	}

	// Token: 0x06002091 RID: 8337 RVA: 0x000AB64C File Offset: 0x000A984C
	public void RegisterPairConfigKey(Enum key1, Enum key2, bool needCheckValue = true)
	{
		int num = Convert.ToInt32(key1);
		int num2 = Convert.ToInt32(key2);
		if (!this.PairConfigKeySet.ContainsKey(num) && !this.PairConfigKeySet.ContainsKey(num2))
		{
			this.PairKeyArray.Add(new ValueTuple<int, int>(num, num2));
		}
		this.PairConfigKeySet.TryAdd(num, num2);
		this.PairConfigKeySet.TryAdd(num2, num);
		if (needCheckValue)
		{
			this.NeedValueCheckPairKeySet.Add(num);
		}
	}

	// Token: 0x06002092 RID: 8338 RVA: 0x000AB6C1 File Offset: 0x000A98C1
	public void SetValueFromDefaultConfig(Enum key)
	{
		this.SetValueFromDefaultConfig(Convert.ToInt32(key));
	}

	// Token: 0x06002093 RID: 8339 RVA: 0x000AB6D0 File Offset: 0x000A98D0
	public void SetValueFromDefaultConfig(int intKey)
	{
		float num;
		if (this.DefaultConfigs.TryGetValue(intKey, out num))
		{
			string configMapValue = this.GetConfigMapValue(intKey);
			object obj;
			if (this.TryGetMember(configMapValue, out obj))
			{
				this.SetMember(configMapValue, num);
			}
		}
	}

	// Token: 0x06002094 RID: 8340 RVA: 0x000AB710 File Offset: 0x000A9910
	[NullableContext(0)]
	public virtual bool TryGetMember(string key, out object value)
	{
		if (key != null)
		{
			switch (key.Length)
			{
			case 6:
				if (key == "Camera")
				{
					value = this.Camera;
					return true;
				}
				break;
			case 8:
				if (key == "BlockSet")
				{
					value = this.BlockSet;
					return true;
				}
				break;
			case 9:
				if (key == "ConfigMap")
				{
					value = this.ConfigMap;
					return true;
				}
				break;
			case 10:
				if (key == "IsActivate")
				{
					value = this.IsActivate;
					return true;
				}
				break;
			case 11:
				if (key == "CameraModel")
				{
					value = this.CameraModel;
					return true;
				}
				break;
			case 12:
				if (key == "PairKeyArray")
				{
					value = this.PairKeyArray;
					return true;
				}
				break;
			case 13:
				if (key == "DebugValueSet")
				{
					value = this.DebugValueSet;
					return true;
				}
				break;
			case 14:
			{
				char c = key[0];
				if (c != 'C')
				{
					if (c == 'D')
					{
						if (key == "DefaultConfigs")
						{
							value = this.DefaultConfigs;
							return true;
						}
					}
				}
				else if (key == "CurveConfigMap")
				{
					value = this.CurveConfigMap;
					return true;
				}
				break;
			}
			case 16:
				if (key == "PairConfigKeySet")
				{
					value = this.PairConfigKeySet;
					return true;
				}
				break;
			case 18:
				if (key == "IsActivateInternal")
				{
					value = this.IsActivateInternal;
					return true;
				}
				break;
			case 19:
				if (key == "DefaultCurveConfigs")
				{
					value = this.DefaultCurveConfigs;
					return true;
				}
				break;
			case 24:
				if (key == "NeedValueCheckPairKeySet")
				{
					value = this.NeedValueCheckPairKeySet;
					return true;
				}
				break;
			}
		}
		value = null;
		return false;
	}

	// Token: 0x06002095 RID: 8341 RVA: 0x000AB93B File Offset: 0x000A9B3B
	[NullableContext(0)]
	public virtual void SetMember(string key, object value)
	{
		if (key == "IsActivateInternal")
		{
			this.IsActivateInternal = (bool)value;
			return;
		}
		throw new KeyNotFoundException("设置CameraControllerBase成员属性失败" + key + ")");
	}

	// Token: 0x06002096 RID: 8342 RVA: 0x000AB96C File Offset: 0x000A9B6C
	[NullableContext(0)]
	public virtual IEnumerable<ValueTuple<string, object>> MemberIter()
	{
		CameraControllerBase.<MemberIter>d__53 <MemberIter>d__ = new CameraControllerBase.<MemberIter>d__53(-2);
		<MemberIter>d__.<>4__this = this;
		return <MemberIter>d__;
	}

	// Token: 0x040013EB RID: 5099
	[StaticVariableRuleIgnore]
	private static readonly Stat UpdateCustomEnableConditionStat = Stat.Create("UpdateCustomEnableConditionStat", "", "");

	// Token: 0x040013EC RID: 5100
	[StaticVariableRuleIgnore]
	private static readonly Stat OnEnableStat = Stat.Create("OnEnableStat", "", "");

	// Token: 0x040013ED RID: 5101
	[StaticVariableRuleIgnore]
	private static readonly Stat OnDisableStat = Stat.Create("OnDisableStat", "", "");

	// Token: 0x040013EE RID: 5102
	[StaticVariableRuleIgnore]
	private static readonly Stat UpdateInternalStat = Stat.Create("UpdateInternalStat", "", "");

	// Token: 0x040013EF RID: 5103
	[StaticVariableRuleIgnore]
	private static readonly Stat UpdateDeactivateInternalStat = Stat.Create("UpdateDeactivateInternalStat", "", "");

	// Token: 0x040013F0 RID: 5104
	public readonly FightCameraLogicComponent Camera;

	// Token: 0x040013F1 RID: 5105
	private bool IsActivateInternal = true;

	// Token: 0x040013F2 RID: 5106
	private readonly HashSet<object> BlockSet = new HashSet<object>();

	// Token: 0x040013F3 RID: 5107
	private readonly Dictionary<int, float> DefaultConfigs = new Dictionary<int, float>();

	// Token: 0x040013F4 RID: 5108
	private readonly Dictionary<int, string> ConfigMap = new Dictionary<int, string>();

	// Token: 0x040013F5 RID: 5109
	private readonly Dictionary<int, CurveBase> DefaultCurveConfigs = new Dictionary<int, CurveBase>();

	// Token: 0x040013F6 RID: 5110
	private readonly Dictionary<int, string> CurveConfigMap = new Dictionary<int, string>();

	// Token: 0x040013F7 RID: 5111
	private readonly HashSet<string> DebugValueSet = new HashSet<string>();

	// Token: 0x040013F8 RID: 5112
	private readonly Dictionary<int, int> PairConfigKeySet = new Dictionary<int, int>();

	// Token: 0x040013F9 RID: 5113
	[Nullable(new byte[]
	{
		1,
		0
	})]
	private readonly List<ValueTuple<int, int>> PairKeyArray = new List<ValueTuple<int, int>>();

	// Token: 0x040013FA RID: 5114
	private readonly HashSet<int> NeedValueCheckPairKeySet = new HashSet<int>();
}
