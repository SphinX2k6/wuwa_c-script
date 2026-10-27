using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200544F RID: 21583
	public struct IInteractEntityPartPrefabBind : IFlatbufferObject
	{
		// Token: 0x17009EE7 RID: 40679
		// (get) Token: 0x060237F3 RID: 145395 RVA: 0x004E9614 File Offset: 0x004E7814
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060237F4 RID: 145396 RVA: 0x004E9621 File Offset: 0x004E7821
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060237F5 RID: 145397 RVA: 0x004E9628 File Offset: 0x004E7828
		public static IInteractEntityPartPrefabBind GetRootAsIInteractEntityPartPrefabBind(ByteBuffer _bb)
		{
			return IInteractEntityPartPrefabBind.GetRootAsIInteractEntityPartPrefabBind(_bb, default(IInteractEntityPartPrefabBind));
		}

		// Token: 0x060237F6 RID: 145398 RVA: 0x004E9644 File Offset: 0x004E7844
		public static IInteractEntityPartPrefabBind GetRootAsIInteractEntityPartPrefabBind(ByteBuffer _bb, IInteractEntityPartPrefabBind obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060237F7 RID: 145399 RVA: 0x004E9661 File Offset: 0x004E7861
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060237F8 RID: 145400 RVA: 0x004E9670 File Offset: 0x004E7870
		public IInteractEntityPartPrefabBind __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009EE8 RID: 40680
		// (get) Token: 0x060237F9 RID: 145401 RVA: 0x004E9680 File Offset: 0x004E7880
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

		// Token: 0x060237FA RID: 145402 RVA: 0x004E96BC File Offset: 0x004E78BC
		public IInteractEntityPartPrefabOptionPoint? OptionPoints(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IInteractEntityPartPrefabOptionPoint?(default(IInteractEntityPartPrefabOptionPoint).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009EE9 RID: 40681
		// (get) Token: 0x060237FB RID: 145403 RVA: 0x004E971C File Offset: 0x004E791C
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

		// Token: 0x060237FC RID: 145404 RVA: 0x004E9747 File Offset: 0x004E7947
		public static Offset<IInteractEntityPartPrefabBind> CreateIInteractEntityPartPrefabBind(FlatBufferBuilder builder, EInteractEntityPartBindType Type = EInteractEntityPartBindType.Prefab, VectorOffset OptionPointsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IInteractEntityPartPrefabBind.AddOptionPoints(builder, OptionPointsOffset);
			IInteractEntityPartPrefabBind.AddType(builder, Type);
			return IInteractEntityPartPrefabBind.EndIInteractEntityPartPrefabBind(builder);
		}

		// Token: 0x060237FD RID: 145405 RVA: 0x004E9764 File Offset: 0x004E7964
		public static void StartIInteractEntityPartPrefabBind(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060237FE RID: 145406 RVA: 0x004E976D File Offset: 0x004E796D
		public static void AddType(FlatBufferBuilder builder, EInteractEntityPartBindType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060237FF RID: 145407 RVA: 0x004E9778 File Offset: 0x004E7978
		public static void AddOptionPoints(FlatBufferBuilder builder, VectorOffset optionPointsOffset)
		{
			builder.AddOffset(1, optionPointsOffset.Value, 0);
		}

		// Token: 0x06023800 RID: 145408 RVA: 0x004E9788 File Offset: 0x004E7988
		public static VectorOffset CreateOptionPointsVector(FlatBufferBuilder builder, Offset<IInteractEntityPartPrefabOptionPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023801 RID: 145409 RVA: 0x004E97C8 File Offset: 0x004E79C8
		public static VectorOffset CreateOptionPointsVectorBlock(FlatBufferBuilder builder, Offset<IInteractEntityPartPrefabOptionPoint>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IInteractEntityPartPrefabOptionPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023802 RID: 145410 RVA: 0x004E97E2 File Offset: 0x004E79E2
		public static VectorOffset CreateOptionPointsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IInteractEntityPartPrefabOptionPoint>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IInteractEntityPartPrefabOptionPoint>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023803 RID: 145411 RVA: 0x004E9800 File Offset: 0x004E7A00
		public static VectorOffset CreateOptionPointsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IInteractEntityPartPrefabOptionPoint>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023804 RID: 145412 RVA: 0x004E9819 File Offset: 0x004E7A19
		public static void StartOptionPointsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023805 RID: 145413 RVA: 0x004E9824 File Offset: 0x004E7A24
		public static Offset<IInteractEntityPartPrefabBind> EndIInteractEntityPartPrefabBind(FlatBufferBuilder builder)
		{
			return new Offset<IInteractEntityPartPrefabBind>(builder.EndTable());
		}

		// Token: 0x06023806 RID: 145414 RVA: 0x004E9834 File Offset: 0x004E7A34
		public IInteractEntityPartPrefabBindT UnPack()
		{
			IInteractEntityPartPrefabBindT interactEntityPartPrefabBindT = new IInteractEntityPartPrefabBindT();
			this.UnPackTo(interactEntityPartPrefabBindT);
			return interactEntityPartPrefabBindT;
		}

		// Token: 0x06023807 RID: 145415 RVA: 0x004E9850 File Offset: 0x004E7A50
		public void UnPackTo(IInteractEntityPartPrefabBindT _o)
		{
			_o.Type = this.Type;
			_o.OptionPoints = new List<IInteractEntityPartPrefabOptionPointT>();
			for (int i = 0; i < this.OptionPointsLength; i++)
			{
				_o.OptionPoints.Add((this.OptionPoints(i) != null) ? this.OptionPoints(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06023808 RID: 145416 RVA: 0x004E98BC File Offset: 0x004E7ABC
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

		// Token: 0x0400E6C4 RID: 59076
		private Table __p;
	}
}
