using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DCF RID: 3535
	[NetMessage(EMessageId.PreheatSignRewardResponse)]
	public sealed class PreheatSignRewardResponse : IMessage<PreheatSignRewardResponse>, IMessage, IEquatable<PreheatSignRewardResponse>, IDeepCloneable<PreheatSignRewardResponse>, IBufferMessage
	{
		// Token: 0x0601307B RID: 77947 RVA: 0x002C60A4 File Offset: 0x002C42A4
		[NullableContext(1)]
		public static PreheatSignRewardResponse Create()
		{
			return new PreheatSignRewardResponse();
		}

		// Token: 0x17003F25 RID: 16165
		// (get) Token: 0x0601307C RID: 77948 RVA: 0x002C60AB File Offset: 0x002C42AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003F26 RID: 16166
		// (get) Token: 0x0601307D RID: 77949 RVA: 0x002C60AE File Offset: 0x002C42AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PreheatSignRewardResponse.Descriptor;
			}
		}

		// Token: 0x0601307E RID: 77950 RVA: 0x002C60B5 File Offset: 0x002C42B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignRewardResponse()
		{
		}

		// Token: 0x0601307F RID: 77951 RVA: 0x002C60C0 File Offset: 0x002C42C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignRewardResponse(PreheatSignRewardResponse other) : this()
		{
			this.error_ = other.error_;
			this.preheatSignSurveyInfo_ = ((other.preheatSignSurveyInfo_ != null) ? other.preheatSignSurveyInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013080 RID: 77952 RVA: 0x002C610C File Offset: 0x002C430C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignRewardResponse Clone()
		{
			return new PreheatSignRewardResponse(this);
		}

		// Token: 0x17003F27 RID: 16167
		// (get) Token: 0x06013081 RID: 77953 RVA: 0x002C6114 File Offset: 0x002C4314
		// (set) Token: 0x06013082 RID: 77954 RVA: 0x002C611C File Offset: 0x002C431C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Error
		{
			get
			{
				return this.error_;
			}
			set
			{
				this.error_ = value;
			}
		}

		// Token: 0x17003F28 RID: 16168
		// (get) Token: 0x06013083 RID: 77955 RVA: 0x002C6125 File Offset: 0x002C4325
		// (set) Token: 0x06013084 RID: 77956 RVA: 0x002C612D File Offset: 0x002C432D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignSurveyInfo PreheatSignSurveyInfo
		{
			get
			{
				return this.preheatSignSurveyInfo_;
			}
			set
			{
				this.preheatSignSurveyInfo_ = value;
			}
		}

		// Token: 0x06013085 RID: 77957 RVA: 0x002C6136 File Offset: 0x002C4336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PreheatSignRewardResponse);
		}

		// Token: 0x06013086 RID: 77958 RVA: 0x002C6144 File Offset: 0x002C4344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PreheatSignRewardResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && object.Equals(this.PreheatSignSurveyInfo, other.PreheatSignSurveyInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013087 RID: 77959 RVA: 0x002C6194 File Offset: 0x002C4394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Error != ErrorCode.Success)
			{
				num ^= this.Error.GetHashCode();
			}
			if (this.preheatSignSurveyInfo_ != null)
			{
				num ^= this.PreheatSignSurveyInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013088 RID: 77960 RVA: 0x002C61EF File Offset: 0x002C43EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013089 RID: 77961 RVA: 0x002C61FC File Offset: 0x002C43FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601308A RID: 77962 RVA: 0x002C6208 File Offset: 0x002C4408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Error);
			}
			if (this.preheatSignSurveyInfo_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.PreheatSignSurveyInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601308B RID: 77963 RVA: 0x002C6264 File Offset: 0x002C4464
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Error != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Error);
			}
			if (this.preheatSignSurveyInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.PreheatSignSurveyInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601308C RID: 77964 RVA: 0x002C62BC File Offset: 0x002C44BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PreheatSignRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Error != ErrorCode.Success)
			{
				this.Error = other.Error;
			}
			if (other.preheatSignSurveyInfo_ != null)
			{
				if (this.preheatSignSurveyInfo_ == null)
				{
					this.PreheatSignSurveyInfo = new PreheatSignSurveyInfo();
				}
				this.PreheatSignSurveyInfo.MergeFrom(other.PreheatSignSurveyInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601308D RID: 77965 RVA: 0x002C6324 File Offset: 0x002C4524
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601308E RID: 77966 RVA: 0x002C6330 File Offset: 0x002C4530
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
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.preheatSignSurveyInfo_ == null)
						{
							this.PreheatSignSurveyInfo = new PreheatSignSurveyInfo();
						}
						input.ReadMessage(this.PreheatSignSurveyInfo);
					}
				}
				else
				{
					this.Error = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400757D RID: 30077
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400757E RID: 30078
		public const int ErrorFieldNumber = 10;

		// Token: 0x0400757F RID: 30079
		private ErrorCode error_;

		// Token: 0x04007580 RID: 30080
		public const int PreheatSignSurveyInfoFieldNumber = 15;

		// Token: 0x04007581 RID: 30081
		private PreheatSignSurveyInfo preheatSignSurveyInfo_;
	}
}
