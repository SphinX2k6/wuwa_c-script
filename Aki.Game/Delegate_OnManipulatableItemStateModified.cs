using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.NewWorld.SceneItem.Manipulate;

// Token: 0x0200067E RID: 1662
// (Invoke) Token: 0x06003658 RID: 13912
[EventRule(EEventName.OnManipulatableItemStateModified)]
internal delegate void Delegate_OnManipulatableItemStateModified(SceneItemManipulatableComponent.EManipulatableState oldStateEnum, SceneItemManipulatableComponent.EManipulatableState newStateEnum, [Nullable(1)] Entity entity, SceneItemManipulableBaseState oldState, SceneItemManipulableBaseState newState);
