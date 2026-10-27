using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000553 RID: 1363
	[NetMessage(EMessageId.FishingEntrustHandInResponse)]
	public sealed class FishingEntrustHandInResponse : IMessage<FishingEntrustHandInResponse>, IMessage, IEquatable<FishingEntrustHandInResponse>, IDeepCloneable<FishingEntrustHandInResponse>, IBufferMessage
	{
		// Token: 0x06007F51 RID: 32593 RVA: 0x00133FEC File Offset: 0x001321EC
		[NullableContext(1)]
		public static FishingEntrustHandInResponse Create()
		{
			return new FishingEntrustHandInResponse();
		}

		// Token: 0x170018C9 RID: 6345
		// (get) Token: 0x06007F52 RID: 32594 RVA: 0x00133FF3 File Offset: 0x001321F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170018CA RID: 6346
		// (get) Token: 0x06007F53 RID: 32595 RVA: 0x00133FF6 File Offset: 0x001321F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingEntrustHandInResponse.Descriptor;
			}
		}

		// Token: 0x06007F54 RID: 32596 RVA: 0x00133FFD File Offset: 0x001321FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustHandInResponse()
		{
		}

		// Token: 0x06007F55 RID: 32597 RVA: 0x00134005 File Offset: 0x00132205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustHandInResponse(FishingEntrustHandInResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007F56 RID: 32598 RVA: 0x0013402A File Offset: 0x0013222A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingEntrustHandInResponse Clone()
		{
			return new FishingEntrustHandInResponse(this);
		}

		// Token: 0x170018CB RID: 6347
		// (get) Token: 0x06007F57 RID: 32599 RVA: 0x00134032 File Offset: 0x00132232
		// (set) Token: 0x06007F58 RID: 32600 RVA: 0x0013403A File Offset: 0x0013223A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x06007F59 RID: 32601 RVA: 0x00134043 File Offset: 0x00132243
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingEntrustHandInResponse);
		}

		// Token: 0x06007F5A RID: 32602 RVA: 0x00134051 File Offset: 0x00132251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingEntrustHandInResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007F5B RID: 32603 RVA: 0x00134080 File Offset: 0x00132280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007F5C RID: 32604 RVA: 0x001340C5 File Offset: 0x001322C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007F5D RID: 32605 RVA: 0x001340D2 File Offset: 0x001322D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007F5E RID: 32606 RVA: 0x001340DB File Offset: 0x001322DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007F5F RID: 32607 RVA: 0x00134110 File Offset: 0x00132310
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007F60 RID: 32608 RVA: 0x0013414E File Offset: 0x0013234E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingEntrustHandInResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007F61 RID: 32609 RVA: 0x0013417F File Offset: 0x0013237F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007F62 RID: 32610 RVA: 0x00134188 File Offset: 0x00132388
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
				if (num != 56U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400405B RID: 16475
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400405C RID: 16476
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400405D RID: 16477
		private ErrorCode errorCode_;
	}
}
