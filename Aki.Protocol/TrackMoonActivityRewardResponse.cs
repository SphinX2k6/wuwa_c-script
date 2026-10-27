using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013DC RID: 5084
	[NetMessage(EMessageId.TrackMoonActivityRewardResponse)]
	public sealed class TrackMoonActivityRewardResponse : IMessage<TrackMoonActivityRewardResponse>, IMessage, IEquatable<TrackMoonActivityRewardResponse>, IDeepCloneable<TrackMoonActivityRewardResponse>, IBufferMessage
	{
		// Token: 0x0601AF4B RID: 110411 RVA: 0x003E7EC4 File Offset: 0x003E60C4
		[NullableContext(1)]
		public static TrackMoonActivityRewardResponse Create()
		{
			return new TrackMoonActivityRewardResponse();
		}

		// Token: 0x17005AE2 RID: 23266
		// (get) Token: 0x0601AF4C RID: 110412 RVA: 0x003E7ECB File Offset: 0x003E60CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AE3 RID: 23267
		// (get) Token: 0x0601AF4D RID: 110413 RVA: 0x003E7ECE File Offset: 0x003E60CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrackMoonActivityRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601AF4E RID: 110414 RVA: 0x003E7ED5 File Offset: 0x003E60D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonActivityRewardResponse()
		{
		}

		// Token: 0x0601AF4F RID: 110415 RVA: 0x003E7EDD File Offset: 0x003E60DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonActivityRewardResponse(TrackMoonActivityRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AF50 RID: 110416 RVA: 0x003E7F02 File Offset: 0x003E6102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrackMoonActivityRewardResponse Clone()
		{
			return new TrackMoonActivityRewardResponse(this);
		}

		// Token: 0x17005AE4 RID: 23268
		// (get) Token: 0x0601AF51 RID: 110417 RVA: 0x003E7F0A File Offset: 0x003E610A
		// (set) Token: 0x0601AF52 RID: 110418 RVA: 0x003E7F12 File Offset: 0x003E6112
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

		// Token: 0x0601AF53 RID: 110419 RVA: 0x003E7F1B File Offset: 0x003E611B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrackMoonActivityRewardResponse);
		}

		// Token: 0x0601AF54 RID: 110420 RVA: 0x003E7F29 File Offset: 0x003E6129
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrackMoonActivityRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AF55 RID: 110421 RVA: 0x003E7F58 File Offset: 0x003E6158
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

		// Token: 0x0601AF56 RID: 110422 RVA: 0x003E7F9D File Offset: 0x003E619D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AF57 RID: 110423 RVA: 0x003E7FAA File Offset: 0x003E61AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AF58 RID: 110424 RVA: 0x003E7FB3 File Offset: 0x003E61B3
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

		// Token: 0x0601AF59 RID: 110425 RVA: 0x003E7FE8 File Offset: 0x003E61E8
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

		// Token: 0x0601AF5A RID: 110426 RVA: 0x003E8026 File Offset: 0x003E6226
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrackMoonActivityRewardResponse other)
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

		// Token: 0x0601AF5B RID: 110427 RVA: 0x003E8057 File Offset: 0x003E6257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AF5C RID: 110428 RVA: 0x003E8060 File Offset: 0x003E6260
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

		// Token: 0x04009C35 RID: 39989
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C36 RID: 39990
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04009C37 RID: 39991
		private ErrorCode errorCode_;
	}
}
