using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004703 RID: 18179
	public struct IRunningFlowInfo : IFlatbufferObject
	{
		// Token: 0x17008211 RID: 33297
		// (get) Token: 0x0601BDD9 RID: 114137 RVA: 0x003F323F File Offset: 0x003F143F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BDDA RID: 114138 RVA: 0x003F324C File Offset: 0x003F144C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BDDB RID: 114139 RVA: 0x003F3254 File Offset: 0x003F1454
		public static IRunningFlowInfo GetRootAsIRunningFlowInfo(ByteBuffer _bb)
		{
			return IRunningFlowInfo.GetRootAsIRunningFlowInfo(_bb, default(IRunningFlowInfo));
		}

		// Token: 0x0601BDDC RID: 114140 RVA: 0x003F3270 File Offset: 0x003F1470
		public static IRunningFlowInfo GetRootAsIRunningFlowInfo(ByteBuffer _bb, IRunningFlowInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BDDD RID: 114141 RVA: 0x003F328D File Offset: 0x003F148D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BDDE RID: 114142 RVA: 0x003F329C File Offset: 0x003F149C
		public IRunningFlowInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008212 RID: 33298
		// (get) Token: 0x0601BDDF RID: 114143 RVA: 0x003F32AC File Offset: 0x003F14AC
		public bool IsPlaying
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601BDE0 RID: 114144 RVA: 0x003F32EC File Offset: 0x003F14EC
		public Record_Int_EActionState? ActionInfo(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new Record_Int_EActionState?(default(Record_Int_EActionState).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17008213 RID: 33299
		// (get) Token: 0x0601BDE1 RID: 114145 RVA: 0x003F334C File Offset: 0x003F154C
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

		// Token: 0x0601BDE2 RID: 114146 RVA: 0x003F3377 File Offset: 0x003F1577
		public static Offset<IRunningFlowInfo> CreateIRunningFlowInfo(FlatBufferBuilder builder, bool IsPlaying = false, VectorOffset ActionInfoOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IRunningFlowInfo.AddActionInfo(builder, ActionInfoOffset);
			IRunningFlowInfo.AddIsPlaying(builder, IsPlaying);
			return IRunningFlowInfo.EndIRunningFlowInfo(builder);
		}

		// Token: 0x0601BDE3 RID: 114147 RVA: 0x003F3394 File Offset: 0x003F1594
		public static void StartIRunningFlowInfo(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601BDE4 RID: 114148 RVA: 0x003F339D File Offset: 0x003F159D
		public static void AddIsPlaying(FlatBufferBuilder builder, bool isPlaying)
		{
			builder.AddBool(0, isPlaying, false);
		}

		// Token: 0x0601BDE5 RID: 114149 RVA: 0x003F33A8 File Offset: 0x003F15A8
		public static void AddActionInfo(FlatBufferBuilder builder, VectorOffset actionInfoOffset)
		{
			builder.AddOffset(1, actionInfoOffset.Value, 0);
		}

		// Token: 0x0601BDE6 RID: 114150 RVA: 0x003F33B8 File Offset: 0x003F15B8
		public static VectorOffset CreateActionInfoVector(FlatBufferBuilder builder, Offset<Record_Int_EActionState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0601BDE7 RID: 114151 RVA: 0x003F33F8 File Offset: 0x003F15F8
		public static VectorOffset CreateActionInfoVectorBlock(FlatBufferBuilder builder, Offset<Record_Int_EActionState>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<Record_Int_EActionState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BDE8 RID: 114152 RVA: 0x003F3412 File Offset: 0x003F1612
		public static VectorOffset CreateActionInfoVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<Record_Int_EActionState>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<Record_Int_EActionState>>(data);
			return builder.EndVector();
		}

		// Token: 0x0601BDE9 RID: 114153 RVA: 0x003F3430 File Offset: 0x003F1630
		public static VectorOffset CreateActionInfoVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<Record_Int_EActionState>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0601BDEA RID: 114154 RVA: 0x003F3449 File Offset: 0x003F1649
		public static void StartActionInfoVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0601BDEB RID: 114155 RVA: 0x003F3454 File Offset: 0x003F1654
		public static Offset<IRunningFlowInfo> EndIRunningFlowInfo(FlatBufferBuilder builder)
		{
			return new Offset<IRunningFlowInfo>(builder.EndTable());
		}

		// Token: 0x0601BDEC RID: 114156 RVA: 0x003F3464 File Offset: 0x003F1664
		public IRunningFlowInfoT UnPack()
		{
			IRunningFlowInfoT runningFlowInfoT = new IRunningFlowInfoT();
			this.UnPackTo(runningFlowInfoT);
			return runningFlowInfoT;
		}

		// Token: 0x0601BDED RID: 114157 RVA: 0x003F3480 File Offset: 0x003F1680
		public void UnPackTo(IRunningFlowInfoT _o)
		{
			_o.IsPlaying = this.IsPlaying;
			_o.ActionInfo = new List<Record_Int_EActionStateT>();
			for (int i = 0; i < this.ActionInfoLength; i++)
			{
				_o.ActionInfo.Add((this.ActionInfo(i) != null) ? this.ActionInfo(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0601BDEE RID: 114158 RVA: 0x003F34EC File Offset: 0x003F16EC
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

		// Token: 0x0400C9BC RID: 51644
		private Table __p;
	}
}
