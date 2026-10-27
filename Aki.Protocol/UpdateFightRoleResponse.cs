using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001496 RID: 5270
	[NetMessage(EMessageId.UpdateFightRoleResponse)]
	public sealed class UpdateFightRoleResponse : IMessage<UpdateFightRoleResponse>, IMessage, IEquatable<UpdateFightRoleResponse>, IDeepCloneable<UpdateFightRoleResponse>, IBufferMessage
	{
		// Token: 0x0601BE11 RID: 114193 RVA: 0x00407D3B File Offset: 0x00405F3B
		[NullableContext(1)]
		public static UpdateFightRoleResponse Create()
		{
			return new UpdateFightRoleResponse();
		}

		// Token: 0x17005DF8 RID: 24056
		// (get) Token: 0x0601BE12 RID: 114194 RVA: 0x00407D42 File Offset: 0x00405F42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005DF9 RID: 24057
		// (get) Token: 0x0601BE13 RID: 114195 RVA: 0x00407D45 File Offset: 0x00405F45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateFightRoleResponse.Descriptor;
			}
		}

		// Token: 0x0601BE14 RID: 114196 RVA: 0x00407D4C File Offset: 0x00405F4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFightRoleResponse()
		{
		}

		// Token: 0x0601BE15 RID: 114197 RVA: 0x00407D54 File Offset: 0x00405F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFightRoleResponse(UpdateFightRoleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BE16 RID: 114198 RVA: 0x00407D79 File Offset: 0x00405F79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateFightRoleResponse Clone()
		{
			return new UpdateFightRoleResponse(this);
		}

		// Token: 0x17005DFA RID: 24058
		// (get) Token: 0x0601BE17 RID: 114199 RVA: 0x00407D81 File Offset: 0x00405F81
		// (set) Token: 0x0601BE18 RID: 114200 RVA: 0x00407D89 File Offset: 0x00405F89
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

		// Token: 0x0601BE19 RID: 114201 RVA: 0x00407D92 File Offset: 0x00405F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateFightRoleResponse);
		}

		// Token: 0x0601BE1A RID: 114202 RVA: 0x00407DA0 File Offset: 0x00405FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateFightRoleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BE1B RID: 114203 RVA: 0x00407DD0 File Offset: 0x00405FD0
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

		// Token: 0x0601BE1C RID: 114204 RVA: 0x00407E15 File Offset: 0x00406015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BE1D RID: 114205 RVA: 0x00407E22 File Offset: 0x00406022
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BE1E RID: 114206 RVA: 0x00407E2B File Offset: 0x0040602B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BE1F RID: 114207 RVA: 0x00407E60 File Offset: 0x00406060
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

		// Token: 0x0601BE20 RID: 114208 RVA: 0x00407E9E File Offset: 0x0040609E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateFightRoleResponse other)
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

		// Token: 0x0601BE21 RID: 114209 RVA: 0x00407ECF File Offset: 0x004060CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BE22 RID: 114210 RVA: 0x00407ED8 File Offset: 0x004060D8
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
				if (num != 24U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400A04A RID: 41034
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A04B RID: 41035
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400A04C RID: 41036
		private ErrorCode errorCode_;
	}
}
