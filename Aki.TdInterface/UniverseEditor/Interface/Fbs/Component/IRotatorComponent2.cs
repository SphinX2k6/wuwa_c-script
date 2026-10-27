using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005891 RID: 22673
	public struct IRotatorComponent2 : IFlatbufferObject
	{
		// Token: 0x1700A9AD RID: 43437
		// (get) Token: 0x06026388 RID: 156552 RVA: 0x00544CC3 File Offset: 0x00542EC3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026389 RID: 156553 RVA: 0x00544CD0 File Offset: 0x00542ED0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602638A RID: 156554 RVA: 0x00544CD8 File Offset: 0x00542ED8
		public static IRotatorComponent2 GetRootAsIRotatorComponent2(ByteBuffer _bb)
		{
			return IRotatorComponent2.GetRootAsIRotatorComponent2(_bb, default(IRotatorComponent2));
		}

		// Token: 0x0602638B RID: 156555 RVA: 0x00544CF4 File Offset: 0x00542EF4
		public static IRotatorComponent2 GetRootAsIRotatorComponent2(ByteBuffer _bb, IRotatorComponent2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602638C RID: 156556 RVA: 0x00544D11 File Offset: 0x00542F11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602638D RID: 156557 RVA: 0x00544D20 File Offset: 0x00542F20
		public IRotatorComponent2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A9AE RID: 43438
		// (get) Token: 0x0602638E RID: 156558 RVA: 0x00544D30 File Offset: 0x00542F30
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0602638F RID: 156559 RVA: 0x00544D70 File Offset: 0x00542F70
		public IStateRotationConfig? Config(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IStateRotationConfig?(default(IStateRotationConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A9AF RID: 43439
		// (get) Token: 0x06026390 RID: 156560 RVA: 0x00544DD0 File Offset: 0x00542FD0
		public int ConfigLength
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

		// Token: 0x1700A9B0 RID: 43440
		// (get) Token: 0x06026391 RID: 156561 RVA: 0x00544DFC File Offset: 0x00542FFC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026392 RID: 156562 RVA: 0x00544E38 File Offset: 0x00543038
		public static Offset<IRotatorComponent2> CreateIRotatorComponent2(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ConfigOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IRotatorComponent2.AddConfig(builder, ConfigOffset);
			IRotatorComponent2.AddNullMask(builder, NullMask);
			IRotatorComponent2.AddDisabled(builder, Disabled);
			return IRotatorComponent2.EndIRotatorComponent2(builder);
		}

		// Token: 0x06026393 RID: 156563 RVA: 0x00544E5C File Offset: 0x0054305C
		public static void StartIRotatorComponent2(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06026394 RID: 156564 RVA: 0x00544E65 File Offset: 0x00543065
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x06026395 RID: 156565 RVA: 0x00544E70 File Offset: 0x00543070
		public static void AddConfig(FlatBufferBuilder builder, VectorOffset configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x06026396 RID: 156566 RVA: 0x00544E80 File Offset: 0x00543080
		public static VectorOffset CreateConfigVector(FlatBufferBuilder builder, Offset<IStateRotationConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026397 RID: 156567 RVA: 0x00544EC0 File Offset: 0x005430C0
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, Offset<IStateRotationConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IStateRotationConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026398 RID: 156568 RVA: 0x00544EDA File Offset: 0x005430DA
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IStateRotationConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IStateRotationConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026399 RID: 156569 RVA: 0x00544EF8 File Offset: 0x005430F8
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IStateRotationConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602639A RID: 156570 RVA: 0x00544F11 File Offset: 0x00543111
		public static void StartConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602639B RID: 156571 RVA: 0x00544F1C File Offset: 0x0054311C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0602639C RID: 156572 RVA: 0x00544F27 File Offset: 0x00543127
		public static Offset<IRotatorComponent2> EndIRotatorComponent2(FlatBufferBuilder builder)
		{
			return new Offset<IRotatorComponent2>(builder.EndTable());
		}

		// Token: 0x0602639D RID: 156573 RVA: 0x00544F34 File Offset: 0x00543134
		public IRotatorComponent2T UnPack()
		{
			IRotatorComponent2T rotatorComponent2T = new IRotatorComponent2T();
			this.UnPackTo(rotatorComponent2T);
			return rotatorComponent2T;
		}

		// Token: 0x0602639E RID: 156574 RVA: 0x00544F50 File Offset: 0x00543150
		public void UnPackTo(IRotatorComponent2T _o)
		{
			_o.Disabled = this.Disabled;
			_o.Config = new List<IStateRotationConfigT>();
			for (int i = 0; i < this.ConfigLength; i++)
			{
				_o.Config.Add((this.Config(i) != null) ? this.Config(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602639F RID: 156575 RVA: 0x00544FC8 File Offset: 0x005431C8
		public static Offset<IRotatorComponent2> Pack(FlatBufferBuilder builder, IRotatorComponent2T _o)
		{
			if (_o == null)
			{
				return default(Offset<IRotatorComponent2>);
			}
			VectorOffset configOffset = default(VectorOffset);
			if (_o.Config != null)
			{
				Offset<IStateRotationConfig>[] array = new Offset<IStateRotationConfig>[_o.Config.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IStateRotationConfig.Pack(builder, _o.Config[i]);
				}
				configOffset = IRotatorComponent2.CreateConfigVector(builder, array);
			}
			return IRotatorComponent2.CreateIRotatorComponent2(builder, _o.Disabled, configOffset, _o.NullMask);
		}

		// Token: 0x0400EDED RID: 60909
		private Table __p;
	}
}
