using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001A95 RID: 6805
public class PhotoOptionPart : IPhotoSnapshotPart
{
	// Token: 0x06010D37 RID: 68919 RVA: 0x004EF4A8 File Offset: 0x004ED6A8
	public void Capture()
	{
		this.SetUpValueMap.Clear();
		foreach (KeyValuePair<EPhotoSetupValueType, float> keyValuePair in PhotographModel.Instance.GetAllPhotographOption())
		{
			if (!PhotographController.Instance.IsLocalStorageSetup(keyValuePair.Key))
			{
				this.SetUpValueMap[keyValuePair.Key] = keyValuePair.Value;
			}
		}
	}

	// Token: 0x06010D38 RID: 68920 RVA: 0x004EF52C File Offset: 0x004ED72C
	public float? TryGetValue(EPhotoSetupValueType valueType)
	{
		float value;
		if (!this.SetUpValueMap.TryGetValue(valueType, out value))
		{
			return null;
		}
		return new float?(value);
	}

	// Token: 0x06010D39 RID: 68921 RVA: 0x004EF559 File Offset: 0x004ED759
	public void Apply()
	{
	}

	// Token: 0x040094BE RID: 38078
	[Nullable(1)]
	public readonly Dictionary<EPhotoSetupValueType, float> SetUpValueMap = new Dictionary<EPhotoSetupValueType, float>();
}
