using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001119 RID: 4377
	[NetMessage(EMessageId.RollBlockItemUpdateNotify)]
	public sealed class RollBlockItemUpdateNotify : IMessage<RollBlockItemUpdateNotify>, IMessage, IEquatable<RollBlockItemUpdateNotify>, IDeepCloneable<RollBlockItemUpdateNotify>, IBufferMessage
	{
		// Token: 0x06017648 RID: 95816 RVA: 0x00367599 File Offset: 0x00365799
		[NullableContext(1)]
		public static RollBlockItemUpdateNotify Create()
		{
			return new RollBlockItemUpdateNotify();
		}

		// Token: 0x17004E9C RID: 20124
		// (get) Token: 0x06017649 RID: 95817 RVA: 0x003675A0 File Offset: 0x003657A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004E9D RID: 20125
		// (get) Token: 0x0601764A RID: 95818 RVA: 0x003675A3 File Offset: 0x003657A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockItemUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601764B RID: 95819 RVA: 0x003675AA File Offset: 0x003657AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockItemUpdateNotify()
		{
		}

		// Token: 0x0601764C RID: 95820 RVA: 0x003675B4 File Offset: 0x003657B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockItemUpdateNotify(RollBlockItemUpdateNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.component_ = ((other.component_ != null) ? other.component_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601764D RID: 95821 RVA: 0x00367600 File Offset: 0x00365800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockItemUpdateNotify Clone()
		{
			return new RollBlockItemUpdateNotify(this);
		}

		// Token: 0x17004E9E RID: 20126
		// (get) Token: 0x0601764E RID: 95822 RVA: 0x00367608 File Offset: 0x00365808
		// (set) Token: 0x0601764F RID: 95823 RVA: 0x00367610 File Offset: 0x00365810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x17004E9F RID: 20127
		// (get) Token: 0x06017650 RID: 95824 RVA: 0x00367619 File Offset: 0x00365819
		// (set) Token: 0x06017651 RID: 95825 RVA: 0x00367621 File Offset: 0x00365821
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RbItemComponentPb Component
		{
			get
			{
				return this.component_;
			}
			set
			{
				this.component_ = value;
			}
		}

		// Token: 0x06017652 RID: 95826 RVA: 0x0036762A File Offset: 0x0036582A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockItemUpdateNotify);
		}

		// Token: 0x06017653 RID: 95827 RVA: 0x00367638 File Offset: 0x00365838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockItemUpdateNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.Component, other.Component) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017654 RID: 95828 RVA: 0x00367688 File Offset: 0x00365888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.component_ != null)
			{
				num ^= this.Component.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017655 RID: 95829 RVA: 0x003676DD File Offset: 0x003658DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017656 RID: 95830 RVA: 0x003676EA File Offset: 0x003658EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017657 RID: 95831 RVA: 0x003676F4 File Offset: 0x003658F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.component_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(this.Component);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017658 RID: 95832 RVA: 0x00367750 File Offset: 0x00365950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.component_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Component);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017659 RID: 95833 RVA: 0x003677A8 File Offset: 0x003659A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockItemUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.component_ != null)
			{
				if (this.component_ == null)
				{
					this.Component = new RbItemComponentPb();
				}
				this.Component.MergeFrom(other.Component);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601765A RID: 95834 RVA: 0x00367810 File Offset: 0x00365A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601765B RID: 95835 RVA: 0x0036781C File Offset: 0x00365A1C
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
				if (num != 58U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					if (this.component_ == null)
					{
						this.Component = new RbItemComponentPb();
					}
					input.ReadMessage(this.Component);
				}
			}
		}

		// Token: 0x04008BBA RID: 35770
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008BBB RID: 35771
		public const int EntityIdFieldNumber = 11;

		// Token: 0x04008BBC RID: 35772
		private long entityId_;

		// Token: 0x04008BBD RID: 35773
		public const int ComponentFieldNumber = 7;

		// Token: 0x04008BBE RID: 35774
		private RbItemComponentPb component_;
	}
}
