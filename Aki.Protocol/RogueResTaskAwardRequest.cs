using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FFD RID: 4093
	[NetMessage(EMessageId.RogueResTaskAwardRequest)]
	public sealed class RogueResTaskAwardRequest : IMessage<RogueResTaskAwardRequest>, IMessage, IEquatable<RogueResTaskAwardRequest>, IDeepCloneable<RogueResTaskAwardRequest>, IBufferMessage
	{
		// Token: 0x06015EA8 RID: 89768 RVA: 0x00330635 File Offset: 0x0032E835
		[NullableContext(1)]
		public static RogueResTaskAwardRequest Create()
		{
			return new RogueResTaskAwardRequest();
		}

		// Token: 0x17004947 RID: 18759
		// (get) Token: 0x06015EA9 RID: 89769 RVA: 0x0033063C File Offset: 0x0032E83C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004948 RID: 18760
		// (get) Token: 0x06015EAA RID: 89770 RVA: 0x0033063F File Offset: 0x0032E83F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResTaskAwardRequest.Descriptor;
			}
		}

		// Token: 0x06015EAB RID: 89771 RVA: 0x00330646 File Offset: 0x0032E846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTaskAwardRequest()
		{
		}

		// Token: 0x06015EAC RID: 89772 RVA: 0x0033064E File Offset: 0x0032E84E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTaskAwardRequest(RogueResTaskAwardRequest other) : this()
		{
			this.configId_ = other.configId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015EAD RID: 89773 RVA: 0x00330673 File Offset: 0x0032E873
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTaskAwardRequest Clone()
		{
			return new RogueResTaskAwardRequest(this);
		}

		// Token: 0x17004949 RID: 18761
		// (get) Token: 0x06015EAE RID: 89774 RVA: 0x0033067B File Offset: 0x0032E87B
		// (set) Token: 0x06015EAF RID: 89775 RVA: 0x00330683 File Offset: 0x0032E883
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x06015EB0 RID: 89776 RVA: 0x0033068C File Offset: 0x0032E88C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResTaskAwardRequest);
		}

		// Token: 0x06015EB1 RID: 89777 RVA: 0x0033069A File Offset: 0x0032E89A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResTaskAwardRequest other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015EB2 RID: 89778 RVA: 0x003306C8 File Offset: 0x0032E8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015EB3 RID: 89779 RVA: 0x00330707 File Offset: 0x0032E907
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015EB4 RID: 89780 RVA: 0x00330714 File Offset: 0x0032E914
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015EB5 RID: 89781 RVA: 0x0033071D File Offset: 0x0032E91D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015EB6 RID: 89782 RVA: 0x00330750 File Offset: 0x0032E950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015EB7 RID: 89783 RVA: 0x0033078E File Offset: 0x0032E98E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResTaskAwardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015EB8 RID: 89784 RVA: 0x003307BF File Offset: 0x0032E9BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015EB9 RID: 89785 RVA: 0x003307C8 File Offset: 0x0032E9C8
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008400 RID: 33792
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008401 RID: 33793
		public const int ConfigIdFieldNumber = 10;

		// Token: 0x04008402 RID: 33794
		private int configId_;
	}
}
