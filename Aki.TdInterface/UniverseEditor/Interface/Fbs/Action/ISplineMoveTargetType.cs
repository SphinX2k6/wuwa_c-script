using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007965 RID: 31077
	public struct ISplineMoveTargetType : IFlatbufferObject
	{
		// Token: 0x1700E3E9 RID: 58345
		// (get) Token: 0x06036BB2 RID: 224178 RVA: 0x0075279E File Offset: 0x0075099E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036BB3 RID: 224179 RVA: 0x007527AB File Offset: 0x007509AB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036BB4 RID: 224180 RVA: 0x007527B4 File Offset: 0x007509B4
		public static ISplineMoveTargetType GetRootAsISplineMoveTargetType(ByteBuffer _bb)
		{
			return ISplineMoveTargetType.GetRootAsISplineMoveTargetType(_bb, default(ISplineMoveTargetType));
		}

		// Token: 0x06036BB5 RID: 224181 RVA: 0x007527D0 File Offset: 0x007509D0
		public static ISplineMoveTargetType GetRootAsISplineMoveTargetType(ByteBuffer _bb, ISplineMoveTargetType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036BB6 RID: 224182 RVA: 0x007527ED File Offset: 0x007509ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036BB7 RID: 224183 RVA: 0x007527FC File Offset: 0x007509FC
		public ISplineMoveTargetType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3EA RID: 58346
		// (get) Token: 0x06036BB8 RID: 224184 RVA: 0x0075280C File Offset: 0x00750A0C
		public ESplineMoveTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESplineMoveTargetType.Entity;
				}
				return (ESplineMoveTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036BB9 RID: 224185 RVA: 0x00752848 File Offset: 0x00750A48
		public static Offset<ISplineMoveTargetType> CreateISplineMoveTargetType(FlatBufferBuilder builder, ESplineMoveTargetType Type = ESplineMoveTargetType.Entity)
		{
			builder.StartTable(1);
			ISplineMoveTargetType.AddType(builder, Type);
			return ISplineMoveTargetType.EndISplineMoveTargetType(builder);
		}

		// Token: 0x06036BBA RID: 224186 RVA: 0x0075285E File Offset: 0x00750A5E
		public static void StartISplineMoveTargetType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06036BBB RID: 224187 RVA: 0x00752867 File Offset: 0x00750A67
		public static void AddType(FlatBufferBuilder builder, ESplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036BBC RID: 224188 RVA: 0x00752872 File Offset: 0x00750A72
		public static Offset<ISplineMoveTargetType> EndISplineMoveTargetType(FlatBufferBuilder builder)
		{
			return new Offset<ISplineMoveTargetType>(builder.EndTable());
		}

		// Token: 0x06036BBD RID: 224189 RVA: 0x00752880 File Offset: 0x00750A80
		public ISplineMoveTargetTypeT UnPack()
		{
			ISplineMoveTargetTypeT splineMoveTargetTypeT = new ISplineMoveTargetTypeT();
			this.UnPackTo(splineMoveTargetTypeT);
			return splineMoveTargetTypeT;
		}

		// Token: 0x06036BBE RID: 224190 RVA: 0x0075289B File Offset: 0x00750A9B
		public void UnPackTo(ISplineMoveTargetTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06036BBF RID: 224191 RVA: 0x007528AC File Offset: 0x00750AAC
		public static Offset<ISplineMoveTargetType> Pack(FlatBufferBuilder builder, ISplineMoveTargetTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISplineMoveTargetType>);
			}
			return ISplineMoveTargetType.CreateISplineMoveTargetType(builder, _o.Type);
		}

		// Token: 0x04012C4E RID: 76878
		private Table __p;
	}
}
