using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D73 RID: 3443
	[NetMessage(EMessageId.PlaceItemOnBoardResponse)]
	public sealed class PlaceItemOnBoardResponse : IMessage<PlaceItemOnBoardResponse>, IMessage, IEquatable<PlaceItemOnBoardResponse>, IDeepCloneable<PlaceItemOnBoardResponse>, IBufferMessage
	{
		// Token: 0x060128FE RID: 76030 RVA: 0x002B531B File Offset: 0x002B351B
		[NullableContext(1)]
		public static PlaceItemOnBoardResponse Create()
		{
			return new PlaceItemOnBoardResponse();
		}

		// Token: 0x17003D88 RID: 15752
		// (get) Token: 0x060128FF RID: 76031 RVA: 0x002B5322 File Offset: 0x002B3522
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D89 RID: 15753
		// (get) Token: 0x06012900 RID: 76032 RVA: 0x002B5325 File Offset: 0x002B3525
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlaceItemOnBoardResponse.Descriptor;
			}
		}

		// Token: 0x06012901 RID: 76033 RVA: 0x002B532C File Offset: 0x002B352C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlaceItemOnBoardResponse()
		{
		}

		// Token: 0x06012902 RID: 76034 RVA: 0x002B5334 File Offset: 0x002B3534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlaceItemOnBoardResponse(PlaceItemOnBoardResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.toPlace_ = other.toPlace_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012903 RID: 76035 RVA: 0x002B5365 File Offset: 0x002B3565
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlaceItemOnBoardResponse Clone()
		{
			return new PlaceItemOnBoardResponse(this);
		}

		// Token: 0x17003D8A RID: 15754
		// (get) Token: 0x06012904 RID: 76036 RVA: 0x002B536D File Offset: 0x002B356D
		// (set) Token: 0x06012905 RID: 76037 RVA: 0x002B5375 File Offset: 0x002B3575
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

		// Token: 0x17003D8B RID: 15755
		// (get) Token: 0x06012906 RID: 76038 RVA: 0x002B537E File Offset: 0x002B357E
		// (set) Token: 0x06012907 RID: 76039 RVA: 0x002B5386 File Offset: 0x002B3586
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

		// Token: 0x06012908 RID: 76040 RVA: 0x002B538F File Offset: 0x002B358F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlaceItemOnBoardResponse);
		}

		// Token: 0x06012909 RID: 76041 RVA: 0x002B539D File Offset: 0x002B359D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlaceItemOnBoardResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.ToPlace == other.ToPlace && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601290A RID: 76042 RVA: 0x002B53DC File Offset: 0x002B35DC
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

		// Token: 0x0601290B RID: 76043 RVA: 0x002B543A File Offset: 0x002B363A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601290C RID: 76044 RVA: 0x002B5447 File Offset: 0x002B3647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601290D RID: 76045 RVA: 0x002B5450 File Offset: 0x002B3650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this.ToPlace != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ToPlace);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601290E RID: 76046 RVA: 0x002B54AC File Offset: 0x002B36AC
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

		// Token: 0x0601290F RID: 76047 RVA: 0x002B5504 File Offset: 0x002B3704
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

		// Token: 0x06012910 RID: 76048 RVA: 0x002B5554 File Offset: 0x002B3754
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012911 RID: 76049 RVA: 0x002B5560 File Offset: 0x002B3760
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ToPlace = input.ReadInt32();
					}
				}
				else
				{
					this.ErrCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04007347 RID: 29511
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007348 RID: 29512
		public const int ErrCodeFieldNumber = 13;

		// Token: 0x04007349 RID: 29513
		private ErrorCode errCode_;

		// Token: 0x0400734A RID: 29514
		public const int ToPlaceFieldNumber = 15;

		// Token: 0x0400734B RID: 29515
		private int toPlace_;
	}
}
