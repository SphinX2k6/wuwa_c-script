using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005465 RID: 21605
	public class IInteractPlayerDiractionType_UnionUnion
	{
		// Token: 0x17009F10 RID: 40720
		// (get) Token: 0x060238A7 RID: 145575 RVA: 0x004EA865 File Offset: 0x004E8A65
		// (set) Token: 0x060238A8 RID: 145576 RVA: 0x004EA86D File Offset: 0x004E8A6D
		public IInteractPlayerDiractionType_Union Type { get; set; }

		// Token: 0x17009F11 RID: 40721
		// (get) Token: 0x060238A9 RID: 145577 RVA: 0x004EA876 File Offset: 0x004E8A76
		// (set) Token: 0x060238AA RID: 145578 RVA: 0x004EA87E File Offset: 0x004E8A7E
		public object Value { get; set; }

		// Token: 0x060238AB RID: 145579 RVA: 0x004EA887 File Offset: 0x004E8A87
		public IInteractPlayerDiractionType_UnionUnion()
		{
			this.Type = IInteractPlayerDiractionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060238AC RID: 145580 RVA: 0x004EA89D File Offset: 0x004E8A9D
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060238AD RID: 145581 RVA: 0x004EA8AF File Offset: 0x004E8AAF
		public IInteractPlayerDiractionTypeT AsIInteractPlayerDiractionType()
		{
			return this.As<IInteractPlayerDiractionTypeT>();
		}

		// Token: 0x060238AE RID: 145582 RVA: 0x004EA8B7 File Offset: 0x004E8AB7
		public static IInteractPlayerDiractionType_UnionUnion FromIInteractPlayerDiractionType(IInteractPlayerDiractionTypeT _iinteractplayerdiractiontype)
		{
			return new IInteractPlayerDiractionType_UnionUnion
			{
				Type = IInteractPlayerDiractionType_Union.IInteractPlayerDiractionType,
				Value = _iinteractplayerdiractiontype
			};
		}

		// Token: 0x060238AF RID: 145583 RVA: 0x004EA8CC File Offset: 0x004E8ACC
		public IInteractPlayerDiractionToNpcT AsIInteractPlayerDiractionToNpc()
		{
			return this.As<IInteractPlayerDiractionToNpcT>();
		}

		// Token: 0x060238B0 RID: 145584 RVA: 0x004EA8D4 File Offset: 0x004E8AD4
		public static IInteractPlayerDiractionType_UnionUnion FromIInteractPlayerDiractionToNpc(IInteractPlayerDiractionToNpcT _iinteractplayerdiractiontonpc)
		{
			return new IInteractPlayerDiractionType_UnionUnion
			{
				Type = IInteractPlayerDiractionType_Union.IInteractPlayerDiractionToNpc,
				Value = _iinteractplayerdiractiontonpc
			};
		}

		// Token: 0x060238B1 RID: 145585 RVA: 0x004EA8E9 File Offset: 0x004E8AE9
		public IInteractPlayerDiractionToLeisureT AsIInteractPlayerDiractionToLeisure()
		{
			return this.As<IInteractPlayerDiractionToLeisureT>();
		}

		// Token: 0x060238B2 RID: 145586 RVA: 0x004EA8F1 File Offset: 0x004E8AF1
		public static IInteractPlayerDiractionType_UnionUnion FromIInteractPlayerDiractionToLeisure(IInteractPlayerDiractionToLeisureT _iinteractplayerdiractiontoleisure)
		{
			return new IInteractPlayerDiractionType_UnionUnion
			{
				Type = IInteractPlayerDiractionType_Union.IInteractPlayerDiractionToLeisure,
				Value = _iinteractplayerdiractiontoleisure
			};
		}

		// Token: 0x060238B3 RID: 145587 RVA: 0x004EA908 File Offset: 0x004E8B08
		public static int Pack(FlatBufferBuilder builder, IInteractPlayerDiractionType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IInteractPlayerDiractionType_Union.IInteractPlayerDiractionType:
				return IInteractPlayerDiractionType.Pack(builder, _o.AsIInteractPlayerDiractionType()).Value;
			case IInteractPlayerDiractionType_Union.IInteractPlayerDiractionToNpc:
				return IInteractPlayerDiractionToNpc.Pack(builder, _o.AsIInteractPlayerDiractionToNpc()).Value;
			case IInteractPlayerDiractionType_Union.IInteractPlayerDiractionToLeisure:
				return IInteractPlayerDiractionToLeisure.Pack(builder, _o.AsIInteractPlayerDiractionToLeisure()).Value;
			default:
				return 0;
			}
		}
	}
}
