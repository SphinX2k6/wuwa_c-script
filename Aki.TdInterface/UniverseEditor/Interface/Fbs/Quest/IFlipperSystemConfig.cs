using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020042A1 RID: 17057
	public struct IFlipperSystemConfig : IFlatbufferObject
	{
		// Token: 0x170074A1 RID: 29857
		// (get) Token: 0x06017DF1 RID: 97777 RVA: 0x00368CD1 File Offset: 0x00366ED1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017DF2 RID: 97778 RVA: 0x00368CDE File Offset: 0x00366EDE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017DF3 RID: 97779 RVA: 0x00368CE8 File Offset: 0x00366EE8
		public static IFlipperSystemConfig GetRootAsIFlipperSystemConfig(ByteBuffer _bb)
		{
			return IFlipperSystemConfig.GetRootAsIFlipperSystemConfig(_bb, default(IFlipperSystemConfig));
		}

		// Token: 0x06017DF4 RID: 97780 RVA: 0x00368D04 File Offset: 0x00366F04
		public static IFlipperSystemConfig GetRootAsIFlipperSystemConfig(ByteBuffer _bb, IFlipperSystemConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017DF5 RID: 97781 RVA: 0x00368D21 File Offset: 0x00366F21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017DF6 RID: 97782 RVA: 0x00368D30 File Offset: 0x00366F30
		public IFlipperSystemConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170074A2 RID: 29858
		// (get) Token: 0x06017DF7 RID: 97783 RVA: 0x00368D40 File Offset: 0x00366F40
		public EEnableSystemType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEnableSystemType.GradingSystem;
				}
				return (EEnableSystemType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017DF8 RID: 97784 RVA: 0x00368D7C File Offset: 0x00366F7C
		public IFlipperSystemVar? Vars(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IFlipperSystemVar?(default(IFlipperSystemVar).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170074A3 RID: 29859
		// (get) Token: 0x06017DF9 RID: 97785 RVA: 0x00368DDC File Offset: 0x00366FDC
		public int VarsLength
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

		// Token: 0x06017DFA RID: 97786 RVA: 0x00368E07 File Offset: 0x00367007
		public static Offset<IFlipperSystemConfig> CreateIFlipperSystemConfig(FlatBufferBuilder builder, EEnableSystemType Type = EEnableSystemType.GradingSystem, VectorOffset VarsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IFlipperSystemConfig.AddVars(builder, VarsOffset);
			IFlipperSystemConfig.AddType(builder, Type);
			return IFlipperSystemConfig.EndIFlipperSystemConfig(builder);
		}

		// Token: 0x06017DFB RID: 97787 RVA: 0x00368E24 File Offset: 0x00367024
		public static void StartIFlipperSystemConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06017DFC RID: 97788 RVA: 0x00368E2D File Offset: 0x0036702D
		public static void AddType(FlatBufferBuilder builder, EEnableSystemType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017DFD RID: 97789 RVA: 0x00368E38 File Offset: 0x00367038
		public static void AddVars(FlatBufferBuilder builder, VectorOffset varsOffset)
		{
			builder.AddOffset(1, varsOffset.Value, 0);
		}

		// Token: 0x06017DFE RID: 97790 RVA: 0x00368E48 File Offset: 0x00367048
		public static VectorOffset CreateVarsVector(FlatBufferBuilder builder, Offset<IFlipperSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06017DFF RID: 97791 RVA: 0x00368E88 File Offset: 0x00367088
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, Offset<IFlipperSystemVar>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IFlipperSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017E00 RID: 97792 RVA: 0x00368EA2 File Offset: 0x003670A2
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IFlipperSystemVar>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IFlipperSystemVar>>(data);
			return builder.EndVector();
		}

		// Token: 0x06017E01 RID: 97793 RVA: 0x00368EC0 File Offset: 0x003670C0
		public static VectorOffset CreateVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IFlipperSystemVar>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06017E02 RID: 97794 RVA: 0x00368ED9 File Offset: 0x003670D9
		public static void StartVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06017E03 RID: 97795 RVA: 0x00368EE4 File Offset: 0x003670E4
		public static Offset<IFlipperSystemConfig> EndIFlipperSystemConfig(FlatBufferBuilder builder)
		{
			return new Offset<IFlipperSystemConfig>(builder.EndTable());
		}

		// Token: 0x06017E04 RID: 97796 RVA: 0x00368EF4 File Offset: 0x003670F4
		public IFlipperSystemConfigT UnPack()
		{
			IFlipperSystemConfigT flipperSystemConfigT = new IFlipperSystemConfigT();
			this.UnPackTo(flipperSystemConfigT);
			return flipperSystemConfigT;
		}

		// Token: 0x06017E05 RID: 97797 RVA: 0x00368F10 File Offset: 0x00367110
		public void UnPackTo(IFlipperSystemConfigT _o)
		{
			_o.Type = this.Type;
			_o.Vars = new List<IFlipperSystemVarT>();
			for (int i = 0; i < this.VarsLength; i++)
			{
				_o.Vars.Add((this.Vars(i) != null) ? this.Vars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06017E06 RID: 97798 RVA: 0x00368F7C File Offset: 0x0036717C
		public static Offset<IFlipperSystemConfig> Pack(FlatBufferBuilder builder, IFlipperSystemConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFlipperSystemConfig>);
			}
			VectorOffset varsOffset = default(VectorOffset);
			if (_o.Vars != null)
			{
				Offset<IFlipperSystemVar>[] array = new Offset<IFlipperSystemVar>[_o.Vars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IFlipperSystemVar.Pack(builder, _o.Vars[i]);
				}
				varsOffset = IFlipperSystemConfig.CreateVarsVector(builder, array);
			}
			return IFlipperSystemConfig.CreateIFlipperSystemConfig(builder, _o.Type, varsOffset);
		}

		// Token: 0x0400C1EE RID: 49646
		private Table __p;
	}
}
