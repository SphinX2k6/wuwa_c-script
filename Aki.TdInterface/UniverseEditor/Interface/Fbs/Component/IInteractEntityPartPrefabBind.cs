using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059D5 RID: 22997
	public struct IInteractEntityPartPrefabBind : IFlatbufferObject
	{
		// Token: 0x1700A721 RID: 42785
		// (get) Token: 0x060258AB RID: 153771 RVA: 0x00526688 File Offset: 0x00524888
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060258AC RID: 153772 RVA: 0x00526695 File Offset: 0x00524895
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060258AD RID: 153773 RVA: 0x0052669C File Offset: 0x0052489C
		public static IInteractEntityPartPrefabBind GetRootAsIInteractEntityPartPrefabBind(ByteBuffer _bb)
		{
			return IInteractEntityPartPrefabBind.GetRootAsIInteractEntityPartPrefabBind(_bb, default(IInteractEntityPartPrefabBind));
		}

		// Token: 0x060258AE RID: 153774 RVA: 0x005266B8 File Offset: 0x005248B8
		public static IInteractEntityPartPrefabBind GetRootAsIInteractEntityPartPrefabBind(ByteBuffer _bb, IInteractEntityPartPrefabBind obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060258AF RID: 153775 RVA: 0x005266D5 File Offset: 0x005248D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060258B0 RID: 153776 RVA: 0x005266E4 File Offset: 0x005248E4
		public IInteractEntityPartPrefabBind __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A722 RID: 42786
		// (get) Token: 0x060258B1 RID: 153777 RVA: 0x005266F4 File Offset: 0x005248F4
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

		// Token: 0x060258B2 RID: 153778 RVA: 0x00526730 File Offset: 0x00524930
		public IInteractEntityPartPrefabOptionPoint? OptionPoints(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IInteractEntityPartPrefabOptionPoint?(default(IInteractEntityPartPrefabOptionPoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A723 RID: 42787
		// (get) Token: 0x060258B3 RID: 153779 RVA: 0x00526790 File Offset: 0x00524990
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

		// Token: 0x060258B4 RID: 153780 RVA: 0x005267BB File Offset: 0x005249BB
		public static Offset<IInteractEntityPartPrefabBind> CreateIInteractEntityPartPrefabBind(FlatBufferBuilder builder, EInteractEntityPartBindType Type = EInteractEntityPartBindType.Prefab, VectorOffset OptionPointsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IInteractEntityPartPrefabBind.AddOptionPoints(builder, OptionPointsOffset);
			IInteractEntityPartPrefabBind.AddType(builder, Type);
			return IInteractEntityPartPrefabBind.EndIInteractEntityPartPrefabBind(builder);
		}

		// Token: 0x060258B5 RID: 153781 RVA: 0x005267D8 File Offset: 0x005249D8
		public static void StartIInteractEntityPartPrefabBind(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060258B6 RID: 153782 RVA: 0x005267E1 File Offset: 0x005249E1
		public static void AddType(FlatBufferBuilder builder, EInteractEntityPartBindType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060258B7 RID: 153783 RVA: 0x005267EC File Offset: 0x005249EC
		public static void AddOptionPoints(FlatBufferBuilder builder, VectorOffset optionPointsOffset)
		{
			builder.AddOffset(1, optionPointsOffset.Value, 0);
		}

		// Token: 0x060258B8 RID: 153784 RVA: 0x005267FC File Offset: 0x005249FC
		public static VectorOffset CreateOptionPointsVector(FlatBufferBuilder builder, Offset<IInteractEntityPartPrefabOptionPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060258B9 RID: 153785 RVA: 0x0052683C File Offset: 0x00524A3C
		public static VectorOffset CreateOptionPointsVectorBlock(FlatBufferBuilder builder, Offset<IInteractEntityPartPrefabOptionPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInteractEntityPartPrefabOptionPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x060258BA RID: 153786 RVA: 0x00526856 File Offset: 0x00524A56
		public static VectorOffset CreateOptionPointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInteractEntityPartPrefabOptionPoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInteractEntityPartPrefabOptionPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x060258BB RID: 153787 RVA: 0x00526874 File Offset: 0x00524A74
		public static VectorOffset CreateOptionPointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInteractEntityPartPrefabOptionPoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060258BC RID: 153788 RVA: 0x0052688D File Offset: 0x00524A8D
		public static void StartOptionPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060258BD RID: 153789 RVA: 0x00526898 File Offset: 0x00524A98
		public static Offset<IInteractEntityPartPrefabBind> EndIInteractEntityPartPrefabBind(FlatBufferBuilder builder)
		{
			return new Offset<IInteractEntityPartPrefabBind>(builder.EndTable());
		}

		// Token: 0x060258BE RID: 153790 RVA: 0x005268A8 File Offset: 0x00524AA8
		public IInteractEntityPartPrefabBindT UnPack()
		{
			IInteractEntityPartPrefabBindT interactEntityPartPrefabBindT = new IInteractEntityPartPrefabBindT();
			this.UnPackTo(interactEntityPartPrefabBindT);
			return interactEntityPartPrefabBindT;
		}

		// Token: 0x060258BF RID: 153791 RVA: 0x005268C4 File Offset: 0x00524AC4
		public void UnPackTo(IInteractEntityPartPrefabBindT _o)
		{
			_o.Type = this.Type;
			_o.OptionPoints = new List<IInteractEntityPartPrefabOptionPointT>();
			for (int i = 0; i < this.OptionPointsLength; i++)
			{
				_o.OptionPoints.Add((this.OptionPoints(i) != null) ? this.OptionPoints(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060258C0 RID: 153792 RVA: 0x00526930 File Offset: 0x00524B30
		public static Offset<IInteractEntityPartPrefabBind> Pack(FlatBufferBuilder builder, IInteractEntityPartPrefabBindT _o)
		{
			if (_o == null)
			{
				return default(Offset<IInteractEntityPartPrefabBind>);
			}
			VectorOffset optionPointsOffset = default(VectorOffset);
			if (_o.OptionPoints != null)
			{
				Offset<IInteractEntityPartPrefabOptionPoint>[] array = new Offset<IInteractEntityPartPrefabOptionPoint>[_o.OptionPoints.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IInteractEntityPartPrefabOptionPoint.Pack(builder, _o.OptionPoints[i]);
				}
				optionPointsOffset = IInteractEntityPartPrefabBind.CreateOptionPointsVector(builder, array);
			}
			return IInteractEntityPartPrefabBind.CreateIInteractEntityPartPrefabBind(builder, _o.Type, optionPointsOffset);
		}

		// Token: 0x0400F2F5 RID: 62197
		private Table __p;
	}
}
