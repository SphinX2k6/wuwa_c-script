using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020052D6 RID: 21206
	public struct IFreeAngleTurntable : IFlatbufferObject
	{
		// Token: 0x17009B94 RID: 39828
		// (get) Token: 0x0602299B RID: 141723 RVA: 0x004CBC8E File Offset: 0x004C9E8E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602299C RID: 141724 RVA: 0x004CBC9B File Offset: 0x004C9E9B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602299D RID: 141725 RVA: 0x004CBCA4 File Offset: 0x004C9EA4
		public static IFreeAngleTurntable GetRootAsIFreeAngleTurntable(ByteBuffer _bb)
		{
			return IFreeAngleTurntable.GetRootAsIFreeAngleTurntable(_bb, default(IFreeAngleTurntable));
		}

		// Token: 0x0602299E RID: 141726 RVA: 0x004CBCC0 File Offset: 0x004C9EC0
		public static IFreeAngleTurntable GetRootAsIFreeAngleTurntable(ByteBuffer _bb, IFreeAngleTurntable obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602299F RID: 141727 RVA: 0x004CBCDD File Offset: 0x004C9EDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060229A0 RID: 141728 RVA: 0x004CBCEC File Offset: 0x004C9EEC
		public IFreeAngleTurntable __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009B95 RID: 39829
		// (get) Token: 0x060229A1 RID: 141729 RVA: 0x004CBCFC File Offset: 0x004C9EFC
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

		// Token: 0x17009B96 RID: 39830
		// (get) Token: 0x060229A2 RID: 141730 RVA: 0x004CBD38 File Offset: 0x004C9F38
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

		// Token: 0x060229A3 RID: 141731 RVA: 0x004CBD74 File Offset: 0x004C9F74
		public IFreeAngleItem? ItemConfig(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IFreeAngleItem?(default(IFreeAngleItem).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009B97 RID: 39831
		// (get) Token: 0x060229A4 RID: 141732 RVA: 0x004CBDD4 File Offset: 0x004C9FD4
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

		// Token: 0x17009B98 RID: 39832
		// (get) Token: 0x060229A5 RID: 141733 RVA: 0x004CBE00 File Offset: 0x004CA000
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

		// Token: 0x060229A6 RID: 141734 RVA: 0x004CBE3D File Offset: 0x004CA03D
		public static Offset<IFreeAngleTurntable> CreateIFreeAngleTurntable(FlatBufferBuilder builder, EControllerType Type = EControllerType.FreeAngle, int RotationSpeed = 0, VectorOffset ItemConfigOffset = default(VectorOffset), int IntervalAngle = 0)
		{
			builder.StartTable(4);
			IFreeAngleTurntable.AddIntervalAngle(builder, IntervalAngle);
			IFreeAngleTurntable.AddItemConfig(builder, ItemConfigOffset);
			IFreeAngleTurntable.AddRotationSpeed(builder, RotationSpeed);
			IFreeAngleTurntable.AddType(builder, Type);
			return IFreeAngleTurntable.EndIFreeAngleTurntable(builder);
		}

		// Token: 0x060229A7 RID: 141735 RVA: 0x004CBE69 File Offset: 0x004CA069
		public static void StartIFreeAngleTurntable(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060229A8 RID: 141736 RVA: 0x004CBE72 File Offset: 0x004CA072
		public static void AddType(FlatBufferBuilder builder, EControllerType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060229A9 RID: 141737 RVA: 0x004CBE7D File Offset: 0x004CA07D
		public static void AddRotationSpeed(FlatBufferBuilder builder, int rotationSpeed)
		{
			builder.AddInt(1, rotationSpeed, 0);
		}

		// Token: 0x060229AA RID: 141738 RVA: 0x004CBE88 File Offset: 0x004CA088
		public static void AddItemConfig(FlatBufferBuilder builder, VectorOffset itemConfigOffset)
		{
			builder.AddOffset(2, itemConfigOffset.Value, 0);
		}

		// Token: 0x060229AB RID: 141739 RVA: 0x004CBE98 File Offset: 0x004CA098
		public static VectorOffset CreateItemConfigVector(FlatBufferBuilder builder, Offset<IFreeAngleItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060229AC RID: 141740 RVA: 0x004CBED8 File Offset: 0x004CA0D8
		public static VectorOffset CreateItemConfigVectorBlock(FlatBufferBuilder builder, Offset<IFreeAngleItem>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFreeAngleItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x060229AD RID: 141741 RVA: 0x004CBEF2 File Offset: 0x004CA0F2
		public static VectorOffset CreateItemConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFreeAngleItem>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFreeAngleItem>>(data);
			return builder.EndVector();
		}

		// Token: 0x060229AE RID: 141742 RVA: 0x004CBF10 File Offset: 0x004CA110
		public static VectorOffset CreateItemConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFreeAngleItem>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060229AF RID: 141743 RVA: 0x004CBF29 File Offset: 0x004CA129
		public static void StartItemConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060229B0 RID: 141744 RVA: 0x004CBF34 File Offset: 0x004CA134
		public static void AddIntervalAngle(FlatBufferBuilder builder, int intervalAngle)
		{
			builder.AddInt(3, intervalAngle, 0);
		}

		// Token: 0x060229B1 RID: 141745 RVA: 0x004CBF3F File Offset: 0x004CA13F
		public static Offset<IFreeAngleTurntable> EndIFreeAngleTurntable(FlatBufferBuilder builder)
		{
			return new Offset<IFreeAngleTurntable>(builder.EndTable());
		}

		// Token: 0x060229B2 RID: 141746 RVA: 0x004CBF4C File Offset: 0x004CA14C
		public IFreeAngleTurntableT UnPack()
		{
			IFreeAngleTurntableT freeAngleTurntableT = new IFreeAngleTurntableT();
			this.UnPackTo(freeAngleTurntableT);
			return freeAngleTurntableT;
		}

		// Token: 0x060229B3 RID: 141747 RVA: 0x004CBF68 File Offset: 0x004CA168
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

		// Token: 0x060229B4 RID: 141748 RVA: 0x004CBFEC File Offset: 0x004CA1EC
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

		// Token: 0x0400E46A RID: 58474
		private Table __p;
	}
}
