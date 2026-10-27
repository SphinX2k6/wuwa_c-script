using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020001E8 RID: 488
	[NetMessage(EMessageId.BtForcedOccupationResponse)]
	public sealed class BtForcedOccupationResponse : IMessage<BtForcedOccupationResponse>, IMessage, IEquatable<BtForcedOccupationResponse>, IDeepCloneable<BtForcedOccupationResponse>, IBufferMessage
	{
		// Token: 0x060036B7 RID: 14007 RVA: 0x00089194 File Offset: 0x00087394
		[NullableContext(1)]
		public static BtForcedOccupationResponse Create()
		{
			return new BtForcedOccupationResponse();
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x060036B8 RID: 14008 RVA: 0x0008919B File Offset: 0x0008739B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x060036B9 RID: 14009 RVA: 0x0008919E File Offset: 0x0008739E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BtForcedOccupationResponse.Descriptor;
			}
		}

		// Token: 0x060036BA RID: 14010 RVA: 0x000891A5 File Offset: 0x000873A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtForcedOccupationResponse()
		{
		}

		// Token: 0x060036BB RID: 14011 RVA: 0x000891AD File Offset: 0x000873AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtForcedOccupationResponse(BtForcedOccupationResponse other) : this()
		{
			this.errorId_ = other.errorId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060036BC RID: 14012 RVA: 0x000891D2 File Offset: 0x000873D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BtForcedOccupationResponse Clone()
		{
			return new BtForcedOccupationResponse(this);
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x060036BD RID: 14013 RVA: 0x000891DA File Offset: 0x000873DA
		// (set) Token: 0x060036BE RID: 14014 RVA: 0x000891E2 File Offset: 0x000873E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorId
		{
			get
			{
				return this.errorId_;
			}
			set
			{
				this.errorId_ = value;
			}
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x000891EB File Offset: 0x000873EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BtForcedOccupationResponse);
		}

		// Token: 0x060036C0 RID: 14016 RVA: 0x000891F9 File Offset: 0x000873F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BtForcedOccupationResponse other)
		{
			return other != null && (other == this || (this.ErrorId == other.ErrorId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060036C1 RID: 14017 RVA: 0x00089228 File Offset: 0x00087428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorId != ErrorCode.Success)
			{
				num ^= this.ErrorId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060036C2 RID: 14018 RVA: 0x0008926D File Offset: 0x0008746D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060036C3 RID: 14019 RVA: 0x0008927A File Offset: 0x0008747A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060036C4 RID: 14020 RVA: 0x00089283 File Offset: 0x00087483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorId != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x000892B8 File Offset: 0x000874B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorId != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060036C6 RID: 14022 RVA: 0x000892F6 File Offset: 0x000874F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BtForcedOccupationResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorId != ErrorCode.Success)
			{
				this.ErrorId = other.ErrorId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060036C7 RID: 14023 RVA: 0x00089327 File Offset: 0x00087527
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060036C8 RID: 14024 RVA: 0x00089330 File Offset: 0x00087530
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorId = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002AB0 RID: 10928
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002AB1 RID: 10929
		public const int ErrorIdFieldNumber = 11;

		// Token: 0x04002AB2 RID: 10930
		private ErrorCode errorId_;
	}
}
