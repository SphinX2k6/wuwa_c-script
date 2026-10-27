using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000710 RID: 1808
	[NetMessage(EMessageId.GravityFlipInteractResponse)]
	public sealed class GravityFlipInteractResponse : IMessage<GravityFlipInteractResponse>, IMessage, IEquatable<GravityFlipInteractResponse>, IDeepCloneable<GravityFlipInteractResponse>, IBufferMessage
	{
		// Token: 0x0600A470 RID: 42096 RVA: 0x0018CF74 File Offset: 0x0018B174
		[NullableContext(1)]
		public static GravityFlipInteractResponse Create()
		{
			return new GravityFlipInteractResponse();
		}

		// Token: 0x17002110 RID: 8464
		// (get) Token: 0x0600A471 RID: 42097 RVA: 0x0018CF7B File Offset: 0x0018B17B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002111 RID: 8465
		// (get) Token: 0x0600A472 RID: 42098 RVA: 0x0018CF7E File Offset: 0x0018B17E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GravityFlipInteractResponse.Descriptor;
			}
		}

		// Token: 0x0600A473 RID: 42099 RVA: 0x0018CF85 File Offset: 0x0018B185
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipInteractResponse()
		{
		}

		// Token: 0x0600A474 RID: 42100 RVA: 0x0018CF8D File Offset: 0x0018B18D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipInteractResponse(GravityFlipInteractResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.curGravityFlipType_ = other.curGravityFlipType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A475 RID: 42101 RVA: 0x0018CFBE File Offset: 0x0018B1BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipInteractResponse Clone()
		{
			return new GravityFlipInteractResponse(this);
		}

		// Token: 0x17002112 RID: 8466
		// (get) Token: 0x0600A476 RID: 42102 RVA: 0x0018CFC6 File Offset: 0x0018B1C6
		// (set) Token: 0x0600A477 RID: 42103 RVA: 0x0018CFCE File Offset: 0x0018B1CE
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

		// Token: 0x17002113 RID: 8467
		// (get) Token: 0x0600A478 RID: 42104 RVA: 0x0018CFD7 File Offset: 0x0018B1D7
		// (set) Token: 0x0600A479 RID: 42105 RVA: 0x0018CFDF File Offset: 0x0018B1DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GravityFlipType CurGravityFlipType
		{
			get
			{
				return this.curGravityFlipType_;
			}
			set
			{
				this.curGravityFlipType_ = value;
			}
		}

		// Token: 0x0600A47A RID: 42106 RVA: 0x0018CFE8 File Offset: 0x0018B1E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GravityFlipInteractResponse);
		}

		// Token: 0x0600A47B RID: 42107 RVA: 0x0018CFF6 File Offset: 0x0018B1F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GravityFlipInteractResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.CurGravityFlipType == other.CurGravityFlipType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A47C RID: 42108 RVA: 0x0018D034 File Offset: 0x0018B234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.CurGravityFlipType != GravityFlipType.GravityUp)
			{
				num ^= this.CurGravityFlipType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A47D RID: 42109 RVA: 0x0018D098 File Offset: 0x0018B298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A47E RID: 42110 RVA: 0x0018D0A5 File Offset: 0x0018B2A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A47F RID: 42111 RVA: 0x0018D0B0 File Offset: 0x0018B2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurGravityFlipType != GravityFlipType.GravityUp)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.CurGravityFlipType);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A480 RID: 42112 RVA: 0x0018D10C File Offset: 0x0018B30C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.CurGravityFlipType != GravityFlipType.GravityUp)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.CurGravityFlipType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A481 RID: 42113 RVA: 0x0018D164 File Offset: 0x0018B364
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GravityFlipInteractResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.CurGravityFlipType != GravityFlipType.GravityUp)
			{
				this.CurGravityFlipType = other.CurGravityFlipType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A482 RID: 42114 RVA: 0x0018D1B4 File Offset: 0x0018B3B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A483 RID: 42115 RVA: 0x0018D1C0 File Offset: 0x0018B3C0
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
				if (num != 32U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.CurGravityFlipType = (GravityFlipType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004BCC RID: 19404
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004BCD RID: 19405
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04004BCE RID: 19406
		private ErrorCode errorCode_;

		// Token: 0x04004BCF RID: 19407
		public const int CurGravityFlipTypeFieldNumber = 4;

		// Token: 0x04004BD0 RID: 19408
		private GravityFlipType curGravityFlipType_;
	}
}
