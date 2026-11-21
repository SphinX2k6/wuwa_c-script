using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000872 RID: 2162
	public sealed class KillProgress : IMessage<KillProgress>, IMessage, IEquatable<KillProgress>, IDeepCloneable<KillProgress>, IBufferMessage
	{
		// Token: 0x0600C0D2 RID: 49362 RVA: 0x001CA5A1 File Offset: 0x001C87A1
		[NullableContext(1)]
		public static KillProgress Create()
		{
			return new KillProgress();
		}

		// Token: 0x170026F3 RID: 9971
		// (get) Token: 0x0600C0D3 RID: 49363 RVA: 0x001CA5A8 File Offset: 0x001C87A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026F4 RID: 9972
		// (get) Token: 0x0600C0D4 RID: 49364 RVA: 0x001CA5AB File Offset: 0x001C87AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KillProgress.Descriptor;
			}
		}

		// Token: 0x0600C0D5 RID: 49365 RVA: 0x001CA5B2 File Offset: 0x001C87B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KillProgress()
		{
		}

		// Token: 0x0600C0D6 RID: 49366 RVA: 0x001CA5C8 File Offset: 0x001C87C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KillProgress(KillProgress other) : this()
		{
			this.monId_ = other.monId_.Clone();
			this.prefabNum_ = other.prefabNum_;
			this.currNum_ = other.currNum_;
			this.totalNum_ = other.totalNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C0D7 RID: 49367 RVA: 0x001CA621 File Offset: 0x001C8821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KillProgress Clone()
		{
			return new KillProgress(this);
		}

		// Token: 0x170026F5 RID: 9973
		// (get) Token: 0x0600C0D8 RID: 49368 RVA: 0x001CA629 File Offset: 0x001C8829
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MonId
		{
			get
			{
				return this.monId_;
			}
		}

		// Token: 0x170026F6 RID: 9974
		// (get) Token: 0x0600C0D9 RID: 49369 RVA: 0x001CA631 File Offset: 0x001C8831
		// (set) Token: 0x0600C0DA RID: 49370 RVA: 0x001CA639 File Offset: 0x001C8839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PrefabNum
		{
			get
			{
				return this.prefabNum_;
			}
			set
			{
				this.prefabNum_ = value;
			}
		}

		// Token: 0x170026F7 RID: 9975
		// (get) Token: 0x0600C0DB RID: 49371 RVA: 0x001CA642 File Offset: 0x001C8842
		// (set) Token: 0x0600C0DC RID: 49372 RVA: 0x001CA64A File Offset: 0x001C884A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurrNum
		{
			get
			{
				return this.currNum_;
			}
			set
			{
				this.currNum_ = value;
			}
		}

		// Token: 0x170026F8 RID: 9976
		// (get) Token: 0x0600C0DD RID: 49373 RVA: 0x001CA653 File Offset: 0x001C8853
		// (set) Token: 0x0600C0DE RID: 49374 RVA: 0x001CA65B File Offset: 0x001C885B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TotalNum
		{
			get
			{
				return this.totalNum_;
			}
			set
			{
				this.totalNum_ = value;
			}
		}

		// Token: 0x0600C0DF RID: 49375 RVA: 0x001CA664 File Offset: 0x001C8864
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KillProgress);
		}

		// Token: 0x0600C0E0 RID: 49376 RVA: 0x001CA674 File Offset: 0x001C8874
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KillProgress other)
		{
			return other != null && (other == this || (this.monId_.Equals(other.monId_) && this.PrefabNum == other.PrefabNum && this.CurrNum == other.CurrNum && this.TotalNum == other.TotalNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C0E1 RID: 49377 RVA: 0x001CA6E4 File Offset: 0x001C88E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.monId_.GetHashCode();
			if (this.PrefabNum != 0)
			{
				num ^= this.PrefabNum.GetHashCode();
			}
			if (this.CurrNum != 0)
			{
				num ^= this.CurrNum.GetHashCode();
			}
			if (this.TotalNum != 0)
			{
				num ^= this.TotalNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C0E2 RID: 49378 RVA: 0x001CA763 File Offset: 0x001C8963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C0E3 RID: 49379 RVA: 0x001CA770 File Offset: 0x001C8970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C0E4 RID: 49380 RVA: 0x001CA77C File Offset: 0x001C897C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.monId_.WriteTo(ref output, KillProgress._repeated_monId_codec);
			if (this.PrefabNum != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.PrefabNum);
			}
			if (this.CurrNum != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurrNum);
			}
			if (this.TotalNum != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TotalNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C0E5 RID: 49381 RVA: 0x001CA804 File Offset: 0x001C8A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.monId_.CalculateSize(KillProgress._repeated_monId_codec);
			if (this.PrefabNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PrefabNum);
			}
			if (this.CurrNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurrNum);
			}
			if (this.TotalNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TotalNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C0E6 RID: 49382 RVA: 0x001CA888 File Offset: 0x001C8A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KillProgress other)
		{
			if (other == null)
			{
				return;
			}
			this.monId_.Add(other.monId_);
			if (other.PrefabNum != 0)
			{
				this.PrefabNum = other.PrefabNum;
			}
			if (other.CurrNum != 0)
			{
				this.CurrNum = other.CurrNum;
			}
			if (other.TotalNum != 0)
			{
				this.TotalNum = other.TotalNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C0E7 RID: 49383 RVA: 0x001CA8FD File Offset: 0x001C8AFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C0E8 RID: 49384 RVA: 0x001CA908 File Offset: 0x001C8B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num <= 10U)
				{
					if (num == 8U || num == 10U)
					{
						this.monId_.AddEntriesFrom(ref input, KillProgress._repeated_monId_codec);
						continue;
					}
				}
				else
				{
					if (num == 16U)
					{
						this.PrefabNum = input.ReadInt32();
						continue;
					}
					if (num == 24U)
					{
						this.CurrNum = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.TotalNum = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400540D RID: 21517
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400540E RID: 21518
		public const int MonIdFieldNumber = 1;

		// Token: 0x0400540F RID: 21519
		private static readonly FieldCodec<int> _repeated_monId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04005410 RID: 21520
		private readonly RepeatedField<int> monId_ = new RepeatedField<int>();

		// Token: 0x04005411 RID: 21521
		public const int PrefabNumFieldNumber = 2;

		// Token: 0x04005412 RID: 21522
		private int prefabNum_;

		// Token: 0x04005413 RID: 21523
		public const int CurrNumFieldNumber = 3;

		// Token: 0x04005414 RID: 21524
		private int currNum_;

		// Token: 0x04005415 RID: 21525
		public const int TotalNumFieldNumber = 4;

		// Token: 0x04005416 RID: 21526
		private int totalNum_;
	}
}
