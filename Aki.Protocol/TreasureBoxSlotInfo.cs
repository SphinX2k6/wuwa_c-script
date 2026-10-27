using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001461 RID: 5217
	public sealed class TreasureBoxSlotInfo : IMessage<TreasureBoxSlotInfo>, IMessage, IEquatable<TreasureBoxSlotInfo>, IDeepCloneable<TreasureBoxSlotInfo>, IBufferMessage
	{
		// Token: 0x0601B9EA RID: 113130 RVA: 0x003FF401 File Offset: 0x003FD601
		[NullableContext(1)]
		public static TreasureBoxSlotInfo Create()
		{
			return new TreasureBoxSlotInfo();
		}

		// Token: 0x17005D1D RID: 23837
		// (get) Token: 0x0601B9EB RID: 113131 RVA: 0x003FF408 File Offset: 0x003FD608
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<TreasureBoxSlotInfo> Parser
		{
			get
			{
				return TreasureBoxSlotInfo._parser;
			}
		}

		// Token: 0x17005D1E RID: 23838
		// (get) Token: 0x0601B9EC RID: 113132 RVA: 0x003FF40F File Offset: 0x003FD60F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D1F RID: 23839
		// (get) Token: 0x0601B9ED RID: 113133 RVA: 0x003FF412 File Offset: 0x003FD612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TreasureBoxSlotInfo.Descriptor;
			}
		}

		// Token: 0x0601B9EE RID: 113134 RVA: 0x003FF419 File Offset: 0x003FD619
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureBoxSlotInfo()
		{
		}

		// Token: 0x0601B9EF RID: 113135 RVA: 0x003FF421 File Offset: 0x003FD621
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureBoxSlotInfo(TreasureBoxSlotInfo other) : this()
		{
			this.detectionSlotId_ = other.detectionSlotId_;
			this.markId_ = other.markId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B9F0 RID: 113136 RVA: 0x003FF452 File Offset: 0x003FD652
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TreasureBoxSlotInfo Clone()
		{
			return new TreasureBoxSlotInfo(this);
		}

		// Token: 0x17005D20 RID: 23840
		// (get) Token: 0x0601B9F1 RID: 113137 RVA: 0x003FF45A File Offset: 0x003FD65A
		// (set) Token: 0x0601B9F2 RID: 113138 RVA: 0x003FF462 File Offset: 0x003FD662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long DetectionSlotId
		{
			get
			{
				return this.detectionSlotId_;
			}
			set
			{
				this.detectionSlotId_ = value;
			}
		}

		// Token: 0x17005D21 RID: 23841
		// (get) Token: 0x0601B9F3 RID: 113139 RVA: 0x003FF46B File Offset: 0x003FD66B
		// (set) Token: 0x0601B9F4 RID: 113140 RVA: 0x003FF473 File Offset: 0x003FD673
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkId
		{
			get
			{
				return this.markId_;
			}
			set
			{
				this.markId_ = value;
			}
		}

		// Token: 0x0601B9F5 RID: 113141 RVA: 0x003FF47C File Offset: 0x003FD67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TreasureBoxSlotInfo);
		}

		// Token: 0x0601B9F6 RID: 113142 RVA: 0x003FF48A File Offset: 0x003FD68A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TreasureBoxSlotInfo other)
		{
			return other != null && (other == this || (this.DetectionSlotId == other.DetectionSlotId && this.MarkId == other.MarkId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B9F7 RID: 113143 RVA: 0x003FF4C8 File Offset: 0x003FD6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DetectionSlotId != 0L)
			{
				num ^= this.DetectionSlotId.GetHashCode();
			}
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B9F8 RID: 113144 RVA: 0x003FF520 File Offset: 0x003FD720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B9F9 RID: 113145 RVA: 0x003FF52D File Offset: 0x003FD72D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B9FA RID: 113146 RVA: 0x003FF538 File Offset: 0x003FD738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DetectionSlotId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.DetectionSlotId);
			}
			if (this.MarkId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B9FB RID: 113147 RVA: 0x003FF590 File Offset: 0x003FD790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DetectionSlotId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.DetectionSlotId);
			}
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B9FC RID: 113148 RVA: 0x003FF5E8 File Offset: 0x003FD7E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TreasureBoxSlotInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DetectionSlotId != 0L)
			{
				this.DetectionSlotId = other.DetectionSlotId;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B9FD RID: 113149 RVA: 0x003FF638 File Offset: 0x003FD838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B9FE RID: 113150 RVA: 0x003FF644 File Offset: 0x003FD844
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
						this.MarkId = input.ReadInt32();
					}
				}
				else
				{
					this.DetectionSlotId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009F22 RID: 40738
		private static readonly MessageParser<TreasureBoxSlotInfo> _parser = new MessageParser<TreasureBoxSlotInfo>(() => new TreasureBoxSlotInfo());

		// Token: 0x04009F23 RID: 40739
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F24 RID: 40740
		public const int DetectionSlotIdFieldNumber = 1;

		// Token: 0x04009F25 RID: 40741
		private long detectionSlotId_;

		// Token: 0x04009F26 RID: 40742
		public const int MarkIdFieldNumber = 2;

		// Token: 0x04009F27 RID: 40743
		private int markId_;
	}
}
