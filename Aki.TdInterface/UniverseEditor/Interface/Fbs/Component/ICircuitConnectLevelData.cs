using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054E1 RID: 21729
	public struct ICircuitConnectLevelData : IFlatbufferObject
	{
		// Token: 0x17009B37 RID: 39735
		// (get) Token: 0x060224CB RID: 140491 RVA: 0x004BA604 File Offset: 0x004B8804
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060224CC RID: 140492 RVA: 0x004BA611 File Offset: 0x004B8811
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060224CD RID: 140493 RVA: 0x004BA618 File Offset: 0x004B8818
		public static ICircuitConnectLevelData GetRootAsICircuitConnectLevelData(ByteBuffer _bb)
		{
			return ICircuitConnectLevelData.GetRootAsICircuitConnectLevelData(_bb, default(ICircuitConnectLevelData));
		}

		// Token: 0x060224CE RID: 140494 RVA: 0x004BA634 File Offset: 0x004B8834
		public static ICircuitConnectLevelData GetRootAsICircuitConnectLevelData(ByteBuffer _bb, ICircuitConnectLevelData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060224CF RID: 140495 RVA: 0x004BA651 File Offset: 0x004B8851
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060224D0 RID: 140496 RVA: 0x004BA660 File Offset: 0x004B8860
		public ICircuitConnectLevelData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B38 RID: 39736
		// (get) Token: 0x060224D1 RID: 140497 RVA: 0x004BA670 File Offset: 0x004B8870
		public TCircuitConnectMode ModeType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TCircuitConnectMode.NONE;
				}
				return (TCircuitConnectMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060224D2 RID: 140498 RVA: 0x004BA6AC File Offset: 0x004B88AC
		public TTable? Mode<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060224D3 RID: 140499 RVA: 0x004BA6F0 File Offset: 0x004B88F0
		public ICircuitConnectThreeRings ModeAsICircuitConnectThreeRings()
		{
			return this.Mode<ICircuitConnectThreeRings>().Value;
		}

		// Token: 0x060224D4 RID: 140500 RVA: 0x004BA70C File Offset: 0x004B890C
		public ICircuitConnectTwoRings ModeAsICircuitConnectTwoRings()
		{
			return this.Mode<ICircuitConnectTwoRings>().Value;
		}

		// Token: 0x17009B39 RID: 39737
		// (get) Token: 0x060224D5 RID: 140501 RVA: 0x004BA728 File Offset: 0x004B8928
		public float RotationSpeed
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

		// Token: 0x17009B3A RID: 39738
		// (get) Token: 0x060224D6 RID: 140502 RVA: 0x004BA768 File Offset: 0x004B8968
		public float ConnectTolerance
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

		// Token: 0x060224D7 RID: 140503 RVA: 0x004BA7AC File Offset: 0x004B89AC
		public ICircuitConnectLinkageGroup? LinkageGroups(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new ICircuitConnectLinkageGroup?(default(ICircuitConnectLinkageGroup).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009B3B RID: 39739
		// (get) Token: 0x060224D8 RID: 140504 RVA: 0x004BA810 File Offset: 0x004B8A10
		public int LinkageGroupsLength
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

		// Token: 0x060224D9 RID: 140505 RVA: 0x004BA83C File Offset: 0x004B8A3C
		public ICircuitConnectLayout? Layout(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new ICircuitConnectLayout?(default(ICircuitConnectLayout).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009B3C RID: 39740
		// (get) Token: 0x060224DA RID: 140506 RVA: 0x004BA8A0 File Offset: 0x004B8AA0
		public int LayoutLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060224DB RID: 140507 RVA: 0x004BA8CC File Offset: 0x004B8ACC
		public static Offset<ICircuitConnectLevelData> CreateICircuitConnectLevelData(FlatBufferBuilder builder, TCircuitConnectMode Mode_type = TCircuitConnectMode.NONE, int ModeOffset = 0, float RotationSpeed = 0f, float ConnectTolerance = 0f, VectorOffset LinkageGroupsOffset = default(VectorOffset), VectorOffset LayoutOffset = default(VectorOffset))
		{
			builder.StartTable(6);
			ICircuitConnectLevelData.AddLayout(builder, LayoutOffset);
			ICircuitConnectLevelData.AddLinkageGroups(builder, LinkageGroupsOffset);
			ICircuitConnectLevelData.AddConnectTolerance(builder, ConnectTolerance);
			ICircuitConnectLevelData.AddRotationSpeed(builder, RotationSpeed);
			ICircuitConnectLevelData.AddMode(builder, ModeOffset);
			ICircuitConnectLevelData.AddModeType(builder, Mode_type);
			return ICircuitConnectLevelData.EndICircuitConnectLevelData(builder);
		}

		// Token: 0x060224DC RID: 140508 RVA: 0x004BA908 File Offset: 0x004B8B08
		public static void StartICircuitConnectLevelData(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x060224DD RID: 140509 RVA: 0x004BA911 File Offset: 0x004B8B11
		public static void AddModeType(FlatBufferBuilder builder, TCircuitConnectMode modeType)
		{
			builder.AddByte(0, (byte)modeType, 0);
		}

		// Token: 0x060224DE RID: 140510 RVA: 0x004BA91C File Offset: 0x004B8B1C
		public static void AddMode(FlatBufferBuilder builder, int modeOffset)
		{
			builder.AddOffset(1, modeOffset, 0);
		}

		// Token: 0x060224DF RID: 140511 RVA: 0x004BA927 File Offset: 0x004B8B27
		public static void AddRotationSpeed(FlatBufferBuilder builder, float rotationSpeed)
		{
			builder.AddFloat(2, rotationSpeed, 0.0);
		}

		// Token: 0x060224E0 RID: 140512 RVA: 0x004BA93A File Offset: 0x004B8B3A
		public static void AddConnectTolerance(FlatBufferBuilder builder, float connectTolerance)
		{
			builder.AddFloat(3, connectTolerance, 0.0);
		}

		// Token: 0x060224E1 RID: 140513 RVA: 0x004BA94D File Offset: 0x004B8B4D
		public static void AddLinkageGroups(FlatBufferBuilder builder, VectorOffset linkageGroupsOffset)
		{
			builder.AddOffset(4, linkageGroupsOffset.Value, 0);
		}

		// Token: 0x060224E2 RID: 140514 RVA: 0x004BA960 File Offset: 0x004B8B60
		public static VectorOffset CreateLinkageGroupsVector(FlatBufferBuilder builder, Offset<ICircuitConnectLinkageGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060224E3 RID: 140515 RVA: 0x004BA9A0 File Offset: 0x004B8BA0
		public static VectorOffset CreateLinkageGroupsVectorBlock(FlatBufferBuilder builder, Offset<ICircuitConnectLinkageGroup>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICircuitConnectLinkageGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x060224E4 RID: 140516 RVA: 0x004BA9BA File Offset: 0x004B8BBA
		public static VectorOffset CreateLinkageGroupsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICircuitConnectLinkageGroup>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICircuitConnectLinkageGroup>>(data);
			return builder.EndVector();
		}

		// Token: 0x060224E5 RID: 140517 RVA: 0x004BA9D8 File Offset: 0x004B8BD8
		public static VectorOffset CreateLinkageGroupsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICircuitConnectLinkageGroup>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060224E6 RID: 140518 RVA: 0x004BA9F1 File Offset: 0x004B8BF1
		public static void StartLinkageGroupsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060224E7 RID: 140519 RVA: 0x004BA9FC File Offset: 0x004B8BFC
		public static void AddLayout(FlatBufferBuilder builder, VectorOffset layoutOffset)
		{
			builder.AddOffset(5, layoutOffset.Value, 0);
		}

		// Token: 0x060224E8 RID: 140520 RVA: 0x004BAA0C File Offset: 0x004B8C0C
		public static VectorOffset CreateLayoutVector(FlatBufferBuilder builder, Offset<ICircuitConnectLayout>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060224E9 RID: 140521 RVA: 0x004BAA4C File Offset: 0x004B8C4C
		public static VectorOffset CreateLayoutVectorBlock(FlatBufferBuilder builder, Offset<ICircuitConnectLayout>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICircuitConnectLayout>>(data);
			return builder.EndVector();
		}

		// Token: 0x060224EA RID: 140522 RVA: 0x004BAA66 File Offset: 0x004B8C66
		public static VectorOffset CreateLayoutVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICircuitConnectLayout>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICircuitConnectLayout>>(data);
			return builder.EndVector();
		}

		// Token: 0x060224EB RID: 140523 RVA: 0x004BAA84 File Offset: 0x004B8C84
		public static VectorOffset CreateLayoutVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICircuitConnectLayout>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060224EC RID: 140524 RVA: 0x004BAA9D File Offset: 0x004B8C9D
		public static void StartLayoutVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060224ED RID: 140525 RVA: 0x004BAAA8 File Offset: 0x004B8CA8
		public static Offset<ICircuitConnectLevelData> EndICircuitConnectLevelData(FlatBufferBuilder builder)
		{
			return new Offset<ICircuitConnectLevelData>(builder.EndTable());
		}

		// Token: 0x060224EE RID: 140526 RVA: 0x004BAAB8 File Offset: 0x004B8CB8
		public ICircuitConnectLevelDataT UnPack()
		{
			ICircuitConnectLevelDataT circuitConnectLevelDataT = new ICircuitConnectLevelDataT();
			this.UnPackTo(circuitConnectLevelDataT);
			return circuitConnectLevelDataT;
		}

		// Token: 0x060224EF RID: 140527 RVA: 0x004BAAD4 File Offset: 0x004B8CD4
		public void UnPackTo(ICircuitConnectLevelDataT _o)
		{
			_o.Mode = new TCircuitConnectModeUnion();
			_o.Mode.Type = this.ModeType;
			TCircuitConnectMode modeType = this.ModeType;
			if (modeType != TCircuitConnectMode.ICircuitConnectThreeRings)
			{
				if (modeType == TCircuitConnectMode.ICircuitConnectTwoRings)
				{
					_o.Mode.Value = ((this.Mode<ICircuitConnectTwoRings>() != null) ? this.Mode<ICircuitConnectTwoRings>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Mode.Value = ((this.Mode<ICircuitConnectThreeRings>() != null) ? this.Mode<ICircuitConnectThreeRings>().Value.UnPack() : null);
			}
			_o.RotationSpeed = this.RotationSpeed;
			_o.ConnectTolerance = this.ConnectTolerance;
			_o.LinkageGroups = new List<ICircuitConnectLinkageGroupT>();
			for (int i = 0; i < this.LinkageGroupsLength; i++)
			{
				_o.LinkageGroups.Add((this.LinkageGroups(i) != null) ? this.LinkageGroups(i).Value.UnPack() : null);
			}
			_o.Layout = new List<ICircuitConnectLayoutT>();
			for (int j = 0; j < this.LayoutLength; j++)
			{
				_o.Layout.Add((this.Layout(j) != null) ? this.Layout(j).Value.UnPack() : null);
			}
		}

		// Token: 0x060224F0 RID: 140528 RVA: 0x004BAC48 File Offset: 0x004B8E48
		public static Offset<ICircuitConnectLevelData> Pack(FlatBufferBuilder builder, ICircuitConnectLevelDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICircuitConnectLevelData>);
			}
			TCircuitConnectMode mode_type = (_o.Mode == null) ? TCircuitConnectMode.NONE : _o.Mode.Type;
			int modeOffset = (_o.Mode == null) ? 0 : TCircuitConnectModeUnion.Pack(builder, _o.Mode);
			VectorOffset linkageGroupsOffset = default(VectorOffset);
			if (_o.LinkageGroups != null)
			{
				Offset<ICircuitConnectLinkageGroup>[] array = new Offset<ICircuitConnectLinkageGroup>[_o.LinkageGroups.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICircuitConnectLinkageGroup.Pack(builder, _o.LinkageGroups[i]);
				}
				linkageGroupsOffset = ICircuitConnectLevelData.CreateLinkageGroupsVector(builder, array);
			}
			VectorOffset layoutOffset = default(VectorOffset);
			if (_o.Layout != null)
			{
				Offset<ICircuitConnectLayout>[] array2 = new Offset<ICircuitConnectLayout>[_o.Layout.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = ICircuitConnectLayout.Pack(builder, _o.Layout[j]);
				}
				layoutOffset = ICircuitConnectLevelData.CreateLayoutVector(builder, array2);
			}
			return ICircuitConnectLevelData.CreateICircuitConnectLevelData(builder, mode_type, modeOffset, _o.RotationSpeed, _o.ConnectTolerance, linkageGroupsOffset, layoutOffset);
		}

		// Token: 0x0400EA3A RID: 59962
		private Table __p;
	}
}
