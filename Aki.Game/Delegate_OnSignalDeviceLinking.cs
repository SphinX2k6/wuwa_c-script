using System;

// Token: 0x020008E6 RID: 2278
// (Invoke) Token: 0x06003FF8 RID: 16376
[EventRule(EEventName.OnSignalDeviceLinking)]
internal delegate void Delegate_OnSignalDeviceLinking(bool isAdd, int from, bool isFromDot, int to, bool isToDot);
