using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200034E RID: 846
	public sealed class DangoBrawlEventSlotInfo : IMessage<DangoBrawlEventSlotInfo>, IMessage, IEquatable<DangoBrawlEventSlotInfo>, IDeepCloneable<DangoBrawlEventSlotInfo>, IBufferMessage
	{
		// Token: 0x060054C6 RID: 21702 RVA: 0x000CEBDC File Offset: 0x000CCDDC
		[NullableContext(1)]
		public static DangoBrawlEventSlotInfo Create()
		{
			return new DangoBrawlEventSlotInfo();
		}

		// Token: 0x17000F6D RID: 3949
		// (get) Token: 0x060054C7 RID: 21703 RVA: 0x000CEBE3 File Offset: 0x000CCDE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoBrawlEventSlotInfo> Parser
		{
			get
			{
				return DangoBrawlEventSlotInfo._parser;
			}
		}

		// Token: 0x17000F6E RID: 3950
		// (get) Token: 0x060054C8 RID: 21704 RVA: 0x000CEBEA File Offset: 0x000CCDEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F6F RID: 3951
		// (get) Token: 0x060054C9 RID: 21705 RVA: 0x000CEBED File Offset: 0x000CCDED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlEventSlotInfo.Descriptor;
			}
		}

		// Token: 0x060054CA RID: 21706 RVA: 0x000CEBF4 File Offset: 0x000CCDF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventSlotInfo()
		{
		}

		// Token: 0x060054CB RID: 21707 RVA: 0x000CEBFC File Offset: 0x000CCDFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventSlotInfo(DangoBrawlEventSlotInfo other) : this()
		{
			this.eventConfigId_ = other.eventConfigId_;
			this.refreshedCount_ = other.refreshedCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060054CC RID: 21708 RVA: 0x000CEC2D File Offset: 0x000CCE2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventSlotInfo Clone()
		{
			return new DangoBrawlEventSlotInfo(this);
		}

		// Token: 0x17000F70 RID: 3952
		// (get) Token: 0x060054CD RID: 21709 RVA: 0x000CEC35 File Offset: 0x000CCE35
		// (set) Token: 0x060054CE RID: 21710 RVA: 0x000CEC3D File Offset: 0x000CCE3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EventConfigId
		{
			get
			{
				return this.eventConfigId_;
			}
			set
			{
				this.eventConfigId_ = value;
			}
		}

		// Token: 0x17000F71 RID: 3953
		// (get) Token: 0x060054CF RID: 21711 RVA: 0x000CEC46 File Offset: 0x000CCE46
		// (set) Token: 0x060054D0 RID: 21712 RVA: 0x000CEC4E File Offset: 0x000CCE4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RefreshedCount
		{
			get
			{
				return this.refreshedCount_;
			}
			set
			{
				this.refreshedCount_ = value;
			}
		}

		// Token: 0x060054D1 RID: 21713 RVA: 0x000CEC57 File Offset: 0x000CCE57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlEventSlotInfo);
		}

		// Token: 0x060054D2 RID: 21714 RVA: 0x000CEC65 File Offset: 0x000CCE65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlEventSlotInfo other)
		{
			return other != null && (other == this || (this.EventConfigId == other.EventConfigId && this.RefreshedCount == other.RefreshedCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060054D3 RID: 21715 RVA: 0x000CECA4 File Offset: 0x000CCEA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EventConfigId != 0)
			{
				num ^= this.EventConfigId.GetHashCode();
			}
			if (this.RefreshedCount != 0)
			{
				num ^= this.RefreshedCount.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060054D4 RID: 21716 RVA: 0x000CECFC File Offset: 0x000CCEFC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060054D5 RID: 21717 RVA: 0x000CED09 File Offset: 0x000CCF09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060054D6 RID: 21718 RVA: 0x000CED14 File Offset: 0x000CCF14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EventConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EventConfigId);
			}
			if (this.RefreshedCount != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RefreshedCount);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060054D7 RID: 21719 RVA: 0x000CED6C File Offset: 0x000CCF6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EventConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EventConfigId);
			}
			if (this.RefreshedCount != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RefreshedCount);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060054D8 RID: 21720 RVA: 0x000CEDC4 File Offset: 0x000CCFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoBrawlEventSlotInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EventConfigId != 0)
			{
				this.EventConfigId = other.EventConfigId;
			}
			if (other.RefreshedCount != 0)
			{
				this.RefreshedCount = other.RefreshedCount;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060054D9 RID: 21721 RVA: 0x000CEE14 File Offset: 0x000CD014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060054DA RID: 21722 RVA: 0x000CEE20 File Offset: 0x000CD020
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
						this.RefreshedCount = input.ReadInt32();
					}
				}
				else
				{
					this.EventConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003434 RID: 13364
		private static readonly MessageParser<DangoBrawlEventSlotInfo> _parser = new MessageParser<DangoBrawlEventSlotInfo>(() => new DangoBrawlEventSlotInfo());

		// Token: 0x04003435 RID: 13365
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003436 RID: 13366
		public const int EventConfigIdFieldNumber = 1;

		// Token: 0x04003437 RID: 13367
		private int eventConfigId_;

		// Token: 0x04003438 RID: 13368
		public const int RefreshedCountFieldNumber = 2;

		// Token: 0x04003439 RID: 13369
		private int refreshedCount_;
	}
}
