using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020000CA RID: 202
	[NetMessage(EMessageId.AdviceDeleteRequest)]
	public sealed class AdviceDeleteRequest : IMessage<AdviceDeleteRequest>, IMessage, IEquatable<AdviceDeleteRequest>, IDeepCloneable<AdviceDeleteRequest>, IBufferMessage
	{
		// Token: 0x06001FC6 RID: 8134 RVA: 0x0005679F File Offset: 0x0005499F
		[NullableContext(1)]
		public static AdviceDeleteRequest Create()
		{
			return new AdviceDeleteRequest();
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001FC7 RID: 8135 RVA: 0x000567A6 File Offset: 0x000549A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170003D3 RID: 979
		// (get) Token: 0x06001FC8 RID: 8136 RVA: 0x000567A9 File Offset: 0x000549A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AdviceDeleteRequest.Descriptor;
			}
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x000567B0 File Offset: 0x000549B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceDeleteRequest()
		{
		}

		// Token: 0x06001FCA RID: 8138 RVA: 0x000567B8 File Offset: 0x000549B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceDeleteRequest(AdviceDeleteRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001FCB RID: 8139 RVA: 0x000567DD File Offset: 0x000549DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AdviceDeleteRequest Clone()
		{
			return new AdviceDeleteRequest(this);
		}

		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001FCC RID: 8140 RVA: 0x000567E5 File Offset: 0x000549E5
		// (set) Token: 0x06001FCD RID: 8141 RVA: 0x000567ED File Offset: 0x000549ED
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

		// Token: 0x06001FCE RID: 8142 RVA: 0x000567F6 File Offset: 0x000549F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AdviceDeleteRequest);
		}

		// Token: 0x06001FCF RID: 8143 RVA: 0x00056804 File Offset: 0x00054A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AdviceDeleteRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001FD0 RID: 8144 RVA: 0x00056834 File Offset: 0x00054A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x00056873 File Offset: 0x00054A73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x00056880 File Offset: 0x00054A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x00056889 File Offset: 0x00054A89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001FD4 RID: 8148 RVA: 0x000568BC File Offset: 0x00054ABC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001FD5 RID: 8149 RVA: 0x000568FA File Offset: 0x00054AFA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AdviceDeleteRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001FD6 RID: 8150 RVA: 0x0005692B File Offset: 0x00054B2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001FD7 RID: 8151 RVA: 0x00056934 File Offset: 0x00054B34
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04002423 RID: 9251
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002424 RID: 9252
		public const int IdFieldNumber = 4;

		// Token: 0x04002425 RID: 9253
		private long id_;
	}
}
