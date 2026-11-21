using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000117 RID: 279
	public sealed class ArtemisNodeInfo : IMessage<ArtemisNodeInfo>, IMessage, IEquatable<ArtemisNodeInfo>, IDeepCloneable<ArtemisNodeInfo>, IBufferMessage
	{
		// Token: 0x06002658 RID: 9816 RVA: 0x0006615E File Offset: 0x0006435E
		[NullableContext(1)]
		public static ArtemisNodeInfo Create()
		{
			return new ArtemisNodeInfo();
		}

		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x06002659 RID: 9817 RVA: 0x00066165 File Offset: 0x00064365
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000558 RID: 1368
		// (get) Token: 0x0600265A RID: 9818 RVA: 0x00066168 File Offset: 0x00064368
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ArtemisNodeInfo.Descriptor;
			}
		}

		// Token: 0x0600265B RID: 9819 RVA: 0x0006616F File Offset: 0x0006436F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeInfo()
		{
		}

		// Token: 0x0600265C RID: 9820 RVA: 0x00066177 File Offset: 0x00064377
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeInfo(ArtemisNodeInfo other) : this()
		{
			this.activityId_ = other.activityId_;
			this.index_ = other.index_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x000661B4 File Offset: 0x000643B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeInfo Clone()
		{
			return new ArtemisNodeInfo(this);
		}

		// Token: 0x17000559 RID: 1369
		// (get) Token: 0x0600265E RID: 9822 RVA: 0x000661BC File Offset: 0x000643BC
		// (set) Token: 0x0600265F RID: 9823 RVA: 0x000661C4 File Offset: 0x000643C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x1700055A RID: 1370
		// (get) Token: 0x06002660 RID: 9824 RVA: 0x000661CD File Offset: 0x000643CD
		// (set) Token: 0x06002661 RID: 9825 RVA: 0x000661D5 File Offset: 0x000643D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x06002662 RID: 9826 RVA: 0x000661DE File Offset: 0x000643DE
		// (set) Token: 0x06002663 RID: 9827 RVA: 0x000661E6 File Offset: 0x000643E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisState State
		{
			get
			{
				return this.state_;
			}
			set
			{
				this.state_ = value;
			}
		}

		// Token: 0x06002664 RID: 9828 RVA: 0x000661EF File Offset: 0x000643EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ArtemisNodeInfo);
		}

		// Token: 0x06002665 RID: 9829 RVA: 0x00066200 File Offset: 0x00064400
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ArtemisNodeInfo other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Index == other.Index && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002666 RID: 9830 RVA: 0x0006625C File Offset: 0x0006445C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.State != ArtemisState.ArtemisLocked)
			{
				num ^= this.State.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002667 RID: 9831 RVA: 0x000662D3 File Offset: 0x000644D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002668 RID: 9832 RVA: 0x000662E0 File Offset: 0x000644E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002669 RID: 9833 RVA: 0x000662EC File Offset: 0x000644EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ActivityId);
			}
			if (this.Index != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Index);
			}
			if (this.State != ArtemisState.ArtemisLocked)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.State);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600266A RID: 9834 RVA: 0x00066360 File Offset: 0x00064560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.State != ArtemisState.ArtemisLocked)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.State);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600266B RID: 9835 RVA: 0x000663D0 File Offset: 0x000645D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ArtemisNodeInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.State != ArtemisState.ArtemisLocked)
			{
				this.State = other.State;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600266C RID: 9836 RVA: 0x00066434 File Offset: 0x00064634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600266D RID: 9837 RVA: 0x00066440 File Offset: 0x00064640
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
							this.State = (ArtemisState)input.ReadEnum();
						}
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400265E RID: 9822
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400265F RID: 9823
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x04002660 RID: 9824
		private int activityId_;

		// Token: 0x04002661 RID: 9825
		public const int IndexFieldNumber = 2;

		// Token: 0x04002662 RID: 9826
		private int index_;

		// Token: 0x04002663 RID: 9827
		public const int StateFieldNumber = 3;

		// Token: 0x04002664 RID: 9828
		private ArtemisState state_;
	}
}
