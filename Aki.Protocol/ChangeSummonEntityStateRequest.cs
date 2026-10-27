using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000264 RID: 612
	[NetMessage(EMessageId.ChangeSummonEntityStateRequest)]
	public sealed class ChangeSummonEntityStateRequest : IMessage<ChangeSummonEntityStateRequest>, IMessage, IEquatable<ChangeSummonEntityStateRequest>, IDeepCloneable<ChangeSummonEntityStateRequest>, IBufferMessage
	{
		// Token: 0x060040B1 RID: 16561 RVA: 0x0009ECF6 File Offset: 0x0009CEF6
		[NullableContext(1)]
		public static ChangeSummonEntityStateRequest Create()
		{
			return new ChangeSummonEntityStateRequest();
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x060040B2 RID: 16562 RVA: 0x0009ECFD File Offset: 0x0009CEFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x060040B3 RID: 16563 RVA: 0x0009ED00 File Offset: 0x0009CF00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangeSummonEntityStateRequest.Descriptor;
			}
		}

		// Token: 0x060040B4 RID: 16564 RVA: 0x0009ED07 File Offset: 0x0009CF07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSummonEntityStateRequest()
		{
		}

		// Token: 0x060040B5 RID: 16565 RVA: 0x0009ED0F File Offset: 0x0009CF0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSummonEntityStateRequest(ChangeSummonEntityStateRequest other) : this()
		{
			this.summonEntityId_ = other.summonEntityId_;
			this.tagId_ = other.tagId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060040B6 RID: 16566 RVA: 0x0009ED40 File Offset: 0x0009CF40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangeSummonEntityStateRequest Clone()
		{
			return new ChangeSummonEntityStateRequest(this);
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x060040B7 RID: 16567 RVA: 0x0009ED48 File Offset: 0x0009CF48
		// (set) Token: 0x060040B8 RID: 16568 RVA: 0x0009ED50 File Offset: 0x0009CF50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SummonEntityId
		{
			get
			{
				return this.summonEntityId_;
			}
			set
			{
				this.summonEntityId_ = value;
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x060040B9 RID: 16569 RVA: 0x0009ED59 File Offset: 0x0009CF59
		// (set) Token: 0x060040BA RID: 16570 RVA: 0x0009ED61 File Offset: 0x0009CF61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TagId
		{
			get
			{
				return this.tagId_;
			}
			set
			{
				this.tagId_ = value;
			}
		}

		// Token: 0x060040BB RID: 16571 RVA: 0x0009ED6A File Offset: 0x0009CF6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangeSummonEntityStateRequest);
		}

		// Token: 0x060040BC RID: 16572 RVA: 0x0009ED78 File Offset: 0x0009CF78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangeSummonEntityStateRequest other)
		{
			return other != null && (other == this || (this.SummonEntityId == other.SummonEntityId && this.TagId == other.TagId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060040BD RID: 16573 RVA: 0x0009EDB8 File Offset: 0x0009CFB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SummonEntityId != 0L)
			{
				num ^= this.SummonEntityId.GetHashCode();
			}
			if (this.TagId != 0)
			{
				num ^= this.TagId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060040BE RID: 16574 RVA: 0x0009EE10 File Offset: 0x0009D010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060040BF RID: 16575 RVA: 0x0009EE1D File Offset: 0x0009D01D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060040C0 RID: 16576 RVA: 0x0009EE28 File Offset: 0x0009D028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TagId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.TagId);
			}
			if (this.SummonEntityId != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(this.SummonEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060040C1 RID: 16577 RVA: 0x0009EE84 File Offset: 0x0009D084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SummonEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SummonEntityId);
			}
			if (this.TagId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TagId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060040C2 RID: 16578 RVA: 0x0009EEDC File Offset: 0x0009D0DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangeSummonEntityStateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SummonEntityId != 0L)
			{
				this.SummonEntityId = other.SummonEntityId;
			}
			if (other.TagId != 0)
			{
				this.TagId = other.TagId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060040C3 RID: 16579 RVA: 0x0009EF2C File Offset: 0x0009D12C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060040C4 RID: 16580 RVA: 0x0009EF38 File Offset: 0x0009D138
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
				if (num != 48U)
				{
					if (num != 96U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SummonEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.TagId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04002D75 RID: 11637
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D76 RID: 11638
		public const int SummonEntityIdFieldNumber = 12;

		// Token: 0x04002D77 RID: 11639
		private long summonEntityId_;

		// Token: 0x04002D78 RID: 11640
		public const int TagIdFieldNumber = 6;

		// Token: 0x04002D79 RID: 11641
		private int tagId_;
	}
}
