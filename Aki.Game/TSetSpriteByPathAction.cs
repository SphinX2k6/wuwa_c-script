using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02002D77 RID: 11639
// (Invoke) Token: 0x06018793 RID: 100243
public delegate void TSetSpriteByPathAction(string path, UUISprite uiSprite, bool setSize, EUiViewName? syncLoadViewName = null, [Nullable(2)] Action<bool> callback = null);
