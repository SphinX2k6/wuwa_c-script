using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200635B RID: 25435
	public struct ICheckFlowLookAt : IFlatbufferObject
	{
		// Token: 0x1700BDC5 RID: 48581
		// (get) Token: 0x0602BFFD RID: 180221 RVA: 0x0060BD27 File Offset: 0x00609F27
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602BFFE RID: 180222 RVA: 0x0060BD34 File Offset: 0x00609F34
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602BFFF RID: 180223 RVA: 0x0060BD3C File Offset: 0x00609F3C
		public static ICheckFlowLookAt GetRootAsICheckFlowLookAt(ByteBuffer _bb)
		{
			return ICheckFlowLookAt.GetRootAsICheckFlowLookAt(_bb, default(ICheckFlowLookAt));
		}

		// Token: 0x0602C000 RID: 180224 RVA: 0x0060BD58 File Offset: 0x00609F58
		public static ICheckFlowLookAt GetRootAsICheckFlowLookAt(ByteBuffer _bb, ICheckFlowLookAt obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C001 RID: 180225 RVA: 0x0060BD75 File Offset: 0x00609F75
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C002 RID: 180226 RVA: 0x0060BD84 File Offset: 0x00609F84
		public ICheckFlowLookAt __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BDC6 RID: 48582
		// (get) Token: 0x0602C003 RID: 180227 RVA: 0x0060BD94 File Offset: 0x00609F94
		public EOverrideLookAtType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EOverrideLookAtType.CheckFlowLookAt;
				}
				return (EOverrideLookAtType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C004 RID: 180228 RVA: 0x0060BDD0 File Offset: 0x00609FD0
		public ICheckFlowLookAtConfig? CheckFlowLookAtConfigs(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ICheckFlowLookAtConfig?(default(ICheckFlowLookAtConfig).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700BDC7 RID: 48583
		// (get) Token: 0x0602C005 RID: 180229 RVA: 0x0060BE30 File Offset: 0x0060A030
		public int CheckFlowLookAtConfigsLength
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

		// Token: 0x0602C006 RID: 180230 RVA: 0x0060BE5B File Offset: 0x0060A05B
		public static Offset<ICheckFlowLookAt> CreateICheckFlowLookAt(FlatBufferBuilder builder, EOverrideLookAtType Type = EOverrideLookAtType.CheckFlowLookAt, VectorOffset CheckFlowLookAtConfigsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ICheckFlowLookAt.AddCheckFlowLookAtConfigs(builder, CheckFlowLookAtConfigsOffset);
			ICheckFlowLookAt.AddType(builder, Type);
			return ICheckFlowLookAt.EndICheckFlowLookAt(builder);
		}

		// Token: 0x0602C007 RID: 180231 RVA: 0x0060BE78 File Offset: 0x0060A078
		public static void StartICheckFlowLookAt(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602C008 RID: 180232 RVA: 0x0060BE81 File Offset: 0x0060A081
		public static void AddType(FlatBufferBuilder builder, EOverrideLookAtType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602C009 RID: 180233 RVA: 0x0060BE8C File Offset: 0x0060A08C
		public static void AddCheckFlowLookAtConfigs(FlatBufferBuilder builder, VectorOffset checkFlowLookAtConfigsOffset)
		{
			builder.AddOffset(1, checkFlowLookAtConfigsOffset.Value, 0);
		}

		// Token: 0x0602C00A RID: 180234 RVA: 0x0060BE9C File Offset: 0x0060A09C
		public static VectorOffset CreateCheckFlowLookAtConfigsVector(FlatBufferBuilder builder, Offset<ICheckFlowLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C00B RID: 180235 RVA: 0x0060BEDC File Offset: 0x0060A0DC
		public static VectorOffset CreateCheckFlowLookAtConfigsVectorBlock(FlatBufferBuilder builder, Offset<ICheckFlowLookAtConfig>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ICheckFlowLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C00C RID: 180236 RVA: 0x0060BEF6 File Offset: 0x0060A0F6
		public static VectorOffset CreateCheckFlowLookAtConfigsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ICheckFlowLookAtConfig>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ICheckFlowLookAtConfig>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C00D RID: 180237 RVA: 0x0060BF14 File Offset: 0x0060A114
		public static VectorOffset CreateCheckFlowLookAtConfigsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ICheckFlowLookAtConfig>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C00E RID: 180238 RVA: 0x0060BF2D File Offset: 0x0060A12D
		public static void StartCheckFlowLookAtConfigsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C00F RID: 180239 RVA: 0x0060BF38 File Offset: 0x0060A138
		public static Offset<ICheckFlowLookAt> EndICheckFlowLookAt(FlatBufferBuilder builder)
		{
			return new Offset<ICheckFlowLookAt>(builder.EndTable());
		}

		// Token: 0x0602C010 RID: 180240 RVA: 0x0060BF48 File Offset: 0x0060A148
		public ICheckFlowLookAtT UnPack()
		{
			ICheckFlowLookAtT checkFlowLookAtT = new ICheckFlowLookAtT();
			this.UnPackTo(checkFlowLookAtT);
			return checkFlowLookAtT;
		}

		// Token: 0x0602C011 RID: 180241 RVA: 0x0060BF64 File Offset: 0x0060A164
		public void UnPackTo(ICheckFlowLookAtT _o)
		{
			_o.Type = this.Type;
			_o.CheckFlowLookAtConfigs = new List<ICheckFlowLookAtConfigT>();
			for (int i = 0; i < this.CheckFlowLookAtConfigsLength; i++)
			{
				_o.CheckFlowLookAtConfigs.Add((this.CheckFlowLookAtConfigs(i) != null) ? this.CheckFlowLookAtConfigs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602C012 RID: 180242 RVA: 0x0060BFD0 File Offset: 0x0060A1D0
		public static Offset<ICheckFlowLookAt> Pack(FlatBufferBuilder builder, ICheckFlowLookAtT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckFlowLookAt>);
			}
			VectorOffset checkFlowLookAtConfigsOffset = default(VectorOffset);
			if (_o.CheckFlowLookAtConfigs != null)
			{
				Offset<ICheckFlowLookAtConfig>[] array = new Offset<ICheckFlowLookAtConfig>[_o.CheckFlowLookAtConfigs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = ICheckFlowLookAtConfig.Pack(builder, _o.CheckFlowLookAtConfigs[i]);
				}
				checkFlowLookAtConfigsOffset = ICheckFlowLookAt.CreateCheckFlowLookAtConfigsVector(builder, array);
			}
			return ICheckFlowLookAt.CreateICheckFlowLookAt(builder, _o.Type, checkFlowLookAtConfigsOffset);
		}

		// Token: 0x04010928 RID: 67880
		private Table __p;
	}
}
