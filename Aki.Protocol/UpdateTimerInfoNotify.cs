using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014AE RID: 5294
	[NetMessage(EMessageId.UpdateTimerInfoNotify)]
	public sealed class UpdateTimerInfoNotify : IMessage<UpdateTimerInfoNotify>, IMessage, IEquatable<UpdateTimerInfoNotify>, IDeepCloneable<UpdateTimerInfoNotify>, IBufferMessage
	{
		// Token: 0x0601BFEF RID: 114671 RVA: 0x0040BC44 File Offset: 0x00409E44
		[NullableContext(1)]
		public static UpdateTimerInfoNotify Create()
		{
			return new UpdateTimerInfoNotify();
		}

		// Token: 0x17005E57 RID: 24151
		// (get) Token: 0x0601BFF0 RID: 114672 RVA: 0x0040BC4B File Offset: 0x00409E4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E58 RID: 24152
		// (get) Token: 0x0601BFF1 RID: 114673 RVA: 0x0040BC4E File Offset: 0x00409E4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateTimerInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601BFF2 RID: 114674 RVA: 0x0040BC55 File Offset: 0x00409E55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateTimerInfoNotify()
		{
		}

		// Token: 0x0601BFF3 RID: 114675 RVA: 0x0040BC60 File Offset: 0x00409E60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateTimerInfoNotify(UpdateTimerInfoNotify other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.timerInfo_ = ((other.timerInfo_ != null) ? other.timerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BFF4 RID: 114676 RVA: 0x0040BCB8 File Offset: 0x00409EB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateTimerInfoNotify Clone()
		{
			return new UpdateTimerInfoNotify(this);
		}

		// Token: 0x17005E59 RID: 24153
		// (get) Token: 0x0601BFF5 RID: 114677 RVA: 0x0040BCC0 File Offset: 0x00409EC0
		// (set) Token: 0x0601BFF6 RID: 114678 RVA: 0x0040BCC8 File Offset: 0x00409EC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeOwnerId
		{
			get
			{
				return this.treeOwnerId_;
			}
			set
			{
				this.treeOwnerId_ = value;
			}
		}

		// Token: 0x17005E5A RID: 24154
		// (get) Token: 0x0601BFF7 RID: 114679 RVA: 0x0040BCD1 File Offset: 0x00409ED1
		// (set) Token: 0x0601BFF8 RID: 114680 RVA: 0x0040BCD9 File Offset: 0x00409ED9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long TreeIncId
		{
			get
			{
				return this.treeIncId_;
			}
			set
			{
				this.treeIncId_ = value;
			}
		}

		// Token: 0x17005E5B RID: 24155
		// (get) Token: 0x0601BFF9 RID: 114681 RVA: 0x0040BCE2 File Offset: 0x00409EE2
		// (set) Token: 0x0601BFFA RID: 114682 RVA: 0x0040BCEA File Offset: 0x00409EEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TimerInfoPb TimerInfo
		{
			get
			{
				return this.timerInfo_;
			}
			set
			{
				this.timerInfo_ = value;
			}
		}

		// Token: 0x0601BFFB RID: 114683 RVA: 0x0040BCF3 File Offset: 0x00409EF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateTimerInfoNotify);
		}

		// Token: 0x0601BFFC RID: 114684 RVA: 0x0040BD04 File Offset: 0x00409F04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateTimerInfoNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && object.Equals(this.TimerInfo, other.TimerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BFFD RID: 114685 RVA: 0x0040BD64 File Offset: 0x00409F64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeOwnerId != 0)
			{
				num ^= this.TreeOwnerId.GetHashCode();
			}
			if (this.TreeIncId != 0L)
			{
				num ^= this.TreeIncId.GetHashCode();
			}
			if (this.timerInfo_ != null)
			{
				num ^= this.TimerInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BFFE RID: 114686 RVA: 0x0040BDD2 File Offset: 0x00409FD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BFFF RID: 114687 RVA: 0x0040BDDF File Offset: 0x00409FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C000 RID: 114688 RVA: 0x0040BDE8 File Offset: 0x00409FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.timerInfo_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(this.TimerInfo);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C001 RID: 114689 RVA: 0x0040BE60 File Offset: 0x0040A060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeOwnerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.TreeIncId);
			}
			if (this.timerInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.TimerInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C002 RID: 114690 RVA: 0x0040BED0 File Offset: 0x0040A0D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateTimerInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeOwnerId != 0)
			{
				this.TreeOwnerId = other.TreeOwnerId;
			}
			if (other.TreeIncId != 0L)
			{
				this.TreeIncId = other.TreeIncId;
			}
			if (other.timerInfo_ != null)
			{
				if (this.timerInfo_ == null)
				{
					this.TimerInfo = new TimerInfoPb();
				}
				this.TimerInfo.MergeFrom(other.TimerInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C003 RID: 114691 RVA: 0x0040BF4C File Offset: 0x0040A14C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C004 RID: 114692 RVA: 0x0040BF58 File Offset: 0x0040A158
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
				if (num != 34U)
				{
					if (num != 40U)
					{
						if (num != 80U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.TreeOwnerId = input.ReadInt32();
						}
					}
					else
					{
						this.TreeIncId = input.ReadInt64();
					}
				}
				else
				{
					if (this.timerInfo_ == null)
					{
						this.TimerInfo = new TimerInfoPb();
					}
					input.ReadMessage(this.TimerInfo);
				}
			}
		}

		// Token: 0x0400A0CA RID: 41162
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A0CB RID: 41163
		public const int TreeOwnerIdFieldNumber = 10;

		// Token: 0x0400A0CC RID: 41164
		private int treeOwnerId_;

		// Token: 0x0400A0CD RID: 41165
		public const int TreeIncIdFieldNumber = 5;

		// Token: 0x0400A0CE RID: 41166
		private long treeIncId_;

		// Token: 0x0400A0CF RID: 41167
		public const int TimerInfoFieldNumber = 4;

		// Token: 0x0400A0D0 RID: 41168
		private TimerInfoPb timerInfo_;
	}
}
