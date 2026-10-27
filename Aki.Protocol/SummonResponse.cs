using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012B5 RID: 4789
	[NetMessage(EMessageId.SummonResponse)]
	public sealed class SummonResponse : IMessage<SummonResponse>, IMessage, IEquatable<SummonResponse>, IDeepCloneable<SummonResponse>, IBufferMessage
	{
		// Token: 0x060197BE RID: 104382 RVA: 0x003B42C9 File Offset: 0x003B24C9
		[NullableContext(1)]
		public static SummonResponse Create()
		{
			return new SummonResponse();
		}

		// Token: 0x170055F0 RID: 22000
		// (get) Token: 0x060197BF RID: 104383 RVA: 0x003B42D0 File Offset: 0x003B24D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170055F1 RID: 22001
		// (get) Token: 0x060197C0 RID: 104384 RVA: 0x003B42D3 File Offset: 0x003B24D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SummonResponse.Descriptor;
			}
		}

		// Token: 0x060197C1 RID: 104385 RVA: 0x003B42DA File Offset: 0x003B24DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonResponse()
		{
		}

		// Token: 0x060197C2 RID: 104386 RVA: 0x003B42E2 File Offset: 0x003B24E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonResponse(SummonResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060197C3 RID: 104387 RVA: 0x003B4307 File Offset: 0x003B2507
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SummonResponse Clone()
		{
			return new SummonResponse(this);
		}

		// Token: 0x170055F2 RID: 22002
		// (get) Token: 0x060197C4 RID: 104388 RVA: 0x003B430F File Offset: 0x003B250F
		// (set) Token: 0x060197C5 RID: 104389 RVA: 0x003B4317 File Offset: 0x003B2517
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

		// Token: 0x060197C6 RID: 104390 RVA: 0x003B4320 File Offset: 0x003B2520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SummonResponse);
		}

		// Token: 0x060197C7 RID: 104391 RVA: 0x003B432E File Offset: 0x003B252E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SummonResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060197C8 RID: 104392 RVA: 0x003B435C File Offset: 0x003B255C
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

		// Token: 0x060197C9 RID: 104393 RVA: 0x003B43A1 File Offset: 0x003B25A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060197CA RID: 104394 RVA: 0x003B43AE File Offset: 0x003B25AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060197CB RID: 104395 RVA: 0x003B43B7 File Offset: 0x003B25B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060197CC RID: 104396 RVA: 0x003B43EC File Offset: 0x003B25EC
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

		// Token: 0x060197CD RID: 104397 RVA: 0x003B442A File Offset: 0x003B262A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SummonResponse other)
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

		// Token: 0x060197CE RID: 104398 RVA: 0x003B445B File Offset: 0x003B265B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060197CF RID: 104399 RVA: 0x003B4464 File Offset: 0x003B2664
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009588 RID: 38280
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009589 RID: 38281
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x0400958A RID: 38282
		private ErrorCode errorCode_;
	}
}
