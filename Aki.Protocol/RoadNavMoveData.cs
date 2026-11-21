using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F65 RID: 3941
	public sealed class RoadNavMoveData : IMessage<RoadNavMoveData>, IMessage, IEquatable<RoadNavMoveData>, IDeepCloneable<RoadNavMoveData>, IBufferMessage
	{
		// Token: 0x0601518D RID: 86413 RVA: 0x0030F8D4 File Offset: 0x0030DAD4
		[NullableContext(1)]
		public static RoadNavMoveData Create()
		{
			return new RoadNavMoveData();
		}

		// Token: 0x17004632 RID: 17970
		// (get) Token: 0x0601518E RID: 86414 RVA: 0x0030F8DB File Offset: 0x0030DADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004633 RID: 17971
		// (get) Token: 0x0601518F RID: 86415 RVA: 0x0030F8DE File Offset: 0x0030DADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoadNavMoveData.Descriptor;
			}
		}

		// Token: 0x06015190 RID: 86416 RVA: 0x0030F8E5 File Offset: 0x0030DAE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNavMoveData()
		{
		}

		// Token: 0x06015191 RID: 86417 RVA: 0x0030F8F0 File Offset: 0x0030DAF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNavMoveData(RoadNavMoveData other) : this()
		{
			this.destRoadId_ = other.destRoadId_;
			this.destIndex_ = other.destIndex_;
			this.genRoadId_ = other.genRoadId_;
			this.genRoadIndex_ = other.genRoadIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015192 RID: 86418 RVA: 0x0030F944 File Offset: 0x0030DB44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoadNavMoveData Clone()
		{
			return new RoadNavMoveData(this);
		}

		// Token: 0x17004634 RID: 17972
		// (get) Token: 0x06015193 RID: 86419 RVA: 0x0030F94C File Offset: 0x0030DB4C
		// (set) Token: 0x06015194 RID: 86420 RVA: 0x0030F954 File Offset: 0x0030DB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DestRoadId
		{
			get
			{
				return this.destRoadId_;
			}
			set
			{
				this.destRoadId_ = value;
			}
		}

		// Token: 0x17004635 RID: 17973
		// (get) Token: 0x06015195 RID: 86421 RVA: 0x0030F95D File Offset: 0x0030DB5D
		// (set) Token: 0x06015196 RID: 86422 RVA: 0x0030F965 File Offset: 0x0030DB65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DestIndex
		{
			get
			{
				return this.destIndex_;
			}
			set
			{
				this.destIndex_ = value;
			}
		}

		// Token: 0x17004636 RID: 17974
		// (get) Token: 0x06015197 RID: 86423 RVA: 0x0030F96E File Offset: 0x0030DB6E
		// (set) Token: 0x06015198 RID: 86424 RVA: 0x0030F976 File Offset: 0x0030DB76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GenRoadId
		{
			get
			{
				return this.genRoadId_;
			}
			set
			{
				this.genRoadId_ = value;
			}
		}

		// Token: 0x17004637 RID: 17975
		// (get) Token: 0x06015199 RID: 86425 RVA: 0x0030F97F File Offset: 0x0030DB7F
		// (set) Token: 0x0601519A RID: 86426 RVA: 0x0030F987 File Offset: 0x0030DB87
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GenRoadIndex
		{
			get
			{
				return this.genRoadIndex_;
			}
			set
			{
				this.genRoadIndex_ = value;
			}
		}

		// Token: 0x0601519B RID: 86427 RVA: 0x0030F990 File Offset: 0x0030DB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoadNavMoveData);
		}

		// Token: 0x0601519C RID: 86428 RVA: 0x0030F9A0 File Offset: 0x0030DBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoadNavMoveData other)
		{
			return other != null && (other == this || (this.DestRoadId == other.DestRoadId && this.DestIndex == other.DestIndex && this.GenRoadId == other.GenRoadId && this.GenRoadIndex == other.GenRoadIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601519D RID: 86429 RVA: 0x0030FA0C File Offset: 0x0030DC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DestRoadId != 0)
			{
				num ^= this.DestRoadId.GetHashCode();
			}
			if (this.DestIndex != 0)
			{
				num ^= this.DestIndex.GetHashCode();
			}
			if (this.GenRoadId != 0)
			{
				num ^= this.GenRoadId.GetHashCode();
			}
			if (this.GenRoadIndex != 0)
			{
				num ^= this.GenRoadIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601519E RID: 86430 RVA: 0x0030FA96 File Offset: 0x0030DC96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601519F RID: 86431 RVA: 0x0030FAA3 File Offset: 0x0030DCA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060151A0 RID: 86432 RVA: 0x0030FAAC File Offset: 0x0030DCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DestRoadId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DestRoadId);
			}
			if (this.DestIndex != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.DestIndex);
			}
			if (this.GenRoadId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.GenRoadId);
			}
			if (this.GenRoadIndex != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.GenRoadIndex);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060151A1 RID: 86433 RVA: 0x0030FB3C File Offset: 0x0030DD3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DestRoadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DestRoadId);
			}
			if (this.DestIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DestIndex);
			}
			if (this.GenRoadId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GenRoadId);
			}
			if (this.GenRoadIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GenRoadIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060151A2 RID: 86434 RVA: 0x0030FBC4 File Offset: 0x0030DDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoadNavMoveData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DestRoadId != 0)
			{
				this.DestRoadId = other.DestRoadId;
			}
			if (other.DestIndex != 0)
			{
				this.DestIndex = other.DestIndex;
			}
			if (other.GenRoadId != 0)
			{
				this.GenRoadId = other.GenRoadId;
			}
			if (other.GenRoadIndex != 0)
			{
				this.GenRoadIndex = other.GenRoadIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060151A3 RID: 86435 RVA: 0x0030FC3C File Offset: 0x0030DE3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060151A4 RID: 86436 RVA: 0x0030FC48 File Offset: 0x0030DE48
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.DestRoadId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.DestIndex = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.GenRoadId = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.GenRoadIndex = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007F62 RID: 32610
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007F63 RID: 32611
		public const int DestRoadIdFieldNumber = 1;

		// Token: 0x04007F64 RID: 32612
		private int destRoadId_;

		// Token: 0x04007F65 RID: 32613
		public const int DestIndexFieldNumber = 2;

		// Token: 0x04007F66 RID: 32614
		private int destIndex_;

		// Token: 0x04007F67 RID: 32615
		public const int GenRoadIdFieldNumber = 3;

		// Token: 0x04007F68 RID: 32616
		private int genRoadId_;

		// Token: 0x04007F69 RID: 32617
		public const int GenRoadIndexFieldNumber = 4;

		// Token: 0x04007F6A RID: 32618
		private int genRoadIndex_;
	}
}
