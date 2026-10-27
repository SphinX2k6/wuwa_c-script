using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009C5 RID: 2501
	[NetMessage(EMessageId.MatchThreeEndResponse)]
	public sealed class MatchThreeEndResponse : IMessage<MatchThreeEndResponse>, IMessage, IEquatable<MatchThreeEndResponse>, IDeepCloneable<MatchThreeEndResponse>, IBufferMessage
	{
		// Token: 0x0600DB6D RID: 56173 RVA: 0x00203999 File Offset: 0x00201B99
		[NullableContext(1)]
		public static MatchThreeEndResponse Create()
		{
			return new MatchThreeEndResponse();
		}

		// Token: 0x17002C79 RID: 11385
		// (get) Token: 0x0600DB6E RID: 56174 RVA: 0x002039A0 File Offset: 0x00201BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C7A RID: 11386
		// (get) Token: 0x0600DB6F RID: 56175 RVA: 0x002039A3 File Offset: 0x00201BA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MatchThreeEndResponse.Descriptor;
			}
		}

		// Token: 0x0600DB70 RID: 56176 RVA: 0x002039AA File Offset: 0x00201BAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeEndResponse()
		{
		}

		// Token: 0x0600DB71 RID: 56177 RVA: 0x002039B2 File Offset: 0x00201BB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeEndResponse(MatchThreeEndResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.success_ = other.success_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DB72 RID: 56178 RVA: 0x002039E3 File Offset: 0x00201BE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MatchThreeEndResponse Clone()
		{
			return new MatchThreeEndResponse(this);
		}

		// Token: 0x17002C7B RID: 11387
		// (get) Token: 0x0600DB73 RID: 56179 RVA: 0x002039EB File Offset: 0x00201BEB
		// (set) Token: 0x0600DB74 RID: 56180 RVA: 0x002039F3 File Offset: 0x00201BF3
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

		// Token: 0x17002C7C RID: 11388
		// (get) Token: 0x0600DB75 RID: 56181 RVA: 0x002039FC File Offset: 0x00201BFC
		// (set) Token: 0x0600DB76 RID: 56182 RVA: 0x00203A04 File Offset: 0x00201C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Success
		{
			get
			{
				return this.success_;
			}
			set
			{
				this.success_ = value;
			}
		}

		// Token: 0x0600DB77 RID: 56183 RVA: 0x00203A0D File Offset: 0x00201C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MatchThreeEndResponse);
		}

		// Token: 0x0600DB78 RID: 56184 RVA: 0x00203A1B File Offset: 0x00201C1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MatchThreeEndResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Success == other.Success && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DB79 RID: 56185 RVA: 0x00203A5C File Offset: 0x00201C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Success)
			{
				num ^= this.Success.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DB7A RID: 56186 RVA: 0x00203ABA File Offset: 0x00201CBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DB7B RID: 56187 RVA: 0x00203AC7 File Offset: 0x00201CC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DB7C RID: 56188 RVA: 0x00203AD0 File Offset: 0x00201CD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Success)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.Success);
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

		// Token: 0x0600DB7D RID: 56189 RVA: 0x00203B2C File Offset: 0x00201D2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Success)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DB7E RID: 56190 RVA: 0x00203B78 File Offset: 0x00201D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MatchThreeEndResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Success)
			{
				this.Success = other.Success;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DB7F RID: 56191 RVA: 0x00203BC8 File Offset: 0x00201DC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB80 RID: 56192 RVA: 0x00203BD4 File Offset: 0x00201DD4
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
					this.Success = input.ReadBool();
				}
			}
		}

		// Token: 0x04005B10 RID: 23312
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B11 RID: 23313
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04005B12 RID: 23314
		private ErrorCode errorCode_;

		// Token: 0x04005B13 RID: 23315
		public const int SuccessFieldNumber = 2;

		// Token: 0x04005B14 RID: 23316
		private bool success_;
	}
}
