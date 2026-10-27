using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200737F RID: 29567
	public struct ITeleportDungeonFunction : IFlatbufferObject
	{
		// Token: 0x1700E07B RID: 57467
		// (get) Token: 0x06035AAD RID: 219821 RVA: 0x0074EB90 File Offset: 0x0074CD90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035AAE RID: 219822 RVA: 0x0074EB9D File Offset: 0x0074CD9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035AAF RID: 219823 RVA: 0x0074EBA4 File Offset: 0x0074CDA4
		public static ITeleportDungeonFunction GetRootAsITeleportDungeonFunction(ByteBuffer _bb)
		{
			return ITeleportDungeonFunction.GetRootAsITeleportDungeonFunction(_bb, default(ITeleportDungeonFunction));
		}

		// Token: 0x06035AB0 RID: 219824 RVA: 0x0074EBC0 File Offset: 0x0074CDC0
		public static ITeleportDungeonFunction GetRootAsITeleportDungeonFunction(ByteBuffer _bb, ITeleportDungeonFunction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035AB1 RID: 219825 RVA: 0x0074EBDD File Offset: 0x0074CDDD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035AB2 RID: 219826 RVA: 0x0074EBEC File Offset: 0x0074CDEC
		public ITeleportDungeonFunction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E07C RID: 57468
		// (get) Token: 0x06035AB3 RID: 219827 RVA: 0x0074EBFC File Offset: 0x0074CDFC
		public EEnableFunctionType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnableFunctionType.TeleportDungeon;
				}
				return (EEnableFunctionType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E07D RID: 57469
		// (get) Token: 0x06035AB4 RID: 219828 RVA: 0x0074EC38 File Offset: 0x0074CE38
		public bool Enable
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06035AB5 RID: 219829 RVA: 0x0074EC78 File Offset: 0x0074CE78
		public int DungeonList(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E07E RID: 57470
		// (get) Token: 0x06035AB6 RID: 219830 RVA: 0x0074ECB8 File Offset: 0x0074CEB8
		public int DungeonListLength
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

		// Token: 0x06035AB7 RID: 219831 RVA: 0x0074ECE3 File Offset: 0x0074CEE3
		public Span<int> GetDungeonListBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06035AB8 RID: 219832 RVA: 0x0074ECF2 File Offset: 0x0074CEF2
		public int[] GetDungeonListArray()
		{
			return this.__p.__vector_as_array<int>(8);
		}

		// Token: 0x1700E07F RID: 57471
		// (get) Token: 0x06035AB9 RID: 219833 RVA: 0x0074ED00 File Offset: 0x0074CF00
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035ABA RID: 219834 RVA: 0x0074ED3D File Offset: 0x0074CF3D
		public static Offset<ITeleportDungeonFunction> CreateITeleportDungeonFunction(FlatBufferBuilder builder, EEnableFunctionType Type = EEnableFunctionType.TeleportDungeon, bool Enable = false, VectorOffset DungeonListOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(4);
			ITeleportDungeonFunction.AddDungeonList(builder, DungeonListOffset);
			ITeleportDungeonFunction.AddNullMask(builder, NullMask);
			ITeleportDungeonFunction.AddEnable(builder, Enable);
			ITeleportDungeonFunction.AddType(builder, Type);
			return ITeleportDungeonFunction.EndITeleportDungeonFunction(builder);
		}

		// Token: 0x06035ABB RID: 219835 RVA: 0x0074ED69 File Offset: 0x0074CF69
		public static void StartITeleportDungeonFunction(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06035ABC RID: 219836 RVA: 0x0074ED72 File Offset: 0x0074CF72
		public static void AddType(FlatBufferBuilder builder, EEnableFunctionType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035ABD RID: 219837 RVA: 0x0074ED7D File Offset: 0x0074CF7D
		public static void AddEnable(FlatBufferBuilder builder, bool enable)
		{
			builder.AddBool(1, enable, false);
		}

		// Token: 0x06035ABE RID: 219838 RVA: 0x0074ED88 File Offset: 0x0074CF88
		public static void AddDungeonList(FlatBufferBuilder builder, VectorOffset dungeonListOffset)
		{
			builder.AddOffset(2, dungeonListOffset.Value, 0);
		}

		// Token: 0x06035ABF RID: 219839 RVA: 0x0074ED98 File Offset: 0x0074CF98
		public static VectorOffset CreateDungeonListVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x06035AC0 RID: 219840 RVA: 0x0074EDCF File Offset: 0x0074CFCF
		public static VectorOffset CreateDungeonListVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035AC1 RID: 219841 RVA: 0x0074EDE9 File Offset: 0x0074CFE9
		public static VectorOffset CreateDungeonListVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x06035AC2 RID: 219842 RVA: 0x0074EE07 File Offset: 0x0074D007
		public static VectorOffset CreateDungeonListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06035AC3 RID: 219843 RVA: 0x0074EE20 File Offset: 0x0074D020
		public static void StartDungeonListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06035AC4 RID: 219844 RVA: 0x0074EE2B File Offset: 0x0074D02B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(3, nullMask, 0);
		}

		// Token: 0x06035AC5 RID: 219845 RVA: 0x0074EE36 File Offset: 0x0074D036
		public static Offset<ITeleportDungeonFunction> EndITeleportDungeonFunction(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportDungeonFunction>(builder.EndTable());
		}

		// Token: 0x06035AC6 RID: 219846 RVA: 0x0074EE44 File Offset: 0x0074D044
		public ITeleportDungeonFunctionT UnPack()
		{
			ITeleportDungeonFunctionT teleportDungeonFunctionT = new ITeleportDungeonFunctionT();
			this.UnPackTo(teleportDungeonFunctionT);
			return teleportDungeonFunctionT;
		}

		// Token: 0x06035AC7 RID: 219847 RVA: 0x0074EE60 File Offset: 0x0074D060
		public void UnPackTo(ITeleportDungeonFunctionT _o)
		{
			_o.Type = this.Type;
			_o.Enable = this.Enable;
			_o.DungeonList = new List<int>();
			for (int i = 0; i < this.DungeonListLength; i++)
			{
				_o.DungeonList.Add(this.DungeonList(i));
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035AC8 RID: 219848 RVA: 0x0074EEC0 File Offset: 0x0074D0C0
		public static Offset<ITeleportDungeonFunction> Pack(FlatBufferBuilder builder, ITeleportDungeonFunctionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportDungeonFunction>);
			}
			VectorOffset dungeonListOffset = default(VectorOffset);
			if (_o.DungeonList != null)
			{
				int[] data = _o.DungeonList.ToArray();
				dungeonListOffset = ITeleportDungeonFunction.CreateDungeonListVector(builder, data);
			}
			return ITeleportDungeonFunction.CreateITeleportDungeonFunction(builder, _o.Type, _o.Enable, dungeonListOffset, _o.NullMask);
		}

		// Token: 0x0401219A RID: 74138
		private Table __p;
	}
}
