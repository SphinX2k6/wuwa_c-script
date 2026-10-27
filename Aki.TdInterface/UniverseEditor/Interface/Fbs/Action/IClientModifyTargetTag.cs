using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063D9 RID: 25561
	public struct IClientModifyTargetTag : IFlatbufferObject
	{
		// Token: 0x1700BE68 RID: 48744
		// (get) Token: 0x0602C367 RID: 181095 RVA: 0x00611B1D File Offset: 0x0060FD1D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C368 RID: 181096 RVA: 0x00611B2A File Offset: 0x0060FD2A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C369 RID: 181097 RVA: 0x00611B34 File Offset: 0x0060FD34
		public static IClientModifyTargetTag GetRootAsIClientModifyTargetTag(ByteBuffer _bb)
		{
			return IClientModifyTargetTag.GetRootAsIClientModifyTargetTag(_bb, default(IClientModifyTargetTag));
		}

		// Token: 0x0602C36A RID: 181098 RVA: 0x00611B50 File Offset: 0x0060FD50
		public static IClientModifyTargetTag GetRootAsIClientModifyTargetTag(ByteBuffer _bb, IClientModifyTargetTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C36B RID: 181099 RVA: 0x00611B6D File Offset: 0x0060FD6D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C36C RID: 181100 RVA: 0x00611B7C File Offset: 0x0060FD7C
		public IClientModifyTargetTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE69 RID: 48745
		// (get) Token: 0x0602C36D RID: 181101 RVA: 0x00611B8C File Offset: 0x0060FD8C
		public bool IsAddTag
		{
			get
			{
				int num = this.__p.__offset(4);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700BE6A RID: 48746
		// (get) Token: 0x0602C36E RID: 181102 RVA: 0x00611BCC File Offset: 0x0060FDCC
		public TClientModifyTarget TargetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TClientModifyTarget.NONE;
				}
				return (TClientModifyTarget)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602C36F RID: 181103 RVA: 0x00611C08 File Offset: 0x0060FE08
		public TTable? Target<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C370 RID: 181104 RVA: 0x00611C4C File Offset: 0x0060FE4C
		public IClientModifyPlayerTarget TargetAsIClientModifyPlayerTarget()
		{
			return this.Target<IClientModifyPlayerTarget>().Value;
		}

		// Token: 0x0602C371 RID: 181105 RVA: 0x00611C68 File Offset: 0x0060FE68
		public IClientModifySelfTarget TargetAsIClientModifySelfTarget()
		{
			return this.Target<IClientModifySelfTarget>().Value;
		}

		// Token: 0x0602C372 RID: 181106 RVA: 0x00611C84 File Offset: 0x0060FE84
		public string PerformanceTag(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700BE6B RID: 48747
		// (get) Token: 0x0602C373 RID: 181107 RVA: 0x00611CC0 File Offset: 0x0060FEC0
		public int PerformanceTagLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602C374 RID: 181108 RVA: 0x00611CEC File Offset: 0x0060FEEC
		public static Offset<IClientModifyTargetTag> CreateIClientModifyTargetTag(FlatBufferBuilder builder, bool IsAddTag = false, TClientModifyTarget Target_type = TClientModifyTarget.NONE, int TargetOffset = 0, VectorOffset PerformanceTagOffset = default(VectorOffset))
		{
			builder.StartTable(4);
			IClientModifyTargetTag.AddPerformanceTag(builder, PerformanceTagOffset);
			IClientModifyTargetTag.AddTarget(builder, TargetOffset);
			IClientModifyTargetTag.AddTargetType(builder, Target_type);
			IClientModifyTargetTag.AddIsAddTag(builder, IsAddTag);
			return IClientModifyTargetTag.EndIClientModifyTargetTag(builder);
		}

		// Token: 0x0602C375 RID: 181109 RVA: 0x00611D18 File Offset: 0x0060FF18
		public static void StartIClientModifyTargetTag(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602C376 RID: 181110 RVA: 0x00611D21 File Offset: 0x0060FF21
		public static void AddIsAddTag(FlatBufferBuilder builder, bool isAddTag)
		{
			builder.AddBool(0, isAddTag, false);
		}

		// Token: 0x0602C377 RID: 181111 RVA: 0x00611D2C File Offset: 0x0060FF2C
		public static void AddTargetType(FlatBufferBuilder builder, TClientModifyTarget targetType)
		{
			builder.AddByte(1, (byte)targetType, 0);
		}

		// Token: 0x0602C378 RID: 181112 RVA: 0x00611D37 File Offset: 0x0060FF37
		public static void AddTarget(FlatBufferBuilder builder, int targetOffset)
		{
			builder.AddOffset(2, targetOffset, 0);
		}

		// Token: 0x0602C379 RID: 181113 RVA: 0x00611D42 File Offset: 0x0060FF42
		public static void AddPerformanceTag(FlatBufferBuilder builder, VectorOffset performanceTagOffset)
		{
			builder.AddOffset(3, performanceTagOffset.Value, 0);
		}

		// Token: 0x0602C37A RID: 181114 RVA: 0x00611D54 File Offset: 0x0060FF54
		public static VectorOffset CreatePerformanceTagVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602C37B RID: 181115 RVA: 0x00611D94 File Offset: 0x0060FF94
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C37C RID: 181116 RVA: 0x00611DAE File Offset: 0x0060FFAE
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0602C37D RID: 181117 RVA: 0x00611DCC File Offset: 0x0060FFCC
		public static VectorOffset CreatePerformanceTagVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602C37E RID: 181118 RVA: 0x00611DE5 File Offset: 0x0060FFE5
		public static void StartPerformanceTagVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602C37F RID: 181119 RVA: 0x00611DF0 File Offset: 0x0060FFF0
		public static Offset<IClientModifyTargetTag> EndIClientModifyTargetTag(FlatBufferBuilder builder)
		{
			return new Offset<IClientModifyTargetTag>(builder.EndTable());
		}

		// Token: 0x0602C380 RID: 181120 RVA: 0x00611E00 File Offset: 0x00610000
		public IClientModifyTargetTagT UnPack()
		{
			IClientModifyTargetTagT clientModifyTargetTagT = new IClientModifyTargetTagT();
			this.UnPackTo(clientModifyTargetTagT);
			return clientModifyTargetTagT;
		}

		// Token: 0x0602C381 RID: 181121 RVA: 0x00611E1C File Offset: 0x0061001C
		public void UnPackTo(IClientModifyTargetTagT _o)
		{
			_o.IsAddTag = this.IsAddTag;
			_o.Target = new TClientModifyTargetUnion();
			_o.Target.Type = this.TargetType;
			TClientModifyTarget targetType = this.TargetType;
			if (targetType != TClientModifyTarget.IClientModifyPlayerTarget)
			{
				if (targetType == TClientModifyTarget.IClientModifySelfTarget)
				{
					_o.Target.Value = ((this.Target<IClientModifySelfTarget>() != null) ? this.Target<IClientModifySelfTarget>().Value.UnPack() : null);
				}
			}
			else
			{
				_o.Target.Value = ((this.Target<IClientModifyPlayerTarget>() != null) ? this.Target<IClientModifyPlayerTarget>().Value.UnPack() : null);
			}
			_o.PerformanceTag = new List<string>();
			for (int i = 0; i < this.PerformanceTagLength; i++)
			{
				_o.PerformanceTag.Add(this.PerformanceTag(i));
			}
		}

		// Token: 0x0602C382 RID: 181122 RVA: 0x00611F00 File Offset: 0x00610100
		public static Offset<IClientModifyTargetTag> Pack(FlatBufferBuilder builder, IClientModifyTargetTagT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientModifyTargetTag>);
			}
			TClientModifyTarget target_type = (_o.Target == null) ? TClientModifyTarget.NONE : _o.Target.Type;
			int targetOffset = (_o.Target == null) ? 0 : TClientModifyTargetUnion.Pack(builder, _o.Target);
			VectorOffset performanceTagOffset = default(VectorOffset);
			if (_o.PerformanceTag != null)
			{
				StringOffset[] array = new StringOffset[_o.PerformanceTag.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.PerformanceTag[i]);
				}
				performanceTagOffset = IClientModifyTargetTag.CreatePerformanceTagVector(builder, array);
			}
			return IClientModifyTargetTag.CreateIClientModifyTargetTag(builder, _o.IsAddTag, target_type, targetOffset, performanceTagOffset);
		}

		// Token: 0x040109B3 RID: 68019
		private Table __p;
	}
}
