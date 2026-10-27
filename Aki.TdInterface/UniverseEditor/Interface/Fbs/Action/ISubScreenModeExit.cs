using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007217 RID: 29207
	public struct ISubScreenModeExit : IFlatbufferObject
	{
		// Token: 0x1700D8D0 RID: 55504
		// (get) Token: 0x06033CDA RID: 212186 RVA: 0x006F8BC2 File Offset: 0x006F6DC2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033CDB RID: 212187 RVA: 0x006F8BCF File Offset: 0x006F6DCF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033CDC RID: 212188 RVA: 0x006F8BD8 File Offset: 0x006F6DD8
		public static ISubScreenModeExit GetRootAsISubScreenModeExit(ByteBuffer _bb)
		{
			return ISubScreenModeExit.GetRootAsISubScreenModeExit(_bb, default(ISubScreenModeExit));
		}

		// Token: 0x06033CDD RID: 212189 RVA: 0x006F8BF4 File Offset: 0x006F6DF4
		public static ISubScreenModeExit GetRootAsISubScreenModeExit(ByteBuffer _bb, ISubScreenModeExit obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033CDE RID: 212190 RVA: 0x006F8C11 File Offset: 0x006F6E11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033CDF RID: 212191 RVA: 0x006F8C20 File Offset: 0x006F6E20
		public ISubScreenModeExit __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D8D1 RID: 55505
		// (get) Token: 0x06033CE0 RID: 212192 RVA: 0x006F8C30 File Offset: 0x006F6E30
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

		// Token: 0x06033CE1 RID: 212193 RVA: 0x006F8C6C File Offset: 0x006F6E6C
		public ISetSubScreenData? ExitConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ISetSubScreenData?(default(ISetSubScreenData).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D8D2 RID: 55506
		// (get) Token: 0x06033CE2 RID: 212194 RVA: 0x006F8CCC File Offset: 0x006F6ECC
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

		// Token: 0x06033CE3 RID: 212195 RVA: 0x006F8CF7 File Offset: 0x006F6EF7
		public static Offset<ISubScreenModeExit> CreateISubScreenModeExit(FlatBufferBuilder builder, ESubScreenOperationType Type = ESubScreenOperationType.Init, VectorOffset ExitConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISubScreenModeExit.AddExitConfigs(builder, ExitConfigsOffset);
			ISubScreenModeExit.AddType(builder, Type);
			return ISubScreenModeExit.EndISubScreenModeExit(builder);
		}

		// Token: 0x06033CE4 RID: 212196 RVA: 0x006F8D14 File Offset: 0x006F6F14
		public static void StartISubScreenModeExit(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033CE5 RID: 212197 RVA: 0x006F8D1D File Offset: 0x006F6F1D
		public static void AddType(FlatBufferBuilder builder, ESubScreenOperationType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033CE6 RID: 212198 RVA: 0x006F8D28 File Offset: 0x006F6F28
		public static void AddExitConfigs(FlatBufferBuilder builder, VectorOffset exitConfigsOffset)
		{
			builder.AddOffset(1, exitConfigsOffset.Value, 0);
		}

		// Token: 0x06033CE7 RID: 212199 RVA: 0x006F8D38 File Offset: 0x006F6F38
		public static VectorOffset CreateExitConfigsVector(FlatBufferBuilder builder, Offset<ISetSubScreenData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06033CE8 RID: 212200 RVA: 0x006F8D78 File Offset: 0x006F6F78
		public static VectorOffset CreateExitConfigsVectorBlock(FlatBufferBuilder builder, Offset<ISetSubScreenData>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ISetSubScreenData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06033CE9 RID: 212201 RVA: 0x006F8D92 File Offset: 0x006F6F92
		public static VectorOffset CreateExitConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ISetSubScreenData>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ISetSubScreenData>>(data);
			return builder.EndVector();
		}

		// Token: 0x06033CEA RID: 212202 RVA: 0x006F8DB0 File Offset: 0x006F6FB0
		public static VectorOffset CreateExitConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ISetSubScreenData>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06033CEB RID: 212203 RVA: 0x006F8DC9 File Offset: 0x006F6FC9
		public static void StartExitConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06033CEC RID: 212204 RVA: 0x006F8DD4 File Offset: 0x006F6FD4
		public static Offset<ISubScreenModeExit> EndISubScreenModeExit(FlatBufferBuilder builder)
		{
			return new Offset<ISubScreenModeExit>(builder.EndTable());
		}

		// Token: 0x06033CED RID: 212205 RVA: 0x006F8DE4 File Offset: 0x006F6FE4
		public ISubScreenModeExitT UnPack()
		{
			ISubScreenModeExitT subScreenModeExitT = new ISubScreenModeExitT();
			this.UnPackTo(subScreenModeExitT);
			return subScreenModeExitT;
		}

		// Token: 0x06033CEE RID: 212206 RVA: 0x006F8E00 File Offset: 0x006F7000
		public void UnPackTo(ISubScreenModeExitT _o)
		{
			_o.Type = this.Type;
			_o.ExitConfigs = new List<ISetSubScreenDataT>();
			for (int i = 0; i < this.ExitConfigsLength; i++)
			{
				_o.ExitConfigs.Add((this.ExitConfigs(i) != null) ? this.ExitConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06033CEF RID: 212207 RVA: 0x006F8E6C File Offset: 0x006F706C
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

		// Token: 0x04011D06 RID: 72966
		private Table __p;
	}
}
