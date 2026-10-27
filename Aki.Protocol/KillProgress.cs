using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000883 RID: 2179
	public sealed class KillProgress : IMessage<KillProgress>, IMessage, IEquatable<KillProgress>, IDeepCloneable<KillProgress>, IBufferMessage
	{
		// Token: 0x0600C1EE RID: 49646 RVA: 0x001CC889 File Offset: 0x001CAA89
		[NullableContext(1)]
		public static KillProgress Create()
		{
			return new KillProgress();
		}

		// Token: 0x17002732 RID: 10034
		// (get) Token: 0x0600C1EF RID: 49647 RVA: 0x001CC890 File Offset: 0x001CAA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002733 RID: 10035
		// (get) Token: 0x0600C1F0 RID: 49648 RVA: 0x001CC893 File Offset: 0x001CAA93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KillProgress.Descriptor;
			}
		}

		// Token: 0x0600C1F1 RID: 49649 RVA: 0x001CC89A File Offset: 0x001CAA9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KillProgress()
		{
		}

		// Token: 0x0600C1F2 RID: 49650 RVA: 0x001CC8B0 File Offset: 0x001CAAB0
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

		// Token: 0x0600C1F3 RID: 49651 RVA: 0x001CC909 File Offset: 0x001CAB09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KillProgress Clone()
		{
			return new KillProgress(this);
		}

		// Token: 0x17002734 RID: 10036
		// (get) Token: 0x0600C1F4 RID: 49652 RVA: 0x001CC911 File Offset: 0x001CAB11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MonId
		{
			get
			{
				return this.monId_;
			}
		}

		// Token: 0x17002735 RID: 10037
		// (get) Token: 0x0600C1F5 RID: 49653 RVA: 0x001CC919 File Offset: 0x001CAB19
		// (set) Token: 0x0600C1F6 RID: 49654 RVA: 0x001CC921 File Offset: 0x001CAB21
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

		// Token: 0x17002736 RID: 10038
		// (get) Token: 0x0600C1F7 RID: 49655 RVA: 0x001CC92A File Offset: 0x001CAB2A
		// (set) Token: 0x0600C1F8 RID: 49656 RVA: 0x001CC932 File Offset: 0x001CAB32
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

		// Token: 0x17002737 RID: 10039
		// (get) Token: 0x0600C1F9 RID: 49657 RVA: 0x001CC93B File Offset: 0x001CAB3B
		// (set) Token: 0x0600C1FA RID: 49658 RVA: 0x001CC943 File Offset: 0x001CAB43
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

		// Token: 0x0600C1FB RID: 49659 RVA: 0x001CC94C File Offset: 0x001CAB4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KillProgress);
		}

		// Token: 0x0600C1FC RID: 49660 RVA: 0x001CC95C File Offset: 0x001CAB5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KillProgress other)
		{
			return other != null && (other == this || (this.monId_.Equals(other.monId_) && this.PrefabNum == other.PrefabNum && this.CurrNum == other.CurrNum && this.TotalNum == other.TotalNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C1FD RID: 49661 RVA: 0x001CC9CC File Offset: 0x001CABCC
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

		// Token: 0x0600C1FE RID: 49662 RVA: 0x001CCA4B File Offset: 0x001CAC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C1FF RID: 49663 RVA: 0x001CCA58 File Offset: 0x001CAC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C200 RID: 49664 RVA: 0x001CCA64 File Offset: 0x001CAC64
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

		// Token: 0x0600C201 RID: 49665 RVA: 0x001CCAEC File Offset: 0x001CACEC
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

		// Token: 0x0600C202 RID: 49666 RVA: 0x001CCB70 File Offset: 0x001CAD70
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

		// Token: 0x0600C203 RID: 49667 RVA: 0x001CCBE5 File Offset: 0x001CADE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C204 RID: 49668 RVA: 0x001CCBF0 File Offset: 0x001CADF0
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

		// Token: 0x04005406 RID: 21510
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005407 RID: 21511
		public const int MonIdFieldNumber = 1;

		// Token: 0x04005408 RID: 21512
		private static readonly FieldCodec<int> _repeated_monId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04005409 RID: 21513
		private readonly RepeatedField<int> monId_ = new RepeatedField<int>();

		// Token: 0x0400540A RID: 21514
		public const int PrefabNumFieldNumber = 2;

		// Token: 0x0400540B RID: 21515
		private int prefabNum_;

		// Token: 0x0400540C RID: 21516
		public const int CurrNumFieldNumber = 3;

		// Token: 0x0400540D RID: 21517
		private int currNum_;

		// Token: 0x0400540E RID: 21518
		public const int TotalNumFieldNumber = 4;

		// Token: 0x0400540F RID: 21519
		private int totalNum_;
	}
}
