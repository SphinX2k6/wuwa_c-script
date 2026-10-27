using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001357 RID: 4951
	[NetMessage(EMessageId.TetrisUpdateResponse)]
	public sealed class TetrisUpdateResponse : IMessage<TetrisUpdateResponse>, IMessage, IEquatable<TetrisUpdateResponse>, IDeepCloneable<TetrisUpdateResponse>, IBufferMessage
	{
		// Token: 0x0601A4E3 RID: 107747 RVA: 0x003D26A3 File Offset: 0x003D08A3
		[NullableContext(1)]
		public static TetrisUpdateResponse Create()
		{
			return new TetrisUpdateResponse();
		}

		// Token: 0x170058C4 RID: 22724
		// (get) Token: 0x0601A4E4 RID: 107748 RVA: 0x003D26AA File Offset: 0x003D08AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058C5 RID: 22725
		// (get) Token: 0x0601A4E5 RID: 107749 RVA: 0x003D26AD File Offset: 0x003D08AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TetrisUpdateResponse.Descriptor;
			}
		}

		// Token: 0x0601A4E6 RID: 107750 RVA: 0x003D26B4 File Offset: 0x003D08B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisUpdateResponse()
		{
		}

		// Token: 0x0601A4E7 RID: 107751 RVA: 0x003D26BC File Offset: 0x003D08BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisUpdateResponse(TetrisUpdateResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A4E8 RID: 107752 RVA: 0x003D26E1 File Offset: 0x003D08E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisUpdateResponse Clone()
		{
			return new TetrisUpdateResponse(this);
		}

		// Token: 0x170058C6 RID: 22726
		// (get) Token: 0x0601A4E9 RID: 107753 RVA: 0x003D26E9 File Offset: 0x003D08E9
		// (set) Token: 0x0601A4EA RID: 107754 RVA: 0x003D26F1 File Offset: 0x003D08F1
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

		// Token: 0x0601A4EB RID: 107755 RVA: 0x003D26FA File Offset: 0x003D08FA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TetrisUpdateResponse);
		}

		// Token: 0x0601A4EC RID: 107756 RVA: 0x003D2708 File Offset: 0x003D0908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TetrisUpdateResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A4ED RID: 107757 RVA: 0x003D2738 File Offset: 0x003D0938
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

		// Token: 0x0601A4EE RID: 107758 RVA: 0x003D277D File Offset: 0x003D097D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A4EF RID: 107759 RVA: 0x003D278A File Offset: 0x003D098A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A4F0 RID: 107760 RVA: 0x003D2793 File Offset: 0x003D0993
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A4F1 RID: 107761 RVA: 0x003D27C8 File Offset: 0x003D09C8
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

		// Token: 0x0601A4F2 RID: 107762 RVA: 0x003D2806 File Offset: 0x003D0A06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TetrisUpdateResponse other)
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

		// Token: 0x0601A4F3 RID: 107763 RVA: 0x003D2837 File Offset: 0x003D0A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A4F4 RID: 107764 RVA: 0x003D2840 File Offset: 0x003D0A40
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
				if (num != 80U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009967 RID: 39271
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009968 RID: 39272
		public const int ErrCodeFieldNumber = 10;

		// Token: 0x04009969 RID: 39273
		private ErrorCode errCode_;
	}
}
