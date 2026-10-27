using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x0200169A RID: 5786
	[NetMessage(EMessageId.GmIsOverlapNotify)]
	public sealed class GmIsOverlapNotify : IMessage<GmIsOverlapNotify>, IMessage, IEquatable<GmIsOverlapNotify>, IDeepCloneable<GmIsOverlapNotify>, IBufferMessage
	{
		// Token: 0x0601D001 RID: 118785 RVA: 0x0043EC75 File Offset: 0x0043CE75
		[NullableContext(1)]
		public static GmIsOverlapNotify Create()
		{
			return new GmIsOverlapNotify();
		}

		// Token: 0x17006268 RID: 25192
		// (get) Token: 0x0601D002 RID: 118786 RVA: 0x0043EC7C File Offset: 0x0043CE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006269 RID: 25193
		// (get) Token: 0x0601D003 RID: 118787 RVA: 0x0043EC7F File Offset: 0x0043CE7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GmIsOverlapNotify.Descriptor;
			}
		}

		// Token: 0x0601D004 RID: 118788 RVA: 0x0043EC86 File Offset: 0x0043CE86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmIsOverlapNotify()
		{
		}

		// Token: 0x0601D005 RID: 118789 RVA: 0x0043EC90 File Offset: 0x0043CE90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmIsOverlapNotify(GmIsOverlapNotify other) : this()
		{
			this.cellSize_ = other.cellSize_;
			this.box_ = ((other.box_ != null) ? other.box_.Clone() : null);
			this.isOverlap_ = other.isOverlap_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D006 RID: 118790 RVA: 0x0043ECE8 File Offset: 0x0043CEE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GmIsOverlapNotify Clone()
		{
			return new GmIsOverlapNotify(this);
		}

		// Token: 0x1700626A RID: 25194
		// (get) Token: 0x0601D007 RID: 118791 RVA: 0x0043ECF0 File Offset: 0x0043CEF0
		// (set) Token: 0x0601D008 RID: 118792 RVA: 0x0043ECF8 File Offset: 0x0043CEF8
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

		// Token: 0x1700626B RID: 25195
		// (get) Token: 0x0601D009 RID: 118793 RVA: 0x0043ED01 File Offset: 0x0043CF01
		// (set) Token: 0x0601D00A RID: 118794 RVA: 0x0043ED09 File Offset: 0x0043CF09
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

		// Token: 0x1700626C RID: 25196
		// (get) Token: 0x0601D00B RID: 118795 RVA: 0x0043ED12 File Offset: 0x0043CF12
		// (set) Token: 0x0601D00C RID: 118796 RVA: 0x0043ED1A File Offset: 0x0043CF1A
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

		// Token: 0x0601D00D RID: 118797 RVA: 0x0043ED23 File Offset: 0x0043CF23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GmIsOverlapNotify);
		}

		// Token: 0x0601D00E RID: 118798 RVA: 0x0043ED34 File Offset: 0x0043CF34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GmIsOverlapNotify other)
		{
			return other != null && (other == this || (ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(this.CellSize, other.CellSize) && object.Equals(this.Box, other.Box) && this.IsOverlap == other.IsOverlap && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D00F RID: 118799 RVA: 0x0043ED9C File Offset: 0x0043CF9C
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

		// Token: 0x0601D010 RID: 118800 RVA: 0x0043EE11 File Offset: 0x0043D011
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D011 RID: 118801 RVA: 0x0043EE1E File Offset: 0x0043D01E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D012 RID: 118802 RVA: 0x0043EE28 File Offset: 0x0043D028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsOverlap)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.IsOverlap);
			}
			if (this.box_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.Box);
			}
			if (this.CellSize != 0f)
			{
				output.WriteRawTag(77);
				output.WriteFloat(this.CellSize);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D013 RID: 118803 RVA: 0x0043EEA4 File Offset: 0x0043D0A4
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

		// Token: 0x0601D014 RID: 118804 RVA: 0x0043EF00 File Offset: 0x0043D100
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

		// Token: 0x0601D015 RID: 118805 RVA: 0x0043EF81 File Offset: 0x0043D181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D016 RID: 118806 RVA: 0x0043EF8C File Offset: 0x0043D18C
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
				if (num != 24U)
				{
					if (num != 34U)
					{
						if (num != 77U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.CellSize = input.ReadFloat();
						}
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
		}

		// Token: 0x0400C3D0 RID: 50128
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C3D1 RID: 50129
		public const int CellSizeFieldNumber = 9;

		// Token: 0x0400C3D2 RID: 50130
		private float cellSize_;

		// Token: 0x0400C3D3 RID: 50131
		public const int BoxFieldNumber = 4;

		// Token: 0x0400C3D4 RID: 50132
		private VoxelSpan box_;

		// Token: 0x0400C3D5 RID: 50133
		public const int IsOverlapFieldNumber = 3;

		// Token: 0x0400C3D6 RID: 50134
		private bool isOverlap_;
	}
}
