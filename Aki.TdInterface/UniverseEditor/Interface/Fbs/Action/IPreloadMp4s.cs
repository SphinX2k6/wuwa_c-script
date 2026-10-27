using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D98 RID: 28056
	public struct IPreloadMp4s : IFlatbufferObject
	{
		// Token: 0x1700D146 RID: 53574
		// (get) Token: 0x060318F1 RID: 202993 RVA: 0x006B788E File Offset: 0x006B5A8E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060318F2 RID: 202994 RVA: 0x006B789B File Offset: 0x006B5A9B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060318F3 RID: 202995 RVA: 0x006B78A4 File Offset: 0x006B5AA4
		public static IPreloadMp4s GetRootAsIPreloadMp4s(ByteBuffer _bb)
		{
			return IPreloadMp4s.GetRootAsIPreloadMp4s(_bb, default(IPreloadMp4s));
		}

		// Token: 0x060318F4 RID: 202996 RVA: 0x006B78C0 File Offset: 0x006B5AC0
		public static IPreloadMp4s GetRootAsIPreloadMp4s(ByteBuffer _bb, IPreloadMp4s obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060318F5 RID: 202997 RVA: 0x006B78DD File Offset: 0x006B5ADD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060318F6 RID: 202998 RVA: 0x006B78EC File Offset: 0x006B5AEC
		public IPreloadMp4s __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D147 RID: 53575
		// (get) Token: 0x060318F7 RID: 202999 RVA: 0x006B78FC File Offset: 0x006B5AFC
		public EPreloadObjectType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EPreloadObjectType.PreloadTrialCharacterForSkill;
				}
				return (EPreloadObjectType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060318F8 RID: 203000 RVA: 0x006B7938 File Offset: 0x006B5B38
		public string Mp4s(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D148 RID: 53576
		// (get) Token: 0x060318F9 RID: 203001 RVA: 0x006B7974 File Offset: 0x006B5B74
		public int Mp4sLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060318FA RID: 203002 RVA: 0x006B799F File Offset: 0x006B5B9F
		public static Offset<IPreloadMp4s> CreateIPreloadMp4s(FlatBufferBuilder builder, EPreloadObjectType Type = EPreloadObjectType.PreloadTrialCharacterForSkill, VectorOffset Mp4sOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IPreloadMp4s.AddMp4s(builder, Mp4sOffset);
			IPreloadMp4s.AddType(builder, Type);
			return IPreloadMp4s.EndIPreloadMp4s(builder);
		}

		// Token: 0x060318FB RID: 203003 RVA: 0x006B79BC File Offset: 0x006B5BBC
		public static void StartIPreloadMp4s(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060318FC RID: 203004 RVA: 0x006B79C5 File Offset: 0x006B5BC5
		public static void AddType(FlatBufferBuilder builder, EPreloadObjectType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060318FD RID: 203005 RVA: 0x006B79D0 File Offset: 0x006B5BD0
		public static void AddMp4s(FlatBufferBuilder builder, VectorOffset mp4sOffset)
		{
			builder.AddOffset(1, mp4sOffset.Value, 0);
		}

		// Token: 0x060318FE RID: 203006 RVA: 0x006B79E0 File Offset: 0x006B5BE0
		public static VectorOffset CreateMp4sVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060318FF RID: 203007 RVA: 0x006B7A20 File Offset: 0x006B5C20
		public static VectorOffset CreateMp4sVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06031900 RID: 203008 RVA: 0x006B7A3A File Offset: 0x006B5C3A
		public static VectorOffset CreateMp4sVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06031901 RID: 203009 RVA: 0x006B7A58 File Offset: 0x006B5C58
		public static VectorOffset CreateMp4sVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06031902 RID: 203010 RVA: 0x006B7A71 File Offset: 0x006B5C71
		public static void StartMp4sVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06031903 RID: 203011 RVA: 0x006B7A7C File Offset: 0x006B5C7C
		public static Offset<IPreloadMp4s> EndIPreloadMp4s(FlatBufferBuilder builder)
		{
			return new Offset<IPreloadMp4s>(builder.EndTable());
		}

		// Token: 0x06031904 RID: 203012 RVA: 0x006B7A8C File Offset: 0x006B5C8C
		public IPreloadMp4sT UnPack()
		{
			IPreloadMp4sT preloadMp4sT = new IPreloadMp4sT();
			this.UnPackTo(preloadMp4sT);
			return preloadMp4sT;
		}

		// Token: 0x06031905 RID: 203013 RVA: 0x006B7AA8 File Offset: 0x006B5CA8
		public void UnPackTo(IPreloadMp4sT _o)
		{
			_o.Type = this.Type;
			_o.Mp4s = new List<string>();
			for (int i = 0; i < this.Mp4sLength; i++)
			{
				_o.Mp4s.Add(this.Mp4s(i));
			}
		}

		// Token: 0x06031906 RID: 203014 RVA: 0x006B7AF0 File Offset: 0x006B5CF0
		public static Offset<IPreloadMp4s> Pack(FlatBufferBuilder builder, IPreloadMp4sT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPreloadMp4s>);
			}
			VectorOffset mp4sOffset = default(VectorOffset);
			if (_o.Mp4s != null)
			{
				StringOffset[] array = new StringOffset[_o.Mp4s.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.Mp4s[i]);
				}
				mp4sOffset = IPreloadMp4s.CreateMp4sVector(builder, array);
			}
			return IPreloadMp4s.CreateIPreloadMp4s(builder, _o.Type, mp4sOffset);
		}

		// Token: 0x0401176B RID: 71531
		private Table __p;
	}
}
