using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003B3 RID: 947
	[NetMessage(EMessageId.DarkTidePoisonCircleStartShrinkNotify)]
	public sealed class DarkTidePoisonCircleStartShrinkNotify : IMessage<DarkTidePoisonCircleStartShrinkNotify>, IMessage, IEquatable<DarkTidePoisonCircleStartShrinkNotify>, IDeepCloneable<DarkTidePoisonCircleStartShrinkNotify>, IBufferMessage
	{
		// Token: 0x06005CED RID: 23789 RVA: 0x000E1A18 File Offset: 0x000DFC18
		[NullableContext(1)]
		public static DarkTidePoisonCircleStartShrinkNotify Create()
		{
			return new DarkTidePoisonCircleStartShrinkNotify();
		}

		// Token: 0x1700113F RID: 4415
		// (get) Token: 0x06005CEE RID: 23790 RVA: 0x000E1A1F File Offset: 0x000DFC1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x06005CEF RID: 23791 RVA: 0x000E1A22 File Offset: 0x000DFC22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTidePoisonCircleStartShrinkNotify.Descriptor;
			}
		}

		// Token: 0x06005CF0 RID: 23792 RVA: 0x000E1A29 File Offset: 0x000DFC29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTidePoisonCircleStartShrinkNotify()
		{
		}

		// Token: 0x06005CF1 RID: 23793 RVA: 0x000E1A34 File Offset: 0x000DFC34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTidePoisonCircleStartShrinkNotify(DarkTidePoisonCircleStartShrinkNotify other) : this()
		{
			this.fromPoisonCircleInfo_ = ((other.fromPoisonCircleInfo_ != null) ? other.fromPoisonCircleInfo_.Clone() : null);
			this.toPoisonCircleInfo_ = ((other.toPoisonCircleInfo_ != null) ? other.toPoisonCircleInfo_.Clone() : null);
			this.startTimestamp_ = other.startTimestamp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005CF2 RID: 23794 RVA: 0x000E1A9C File Offset: 0x000DFC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTidePoisonCircleStartShrinkNotify Clone()
		{
			return new DarkTidePoisonCircleStartShrinkNotify(this);
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x06005CF3 RID: 23795 RVA: 0x000E1AA4 File Offset: 0x000DFCA4
		// (set) Token: 0x06005CF4 RID: 23796 RVA: 0x000E1AAC File Offset: 0x000DFCAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PoisonCircleSnapshotInfo FromPoisonCircleInfo
		{
			get
			{
				return this.fromPoisonCircleInfo_;
			}
			set
			{
				this.fromPoisonCircleInfo_ = value;
			}
		}

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x06005CF5 RID: 23797 RVA: 0x000E1AB5 File Offset: 0x000DFCB5
		// (set) Token: 0x06005CF6 RID: 23798 RVA: 0x000E1ABD File Offset: 0x000DFCBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PoisonCircleSnapshotInfo ToPoisonCircleInfo
		{
			get
			{
				return this.toPoisonCircleInfo_;
			}
			set
			{
				this.toPoisonCircleInfo_ = value;
			}
		}

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x06005CF7 RID: 23799 RVA: 0x000E1AC6 File Offset: 0x000DFCC6
		// (set) Token: 0x06005CF8 RID: 23800 RVA: 0x000E1ACE File Offset: 0x000DFCCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long StartTimestamp
		{
			get
			{
				return this.startTimestamp_;
			}
			set
			{
				this.startTimestamp_ = value;
			}
		}

		// Token: 0x06005CF9 RID: 23801 RVA: 0x000E1AD7 File Offset: 0x000DFCD7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTidePoisonCircleStartShrinkNotify);
		}

		// Token: 0x06005CFA RID: 23802 RVA: 0x000E1AE8 File Offset: 0x000DFCE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTidePoisonCircleStartShrinkNotify other)
		{
			return other != null && (other == this || (object.Equals(this.FromPoisonCircleInfo, other.FromPoisonCircleInfo) && object.Equals(this.ToPoisonCircleInfo, other.ToPoisonCircleInfo) && this.StartTimestamp == other.StartTimestamp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005CFB RID: 23803 RVA: 0x000E1B4C File Offset: 0x000DFD4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.fromPoisonCircleInfo_ != null)
			{
				num ^= this.FromPoisonCircleInfo.GetHashCode();
			}
			if (this.toPoisonCircleInfo_ != null)
			{
				num ^= this.ToPoisonCircleInfo.GetHashCode();
			}
			if (this.StartTimestamp != 0L)
			{
				num ^= this.StartTimestamp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005CFC RID: 23804 RVA: 0x000E1BB7 File Offset: 0x000DFDB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005CFD RID: 23805 RVA: 0x000E1BC4 File Offset: 0x000DFDC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005CFE RID: 23806 RVA: 0x000E1BD0 File Offset: 0x000DFDD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.fromPoisonCircleInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.FromPoisonCircleInfo);
			}
			if (this.StartTimestamp != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(this.StartTimestamp);
			}
			if (this.toPoisonCircleInfo_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.ToPoisonCircleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005CFF RID: 23807 RVA: 0x000E1C48 File Offset: 0x000DFE48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.fromPoisonCircleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FromPoisonCircleInfo);
			}
			if (this.toPoisonCircleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ToPoisonCircleInfo);
			}
			if (this.StartTimestamp != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.StartTimestamp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D00 RID: 23808 RVA: 0x000E1CB8 File Offset: 0x000DFEB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTidePoisonCircleStartShrinkNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.fromPoisonCircleInfo_ != null)
			{
				if (this.fromPoisonCircleInfo_ == null)
				{
					this.FromPoisonCircleInfo = new PoisonCircleSnapshotInfo();
				}
				this.FromPoisonCircleInfo.MergeFrom(other.FromPoisonCircleInfo);
			}
			if (other.toPoisonCircleInfo_ != null)
			{
				if (this.toPoisonCircleInfo_ == null)
				{
					this.ToPoisonCircleInfo = new PoisonCircleSnapshotInfo();
				}
				this.ToPoisonCircleInfo.MergeFrom(other.ToPoisonCircleInfo);
			}
			if (other.StartTimestamp != 0L)
			{
				this.StartTimestamp = other.StartTimestamp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005D01 RID: 23809 RVA: 0x000E1D4C File Offset: 0x000DFF4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D02 RID: 23810 RVA: 0x000E1D58 File Offset: 0x000DFF58
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
				if (num != 10U)
				{
					if (num != 32U)
					{
						if (num != 58U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							if (this.toPoisonCircleInfo_ == null)
							{
								this.ToPoisonCircleInfo = new PoisonCircleSnapshotInfo();
							}
							input.ReadMessage(this.ToPoisonCircleInfo);
						}
					}
					else
					{
						this.StartTimestamp = input.ReadInt64();
					}
				}
				else
				{
					if (this.fromPoisonCircleInfo_ == null)
					{
						this.FromPoisonCircleInfo = new PoisonCircleSnapshotInfo();
					}
					input.ReadMessage(this.FromPoisonCircleInfo);
				}
			}
		}

		// Token: 0x0400366B RID: 13931
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400366C RID: 13932
		public const int FromPoisonCircleInfoFieldNumber = 1;

		// Token: 0x0400366D RID: 13933
		private PoisonCircleSnapshotInfo fromPoisonCircleInfo_;

		// Token: 0x0400366E RID: 13934
		public const int ToPoisonCircleInfoFieldNumber = 7;

		// Token: 0x0400366F RID: 13935
		private PoisonCircleSnapshotInfo toPoisonCircleInfo_;

		// Token: 0x04003670 RID: 13936
		public const int StartTimestampFieldNumber = 4;

		// Token: 0x04003671 RID: 13937
		private long startTimestamp_;
	}
}
