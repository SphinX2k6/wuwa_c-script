using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E9E RID: 24222
	public struct IRotatorComponent2 : IFlatbufferObject
	{
		// Token: 0x1700B2DD RID: 45789
		// (get) Token: 0x060288EA RID: 166122 RVA: 0x0058B80F File Offset: 0x00589A0F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060288EB RID: 166123 RVA: 0x0058B81C File Offset: 0x00589A1C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060288EC RID: 166124 RVA: 0x0058B824 File Offset: 0x00589A24
		public static IRotatorComponent2 GetRootAsIRotatorComponent2(ByteBuffer _bb)
		{
			return IRotatorComponent2.GetRootAsIRotatorComponent2(_bb, default(IRotatorComponent2));
		}

		// Token: 0x060288ED RID: 166125 RVA: 0x0058B840 File Offset: 0x00589A40
		public static IRotatorComponent2 GetRootAsIRotatorComponent2(ByteBuffer _bb, IRotatorComponent2 obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060288EE RID: 166126 RVA: 0x0058B85D File Offset: 0x00589A5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060288EF RID: 166127 RVA: 0x0058B86C File Offset: 0x00589A6C
		public IRotatorComponent2 __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B2DE RID: 45790
		// (get) Token: 0x060288F0 RID: 166128 RVA: 0x0058B87C File Offset: 0x00589A7C
		public bool Disabled
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060288F1 RID: 166129 RVA: 0x0058B8BC File Offset: 0x00589ABC
		public IStateRotationConfig? Config(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IStateRotationConfig?(default(IStateRotationConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700B2DF RID: 45791
		// (get) Token: 0x060288F2 RID: 166130 RVA: 0x0058B91C File Offset: 0x00589B1C
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

		// Token: 0x1700B2E0 RID: 45792
		// (get) Token: 0x060288F3 RID: 166131 RVA: 0x0058B948 File Offset: 0x00589B48
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

		// Token: 0x060288F4 RID: 166132 RVA: 0x0058B984 File Offset: 0x00589B84
		public static Offset<IRotatorComponent2> CreateIRotatorComponent2(FlatBufferBuilder builder, bool Disabled = false, VectorOffset ConfigOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(3);
			IRotatorComponent2.AddConfig(builder, ConfigOffset);
			IRotatorComponent2.AddNullMask(builder, NullMask);
			IRotatorComponent2.AddDisabled(builder, Disabled);
			return IRotatorComponent2.EndIRotatorComponent2(builder);
		}

		// Token: 0x060288F5 RID: 166133 RVA: 0x0058B9A8 File Offset: 0x00589BA8
		public static void StartIRotatorComponent2(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060288F6 RID: 166134 RVA: 0x0058B9B1 File Offset: 0x00589BB1
		public static void AddDisabled(FlatBufferBuilder builder, bool disabled)
		{
			builder.AddBool(0, disabled, false);
		}

		// Token: 0x060288F7 RID: 166135 RVA: 0x0058B9BC File Offset: 0x00589BBC
		public static void AddConfig(FlatBufferBuilder builder, VectorOffset configOffset)
		{
			builder.AddOffset(1, configOffset.Value, 0);
		}

		// Token: 0x060288F8 RID: 166136 RVA: 0x0058B9CC File Offset: 0x00589BCC
		public static VectorOffset CreateConfigVector(FlatBufferBuilder builder, Offset<IStateRotationConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060288F9 RID: 166137 RVA: 0x0058BA0C File Offset: 0x00589C0C
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, Offset<IStateRotationConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IStateRotationConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060288FA RID: 166138 RVA: 0x0058BA26 File Offset: 0x00589C26
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IStateRotationConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IStateRotationConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x060288FB RID: 166139 RVA: 0x0058BA44 File Offset: 0x00589C44
		public static VectorOffset CreateConfigVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IStateRotationConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060288FC RID: 166140 RVA: 0x0058BA5D File Offset: 0x00589C5D
		public static void StartConfigVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060288FD RID: 166141 RVA: 0x0058BA68 File Offset: 0x00589C68
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x060288FE RID: 166142 RVA: 0x0058BA73 File Offset: 0x00589C73
		public static Offset<IRotatorComponent2> EndIRotatorComponent2(FlatBufferBuilder builder)
		{
			return new Offset<IRotatorComponent2>(builder.EndTable());
		}

		// Token: 0x060288FF RID: 166143 RVA: 0x0058BA80 File Offset: 0x00589C80
		public IRotatorComponent2T UnPack()
		{
			IRotatorComponent2T rotatorComponent2T = new IRotatorComponent2T();
			this.UnPackTo(rotatorComponent2T);
			return rotatorComponent2T;
		}

		// Token: 0x06028900 RID: 166144 RVA: 0x0058BA9C File Offset: 0x00589C9C
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

		// Token: 0x06028901 RID: 166145 RVA: 0x0058BB14 File Offset: 0x00589D14
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

		// Token: 0x0400FAE0 RID: 64224
		private Table __p;
	}
}
