using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A6E RID: 2670
	[NetMessage(EMessageId.MotorFightTalentUpResponse)]
	public sealed class MotorFightTalentUpResponse : IMessage<MotorFightTalentUpResponse>, IMessage, IEquatable<MotorFightTalentUpResponse>, IDeepCloneable<MotorFightTalentUpResponse>, IBufferMessage
	{
		// Token: 0x0600E8DA RID: 59610 RVA: 0x002202F4 File Offset: 0x0021E4F4
		[NullableContext(1)]
		public static MotorFightTalentUpResponse Create()
		{
			return new MotorFightTalentUpResponse();
		}

		// Token: 0x17002F41 RID: 12097
		// (get) Token: 0x0600E8DB RID: 59611 RVA: 0x002202FB File Offset: 0x0021E4FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F42 RID: 12098
		// (get) Token: 0x0600E8DC RID: 59612 RVA: 0x002202FE File Offset: 0x0021E4FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightTalentUpResponse.Descriptor;
			}
		}

		// Token: 0x0600E8DD RID: 59613 RVA: 0x00220305 File Offset: 0x0021E505
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentUpResponse()
		{
		}

		// Token: 0x0600E8DE RID: 59614 RVA: 0x0022030D File Offset: 0x0021E50D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentUpResponse(MotorFightTalentUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E8DF RID: 59615 RVA: 0x00220332 File Offset: 0x0021E532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightTalentUpResponse Clone()
		{
			return new MotorFightTalentUpResponse(this);
		}

		// Token: 0x17002F43 RID: 12099
		// (get) Token: 0x0600E8E0 RID: 59616 RVA: 0x0022033A File Offset: 0x0021E53A
		// (set) Token: 0x0600E8E1 RID: 59617 RVA: 0x00220342 File Offset: 0x0021E542
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

		// Token: 0x0600E8E2 RID: 59618 RVA: 0x0022034B File Offset: 0x0021E54B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightTalentUpResponse);
		}

		// Token: 0x0600E8E3 RID: 59619 RVA: 0x00220359 File Offset: 0x0021E559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightTalentUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E8E4 RID: 59620 RVA: 0x00220388 File Offset: 0x0021E588
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

		// Token: 0x0600E8E5 RID: 59621 RVA: 0x002203CD File Offset: 0x0021E5CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E8E6 RID: 59622 RVA: 0x002203DA File Offset: 0x0021E5DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E8E7 RID: 59623 RVA: 0x002203E3 File Offset: 0x0021E5E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
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

		// Token: 0x0600E8E8 RID: 59624 RVA: 0x00220418 File Offset: 0x0021E618
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

		// Token: 0x0600E8E9 RID: 59625 RVA: 0x00220456 File Offset: 0x0021E656
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightTalentUpResponse other)
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

		// Token: 0x0600E8EA RID: 59626 RVA: 0x00220487 File Offset: 0x0021E687
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E8EB RID: 59627 RVA: 0x00220490 File Offset: 0x0021E690
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005EC4 RID: 24260
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EC5 RID: 24261
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04005EC6 RID: 24262
		private ErrorCode errorCode_;
	}
}
