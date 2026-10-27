using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042D9 RID: 17113
	public class TItemVariableUnion
	{
		// Token: 0x17007948 RID: 31048
		// (get) Token: 0x06019617 RID: 103959 RVA: 0x003A4190 File Offset: 0x003A2390
		// (set) Token: 0x06019618 RID: 103960 RVA: 0x003A4198 File Offset: 0x003A2398
		public TItemVariable Type { get; set; }

		// Token: 0x17007949 RID: 31049
		// (get) Token: 0x06019619 RID: 103961 RVA: 0x003A41A1 File Offset: 0x003A23A1
		// (set) Token: 0x0601961A RID: 103962 RVA: 0x003A41A9 File Offset: 0x003A23A9
		public object Value { get; set; }

		// Token: 0x0601961B RID: 103963 RVA: 0x003A41B2 File Offset: 0x003A23B2
		public TItemVariableUnion()
		{
			this.Type = TItemVariable.NONE;
			this.Value = null;
		}

		// Token: 0x0601961C RID: 103964 RVA: 0x003A41C8 File Offset: 0x003A23C8
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601961D RID: 103965 RVA: 0x003A41DA File Offset: 0x003A23DA
		public IItemIdVariableT AsIItemIdVariable()
		{
			return this.As<IItemIdVariableT>();
		}

		// Token: 0x0601961E RID: 103966 RVA: 0x003A41E2 File Offset: 0x003A23E2
		public static TItemVariableUnion FromIItemIdVariable(IItemIdVariableT _iitemidvariable)
		{
			return new TItemVariableUnion
			{
				Type = TItemVariable.IItemIdVariable,
				Value = _iitemidvariable
			};
		}

		// Token: 0x0601961F RID: 103967 RVA: 0x003A41F7 File Offset: 0x003A23F7
		public IItemTypeVariableT AsIItemTypeVariable()
		{
			return this.As<IItemTypeVariableT>();
		}

		// Token: 0x06019620 RID: 103968 RVA: 0x003A41FF File Offset: 0x003A23FF
		public static TItemVariableUnion FromIItemTypeVariable(IItemTypeVariableT _iitemtypevariable)
		{
			return new TItemVariableUnion
			{
				Type = TItemVariable.IItemTypeVariable,
				Value = _iitemtypevariable
			};
		}

		// Token: 0x06019621 RID: 103969 RVA: 0x003A4214 File Offset: 0x003A2414
		public static int Pack(FlatBufferBuilder builder, TItemVariableUnion _o)
		{
			TItemVariable type = _o.Type;
			if (type == TItemVariable.IItemIdVariable)
			{
				return IItemIdVariable.Pack(builder, _o.AsIItemIdVariable()).Value;
			}
			if (type != TItemVariable.IItemTypeVariable)
			{
				return 0;
			}
			return IItemTypeVariable.Pack(builder, _o.AsIItemTypeVariable()).Value;
		}
	}
}
