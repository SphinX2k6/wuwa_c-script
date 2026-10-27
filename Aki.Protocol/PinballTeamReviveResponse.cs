using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D68 RID: 3432
	[NetMessage(EMessageId.PinballTeamReviveResponse)]
	public sealed class PinballTeamReviveResponse : IMessage<PinballTeamReviveResponse>, IMessage, IEquatable<PinballTeamReviveResponse>, IDeepCloneable<PinballTeamReviveResponse>, IBufferMessage
	{
		// Token: 0x06012812 RID: 75794 RVA: 0x002B2FCA File Offset: 0x002B11CA
		[NullableContext(1)]
		public static PinballTeamReviveResponse Create()
		{
			return new PinballTeamReviveResponse();
		}

		// Token: 0x17003D54 RID: 15700
		// (get) Token: 0x06012813 RID: 75795 RVA: 0x002B2FD1 File Offset: 0x002B11D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D55 RID: 15701
		// (get) Token: 0x06012814 RID: 75796 RVA: 0x002B2FD4 File Offset: 0x002B11D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballTeamReviveResponse.Descriptor;
			}
		}

		// Token: 0x06012815 RID: 75797 RVA: 0x002B2FDB File Offset: 0x002B11DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamReviveResponse()
		{
		}

		// Token: 0x06012816 RID: 75798 RVA: 0x002B2FE3 File Offset: 0x002B11E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamReviveResponse(PinballTeamReviveResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012817 RID: 75799 RVA: 0x002B3008 File Offset: 0x002B1208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballTeamReviveResponse Clone()
		{
			return new PinballTeamReviveResponse(this);
		}

		// Token: 0x17003D56 RID: 15702
		// (get) Token: 0x06012818 RID: 75800 RVA: 0x002B3010 File Offset: 0x002B1210
		// (set) Token: 0x06012819 RID: 75801 RVA: 0x002B3018 File Offset: 0x002B1218
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

		// Token: 0x0601281A RID: 75802 RVA: 0x002B3021 File Offset: 0x002B1221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballTeamReviveResponse);
		}

		// Token: 0x0601281B RID: 75803 RVA: 0x002B302F File Offset: 0x002B122F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballTeamReviveResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601281C RID: 75804 RVA: 0x002B3060 File Offset: 0x002B1260
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

		// Token: 0x0601281D RID: 75805 RVA: 0x002B30A5 File Offset: 0x002B12A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601281E RID: 75806 RVA: 0x002B30B2 File Offset: 0x002B12B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601281F RID: 75807 RVA: 0x002B30BB File Offset: 0x002B12BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012820 RID: 75808 RVA: 0x002B30F0 File Offset: 0x002B12F0
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

		// Token: 0x06012821 RID: 75809 RVA: 0x002B312E File Offset: 0x002B132E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballTeamReviveResponse other)
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

		// Token: 0x06012822 RID: 75810 RVA: 0x002B315F File Offset: 0x002B135F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012823 RID: 75811 RVA: 0x002B3168 File Offset: 0x002B1368
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007305 RID: 29445
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007306 RID: 29446
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04007307 RID: 29447
		private ErrorCode errorCode_;
	}
}
