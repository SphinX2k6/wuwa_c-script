using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079E3 RID: 31203
	public struct ISubScreenModeAdjust : IFlatbufferObject
	{
		// Token: 0x1700E4BF RID: 58559
		// (get) Token: 0x06036F9E RID: 225182 RVA: 0x00759874 File Offset: 0x00757A74
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036F9F RID: 225183 RVA: 0x00759881 File Offset: 0x00757A81
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036FA0 RID: 225184 RVA: 0x00759888 File Offset: 0x00757A88
		public static ISubScreenModeAdjust GetRootAsISubScreenModeAdjust(ByteBuffer _bb)
		{
			return ISubScreenModeAdjust.GetRootAsISubScreenModeAdjust(_bb, default(ISubScreenModeAdjust));
		}

		// Token: 0x06036FA1 RID: 225185 RVA: 0x007598A4 File Offset: 0x00757AA4
		public static ISubScreenModeAdjust GetRootAsISubScreenModeAdjust(ByteBuffer _bb, ISubScreenModeAdjust obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036FA2 RID: 225186 RVA: 0x007598C1 File Offset: 0x00757AC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036FA3 RID: 225187 RVA: 0x007598D0 File Offset: 0x00757AD0
		public ISubScreenModeAdjust __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4C0 RID: 58560
		// (get) Token: 0x06036FA4 RID: 225188 RVA: 0x007598E0 File Offset: 0x00757AE0
		public ESubScreenOperationType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESubScreenOperationType.Init;
				}
				return (ESubScreenOperationType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036FA5 RID: 225189 RVA: 0x0075991C File Offset: 0x00757B1C
		public ISetSubScreenData? AdjustConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISetSubScreenData?(default(ISetSubScreenData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E4C1 RID: 58561
		// (get) Token: 0x06036FA6 RID: 225190 RVA: 0x0075997C File Offset: 0x00757B7C
		public int AdjustConfigsLength
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

		// Token: 0x06036FA7 RID: 225191 RVA: 0x007599A7 File Offset: 0x00757BA7
		public static Offset<ISubScreenModeAdjust> CreateISubScreenModeAdjust(FlatBufferBuilder builder, ESubScreenOperationType Type = ESubScreenOperationType.Init, VectorOffset AdjustConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISubScreenModeAdjust.AddAdjustConfigs(builder, AdjustConfigsOffset);
			ISubScreenModeAdjust.AddType(builder, Type);
			return ISubScreenModeAdjust.EndISubScreenModeAdjust(builder);
		}

		// Token: 0x06036FA8 RID: 225192 RVA: 0x007599C4 File Offset: 0x00757BC4
		public static void StartISubScreenModeAdjust(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036FA9 RID: 225193 RVA: 0x007599CD File Offset: 0x00757BCD
		public static void AddType(FlatBufferBuilder builder, ESubScreenOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036FAA RID: 225194 RVA: 0x007599D8 File Offset: 0x00757BD8
		public static void AddAdjustConfigs(FlatBufferBuilder builder, VectorOffset adjustConfigsOffset)
		{
			builder.AddOffset(1, adjustConfigsOffset.Value, 0);
		}

		// Token: 0x06036FAB RID: 225195 RVA: 0x007599E8 File Offset: 0x00757BE8
		public static VectorOffset CreateAdjustConfigsVector(FlatBufferBuilder builder, Offset<ISetSubScreenData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06036FAC RID: 225196 RVA: 0x00759A28 File Offset: 0x00757C28
		public static VectorOffset CreateAdjustConfigsVectorBlock(FlatBufferBuilder builder, Offset<ISetSubScreenData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISetSubScreenData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06036FAD RID: 225197 RVA: 0x00759A42 File Offset: 0x00757C42
		public static VectorOffset CreateAdjustConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISetSubScreenData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISetSubScreenData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06036FAE RID: 225198 RVA: 0x00759A60 File Offset: 0x00757C60
		public static VectorOffset CreateAdjustConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISetSubScreenData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06036FAF RID: 225199 RVA: 0x00759A79 File Offset: 0x00757C79
		public static void StartAdjustConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036FB0 RID: 225200 RVA: 0x00759A84 File Offset: 0x00757C84
		public static Offset<ISubScreenModeAdjust> EndISubScreenModeAdjust(FlatBufferBuilder builder)
		{
			return new Offset<ISubScreenModeAdjust>(builder.EndTable());
		}

		// Token: 0x06036FB1 RID: 225201 RVA: 0x00759A94 File Offset: 0x00757C94
		public ISubScreenModeAdjustT UnPack()
		{
			ISubScreenModeAdjustT subScreenModeAdjustT = new ISubScreenModeAdjustT();
			this.UnPackTo(subScreenModeAdjustT);
			return subScreenModeAdjustT;
		}

		// Token: 0x06036FB2 RID: 225202 RVA: 0x00759AB0 File Offset: 0x00757CB0
		public void UnPackTo(ISubScreenModeAdjustT _o)
		{
			_o.Type = this.Type;
			_o.AdjustConfigs = new List<ISetSubScreenDataT>();
			for (int i = 0; i < this.AdjustConfigsLength; i++)
			{
				_o.AdjustConfigs.Add((this.AdjustConfigs(i) != null) ? this.AdjustConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06036FB3 RID: 225203 RVA: 0x00759B1C File Offset: 0x00757D1C
		public static Offset<ISubScreenModeAdjust> Pack(FlatBufferBuilder builder, ISubScreenModeAdjustT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubScreenModeAdjust>);
			}
			VectorOffset adjustConfigsOffset = default(VectorOffset);
			if (_o.AdjustConfigs != null)
			{
				Offset<ISetSubScreenData>[] array = new Offset<ISetSubScreenData>[_o.AdjustConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISetSubScreenData.Pack(builder, _o.AdjustConfigs[i]);
				}
				adjustConfigsOffset = ISubScreenModeAdjust.CreateAdjustConfigsVector(builder, array);
			}
			return ISubScreenModeAdjust.CreateISubScreenModeAdjust(builder, _o.Type, adjustConfigsOffset);
		}

		// Token: 0x04012CFB RID: 77051
		private Table __p;
	}
}
