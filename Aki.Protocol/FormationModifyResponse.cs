using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200061A RID: 1562
	[NetMessage(EMessageId.FormationModifyResponse)]
	public sealed class FormationModifyResponse : IMessage<FormationModifyResponse>, IMessage, IEquatable<FormationModifyResponse>, IDeepCloneable<FormationModifyResponse>, IBufferMessage
	{
		// Token: 0x06009085 RID: 36997 RVA: 0x0015E440 File Offset: 0x0015C640
		[NullableContext(1)]
		public static FormationModifyResponse Create()
		{
			return new FormationModifyResponse();
		}

		// Token: 0x17001CB6 RID: 7350
		// (get) Token: 0x06009086 RID: 36998 RVA: 0x0015E447 File Offset: 0x0015C647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001CB7 RID: 7351
		// (get) Token: 0x06009087 RID: 36999 RVA: 0x0015E44A File Offset: 0x0015C64A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationModifyResponse.Descriptor;
			}
		}

		// Token: 0x06009088 RID: 37000 RVA: 0x0015E451 File Offset: 0x0015C651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationModifyResponse()
		{
		}

		// Token: 0x06009089 RID: 37001 RVA: 0x0015E45C File Offset: 0x0015C65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationModifyResponse(FormationModifyResponse other) : this()
		{
			this.formation_ = ((other.formation_ != null) ? other.formation_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600908A RID: 37002 RVA: 0x0015E4A8 File Offset: 0x0015C6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationModifyResponse Clone()
		{
			return new FormationModifyResponse(this);
		}

		// Token: 0x17001CB8 RID: 7352
		// (get) Token: 0x0600908B RID: 37003 RVA: 0x0015E4B0 File Offset: 0x0015C6B0
		// (set) Token: 0x0600908C RID: 37004 RVA: 0x0015E4B8 File Offset: 0x0015C6B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Formation Formation
		{
			get
			{
				return this.formation_;
			}
			set
			{
				this.formation_ = value;
			}
		}

		// Token: 0x17001CB9 RID: 7353
		// (get) Token: 0x0600908D RID: 37005 RVA: 0x0015E4C1 File Offset: 0x0015C6C1
		// (set) Token: 0x0600908E RID: 37006 RVA: 0x0015E4C9 File Offset: 0x0015C6C9
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

		// Token: 0x0600908F RID: 37007 RVA: 0x0015E4D2 File Offset: 0x0015C6D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationModifyResponse);
		}

		// Token: 0x06009090 RID: 37008 RVA: 0x0015E4E0 File Offset: 0x0015C6E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationModifyResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Formation, other.Formation) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009091 RID: 37009 RVA: 0x0015E530 File Offset: 0x0015C730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.formation_ != null)
			{
				num ^= this.Formation.GetHashCode();
			}
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

		// Token: 0x06009092 RID: 37010 RVA: 0x0015E58B File Offset: 0x0015C78B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009093 RID: 37011 RVA: 0x0015E598 File Offset: 0x0015C798
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009094 RID: 37012 RVA: 0x0015E5A4 File Offset: 0x0015C7A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.formation_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Formation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009095 RID: 37013 RVA: 0x0015E600 File Offset: 0x0015C800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.formation_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Formation);
			}
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

		// Token: 0x06009096 RID: 37014 RVA: 0x0015E658 File Offset: 0x0015C858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FormationModifyResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.formation_ != null)
			{
				if (this.formation_ == null)
				{
					this.Formation = new Formation();
				}
				this.Formation.MergeFrom(other.Formation);
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009097 RID: 37015 RVA: 0x0015E6C0 File Offset: 0x0015C8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009098 RID: 37016 RVA: 0x0015E6CC File Offset: 0x0015C8CC
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
				if (num != 16U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.formation_ == null)
						{
							this.Formation = new Formation();
						}
						input.ReadMessage(this.Formation);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004660 RID: 18016
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004661 RID: 18017
		public const int FormationFieldNumber = 11;

		// Token: 0x04004662 RID: 18018
		private Formation formation_;

		// Token: 0x04004663 RID: 18019
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04004664 RID: 18020
		private ErrorCode errorCode_;
	}
}
