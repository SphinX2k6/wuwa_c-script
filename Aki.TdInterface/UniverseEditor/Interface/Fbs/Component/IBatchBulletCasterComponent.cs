using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200542A RID: 21546
	public struct IBatchBulletCasterComponent : IFlatbufferObject
	{
		// Token: 0x170098F2 RID: 39154
		// (get) Token: 0x06021C40 RID: 138304 RVA: 0x004A7B93 File Offset: 0x004A5D93
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06021C41 RID: 138305 RVA: 0x004A7BA0 File Offset: 0x004A5DA0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06021C42 RID: 138306 RVA: 0x004A7BA8 File Offset: 0x004A5DA8
		public static IBatchBulletCasterComponent GetRootAsIBatchBulletCasterComponent(ByteBuffer _bb)
		{
			return IBatchBulletCasterComponent.GetRootAsIBatchBulletCasterComponent(_bb, default(IBatchBulletCasterComponent));
		}

		// Token: 0x06021C43 RID: 138307 RVA: 0x004A7BC4 File Offset: 0x004A5DC4
		public static IBatchBulletCasterComponent GetRootAsIBatchBulletCasterComponent(ByteBuffer _bb, IBatchBulletCasterComponent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06021C44 RID: 138308 RVA: 0x004A7BE1 File Offset: 0x004A5DE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06021C45 RID: 138309 RVA: 0x004A7BF0 File Offset: 0x004A5DF0
		public IBatchBulletCasterComponent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170098F3 RID: 39155
		// (get) Token: 0x06021C46 RID: 138310 RVA: 0x004A7C00 File Offset: 0x004A5E00
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170098F4 RID: 39156
		// (get) Token: 0x06021C47 RID: 138311 RVA: 0x004A7C40 File Offset: 0x004A5E40
		public string WarningEffect
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

		// Token: 0x06021C48 RID: 138312 RVA: 0x004A7C77 File Offset: 0x004A5E77
		public Span<byte> GetWarningEffectBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06021C49 RID: 138313 RVA: 0x004A7C86 File Offset: 0x004A5E86
		public byte[] GetWarningEffectArray()
		{
			return this.__p.__vector_as_array<byte>(6);
		}

		// Token: 0x170098F5 RID: 39157
		// (get) Token: 0x06021C4A RID: 138314 RVA: 0x004A7C94 File Offset: 0x004A5E94
		public EBatchBulletMovementType MovementType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return EBatchBulletMovementType.Sprint;
				}
				return (EBatchBulletMovementType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021C4B RID: 138315 RVA: 0x004A7CD0 File Offset: 0x004A5ED0
		public IPosRot? BulletList(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IPosRot?(default(IPosRot).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170098F6 RID: 39158
		// (get) Token: 0x06021C4C RID: 138316 RVA: 0x004A7D34 File Offset: 0x004A5F34
		public int BulletListLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06021C4D RID: 138317 RVA: 0x004A7D60 File Offset: 0x004A5F60
		public IBatchBulletItem? BatchList(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new IBatchBulletItem?(default(IBatchBulletItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170098F7 RID: 39159
		// (get) Token: 0x06021C4E RID: 138318 RVA: 0x004A7DC4 File Offset: 0x004A5FC4
		public int BatchListLength
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

		// Token: 0x170098F8 RID: 39160
		// (get) Token: 0x06021C4F RID: 138319 RVA: 0x004A7DF0 File Offset: 0x004A5FF0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06021C50 RID: 138320 RVA: 0x004A7E2D File Offset: 0x004A602D
		public static Offset<IBatchBulletCasterComponent> CreateIBatchBulletCasterComponent(FlatBufferBuilder builder, bool Disabled = false, StringOffset WarningEffectOffset = default(StringOffset), EBatchBulletMovementType MovementType = EBatchBulletMovementType.Sprint, VectorOffset BulletListOffset = default(VectorOffset), VectorOffset BatchListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(6);
			IBatchBulletCasterComponent.AddBatchList(builder, BatchListOffset);
			IBatchBulletCasterComponent.AddBulletList(builder, BulletListOffset);
			IBatchBulletCasterComponent.AddWarningEffect(builder, WarningEffectOffset);
			IBatchBulletCasterComponent.AddNullMask(builder, NullMask);
			IBatchBulletCasterComponent.AddMovementType(builder, MovementType);
			IBatchBulletCasterComponent.AddDisabled(builder, Disabled);
			return IBatchBulletCasterComponent.EndIBatchBulletCasterComponent(builder);
		}

		// Token: 0x06021C51 RID: 138321 RVA: 0x004A7E69 File Offset: 0x004A6069
		public static void StartIBatchBulletCasterComponent(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06021C52 RID: 138322 RVA: 0x004A7E72 File Offset: 0x004A6072
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06021C53 RID: 138323 RVA: 0x004A7E7D File Offset: 0x004A607D
		public static void AddWarningEffect(FlatBufferBuilder builder, StringOffset warningEffectOffset)
		{
			builder.AddOffset(1, warningEffectOffset.Value, 0);
		}

		// Token: 0x06021C54 RID: 138324 RVA: 0x004A7E8D File Offset: 0x004A608D
		public static void AddMovementType(FlatBufferBuilder builder, EBatchBulletMovementType movementType)
		{
			builder.AddByte(2, (byte)movementType, 0);
		}

		// Token: 0x06021C55 RID: 138325 RVA: 0x004A7E98 File Offset: 0x004A6098
		public static void AddBulletList(FlatBufferBuilder builder, VectorOffset bulletListOffset)
		{
			builder.AddOffset(3, bulletListOffset.Value, 0);
		}

		// Token: 0x06021C56 RID: 138326 RVA: 0x004A7EA8 File Offset: 0x004A60A8
		public static VectorOffset CreateBulletListVector(FlatBufferBuilder builder, Offset<IPosRot>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021C57 RID: 138327 RVA: 0x004A7EE8 File Offset: 0x004A60E8
		public static VectorOffset CreateBulletListVectorBlock(FlatBufferBuilder builder, Offset<IPosRot>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IPosRot>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021C58 RID: 138328 RVA: 0x004A7F02 File Offset: 0x004A6102
		public static VectorOffset CreateBulletListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IPosRot>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IPosRot>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021C59 RID: 138329 RVA: 0x004A7F20 File Offset: 0x004A6120
		public static VectorOffset CreateBulletListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IPosRot>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021C5A RID: 138330 RVA: 0x004A7F39 File Offset: 0x004A6139
		public static void StartBulletListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021C5B RID: 138331 RVA: 0x004A7F44 File Offset: 0x004A6144
		public static void AddBatchList(FlatBufferBuilder builder, VectorOffset batchListOffset)
		{
			builder.AddOffset(4, batchListOffset.Value, 0);
		}

		// Token: 0x06021C5C RID: 138332 RVA: 0x004A7F54 File Offset: 0x004A6154
		public static VectorOffset CreateBatchListVector(FlatBufferBuilder builder, Offset<IBatchBulletItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06021C5D RID: 138333 RVA: 0x004A7F94 File Offset: 0x004A6194
		public static VectorOffset CreateBatchListVectorBlock(FlatBufferBuilder builder, Offset<IBatchBulletItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IBatchBulletItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021C5E RID: 138334 RVA: 0x004A7FAE File Offset: 0x004A61AE
		public static VectorOffset CreateBatchListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IBatchBulletItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IBatchBulletItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x06021C5F RID: 138335 RVA: 0x004A7FCC File Offset: 0x004A61CC
		public static VectorOffset CreateBatchListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IBatchBulletItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06021C60 RID: 138336 RVA: 0x004A7FE5 File Offset: 0x004A61E5
		public static void StartBatchListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06021C61 RID: 138337 RVA: 0x004A7FF0 File Offset: 0x004A61F0
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06021C62 RID: 138338 RVA: 0x004A7FFB File Offset: 0x004A61FB
		public static Offset<IBatchBulletCasterComponent> EndIBatchBulletCasterComponent(FlatBufferBuilder builder)
		{
			return new Offset<IBatchBulletCasterComponent>(builder.EndTable());
		}

		// Token: 0x06021C63 RID: 138339 RVA: 0x004A8008 File Offset: 0x004A6208
		public IBatchBulletCasterComponentT UnPack()
		{
			IBatchBulletCasterComponentT batchBulletCasterComponentT = new IBatchBulletCasterComponentT();
			this.UnPackTo(batchBulletCasterComponentT);
			return batchBulletCasterComponentT;
		}

		// Token: 0x06021C64 RID: 138340 RVA: 0x004A8024 File Offset: 0x004A6224
		public void UnPackTo(IBatchBulletCasterComponentT _o)
		{
			_o.Disabled = this.Disabled;
			_o.WarningEffect = this.WarningEffect;
			_o.MovementType = this.MovementType;
			_o.BulletList = new List<IPosRotT>();
			for (int i = 0; i < this.BulletListLength; i++)
			{
				_o.BulletList.Add((this.BulletList(i) != null) ? this.BulletList(i).Value.UnPack() : null);
			}
			_o.BatchList = new List<IBatchBulletItemT>();
			for (int j = 0; j < this.BatchListLength; j++)
			{
				_o.BatchList.Add((this.BatchList(j) != null) ? this.BatchList(j).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06021C65 RID: 138341 RVA: 0x004A8108 File Offset: 0x004A6308
		public static Offset<IBatchBulletCasterComponent> Pack(FlatBufferBuilder builder, IBatchBulletCasterComponentT _o)
		{
			if (_o == null)
			{
				return default(Offset<IBatchBulletCasterComponent>);
			}
			StringOffset warningEffectOffset = (_o.WarningEffect == null) ? default(StringOffset) : builder.CreateString(_o.WarningEffect);
			VectorOffset bulletListOffset = default(VectorOffset);
			if (_o.BulletList != null)
			{
				Offset<IPosRot>[] array = new Offset<IPosRot>[_o.BulletList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IPosRot.Pack(builder, _o.BulletList[i]);
				}
				bulletListOffset = IBatchBulletCasterComponent.CreateBulletListVector(builder, array);
			}
			VectorOffset batchListOffset = default(VectorOffset);
			if (_o.BatchList != null)
			{
				Offset<IBatchBulletItem>[] array2 = new Offset<IBatchBulletItem>[_o.BatchList.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IBatchBulletItem.Pack(builder, _o.BatchList[j]);
				}
				batchListOffset = IBatchBulletCasterComponent.CreateBatchListVector(builder, array2);
			}
			return IBatchBulletCasterComponent.CreateIBatchBulletCasterComponent(builder, _o.Disabled, warningEffectOffset, _o.MovementType, bulletListOffset, batchListOffset, _o.NullMask);
		}

		// Token: 0x0400E8DC RID: 59612
		private Table __p;
	}
}
