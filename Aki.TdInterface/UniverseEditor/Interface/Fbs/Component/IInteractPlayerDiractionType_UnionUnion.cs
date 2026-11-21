using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059EB RID: 23019
	public class IInteractPlayerDiractionType_UnionUnion
	{
		// Token: 0x1700A74A RID: 42826
		// (get) Token: 0x0602595F RID: 153951 RVA: 0x005278D9 File Offset: 0x00525AD9
		// (set) Token: 0x06025960 RID: 153952 RVA: 0x005278E1 File Offset: 0x00525AE1
		public IInteractPlayerDiractionType_Union Type { get; set; }

		// Token: 0x1700A74B RID: 42827
		// (get) Token: 0x06025961 RID: 153953 RVA: 0x005278EA File Offset: 0x00525AEA
		// (set) Token: 0x06025962 RID: 153954 RVA: 0x005278F2 File Offset: 0x00525AF2
		public object Value { get; set; }

		// Token: 0x06025963 RID: 153955 RVA: 0x005278FB File Offset: 0x00525AFB
		public IInteractPlayerDiractionType_UnionUnion()
		{
			this.Type = IInteractPlayerDiractionType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06025964 RID: 153956 RVA: 0x00527911 File Offset: 0x00525B11
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06025965 RID: 153957 RVA: 0x00527923 File Offset: 0x00525B23
		public IInteractPlayerDiractionTypeT AsIInteractPlayerDiractionType()
		{
			return this.As<IInteractPlayerDiractionTypeT>();
		}

		// Token: 0x06025966 RID: 153958 RVA: 0x0052792B File Offset: 0x00525B2B
		public static IInteractPlayerDiractionType_UnionUnion FromIInteractPlayerDiractionType(IInteractPlayerDiractionTypeT _iinteractplayerdiractiontype)
		{
			return new IInteractPlayerDiractionType_UnionUnion
			{
				Type = IInteractPlayerDiractionType_Union.IInteractPlayerDiractionType,
				Value = _iinteractplayerdiractiontype
			};
		}

		// Token: 0x06025967 RID: 153959 RVA: 0x00527940 File Offset: 0x00525B40
		public IInteractPlayerDiractionToNpcT AsIInteractPlayerDiractionToNpc()
		{
			return this.As<IInteractPlayerDiractionToNpcT>();
		}

		// Token: 0x06025968 RID: 153960 RVA: 0x00527948 File Offset: 0x00525B48
		public static IInteractPlayerDiractionType_UnionUnion FromIInteractPlayerDiractionToNpc(IInteractPlayerDiractionToNpcT _iinteractplayerdiractiontonpc)
		{
			return new IInteractPlayerDiractionType_UnionUnion
			{
				Type = IInteractPlayerDiractionType_Union.IInteractPlayerDiractionToNpc,
				Value = _iinteractplayerdiractiontonpc
			};
		}

		// Token: 0x06025969 RID: 153961 RVA: 0x0052795D File Offset: 0x00525B5D
		public IInteractPlayerDiractionToLeisureT AsIInteractPlayerDiractionToLeisure()
		{
			return this.As<IInteractPlayerDiractionToLeisureT>();
		}

		// Token: 0x0602596A RID: 153962 RVA: 0x00527965 File Offset: 0x00525B65
		public static IInteractPlayerDiractionType_UnionUnion FromIInteractPlayerDiractionToLeisure(IInteractPlayerDiractionToLeisureT _iinteractplayerdiractiontoleisure)
		{
			return new IInteractPlayerDiractionType_UnionUnion
			{
				Type = IInteractPlayerDiractionType_Union.IInteractPlayerDiractionToLeisure,
				Value = _iinteractplayerdiractiontoleisure
			};
		}

		// Token: 0x0602596B RID: 153963 RVA: 0x0052797C File Offset: 0x00525B7C
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
