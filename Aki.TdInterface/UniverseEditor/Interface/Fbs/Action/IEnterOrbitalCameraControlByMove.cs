using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066C3 RID: 26307
	public struct IEnterOrbitalCameraControlByMove : IFlatbufferObject
	{
		// Token: 0x1700C373 RID: 50035
		// (get) Token: 0x0602DBA8 RID: 187304 RVA: 0x00641877 File Offset: 0x0063FA77
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602DBA9 RID: 187305 RVA: 0x00641884 File Offset: 0x0063FA84
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602DBAA RID: 187306 RVA: 0x0064188C File Offset: 0x0063FA8C
		public static IEnterOrbitalCameraControlByMove GetRootAsIEnterOrbitalCameraControlByMove(ByteBuffer _bb)
		{
			return IEnterOrbitalCameraControlByMove.GetRootAsIEnterOrbitalCameraControlByMove(_bb, default(IEnterOrbitalCameraControlByMove));
		}

		// Token: 0x0602DBAB RID: 187307 RVA: 0x006418A8 File Offset: 0x0063FAA8
		public static IEnterOrbitalCameraControlByMove GetRootAsIEnterOrbitalCameraControlByMove(ByteBuffer _bb, IEnterOrbitalCameraControlByMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602DBAC RID: 187308 RVA: 0x006418C5 File Offset: 0x0063FAC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602DBAD RID: 187309 RVA: 0x006418D4 File Offset: 0x0063FAD4
		public IEnterOrbitalCameraControlByMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C374 RID: 50036
		// (get) Token: 0x0602DBAE RID: 187310 RVA: 0x006418E4 File Offset: 0x0063FAE4
		public EEnterOrbitalCameraType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnterOrbitalCameraType.ControlByMove;
				}
				return (EEnterOrbitalCameraType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C375 RID: 50037
		// (get) Token: 0x0602DBAF RID: 187311 RVA: 0x00641920 File Offset: 0x0063FB20
		public string LevelSequence
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DBB0 RID: 187312 RVA: 0x00641957 File Offset: 0x0063FB57
		public Span<byte> GetLevelSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0602DBB1 RID: 187313 RVA: 0x00641966 File Offset: 0x0063FB66
		public byte[] GetLevelSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700C376 RID: 50038
		// (get) Token: 0x0602DBB2 RID: 187314 RVA: 0x00641974 File Offset: 0x0063FB74
		public float BlendInTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C377 RID: 50039
		// (get) Token: 0x0602DBB3 RID: 187315 RVA: 0x006419B4 File Offset: 0x0063FBB4
		public float BlendOutTime
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C378 RID: 50040
		// (get) Token: 0x0602DBB4 RID: 187316 RVA: 0x006419F8 File Offset: 0x0063FBF8
		public int BegEntity
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C379 RID: 50041
		// (get) Token: 0x0602DBB5 RID: 187317 RVA: 0x00641A38 File Offset: 0x0063FC38
		public int EndEntity
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602DBB6 RID: 187318 RVA: 0x00641A75 File Offset: 0x0063FC75
		public static Offset<IEnterOrbitalCameraControlByMove> CreateIEnterOrbitalCameraControlByMove(FlatBufferBuilder builder, EEnterOrbitalCameraType Type = EEnterOrbitalCameraType.ControlByMove, StringOffset LevelSequenceOffset = default(StringOffset), float BlendInTime = 0f, float BlendOutTime = 0f, int BegEntity = 0, int EndEntity = 0)
		{
			builder.StartTable(6);
			IEnterOrbitalCameraControlByMove.AddEndEntity(builder, EndEntity);
			IEnterOrbitalCameraControlByMove.AddBegEntity(builder, BegEntity);
			IEnterOrbitalCameraControlByMove.AddBlendOutTime(builder, BlendOutTime);
			IEnterOrbitalCameraControlByMove.AddBlendInTime(builder, BlendInTime);
			IEnterOrbitalCameraControlByMove.AddLevelSequence(builder, LevelSequenceOffset);
			IEnterOrbitalCameraControlByMove.AddType(builder, Type);
			return IEnterOrbitalCameraControlByMove.EndIEnterOrbitalCameraControlByMove(builder);
		}

		// Token: 0x0602DBB7 RID: 187319 RVA: 0x00641AB1 File Offset: 0x0063FCB1
		public static void StartIEnterOrbitalCameraControlByMove(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0602DBB8 RID: 187320 RVA: 0x00641ABA File Offset: 0x0063FCBA
		public static void AddType(FlatBufferBuilder builder, EEnterOrbitalCameraType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602DBB9 RID: 187321 RVA: 0x00641AC5 File Offset: 0x0063FCC5
		public static void AddLevelSequence(FlatBufferBuilder builder, StringOffset levelSequenceOffset)
		{
			builder.AddOffset(1, levelSequenceOffset.Value, 0);
		}

		// Token: 0x0602DBBA RID: 187322 RVA: 0x00641AD5 File Offset: 0x0063FCD5
		public static void AddBlendInTime(FlatBufferBuilder builder, float blendInTime)
		{
			builder.AddFloat(2, blendInTime, 0.0);
		}

		// Token: 0x0602DBBB RID: 187323 RVA: 0x00641AE8 File Offset: 0x0063FCE8
		public static void AddBlendOutTime(FlatBufferBuilder builder, float blendOutTime)
		{
			builder.AddFloat(3, blendOutTime, 0.0);
		}

		// Token: 0x0602DBBC RID: 187324 RVA: 0x00641AFB File Offset: 0x0063FCFB
		public static void AddBegEntity(FlatBufferBuilder builder, int begEntity)
		{
			builder.AddInt(4, begEntity, 0);
		}

		// Token: 0x0602DBBD RID: 187325 RVA: 0x00641B06 File Offset: 0x0063FD06
		public static void AddEndEntity(FlatBufferBuilder builder, int endEntity)
		{
			builder.AddInt(5, endEntity, 0);
		}

		// Token: 0x0602DBBE RID: 187326 RVA: 0x00641B11 File Offset: 0x0063FD11
		public static Offset<IEnterOrbitalCameraControlByMove> EndIEnterOrbitalCameraControlByMove(FlatBufferBuilder builder)
		{
			return new Offset<IEnterOrbitalCameraControlByMove>(builder.EndTable());
		}

		// Token: 0x0602DBBF RID: 187327 RVA: 0x00641B20 File Offset: 0x0063FD20
		public IEnterOrbitalCameraControlByMoveT UnPack()
		{
			IEnterOrbitalCameraControlByMoveT enterOrbitalCameraControlByMoveT = new IEnterOrbitalCameraControlByMoveT();
			this.UnPackTo(enterOrbitalCameraControlByMoveT);
			return enterOrbitalCameraControlByMoveT;
		}

		// Token: 0x0602DBC0 RID: 187328 RVA: 0x00641B3C File Offset: 0x0063FD3C
		public void UnPackTo(IEnterOrbitalCameraControlByMoveT _o)
		{
			_o.Type = this.Type;
			_o.LevelSequence = this.LevelSequence;
			_o.BlendInTime = this.BlendInTime;
			_o.BlendOutTime = this.BlendOutTime;
			_o.BegEntity = this.BegEntity;
			_o.EndEntity = this.EndEntity;
		}

		// Token: 0x0602DBC1 RID: 187329 RVA: 0x00641B94 File Offset: 0x0063FD94
		public static Offset<IEnterOrbitalCameraControlByMove> Pack(FlatBufferBuilder builder, IEnterOrbitalCameraControlByMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterOrbitalCameraControlByMove>);
			}
			StringOffset levelSequenceOffset = (_o.LevelSequence == null) ? default(StringOffset) : builder.CreateString(_o.LevelSequence);
			return IEnterOrbitalCameraControlByMove.CreateIEnterOrbitalCameraControlByMove(builder, _o.Type, levelSequenceOffset, _o.BlendInTime, _o.BlendOutTime, _o.BegEntity, _o.EndEntity);
		}

		// Token: 0x04010D88 RID: 69000
		private Table __p;
	}
}
