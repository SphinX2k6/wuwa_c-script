using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003B4 RID: 948
	[NetMessage(EMessageId.DarkTidePoisonCircleStopShrinkNotify)]
	public sealed class DarkTidePoisonCircleStopShrinkNotify : IMessage<DarkTidePoisonCircleStopShrinkNotify>, IMessage, IEquatable<DarkTidePoisonCircleStopShrinkNotify>, IDeepCloneable<DarkTidePoisonCircleStopShrinkNotify>, IBufferMessage
	{
		// Token: 0x06005D03 RID: 23811 RVA: 0x000E1DEC File Offset: 0x000DFFEC
		[NullableContext(1)]
		public static DarkTidePoisonCircleStopShrinkNotify Create()
		{
			return new DarkTidePoisonCircleStopShrinkNotify();
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x06005D04 RID: 23812 RVA: 0x000E1DF3 File Offset: 0x000DFFF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x06005D05 RID: 23813 RVA: 0x000E1DF6 File Offset: 0x000DFFF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DarkTidePoisonCircleStopShrinkNotify.Descriptor;
			}
		}

		// Token: 0x06005D06 RID: 23814 RVA: 0x000E1DFD File Offset: 0x000DFFFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTidePoisonCircleStopShrinkNotify()
		{
		}

		// Token: 0x06005D07 RID: 23815 RVA: 0x000E1E05 File Offset: 0x000E0005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTidePoisonCircleStopShrinkNotify(DarkTidePoisonCircleStopShrinkNotify other) : this()
		{
			this.currentPoisonCircleInfo_ = ((other.currentPoisonCircleInfo_ != null) ? other.currentPoisonCircleInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005D08 RID: 23816 RVA: 0x000E1E3A File Offset: 0x000E003A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DarkTidePoisonCircleStopShrinkNotify Clone()
		{
			return new DarkTidePoisonCircleStopShrinkNotify(this);
		}

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x06005D09 RID: 23817 RVA: 0x000E1E42 File Offset: 0x000E0042
		// (set) Token: 0x06005D0A RID: 23818 RVA: 0x000E1E4A File Offset: 0x000E004A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PoisonCircleSnapshotInfo CurrentPoisonCircleInfo
		{
			get
			{
				return this.currentPoisonCircleInfo_;
			}
			set
			{
				this.currentPoisonCircleInfo_ = value;
			}
		}

		// Token: 0x06005D0B RID: 23819 RVA: 0x000E1E53 File Offset: 0x000E0053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DarkTidePoisonCircleStopShrinkNotify);
		}

		// Token: 0x06005D0C RID: 23820 RVA: 0x000E1E61 File Offset: 0x000E0061
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DarkTidePoisonCircleStopShrinkNotify other)
		{
			return other != null && (other == this || (object.Equals(this.CurrentPoisonCircleInfo, other.CurrentPoisonCircleInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005D0D RID: 23821 RVA: 0x000E1E94 File Offset: 0x000E0094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.currentPoisonCircleInfo_ != null)
			{
				num ^= this.CurrentPoisonCircleInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06005D0E RID: 23822 RVA: 0x000E1ED0 File Offset: 0x000E00D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005D0F RID: 23823 RVA: 0x000E1EDD File Offset: 0x000E00DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005D10 RID: 23824 RVA: 0x000E1EE6 File Offset: 0x000E00E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.currentPoisonCircleInfo_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.CurrentPoisonCircleInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005D11 RID: 23825 RVA: 0x000E1F18 File Offset: 0x000E0118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.currentPoisonCircleInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.CurrentPoisonCircleInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06005D12 RID: 23826 RVA: 0x000E1F58 File Offset: 0x000E0158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DarkTidePoisonCircleStopShrinkNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.currentPoisonCircleInfo_ != null)
			{
				if (this.currentPoisonCircleInfo_ == null)
				{
					this.CurrentPoisonCircleInfo = new PoisonCircleSnapshotInfo();
				}
				this.CurrentPoisonCircleInfo.MergeFrom(other.CurrentPoisonCircleInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06005D13 RID: 23827 RVA: 0x000E1FAC File Offset: 0x000E01AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005D14 RID: 23828 RVA: 0x000E1FB8 File Offset: 0x000E01B8
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.currentPoisonCircleInfo_ == null)
					{
						this.CurrentPoisonCircleInfo = new PoisonCircleSnapshotInfo();
					}
					input.ReadMessage(this.CurrentPoisonCircleInfo);
				}
			}
		}

		// Token: 0x04003672 RID: 13938
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003673 RID: 13939
		public const int CurrentPoisonCircleInfoFieldNumber = 1;

		// Token: 0x04003674 RID: 13940
		private PoisonCircleSnapshotInfo currentPoisonCircleInfo_;
	}
}
