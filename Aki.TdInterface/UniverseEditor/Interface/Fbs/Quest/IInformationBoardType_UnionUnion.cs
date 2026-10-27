using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003EA0 RID: 16032
	public class IInformationBoardType_UnionUnion
	{
		// Token: 0x17006F4D RID: 28493
		// (get) Token: 0x06016A26 RID: 92710 RVA: 0x00344F85 File Offset: 0x00343185
		// (set) Token: 0x06016A27 RID: 92711 RVA: 0x00344F8D File Offset: 0x0034318D
		public IInformationBoardType_Union Type { get; set; }

		// Token: 0x17006F4E RID: 28494
		// (get) Token: 0x06016A28 RID: 92712 RVA: 0x00344F96 File Offset: 0x00343196
		// (set) Token: 0x06016A29 RID: 92713 RVA: 0x00344F9E File Offset: 0x0034319E
		public object Value { get; set; }

		// Token: 0x06016A2A RID: 92714 RVA: 0x00344FA7 File Offset: 0x003431A7
		public IInformationBoardType_UnionUnion()
		{
			this.Type = IInformationBoardType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06016A2B RID: 92715 RVA: 0x00344FBD File Offset: 0x003431BD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06016A2C RID: 92716 RVA: 0x00344FCF File Offset: 0x003431CF
		public IInformationBoardTypeT AsIInformationBoardType()
		{
			return this.As<IInformationBoardTypeT>();
		}

		// Token: 0x06016A2D RID: 92717 RVA: 0x00344FD7 File Offset: 0x003431D7
		public static IInformationBoardType_UnionUnion FromIInformationBoardType(IInformationBoardTypeT _iinformationboardtype)
		{
			return new IInformationBoardType_UnionUnion
			{
				Type = IInformationBoardType_Union.IInformationBoardType,
				Value = _iinformationboardtype
			};
		}

		// Token: 0x06016A2E RID: 92718 RVA: 0x00344FEC File Offset: 0x003431EC
		public IDangoAbyssInformationBoardT AsIDangoAbyssInformationBoard()
		{
			return this.As<IDangoAbyssInformationBoardT>();
		}

		// Token: 0x06016A2F RID: 92719 RVA: 0x00344FF4 File Offset: 0x003431F4
		public static IInformationBoardType_UnionUnion FromIDangoAbyssInformationBoard(IDangoAbyssInformationBoardT _idangoabyssinformationboard)
		{
			return new IInformationBoardType_UnionUnion
			{
				Type = IInformationBoardType_Union.IDangoAbyssInformationBoard,
				Value = _idangoabyssinformationboard
			};
		}

		// Token: 0x06016A30 RID: 92720 RVA: 0x0034500C File Offset: 0x0034320C
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
