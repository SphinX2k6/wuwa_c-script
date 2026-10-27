using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005449 RID: 21577
	public struct IInteractEntityPartModelBind : IFlatbufferObject
	{
		// Token: 0x17009EDD RID: 40669
		// (get) Token: 0x060237BD RID: 145341 RVA: 0x004E9004 File Offset: 0x004E7204
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060237BE RID: 145342 RVA: 0x004E9011 File Offset: 0x004E7211
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060237BF RID: 145343 RVA: 0x004E9018 File Offset: 0x004E7218
		public static IInteractEntityPartModelBind GetRootAsIInteractEntityPartModelBind(ByteBuffer _bb)
		{
			return IInteractEntityPartModelBind.GetRootAsIInteractEntityPartModelBind(_bb, default(IInteractEntityPartModelBind));
		}

		// Token: 0x060237C0 RID: 145344 RVA: 0x004E9034 File Offset: 0x004E7234
		public static IInteractEntityPartModelBind GetRootAsIInteractEntityPartModelBind(ByteBuffer _bb, IInteractEntityPartModelBind obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060237C1 RID: 145345 RVA: 0x004E9051 File Offset: 0x004E7251
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060237C2 RID: 145346 RVA: 0x004E9060 File Offset: 0x004E7260
		public IInteractEntityPartModelBind __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009EDE RID: 40670
		// (get) Token: 0x060237C3 RID: 145347 RVA: 0x004E9070 File Offset: 0x004E7270
		public EInteractEntityPartBindType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInteractEntityPartBindType.Prefab;
				}
				return (EInteractEntityPartBindType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060237C4 RID: 145348 RVA: 0x004E90AC File Offset: 0x004E72AC
		public IInteractEntityPartModelOptionPoint? OptionPoints(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IInteractEntityPartModelOptionPoint?(default(IInteractEntityPartModelOptionPoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009EDF RID: 40671
		// (get) Token: 0x060237C5 RID: 145349 RVA: 0x004E910C File Offset: 0x004E730C
		public int OptionPointsLength
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

		// Token: 0x060237C6 RID: 145350 RVA: 0x004E9137 File Offset: 0x004E7337
		public static Offset<IInteractEntityPartModelBind> CreateIInteractEntityPartModelBind(FlatBufferBuilder builder, EInteractEntityPartBindType Type = EInteractEntityPartBindType.Prefab, VectorOffset OptionPointsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IInteractEntityPartModelBind.AddOptionPoints(builder, OptionPointsOffset);
			IInteractEntityPartModelBind.AddType(builder, Type);
			return IInteractEntityPartModelBind.EndIInteractEntityPartModelBind(builder);
		}

		// Token: 0x060237C7 RID: 145351 RVA: 0x004E9154 File Offset: 0x004E7354
		public static void StartIInteractEntityPartModelBind(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060237C8 RID: 145352 RVA: 0x004E915D File Offset: 0x004E735D
		public static void AddType(FlatBufferBuilder builder, EInteractEntityPartBindType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060237C9 RID: 145353 RVA: 0x004E9168 File Offset: 0x004E7368
		public static void AddOptionPoints(FlatBufferBuilder builder, VectorOffset optionPointsOffset)
		{
			builder.AddOffset(1, optionPointsOffset.Value, 0);
		}

		// Token: 0x060237CA RID: 145354 RVA: 0x004E9178 File Offset: 0x004E7378
		public static VectorOffset CreateOptionPointsVector(FlatBufferBuilder builder, Offset<IInteractEntityPartModelOptionPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060237CB RID: 145355 RVA: 0x004E91B8 File Offset: 0x004E73B8
		public static VectorOffset CreateOptionPointsVectorBlock(FlatBufferBuilder builder, Offset<IInteractEntityPartModelOptionPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInteractEntityPartModelOptionPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x060237CC RID: 145356 RVA: 0x004E91D2 File Offset: 0x004E73D2
		public static VectorOffset CreateOptionPointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInteractEntityPartModelOptionPoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInteractEntityPartModelOptionPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x060237CD RID: 145357 RVA: 0x004E91F0 File Offset: 0x004E73F0
		public static VectorOffset CreateOptionPointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInteractEntityPartModelOptionPoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060237CE RID: 145358 RVA: 0x004E9209 File Offset: 0x004E7409
		public static void StartOptionPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060237CF RID: 145359 RVA: 0x004E9214 File Offset: 0x004E7414
		public static Offset<IInteractEntityPartModelBind> EndIInteractEntityPartModelBind(FlatBufferBuilder builder)
		{
			return new Offset<IInteractEntityPartModelBind>(builder.EndTable());
		}

		// Token: 0x060237D0 RID: 145360 RVA: 0x004E9224 File Offset: 0x004E7424
		public IInteractEntityPartModelBindT UnPack()
		{
			IInteractEntityPartModelBindT interactEntityPartModelBindT = new IInteractEntityPartModelBindT();
			this.UnPackTo(interactEntityPartModelBindT);
			return interactEntityPartModelBindT;
		}

		// Token: 0x060237D1 RID: 145361 RVA: 0x004E9240 File Offset: 0x004E7440
		public void UnPackTo(IInteractEntityPartModelBindT _o)
		{
			_o.Type = this.Type;
			_o.OptionPoints = new List<IInteractEntityPartModelOptionPointT>();
			for (int i = 0; i < this.OptionPointsLength; i++)
			{
				_o.OptionPoints.Add((this.OptionPoints(i) != null) ? this.OptionPoints(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060237D2 RID: 145362 RVA: 0x004E92AC File Offset: 0x004E74AC
		public static Offset<IInteractEntityPartModelBind> Pack(FlatBufferBuilder builder, IInteractEntityPartModelBindT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractEntityPartModelBind>);
			}
			VectorOffset optionPointsOffset = default(VectorOffset);
			if (_o.OptionPoints != null)
			{
				Offset<IInteractEntityPartModelOptionPoint>[] array = new Offset<IInteractEntityPartModelOptionPoint>[_o.OptionPoints.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IInteractEntityPartModelOptionPoint.Pack(builder, _o.OptionPoints[i]);
				}
				optionPointsOffset = IInteractEntityPartModelBind.CreateOptionPointsVector(builder, array);
			}
			return IInteractEntityPartModelBind.CreateIInteractEntityPartModelBind(builder, _o.Type, optionPointsOffset);
		}

		// Token: 0x0400E6BE RID: 59070
		private Table __p;
	}
}
