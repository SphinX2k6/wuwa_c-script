using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000590 RID: 1424
	[NetMessage(EMessageId.FishingTeleportToBoatResponse)]
	public sealed class FishingTeleportToBoatResponse : IMessage<FishingTeleportToBoatResponse>, IMessage, IEquatable<FishingTeleportToBoatResponse>, IDeepCloneable<FishingTeleportToBoatResponse>, IBufferMessage
	{
		// Token: 0x060083F8 RID: 33784 RVA: 0x0013D9DE File Offset: 0x0013BBDE
		[NullableContext(1)]
		public static FishingTeleportToBoatResponse Create()
		{
			return new FishingTeleportToBoatResponse();
		}

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x060083F9 RID: 33785 RVA: 0x0013D9E5 File Offset: 0x0013BBE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x060083FA RID: 33786 RVA: 0x0013D9E8 File Offset: 0x0013BBE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingTeleportToBoatResponse.Descriptor;
			}
		}

		// Token: 0x060083FB RID: 33787 RVA: 0x0013D9EF File Offset: 0x0013BBEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTeleportToBoatResponse()
		{
		}

		// Token: 0x060083FC RID: 33788 RVA: 0x0013D9F7 File Offset: 0x0013BBF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTeleportToBoatResponse(FishingTeleportToBoatResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060083FD RID: 33789 RVA: 0x0013DA1C File Offset: 0x0013BC1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingTeleportToBoatResponse Clone()
		{
			return new FishingTeleportToBoatResponse(this);
		}

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x060083FE RID: 33790 RVA: 0x0013DA24 File Offset: 0x0013BC24
		// (set) Token: 0x060083FF RID: 33791 RVA: 0x0013DA2C File Offset: 0x0013BC2C
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

		// Token: 0x06008400 RID: 33792 RVA: 0x0013DA35 File Offset: 0x0013BC35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingTeleportToBoatResponse);
		}

		// Token: 0x06008401 RID: 33793 RVA: 0x0013DA43 File Offset: 0x0013BC43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingTeleportToBoatResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008402 RID: 33794 RVA: 0x0013DA74 File Offset: 0x0013BC74
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

		// Token: 0x06008403 RID: 33795 RVA: 0x0013DAB9 File Offset: 0x0013BCB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008404 RID: 33796 RVA: 0x0013DAC6 File Offset: 0x0013BCC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008405 RID: 33797 RVA: 0x0013DACF File Offset: 0x0013BCCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008406 RID: 33798 RVA: 0x0013DB04 File Offset: 0x0013BD04
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

		// Token: 0x06008407 RID: 33799 RVA: 0x0013DB42 File Offset: 0x0013BD42
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingTeleportToBoatResponse other)
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

		// Token: 0x06008408 RID: 33800 RVA: 0x0013DB73 File Offset: 0x0013BD73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008409 RID: 33801 RVA: 0x0013DB7C File Offset: 0x0013BD7C
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
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004194 RID: 16788
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004195 RID: 16789
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x04004196 RID: 16790
		private ErrorCode errorCode_;
	}
}
