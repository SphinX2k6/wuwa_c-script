using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F9F RID: 3999
	[NetMessage(EMessageId.RoguelikeResultRequest)]
	public sealed class RoguelikeResultRequest : IMessage<RoguelikeResultRequest>, IMessage, IEquatable<RoguelikeResultRequest>, IDeepCloneable<RoguelikeResultRequest>, IBufferMessage
	{
		// Token: 0x060156A8 RID: 87720 RVA: 0x0031CA54 File Offset: 0x0031AC54
		[NullableContext(1)]
		public static RoguelikeResultRequest Create()
		{
			return new RoguelikeResultRequest();
		}

		// Token: 0x1700476F RID: 18287
		// (get) Token: 0x060156A9 RID: 87721 RVA: 0x0031CA5B File Offset: 0x0031AC5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004770 RID: 18288
		// (get) Token: 0x060156AA RID: 87722 RVA: 0x0031CA5E File Offset: 0x0031AC5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeResultRequest.Descriptor;
			}
		}

		// Token: 0x060156AB RID: 87723 RVA: 0x0031CA65 File Offset: 0x0031AC65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultRequest()
		{
		}

		// Token: 0x060156AC RID: 87724 RVA: 0x0031CA6D File Offset: 0x0031AC6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultRequest(RoguelikeResultRequest other) : this()
		{
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060156AD RID: 87725 RVA: 0x0031CA92 File Offset: 0x0031AC92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultRequest Clone()
		{
			return new RoguelikeResultRequest(this);
		}

		// Token: 0x17004771 RID: 18289
		// (get) Token: 0x060156AE RID: 87726 RVA: 0x0031CA9A File Offset: 0x0031AC9A
		// (set) Token: 0x060156AF RID: 87727 RVA: 0x0031CAA2 File Offset: 0x0031ACA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x060156B0 RID: 87728 RVA: 0x0031CAAB File Offset: 0x0031ACAB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeResultRequest);
		}

		// Token: 0x060156B1 RID: 87729 RVA: 0x0031CAB9 File Offset: 0x0031ACB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeResultRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060156B2 RID: 87730 RVA: 0x0031CAE8 File Offset: 0x0031ACE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060156B3 RID: 87731 RVA: 0x0031CB27 File Offset: 0x0031AD27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060156B4 RID: 87732 RVA: 0x0031CB34 File Offset: 0x0031AD34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060156B5 RID: 87733 RVA: 0x0031CB3D File Offset: 0x0031AD3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060156B6 RID: 87734 RVA: 0x0031CB70 File Offset: 0x0031AD70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060156B7 RID: 87735 RVA: 0x0031CBAE File Offset: 0x0031ADAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeResultRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060156B8 RID: 87736 RVA: 0x0031CBDF File Offset: 0x0031ADDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060156B9 RID: 87737 RVA: 0x0031CBE8 File Offset: 0x0031ADE8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400814E RID: 33102
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400814F RID: 33103
		public const int InstIdFieldNumber = 9;

		// Token: 0x04008150 RID: 33104
		private int instId_;
	}
}
