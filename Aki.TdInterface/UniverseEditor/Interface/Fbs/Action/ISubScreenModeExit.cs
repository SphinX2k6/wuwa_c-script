using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079EC RID: 31212
	public struct ISubScreenModeExit : IFlatbufferObject
	{
		// Token: 0x1700E4C9 RID: 58569
		// (get) Token: 0x06036FDC RID: 225244 RVA: 0x00759F22 File Offset: 0x00758122
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036FDD RID: 225245 RVA: 0x00759F2F File Offset: 0x0075812F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036FDE RID: 225246 RVA: 0x00759F38 File Offset: 0x00758138
		public static ISubScreenModeExit GetRootAsISubScreenModeExit(ByteBuffer _bb)
		{
			return ISubScreenModeExit.GetRootAsISubScreenModeExit(_bb, default(ISubScreenModeExit));
		}

		// Token: 0x06036FDF RID: 225247 RVA: 0x00759F54 File Offset: 0x00758154
		public static ISubScreenModeExit GetRootAsISubScreenModeExit(ByteBuffer _bb, ISubScreenModeExit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036FE0 RID: 225248 RVA: 0x00759F71 File Offset: 0x00758171
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036FE1 RID: 225249 RVA: 0x00759F80 File Offset: 0x00758180
		public ISubScreenModeExit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E4CA RID: 58570
		// (get) Token: 0x06036FE2 RID: 225250 RVA: 0x00759F90 File Offset: 0x00758190
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

		// Token: 0x06036FE3 RID: 225251 RVA: 0x00759FCC File Offset: 0x007581CC
		public ISetSubScreenData? ExitConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISetSubScreenData?(default(ISetSubScreenData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700E4CB RID: 58571
		// (get) Token: 0x06036FE4 RID: 225252 RVA: 0x0075A02C File Offset: 0x0075822C
		public int ExitConfigsLength
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

		// Token: 0x06036FE5 RID: 225253 RVA: 0x0075A057 File Offset: 0x00758257
		public static Offset<ISubScreenModeExit> CreateISubScreenModeExit(FlatBufferBuilder builder, ESubScreenOperationType Type = ESubScreenOperationType.Init, VectorOffset ExitConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISubScreenModeExit.AddExitConfigs(builder, ExitConfigsOffset);
			ISubScreenModeExit.AddType(builder, Type);
			return ISubScreenModeExit.EndISubScreenModeExit(builder);
		}

		// Token: 0x06036FE6 RID: 225254 RVA: 0x0075A074 File Offset: 0x00758274
		public static void StartISubScreenModeExit(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036FE7 RID: 225255 RVA: 0x0075A07D File Offset: 0x0075827D
		public static void AddType(FlatBufferBuilder builder, ESubScreenOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06036FE8 RID: 225256 RVA: 0x0075A088 File Offset: 0x00758288
		public static void AddExitConfigs(FlatBufferBuilder builder, VectorOffset exitConfigsOffset)
		{
			builder.AddOffset(1, exitConfigsOffset.Value, 0);
		}

		// Token: 0x06036FE9 RID: 225257 RVA: 0x0075A098 File Offset: 0x00758298
		public static VectorOffset CreateExitConfigsVector(FlatBufferBuilder builder, Offset<ISetSubScreenData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06036FEA RID: 225258 RVA: 0x0075A0D8 File Offset: 0x007582D8
		public static VectorOffset CreateExitConfigsVectorBlock(FlatBufferBuilder builder, Offset<ISetSubScreenData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISetSubScreenData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06036FEB RID: 225259 RVA: 0x0075A0F2 File Offset: 0x007582F2
		public static VectorOffset CreateExitConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISetSubScreenData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISetSubScreenData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06036FEC RID: 225260 RVA: 0x0075A110 File Offset: 0x00758310
		public static VectorOffset CreateExitConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISetSubScreenData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06036FED RID: 225261 RVA: 0x0075A129 File Offset: 0x00758329
		public static void StartExitConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06036FEE RID: 225262 RVA: 0x0075A134 File Offset: 0x00758334
		public static Offset<ISubScreenModeExit> EndISubScreenModeExit(FlatBufferBuilder builder)
		{
			return new Offset<ISubScreenModeExit>(builder.EndTable());
		}

		// Token: 0x06036FEF RID: 225263 RVA: 0x0075A144 File Offset: 0x00758344
		public ISubScreenModeExitT UnPack()
		{
			ISubScreenModeExitT subScreenModeExitT = new ISubScreenModeExitT();
			this.UnPackTo(subScreenModeExitT);
			return subScreenModeExitT;
		}

		// Token: 0x06036FF0 RID: 225264 RVA: 0x0075A160 File Offset: 0x00758360
		public void UnPackTo(ISubScreenModeExitT _o)
		{
			_o.Type = this.Type;
			_o.ExitConfigs = new List<ISetSubScreenDataT>();
			for (int i = 0; i < this.ExitConfigsLength; i++)
			{
				_o.ExitConfigs.Add((this.ExitConfigs(i) != null) ? this.ExitConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06036FF1 RID: 225265 RVA: 0x0075A1CC File Offset: 0x007583CC
		public static Offset<ISubScreenModeExit> Pack(FlatBufferBuilder builder, ISubScreenModeExitT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISubScreenModeExit>);
			}
			VectorOffset exitConfigsOffset = default(VectorOffset);
			if (_o.ExitConfigs != null)
			{
				Offset<ISetSubScreenData>[] array = new Offset<ISetSubScreenData>[_o.ExitConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ISetSubScreenData.Pack(builder, _o.ExitConfigs[i]);
				}
				exitConfigsOffset = ISubScreenModeExit.CreateExitConfigsVector(builder, array);
			}
			return ISubScreenModeExit.CreateISubScreenModeExit(builder, _o.Type, exitConfigsOffset);
		}

		// Token: 0x04012D08 RID: 77064
		private Table __p;
	}
}
