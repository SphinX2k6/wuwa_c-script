using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B6B RID: 19307
	public struct IRunningFlowInfo : IFlatbufferObject
	{
		// Token: 0x17008852 RID: 34898
		// (get) Token: 0x0601D5AE RID: 120238 RVA: 0x0041F4DB File Offset: 0x0041D6DB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601D5AF RID: 120239 RVA: 0x0041F4E8 File Offset: 0x0041D6E8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601D5B0 RID: 120240 RVA: 0x0041F4F0 File Offset: 0x0041D6F0
		public static IRunningFlowInfo GetRootAsIRunningFlowInfo(ByteBuffer _bb)
		{
			return IRunningFlowInfo.GetRootAsIRunningFlowInfo(_bb, default(IRunningFlowInfo));
		}

		// Token: 0x0601D5B1 RID: 120241 RVA: 0x0041F50C File Offset: 0x0041D70C
		public static IRunningFlowInfo GetRootAsIRunningFlowInfo(ByteBuffer _bb, IRunningFlowInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601D5B2 RID: 120242 RVA: 0x0041F529 File Offset: 0x0041D729
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601D5B3 RID: 120243 RVA: 0x0041F538 File Offset: 0x0041D738
		public IRunningFlowInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008853 RID: 34899
		// (get) Token: 0x0601D5B4 RID: 120244 RVA: 0x0041F548 File Offset: 0x0041D748
		public bool IsPlaying
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601D5B5 RID: 120245 RVA: 0x0041F588 File Offset: 0x0041D788
		public Record_Int_EActionState? ActionInfo(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_EActionState?(default(Record_Int_EActionState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008854 RID: 34900
		// (get) Token: 0x0601D5B6 RID: 120246 RVA: 0x0041F5E8 File Offset: 0x0041D7E8
		public int ActionInfoLength
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

		// Token: 0x0601D5B7 RID: 120247 RVA: 0x0041F613 File Offset: 0x0041D813
		public static Offset<IRunningFlowInfo> CreateIRunningFlowInfo(FlatBufferBuilder builder, bool IsPlaying = false, VectorOffset ActionInfoOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRunningFlowInfo.AddActionInfo(builder, ActionInfoOffset);
			IRunningFlowInfo.AddIsPlaying(builder, IsPlaying);
			return IRunningFlowInfo.EndIRunningFlowInfo(builder);
		}

		// Token: 0x0601D5B8 RID: 120248 RVA: 0x0041F630 File Offset: 0x0041D830
		public static void StartIRunningFlowInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601D5B9 RID: 120249 RVA: 0x0041F639 File Offset: 0x0041D839
		public static void AddIsPlaying(FlatBufferBuilder builder, bool isPlaying)
		{
			builder.AddBool(0, isPlaying, false);
		}

		// Token: 0x0601D5BA RID: 120250 RVA: 0x0041F644 File Offset: 0x0041D844
		public static void AddActionInfo(FlatBufferBuilder builder, VectorOffset actionInfoOffset)
		{
			builder.AddOffset(1, actionInfoOffset.Value, 0);
		}

		// Token: 0x0601D5BB RID: 120251 RVA: 0x0041F654 File Offset: 0x0041D854
		public static VectorOffset CreateActionInfoVector(FlatBufferBuilder builder, Offset<Record_Int_EActionState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601D5BC RID: 120252 RVA: 0x0041F694 File Offset: 0x0041D894
		public static VectorOffset CreateActionInfoVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_EActionState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_EActionState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D5BD RID: 120253 RVA: 0x0041F6AE File Offset: 0x0041D8AE
		public static VectorOffset CreateActionInfoVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_EActionState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_EActionState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601D5BE RID: 120254 RVA: 0x0041F6CC File Offset: 0x0041D8CC
		public static VectorOffset CreateActionInfoVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_EActionState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601D5BF RID: 120255 RVA: 0x0041F6E5 File Offset: 0x0041D8E5
		public static void StartActionInfoVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601D5C0 RID: 120256 RVA: 0x0041F6F0 File Offset: 0x0041D8F0
		public static Offset<IRunningFlowInfo> EndIRunningFlowInfo(FlatBufferBuilder builder)
		{
			return new Offset<IRunningFlowInfo>(builder.EndTable());
		}

		// Token: 0x0601D5C1 RID: 120257 RVA: 0x0041F700 File Offset: 0x0041D900
		public IRunningFlowInfoT UnPack()
		{
			IRunningFlowInfoT runningFlowInfoT = new IRunningFlowInfoT();
			this.UnPackTo(runningFlowInfoT);
			return runningFlowInfoT;
		}

		// Token: 0x0601D5C2 RID: 120258 RVA: 0x0041F71C File Offset: 0x0041D91C
		public void UnPackTo(IRunningFlowInfoT _o)
		{
			_o.IsPlaying = this.IsPlaying;
			_o.ActionInfo = new List<Record_Int_EActionStateT>();
			for (int i = 0; i < this.ActionInfoLength; i++)
			{
				_o.ActionInfo.Add((this.ActionInfo(i) != null) ? this.ActionInfo(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601D5C3 RID: 120259 RVA: 0x0041F788 File Offset: 0x0041D988
		public static Offset<IRunningFlowInfo> Pack(FlatBufferBuilder builder, IRunningFlowInfoT _o)
		{
			if (_o == null)
			{
				return default(Offset<IRunningFlowInfo>);
			}
			VectorOffset actionInfoOffset = default(VectorOffset);
			if (_o.ActionInfo != null)
			{
				Offset<Record_Int_EActionState>[] array = new Offset<Record_Int_EActionState>[_o.ActionInfo.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = Record_Int_EActionState.Pack(builder, _o.ActionInfo[i]);
				}
				actionInfoOffset = IRunningFlowInfo.CreateActionInfoVector(builder, array);
			}
			return IRunningFlowInfo.CreateIRunningFlowInfo(builder, _o.IsPlaying, actionInfoOffset);
		}

		// Token: 0x0400D3EB RID: 54251
		private Table __p;
	}
}
