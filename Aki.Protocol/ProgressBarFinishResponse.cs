using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DD9 RID: 3545
	[NetMessage(EMessageId.ProgressBarFinishResponse)]
	public sealed class ProgressBarFinishResponse : IMessage<ProgressBarFinishResponse>, IMessage, IEquatable<ProgressBarFinishResponse>, IDeepCloneable<ProgressBarFinishResponse>, IBufferMessage
	{
		// Token: 0x0601319E RID: 78238 RVA: 0x002C8EA9 File Offset: 0x002C70A9
		[NullableContext(1)]
		public static ProgressBarFinishResponse Create()
		{
			return new ProgressBarFinishResponse();
		}

		// Token: 0x17003F64 RID: 16228
		// (get) Token: 0x0601319F RID: 78239 RVA: 0x002C8EB0 File Offset: 0x002C70B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F65 RID: 16229
		// (get) Token: 0x060131A0 RID: 78240 RVA: 0x002C8EB3 File Offset: 0x002C70B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ProgressBarFinishResponse.Descriptor;
			}
		}

		// Token: 0x060131A1 RID: 78241 RVA: 0x002C8EBA File Offset: 0x002C70BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProgressBarFinishResponse()
		{
		}

		// Token: 0x060131A2 RID: 78242 RVA: 0x002C8EC2 File Offset: 0x002C70C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProgressBarFinishResponse(ProgressBarFinishResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060131A3 RID: 78243 RVA: 0x002C8EE7 File Offset: 0x002C70E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ProgressBarFinishResponse Clone()
		{
			return new ProgressBarFinishResponse(this);
		}

		// Token: 0x17003F66 RID: 16230
		// (get) Token: 0x060131A4 RID: 78244 RVA: 0x002C8EEF File Offset: 0x002C70EF
		// (set) Token: 0x060131A5 RID: 78245 RVA: 0x002C8EF7 File Offset: 0x002C70F7
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

		// Token: 0x060131A6 RID: 78246 RVA: 0x002C8F00 File Offset: 0x002C7100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ProgressBarFinishResponse);
		}

		// Token: 0x060131A7 RID: 78247 RVA: 0x002C8F0E File Offset: 0x002C710E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ProgressBarFinishResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060131A8 RID: 78248 RVA: 0x002C8F3C File Offset: 0x002C713C
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

		// Token: 0x060131A9 RID: 78249 RVA: 0x002C8F81 File Offset: 0x002C7181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060131AA RID: 78250 RVA: 0x002C8F8E File Offset: 0x002C718E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060131AB RID: 78251 RVA: 0x002C8F97 File Offset: 0x002C7197
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060131AC RID: 78252 RVA: 0x002C8FCC File Offset: 0x002C71CC
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

		// Token: 0x060131AD RID: 78253 RVA: 0x002C900A File Offset: 0x002C720A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ProgressBarFinishResponse other)
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

		// Token: 0x060131AE RID: 78254 RVA: 0x002C903B File Offset: 0x002C723B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060131AF RID: 78255 RVA: 0x002C9044 File Offset: 0x002C7244
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400762D RID: 30253
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400762E RID: 30254
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x0400762F RID: 30255
		private ErrorCode errorCode_;
	}
}
