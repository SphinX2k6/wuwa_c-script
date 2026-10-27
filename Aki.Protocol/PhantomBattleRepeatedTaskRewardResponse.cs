using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CA6 RID: 3238
	[NetMessage(EMessageId.PhantomBattleRepeatedTaskRewardResponse)]
	public sealed class PhantomBattleRepeatedTaskRewardResponse : IMessage<PhantomBattleRepeatedTaskRewardResponse>, IMessage, IEquatable<PhantomBattleRepeatedTaskRewardResponse>, IDeepCloneable<PhantomBattleRepeatedTaskRewardResponse>, IBufferMessage
	{
		// Token: 0x060118BF RID: 71871 RVA: 0x00292215 File Offset: 0x00290415
		[NullableContext(1)]
		public static PhantomBattleRepeatedTaskRewardResponse Create()
		{
			return new PhantomBattleRepeatedTaskRewardResponse();
		}

		// Token: 0x17003A23 RID: 14883
		// (get) Token: 0x060118C0 RID: 71872 RVA: 0x0029221C File Offset: 0x0029041C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A24 RID: 14884
		// (get) Token: 0x060118C1 RID: 71873 RVA: 0x0029221F File Offset: 0x0029041F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomBattleRepeatedTaskRewardResponse.Descriptor;
			}
		}

		// Token: 0x060118C2 RID: 71874 RVA: 0x00292226 File Offset: 0x00290426
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRepeatedTaskRewardResponse()
		{
		}

		// Token: 0x060118C3 RID: 71875 RVA: 0x0029222E File Offset: 0x0029042E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRepeatedTaskRewardResponse(PhantomBattleRepeatedTaskRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060118C4 RID: 71876 RVA: 0x00292253 File Offset: 0x00290453
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomBattleRepeatedTaskRewardResponse Clone()
		{
			return new PhantomBattleRepeatedTaskRewardResponse(this);
		}

		// Token: 0x17003A25 RID: 14885
		// (get) Token: 0x060118C5 RID: 71877 RVA: 0x0029225B File Offset: 0x0029045B
		// (set) Token: 0x060118C6 RID: 71878 RVA: 0x00292263 File Offset: 0x00290463
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

		// Token: 0x060118C7 RID: 71879 RVA: 0x0029226C File Offset: 0x0029046C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomBattleRepeatedTaskRewardResponse);
		}

		// Token: 0x060118C8 RID: 71880 RVA: 0x0029227A File Offset: 0x0029047A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomBattleRepeatedTaskRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060118C9 RID: 71881 RVA: 0x002922A8 File Offset: 0x002904A8
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

		// Token: 0x060118CA RID: 71882 RVA: 0x002922ED File Offset: 0x002904ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060118CB RID: 71883 RVA: 0x002922FA File Offset: 0x002904FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060118CC RID: 71884 RVA: 0x00292303 File Offset: 0x00290503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(72);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060118CD RID: 71885 RVA: 0x00292338 File Offset: 0x00290538
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

		// Token: 0x060118CE RID: 71886 RVA: 0x00292376 File Offset: 0x00290576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomBattleRepeatedTaskRewardResponse other)
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

		// Token: 0x060118CF RID: 71887 RVA: 0x002923A7 File Offset: 0x002905A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060118D0 RID: 71888 RVA: 0x002923B0 File Offset: 0x002905B0
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
				if (num != 72U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006EA3 RID: 28323
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006EA4 RID: 28324
		public const int ErrorCodeFieldNumber = 9;

		// Token: 0x04006EA5 RID: 28325
		private ErrorCode errorCode_;
	}
}
