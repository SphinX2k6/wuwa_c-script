using System;
using Aki.Protocol;
using CSharpScript.Game.Module.Roguelike;

// Token: 0x020008A7 RID: 2215
// (Invoke) Token: 0x06003EFC RID: 16124
[EventRule(EEventName.RoguelikeChooseDataResult)]
internal delegate void Delegate_RoguelikeChooseDataResult(CSharpScript.Game.Module.Roguelike.RogueGainEntry newRogueGainEntry, CSharpScript.Game.Module.Roguelike.RogueGainEntry oldRogueGainEntry, bool isSuccess, int bindId, RoguelikeChooseDataResultResponse response);
