using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x02001716 RID: 5910
	[NetMessage(EMessageId.GmIsOverlapNotify)]
	public sealed class GmIsOverlapNotify : IMessage<GmIsOverlapNotify>, IMessage, IEquatable<GmIsOverlapNotify>, IDeepCloneable<GmIsOverlapNotify>, IBufferMessage
	{
		// Token: 0x0601DAD0 RID: 121552 RVA: 0x0045A9B5 File Offset: 0x00458BB5
		[NullableContext(1)]
		public static GmIsOverlapNotify Create()
		{
			return new GmIsOverlapNotify();
		}

		// Token: 0x1700650D RID: 25869
		// (get) Token: 0x0601DAD1 RID: 121553 RVA: 0x0045A9BC File Offset: 0x00458BBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700650E RID: 25870
		// (get) Token: 0x0601DAD2 RID: 121554 RVA: 0x0045A9BF File Offset: 0x00458BBF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmIsOverlapNotify.Descriptor;
			}
		}

		// Token: 0x0601DAD3 RID: 121555 RVA: 0x0045A9C6 File Offset: 0x00458BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmIsOverlapNotify()
		{
		}

		// Token: 0x0601DAD4 RID: 121556 RVA: 0x0045A9D0 File Offset: 0x00458BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmIsOverlapNotify(GmIsOverlapNotify other) : this()
		{
			this.cellSize_ = other.cellSize_;
			this.box_ = ((other.box_ != null) ? other.box_.Clone() : null);
			this.isOverlap_ = other.isOverlap_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601DAD5 RID: 121557 RVA: 0x0045AA28 File Offset: 0x00458C28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmIsOverlapNotify Clone()
		{
			return new GmIsOverlapNotify(this);
		}

		// Token: 0x1700650F RID: 25871
		// (get) Token: 0x0601DAD6 RID: 121558 RVA: 0x0045AA30 File Offset: 0x00458C30
		// (set) Token: 0x0601DAD7 RID: 121559 RVA: 0x0045AA38 File Offset: 0x00458C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public float CellSize
		{
			get
			{
				return this.cellSize_;
			}
			set
			{
				this.cellSize_ = value;
			}
		}

		// Token: 0x17006510 RID: 25872
		// (get) Token: 0x0601DAD8 RID: 121560 RVA: 0x0045AA41 File Offset: 0x00458C41
		// (set) Token: 0x0601DAD9 RID: 121561 RVA: 0x0045AA49 File Offset: 0x00458C49
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VoxelSpan Box
		{
			get
			{
				return this.box_;
			}
			set
			{
				this.box_ = value;
			}
		}

		// Token: 0x17006511 RID: 25873
		// (get) Token: 0x0601DADA RID: 121562 RVA: 0x0045AA52 File Offset: 0x00458C52
		// (set) Token: 0x0601DADB RID: 121563 RVA: 0x0045AA5A File Offset: 0x00458C5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOverlap
		{
			get
			{
				return this.isOverlap_;
			}
			set
			{
				this.isOverlap_ = value;
			}
		}

		// Token: 0x0601DADC RID: 121564 RVA: 0x0045AA63 File Offset: 0x00458C63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmIsOverlapNotify);
		}

		// Token: 0x0601DADD RID: 121565 RVA: 0x0045AA74 File Offset: 0x00458C74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmIsOverlapNotify other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.CellSize, other.CellSize) && object.Equals(this.Box, other.Box) && this.IsOverlap == other.IsOverlap && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601DADE RID: 121566 RVA: 0x0045AADC File Offset: 0x00458CDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.CellSize != 0f)
			{
				num ^= ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(this.CellSize);
			}
			if (this.box_ != null)
			{
				num ^= this.Box.GetHashCode();
			}
			if (this.IsOverlap)
			{
				num ^= this.IsOverlap.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601DADF RID: 121567 RVA: 0x0045AB51 File Offset: 0x00458D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601DAE0 RID: 121568 RVA: 0x0045AB5E File Offset: 0x00458D5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601DAE1 RID: 121569 RVA: 0x0045AB68 File Offset: 0x00458D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CellSize != 0f)
			{
				output.WriteRawTag(13);
				output.WriteFloat(this.CellSize);
			}
			if (this.IsOverlap)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.IsOverlap);
			}
			if (this.box_ != null)
			{
				output.WriteRawTag(122);
				output.WriteMessage(this.Box);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601DAE2 RID: 121570 RVA: 0x0045ABE4 File Offset: 0x00458DE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.CellSize != 0f)
			{
				num += 5;
			}
			if (this.box_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Box);
			}
			if (this.IsOverlap)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601DAE3 RID: 121571 RVA: 0x0045AC40 File Offset: 0x00458E40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GmIsOverlapNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.CellSize != 0f)
			{
				this.CellSize = other.CellSize;
			}
			if (other.box_ != null)
			{
				if (this.box_ == null)
				{
					this.Box = new VoxelSpan();
				}
				this.Box.MergeFrom(other.Box);
			}
			if (other.IsOverlap)
			{
				this.IsOverlap = other.IsOverlap;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601DAE4 RID: 121572 RVA: 0x0045ACC1 File Offset: 0x00458EC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601DAE5 RID: 121573 RVA: 0x0045ACCC File Offset: 0x00458ECC
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
				if (num != 13U)
				{
					if (num != 88U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.box_ == null)
							{
								this.Box = new VoxelSpan();
							}
							input.ReadMessage(this.Box);
						}
					}
					else
					{
						this.IsOverlap = input.ReadBool();
					}
				}
				else
				{
					this.CellSize = input.ReadFloat();
				}
			}
		}

		// Token: 0x0400C8FF RID: 51455
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C900 RID: 51456
		public const int CellSizeFieldNumber = 1;

		// Token: 0x0400C901 RID: 51457
		private float cellSize_;

		// Token: 0x0400C902 RID: 51458
		public const int BoxFieldNumber = 15;

		// Token: 0x0400C903 RID: 51459
		private VoxelSpan box_;

		// Token: 0x0400C904 RID: 51460
		public const int IsOverlapFieldNumber = 11;

		// Token: 0x0400C905 RID: 51461
		private bool isOverlap_;
	}
}
