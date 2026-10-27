using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009DD RID: 2525
	[NetMessage(EMessageId.MixDrinkRoleRewardResponse)]
	public sealed class MixDrinkRoleRewardResponse : IMessage<MixDrinkRoleRewardResponse>, IMessage, IEquatable<MixDrinkRoleRewardResponse>, IDeepCloneable<MixDrinkRoleRewardResponse>, IBufferMessage
	{
		// Token: 0x0600DD4C RID: 56652 RVA: 0x00207711 File Offset: 0x00205911
		[NullableContext(1)]
		public static MixDrinkRoleRewardResponse Create()
		{
			return new MixDrinkRoleRewardResponse();
		}

		// Token: 0x17002CD9 RID: 11481
		// (get) Token: 0x0600DD4D RID: 56653 RVA: 0x00207718 File Offset: 0x00205918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CDA RID: 11482
		// (get) Token: 0x0600DD4E RID: 56654 RVA: 0x0020771B File Offset: 0x0020591B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MixDrinkRoleRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600DD4F RID: 56655 RVA: 0x00207722 File Offset: 0x00205922
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleRewardResponse()
		{
		}

		// Token: 0x0600DD50 RID: 56656 RVA: 0x0020772A File Offset: 0x0020592A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleRewardResponse(MixDrinkRoleRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD51 RID: 56657 RVA: 0x0020774F File Offset: 0x0020594F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleRewardResponse Clone()
		{
			return new MixDrinkRoleRewardResponse(this);
		}

		// Token: 0x17002CDB RID: 11483
		// (get) Token: 0x0600DD52 RID: 56658 RVA: 0x00207757 File Offset: 0x00205957
		// (set) Token: 0x0600DD53 RID: 56659 RVA: 0x0020775F File Offset: 0x0020595F
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

		// Token: 0x0600DD54 RID: 56660 RVA: 0x00207768 File Offset: 0x00205968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MixDrinkRoleRewardResponse);
		}

		// Token: 0x0600DD55 RID: 56661 RVA: 0x00207776 File Offset: 0x00205976
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MixDrinkRoleRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD56 RID: 56662 RVA: 0x002077A4 File Offset: 0x002059A4
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

		// Token: 0x0600DD57 RID: 56663 RVA: 0x002077E9 File Offset: 0x002059E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DD58 RID: 56664 RVA: 0x002077F6 File Offset: 0x002059F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD59 RID: 56665 RVA: 0x002077FF File Offset: 0x002059FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD5A RID: 56666 RVA: 0x00207834 File Offset: 0x00205A34
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

		// Token: 0x0600DD5B RID: 56667 RVA: 0x00207872 File Offset: 0x00205A72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MixDrinkRoleRewardResponse other)
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

		// Token: 0x0600DD5C RID: 56668 RVA: 0x002078A3 File Offset: 0x00205AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD5D RID: 56669 RVA: 0x002078AC File Offset: 0x00205AAC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005B85 RID: 23429
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B86 RID: 23430
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04005B87 RID: 23431
		private ErrorCode errorCode_;
	}
}
