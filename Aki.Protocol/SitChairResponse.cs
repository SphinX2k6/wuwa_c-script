using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001270 RID: 4720
	[NetMessage(EMessageId.SitChairResponse)]
	public sealed class SitChairResponse : IMessage<SitChairResponse>, IMessage, IEquatable<SitChairResponse>, IDeepCloneable<SitChairResponse>, IBufferMessage
	{
		// Token: 0x06019332 RID: 103218 RVA: 0x003ACFB5 File Offset: 0x003AB1B5
		[NullableContext(1)]
		public static SitChairResponse Create()
		{
			return new SitChairResponse();
		}

		// Token: 0x17005535 RID: 21813
		// (get) Token: 0x06019333 RID: 103219 RVA: 0x003ACFBC File Offset: 0x003AB1BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005536 RID: 21814
		// (get) Token: 0x06019334 RID: 103220 RVA: 0x003ACFBF File Offset: 0x003AB1BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SitChairResponse.Descriptor;
			}
		}

		// Token: 0x06019335 RID: 103221 RVA: 0x003ACFC6 File Offset: 0x003AB1C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SitChairResponse()
		{
		}

		// Token: 0x06019336 RID: 103222 RVA: 0x003ACFCE File Offset: 0x003AB1CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SitChairResponse(SitChairResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019337 RID: 103223 RVA: 0x003ACFF3 File Offset: 0x003AB1F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SitChairResponse Clone()
		{
			return new SitChairResponse(this);
		}

		// Token: 0x17005537 RID: 21815
		// (get) Token: 0x06019338 RID: 103224 RVA: 0x003ACFFB File Offset: 0x003AB1FB
		// (set) Token: 0x06019339 RID: 103225 RVA: 0x003AD003 File Offset: 0x003AB203
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

		// Token: 0x0601933A RID: 103226 RVA: 0x003AD00C File Offset: 0x003AB20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SitChairResponse);
		}

		// Token: 0x0601933B RID: 103227 RVA: 0x003AD01A File Offset: 0x003AB21A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SitChairResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601933C RID: 103228 RVA: 0x003AD048 File Offset: 0x003AB248
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

		// Token: 0x0601933D RID: 103229 RVA: 0x003AD08D File Offset: 0x003AB28D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601933E RID: 103230 RVA: 0x003AD09A File Offset: 0x003AB29A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601933F RID: 103231 RVA: 0x003AD0A3 File Offset: 0x003AB2A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019340 RID: 103232 RVA: 0x003AD0D4 File Offset: 0x003AB2D4
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

		// Token: 0x06019341 RID: 103233 RVA: 0x003AD112 File Offset: 0x003AB312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SitChairResponse other)
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

		// Token: 0x06019342 RID: 103234 RVA: 0x003AD143 File Offset: 0x003AB343
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019343 RID: 103235 RVA: 0x003AD14C File Offset: 0x003AB34C
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
				if (num != 8U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400952E RID: 38190
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400952F RID: 38191
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x04009530 RID: 38192
		private ErrorCode errorCode_;
	}
}
