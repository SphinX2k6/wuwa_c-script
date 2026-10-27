using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000715 RID: 1813
	[NetMessage(EMessageId.GravityHookLockPointChangeGravityResponse)]
	public sealed class GravityHookLockPointChangeGravityResponse : IMessage<GravityHookLockPointChangeGravityResponse>, IMessage, IEquatable<GravityHookLockPointChangeGravityResponse>, IDeepCloneable<GravityHookLockPointChangeGravityResponse>, IBufferMessage
	{
		// Token: 0x0600A4D0 RID: 42192 RVA: 0x0018DB09 File Offset: 0x0018BD09
		[NullableContext(1)]
		public static GravityHookLockPointChangeGravityResponse Create()
		{
			return new GravityHookLockPointChangeGravityResponse();
		}

		// Token: 0x17002122 RID: 8482
		// (get) Token: 0x0600A4D1 RID: 42193 RVA: 0x0018DB10 File Offset: 0x0018BD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002123 RID: 8483
		// (get) Token: 0x0600A4D2 RID: 42194 RVA: 0x0018DB13 File Offset: 0x0018BD13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GravityHookLockPointChangeGravityResponse.Descriptor;
			}
		}

		// Token: 0x0600A4D3 RID: 42195 RVA: 0x0018DB1A File Offset: 0x0018BD1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityHookLockPointChangeGravityResponse()
		{
		}

		// Token: 0x0600A4D4 RID: 42196 RVA: 0x0018DB22 File Offset: 0x0018BD22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityHookLockPointChangeGravityResponse(GravityHookLockPointChangeGravityResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A4D5 RID: 42197 RVA: 0x0018DB47 File Offset: 0x0018BD47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityHookLockPointChangeGravityResponse Clone()
		{
			return new GravityHookLockPointChangeGravityResponse(this);
		}

		// Token: 0x17002124 RID: 8484
		// (get) Token: 0x0600A4D6 RID: 42198 RVA: 0x0018DB4F File Offset: 0x0018BD4F
		// (set) Token: 0x0600A4D7 RID: 42199 RVA: 0x0018DB57 File Offset: 0x0018BD57
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

		// Token: 0x0600A4D8 RID: 42200 RVA: 0x0018DB60 File Offset: 0x0018BD60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GravityHookLockPointChangeGravityResponse);
		}

		// Token: 0x0600A4D9 RID: 42201 RVA: 0x0018DB6E File Offset: 0x0018BD6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GravityHookLockPointChangeGravityResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A4DA RID: 42202 RVA: 0x0018DB9C File Offset: 0x0018BD9C
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

		// Token: 0x0600A4DB RID: 42203 RVA: 0x0018DBE1 File Offset: 0x0018BDE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A4DC RID: 42204 RVA: 0x0018DBEE File Offset: 0x0018BDEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A4DD RID: 42205 RVA: 0x0018DBF7 File Offset: 0x0018BDF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A4DE RID: 42206 RVA: 0x0018DC2C File Offset: 0x0018BE2C
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

		// Token: 0x0600A4DF RID: 42207 RVA: 0x0018DC6A File Offset: 0x0018BE6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GravityHookLockPointChangeGravityResponse other)
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

		// Token: 0x0600A4E0 RID: 42208 RVA: 0x0018DC9B File Offset: 0x0018BE9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A4E1 RID: 42209 RVA: 0x0018DCA4 File Offset: 0x0018BEA4
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004BE1 RID: 19425
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BE2 RID: 19426
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04004BE3 RID: 19427
		private ErrorCode errorCode_;
	}
}
