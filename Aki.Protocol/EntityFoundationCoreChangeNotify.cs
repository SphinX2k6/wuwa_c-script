using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200048F RID: 1167
	[NetMessage(EMessageId.EntityFoundationCoreChangeNotify)]
	public sealed class EntityFoundationCoreChangeNotify : IMessage<EntityFoundationCoreChangeNotify>, IMessage, IEquatable<EntityFoundationCoreChangeNotify>, IDeepCloneable<EntityFoundationCoreChangeNotify>, IBufferMessage
	{
		// Token: 0x06006F93 RID: 28563 RVA: 0x00111D60 File Offset: 0x0010FF60
		[NullableContext(1)]
		public static EntityFoundationCoreChangeNotify Create()
		{
			return new EntityFoundationCoreChangeNotify();
		}

		// Token: 0x17001579 RID: 5497
		// (get) Token: 0x06006F94 RID: 28564 RVA: 0x00111D67 File Offset: 0x0010FF67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700157A RID: 5498
		// (get) Token: 0x06006F95 RID: 28565 RVA: 0x00111D6A File Offset: 0x0010FF6A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityFoundationCoreChangeNotify.Descriptor;
			}
		}

		// Token: 0x06006F96 RID: 28566 RVA: 0x00111D71 File Offset: 0x0010FF71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFoundationCoreChangeNotify()
		{
		}

		// Token: 0x06006F97 RID: 28567 RVA: 0x00111D7C File Offset: 0x0010FF7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFoundationCoreChangeNotify(EntityFoundationCoreChangeNotify other) : this()
		{
			this.foundationEntityId_ = other.foundationEntityId_;
			this.hasFoundationCore_ = other.hasFoundationCore_;
			this.foundationCoreInfo_ = ((other.foundationCoreInfo_ != null) ? other.foundationCoreInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006F98 RID: 28568 RVA: 0x00111DD4 File Offset: 0x0010FFD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityFoundationCoreChangeNotify Clone()
		{
			return new EntityFoundationCoreChangeNotify(this);
		}

		// Token: 0x1700157B RID: 5499
		// (get) Token: 0x06006F99 RID: 28569 RVA: 0x00111DDC File Offset: 0x0010FFDC
		// (set) Token: 0x06006F9A RID: 28570 RVA: 0x00111DE4 File Offset: 0x0010FFE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FoundationEntityId
		{
			get
			{
				return this.foundationEntityId_;
			}
			set
			{
				this.foundationEntityId_ = value;
			}
		}

		// Token: 0x1700157C RID: 5500
		// (get) Token: 0x06006F9B RID: 28571 RVA: 0x00111DED File Offset: 0x0010FFED
		// (set) Token: 0x06006F9C RID: 28572 RVA: 0x00111DF5 File Offset: 0x0010FFF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasFoundationCore
		{
			get
			{
				return this.hasFoundationCore_;
			}
			set
			{
				this.hasFoundationCore_ = value;
			}
		}

		// Token: 0x1700157D RID: 5501
		// (get) Token: 0x06006F9D RID: 28573 RVA: 0x00111DFE File Offset: 0x0010FFFE
		// (set) Token: 0x06006F9E RID: 28574 RVA: 0x00111E06 File Offset: 0x00110006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FoundationCoreInfo FoundationCoreInfo
		{
			get
			{
				return this.foundationCoreInfo_;
			}
			set
			{
				this.foundationCoreInfo_ = value;
			}
		}

		// Token: 0x06006F9F RID: 28575 RVA: 0x00111E0F File Offset: 0x0011000F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityFoundationCoreChangeNotify);
		}

		// Token: 0x06006FA0 RID: 28576 RVA: 0x00111E20 File Offset: 0x00110020
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityFoundationCoreChangeNotify other)
		{
			return other != null && (other == this || (this.FoundationEntityId == other.FoundationEntityId && this.HasFoundationCore == other.HasFoundationCore && object.Equals(this.FoundationCoreInfo, other.FoundationCoreInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006FA1 RID: 28577 RVA: 0x00111E80 File Offset: 0x00110080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.FoundationEntityId != 0)
			{
				num ^= this.FoundationEntityId.GetHashCode();
			}
			if (this.HasFoundationCore)
			{
				num ^= this.HasFoundationCore.GetHashCode();
			}
			if (this.foundationCoreInfo_ != null)
			{
				num ^= this.FoundationCoreInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006FA2 RID: 28578 RVA: 0x00111EEE File Offset: 0x001100EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006FA3 RID: 28579 RVA: 0x00111EFB File Offset: 0x001100FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006FA4 RID: 28580 RVA: 0x00111F04 File Offset: 0x00110104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.FoundationEntityId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FoundationEntityId);
			}
			if (this.foundationCoreInfo_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(this.FoundationCoreInfo);
			}
			if (this.HasFoundationCore)
			{
				output.WriteRawTag(88);
				output.WriteBool(this.HasFoundationCore);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006FA5 RID: 28581 RVA: 0x00111F7C File Offset: 0x0011017C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.FoundationEntityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FoundationEntityId);
			}
			if (this.HasFoundationCore)
			{
				num += 2;
			}
			if (this.foundationCoreInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FoundationCoreInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006FA6 RID: 28582 RVA: 0x00111FE0 File Offset: 0x001101E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityFoundationCoreChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.FoundationEntityId != 0)
			{
				this.FoundationEntityId = other.FoundationEntityId;
			}
			if (other.HasFoundationCore)
			{
				this.HasFoundationCore = other.HasFoundationCore;
			}
			if (other.foundationCoreInfo_ != null)
			{
				if (this.foundationCoreInfo_ == null)
				{
					this.FoundationCoreInfo = new FoundationCoreInfo();
				}
				this.FoundationCoreInfo.MergeFrom(other.FoundationCoreInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006FA7 RID: 28583 RVA: 0x0011205C File Offset: 0x0011025C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006FA8 RID: 28584 RVA: 0x00112068 File Offset: 0x00110268
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
					if (num != 66U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.HasFoundationCore = input.ReadBool();
						}
					}
					else
					{
						if (this.foundationCoreInfo_ == null)
						{
							this.FoundationCoreInfo = new FoundationCoreInfo();
						}
						input.ReadMessage(this.FoundationCoreInfo);
					}
				}
				else
				{
					this.FoundationEntityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003BF5 RID: 15349
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003BF6 RID: 15350
		public const int FoundationEntityIdFieldNumber = 3;

		// Token: 0x04003BF7 RID: 15351
		private int foundationEntityId_;

		// Token: 0x04003BF8 RID: 15352
		public const int HasFoundationCoreFieldNumber = 11;

		// Token: 0x04003BF9 RID: 15353
		private bool hasFoundationCore_;

		// Token: 0x04003BFA RID: 15354
		public const int FoundationCoreInfoFieldNumber = 8;

		// Token: 0x04003BFB RID: 15355
		private FoundationCoreInfo foundationCoreInfo_;
	}
}
