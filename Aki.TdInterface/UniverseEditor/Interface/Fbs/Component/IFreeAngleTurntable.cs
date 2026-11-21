using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005841 RID: 22593
	public struct IFreeAngleTurntable : IFlatbufferObject
	{
		// Token: 0x1700A39D RID: 41885
		// (get) Token: 0x0602495F RID: 149855 RVA: 0x00506D8A File Offset: 0x00504F8A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06024960 RID: 149856 RVA: 0x00506D97 File Offset: 0x00504F97
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06024961 RID: 149857 RVA: 0x00506DA0 File Offset: 0x00504FA0
		public static IFreeAngleTurntable GetRootAsIFreeAngleTurntable(ByteBuffer _bb)
		{
			return IFreeAngleTurntable.GetRootAsIFreeAngleTurntable(_bb, default(IFreeAngleTurntable));
		}

		// Token: 0x06024962 RID: 149858 RVA: 0x00506DBC File Offset: 0x00504FBC
		public static IFreeAngleTurntable GetRootAsIFreeAngleTurntable(ByteBuffer _bb, IFreeAngleTurntable obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06024963 RID: 149859 RVA: 0x00506DD9 File Offset: 0x00504FD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024964 RID: 149860 RVA: 0x00506DE8 File Offset: 0x00504FE8
		public IFreeAngleTurntable __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A39E RID: 41886
		// (get) Token: 0x06024965 RID: 149861 RVA: 0x00506DF8 File Offset: 0x00504FF8
		public EControllerType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EControllerType.FreeAngle;
				}
				return (EControllerType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A39F RID: 41887
		// (get) Token: 0x06024966 RID: 149862 RVA: 0x00506E34 File Offset: 0x00505034
		public int RotationSpeed
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06024967 RID: 149863 RVA: 0x00506E70 File Offset: 0x00505070
		public IFreeAngleItem? ItemConfig(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IFreeAngleItem?(default(IFreeAngleItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A3A0 RID: 41888
		// (get) Token: 0x06024968 RID: 149864 RVA: 0x00506ED0 File Offset: 0x005050D0
		public int ItemConfigLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A3A1 RID: 41889
		// (get) Token: 0x06024969 RID: 149865 RVA: 0x00506EFC File Offset: 0x005050FC
		public int IntervalAngle
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602496A RID: 149866 RVA: 0x00506F39 File Offset: 0x00505139
		public static Offset<IFreeAngleTurntable> CreateIFreeAngleTurntable(FlatBufferBuilder builder, EControllerType Type = EControllerType.FreeAngle, int RotationSpeed = 0, VectorOffset ItemConfigOffset = default(VectorOffset), int IntervalAngle = 0)
		{
			builder.StartTable(4);
			IFreeAngleTurntable.AddIntervalAngle(builder, IntervalAngle);
			IFreeAngleTurntable.AddItemConfig(builder, ItemConfigOffset);
			IFreeAngleTurntable.AddRotationSpeed(builder, RotationSpeed);
			IFreeAngleTurntable.AddType(builder, Type);
			return IFreeAngleTurntable.EndIFreeAngleTurntable(builder);
		}

		// Token: 0x0602496B RID: 149867 RVA: 0x00506F65 File Offset: 0x00505165
		public static void StartIFreeAngleTurntable(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602496C RID: 149868 RVA: 0x00506F6E File Offset: 0x0050516E
		public static void AddType(FlatBufferBuilder builder, EControllerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602496D RID: 149869 RVA: 0x00506F79 File Offset: 0x00505179
		public static void AddRotationSpeed(FlatBufferBuilder builder, int rotationSpeed)
		{
			builder.AddInt(1, rotationSpeed, 0);
		}

		// Token: 0x0602496E RID: 149870 RVA: 0x00506F84 File Offset: 0x00505184
		public static void AddItemConfig(FlatBufferBuilder builder, VectorOffset itemConfigOffset)
		{
			builder.AddOffset(2, itemConfigOffset.Value, 0);
		}

		// Token: 0x0602496F RID: 149871 RVA: 0x00506F94 File Offset: 0x00505194
		public static VectorOffset CreateItemConfigVector(FlatBufferBuilder builder, Offset<IFreeAngleItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06024970 RID: 149872 RVA: 0x00506FD4 File Offset: 0x005051D4
		public static VectorOffset CreateItemConfigVectorBlock(FlatBufferBuilder builder, Offset<IFreeAngleItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFreeAngleItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024971 RID: 149873 RVA: 0x00506FEE File Offset: 0x005051EE
		public static VectorOffset CreateItemConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFreeAngleItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFreeAngleItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x06024972 RID: 149874 RVA: 0x0050700C File Offset: 0x0050520C
		public static VectorOffset CreateItemConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFreeAngleItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06024973 RID: 149875 RVA: 0x00507025 File Offset: 0x00505225
		public static void StartItemConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06024974 RID: 149876 RVA: 0x00507030 File Offset: 0x00505230
		public static void AddIntervalAngle(FlatBufferBuilder builder, int intervalAngle)
		{
			builder.AddInt(3, intervalAngle, 0);
		}

		// Token: 0x06024975 RID: 149877 RVA: 0x0050703B File Offset: 0x0050523B
		public static Offset<IFreeAngleTurntable> EndIFreeAngleTurntable(FlatBufferBuilder builder)
		{
			return new Offset<IFreeAngleTurntable>(builder.EndTable());
		}

		// Token: 0x06024976 RID: 149878 RVA: 0x00507048 File Offset: 0x00505248
		public IFreeAngleTurntableT UnPack()
		{
			IFreeAngleTurntableT freeAngleTurntableT = new IFreeAngleTurntableT();
			this.UnPackTo(freeAngleTurntableT);
			return freeAngleTurntableT;
		}

		// Token: 0x06024977 RID: 149879 RVA: 0x00507064 File Offset: 0x00505264
		public void UnPackTo(IFreeAngleTurntableT _o)
		{
			_o.Type = this.Type;
			_o.RotationSpeed = this.RotationSpeed;
			_o.ItemConfig = new List<IFreeAngleItemT>();
			for (int i = 0; i < this.ItemConfigLength; i++)
			{
				_o.ItemConfig.Add((this.ItemConfig(i) != null) ? this.ItemConfig(i).Value.UnPack() : null);
			}
			_o.IntervalAngle = this.IntervalAngle;
		}

		// Token: 0x06024978 RID: 149880 RVA: 0x005070E8 File Offset: 0x005052E8
		public static Offset<IFreeAngleTurntable> Pack(FlatBufferBuilder builder, IFreeAngleTurntableT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFreeAngleTurntable>);
			}
			VectorOffset itemConfigOffset = default(VectorOffset);
			if (_o.ItemConfig != null)
			{
				Offset<IFreeAngleItem>[] array = new Offset<IFreeAngleItem>[_o.ItemConfig.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IFreeAngleItem.Pack(builder, _o.ItemConfig[i]);
				}
				itemConfigOffset = IFreeAngleTurntable.CreateItemConfigVector(builder, array);
			}
			return IFreeAngleTurntable.CreateIFreeAngleTurntable(builder, _o.Type, _o.RotationSpeed, itemConfigOffset, _o.IntervalAngle);
		}

		// Token: 0x0400F077 RID: 61559
		private Table __p;
	}
}
