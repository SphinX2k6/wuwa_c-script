using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070A0 RID: 28832
	public struct ILevelSequenceTransitionType : IFlatbufferObject
	{
		// Token: 0x1700D333 RID: 54067
		// (get) Token: 0x060320E3 RID: 205027 RVA: 0x006C689A File Offset: 0x006C4A9A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060320E4 RID: 205028 RVA: 0x006C68A7 File Offset: 0x006C4AA7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060320E5 RID: 205029 RVA: 0x006C68B0 File Offset: 0x006C4AB0
		public static ILevelSequenceTransitionType GetRootAsILevelSequenceTransitionType(ByteBuffer _bb)
		{
			return ILevelSequenceTransitionType.GetRootAsILevelSequenceTransitionType(_bb, default(ILevelSequenceTransitionType));
		}

		// Token: 0x060320E6 RID: 205030 RVA: 0x006C68CC File Offset: 0x006C4ACC
		public static ILevelSequenceTransitionType GetRootAsILevelSequenceTransitionType(ByteBuffer _bb, ILevelSequenceTransitionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060320E7 RID: 205031 RVA: 0x006C68E9 File Offset: 0x006C4AE9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060320E8 RID: 205032 RVA: 0x006C68F8 File Offset: 0x006C4AF8
		public ILevelSequenceTransitionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D334 RID: 54068
		// (get) Token: 0x060320E9 RID: 205033 RVA: 0x006C6908 File Offset: 0x006C4B08
		public ELevelSequenceTransition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ELevelSequenceTransition.Camera;
				}
				return (ELevelSequenceTransition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D335 RID: 54069
		// (get) Token: 0x060320EA RID: 205034 RVA: 0x006C6944 File Offset: 0x006C4B44
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D336 RID: 54070
		// (get) Token: 0x060320EB RID: 205035 RVA: 0x006C6984 File Offset: 0x006C4B84
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060320EC RID: 205036 RVA: 0x006C69C0 File Offset: 0x006C4BC0
		public static Offset<ILevelSequenceTransitionType> CreateILevelSequenceTransitionType(FlatBufferBuilder builder, ELevelSequenceTransition Type = ELevelSequenceTransition.Camera, float Duration = 0f, byte NullMask = 0)
		{
			builder.StartTable(3);
			ILevelSequenceTransitionType.AddDuration(builder, Duration);
			ILevelSequenceTransitionType.AddNullMask(builder, NullMask);
			ILevelSequenceTransitionType.AddType(builder, Type);
			return ILevelSequenceTransitionType.EndILevelSequenceTransitionType(builder);
		}

		// Token: 0x060320ED RID: 205037 RVA: 0x006C69E4 File Offset: 0x006C4BE4
		public static void StartILevelSequenceTransitionType(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060320EE RID: 205038 RVA: 0x006C69ED File Offset: 0x006C4BED
		public static void AddType(FlatBufferBuilder builder, ELevelSequenceTransition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060320EF RID: 205039 RVA: 0x006C69F8 File Offset: 0x006C4BF8
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(1, duration, 0.0);
		}

		// Token: 0x060320F0 RID: 205040 RVA: 0x006C6A0B File Offset: 0x006C4C0B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060320F1 RID: 205041 RVA: 0x006C6A16 File Offset: 0x006C4C16
		public static Offset<ILevelSequenceTransitionType> EndILevelSequenceTransitionType(FlatBufferBuilder builder)
		{
			return new Offset<ILevelSequenceTransitionType>(builder.EndTable());
		}

		// Token: 0x060320F2 RID: 205042 RVA: 0x006C6A24 File Offset: 0x006C4C24
		public ILevelSequenceTransitionTypeT UnPack()
		{
			ILevelSequenceTransitionTypeT levelSequenceTransitionTypeT = new ILevelSequenceTransitionTypeT();
			this.UnPackTo(levelSequenceTransitionTypeT);
			return levelSequenceTransitionTypeT;
		}

		// Token: 0x060320F3 RID: 205043 RVA: 0x006C6A3F File Offset: 0x006C4C3F
		public void UnPackTo(ILevelSequenceTransitionTypeT _o)
		{
			_o.Type = this.Type;
			_o.Duration = this.Duration;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060320F4 RID: 205044 RVA: 0x006C6A68 File Offset: 0x006C4C68
		public static Offset<ILevelSequenceTransitionType> Pack(FlatBufferBuilder builder, ILevelSequenceTransitionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILevelSequenceTransitionType>);
			}
			return ILevelSequenceTransitionType.CreateILevelSequenceTransitionType(builder, _o.Type, _o.Duration, _o.NullMask);
		}

		// Token: 0x04012050 RID: 73808
		private Table __p;
	}
}
