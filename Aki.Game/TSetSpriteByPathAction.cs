using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020022D1 RID: 8913
// (Invoke) Token: 0x06016035 RID: 90165
public delegate void TSetSpriteByPathAction(string path, UUISprite uiSprite, bool setSize, EUiViewName? syncLoadViewName = null, [Nullable(2)] Action<bool> callback = null);
