using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A3E RID: 2622
	[NetMessage(EMessageId.MotorFightPlayerDeadResponse)]
	public sealed class MotorFightPlayerDeadResponse : IMessage<MotorFightPlayerDeadResponse>, IMessage, IEquatable<MotorFightPlayerDeadResponse>, IDeepCloneable<MotorFightPlayerDeadResponse>, IBufferMessage
	{
		// Token: 0x0600E52D RID: 58669 RVA: 0x00218326 File Offset: 0x00216526
		[NullableContext(1)]
		public static MotorFightPlayerDeadResponse Create()
		{
			return new MotorFightPlayerDeadResponse();
		}

		// Token: 0x17002E72 RID: 11890
		// (get) Token: 0x0600E52E RID: 58670 RVA: 0x0021832D File Offset: 0x0021652D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002E73 RID: 11891
		// (get) Token: 0x0600E52F RID: 58671 RVA: 0x00218330 File Offset: 0x00216530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorFightPlayerDeadResponse.Descriptor;
			}
		}

		// Token: 0x0600E530 RID: 58672 RVA: 0x00218337 File Offset: 0x00216537
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightPlayerDeadResponse()
		{
		}

		// Token: 0x0600E531 RID: 58673 RVA: 0x0021833F File Offset: 0x0021653F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightPlayerDeadResponse(MotorFightPlayerDeadResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E532 RID: 58674 RVA: 0x00218364 File Offset: 0x00216564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorFightPlayerDeadResponse Clone()
		{
			return new MotorFightPlayerDeadResponse(this);
		}

		// Token: 0x17002E74 RID: 11892
		// (get) Token: 0x0600E533 RID: 58675 RVA: 0x0021836C File Offset: 0x0021656C
		// (set) Token: 0x0600E534 RID: 58676 RVA: 0x00218374 File Offset: 0x00216574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x0600E535 RID: 58677 RVA: 0x0021837D File Offset: 0x0021657D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorFightPlayerDeadResponse);
		}

		// Token: 0x0600E536 RID: 58678 RVA: 0x0021838B File Offset: 0x0021658B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorFightPlayerDeadResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E537 RID: 58679 RVA: 0x002183BC File Offset: 0x002165BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E538 RID: 58680 RVA: 0x00218401 File Offset: 0x00216601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E539 RID: 58681 RVA: 0x0021840E File Offset: 0x0021660E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E53A RID: 58682 RVA: 0x00218417 File Offset: 0x00216617
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E53B RID: 58683 RVA: 0x0021844C File Offset: 0x0021664C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E53C RID: 58684 RVA: 0x0021848A File Offset: 0x0021668A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorFightPlayerDeadResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E53D RID: 58685 RVA: 0x002184BB File Offset: 0x002166BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E53E RID: 58686 RVA: 0x002184C4 File Offset: 0x002166C4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005DFF RID: 24063
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005E00 RID: 24064
		public const int ErrCodeFieldNumber = 14;

		// Token: 0x04005E01 RID: 24065
		private ErrorCode errCode_;
	}
}
