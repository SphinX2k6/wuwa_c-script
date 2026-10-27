using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200019E RID: 414
	[NetMessage(EMessageId.BirthDayRewardResponse)]
	public sealed class BirthDayRewardResponse : IMessage<BirthDayRewardResponse>, IMessage, IEquatable<BirthDayRewardResponse>, IDeepCloneable<BirthDayRewardResponse>, IBufferMessage
	{
		// Token: 0x060030D3 RID: 12499 RVA: 0x0007C5A5 File Offset: 0x0007A7A5
		[NullableContext(1)]
		public static BirthDayRewardResponse Create()
		{
			return new BirthDayRewardResponse();
		}

		// Token: 0x1700078B RID: 1931
		// (get) Token: 0x060030D4 RID: 12500 RVA: 0x0007C5AC File Offset: 0x0007A7AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x060030D5 RID: 12501 RVA: 0x0007C5AF File Offset: 0x0007A7AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BirthDayRewardResponse.Descriptor;
			}
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x0007C5B6 File Offset: 0x0007A7B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayRewardResponse()
		{
		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x0007C5BE File Offset: 0x0007A7BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayRewardResponse(BirthDayRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060030D8 RID: 12504 RVA: 0x0007C5E3 File Offset: 0x0007A7E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BirthDayRewardResponse Clone()
		{
			return new BirthDayRewardResponse(this);
		}

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x060030D9 RID: 12505 RVA: 0x0007C5EB File Offset: 0x0007A7EB
		// (set) Token: 0x060030DA RID: 12506 RVA: 0x0007C5F3 File Offset: 0x0007A7F3
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

		// Token: 0x060030DB RID: 12507 RVA: 0x0007C5FC File Offset: 0x0007A7FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BirthDayRewardResponse);
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x0007C60A File Offset: 0x0007A80A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BirthDayRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x0007C638 File Offset: 0x0007A838
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

		// Token: 0x060030DE RID: 12510 RVA: 0x0007C67D File Offset: 0x0007A87D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x0007C68A File Offset: 0x0007A88A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x0007C693 File Offset: 0x0007A893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x0007C6C8 File Offset: 0x0007A8C8
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

		// Token: 0x060030E2 RID: 12514 RVA: 0x0007C706 File Offset: 0x0007A906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BirthDayRewardResponse other)
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

		// Token: 0x060030E3 RID: 12515 RVA: 0x0007C737 File Offset: 0x0007A937
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x0007C740 File Offset: 0x0007A940
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04002909 RID: 10505
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400290A RID: 10506
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x0400290B RID: 10507
		private ErrorCode errorCode_;
	}
}
