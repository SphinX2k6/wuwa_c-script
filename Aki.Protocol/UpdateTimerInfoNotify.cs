using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001524 RID: 5412
	[NetMessage(EMessageId.UpdateTimerInfoNotify)]
	public sealed class UpdateTimerInfoNotify : IMessage<UpdateTimerInfoNotify>, IMessage, IEquatable<UpdateTimerInfoNotify>, IDeepCloneable<UpdateTimerInfoNotify>, IBufferMessage
	{
		// Token: 0x0601CAB6 RID: 117430 RVA: 0x004276FC File Offset: 0x004258FC
		[NullableContext(1)]
		public static UpdateTimerInfoNotify Create()
		{
			return new UpdateTimerInfoNotify();
		}

		// Token: 0x170060F8 RID: 24824
		// (get) Token: 0x0601CAB7 RID: 117431 RVA: 0x00427703 File Offset: 0x00425903
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060F9 RID: 24825
		// (get) Token: 0x0601CAB8 RID: 117432 RVA: 0x00427706 File Offset: 0x00425906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateTimerInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601CAB9 RID: 117433 RVA: 0x0042770D File Offset: 0x0042590D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateTimerInfoNotify()
		{
		}

		// Token: 0x0601CABA RID: 117434 RVA: 0x00427718 File Offset: 0x00425918
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateTimerInfoNotify(UpdateTimerInfoNotify other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this.timerInfo_ = ((other.timerInfo_ != null) ? other.timerInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CABB RID: 117435 RVA: 0x00427770 File Offset: 0x00425970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateTimerInfoNotify Clone()
		{
			return new UpdateTimerInfoNotify(this);
		}

		// Token: 0x170060FA RID: 24826
		// (get) Token: 0x0601CABC RID: 117436 RVA: 0x00427778 File Offset: 0x00425978
		// (set) Token: 0x0601CABD RID: 117437 RVA: 0x00427780 File Offset: 0x00425980
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

		// Token: 0x170060FB RID: 24827
		// (get) Token: 0x0601CABE RID: 117438 RVA: 0x00427789 File Offset: 0x00425989
		// (set) Token: 0x0601CABF RID: 117439 RVA: 0x00427791 File Offset: 0x00425991
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

		// Token: 0x170060FC RID: 24828
		// (get) Token: 0x0601CAC0 RID: 117440 RVA: 0x0042779A File Offset: 0x0042599A
		// (set) Token: 0x0601CAC1 RID: 117441 RVA: 0x004277A2 File Offset: 0x004259A2
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

		// Token: 0x0601CAC2 RID: 117442 RVA: 0x004277AB File Offset: 0x004259AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateTimerInfoNotify);
		}

		// Token: 0x0601CAC3 RID: 117443 RVA: 0x004277BC File Offset: 0x004259BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateTimerInfoNotify other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && object.Equals(this.TimerInfo, other.TimerInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CAC4 RID: 117444 RVA: 0x0042781C File Offset: 0x00425A1C
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

		// Token: 0x0601CAC5 RID: 117445 RVA: 0x0042788A File Offset: 0x00425A8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CAC6 RID: 117446 RVA: 0x00427897 File Offset: 0x00425A97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CAC7 RID: 117447 RVA: 0x004278A0 File Offset: 0x00425AA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.timerInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.TimerInfo);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(72);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CAC8 RID: 117448 RVA: 0x00427918 File Offset: 0x00425B18
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

		// Token: 0x0601CAC9 RID: 117449 RVA: 0x00427988 File Offset: 0x00425B88
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

		// Token: 0x0601CACA RID: 117450 RVA: 0x00427A04 File Offset: 0x00425C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CACB RID: 117451 RVA: 0x00427A10 File Offset: 0x00425C10
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
				if (num != 32U)
				{
					if (num != 66U)
					{
						if (num != 72U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
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
				else
				{
					this.TreeOwnerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A523 RID: 42275
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A524 RID: 42276
		public const int TreeOwnerIdFieldNumber = 4;

		// Token: 0x0400A525 RID: 42277
		private int treeOwnerId_;

		// Token: 0x0400A526 RID: 42278
		public const int TreeIncIdFieldNumber = 9;

		// Token: 0x0400A527 RID: 42279
		private long treeIncId_;

		// Token: 0x0400A528 RID: 42280
		public const int TimerInfoFieldNumber = 8;

		// Token: 0x0400A529 RID: 42281
		private TimerInfoPb timerInfo_;
	}
}
