using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FAF RID: 4015
	[NetMessage(EMessageId.RoguelikeResultRequest)]
	public sealed class RoguelikeResultRequest : IMessage<RoguelikeResultRequest>, IMessage, IEquatable<RoguelikeResultRequest>, IDeepCloneable<RoguelikeResultRequest>, IBufferMessage
	{
		// Token: 0x0601578D RID: 87949 RVA: 0x0031E100 File Offset: 0x0031C300
		[NullableContext(1)]
		public static RoguelikeResultRequest Create()
		{
			return new RoguelikeResultRequest();
		}

		// Token: 0x17004799 RID: 18329
		// (get) Token: 0x0601578E RID: 87950 RVA: 0x0031E107 File Offset: 0x0031C307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700479A RID: 18330
		// (get) Token: 0x0601578F RID: 87951 RVA: 0x0031E10A File Offset: 0x0031C30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeResultRequest.Descriptor;
			}
		}

		// Token: 0x06015790 RID: 87952 RVA: 0x0031E111 File Offset: 0x0031C311
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultRequest()
		{
		}

		// Token: 0x06015791 RID: 87953 RVA: 0x0031E119 File Offset: 0x0031C319
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultRequest(RoguelikeResultRequest other) : this()
		{
			this.instId_ = other.instId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015792 RID: 87954 RVA: 0x0031E13E File Offset: 0x0031C33E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeResultRequest Clone()
		{
			return new RoguelikeResultRequest(this);
		}

		// Token: 0x1700479B RID: 18331
		// (get) Token: 0x06015793 RID: 87955 RVA: 0x0031E146 File Offset: 0x0031C346
		// (set) Token: 0x06015794 RID: 87956 RVA: 0x0031E14E File Offset: 0x0031C34E
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

		// Token: 0x06015795 RID: 87957 RVA: 0x0031E157 File Offset: 0x0031C357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeResultRequest);
		}

		// Token: 0x06015796 RID: 87958 RVA: 0x0031E165 File Offset: 0x0031C365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeResultRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015797 RID: 87959 RVA: 0x0031E194 File Offset: 0x0031C394
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

		// Token: 0x06015798 RID: 87960 RVA: 0x0031E1D3 File Offset: 0x0031C3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015799 RID: 87961 RVA: 0x0031E1E0 File Offset: 0x0031C3E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601579A RID: 87962 RVA: 0x0031E1E9 File Offset: 0x0031C3E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.InstId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601579B RID: 87963 RVA: 0x0031E21C File Offset: 0x0031C41C
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

		// Token: 0x0601579C RID: 87964 RVA: 0x0031E25A File Offset: 0x0031C45A
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

		// Token: 0x0601579D RID: 87965 RVA: 0x0031E28B File Offset: 0x0031C48B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601579E RID: 87966 RVA: 0x0031E294 File Offset: 0x0031C494
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
				if (num != 96U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.InstId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008124 RID: 33060
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008125 RID: 33061
		public const int InstIdFieldNumber = 12;

		// Token: 0x04008126 RID: 33062
		private int instId_;
	}
}
