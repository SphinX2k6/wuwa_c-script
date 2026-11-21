using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DBF RID: 3519
	[NetMessage(EMessageId.PreheatSignRewardResponse)]
	public sealed class PreheatSignRewardResponse : IMessage<PreheatSignRewardResponse>, IMessage, IEquatable<PreheatSignRewardResponse>, IDeepCloneable<PreheatSignRewardResponse>, IBufferMessage
	{
		// Token: 0x06012F96 RID: 77718 RVA: 0x002C49E4 File Offset: 0x002C2BE4
		[NullableContext(1)]
		public static PreheatSignRewardResponse Create()
		{
			return new PreheatSignRewardResponse();
		}

		// Token: 0x17003EFB RID: 16123
		// (get) Token: 0x06012F97 RID: 77719 RVA: 0x002C49EB File Offset: 0x002C2BEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EFC RID: 16124
		// (get) Token: 0x06012F98 RID: 77720 RVA: 0x002C49EE File Offset: 0x002C2BEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PreheatSignRewardResponse.Descriptor;
			}
		}

		// Token: 0x06012F99 RID: 77721 RVA: 0x002C49F5 File Offset: 0x002C2BF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignRewardResponse()
		{
		}

		// Token: 0x06012F9A RID: 77722 RVA: 0x002C4A00 File Offset: 0x002C2C00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignRewardResponse(PreheatSignRewardResponse other) : this()
		{
			this.error_ = other.error_;
			this.preheatSignSurveyInfo_ = ((other.preheatSignSurveyInfo_ != null) ? other.preheatSignSurveyInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012F9B RID: 77723 RVA: 0x002C4A4C File Offset: 0x002C2C4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PreheatSignRewardResponse Clone()
		{
			return new PreheatSignRewardResponse(this);
		}

		// Token: 0x17003EFD RID: 16125
		// (get) Token: 0x06012F9C RID: 77724 RVA: 0x002C4A54 File Offset: 0x002C2C54
		// (set) Token: 0x06012F9D RID: 77725 RVA: 0x002C4A5C File Offset: 0x002C2C5C
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

		// Token: 0x17003EFE RID: 16126
		// (get) Token: 0x06012F9E RID: 77726 RVA: 0x002C4A65 File Offset: 0x002C2C65
		// (set) Token: 0x06012F9F RID: 77727 RVA: 0x002C4A6D File Offset: 0x002C2C6D
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

		// Token: 0x06012FA0 RID: 77728 RVA: 0x002C4A76 File Offset: 0x002C2C76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PreheatSignRewardResponse);
		}

		// Token: 0x06012FA1 RID: 77729 RVA: 0x002C4A84 File Offset: 0x002C2C84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PreheatSignRewardResponse other)
		{
			return other != null && (other == this || (this.Error == other.Error && object.Equals(this.PreheatSignSurveyInfo, other.PreheatSignSurveyInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012FA2 RID: 77730 RVA: 0x002C4AD4 File Offset: 0x002C2CD4
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

		// Token: 0x06012FA3 RID: 77731 RVA: 0x002C4B2F File Offset: 0x002C2D2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012FA4 RID: 77732 RVA: 0x002C4B3C File Offset: 0x002C2D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012FA5 RID: 77733 RVA: 0x002C4B48 File Offset: 0x002C2D48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Error != ErrorCode.Success)
			{
				output.WriteRawTag(112);
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

		// Token: 0x06012FA6 RID: 77734 RVA: 0x002C4BA4 File Offset: 0x002C2DA4
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

		// Token: 0x06012FA7 RID: 77735 RVA: 0x002C4BFC File Offset: 0x002C2DFC
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

		// Token: 0x06012FA8 RID: 77736 RVA: 0x002C4C64 File Offset: 0x002C2E64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012FA9 RID: 77737 RVA: 0x002C4C70 File Offset: 0x002C2E70
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

		// Token: 0x040075A7 RID: 30119
		private UnknownFieldSet _unknownFields;

		// Token: 0x040075A8 RID: 30120
		public const int ErrorFieldNumber = 14;

		// Token: 0x040075A9 RID: 30121
		private ErrorCode error_;

		// Token: 0x040075AA RID: 30122
		public const int PreheatSignSurveyInfoFieldNumber = 15;

		// Token: 0x040075AB RID: 30123
		private PreheatSignSurveyInfo preheatSignSurveyInfo_;
	}
}
