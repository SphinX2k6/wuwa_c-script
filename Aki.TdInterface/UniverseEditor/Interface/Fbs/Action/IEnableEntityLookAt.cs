using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CCB RID: 27851
	public struct IEnableEntityLookAt : IFlatbufferObject
	{
		// Token: 0x1700CC42 RID: 52290
		// (get) Token: 0x0602FFF6 RID: 196598 RVA: 0x006880E6 File Offset: 0x006862E6
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FFF7 RID: 196599 RVA: 0x006880F3 File Offset: 0x006862F3
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FFF8 RID: 196600 RVA: 0x006880FC File Offset: 0x006862FC
		public static IEnableEntityLookAt GetRootAsIEnableEntityLookAt(ByteBuffer _bb)
		{
			return IEnableEntityLookAt.GetRootAsIEnableEntityLookAt(_bb, default(IEnableEntityLookAt));
		}

		// Token: 0x0602FFF9 RID: 196601 RVA: 0x00688118 File Offset: 0x00686318
		public static IEnableEntityLookAt GetRootAsIEnableEntityLookAt(ByteBuffer _bb, IEnableEntityLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FFFA RID: 196602 RVA: 0x00688135 File Offset: 0x00686335
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FFFB RID: 196603 RVA: 0x00688144 File Offset: 0x00686344
		public IEnableEntityLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC43 RID: 52291
		// (get) Token: 0x0602FFFC RID: 196604 RVA: 0x00688154 File Offset: 0x00686354
		public string Key
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FFFD RID: 196605 RVA: 0x0068818B File Offset: 0x0068638B
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602FFFE RID: 196606 RVA: 0x0068819A File Offset: 0x0068639A
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700CC44 RID: 52292
		// (get) Token: 0x0602FFFF RID: 196607 RVA: 0x006881A8 File Offset: 0x006863A8
		public TDefaultLookAtType DefaultLookAtTypeType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TDefaultLookAtType.NONE;
				}
				return (TDefaultLookAtType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06030000 RID: 196608 RVA: 0x006881E4 File Offset: 0x006863E4
		public TTable? DefaultLookAtType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06030001 RID: 196609 RVA: 0x00688228 File Offset: 0x00686428
		public ILookAtBubbleEntity DefaultLookAtTypeAsILookAtBubbleEntity()
		{
			return this.DefaultLookAtType<ILookAtBubbleEntity>().Value;
		}

		// Token: 0x06030002 RID: 196610 RVA: 0x00688244 File Offset: 0x00686444
		public ILookAtTarget DefaultLookAtTypeAsILookAtTarget()
		{
			return this.DefaultLookAtType<ILookAtTarget>().Value;
		}

		// Token: 0x1700CC45 RID: 52293
		// (get) Token: 0x06030003 RID: 196611 RVA: 0x00688260 File Offset: 0x00686460
		public ICheckFlowLookAt? OverrideLookAtType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ICheckFlowLookAt?(default(ICheckFlowLookAt).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06030004 RID: 196612 RVA: 0x006882C0 File Offset: 0x006864C0
		public int EntityIds(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700CC46 RID: 52294
		// (get) Token: 0x06030005 RID: 196613 RVA: 0x00688300 File Offset: 0x00686500
		public int EntityIdsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06030006 RID: 196614 RVA: 0x0068832C File Offset: 0x0068652C
		public Span<int> GetEntityIdsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06030007 RID: 196615 RVA: 0x0068833C File Offset: 0x0068653C
		public int[] GetEntityIdsArray()
		{
			return this.__p.__vector_as_array<int>(12);
		}

		// Token: 0x06030008 RID: 196616 RVA: 0x0068834B File Offset: 0x0068654B
		public static Offset<IEnableEntityLookAt> CreateIEnableEntityLookAt(FlatBufferBuilder builder, StringOffset KeyOffset = default(StringOffset), TDefaultLookAtType DefaultLookAtType_type = TDefaultLookAtType.NONE, int DefaultLookAtTypeOffset = 0, Offset<ICheckFlowLookAt> OverrideLookAtTypeOffset = default(Offset<ICheckFlowLookAt>), VectorOffset EntityIdsOffset = default(VectorOffset))
		{
			builder.StartTable(5);
			IEnableEntityLookAt.AddEntityIds(builder, EntityIdsOffset);
			IEnableEntityLookAt.AddOverrideLookAtType(builder, OverrideLookAtTypeOffset);
			IEnableEntityLookAt.AddDefaultLookAtType(builder, DefaultLookAtTypeOffset);
			IEnableEntityLookAt.AddKey(builder, KeyOffset);
			IEnableEntityLookAt.AddDefaultLookAtTypeType(builder, DefaultLookAtType_type);
			return IEnableEntityLookAt.EndIEnableEntityLookAt(builder);
		}

		// Token: 0x06030009 RID: 196617 RVA: 0x0068837F File Offset: 0x0068657F
		public static void StartIEnableEntityLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0603000A RID: 196618 RVA: 0x00688388 File Offset: 0x00686588
		public static void AddKey(FlatBufferBuilder builder, StringOffset keyOffset)
		{
			builder.AddOffset(0, keyOffset.Value, 0);
		}

		// Token: 0x0603000B RID: 196619 RVA: 0x00688398 File Offset: 0x00686598
		public static void AddDefaultLookAtTypeType(FlatBufferBuilder builder, TDefaultLookAtType defaultLookAtTypeType)
		{
			builder.AddByte(1, (byte)defaultLookAtTypeType, 0);
		}

		// Token: 0x0603000C RID: 196620 RVA: 0x006883A3 File Offset: 0x006865A3
		public static void AddDefaultLookAtType(FlatBufferBuilder builder, int defaultLookAtTypeOffset)
		{
			builder.AddOffset(2, defaultLookAtTypeOffset, 0);
		}

		// Token: 0x0603000D RID: 196621 RVA: 0x006883AE File Offset: 0x006865AE
		public static void AddOverrideLookAtType(FlatBufferBuilder builder, Offset<ICheckFlowLookAt> overrideLookAtTypeOffset)
		{
			builder.AddOffset(3, overrideLookAtTypeOffset.Value, 0);
		}

		// Token: 0x0603000E RID: 196622 RVA: 0x006883BE File Offset: 0x006865BE
		public static void AddEntityIds(FlatBufferBuilder builder, VectorOffset entityIdsOffset)
		{
			builder.AddOffset(4, entityIdsOffset.Value, 0);
		}

		// Token: 0x0603000F RID: 196623 RVA: 0x006883D0 File Offset: 0x006865D0
		public static VectorOffset CreateEntityIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06030010 RID: 196624 RVA: 0x00688407 File Offset: 0x00686607
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030011 RID: 196625 RVA: 0x00688421 File Offset: 0x00686621
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06030012 RID: 196626 RVA: 0x0068843F File Offset: 0x0068663F
		public static VectorOffset CreateEntityIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030013 RID: 196627 RVA: 0x00688458 File Offset: 0x00686658
		public static void StartEntityIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030014 RID: 196628 RVA: 0x00688463 File Offset: 0x00686663
		public static Offset<IEnableEntityLookAt> EndIEnableEntityLookAt(FlatBufferBuilder builder)
		{
			return new Offset<IEnableEntityLookAt>(builder.EndTable());
		}

		// Token: 0x06030015 RID: 196629 RVA: 0x00688470 File Offset: 0x00686670
		public IEnableEntityLookAtT UnPack()
		{
			IEnableEntityLookAtT enableEntityLookAtT = new IEnableEntityLookAtT();
			this.UnPackTo(enableEntityLookAtT);
			return enableEntityLookAtT;
		}

		// Token: 0x06030016 RID: 196630 RVA: 0x0068848C File Offset: 0x0068668C
		public void UnPackTo(IEnableEntityLookAtT _o)
		{
			_o.Key = this.Key;
			_o.DefaultLookAtType = new TDefaultLookAtTypeUnion();
			_o.DefaultLookAtType.Type = this.DefaultLookAtTypeType;
			TDefaultLookAtType defaultLookAtTypeType = this.DefaultLookAtTypeType;
			if (defaultLookAtTypeType != TDefaultLookAtType.ILookAtBubbleEntity)
			{
				if (defaultLookAtTypeType == TDefaultLookAtType.ILookAtTarget)
				{
					_o.DefaultLookAtType.Value = ((this.DefaultLookAtType<ILookAtTarget>() != null) ? this.DefaultLookAtType<ILookAtTarget>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.DefaultLookAtType.Value = ((this.DefaultLookAtType<ILookAtBubbleEntity>() != null) ? this.DefaultLookAtType<ILookAtBubbleEntity>().Value.UnPack() : null);
			}
			_o.OverrideLookAtType = ((this.OverrideLookAtType != null) ? this.OverrideLookAtType.Value.UnPack() : null);
			_o.EntityIds = new List<int>();
			for (int i = 0; i < this.EntityIdsLength; i++)
			{
				_o.EntityIds.Add(this.EntityIds(i));
			}
		}

		// Token: 0x06030017 RID: 196631 RVA: 0x006885A4 File Offset: 0x006867A4
		public static Offset<IEnableEntityLookAt> Pack(FlatBufferBuilder builder, IEnableEntityLookAtT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEnableEntityLookAt>);
			}
			StringOffset keyOffset = (_o.Key == null) ? default(StringOffset) : builder.CreateString(_o.Key);
			TDefaultLookAtType defaultLookAtType_type = (_o.DefaultLookAtType == null) ? TDefaultLookAtType.NONE : _o.DefaultLookAtType.Type;
			int defaultLookAtTypeOffset = (_o.DefaultLookAtType == null) ? 0 : TDefaultLookAtTypeUnion.Pack(builder, _o.DefaultLookAtType);
			Offset<ICheckFlowLookAt> overrideLookAtTypeOffset = (_o.OverrideLookAtType == null) ? default(Offset<ICheckFlowLookAt>) : ICheckFlowLookAt.Pack(builder, _o.OverrideLookAtType);
			VectorOffset entityIdsOffset = default(VectorOffset);
			if (_o.EntityIds != null)
			{
				int[] data = _o.EntityIds.ToArray();
				entityIdsOffset = IEnableEntityLookAt.CreateEntityIdsVector(builder, data);
			}
			return IEnableEntityLookAt.CreateIEnableEntityLookAt(builder, keyOffset, defaultLookAtType_type, defaultLookAtTypeOffset, overrideLookAtTypeOffset, entityIdsOffset);
		}

		// Token: 0x04011B13 RID: 72467
		private Table __p;
	}
}
