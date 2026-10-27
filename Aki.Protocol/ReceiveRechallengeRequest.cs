using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ECF RID: 3791
	[NetMessage(EMessageId.ReceiveRechallengeRequest)]
	public sealed class ReceiveRechallengeRequest : IMessage<ReceiveRechallengeRequest>, IMessage, IEquatable<ReceiveRechallengeRequest>, IDeepCloneable<ReceiveRechallengeRequest>, IBufferMessage
	{
		// Token: 0x06014524 RID: 83236 RVA: 0x002F3EE9 File Offset: 0x002F20E9
		[NullableContext(1)]
		public static ReceiveRechallengeRequest Create()
		{
			return new ReceiveRechallengeRequest();
		}

		// Token: 0x1700438B RID: 17291
		// (get) Token: 0x06014525 RID: 83237 RVA: 0x002F3EF0 File Offset: 0x002F20F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700438C RID: 17292
		// (get) Token: 0x06014526 RID: 83238 RVA: 0x002F3EF3 File Offset: 0x002F20F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ReceiveRechallengeRequest.Descriptor;
			}
		}

		// Token: 0x06014527 RID: 83239 RVA: 0x002F3EFA File Offset: 0x002F20FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengeRequest()
		{
		}

		// Token: 0x06014528 RID: 83240 RVA: 0x002F3F02 File Offset: 0x002F2102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengeRequest(ReceiveRechallengeRequest other) : this()
		{
			this.result_ = other.result_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014529 RID: 83241 RVA: 0x002F3F27 File Offset: 0x002F2127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ReceiveRechallengeRequest Clone()
		{
			return new ReceiveRechallengeRequest(this);
		}

		// Token: 0x1700438D RID: 17293
		// (get) Token: 0x0601452A RID: 83242 RVA: 0x002F3F2F File Offset: 0x002F212F
		// (set) Token: 0x0601452B RID: 83243 RVA: 0x002F3F37 File Offset: 0x002F2137
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

		// Token: 0x0601452C RID: 83244 RVA: 0x002F3F40 File Offset: 0x002F2140
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ReceiveRechallengeRequest);
		}

		// Token: 0x0601452D RID: 83245 RVA: 0x002F3F4E File Offset: 0x002F214E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ReceiveRechallengeRequest other)
		{
			return other != null && (other == this || (this.Result == other.Result && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601452E RID: 83246 RVA: 0x002F3F7C File Offset: 0x002F217C
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

		// Token: 0x0601452F RID: 83247 RVA: 0x002F3FC1 File Offset: 0x002F21C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014530 RID: 83248 RVA: 0x002F3FCE File Offset: 0x002F21CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014531 RID: 83249 RVA: 0x002F3FD7 File Offset: 0x002F21D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Result != ERechallengeResultResult.Accept)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.Result);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014532 RID: 83250 RVA: 0x002F400C File Offset: 0x002F220C
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

		// Token: 0x06014533 RID: 83251 RVA: 0x002F404A File Offset: 0x002F224A
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

		// Token: 0x06014534 RID: 83252 RVA: 0x002F407B File Offset: 0x002F227B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014535 RID: 83253 RVA: 0x002F4084 File Offset: 0x002F2284
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
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Result = (ERechallengeResultResult)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007B67 RID: 31591
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007B68 RID: 31592
		public const int ResultFieldNumber = 14;

		// Token: 0x04007B69 RID: 31593
		private ERechallengeResultResult result_;
	}
}
