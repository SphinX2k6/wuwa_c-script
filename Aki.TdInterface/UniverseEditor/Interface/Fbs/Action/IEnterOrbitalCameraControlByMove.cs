using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D3D RID: 27965
	public struct IEnterOrbitalCameraControlByMove : IFlatbufferObject
	{
		// Token: 0x1700CD24 RID: 52516
		// (get) Token: 0x060303C5 RID: 197573 RVA: 0x0068EB2B File Offset: 0x0068CD2B
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060303C6 RID: 197574 RVA: 0x0068EB38 File Offset: 0x0068CD38
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060303C7 RID: 197575 RVA: 0x0068EB40 File Offset: 0x0068CD40
		public static IEnterOrbitalCameraControlByMove GetRootAsIEnterOrbitalCameraControlByMove(ByteBuffer _bb)
		{
			return IEnterOrbitalCameraControlByMove.GetRootAsIEnterOrbitalCameraControlByMove(_bb, default(IEnterOrbitalCameraControlByMove));
		}

		// Token: 0x060303C8 RID: 197576 RVA: 0x0068EB5C File Offset: 0x0068CD5C
		public static IEnterOrbitalCameraControlByMove GetRootAsIEnterOrbitalCameraControlByMove(ByteBuffer _bb, IEnterOrbitalCameraControlByMove obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060303C9 RID: 197577 RVA: 0x0068EB79 File Offset: 0x0068CD79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060303CA RID: 197578 RVA: 0x0068EB88 File Offset: 0x0068CD88
		public IEnterOrbitalCameraControlByMove __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CD25 RID: 52517
		// (get) Token: 0x060303CB RID: 197579 RVA: 0x0068EB98 File Offset: 0x0068CD98
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

		// Token: 0x1700CD26 RID: 52518
		// (get) Token: 0x060303CC RID: 197580 RVA: 0x0068EBD4 File Offset: 0x0068CDD4
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

		// Token: 0x060303CD RID: 197581 RVA: 0x0068EC0B File Offset: 0x0068CE0B
		public Span<byte> GetLevelSequenceBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060303CE RID: 197582 RVA: 0x0068EC1A File Offset: 0x0068CE1A
		public byte[] GetLevelSequenceArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x1700CD27 RID: 52519
		// (get) Token: 0x060303CF RID: 197583 RVA: 0x0068EC28 File Offset: 0x0068CE28
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

		// Token: 0x1700CD28 RID: 52520
		// (get) Token: 0x060303D0 RID: 197584 RVA: 0x0068EC68 File Offset: 0x0068CE68
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

		// Token: 0x1700CD29 RID: 52521
		// (get) Token: 0x060303D1 RID: 197585 RVA: 0x0068ECAC File Offset: 0x0068CEAC
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

		// Token: 0x1700CD2A RID: 52522
		// (get) Token: 0x060303D2 RID: 197586 RVA: 0x0068ECEC File Offset: 0x0068CEEC
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

		// Token: 0x060303D3 RID: 197587 RVA: 0x0068ED29 File Offset: 0x0068CF29
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

		// Token: 0x060303D4 RID: 197588 RVA: 0x0068ED65 File Offset: 0x0068CF65
		public static void StartIEnterOrbitalCameraControlByMove(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060303D5 RID: 197589 RVA: 0x0068ED6E File Offset: 0x0068CF6E
		public static void AddType(FlatBufferBuilder builder, EEnterOrbitalCameraType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060303D6 RID: 197590 RVA: 0x0068ED79 File Offset: 0x0068CF79
		public static void AddLevelSequence(FlatBufferBuilder builder, StringOffset levelSequenceOffset)
		{
			builder.AddOffset(1, levelSequenceOffset.Value, 0);
		}

		// Token: 0x060303D7 RID: 197591 RVA: 0x0068ED89 File Offset: 0x0068CF89
		public static void AddBlendInTime(FlatBufferBuilder builder, float blendInTime)
		{
			builder.AddFloat(2, blendInTime, 0.0);
		}

		// Token: 0x060303D8 RID: 197592 RVA: 0x0068ED9C File Offset: 0x0068CF9C
		public static void AddBlendOutTime(FlatBufferBuilder builder, float blendOutTime)
		{
			builder.AddFloat(3, blendOutTime, 0.0);
		}

		// Token: 0x060303D9 RID: 197593 RVA: 0x0068EDAF File Offset: 0x0068CFAF
		public static void AddBegEntity(FlatBufferBuilder builder, int begEntity)
		{
			builder.AddInt(4, begEntity, 0);
		}

		// Token: 0x060303DA RID: 197594 RVA: 0x0068EDBA File Offset: 0x0068CFBA
		public static void AddEndEntity(FlatBufferBuilder builder, int endEntity)
		{
			builder.AddInt(5, endEntity, 0);
		}

		// Token: 0x060303DB RID: 197595 RVA: 0x0068EDC5 File Offset: 0x0068CFC5
		public static Offset<IEnterOrbitalCameraControlByMove> EndIEnterOrbitalCameraControlByMove(FlatBufferBuilder builder)
		{
			return new Offset<IEnterOrbitalCameraControlByMove>(builder.EndTable());
		}

		// Token: 0x060303DC RID: 197596 RVA: 0x0068EDD4 File Offset: 0x0068CFD4
		public IEnterOrbitalCameraControlByMoveT UnPack()
		{
			IEnterOrbitalCameraControlByMoveT enterOrbitalCameraControlByMoveT = new IEnterOrbitalCameraControlByMoveT();
			this.UnPackTo(enterOrbitalCameraControlByMoveT);
			return enterOrbitalCameraControlByMoveT;
		}

		// Token: 0x060303DD RID: 197597 RVA: 0x0068EDF0 File Offset: 0x0068CFF0
		public void UnPackTo(IEnterOrbitalCameraControlByMoveT _o)
		{
			_o.Type = this.Type;
			_o.LevelSequence = this.LevelSequence;
			_o.BlendInTime = this.BlendInTime;
			_o.BlendOutTime = this.BlendOutTime;
			_o.BegEntity = this.BegEntity;
			_o.EndEntity = this.EndEntity;
		}

		// Token: 0x060303DE RID: 197598 RVA: 0x0068EE48 File Offset: 0x0068D048
		public static Offset<IEnterOrbitalCameraControlByMove> Pack(FlatBufferBuilder builder, IEnterOrbitalCameraControlByMoveT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnterOrbitalCameraControlByMove>);
			}
			StringOffset levelSequenceOffset = (_o.LevelSequence == null) ? default(StringOffset) : builder.CreateString(_o.LevelSequence);
			return IEnterOrbitalCameraControlByMove.CreateIEnterOrbitalCameraControlByMove(builder, _o.Type, levelSequenceOffset, _o.BlendInTime, _o.BlendOutTime, _o.BegEntity, _o.EndEntity);
		}

		// Token: 0x04011BAE RID: 72622
		private Table __p;
	}
}
