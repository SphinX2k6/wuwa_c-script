using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D63 RID: 3427
	[NetMessage(EMessageId.PlaceItemOnBoardResponse)]
	public sealed class PlaceItemOnBoardResponse : IMessage<PlaceItemOnBoardResponse>, IMessage, IEquatable<PlaceItemOnBoardResponse>, IDeepCloneable<PlaceItemOnBoardResponse>, IBufferMessage
	{
		// Token: 0x06012802 RID: 75778 RVA: 0x002B36FE File Offset: 0x002B18FE
		[NullableContext(1)]
		public static PlaceItemOnBoardResponse Create()
		{
			return new PlaceItemOnBoardResponse();
		}

		// Token: 0x17003D53 RID: 15699
		// (get) Token: 0x06012803 RID: 75779 RVA: 0x002B3705 File Offset: 0x002B1905
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D54 RID: 15700
		// (get) Token: 0x06012804 RID: 75780 RVA: 0x002B3708 File Offset: 0x002B1908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlaceItemOnBoardResponse.Descriptor;
			}
		}

		// Token: 0x06012805 RID: 75781 RVA: 0x002B370F File Offset: 0x002B190F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlaceItemOnBoardResponse()
		{
		}

		// Token: 0x06012806 RID: 75782 RVA: 0x002B3717 File Offset: 0x002B1917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlaceItemOnBoardResponse(PlaceItemOnBoardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.toPlace_ = other.toPlace_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012807 RID: 75783 RVA: 0x002B3748 File Offset: 0x002B1948
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlaceItemOnBoardResponse Clone()
		{
			return new PlaceItemOnBoardResponse(this);
		}

		// Token: 0x17003D55 RID: 15701
		// (get) Token: 0x06012808 RID: 75784 RVA: 0x002B3750 File Offset: 0x002B1950
		// (set) Token: 0x06012809 RID: 75785 RVA: 0x002B3758 File Offset: 0x002B1958
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

		// Token: 0x17003D56 RID: 15702
		// (get) Token: 0x0601280A RID: 75786 RVA: 0x002B3761 File Offset: 0x002B1961
		// (set) Token: 0x0601280B RID: 75787 RVA: 0x002B3769 File Offset: 0x002B1969
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ToPlace
		{
			get
			{
				return this.toPlace_;
			}
			set
			{
				this.toPlace_ = value;
			}
		}

		// Token: 0x0601280C RID: 75788 RVA: 0x002B3772 File Offset: 0x002B1972
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlaceItemOnBoardResponse);
		}

		// Token: 0x0601280D RID: 75789 RVA: 0x002B3780 File Offset: 0x002B1980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlaceItemOnBoardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.ToPlace == other.ToPlace && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601280E RID: 75790 RVA: 0x002B37C0 File Offset: 0x002B19C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			if (this.ToPlace != 0)
			{
				num ^= this.ToPlace.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601280F RID: 75791 RVA: 0x002B381E File Offset: 0x002B1A1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012810 RID: 75792 RVA: 0x002B382B File Offset: 0x002B1A2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012811 RID: 75793 RVA: 0x002B3834 File Offset: 0x002B1A34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ToPlace != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ToPlace);
			}
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012812 RID: 75794 RVA: 0x002B3890 File Offset: 0x002B1A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			if (this.ToPlace != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ToPlace);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012813 RID: 75795 RVA: 0x002B38E8 File Offset: 0x002B1AE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlaceItemOnBoardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			if (other.ToPlace != 0)
			{
				this.ToPlace = other.ToPlace;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012814 RID: 75796 RVA: 0x002B3938 File Offset: 0x002B1B38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012815 RID: 75797 RVA: 0x002B3944 File Offset: 0x002B1B44
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
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.ToPlace = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400735F RID: 29535
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007360 RID: 29536
		public const int ErrCodeFieldNumber = 8;

		// Token: 0x04007361 RID: 29537
		private ErrorCode errCode_;

		// Token: 0x04007362 RID: 29538
		public const int ToPlaceFieldNumber = 2;

		// Token: 0x04007363 RID: 29539
		private int toPlace_;
	}
}
