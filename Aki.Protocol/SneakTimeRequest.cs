using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200129C RID: 4764
	[NetMessage(EMessageId.SneakTimeRequest)]
	public sealed class SneakTimeRequest : IMessage<SneakTimeRequest>, IMessage, IEquatable<SneakTimeRequest>, IDeepCloneable<SneakTimeRequest>, IBufferMessage
	{
		// Token: 0x060196D3 RID: 104147 RVA: 0x003B545D File Offset: 0x003B365D
		[NullableContext(1)]
		public static SneakTimeRequest Create()
		{
			return new SneakTimeRequest();
		}

		// Token: 0x17005602 RID: 22018
		// (get) Token: 0x060196D4 RID: 104148 RVA: 0x003B5464 File Offset: 0x003B3664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005603 RID: 22019
		// (get) Token: 0x060196D5 RID: 104149 RVA: 0x003B5467 File Offset: 0x003B3667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SneakTimeRequest.Descriptor;
			}
		}

		// Token: 0x060196D6 RID: 104150 RVA: 0x003B546E File Offset: 0x003B366E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakTimeRequest()
		{
		}

		// Token: 0x060196D7 RID: 104151 RVA: 0x003B5476 File Offset: 0x003B3676
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakTimeRequest(SneakTimeRequest other) : this()
		{
			this.treeOwnerId_ = other.treeOwnerId_;
			this.treeIncId_ = other.treeIncId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060196D8 RID: 104152 RVA: 0x003B54A7 File Offset: 0x003B36A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SneakTimeRequest Clone()
		{
			return new SneakTimeRequest(this);
		}

		// Token: 0x17005604 RID: 22020
		// (get) Token: 0x060196D9 RID: 104153 RVA: 0x003B54AF File Offset: 0x003B36AF
		// (set) Token: 0x060196DA RID: 104154 RVA: 0x003B54B7 File Offset: 0x003B36B7
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

		// Token: 0x17005605 RID: 22021
		// (get) Token: 0x060196DB RID: 104155 RVA: 0x003B54C0 File Offset: 0x003B36C0
		// (set) Token: 0x060196DC RID: 104156 RVA: 0x003B54C8 File Offset: 0x003B36C8
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

		// Token: 0x060196DD RID: 104157 RVA: 0x003B54D1 File Offset: 0x003B36D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SneakTimeRequest);
		}

		// Token: 0x060196DE RID: 104158 RVA: 0x003B54DF File Offset: 0x003B36DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SneakTimeRequest other)
		{
			return other != null && (other == this || (this.TreeOwnerId == other.TreeOwnerId && this.TreeIncId == other.TreeIncId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060196DF RID: 104159 RVA: 0x003B5520 File Offset: 0x003B3720
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

		// Token: 0x060196E0 RID: 104160 RVA: 0x003B5578 File Offset: 0x003B3778
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060196E1 RID: 104161 RVA: 0x003B5585 File Offset: 0x003B3785
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060196E2 RID: 104162 RVA: 0x003B5590 File Offset: 0x003B3790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeIncId != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(this.TreeIncId);
			}
			if (this.TreeOwnerId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TreeOwnerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060196E3 RID: 104163 RVA: 0x003B55EC File Offset: 0x003B37EC
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

		// Token: 0x060196E4 RID: 104164 RVA: 0x003B5644 File Offset: 0x003B3844
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

		// Token: 0x060196E5 RID: 104165 RVA: 0x003B5694 File Offset: 0x003B3894
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060196E6 RID: 104166 RVA: 0x003B56A0 File Offset: 0x003B38A0
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
				if (num != 88U)
				{
					if (num != 104U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.TreeOwnerId = input.ReadInt32();
					}
				}
				else
				{
					this.TreeIncId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009650 RID: 38480
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009651 RID: 38481
		public const int TreeOwnerIdFieldNumber = 13;

		// Token: 0x04009652 RID: 38482
		private int treeOwnerId_;

		// Token: 0x04009653 RID: 38483
		public const int TreeIncIdFieldNumber = 11;

		// Token: 0x04009654 RID: 38484
		private long treeIncId_;
	}
}
