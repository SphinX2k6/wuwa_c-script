using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C00 RID: 23552
	public struct INpcStandbyShowLooply : IFlatbufferObject
	{
		// Token: 0x1700AC59 RID: 44121
		// (get) Token: 0x06026E78 RID: 159352 RVA: 0x00553554 File Offset: 0x00551754
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026E79 RID: 159353 RVA: 0x00553561 File Offset: 0x00551761
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026E7A RID: 159354 RVA: 0x00553568 File Offset: 0x00551768
		public static INpcStandbyShowLooply GetRootAsINpcStandbyShowLooply(ByteBuffer _bb)
		{
			return INpcStandbyShowLooply.GetRootAsINpcStandbyShowLooply(_bb, default(INpcStandbyShowLooply));
		}

		// Token: 0x06026E7B RID: 159355 RVA: 0x00553584 File Offset: 0x00551784
		public static INpcStandbyShowLooply GetRootAsINpcStandbyShowLooply(ByteBuffer _bb, INpcStandbyShowLooply obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026E7C RID: 159356 RVA: 0x005535A1 File Offset: 0x005517A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026E7D RID: 159357 RVA: 0x005535B0 File Offset: 0x005517B0
		public INpcStandbyShowLooply __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AC5A RID: 44122
		// (get) Token: 0x06026E7E RID: 159358 RVA: 0x005535C0 File Offset: 0x005517C0
		public ENpcStandbyShowMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENpcStandbyShowMode.Finite;
				}
				return (ENpcStandbyShowMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026E7F RID: 159359 RVA: 0x005535FC File Offset: 0x005517FC
		public INpcLookAtConfig? LookAtConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INpcLookAtConfig?(default(INpcLookAtConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700AC5B RID: 44123
		// (get) Token: 0x06026E80 RID: 159360 RVA: 0x0055365C File Offset: 0x0055185C
		public int LookAtConfigsLength
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

		// Token: 0x1700AC5C RID: 44124
		// (get) Token: 0x06026E81 RID: 159361 RVA: 0x00553688 File Offset: 0x00551888
		public string Montage
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026E82 RID: 159362 RVA: 0x005536BF File Offset: 0x005518BF
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06026E83 RID: 159363 RVA: 0x005536CE File Offset: 0x005518CE
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700AC5D RID: 44125
		// (get) Token: 0x06026E84 RID: 159364 RVA: 0x005536DC File Offset: 0x005518DC
		public IMontageId? RegisteredMontageId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IMontageId?(default(IMontageId).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AC5E RID: 44126
		// (get) Token: 0x06026E85 RID: 159365 RVA: 0x0055373C File Offset: 0x0055193C
		public int FaceExpressionId
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

		// Token: 0x1700AC5F RID: 44127
		// (get) Token: 0x06026E86 RID: 159366 RVA: 0x0055377C File Offset: 0x0055197C
		public IIgnoreEntityIdsCollision? IgnoreEntityCollision
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new IIgnoreEntityIdsCollision?(default(IIgnoreEntityIdsCollision).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AC60 RID: 44128
		// (get) Token: 0x06026E87 RID: 159367 RVA: 0x005537DC File Offset: 0x005519DC
		public bool SetFadeInTimeToZero
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700AC61 RID: 44129
		// (get) Token: 0x06026E88 RID: 159368 RVA: 0x0055381C File Offset: 0x00551A1C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026E89 RID: 159369 RVA: 0x0055385C File Offset: 0x00551A5C
		public static Offset<INpcStandbyShowLooply> CreateINpcStandbyShowLooply(FlatBufferBuilder builder, ENpcStandbyShowMode Type = ENpcStandbyShowMode.Finite, VectorOffset LookAtConfigsOffset = default(VectorOffset), StringOffset MontageOffset = default(StringOffset), Offset<IMontageId> RegisteredMontageIdOffset = default(Offset<IMontageId>), int FaceExpressionId = 0, Offset<IIgnoreEntityIdsCollision> IgnoreEntityCollisionOffset = default(Offset<IIgnoreEntityIdsCollision>), bool SetFadeInTimeToZero = false, byte NullMask = 0)
		{
			builder.StartTable(8);
			INpcStandbyShowLooply.AddIgnoreEntityCollision(builder, IgnoreEntityCollisionOffset);
			INpcStandbyShowLooply.AddFaceExpressionId(builder, FaceExpressionId);
			INpcStandbyShowLooply.AddRegisteredMontageId(builder, RegisteredMontageIdOffset);
			INpcStandbyShowLooply.AddMontage(builder, MontageOffset);
			INpcStandbyShowLooply.AddLookAtConfigs(builder, LookAtConfigsOffset);
			INpcStandbyShowLooply.AddNullMask(builder, NullMask);
			INpcStandbyShowLooply.AddSetFadeInTimeToZero(builder, SetFadeInTimeToZero);
			INpcStandbyShowLooply.AddType(builder, Type);
			return INpcStandbyShowLooply.EndINpcStandbyShowLooply(builder);
		}

		// Token: 0x06026E8A RID: 159370 RVA: 0x005538B3 File Offset: 0x00551AB3
		public static void StartINpcStandbyShowLooply(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06026E8B RID: 159371 RVA: 0x005538BC File Offset: 0x00551ABC
		public static void AddType(FlatBufferBuilder builder, ENpcStandbyShowMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026E8C RID: 159372 RVA: 0x005538C7 File Offset: 0x00551AC7
		public static void AddLookAtConfigs(FlatBufferBuilder builder, VectorOffset lookAtConfigsOffset)
		{
			builder.AddOffset(1, lookAtConfigsOffset.Value, 0);
		}

		// Token: 0x06026E8D RID: 159373 RVA: 0x005538D8 File Offset: 0x00551AD8
		public static VectorOffset CreateLookAtConfigsVector(FlatBufferBuilder builder, Offset<INpcLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026E8E RID: 159374 RVA: 0x00553918 File Offset: 0x00551B18
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, Offset<INpcLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INpcLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026E8F RID: 159375 RVA: 0x00553932 File Offset: 0x00551B32
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INpcLookAtConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INpcLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026E90 RID: 159376 RVA: 0x00553950 File Offset: 0x00551B50
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INpcLookAtConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026E91 RID: 159377 RVA: 0x00553969 File Offset: 0x00551B69
		public static void StartLookAtConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026E92 RID: 159378 RVA: 0x00553974 File Offset: 0x00551B74
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(2, montageOffset.Value, 0);
		}

		// Token: 0x06026E93 RID: 159379 RVA: 0x00553984 File Offset: 0x00551B84
		public static void AddRegisteredMontageId(FlatBufferBuilder builder, Offset<IMontageId> registeredMontageIdOffset)
		{
			builder.AddOffset(3, registeredMontageIdOffset.Value, 0);
		}

		// Token: 0x06026E94 RID: 159380 RVA: 0x00553994 File Offset: 0x00551B94
		public static void AddFaceExpressionId(FlatBufferBuilder builder, int faceExpressionId)
		{
			builder.AddInt(4, faceExpressionId, 0);
		}

		// Token: 0x06026E95 RID: 159381 RVA: 0x0055399F File Offset: 0x00551B9F
		public static void AddIgnoreEntityCollision(FlatBufferBuilder builder, Offset<IIgnoreEntityIdsCollision> ignoreEntityCollisionOffset)
		{
			builder.AddOffset(5, ignoreEntityCollisionOffset.Value, 0);
		}

		// Token: 0x06026E96 RID: 159382 RVA: 0x005539AF File Offset: 0x00551BAF
		public static void AddSetFadeInTimeToZero(FlatBufferBuilder builder, bool setFadeInTimeToZero)
		{
			builder.AddBool(6, setFadeInTimeToZero, false);
		}

		// Token: 0x06026E97 RID: 159383 RVA: 0x005539BA File Offset: 0x00551BBA
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06026E98 RID: 159384 RVA: 0x005539C5 File Offset: 0x00551BC5
		public static Offset<INpcStandbyShowLooply> EndINpcStandbyShowLooply(FlatBufferBuilder builder)
		{
			return new Offset<INpcStandbyShowLooply>(builder.EndTable());
		}

		// Token: 0x06026E99 RID: 159385 RVA: 0x005539D4 File Offset: 0x00551BD4
		public INpcStandbyShowLooplyT UnPack()
		{
			INpcStandbyShowLooplyT npcStandbyShowLooplyT = new INpcStandbyShowLooplyT();
			this.UnPackTo(npcStandbyShowLooplyT);
			return npcStandbyShowLooplyT;
		}

		// Token: 0x06026E9A RID: 159386 RVA: 0x005539F0 File Offset: 0x00551BF0
		public void UnPackTo(INpcStandbyShowLooplyT _o)
		{
			_o.Type = this.Type;
			_o.LookAtConfigs = new List<INpcLookAtConfigT>();
			for (int i = 0; i < this.LookAtConfigsLength; i++)
			{
				_o.LookAtConfigs.Add((this.LookAtConfigs(i) != null) ? this.LookAtConfigs(i).Value.UnPack() : null);
			}
			_o.Montage = this.Montage;
			_o.RegisteredMontageId = ((this.RegisteredMontageId != null) ? this.RegisteredMontageId.Value.UnPack() : null);
			_o.FaceExpressionId = this.FaceExpressionId;
			_o.IgnoreEntityCollision = ((this.IgnoreEntityCollision != null) ? this.IgnoreEntityCollision.Value.UnPack() : null);
			_o.SetFadeInTimeToZero = this.SetFadeInTimeToZero;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06026E9B RID: 159387 RVA: 0x00553AF0 File Offset: 0x00551CF0
		public static Offset<INpcStandbyShowLooply> Pack(FlatBufferBuilder builder, INpcStandbyShowLooplyT _o)
		{
			if (_o == null)
			{
				return default(Offset<INpcStandbyShowLooply>);
			}
			VectorOffset lookAtConfigsOffset = default(VectorOffset);
			if (_o.LookAtConfigs != null)
			{
				Offset<INpcLookAtConfig>[] array = new Offset<INpcLookAtConfig>[_o.LookAtConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = INpcLookAtConfig.Pack(builder, _o.LookAtConfigs[i]);
				}
				lookAtConfigsOffset = INpcStandbyShowLooply.CreateLookAtConfigsVector(builder, array);
			}
			StringOffset montageOffset = (_o.Montage == null) ? default(StringOffset) : builder.CreateString(_o.Montage);
			Offset<IMontageId> registeredMontageIdOffset = (_o.RegisteredMontageId == null) ? default(Offset<IMontageId>) : IMontageId.Pack(builder, _o.RegisteredMontageId);
			Offset<IIgnoreEntityIdsCollision> ignoreEntityCollisionOffset = (_o.IgnoreEntityCollision == null) ? default(Offset<IIgnoreEntityIdsCollision>) : IIgnoreEntityIdsCollision.Pack(builder, _o.IgnoreEntityCollision);
			return INpcStandbyShowLooply.CreateINpcStandbyShowLooply(builder, _o.Type, lookAtConfigsOffset, montageOffset, registeredMontageIdOffset, _o.FaceExpressionId, ignoreEntityCollisionOffset, _o.SetFadeInTimeToZero, _o.NullMask);
		}

		// Token: 0x0400F67D RID: 63101
		private Table __p;
	}
}
