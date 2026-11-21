using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006B0 RID: 1712
	[NetMessage(EMessageId.GetDetectionLabelInfoResponse)]
	public sealed class GetDetectionLabelInfoResponse : IMessage<GetDetectionLabelInfoResponse>, IMessage, IEquatable<GetDetectionLabelInfoResponse>, IDeepCloneable<GetDetectionLabelInfoResponse>, IBufferMessage
	{
		// Token: 0x06009D25 RID: 40229 RVA: 0x0017DF16 File Offset: 0x0017C116
		[NullableContext(1)]
		public static GetDetectionLabelInfoResponse Create()
		{
			return new GetDetectionLabelInfoResponse();
		}

		// Token: 0x17001F8E RID: 8078
		// (get) Token: 0x06009D26 RID: 40230 RVA: 0x0017DF1D File Offset: 0x0017C11D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F8F RID: 8079
		// (get) Token: 0x06009D27 RID: 40231 RVA: 0x0017DF20 File Offset: 0x0017C120
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GetDetectionLabelInfoResponse.Descriptor;
			}
		}

		// Token: 0x06009D28 RID: 40232 RVA: 0x0017DF27 File Offset: 0x0017C127
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionLabelInfoResponse()
		{
		}

		// Token: 0x06009D29 RID: 40233 RVA: 0x0017DF2F File Offset: 0x0017C12F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionLabelInfoResponse(GetDetectionLabelInfoResponse other) : this()
		{
			this.unlockLabelInfo_ = ((other.unlockLabelInfo_ != null) ? other.unlockLabelInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009D2A RID: 40234 RVA: 0x0017DF64 File Offset: 0x0017C164
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GetDetectionLabelInfoResponse Clone()
		{
			return new GetDetectionLabelInfoResponse(this);
		}

		// Token: 0x17001F90 RID: 8080
		// (get) Token: 0x06009D2B RID: 40235 RVA: 0x0017DF6C File Offset: 0x0017C16C
		// (set) Token: 0x06009D2C RID: 40236 RVA: 0x0017DF74 File Offset: 0x0017C174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UnlockDetectionLabelInfo UnlockLabelInfo
		{
			get
			{
				return this.unlockLabelInfo_;
			}
			set
			{
				this.unlockLabelInfo_ = value;
			}
		}

		// Token: 0x06009D2D RID: 40237 RVA: 0x0017DF7D File Offset: 0x0017C17D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GetDetectionLabelInfoResponse);
		}

		// Token: 0x06009D2E RID: 40238 RVA: 0x0017DF8B File Offset: 0x0017C18B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GetDetectionLabelInfoResponse other)
		{
			return other != null && (other == this || (object.Equals(this.UnlockLabelInfo, other.UnlockLabelInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009D2F RID: 40239 RVA: 0x0017DFC0 File Offset: 0x0017C1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.unlockLabelInfo_ != null)
			{
				num ^= this.UnlockLabelInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009D30 RID: 40240 RVA: 0x0017DFFC File Offset: 0x0017C1FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009D31 RID: 40241 RVA: 0x0017E009 File Offset: 0x0017C209
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009D32 RID: 40242 RVA: 0x0017E012 File Offset: 0x0017C212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.unlockLabelInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.UnlockLabelInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009D33 RID: 40243 RVA: 0x0017E044 File Offset: 0x0017C244
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.unlockLabelInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.UnlockLabelInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009D34 RID: 40244 RVA: 0x0017E084 File Offset: 0x0017C284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GetDetectionLabelInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.unlockLabelInfo_ != null)
			{
				if (this.unlockLabelInfo_ == null)
				{
					this.UnlockLabelInfo = new UnlockDetectionLabelInfo();
				}
				this.UnlockLabelInfo.MergeFrom(other.UnlockLabelInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009D35 RID: 40245 RVA: 0x0017E0D8 File Offset: 0x0017C2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009D36 RID: 40246 RVA: 0x0017E0E4 File Offset: 0x0017C2E4
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.unlockLabelInfo_ == null)
					{
						this.UnlockLabelInfo = new UnlockDetectionLabelInfo();
					}
					input.ReadMessage(this.UnlockLabelInfo);
				}
			}
		}

		// Token: 0x04004A2B RID: 18987
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004A2C RID: 18988
		public const int UnlockLabelInfoFieldNumber = 8;

		// Token: 0x04004A2D RID: 18989
		private UnlockDetectionLabelInfo unlockLabelInfo_;
	}
}
