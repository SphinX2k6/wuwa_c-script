using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200062E RID: 1582
	[NetMessage(EMessageId.FormationModifyResponse)]
	public sealed class FormationModifyResponse : IMessage<FormationModifyResponse>, IMessage, IEquatable<FormationModifyResponse>, IDeepCloneable<FormationModifyResponse>, IBufferMessage
	{
		// Token: 0x060091DB RID: 37339 RVA: 0x00160E70 File Offset: 0x0015F070
		[NullableContext(1)]
		public static FormationModifyResponse Create()
		{
			return new FormationModifyResponse();
		}

		// Token: 0x17001D00 RID: 7424
		// (get) Token: 0x060091DC RID: 37340 RVA: 0x00160E77 File Offset: 0x0015F077
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D01 RID: 7425
		// (get) Token: 0x060091DD RID: 37341 RVA: 0x00160E7A File Offset: 0x0015F07A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FormationModifyResponse.Descriptor;
			}
		}

		// Token: 0x060091DE RID: 37342 RVA: 0x00160E81 File Offset: 0x0015F081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationModifyResponse()
		{
		}

		// Token: 0x060091DF RID: 37343 RVA: 0x00160E8C File Offset: 0x0015F08C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationModifyResponse(FormationModifyResponse other) : this()
		{
			this.formation_ = ((other.formation_ != null) ? other.formation_.Clone() : null);
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060091E0 RID: 37344 RVA: 0x00160ED8 File Offset: 0x0015F0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FormationModifyResponse Clone()
		{
			return new FormationModifyResponse(this);
		}

		// Token: 0x17001D02 RID: 7426
		// (get) Token: 0x060091E1 RID: 37345 RVA: 0x00160EE0 File Offset: 0x0015F0E0
		// (set) Token: 0x060091E2 RID: 37346 RVA: 0x00160EE8 File Offset: 0x0015F0E8
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

		// Token: 0x17001D03 RID: 7427
		// (get) Token: 0x060091E3 RID: 37347 RVA: 0x00160EF1 File Offset: 0x0015F0F1
		// (set) Token: 0x060091E4 RID: 37348 RVA: 0x00160EF9 File Offset: 0x0015F0F9
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

		// Token: 0x060091E5 RID: 37349 RVA: 0x00160F02 File Offset: 0x0015F102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FormationModifyResponse);
		}

		// Token: 0x060091E6 RID: 37350 RVA: 0x00160F10 File Offset: 0x0015F110
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FormationModifyResponse other)
		{
			return other != null && (other == this || (object.Equals(this.Formation, other.Formation) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060091E7 RID: 37351 RVA: 0x00160F60 File Offset: 0x0015F160
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

		// Token: 0x060091E8 RID: 37352 RVA: 0x00160FBB File Offset: 0x0015F1BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060091E9 RID: 37353 RVA: 0x00160FC8 File Offset: 0x0015F1C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060091EA RID: 37354 RVA: 0x00160FD4 File Offset: 0x0015F1D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.formation_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.Formation);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060091EB RID: 37355 RVA: 0x00161030 File Offset: 0x0015F230
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

		// Token: 0x060091EC RID: 37356 RVA: 0x00161088 File Offset: 0x0015F288
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

		// Token: 0x060091ED RID: 37357 RVA: 0x001610F0 File Offset: 0x0015F2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060091EE RID: 37358 RVA: 0x001610FC File Offset: 0x0015F2FC
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
				if (num != 96U)
				{
					if (num != 114U)
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

		// Token: 0x04004667 RID: 18023
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004668 RID: 18024
		public const int FormationFieldNumber = 14;

		// Token: 0x04004669 RID: 18025
		private Formation formation_;

		// Token: 0x0400466A RID: 18026
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x0400466B RID: 18027
		private ErrorCode errorCode_;
	}
}
