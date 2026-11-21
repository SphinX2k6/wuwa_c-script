using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079BF RID: 31167
	public struct IStopNewMoveWithSplineType : IFlatbufferObject
	{
		// Token: 0x1700E48C RID: 58508
		// (get) Token: 0x06036E9C RID: 224924 RVA: 0x00757EC6 File Offset: 0x007560C6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036E9D RID: 224925 RVA: 0x00757ED3 File Offset: 0x007560D3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036E9E RID: 224926 RVA: 0x00757EDC File Offset: 0x007560DC
		public static IStopNewMoveWithSplineType GetRootAsIStopNewMoveWithSplineType(ByteBuffer _bb)
		{
			return IStopNewMoveWithSplineType.GetRootAsIStopNewMoveWithSplineType(_bb, default(IStopNewMoveWithSplineType));
		}

		// Token: 0x06036E9F RID: 224927 RVA: 0x00757EF8 File Offset: 0x007560F8
		public static IStopNewMoveWithSplineType GetRootAsIStopNewMoveWithSplineType(ByteBuffer _bb, IStopNewMoveWithSplineType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036EA0 RID: 224928 RVA: 0x00757F15 File Offset: 0x00756115
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036EA1 RID: 224929 RVA: 0x00757F24 File Offset: 0x00756124
		public IStopNewMoveWithSplineType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E48D RID: 58509
		// (get) Token: 0x06036EA2 RID: 224930 RVA: 0x00757F34 File Offset: 0x00756134
		public EStopNewMoveWithSplineType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EStopNewMoveWithSplineType.StopAtCurrentPos;
				}
				return (EStopNewMoveWithSplineType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036EA3 RID: 224931 RVA: 0x00757F70 File Offset: 0x00756170
		public static Offset<IStopNewMoveWithSplineType> CreateIStopNewMoveWithSplineType(FlatBufferBuilder builder, EStopNewMoveWithSplineType Type = EStopNewMoveWithSplineType.StopAtCurrentPos)
		{
			builder.StartTable(1);
			IStopNewMoveWithSplineType.AddType(builder, Type);
			return IStopNewMoveWithSplineType.EndIStopNewMoveWithSplineType(builder);
		}

		// Token: 0x06036EA4 RID: 224932 RVA: 0x00757F86 File Offset: 0x00756186
		public static void StartIStopNewMoveWithSplineType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036EA5 RID: 224933 RVA: 0x00757F8F File Offset: 0x0075618F
		public static void AddType(FlatBufferBuilder builder, EStopNewMoveWithSplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036EA6 RID: 224934 RVA: 0x00757F9A File Offset: 0x0075619A
		public static Offset<IStopNewMoveWithSplineType> EndIStopNewMoveWithSplineType(FlatBufferBuilder builder)
		{
			return new Offset<IStopNewMoveWithSplineType>(builder.EndTable());
		}

		// Token: 0x06036EA7 RID: 224935 RVA: 0x00757FA8 File Offset: 0x007561A8
		public IStopNewMoveWithSplineTypeT UnPack()
		{
			IStopNewMoveWithSplineTypeT stopNewMoveWithSplineTypeT = new IStopNewMoveWithSplineTypeT();
			this.UnPackTo(stopNewMoveWithSplineTypeT);
			return stopNewMoveWithSplineTypeT;
		}

		// Token: 0x06036EA8 RID: 224936 RVA: 0x00757FC3 File Offset: 0x007561C3
		public void UnPackTo(IStopNewMoveWithSplineTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036EA9 RID: 224937 RVA: 0x00757FD4 File Offset: 0x007561D4
		public static Offset<IStopNewMoveWithSplineType> Pack(FlatBufferBuilder builder, IStopNewMoveWithSplineTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopNewMoveWithSplineType>);
			}
			return IStopNewMoveWithSplineType.CreateIStopNewMoveWithSplineType(builder, _o.Type);
		}

		// Token: 0x04012CCA RID: 77002
		private Table __p;
	}
}
