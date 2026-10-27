using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200565F RID: 22111
	public struct INpcStandbyShowLooply : IFlatbufferObject
	{
		// Token: 0x1700A3CA RID: 41930
		// (get) Token: 0x06024C3F RID: 150591 RVA: 0x005129B8 File Offset: 0x00510BB8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024C40 RID: 150592 RVA: 0x005129C5 File Offset: 0x00510BC5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024C41 RID: 150593 RVA: 0x005129CC File Offset: 0x00510BCC
		public static INpcStandbyShowLooply GetRootAsINpcStandbyShowLooply(ByteBuffer _bb)
		{
			return INpcStandbyShowLooply.GetRootAsINpcStandbyShowLooply(_bb, default(INpcStandbyShowLooply));
		}

		// Token: 0x06024C42 RID: 150594 RVA: 0x005129E8 File Offset: 0x00510BE8
		public static INpcStandbyShowLooply GetRootAsINpcStandbyShowLooply(ByteBuffer _bb, INpcStandbyShowLooply obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024C43 RID: 150595 RVA: 0x00512A05 File Offset: 0x00510C05
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024C44 RID: 150596 RVA: 0x00512A14 File Offset: 0x00510C14
		public INpcStandbyShowLooply __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A3CB RID: 41931
		// (get) Token: 0x06024C45 RID: 150597 RVA: 0x00512A24 File Offset: 0x00510C24
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

		// Token: 0x06024C46 RID: 150598 RVA: 0x00512A60 File Offset: 0x00510C60
		public INpcLookAtConfig? LookAtConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new INpcLookAtConfig?(default(INpcLookAtConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A3CC RID: 41932
		// (get) Token: 0x06024C47 RID: 150599 RVA: 0x00512AC0 File Offset: 0x00510CC0
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

		// Token: 0x1700A3CD RID: 41933
		// (get) Token: 0x06024C48 RID: 150600 RVA: 0x00512AEC File Offset: 0x00510CEC
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

		// Token: 0x06024C49 RID: 150601 RVA: 0x00512B23 File Offset: 0x00510D23
		public Span<byte> GetMontageBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06024C4A RID: 150602 RVA: 0x00512B32 File Offset: 0x00510D32
		public byte[] GetMontageArray()
		{
			return this.__p.__vector_as_array<byte>(8);
		}

		// Token: 0x1700A3CE RID: 41934
		// (get) Token: 0x06024C4B RID: 150603 RVA: 0x00512B40 File Offset: 0x00510D40
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

		// Token: 0x1700A3CF RID: 41935
		// (get) Token: 0x06024C4C RID: 150604 RVA: 0x00512BA0 File Offset: 0x00510DA0
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

		// Token: 0x1700A3D0 RID: 41936
		// (get) Token: 0x06024C4D RID: 150605 RVA: 0x00512BE0 File Offset: 0x00510DE0
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

		// Token: 0x1700A3D1 RID: 41937
		// (get) Token: 0x06024C4E RID: 150606 RVA: 0x00512C40 File Offset: 0x00510E40
		public bool SetFadeInTimeToZero
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A3D2 RID: 41938
		// (get) Token: 0x06024C4F RID: 150607 RVA: 0x00512C80 File Offset: 0x00510E80
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

		// Token: 0x06024C50 RID: 150608 RVA: 0x00512CC0 File Offset: 0x00510EC0
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

		// Token: 0x06024C51 RID: 150609 RVA: 0x00512D17 File Offset: 0x00510F17
		public static void StartINpcStandbyShowLooply(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x06024C52 RID: 150610 RVA: 0x00512D20 File Offset: 0x00510F20
		public static void AddType(FlatBufferBuilder builder, ENpcStandbyShowMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06024C53 RID: 150611 RVA: 0x00512D2B File Offset: 0x00510F2B
		public static void AddLookAtConfigs(FlatBufferBuilder builder, VectorOffset lookAtConfigsOffset)
		{
			builder.AddOffset(1, lookAtConfigsOffset.Value, 0);
		}

		// Token: 0x06024C54 RID: 150612 RVA: 0x00512D3C File Offset: 0x00510F3C
		public static VectorOffset CreateLookAtConfigsVector(FlatBufferBuilder builder, Offset<INpcLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024C55 RID: 150613 RVA: 0x00512D7C File Offset: 0x00510F7C
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, Offset<INpcLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<INpcLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024C56 RID: 150614 RVA: 0x00512D96 File Offset: 0x00510F96
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<INpcLookAtConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<INpcLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024C57 RID: 150615 RVA: 0x00512DB4 File Offset: 0x00510FB4
		public static VectorOffset CreateLookAtConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<INpcLookAtConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024C58 RID: 150616 RVA: 0x00512DCD File Offset: 0x00510FCD
		public static void StartLookAtConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024C59 RID: 150617 RVA: 0x00512DD8 File Offset: 0x00510FD8
		public static void AddMontage(FlatBufferBuilder builder, StringOffset montageOffset)
		{
			builder.AddOffset(2, montageOffset.Value, 0);
		}

		// Token: 0x06024C5A RID: 150618 RVA: 0x00512DE8 File Offset: 0x00510FE8
		public static void AddRegisteredMontageId(FlatBufferBuilder builder, Offset<IMontageId> registeredMontageIdOffset)
		{
			builder.AddOffset(3, registeredMontageIdOffset.Value, 0);
		}

		// Token: 0x06024C5B RID: 150619 RVA: 0x00512DF8 File Offset: 0x00510FF8
		public static void AddFaceExpressionId(FlatBufferBuilder builder, int faceExpressionId)
		{
			builder.AddInt(4, faceExpressionId, 0);
		}

		// Token: 0x06024C5C RID: 150620 RVA: 0x00512E03 File Offset: 0x00511003
		public static void AddIgnoreEntityCollision(FlatBufferBuilder builder, Offset<IIgnoreEntityIdsCollision> ignoreEntityCollisionOffset)
		{
			builder.AddOffset(5, ignoreEntityCollisionOffset.Value, 0);
		}

		// Token: 0x06024C5D RID: 150621 RVA: 0x00512E13 File Offset: 0x00511013
		public static void AddSetFadeInTimeToZero(FlatBufferBuilder builder, bool setFadeInTimeToZero)
		{
			builder.AddBool(6, setFadeInTimeToZero, false);
		}

		// Token: 0x06024C5E RID: 150622 RVA: 0x00512E1E File Offset: 0x0051101E
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06024C5F RID: 150623 RVA: 0x00512E29 File Offset: 0x00511029
		public static Offset<INpcStandbyShowLooply> EndINpcStandbyShowLooply(FlatBufferBuilder builder)
		{
			return new Offset<INpcStandbyShowLooply>(builder.EndTable());
		}

		// Token: 0x06024C60 RID: 150624 RVA: 0x00512E38 File Offset: 0x00511038
		public INpcStandbyShowLooplyT UnPack()
		{
			INpcStandbyShowLooplyT npcStandbyShowLooplyT = new INpcStandbyShowLooplyT();
			this.UnPackTo(npcStandbyShowLooplyT);
			return npcStandbyShowLooplyT;
		}

		// Token: 0x06024C61 RID: 150625 RVA: 0x00512E54 File Offset: 0x00511054
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

		// Token: 0x06024C62 RID: 150626 RVA: 0x00512F54 File Offset: 0x00511154
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

		// Token: 0x0400EA14 RID: 59924
		private Table __p;
	}
}
