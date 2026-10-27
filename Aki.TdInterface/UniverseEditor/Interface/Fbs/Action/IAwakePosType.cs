using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020061D0 RID: 25040
	public struct IAwakePosType : IFlatbufferObject
	{
		// Token: 0x1700BAB9 RID: 47801
		// (get) Token: 0x0602B286 RID: 176774 RVA: 0x005F2FD5 File Offset: 0x005F11D5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B287 RID: 176775 RVA: 0x005F2FE2 File Offset: 0x005F11E2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B288 RID: 176776 RVA: 0x005F2FEC File Offset: 0x005F11EC
		public static IAwakePosType GetRootAsIAwakePosType(ByteBuffer _bb)
		{
			return IAwakePosType.GetRootAsIAwakePosType(_bb, default(IAwakePosType));
		}

		// Token: 0x0602B289 RID: 176777 RVA: 0x005F3008 File Offset: 0x005F1208
		public static IAwakePosType GetRootAsIAwakePosType(ByteBuffer _bb, IAwakePosType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B28A RID: 176778 RVA: 0x005F3025 File Offset: 0x005F1225
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B28B RID: 176779 RVA: 0x005F3034 File Offset: 0x005F1234
		public IAwakePosType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BABA RID: 47802
		// (get) Token: 0x0602B28C RID: 176780 RVA: 0x005F3044 File Offset: 0x005F1244
		public EAwakePosType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EAwakePosType.TransformVar;
				}
				return (EAwakePosType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B28D RID: 176781 RVA: 0x005F3080 File Offset: 0x005F1280
		public static Offset<IAwakePosType> CreateIAwakePosType(FlatBufferBuilder builder, EAwakePosType Type = EAwakePosType.TransformVar)
		{
			builder.StartTable(1);
			IAwakePosType.AddType(builder, Type);
			return IAwakePosType.EndIAwakePosType(builder);
		}

		// Token: 0x0602B28E RID: 176782 RVA: 0x005F3096 File Offset: 0x005F1296
		public static void StartIAwakePosType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x0602B28F RID: 176783 RVA: 0x005F309F File Offset: 0x005F129F
		public static void AddType(FlatBufferBuilder builder, EAwakePosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B290 RID: 176784 RVA: 0x005F30AA File Offset: 0x005F12AA
		public static Offset<IAwakePosType> EndIAwakePosType(FlatBufferBuilder builder)
		{
			return new Offset<IAwakePosType>(builder.EndTable());
		}

		// Token: 0x0602B291 RID: 176785 RVA: 0x005F30B8 File Offset: 0x005F12B8
		public IAwakePosTypeT UnPack()
		{
			IAwakePosTypeT awakePosTypeT = new IAwakePosTypeT();
			this.UnPackTo(awakePosTypeT);
			return awakePosTypeT;
		}

		// Token: 0x0602B292 RID: 176786 RVA: 0x005F30D3 File Offset: 0x005F12D3
		public void UnPackTo(IAwakePosTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602B293 RID: 176787 RVA: 0x005F30E4 File Offset: 0x005F12E4
		public static Offset<IAwakePosType> Pack(FlatBufferBuilder builder, IAwakePosTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IAwakePosType>);
			}
			return IAwakePosType.CreateIAwakePosType(builder, _o.Type);
		}

		// Token: 0x040106F9 RID: 67321
		private Table __p;
	}
}
