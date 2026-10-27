using System;
using Aki.Protocol;

// Token: 0x020002FB RID: 763
// (Invoke) Token: 0x0600284C RID: 10316
[EventRule(EEventName.CharOnEnergyChanged)]
internal delegate void Delegate_CharOnEnergyChanged(EAttributeType attr, float newValue, float oldValue);
