using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C9E RID: 3230
	[NetMessage(EMessageId.PhantomBattleRoundOverResponse)]
	public sealed class PhantomBattleRoundOverResponse : IMessage<PhantomBattleRoundOverResponse>, IMessage, IEquatable<PhantomBattleRoundOverResponse>, IDeepCloneable<PhantomBattleRoundOverResponse>, IBufferMessage
	{
		// Token: 0x0601185C RID: 71772 RVA: 0x00291766 File Offset: 0x0028F966
		[NullableContext(1)]
		public static PhantomBattleRoundOverResponse Create()
		{
			return new PhantomBattleRoundOverResponse();
		}

		// Token: 0x17003A0B RID: 14859
		// (get) Token: 0x0601185D RID: 71773 RVA: 0x0029176D File Offset: 0x0028F96D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A0C RID: 14860
		// (get) Token: 0x0601185E RID: 71774 RVA: 0x00291770 File Offset: 0x0028F970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleRoundOverResponse.Descriptor;
			}
		}

		// Token: 0x0601185F RID: 71775 RVA: 0x00291777 File Offset: 0x0028F977
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoundOverResponse()
		{
		}

		// Token: 0x06011860 RID: 71776 RVA: 0x0029177F File Offset: 0x0028F97F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoundOverResponse(PhantomBattleRoundOverResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011861 RID: 71777 RVA: 0x002917A4 File Offset: 0x0028F9A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRoundOverResponse Clone()
		{
			return new PhantomBattleRoundOverResponse(this);
		}

		// Token: 0x17003A0D RID: 14861
		// (get) Token: 0x06011862 RID: 71778 RVA: 0x002917AC File Offset: 0x0028F9AC
		// (set) Token: 0x06011863 RID: 71779 RVA: 0x002917B4 File Offset: 0x0028F9B4
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

		// Token: 0x06011864 RID: 71780 RVA: 0x002917BD File Offset: 0x0028F9BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleRoundOverResponse);
		}

		// Token: 0x06011865 RID: 71781 RVA: 0x002917CB File Offset: 0x0028F9CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleRoundOverResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011866 RID: 71782 RVA: 0x002917FC File Offset: 0x0028F9FC
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

		// Token: 0x06011867 RID: 71783 RVA: 0x00291841 File Offset: 0x0028FA41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011868 RID: 71784 RVA: 0x0029184E File Offset: 0x0028FA4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011869 RID: 71785 RVA: 0x00291857 File Offset: 0x0028FA57
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

		// Token: 0x0601186A RID: 71786 RVA: 0x0029188C File Offset: 0x0028FA8C
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

		// Token: 0x0601186B RID: 71787 RVA: 0x002918CA File Offset: 0x0028FACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleRoundOverResponse other)
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

		// Token: 0x0601186C RID: 71788 RVA: 0x002918FB File Offset: 0x0028FAFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601186D RID: 71789 RVA: 0x00291904 File Offset: 0x0028FB04
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

		// Token: 0x04006EDE RID: 28382
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EDF RID: 28383
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04006EE0 RID: 28384
		private ErrorCode errorCode_;
	}
}
