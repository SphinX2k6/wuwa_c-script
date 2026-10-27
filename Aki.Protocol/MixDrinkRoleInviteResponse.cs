using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009DB RID: 2523
	[NetMessage(EMessageId.MixDrinkRoleInviteResponse)]
	public sealed class MixDrinkRoleInviteResponse : IMessage<MixDrinkRoleInviteResponse>, IMessage, IEquatable<MixDrinkRoleInviteResponse>, IDeepCloneable<MixDrinkRoleInviteResponse>, IBufferMessage
	{
		// Token: 0x0600DD28 RID: 56616 RVA: 0x00207359 File Offset: 0x00205559
		[NullableContext(1)]
		public static MixDrinkRoleInviteResponse Create()
		{
			return new MixDrinkRoleInviteResponse();
		}

		// Token: 0x17002CD3 RID: 11475
		// (get) Token: 0x0600DD29 RID: 56617 RVA: 0x00207360 File Offset: 0x00205560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CD4 RID: 11476
		// (get) Token: 0x0600DD2A RID: 56618 RVA: 0x00207363 File Offset: 0x00205563
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MixDrinkRoleInviteResponse.Descriptor;
			}
		}

		// Token: 0x0600DD2B RID: 56619 RVA: 0x0020736A File Offset: 0x0020556A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleInviteResponse()
		{
		}

		// Token: 0x0600DD2C RID: 56620 RVA: 0x00207372 File Offset: 0x00205572
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleInviteResponse(MixDrinkRoleInviteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DD2D RID: 56621 RVA: 0x00207397 File Offset: 0x00205597
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleInviteResponse Clone()
		{
			return new MixDrinkRoleInviteResponse(this);
		}

		// Token: 0x17002CD5 RID: 11477
		// (get) Token: 0x0600DD2E RID: 56622 RVA: 0x0020739F File Offset: 0x0020559F
		// (set) Token: 0x0600DD2F RID: 56623 RVA: 0x002073A7 File Offset: 0x002055A7
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

		// Token: 0x0600DD30 RID: 56624 RVA: 0x002073B0 File Offset: 0x002055B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MixDrinkRoleInviteResponse);
		}

		// Token: 0x0600DD31 RID: 56625 RVA: 0x002073BE File Offset: 0x002055BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MixDrinkRoleInviteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DD32 RID: 56626 RVA: 0x002073EC File Offset: 0x002055EC
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

		// Token: 0x0600DD33 RID: 56627 RVA: 0x00207431 File Offset: 0x00205631
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DD34 RID: 56628 RVA: 0x0020743E File Offset: 0x0020563E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DD35 RID: 56629 RVA: 0x00207447 File Offset: 0x00205647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DD36 RID: 56630 RVA: 0x0020747C File Offset: 0x0020567C
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

		// Token: 0x0600DD37 RID: 56631 RVA: 0x002074BA File Offset: 0x002056BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MixDrinkRoleInviteResponse other)
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

		// Token: 0x0600DD38 RID: 56632 RVA: 0x002074EB File Offset: 0x002056EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DD39 RID: 56633 RVA: 0x002074F4 File Offset: 0x002056F4
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04005B7F RID: 23423
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B80 RID: 23424
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04005B81 RID: 23425
		private ErrorCode errorCode_;
	}
}
