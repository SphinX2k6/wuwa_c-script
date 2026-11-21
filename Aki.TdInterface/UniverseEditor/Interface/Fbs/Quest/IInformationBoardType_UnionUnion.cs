using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042DE RID: 17118
	public class IInformationBoardType_UnionUnion
	{
		// Token: 0x1700753A RID: 30010
		// (get) Token: 0x06018073 RID: 98419 RVA: 0x0036DF0D File Offset: 0x0036C10D
		// (set) Token: 0x06018074 RID: 98420 RVA: 0x0036DF15 File Offset: 0x0036C115
		public IInformationBoardType_Union Type { get; set; }

		// Token: 0x1700753B RID: 30011
		// (get) Token: 0x06018075 RID: 98421 RVA: 0x0036DF1E File Offset: 0x0036C11E
		// (set) Token: 0x06018076 RID: 98422 RVA: 0x0036DF26 File Offset: 0x0036C126
		public object Value { get; set; }

		// Token: 0x06018077 RID: 98423 RVA: 0x0036DF2F File Offset: 0x0036C12F
		public IInformationBoardType_UnionUnion()
		{
			this.Type = IInformationBoardType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06018078 RID: 98424 RVA: 0x0036DF45 File Offset: 0x0036C145
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06018079 RID: 98425 RVA: 0x0036DF57 File Offset: 0x0036C157
		public IInformationBoardTypeT AsIInformationBoardType()
		{
			return this.As<IInformationBoardTypeT>();
		}

		// Token: 0x0601807A RID: 98426 RVA: 0x0036DF5F File Offset: 0x0036C15F
		public static IInformationBoardType_UnionUnion FromIInformationBoardType(IInformationBoardTypeT _iinformationboardtype)
		{
			return new IInformationBoardType_UnionUnion
			{
				Type = IInformationBoardType_Union.IInformationBoardType,
				Value = _iinformationboardtype
			};
		}

		// Token: 0x0601807B RID: 98427 RVA: 0x0036DF74 File Offset: 0x0036C174
		public IDangoAbyssInformationBoardT AsIDangoAbyssInformationBoard()
		{
			return this.As<IDangoAbyssInformationBoardT>();
		}

		// Token: 0x0601807C RID: 98428 RVA: 0x0036DF7C File Offset: 0x0036C17C
		public static IInformationBoardType_UnionUnion FromIDangoAbyssInformationBoard(IDangoAbyssInformationBoardT _idangoabyssinformationboard)
		{
			return new IInformationBoardType_UnionUnion
			{
				Type = IInformationBoardType_Union.IDangoAbyssInformationBoard,
				Value = _idangoabyssinformationboard
			};
		}

		// Token: 0x0601807D RID: 98429 RVA: 0x0036DF94 File Offset: 0x0036C194
		public static int Pack(FlatBufferBuilder builder, IInformationBoardType_UnionUnion _o)
		{
			IInformationBoardType_Union type = _o.Type;
			if (type == IInformationBoardType_Union.IInformationBoardType)
			{
				return IInformationBoardType.Pack(builder, _o.AsIInformationBoardType()).Value;
			}
			if (type != IInformationBoardType_Union.IDangoAbyssInformationBoard)
			{
				return 0;
			}
			return IDangoAbyssInformationBoard.Pack(builder, _o.AsIDangoAbyssInformationBoard()).Value;
		}
	}
}
