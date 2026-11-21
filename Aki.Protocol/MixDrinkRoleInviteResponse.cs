using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009CA RID: 2506
	[NetMessage(EMessageId.MixDrinkRoleInviteResponse)]
	public sealed class MixDrinkRoleInviteResponse : IMessage<MixDrinkRoleInviteResponse>, IMessage, IEquatable<MixDrinkRoleInviteResponse>, IDeepCloneable<MixDrinkRoleInviteResponse>, IBufferMessage
	{
		// Token: 0x0600DC0E RID: 56334 RVA: 0x0020516D File Offset: 0x0020336D
		[NullableContext(1)]
		public static MixDrinkRoleInviteResponse Create()
		{
			return new MixDrinkRoleInviteResponse();
		}

		// Token: 0x17002C95 RID: 11413
		// (get) Token: 0x0600DC0F RID: 56335 RVA: 0x00205174 File Offset: 0x00203374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C96 RID: 11414
		// (get) Token: 0x0600DC10 RID: 56336 RVA: 0x00205177 File Offset: 0x00203377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MixDrinkRoleInviteResponse.Descriptor;
			}
		}

		// Token: 0x0600DC11 RID: 56337 RVA: 0x0020517E File Offset: 0x0020337E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleInviteResponse()
		{
		}

		// Token: 0x0600DC12 RID: 56338 RVA: 0x00205186 File Offset: 0x00203386
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleInviteResponse(MixDrinkRoleInviteResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DC13 RID: 56339 RVA: 0x002051AB File Offset: 0x002033AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MixDrinkRoleInviteResponse Clone()
		{
			return new MixDrinkRoleInviteResponse(this);
		}

		// Token: 0x17002C97 RID: 11415
		// (get) Token: 0x0600DC14 RID: 56340 RVA: 0x002051B3 File Offset: 0x002033B3
		// (set) Token: 0x0600DC15 RID: 56341 RVA: 0x002051BB File Offset: 0x002033BB
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

		// Token: 0x0600DC16 RID: 56342 RVA: 0x002051C4 File Offset: 0x002033C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MixDrinkRoleInviteResponse);
		}

		// Token: 0x0600DC17 RID: 56343 RVA: 0x002051D2 File Offset: 0x002033D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MixDrinkRoleInviteResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DC18 RID: 56344 RVA: 0x00205200 File Offset: 0x00203400
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

		// Token: 0x0600DC19 RID: 56345 RVA: 0x00205245 File Offset: 0x00203445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DC1A RID: 56346 RVA: 0x00205252 File Offset: 0x00203452
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC1B RID: 56347 RVA: 0x0020525B File Offset: 0x0020345B
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

		// Token: 0x0600DC1C RID: 56348 RVA: 0x00205290 File Offset: 0x00203490
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

		// Token: 0x0600DC1D RID: 56349 RVA: 0x002052CE File Offset: 0x002034CE
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

		// Token: 0x0600DC1E RID: 56350 RVA: 0x002052FF File Offset: 0x002034FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC1F RID: 56351 RVA: 0x00205308 File Offset: 0x00203508
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

		// Token: 0x04005B88 RID: 23432
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B89 RID: 23433
		public const int ErrorCodeFieldNumber = 2;

		// Token: 0x04005B8A RID: 23434
		private ErrorCode errorCode_;
	}
}
