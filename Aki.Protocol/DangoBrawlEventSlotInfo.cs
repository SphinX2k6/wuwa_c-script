using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000346 RID: 838
	public sealed class DangoBrawlEventSlotInfo : IMessage<DangoBrawlEventSlotInfo>, IMessage, IEquatable<DangoBrawlEventSlotInfo>, IDeepCloneable<DangoBrawlEventSlotInfo>, IBufferMessage
	{
		// Token: 0x060053D9 RID: 21465 RVA: 0x000CC550 File Offset: 0x000CA750
		[NullableContext(1)]
		public static DangoBrawlEventSlotInfo Create()
		{
			return new DangoBrawlEventSlotInfo();
		}

		// Token: 0x17000F3C RID: 3900
		// (get) Token: 0x060053DA RID: 21466 RVA: 0x000CC557 File Offset: 0x000CA757
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<DangoBrawlEventSlotInfo> Parser
		{
			get
			{
				return DangoBrawlEventSlotInfo._parser;
			}
		}

		// Token: 0x17000F3D RID: 3901
		// (get) Token: 0x060053DB RID: 21467 RVA: 0x000CC55E File Offset: 0x000CA75E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000F3E RID: 3902
		// (get) Token: 0x060053DC RID: 21468 RVA: 0x000CC561 File Offset: 0x000CA761
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoBrawlEventSlotInfo.Descriptor;
			}
		}

		// Token: 0x060053DD RID: 21469 RVA: 0x000CC568 File Offset: 0x000CA768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventSlotInfo()
		{
		}

		// Token: 0x060053DE RID: 21470 RVA: 0x000CC570 File Offset: 0x000CA770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventSlotInfo(DangoBrawlEventSlotInfo other) : this()
		{
			this.eventConfigId_ = other.eventConfigId_;
			this.refreshedCount_ = other.refreshedCount_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060053DF RID: 21471 RVA: 0x000CC5A1 File Offset: 0x000CA7A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoBrawlEventSlotInfo Clone()
		{
			return new DangoBrawlEventSlotInfo(this);
		}

		// Token: 0x17000F3F RID: 3903
		// (get) Token: 0x060053E0 RID: 21472 RVA: 0x000CC5A9 File Offset: 0x000CA7A9
		// (set) Token: 0x060053E1 RID: 21473 RVA: 0x000CC5B1 File Offset: 0x000CA7B1
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

		// Token: 0x17000F40 RID: 3904
		// (get) Token: 0x060053E2 RID: 21474 RVA: 0x000CC5BA File Offset: 0x000CA7BA
		// (set) Token: 0x060053E3 RID: 21475 RVA: 0x000CC5C2 File Offset: 0x000CA7C2
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

		// Token: 0x060053E4 RID: 21476 RVA: 0x000CC5CB File Offset: 0x000CA7CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoBrawlEventSlotInfo);
		}

		// Token: 0x060053E5 RID: 21477 RVA: 0x000CC5D9 File Offset: 0x000CA7D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoBrawlEventSlotInfo other)
		{
			return other != null && (other == this || (this.EventConfigId == other.EventConfigId && this.RefreshedCount == other.RefreshedCount && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060053E6 RID: 21478 RVA: 0x000CC618 File Offset: 0x000CA818
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

		// Token: 0x060053E7 RID: 21479 RVA: 0x000CC670 File Offset: 0x000CA870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060053E8 RID: 21480 RVA: 0x000CC67D File Offset: 0x000CA87D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060053E9 RID: 21481 RVA: 0x000CC688 File Offset: 0x000CA888
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

		// Token: 0x060053EA RID: 21482 RVA: 0x000CC6E0 File Offset: 0x000CA8E0
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

		// Token: 0x060053EB RID: 21483 RVA: 0x000CC738 File Offset: 0x000CA938
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

		// Token: 0x060053EC RID: 21484 RVA: 0x000CC788 File Offset: 0x000CA988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060053ED RID: 21485 RVA: 0x000CC794 File Offset: 0x000CA994
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

		// Token: 0x04003398 RID: 13208
		private static readonly MessageParser<DangoBrawlEventSlotInfo> _parser = new MessageParser<DangoBrawlEventSlotInfo>(() => new DangoBrawlEventSlotInfo());

		// Token: 0x04003399 RID: 13209
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400339A RID: 13210
		public const int EventConfigIdFieldNumber = 1;

		// Token: 0x0400339B RID: 13211
		private int eventConfigId_;

		// Token: 0x0400339C RID: 13212
		public const int RefreshedCountFieldNumber = 2;

		// Token: 0x0400339D RID: 13213
		private int refreshedCount_;
	}
}
