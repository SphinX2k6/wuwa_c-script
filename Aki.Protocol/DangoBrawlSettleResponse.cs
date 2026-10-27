using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200036C RID: 876
	[NetMessage(EMessageId.DangoBrawlSettleResponse)]
	public sealed class DangoBrawlSettleResponse : IMessage<DangoBrawlSettleResponse>, IMessage, IEquatable<DangoBrawlSettleResponse>, IDeepCloneable<DangoBrawlSettleResponse>, IBufferMessage
	{
		// Token: 0x06005736 RID: 22326 RVA: 0x000D50A2 File Offset: 0x000D32A2
		[NullableContext(1)]
		public static DangoBrawlSettleResponse Create()
		{
			return new DangoBrawlSettleResponse();
		}

		// Token: 0x17001009 RID: 4105
		// (get) Token: 0x06005737 RID: 22327 RVA: 0x000D50A9 File Offset: 0x000D32A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x06005738 RID: 22328 RVA: 0x000D50AC File Offset: 0x000D32AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlSettleResponse.Descriptor;
			}
		}

		// Token: 0x06005739 RID: 22329 RVA: 0x000D50B3 File Offset: 0x000D32B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSettleResponse()
		{
		}

		// Token: 0x0600573A RID: 22330 RVA: 0x000D50BB File Offset: 0x000D32BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSettleResponse(DangoBrawlSettleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600573B RID: 22331 RVA: 0x000D50E0 File Offset: 0x000D32E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlSettleResponse Clone()
		{
			return new DangoBrawlSettleResponse(this);
		}

		// Token: 0x1700100B RID: 4107
		// (get) Token: 0x0600573C RID: 22332 RVA: 0x000D50E8 File Offset: 0x000D32E8
		// (set) Token: 0x0600573D RID: 22333 RVA: 0x000D50F0 File Offset: 0x000D32F0
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

		// Token: 0x0600573E RID: 22334 RVA: 0x000D50F9 File Offset: 0x000D32F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlSettleResponse);
		}

		// Token: 0x0600573F RID: 22335 RVA: 0x000D5107 File Offset: 0x000D3307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlSettleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005740 RID: 22336 RVA: 0x000D5138 File Offset: 0x000D3338
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

		// Token: 0x06005741 RID: 22337 RVA: 0x000D517D File Offset: 0x000D337D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005742 RID: 22338 RVA: 0x000D518A File Offset: 0x000D338A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005743 RID: 22339 RVA: 0x000D5193 File Offset: 0x000D3393
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005744 RID: 22340 RVA: 0x000D51C8 File Offset: 0x000D33C8
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

		// Token: 0x06005745 RID: 22341 RVA: 0x000D5206 File Offset: 0x000D3406
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlSettleResponse other)
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

		// Token: 0x06005746 RID: 22342 RVA: 0x000D5237 File Offset: 0x000D3437
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005747 RID: 22343 RVA: 0x000D5240 File Offset: 0x000D3440
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040034C0 RID: 13504
		private UnknownFieldSet _unknownFields;

		// Token: 0x040034C1 RID: 13505
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x040034C2 RID: 13506
		private ErrorCode errorCode_;
	}
}
