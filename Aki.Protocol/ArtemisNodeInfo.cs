using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000115 RID: 277
	public sealed class ArtemisNodeInfo : IMessage<ArtemisNodeInfo>, IMessage, IEquatable<ArtemisNodeInfo>, IDeepCloneable<ArtemisNodeInfo>, IBufferMessage
	{
		// Token: 0x060025F9 RID: 9721 RVA: 0x0006513A File Offset: 0x0006333A
		[NullableContext(1)]
		public static ArtemisNodeInfo Create()
		{
			return new ArtemisNodeInfo();
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x060025FA RID: 9722 RVA: 0x00065141 File Offset: 0x00063341
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060025FB RID: 9723 RVA: 0x00065144 File Offset: 0x00063344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ArtemisNodeInfo.Descriptor;
			}
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x0006514B File Offset: 0x0006334B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeInfo()
		{
		}

		// Token: 0x060025FD RID: 9725 RVA: 0x00065153 File Offset: 0x00063353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeInfo(ArtemisNodeInfo other) : this()
		{
			this.activityId_ = other.activityId_;
			this.index_ = other.index_;
			this.state_ = other.state_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060025FE RID: 9726 RVA: 0x00065190 File Offset: 0x00063390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ArtemisNodeInfo Clone()
		{
			return new ArtemisNodeInfo(this);
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x060025FF RID: 9727 RVA: 0x00065198 File Offset: 0x00063398
		// (set) Token: 0x06002600 RID: 9728 RVA: 0x000651A0 File Offset: 0x000633A0
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

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06002601 RID: 9729 RVA: 0x000651A9 File Offset: 0x000633A9
		// (set) Token: 0x06002602 RID: 9730 RVA: 0x000651B1 File Offset: 0x000633B1
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

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06002603 RID: 9731 RVA: 0x000651BA File Offset: 0x000633BA
		// (set) Token: 0x06002604 RID: 9732 RVA: 0x000651C2 File Offset: 0x000633C2
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

		// Token: 0x06002605 RID: 9733 RVA: 0x000651CB File Offset: 0x000633CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ArtemisNodeInfo);
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x000651DC File Offset: 0x000633DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ArtemisNodeInfo other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.Index == other.Index && this.State == other.State && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x00065238 File Offset: 0x00063438
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

		// Token: 0x06002608 RID: 9736 RVA: 0x000652AF File Offset: 0x000634AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x000652BC File Offset: 0x000634BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x000652C8 File Offset: 0x000634C8
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

		// Token: 0x0600260B RID: 9739 RVA: 0x0006533C File Offset: 0x0006353C
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

		// Token: 0x0600260C RID: 9740 RVA: 0x000653AC File Offset: 0x000635AC
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

		// Token: 0x0600260D RID: 9741 RVA: 0x00065410 File Offset: 0x00063610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x0006541C File Offset: 0x0006361C
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

		// Token: 0x040025F3 RID: 9715
		private UnknownFieldSet _unknownFields;

		// Token: 0x040025F4 RID: 9716
		public const int ActivityIdFieldNumber = 1;

		// Token: 0x040025F5 RID: 9717
		private int activityId_;

		// Token: 0x040025F6 RID: 9718
		public const int IndexFieldNumber = 2;

		// Token: 0x040025F7 RID: 9719
		private int index_;

		// Token: 0x040025F8 RID: 9720
		public const int StateFieldNumber = 3;

		// Token: 0x040025F9 RID: 9721
		private ArtemisState state_;
	}
}
