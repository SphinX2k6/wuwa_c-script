using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020006A0 RID: 1696
	public sealed class GachaReward : IMessage<GachaReward>, IMessage, IEquatable<GachaReward>, IDeepCloneable<GachaReward>, IBufferMessage
	{
		// Token: 0x06009B3C RID: 39740 RVA: 0x001768CD File Offset: 0x00174ACD
		[NullableContext(1)]
		public static GachaReward Create()
		{
			return new GachaReward();
		}

		// Token: 0x17001F10 RID: 7952
		// (get) Token: 0x06009B3D RID: 39741 RVA: 0x001768D4 File Offset: 0x00174AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<GachaReward> Parser
		{
			get
			{
				return GachaReward._parser;
			}
		}

		// Token: 0x17001F11 RID: 7953
		// (get) Token: 0x06009B3E RID: 39742 RVA: 0x001768DB File Offset: 0x00174ADB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001F12 RID: 7954
		// (get) Token: 0x06009B3F RID: 39743 RVA: 0x001768DE File Offset: 0x00174ADE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return GachaReward.Descriptor;
			}
		}

		// Token: 0x06009B40 RID: 39744 RVA: 0x001768E5 File Offset: 0x00174AE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaReward()
		{
		}

		// Token: 0x06009B41 RID: 39745 RVA: 0x001768ED File Offset: 0x00174AED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaReward(GachaReward other) : this()
		{
			this.itemId_ = other.itemId_;
			this.itemCount_ = other.itemCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009B42 RID: 39746 RVA: 0x0017691E File Offset: 0x00174B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public GachaReward Clone()
		{
			return new GachaReward(this);
		}

		// Token: 0x17001F13 RID: 7955
		// (get) Token: 0x06009B43 RID: 39747 RVA: 0x00176926 File Offset: 0x00174B26
		// (set) Token: 0x06009B44 RID: 39748 RVA: 0x0017692E File Offset: 0x00174B2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17001F14 RID: 7956
		// (get) Token: 0x06009B45 RID: 39749 RVA: 0x00176937 File Offset: 0x00174B37
		// (set) Token: 0x06009B46 RID: 39750 RVA: 0x0017693F File Offset: 0x00174B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemCount
		{
			get
			{
				return this.itemCount_;
			}
			set
			{
				this.itemCount_ = value;
			}
		}

		// Token: 0x06009B47 RID: 39751 RVA: 0x00176948 File Offset: 0x00174B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as GachaReward);
		}

		// Token: 0x06009B48 RID: 39752 RVA: 0x00176956 File Offset: 0x00174B56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(GachaReward other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.ItemCount == other.ItemCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009B49 RID: 39753 RVA: 0x00176994 File Offset: 0x00174B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.ItemCount != 0)
			{
				num ^= this.ItemCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009B4A RID: 39754 RVA: 0x001769EC File Offset: 0x00174BEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009B4B RID: 39755 RVA: 0x001769F9 File Offset: 0x00174BF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06009B4C RID: 39756 RVA: 0x00176A04 File Offset: 0x00174C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06009B4D RID: 39757 RVA: 0x00176A5C File Offset: 0x00174C5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.ItemCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06009B4E RID: 39758 RVA: 0x00176AB4 File Offset: 0x00174CB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(GachaReward other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.ItemCount != 0)
			{
				this.ItemCount = other.ItemCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06009B4F RID: 39759 RVA: 0x00176B04 File Offset: 0x00174D04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06009B50 RID: 39760 RVA: 0x00176B10 File Offset: 0x00174D10
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ItemCount = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004957 RID: 18775
		private static readonly MessageParser<GachaReward> _parser = new MessageParser<GachaReward>(() => new GachaReward());

		// Token: 0x04004958 RID: 18776
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004959 RID: 18777
		public const int ItemIdFieldNumber = 1;

		// Token: 0x0400495A RID: 18778
		private int itemId_;

		// Token: 0x0400495B RID: 18779
		public const int ItemCountFieldNumber = 2;

		// Token: 0x0400495C RID: 18780
		private int itemCount_;
	}
}
