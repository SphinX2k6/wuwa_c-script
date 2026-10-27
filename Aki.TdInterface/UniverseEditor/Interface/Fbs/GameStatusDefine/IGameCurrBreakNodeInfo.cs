using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x020046F1 RID: 18161
	public struct IGameCurrBreakNodeInfo : IFlatbufferObject
	{
		// Token: 0x170081D3 RID: 33235
		// (get) Token: 0x0601BCB1 RID: 113841 RVA: 0x003F09A4 File Offset: 0x003EEBA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BCB2 RID: 113842 RVA: 0x003F09B1 File Offset: 0x003EEBB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BCB3 RID: 113843 RVA: 0x003F09B8 File Offset: 0x003EEBB8
		public static IGameCurrBreakNodeInfo GetRootAsIGameCurrBreakNodeInfo(ByteBuffer _bb)
		{
			return IGameCurrBreakNodeInfo.GetRootAsIGameCurrBreakNodeInfo(_bb, default(IGameCurrBreakNodeInfo));
		}

		// Token: 0x0601BCB4 RID: 113844 RVA: 0x003F09D4 File Offset: 0x003EEBD4
		public static IGameCurrBreakNodeInfo GetRootAsIGameCurrBreakNodeInfo(ByteBuffer _bb, IGameCurrBreakNodeInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BCB5 RID: 113845 RVA: 0x003F09F1 File Offset: 0x003EEBF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BCB6 RID: 113846 RVA: 0x003F0A00 File Offset: 0x003EEC00
		public IGameCurrBreakNodeInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170081D4 RID: 33236
		// (get) Token: 0x0601BCB7 RID: 113847 RVA: 0x003F0A10 File Offset: 0x003EEC10
		public int Id
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170081D5 RID: 33237
		// (get) Token: 0x0601BCB8 RID: 113848 RVA: 0x003F0A4C File Offset: 0x003EEC4C
		public ENodeBreakMoment BreakMoment
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return ENodeBreakMoment.Null;
				}
				return (ENodeBreakMoment)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601BCB9 RID: 113849 RVA: 0x003F0A88 File Offset: 0x003EEC88
		public IGameCurrBreakNodeInfo_RefVars? RefVars(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IGameCurrBreakNodeInfo_RefVars?(default(IGameCurrBreakNodeInfo_RefVars).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170081D6 RID: 33238
		// (get) Token: 0x0601BCBA RID: 113850 RVA: 0x003F0AE8 File Offset: 0x003EECE8
		public int RefVarsLength
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

		// Token: 0x0601BCBB RID: 113851 RVA: 0x003F0B13 File Offset: 0x003EED13
		public static Offset<IGameCurrBreakNodeInfo> CreateIGameCurrBreakNodeInfo(FlatBufferBuilder builder, int Id = 0, ENodeBreakMoment BreakMoment = ENodeBreakMoment.Null, VectorOffset RefVarsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IGameCurrBreakNodeInfo.AddRefVars(builder, RefVarsOffset);
			IGameCurrBreakNodeInfo.AddId(builder, Id);
			IGameCurrBreakNodeInfo.AddBreakMoment(builder, BreakMoment);
			return IGameCurrBreakNodeInfo.EndIGameCurrBreakNodeInfo(builder);
		}

		// Token: 0x0601BCBC RID: 113852 RVA: 0x003F0B37 File Offset: 0x003EED37
		public static void StartIGameCurrBreakNodeInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601BCBD RID: 113853 RVA: 0x003F0B40 File Offset: 0x003EED40
		public static void AddId(FlatBufferBuilder builder, int id)
		{
			builder.AddInt(0, id, 0);
		}

		// Token: 0x0601BCBE RID: 113854 RVA: 0x003F0B4B File Offset: 0x003EED4B
		public static void AddBreakMoment(FlatBufferBuilder builder, ENodeBreakMoment breakMoment)
		{
			builder.AddByte(1, (byte)breakMoment, 0);
		}

		// Token: 0x0601BCBF RID: 113855 RVA: 0x003F0B56 File Offset: 0x003EED56
		public static void AddRefVars(FlatBufferBuilder builder, VectorOffset refVarsOffset)
		{
			builder.AddOffset(2, refVarsOffset.Value, 0);
		}

		// Token: 0x0601BCC0 RID: 113856 RVA: 0x003F0B68 File Offset: 0x003EED68
		public static VectorOffset CreateRefVarsVector(FlatBufferBuilder builder, Offset<IGameCurrBreakNodeInfo_RefVars>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BCC1 RID: 113857 RVA: 0x003F0BA8 File Offset: 0x003EEDA8
		public static VectorOffset CreateRefVarsVectorBlock(FlatBufferBuilder builder, Offset<IGameCurrBreakNodeInfo_RefVars>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IGameCurrBreakNodeInfo_RefVars>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BCC2 RID: 113858 RVA: 0x003F0BC2 File Offset: 0x003EEDC2
		public static VectorOffset CreateRefVarsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IGameCurrBreakNodeInfo_RefVars>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IGameCurrBreakNodeInfo_RefVars>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BCC3 RID: 113859 RVA: 0x003F0BE0 File Offset: 0x003EEDE0
		public static VectorOffset CreateRefVarsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IGameCurrBreakNodeInfo_RefVars>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BCC4 RID: 113860 RVA: 0x003F0BF9 File Offset: 0x003EEDF9
		public static void StartRefVarsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BCC5 RID: 113861 RVA: 0x003F0C04 File Offset: 0x003EEE04
		public static Offset<IGameCurrBreakNodeInfo> EndIGameCurrBreakNodeInfo(FlatBufferBuilder builder)
		{
			return new Offset<IGameCurrBreakNodeInfo>(builder.EndTable());
		}

		// Token: 0x0601BCC6 RID: 113862 RVA: 0x003F0C14 File Offset: 0x003EEE14
		public IGameCurrBreakNodeInfoT UnPack()
		{
			IGameCurrBreakNodeInfoT gameCurrBreakNodeInfoT = new IGameCurrBreakNodeInfoT();
			this.UnPackTo(gameCurrBreakNodeInfoT);
			return gameCurrBreakNodeInfoT;
		}

		// Token: 0x0601BCC7 RID: 113863 RVA: 0x003F0C30 File Offset: 0x003EEE30
		public void UnPackTo(IGameCurrBreakNodeInfoT _o)
		{
			_o.Id = this.Id;
			_o.BreakMoment = this.BreakMoment;
			_o.RefVars = new List<IGameCurrBreakNodeInfo_RefVarsT>();
			for (int i = 0; i < this.RefVarsLength; i++)
			{
				_o.RefVars.Add((this.RefVars(i) != null) ? this.RefVars(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601BCC8 RID: 113864 RVA: 0x003F0CA8 File Offset: 0x003EEEA8
		public static Offset<IGameCurrBreakNodeInfo> Pack(FlatBufferBuilder builder, IGameCurrBreakNodeInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IGameCurrBreakNodeInfo>);
			}
			VectorOffset refVarsOffset = default(VectorOffset);
			if (_o.RefVars != null)
			{
				Offset<IGameCurrBreakNodeInfo_RefVars>[] array = new Offset<IGameCurrBreakNodeInfo_RefVars>[_o.RefVars.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IGameCurrBreakNodeInfo_RefVars.Pack(builder, _o.RefVars[i]);
				}
				refVarsOffset = IGameCurrBreakNodeInfo.CreateRefVarsVector(builder, array);
			}
			return IGameCurrBreakNodeInfo.CreateIGameCurrBreakNodeInfo(builder, _o.Id, _o.BreakMoment, refVarsOffset);
		}

		// Token: 0x0400C99A RID: 51610
		private Table __p;
	}
}
