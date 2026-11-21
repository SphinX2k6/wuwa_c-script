using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003E2 RID: 994
	[NetMessage(EMessageId.DollGrabTimeBallRequest)]
	public sealed class DollGrabTimeBallRequest : IMessage<DollGrabTimeBallRequest>, IMessage, IEquatable<DollGrabTimeBallRequest>, IDeepCloneable<DollGrabTimeBallRequest>, IBufferMessage
	{
		// Token: 0x060060CB RID: 24779 RVA: 0x000E9CDD File Offset: 0x000E7EDD
		[NullableContext(1)]
		public static DollGrabTimeBallRequest Create()
		{
			return new DollGrabTimeBallRequest();
		}

		// Token: 0x17001200 RID: 4608
		// (get) Token: 0x060060CC RID: 24780 RVA: 0x000E9CE4 File Offset: 0x000E7EE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001201 RID: 4609
		// (get) Token: 0x060060CD RID: 24781 RVA: 0x000E9CE7 File Offset: 0x000E7EE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollGrabTimeBallRequest.Descriptor;
			}
		}

		// Token: 0x060060CE RID: 24782 RVA: 0x000E9CEE File Offset: 0x000E7EEE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabTimeBallRequest()
		{
		}

		// Token: 0x060060CF RID: 24783 RVA: 0x000E9CF6 File Offset: 0x000E7EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabTimeBallRequest(DollGrabTimeBallRequest other) : this()
		{
			this.entityIncId_ = other.entityIncId_;
			this.itemUniId_ = other.itemUniId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060060D0 RID: 24784 RVA: 0x000E9D27 File Offset: 0x000E7F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollGrabTimeBallRequest Clone()
		{
			return new DollGrabTimeBallRequest(this);
		}

		// Token: 0x17001202 RID: 4610
		// (get) Token: 0x060060D1 RID: 24785 RVA: 0x000E9D2F File Offset: 0x000E7F2F
		// (set) Token: 0x060060D2 RID: 24786 RVA: 0x000E9D37 File Offset: 0x000E7F37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityIncId
		{
			get
			{
				return this.entityIncId_;
			}
			set
			{
				this.entityIncId_ = value;
			}
		}

		// Token: 0x17001203 RID: 4611
		// (get) Token: 0x060060D3 RID: 24787 RVA: 0x000E9D40 File Offset: 0x000E7F40
		// (set) Token: 0x060060D4 RID: 24788 RVA: 0x000E9D48 File Offset: 0x000E7F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemUniId
		{
			get
			{
				return this.itemUniId_;
			}
			set
			{
				this.itemUniId_ = value;
			}
		}

		// Token: 0x060060D5 RID: 24789 RVA: 0x000E9D51 File Offset: 0x000E7F51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollGrabTimeBallRequest);
		}

		// Token: 0x060060D6 RID: 24790 RVA: 0x000E9D5F File Offset: 0x000E7F5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollGrabTimeBallRequest other)
		{
			return other != null && (other == this || (this.EntityIncId == other.EntityIncId && this.ItemUniId == other.ItemUniId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060060D7 RID: 24791 RVA: 0x000E9DA0 File Offset: 0x000E7FA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityIncId != 0L)
			{
				num ^= this.EntityIncId.GetHashCode();
			}
			if (this.ItemUniId != 0)
			{
				num ^= this.ItemUniId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060060D8 RID: 24792 RVA: 0x000E9DF8 File Offset: 0x000E7FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060060D9 RID: 24793 RVA: 0x000E9E05 File Offset: 0x000E8005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060060DA RID: 24794 RVA: 0x000E9E10 File Offset: 0x000E8010
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemUniId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ItemUniId);
			}
			if (this.EntityIncId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.EntityIncId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060060DB RID: 24795 RVA: 0x000E9E6C File Offset: 0x000E806C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityIncId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityIncId);
			}
			if (this.ItemUniId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemUniId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060060DC RID: 24796 RVA: 0x000E9EC4 File Offset: 0x000E80C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollGrabTimeBallRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityIncId != 0L)
			{
				this.EntityIncId = other.EntityIncId;
			}
			if (other.ItemUniId != 0)
			{
				this.ItemUniId = other.ItemUniId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060060DD RID: 24797 RVA: 0x000E9F14 File Offset: 0x000E8114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060060DE RID: 24798 RVA: 0x000E9F20 File Offset: 0x000E8120
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
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityIncId = input.ReadInt64();
					}
				}
				else
				{
					this.ItemUniId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040037C2 RID: 14274
		private UnknownFieldSet _unknownFields;

		// Token: 0x040037C3 RID: 14275
		public const int EntityIncIdFieldNumber = 5;

		// Token: 0x040037C4 RID: 14276
		private long entityIncId_;

		// Token: 0x040037C5 RID: 14277
		public const int ItemUniIdFieldNumber = 3;

		// Token: 0x040037C6 RID: 14278
		private int itemUniId_;
	}
}
