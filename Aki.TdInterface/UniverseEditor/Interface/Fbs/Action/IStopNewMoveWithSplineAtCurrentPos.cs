using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079B3 RID: 31155
	public struct IStopNewMoveWithSplineAtCurrentPos : IFlatbufferObject
	{
		// Token: 0x1700E47E RID: 58494
		// (get) Token: 0x06036E50 RID: 224848 RVA: 0x00757860 File Offset: 0x00755A60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036E51 RID: 224849 RVA: 0x0075786D File Offset: 0x00755A6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036E52 RID: 224850 RVA: 0x00757874 File Offset: 0x00755A74
		public static IStopNewMoveWithSplineAtCurrentPos GetRootAsIStopNewMoveWithSplineAtCurrentPos(ByteBuffer _bb)
		{
			return IStopNewMoveWithSplineAtCurrentPos.GetRootAsIStopNewMoveWithSplineAtCurrentPos(_bb, default(IStopNewMoveWithSplineAtCurrentPos));
		}

		// Token: 0x06036E53 RID: 224851 RVA: 0x00757890 File Offset: 0x00755A90
		public static IStopNewMoveWithSplineAtCurrentPos GetRootAsIStopNewMoveWithSplineAtCurrentPos(ByteBuffer _bb, IStopNewMoveWithSplineAtCurrentPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036E54 RID: 224852 RVA: 0x007578AD File Offset: 0x00755AAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036E55 RID: 224853 RVA: 0x007578BC File Offset: 0x00755ABC
		public IStopNewMoveWithSplineAtCurrentPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E47F RID: 58495
		// (get) Token: 0x06036E56 RID: 224854 RVA: 0x007578CC File Offset: 0x00755ACC
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

		// Token: 0x06036E57 RID: 224855 RVA: 0x00757908 File Offset: 0x00755B08
		public static Offset<IStopNewMoveWithSplineAtCurrentPos> CreateIStopNewMoveWithSplineAtCurrentPos(FlatBufferBuilder builder, EStopNewMoveWithSplineType Type = EStopNewMoveWithSplineType.StopAtCurrentPos)
		{
			builder.StartTable(1);
			IStopNewMoveWithSplineAtCurrentPos.AddType(builder, Type);
			return IStopNewMoveWithSplineAtCurrentPos.EndIStopNewMoveWithSplineAtCurrentPos(builder);
		}

		// Token: 0x06036E58 RID: 224856 RVA: 0x0075791E File Offset: 0x00755B1E
		public static void StartIStopNewMoveWithSplineAtCurrentPos(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036E59 RID: 224857 RVA: 0x00757927 File Offset: 0x00755B27
		public static void AddType(FlatBufferBuilder builder, EStopNewMoveWithSplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036E5A RID: 224858 RVA: 0x00757932 File Offset: 0x00755B32
		public static Offset<IStopNewMoveWithSplineAtCurrentPos> EndIStopNewMoveWithSplineAtCurrentPos(FlatBufferBuilder builder)
		{
			return new Offset<IStopNewMoveWithSplineAtCurrentPos>(builder.EndTable());
		}

		// Token: 0x06036E5B RID: 224859 RVA: 0x00757940 File Offset: 0x00755B40
		public IStopNewMoveWithSplineAtCurrentPosT UnPack()
		{
			IStopNewMoveWithSplineAtCurrentPosT stopNewMoveWithSplineAtCurrentPosT = new IStopNewMoveWithSplineAtCurrentPosT();
			this.UnPackTo(stopNewMoveWithSplineAtCurrentPosT);
			return stopNewMoveWithSplineAtCurrentPosT;
		}

		// Token: 0x06036E5C RID: 224860 RVA: 0x0075795B File Offset: 0x00755B5B
		public void UnPackTo(IStopNewMoveWithSplineAtCurrentPosT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036E5D RID: 224861 RVA: 0x0075796C File Offset: 0x00755B6C
		public static Offset<IStopNewMoveWithSplineAtCurrentPos> Pack(FlatBufferBuilder builder, IStopNewMoveWithSplineAtCurrentPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopNewMoveWithSplineAtCurrentPos>);
			}
			return IStopNewMoveWithSplineAtCurrentPos.CreateIStopNewMoveWithSplineAtCurrentPos(builder, _o.Type);
		}

		// Token: 0x04012CC1 RID: 76993
		private Table __p;
	}
}
