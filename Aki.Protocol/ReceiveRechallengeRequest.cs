using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EBF RID: 3775
	[NetMessage(EMessageId.ReceiveRechallengeRequest)]
	public sealed class ReceiveRechallengeRequest : IMessage<ReceiveRechallengeRequest>, IMessage, IEquatable<ReceiveRechallengeRequest>, IDeepCloneable<ReceiveRechallengeRequest>, IBufferMessage
	{
		// Token: 0x0601443F RID: 83007 RVA: 0x002F2834 File Offset: 0x002F0A34
		[NullableContext(1)]
		public static ReceiveRechallengeRequest Create()
		{
			return new ReceiveRechallengeRequest();
		}

		// Token: 0x17004361 RID: 17249
		// (get) Token: 0x06014440 RID: 83008 RVA: 0x002F283B File Offset: 0x002F0A3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004362 RID: 17250
		// (get) Token: 0x06014441 RID: 83009 RVA: 0x002F283E File Offset: 0x002F0A3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReceiveRechallengeRequest.Descriptor;
			}
		}

		// Token: 0x06014442 RID: 83010 RVA: 0x002F2845 File Offset: 0x002F0A45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengeRequest()
		{
		}

		// Token: 0x06014443 RID: 83011 RVA: 0x002F284D File Offset: 0x002F0A4D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengeRequest(ReceiveRechallengeRequest other) : this()
		{
			this.result_ = other.result_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014444 RID: 83012 RVA: 0x002F2872 File Offset: 0x002F0A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengeRequest Clone()
		{
			return new ReceiveRechallengeRequest(this);
		}

		// Token: 0x17004363 RID: 17251
		// (get) Token: 0x06014445 RID: 83013 RVA: 0x002F287A File Offset: 0x002F0A7A
		// (set) Token: 0x06014446 RID: 83014 RVA: 0x002F2882 File Offset: 0x002F0A82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ERechallengeResultResult Result
		{
			get
			{
				return this.result_;
			}
			set
			{
				this.result_ = value;
			}
		}

		// Token: 0x06014447 RID: 83015 RVA: 0x002F288B File Offset: 0x002F0A8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReceiveRechallengeRequest);
		}

		// Token: 0x06014448 RID: 83016 RVA: 0x002F2899 File Offset: 0x002F0A99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReceiveRechallengeRequest other)
		{
			return other != null && (other == this || (this.Result == other.Result && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014449 RID: 83017 RVA: 0x002F28C8 File Offset: 0x002F0AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Result != ERechallengeResultResult.Accept)
			{
				num ^= this.Result.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601444A RID: 83018 RVA: 0x002F290D File Offset: 0x002F0B0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601444B RID: 83019 RVA: 0x002F291A File Offset: 0x002F0B1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601444C RID: 83020 RVA: 0x002F2923 File Offset: 0x002F0B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Result != ERechallengeResultResult.Accept)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.Result);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601444D RID: 83021 RVA: 0x002F2958 File Offset: 0x002F0B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Result != ERechallengeResultResult.Accept)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Result);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601444E RID: 83022 RVA: 0x002F2996 File Offset: 0x002F0B96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ReceiveRechallengeRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Result != ERechallengeResultResult.Accept)
			{
				this.Result = other.Result;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601444F RID: 83023 RVA: 0x002F29C7 File Offset: 0x002F0BC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014450 RID: 83024 RVA: 0x002F29D0 File Offset: 0x002F0BD0
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Result = (ERechallengeResultResult)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007B91 RID: 31633
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B92 RID: 31634
		public const int ResultFieldNumber = 5;

		// Token: 0x04007B93 RID: 31635
		private ERechallengeResultResult result_;
	}
}
