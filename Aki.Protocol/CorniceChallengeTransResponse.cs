using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200030B RID: 779
	[NetMessage(EMessageId.CorniceChallengeTransResponse)]
	public sealed class CorniceChallengeTransResponse : IMessage<CorniceChallengeTransResponse>, IMessage, IEquatable<CorniceChallengeTransResponse>, IDeepCloneable<CorniceChallengeTransResponse>, IBufferMessage
	{
		// Token: 0x06004ECC RID: 20172 RVA: 0x000BFAA9 File Offset: 0x000BDCA9
		[NullableContext(1)]
		public static CorniceChallengeTransResponse Create()
		{
			return new CorniceChallengeTransResponse();
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06004ECD RID: 20173 RVA: 0x000BFAB0 File Offset: 0x000BDCB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06004ECE RID: 20174 RVA: 0x000BFAB3 File Offset: 0x000BDCB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CorniceChallengeTransResponse.Descriptor;
			}
		}

		// Token: 0x06004ECF RID: 20175 RVA: 0x000BFABA File Offset: 0x000BDCBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceChallengeTransResponse()
		{
		}

		// Token: 0x06004ED0 RID: 20176 RVA: 0x000BFAC2 File Offset: 0x000BDCC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceChallengeTransResponse(CorniceChallengeTransResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004ED1 RID: 20177 RVA: 0x000BFAE7 File Offset: 0x000BDCE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CorniceChallengeTransResponse Clone()
		{
			return new CorniceChallengeTransResponse(this);
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x06004ED2 RID: 20178 RVA: 0x000BFAEF File Offset: 0x000BDCEF
		// (set) Token: 0x06004ED3 RID: 20179 RVA: 0x000BFAF7 File Offset: 0x000BDCF7
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

		// Token: 0x06004ED4 RID: 20180 RVA: 0x000BFB00 File Offset: 0x000BDD00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CorniceChallengeTransResponse);
		}

		// Token: 0x06004ED5 RID: 20181 RVA: 0x000BFB0E File Offset: 0x000BDD0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CorniceChallengeTransResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004ED6 RID: 20182 RVA: 0x000BFB3C File Offset: 0x000BDD3C
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

		// Token: 0x06004ED7 RID: 20183 RVA: 0x000BFB81 File Offset: 0x000BDD81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004ED8 RID: 20184 RVA: 0x000BFB8E File Offset: 0x000BDD8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004ED9 RID: 20185 RVA: 0x000BFB97 File Offset: 0x000BDD97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004EDA RID: 20186 RVA: 0x000BFBCC File Offset: 0x000BDDCC
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

		// Token: 0x06004EDB RID: 20187 RVA: 0x000BFC0A File Offset: 0x000BDE0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CorniceChallengeTransResponse other)
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

		// Token: 0x06004EDC RID: 20188 RVA: 0x000BFC3B File Offset: 0x000BDE3B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004EDD RID: 20189 RVA: 0x000BFC44 File Offset: 0x000BDE44
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
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003209 RID: 12809
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400320A RID: 12810
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x0400320B RID: 12811
		private ErrorCode errorCode_;
	}
}
