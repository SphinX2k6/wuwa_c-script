using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071EA RID: 29162
	public struct IStopNewMoveWithSplineType : IFlatbufferObject
	{
		// Token: 0x1700D893 RID: 55443
		// (get) Token: 0x06033B9A RID: 211866 RVA: 0x006F6B66 File Offset: 0x006F4D66
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033B9B RID: 211867 RVA: 0x006F6B73 File Offset: 0x006F4D73
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033B9C RID: 211868 RVA: 0x006F6B7C File Offset: 0x006F4D7C
		public static IStopNewMoveWithSplineType GetRootAsIStopNewMoveWithSplineType(ByteBuffer _bb)
		{
			return IStopNewMoveWithSplineType.GetRootAsIStopNewMoveWithSplineType(_bb, default(IStopNewMoveWithSplineType));
		}

		// Token: 0x06033B9D RID: 211869 RVA: 0x006F6B98 File Offset: 0x006F4D98
		public static IStopNewMoveWithSplineType GetRootAsIStopNewMoveWithSplineType(ByteBuffer _bb, IStopNewMoveWithSplineType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033B9E RID: 211870 RVA: 0x006F6BB5 File Offset: 0x006F4DB5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033B9F RID: 211871 RVA: 0x006F6BC4 File Offset: 0x006F4DC4
		public IStopNewMoveWithSplineType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D894 RID: 55444
		// (get) Token: 0x06033BA0 RID: 211872 RVA: 0x006F6BD4 File Offset: 0x006F4DD4
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

		// Token: 0x06033BA1 RID: 211873 RVA: 0x006F6C10 File Offset: 0x006F4E10
		public static Offset<IStopNewMoveWithSplineType> CreateIStopNewMoveWithSplineType(FlatBufferBuilder builder, EStopNewMoveWithSplineType Type = EStopNewMoveWithSplineType.StopAtCurrentPos)
		{
			builder.StartTable(1);
			IStopNewMoveWithSplineType.AddType(builder, Type);
			return IStopNewMoveWithSplineType.EndIStopNewMoveWithSplineType(builder);
		}

		// Token: 0x06033BA2 RID: 211874 RVA: 0x006F6C26 File Offset: 0x006F4E26
		public static void StartIStopNewMoveWithSplineType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06033BA3 RID: 211875 RVA: 0x006F6C2F File Offset: 0x006F4E2F
		public static void AddType(FlatBufferBuilder builder, EStopNewMoveWithSplineType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033BA4 RID: 211876 RVA: 0x006F6C3A File Offset: 0x006F4E3A
		public static Offset<IStopNewMoveWithSplineType> EndIStopNewMoveWithSplineType(FlatBufferBuilder builder)
		{
			return new Offset<IStopNewMoveWithSplineType>(builder.EndTable());
		}

		// Token: 0x06033BA5 RID: 211877 RVA: 0x006F6C48 File Offset: 0x006F4E48
		public IStopNewMoveWithSplineTypeT UnPack()
		{
			IStopNewMoveWithSplineTypeT stopNewMoveWithSplineTypeT = new IStopNewMoveWithSplineTypeT();
			this.UnPackTo(stopNewMoveWithSplineTypeT);
			return stopNewMoveWithSplineTypeT;
		}

		// Token: 0x06033BA6 RID: 211878 RVA: 0x006F6C63 File Offset: 0x006F4E63
		public void UnPackTo(IStopNewMoveWithSplineTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06033BA7 RID: 211879 RVA: 0x006F6C74 File Offset: 0x006F4E74
		public static Offset<IStopNewMoveWithSplineType> Pack(FlatBufferBuilder builder, IStopNewMoveWithSplineTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStopNewMoveWithSplineType>);
			}
			return IStopNewMoveWithSplineType.CreateIStopNewMoveWithSplineType(builder, _o.Type);
		}

		// Token: 0x04011CC8 RID: 72904
		private Table __p;
	}
}
