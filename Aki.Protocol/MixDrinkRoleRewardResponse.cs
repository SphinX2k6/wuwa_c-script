using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009CC RID: 2508
	[NetMessage(EMessageId.MixDrinkRoleRewardResponse)]
	public sealed class MixDrinkRoleRewardResponse : IMessage<MixDrinkRoleRewardResponse>, IMessage, IEquatable<MixDrinkRoleRewardResponse>, IDeepCloneable<MixDrinkRoleRewardResponse>, IBufferMessage
	{
		// Token: 0x0600DC32 RID: 56370 RVA: 0x00205525 File Offset: 0x00203725
		[NullableContext(1)]
		public static MixDrinkRoleRewardResponse Create()
		{
			return new MixDrinkRoleRewardResponse();
		}

		// Token: 0x17002C9B RID: 11419
		// (get) Token: 0x0600DC33 RID: 56371 RVA: 0x0020552C File Offset: 0x0020372C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C9C RID: 11420
		// (get) Token: 0x0600DC34 RID: 56372 RVA: 0x0020552F File Offset: 0x0020372F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MixDrinkRoleRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600DC35 RID: 56373 RVA: 0x00205536 File Offset: 0x00203736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleRewardResponse()
		{
		}

		// Token: 0x0600DC36 RID: 56374 RVA: 0x0020553E File Offset: 0x0020373E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleRewardResponse(MixDrinkRoleRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DC37 RID: 56375 RVA: 0x00205563 File Offset: 0x00203763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleRewardResponse Clone()
		{
			return new MixDrinkRoleRewardResponse(this);
		}

		// Token: 0x17002C9D RID: 11421
		// (get) Token: 0x0600DC38 RID: 56376 RVA: 0x0020556B File Offset: 0x0020376B
		// (set) Token: 0x0600DC39 RID: 56377 RVA: 0x00205573 File Offset: 0x00203773
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

		// Token: 0x0600DC3A RID: 56378 RVA: 0x0020557C File Offset: 0x0020377C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MixDrinkRoleRewardResponse);
		}

		// Token: 0x0600DC3B RID: 56379 RVA: 0x0020558A File Offset: 0x0020378A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MixDrinkRoleRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DC3C RID: 56380 RVA: 0x002055B8 File Offset: 0x002037B8
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

		// Token: 0x0600DC3D RID: 56381 RVA: 0x002055FD File Offset: 0x002037FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DC3E RID: 56382 RVA: 0x0020560A File Offset: 0x0020380A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC3F RID: 56383 RVA: 0x00205613 File Offset: 0x00203813
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

		// Token: 0x0600DC40 RID: 56384 RVA: 0x00205648 File Offset: 0x00203848
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

		// Token: 0x0600DC41 RID: 56385 RVA: 0x00205686 File Offset: 0x00203886
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

		// Token: 0x0600DC42 RID: 56386 RVA: 0x002056B7 File Offset: 0x002038B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC43 RID: 56387 RVA: 0x002056C0 File Offset: 0x002038C0
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

		// Token: 0x04005B8E RID: 23438
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B8F RID: 23439
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04005B90 RID: 23440
		private ErrorCode errorCode_;
	}
}
