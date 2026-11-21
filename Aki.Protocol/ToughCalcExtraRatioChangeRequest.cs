using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001407 RID: 5127
	[NetMessage(EMessageId.ToughCalcExtraRatioChangeRequest)]
	public sealed class ToughCalcExtraRatioChangeRequest : IMessage<ToughCalcExtraRatioChangeRequest>, IMessage, IEquatable<ToughCalcExtraRatioChangeRequest>, IDeepCloneable<ToughCalcExtraRatioChangeRequest>, IBufferMessage
	{
		// Token: 0x0601B417 RID: 111639 RVA: 0x003F6EF0 File Offset: 0x003F50F0
		[NullableContext(1)]
		public static ToughCalcExtraRatioChangeRequest Create()
		{
			return new ToughCalcExtraRatioChangeRequest();
		}

		// Token: 0x17005C42 RID: 23618
		// (get) Token: 0x0601B418 RID: 111640 RVA: 0x003F6EF7 File Offset: 0x003F50F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C43 RID: 23619
		// (get) Token: 0x0601B419 RID: 111641 RVA: 0x003F6EFA File Offset: 0x003F50FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ToughCalcExtraRatioChangeRequest.Descriptor;
			}
		}

		// Token: 0x0601B41A RID: 111642 RVA: 0x003F6F01 File Offset: 0x003F5101
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangeRequest()
		{
		}

		// Token: 0x0601B41B RID: 111643 RVA: 0x003F6F09 File Offset: 0x003F5109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangeRequest(ToughCalcExtraRatioChangeRequest other) : this()
		{
			this.id_ = other.id_;
			this.duration_ = other.duration_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B41C RID: 111644 RVA: 0x003F6F3A File Offset: 0x003F513A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ToughCalcExtraRatioChangeRequest Clone()
		{
			return new ToughCalcExtraRatioChangeRequest(this);
		}

		// Token: 0x17005C44 RID: 23620
		// (get) Token: 0x0601B41D RID: 111645 RVA: 0x003F6F42 File Offset: 0x003F5142
		// (set) Token: 0x0601B41E RID: 111646 RVA: 0x003F6F4A File Offset: 0x003F514A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17005C45 RID: 23621
		// (get) Token: 0x0601B41F RID: 111647 RVA: 0x003F6F53 File Offset: 0x003F5153
		// (set) Token: 0x0601B420 RID: 111648 RVA: 0x003F6F5B File Offset: 0x003F515B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Duration
		{
			get
			{
				return this.duration_;
			}
			set
			{
				this.duration_ = value;
			}
		}

		// Token: 0x0601B421 RID: 111649 RVA: 0x003F6F64 File Offset: 0x003F5164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ToughCalcExtraRatioChangeRequest);
		}

		// Token: 0x0601B422 RID: 111650 RVA: 0x003F6F72 File Offset: 0x003F5172
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ToughCalcExtraRatioChangeRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Duration == other.Duration && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B423 RID: 111651 RVA: 0x003F6FB0 File Offset: 0x003F51B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Duration != 0)
			{
				num ^= this.Duration.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B424 RID: 111652 RVA: 0x003F7008 File Offset: 0x003F5208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B425 RID: 111653 RVA: 0x003F7015 File Offset: 0x003F5215
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B426 RID: 111654 RVA: 0x003F7020 File Offset: 0x003F5220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.Id);
			}
			if (this.Duration != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Duration);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B427 RID: 111655 RVA: 0x003F707C File Offset: 0x003F527C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this.Duration != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Duration);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B428 RID: 111656 RVA: 0x003F70D4 File Offset: 0x003F52D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ToughCalcExtraRatioChangeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			if (other.Duration != 0)
			{
				this.Duration = other.Duration;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B429 RID: 111657 RVA: 0x003F7124 File Offset: 0x003F5324
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B42A RID: 111658 RVA: 0x003F7130 File Offset: 0x003F5330
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
				if (num != 72U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Duration = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009EDA RID: 40666
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EDB RID: 40667
		public const int IdFieldNumber = 9;

		// Token: 0x04009EDC RID: 40668
		private long id_;

		// Token: 0x04009EDD RID: 40669
		public const int DurationFieldNumber = 11;

		// Token: 0x04009EDE RID: 40670
		private int duration_;
	}
}
