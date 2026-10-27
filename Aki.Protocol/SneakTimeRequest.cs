using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200125F RID: 4703
	[NetMessage(EMessageId.SneakTimeRequest)]
	public sealed class SneakTimeRequest : IMessage<SneakTimeRequest>, IMessage, IEquatable<SneakTimeRequest>, IDeepCloneable<SneakTimeRequest>, IBufferMessage
	{
		// Token: 0x060190E9 RID: 102633 RVA: 0x003A5505 File Offset: 0x003A3705
		[NullableContext(1)]
		public static SneakTimeRequest Create()
		{
			return new SneakTimeRequest();
		}

		// Token: 0x17005483 RID: 21635
		// (get) Token: 0x060190EA RID: 102634 RVA: 0x003A550C File Offset: 0x003A370C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005484 RID: 21636
		// (get) Token: 0x060190EB RID: 102635 RVA: 0x003A550F File Offset: 0x003A370F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SneakTimeRequest.Descriptor;
			}
		}

		// Token: 0x060190EC RID: 102636 RVA: 0x003A5516 File Offset: 0x003A3716
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakTimeRequest()
		{
		}

		// Token: 0x060190ED RID: 102637 RVA: 0x003A551E File Offset: 0x003A371E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakTimeRequest(SneakTimeRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060190EE RID: 102638 RVA: 0x003A554F File Offset: 0x003A374F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakTimeRequest Clone()
		{
			return new SneakTimeRequest(this);
		}

		// Token: 0x17005485 RID: 21637
		// (get) Token: 0x060190EF RID: 102639 RVA: 0x003A5557 File Offset: 0x003A3757
		// (set) Token: 0x060190F0 RID: 102640 RVA: 0x003A555F File Offset: 0x003A375F
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

		// Token: 0x17005486 RID: 21638
		// (get) Token: 0x060190F1 RID: 102641 RVA: 0x003A5568 File Offset: 0x003A3768
		// (set) Token: 0x060190F2 RID: 102642 RVA: 0x003A5570 File Offset: 0x003A3770
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

		// Token: 0x060190F3 RID: 102643 RVA: 0x003A5579 File Offset: 0x003A3779
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SneakTimeRequest);
		}

		// Token: 0x060190F4 RID: 102644 RVA: 0x003A5587 File Offset: 0x003A3787
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SneakTimeRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060190F5 RID: 102645 RVA: 0x003A55C8 File Offset: 0x003A37C8
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
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060190F6 RID: 102646 RVA: 0x003A5620 File Offset: 0x003A3820
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060190F7 RID: 102647 RVA: 0x003A562D File Offset: 0x003A382D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060190F8 RID: 102648 RVA: 0x003A5638 File Offset: 0x003A3838
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.TreeIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060190F9 RID: 102649 RVA: 0x003A5694 File Offset: 0x003A3894
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
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060190FA RID: 102650 RVA: 0x003A56EC File Offset: 0x003A38EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SneakTimeRequest other)
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
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060190FB RID: 102651 RVA: 0x003A573C File Offset: 0x003A393C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060190FC RID: 102652 RVA: 0x003A5748 File Offset: 0x003A3948
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
				if (num != 16U)
				{
					if (num != 104U)
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
					this.TreeOwnerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400939E RID: 37790
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400939F RID: 37791
		public const int TreeOwnerIdFieldNumber = 2;

		// Token: 0x040093A0 RID: 37792
		private int treeOwnerId_;

		// Token: 0x040093A1 RID: 37793
		public const int TreeIncIdFieldNumber = 13;

		// Token: 0x040093A2 RID: 37794
		private long treeIncId_;
	}
}
