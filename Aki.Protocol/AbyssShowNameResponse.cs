using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200004B RID: 75
	[NetMessage(EMessageId.AbyssShowNameResponse)]
	public sealed class AbyssShowNameResponse : IMessage<AbyssShowNameResponse>, IMessage, IEquatable<AbyssShowNameResponse>, IDeepCloneable<AbyssShowNameResponse>, IBufferMessage
	{
		// Token: 0x06001468 RID: 5224 RVA: 0x00036A48 File Offset: 0x00034C48
		[NullableContext(1)]
		public static AbyssShowNameResponse Create()
		{
			return new AbyssShowNameResponse();
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06001469 RID: 5225 RVA: 0x00036A4F File Offset: 0x00034C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600146A RID: 5226 RVA: 0x00036A52 File Offset: 0x00034C52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssShowNameResponse.Descriptor;
			}
		}

		// Token: 0x0600146B RID: 5227 RVA: 0x00036A59 File Offset: 0x00034C59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssShowNameResponse()
		{
		}

		// Token: 0x0600146C RID: 5228 RVA: 0x00036A61 File Offset: 0x00034C61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssShowNameResponse(AbyssShowNameResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600146D RID: 5229 RVA: 0x00036A86 File Offset: 0x00034C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssShowNameResponse Clone()
		{
			return new AbyssShowNameResponse(this);
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600146E RID: 5230 RVA: 0x00036A8E File Offset: 0x00034C8E
		// (set) Token: 0x0600146F RID: 5231 RVA: 0x00036A96 File Offset: 0x00034C96
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

		// Token: 0x06001470 RID: 5232 RVA: 0x00036A9F File Offset: 0x00034C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssShowNameResponse);
		}

		// Token: 0x06001471 RID: 5233 RVA: 0x00036AAD File Offset: 0x00034CAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssShowNameResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001472 RID: 5234 RVA: 0x00036ADC File Offset: 0x00034CDC
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

		// Token: 0x06001473 RID: 5235 RVA: 0x00036B21 File Offset: 0x00034D21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001474 RID: 5236 RVA: 0x00036B2E File Offset: 0x00034D2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001475 RID: 5237 RVA: 0x00036B37 File Offset: 0x00034D37
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

		// Token: 0x06001476 RID: 5238 RVA: 0x00036B6C File Offset: 0x00034D6C
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

		// Token: 0x06001477 RID: 5239 RVA: 0x00036BAA File Offset: 0x00034DAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssShowNameResponse other)
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

		// Token: 0x06001478 RID: 5240 RVA: 0x00036BDB File Offset: 0x00034DDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x00036BE4 File Offset: 0x00034DE4
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

		// Token: 0x04002053 RID: 8275
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002054 RID: 8276
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04002055 RID: 8277
		private ErrorCode errorCode_;
	}
}
