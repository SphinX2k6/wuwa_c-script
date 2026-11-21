using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005FF RID: 1535
	[NetMessage(EMessageId.FlySkinWearResponse)]
	public sealed class FlySkinWearResponse : IMessage<FlySkinWearResponse>, IMessage, IEquatable<FlySkinWearResponse>, IDeepCloneable<FlySkinWearResponse>, IBufferMessage
	{
		// Token: 0x06008E4E RID: 36430 RVA: 0x001593E7 File Offset: 0x001575E7
		[NullableContext(1)]
		public static FlySkinWearResponse Create()
		{
			return new FlySkinWearResponse();
		}

		// Token: 0x17001C3A RID: 7226
		// (get) Token: 0x06008E4F RID: 36431 RVA: 0x001593EE File Offset: 0x001575EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C3B RID: 7227
		// (get) Token: 0x06008E50 RID: 36432 RVA: 0x001593F1 File Offset: 0x001575F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlySkinWearResponse.Descriptor;
			}
		}

		// Token: 0x06008E51 RID: 36433 RVA: 0x001593F8 File Offset: 0x001575F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearResponse()
		{
		}

		// Token: 0x06008E52 RID: 36434 RVA: 0x00159400 File Offset: 0x00157600
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearResponse(FlySkinWearResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008E53 RID: 36435 RVA: 0x00159425 File Offset: 0x00157625
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearResponse Clone()
		{
			return new FlySkinWearResponse(this);
		}

		// Token: 0x17001C3C RID: 7228
		// (get) Token: 0x06008E54 RID: 36436 RVA: 0x0015942D File Offset: 0x0015762D
		// (set) Token: 0x06008E55 RID: 36437 RVA: 0x00159435 File Offset: 0x00157635
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

		// Token: 0x06008E56 RID: 36438 RVA: 0x0015943E File Offset: 0x0015763E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlySkinWearResponse);
		}

		// Token: 0x06008E57 RID: 36439 RVA: 0x0015944C File Offset: 0x0015764C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlySkinWearResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008E58 RID: 36440 RVA: 0x0015947C File Offset: 0x0015767C
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

		// Token: 0x06008E59 RID: 36441 RVA: 0x001594C1 File Offset: 0x001576C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008E5A RID: 36442 RVA: 0x001594CE File Offset: 0x001576CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008E5B RID: 36443 RVA: 0x001594D7 File Offset: 0x001576D7
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

		// Token: 0x06008E5C RID: 36444 RVA: 0x0015950C File Offset: 0x0015770C
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

		// Token: 0x06008E5D RID: 36445 RVA: 0x0015954A File Offset: 0x0015774A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlySkinWearResponse other)
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

		// Token: 0x06008E5E RID: 36446 RVA: 0x0015957B File Offset: 0x0015777B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008E5F RID: 36447 RVA: 0x00159584 File Offset: 0x00157784
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

		// Token: 0x040045AB RID: 17835
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045AC RID: 17836
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x040045AD RID: 17837
		private ErrorCode errorCode_;
	}
}
