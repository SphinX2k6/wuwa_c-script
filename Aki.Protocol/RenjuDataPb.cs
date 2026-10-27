using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F16 RID: 3862
	public sealed class RenjuDataPb : IMessage<RenjuDataPb>, IMessage, IEquatable<RenjuDataPb>, IDeepCloneable<RenjuDataPb>, IBufferMessage
	{
		// Token: 0x06014ACA RID: 84682 RVA: 0x003002E3 File Offset: 0x002FE4E3
		[NullableContext(1)]
		public static RenjuDataPb Create()
		{
			return new RenjuDataPb();
		}

		// Token: 0x170044B8 RID: 17592
		// (get) Token: 0x06014ACB RID: 84683 RVA: 0x003002EA File Offset: 0x002FE4EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170044B9 RID: 17593
		// (get) Token: 0x06014ACC RID: 84684 RVA: 0x003002ED File Offset: 0x002FE4ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RenjuDataPb.Descriptor;
			}
		}

		// Token: 0x06014ACD RID: 84685 RVA: 0x003002F4 File Offset: 0x002FE4F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuDataPb()
		{
		}

		// Token: 0x06014ACE RID: 84686 RVA: 0x003002FC File Offset: 0x002FE4FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuDataPb(RenjuDataPb other) : this()
		{
			this.moveCount_ = other.moveCount_;
			this.lastMoveEntityConfigId_ = other.lastMoveEntityConfigId_;
			this.winner_ = other.winner_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014ACF RID: 84687 RVA: 0x00300339 File Offset: 0x002FE539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RenjuDataPb Clone()
		{
			return new RenjuDataPb(this);
		}

		// Token: 0x170044BA RID: 17594
		// (get) Token: 0x06014AD0 RID: 84688 RVA: 0x00300341 File Offset: 0x002FE541
		// (set) Token: 0x06014AD1 RID: 84689 RVA: 0x00300349 File Offset: 0x002FE549
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MoveCount
		{
			get
			{
				return this.moveCount_;
			}
			set
			{
				this.moveCount_ = value;
			}
		}

		// Token: 0x170044BB RID: 17595
		// (get) Token: 0x06014AD2 RID: 84690 RVA: 0x00300352 File Offset: 0x002FE552
		// (set) Token: 0x06014AD3 RID: 84691 RVA: 0x0030035A File Offset: 0x002FE55A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LastMoveEntityConfigId
		{
			get
			{
				return this.lastMoveEntityConfigId_;
			}
			set
			{
				this.lastMoveEntityConfigId_ = value;
			}
		}

		// Token: 0x170044BC RID: 17596
		// (get) Token: 0x06014AD4 RID: 84692 RVA: 0x00300363 File Offset: 0x002FE563
		// (set) Token: 0x06014AD5 RID: 84693 RVA: 0x0030036B File Offset: 0x002FE56B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Winner
		{
			get
			{
				return this.winner_;
			}
			set
			{
				this.winner_ = value;
			}
		}

		// Token: 0x06014AD6 RID: 84694 RVA: 0x00300374 File Offset: 0x002FE574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RenjuDataPb);
		}

		// Token: 0x06014AD7 RID: 84695 RVA: 0x00300384 File Offset: 0x002FE584
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RenjuDataPb other)
		{
			return other != null && (other == this || (this.MoveCount == other.MoveCount && this.LastMoveEntityConfigId == other.LastMoveEntityConfigId && this.Winner == other.Winner && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014AD8 RID: 84696 RVA: 0x003003E0 File Offset: 0x002FE5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MoveCount != 0)
			{
				num ^= this.MoveCount.GetHashCode();
			}
			if (this.LastMoveEntityConfigId != 0)
			{
				num ^= this.LastMoveEntityConfigId.GetHashCode();
			}
			if (this.Winner != 0)
			{
				num ^= this.Winner.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014AD9 RID: 84697 RVA: 0x00300451 File Offset: 0x002FE651
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014ADA RID: 84698 RVA: 0x0030045E File Offset: 0x002FE65E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014ADB RID: 84699 RVA: 0x00300468 File Offset: 0x002FE668
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MoveCount != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.MoveCount);
			}
			if (this.LastMoveEntityConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LastMoveEntityConfigId);
			}
			if (this.Winner != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Winner);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014ADC RID: 84700 RVA: 0x003004DC File Offset: 0x002FE6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MoveCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MoveCount);
			}
			if (this.LastMoveEntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LastMoveEntityConfigId);
			}
			if (this.Winner != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Winner);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014ADD RID: 84701 RVA: 0x0030054C File Offset: 0x002FE74C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RenjuDataPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MoveCount != 0)
			{
				this.MoveCount = other.MoveCount;
			}
			if (other.LastMoveEntityConfigId != 0)
			{
				this.LastMoveEntityConfigId = other.LastMoveEntityConfigId;
			}
			if (other.Winner != 0)
			{
				this.Winner = other.Winner;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014ADE RID: 84702 RVA: 0x003005B0 File Offset: 0x002FE7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014ADF RID: 84703 RVA: 0x003005BC File Offset: 0x002FE7BC
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.Winner = input.ReadInt32();
						}
					}
					else
					{
						this.LastMoveEntityConfigId = input.ReadInt32();
					}
				}
				else
				{
					this.MoveCount = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007CFF RID: 31999
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007D00 RID: 32000
		public const int MoveCountFieldNumber = 1;

		// Token: 0x04007D01 RID: 32001
		private int moveCount_;

		// Token: 0x04007D02 RID: 32002
		public const int LastMoveEntityConfigIdFieldNumber = 2;

		// Token: 0x04007D03 RID: 32003
		private int lastMoveEntityConfigId_;

		// Token: 0x04007D04 RID: 32004
		public const int WinnerFieldNumber = 3;

		// Token: 0x04007D05 RID: 32005
		private int winner_;
	}
}
