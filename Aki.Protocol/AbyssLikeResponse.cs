using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200002A RID: 42
	[NetMessage(EMessageId.AbyssLikeResponse)]
	public sealed class AbyssLikeResponse : IMessage<AbyssLikeResponse>, IMessage, IEquatable<AbyssLikeResponse>, IDeepCloneable<AbyssLikeResponse>, IBufferMessage
	{
		// Token: 0x06001208 RID: 4616 RVA: 0x00031F05 File Offset: 0x00030105
		[NullableContext(1)]
		public static AbyssLikeResponse Create()
		{
			return new AbyssLikeResponse();
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x00031F0C File Offset: 0x0003010C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600120A RID: 4618 RVA: 0x00031F0F File Offset: 0x0003010F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssLikeResponse.Descriptor;
			}
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x00031F16 File Offset: 0x00030116
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeResponse()
		{
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x00031F1E File Offset: 0x0003011E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeResponse(AbyssLikeResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x00031F43 File Offset: 0x00030143
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssLikeResponse Clone()
		{
			return new AbyssLikeResponse(this);
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600120E RID: 4622 RVA: 0x00031F4B File Offset: 0x0003014B
		// (set) Token: 0x0600120F RID: 4623 RVA: 0x00031F53 File Offset: 0x00030153
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

		// Token: 0x06001210 RID: 4624 RVA: 0x00031F5C File Offset: 0x0003015C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssLikeResponse);
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x00031F6A File Offset: 0x0003016A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssLikeResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x00031F98 File Offset: 0x00030198
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

		// Token: 0x06001213 RID: 4627 RVA: 0x00031FDD File Offset: 0x000301DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x00031FEA File Offset: 0x000301EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x00031FF3 File Offset: 0x000301F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x00032028 File Offset: 0x00030228
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

		// Token: 0x06001217 RID: 4631 RVA: 0x00032066 File Offset: 0x00030266
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssLikeResponse other)
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

		// Token: 0x06001218 RID: 4632 RVA: 0x00032097 File Offset: 0x00030297
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001219 RID: 4633 RVA: 0x000320A0 File Offset: 0x000302A0
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
				if (num != 40U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04001FFA RID: 8186
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FFB RID: 8187
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04001FFC RID: 8188
		private ErrorCode errorCode_;
	}
}
