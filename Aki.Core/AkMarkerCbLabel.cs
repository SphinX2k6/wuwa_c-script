using System;
using System.Text.Json.Serialization;

// Token: 0x02000011 RID: 17
[JsonPolymorphic(TypeDiscriminatorPropertyName = "MarkerType")]
[JsonDerivedType(typeof(AkMarkerCbLabelSoundTrackEffect), "SoundTrackingEffectNotify")]
public class AkMarkerCbLabel
{
}
