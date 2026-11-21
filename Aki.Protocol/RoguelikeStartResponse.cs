using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FAC RID: 4012
	[NetMessage(EMessageId.RoguelikeStartResponse)]
	public sealed class RoguelikeStartResponse : IMessage<RoguelikeStartResponse>, IMessage, IEquatable<RoguelikeStartResponse>, IDeepCloneable<RoguelikeStartResponse>, IBufferMessage
	{
		// Token: 0x060157B0 RID: 87984 RVA: 0x0031EE2E File Offset: 0x0031D02E
		[NullableContext(1)]
		public static RoguelikeStartResponse Create()
		{
			return new RoguelikeStartResponse();
		}

		// Token: 0x170047A5 RID: 18341
		// (get) Token: 0x060157B1 RID: 87985 RVA: 0x0031EE35 File Offset: 0x0031D035
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047A6 RID: 18342
		// (get) Token: 0x060157B2 RID: 87986 RVA: 0x0031EE38 File Offset: 0x0031D038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeStartResponse.Descriptor;
			}
		}

		// Token: 0x060157B3 RID: 87987 RVA: 0x0031EE3F File Offset: 0x0031D03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeStartResponse()
		{
		}

		// Token: 0x060157B4 RID: 87988 RVA: 0x0031EE47 File Offset: 0x0031D047
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeStartResponse(RoguelikeStartResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060157B5 RID: 87989 RVA: 0x0031EE6C File Offset: 0x0031D06C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeStartResponse Clone()
		{
			return new RoguelikeStartResponse(this);
		}

		// Token: 0x170047A7 RID: 18343
		// (get) Token: 0x060157B6 RID: 87990 RVA: 0x0031EE74 File Offset: 0x0031D074
		// (set) Token: 0x060157B7 RID: 87991 RVA: 0x0031EE7C File Offset: 0x0031D07C
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

		// Token: 0x060157B8 RID: 87992 RVA: 0x0031EE85 File Offset: 0x0031D085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeStartResponse);
		}

		// Token: 0x060157B9 RID: 87993 RVA: 0x0031EE93 File Offset: 0x0031D093
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeStartResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060157BA RID: 87994 RVA: 0x0031EEC4 File Offset: 0x0031D0C4
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

		// Token: 0x060157BB RID: 87995 RVA: 0x0031EF09 File Offset: 0x0031D109
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060157BC RID: 87996 RVA: 0x0031EF16 File Offset: 0x0031D116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060157BD RID: 87997 RVA: 0x0031EF1F File Offset: 0x0031D11F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060157BE RID: 87998 RVA: 0x0031EF54 File Offset: 0x0031D154
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

		// Token: 0x060157BF RID: 87999 RVA: 0x0031EF92 File Offset: 0x0031D192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeStartResponse other)
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

		// Token: 0x060157C0 RID: 88000 RVA: 0x0031EFC3 File Offset: 0x0031D1C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060157C1 RID: 88001 RVA: 0x0031EFCC File Offset: 0x0031D1CC
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
				if (num != 120U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04008197 RID: 33175
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008198 RID: 33176
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04008199 RID: 33177
		private ErrorCode errorCode_;
	}
}
