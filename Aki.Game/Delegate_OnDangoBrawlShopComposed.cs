using System;
using CSharpScript.Game.Module.Activity.ActivityContent.DangoBrawl;

// Token: 0x02000D88 RID: 3464
// (Invoke) Token: 0x06005280 RID: 21120
[EventRule(EEventName.OnDangoBrawlShopComposed)]
internal delegate void Delegate_OnDangoBrawlShopComposed(int mainUid, int uid, int configId, bool toBench, int[] sourceUids, EDragSourceKind[] sourceKinds);
