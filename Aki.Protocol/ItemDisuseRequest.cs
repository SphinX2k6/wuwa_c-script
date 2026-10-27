using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000849 RID: 2121
	[NetMessage(EMessageId.ItemDisuseRequest)]
	public sealed class ItemDisuseRequest : IMessage<ItemDisuseRequest>, IMessage, IEquatable<ItemDisuseRequest>, IDeepCloneable<ItemDisuseRequest>, IBufferMessage
	{
		// Token: 0x0600BD41 RID: 48449 RVA: 0x001C20DF File Offset: 0x001C02DF
		[NullableContext(1)]
		public static ItemDisuseRequest Create()
		{
			return new ItemDisuseRequest();
		}

		// Token: 0x17002636 RID: 9782
		// (get) Token: 0x0600BD42 RID: 48450 RVA: 0x001C20E6 File Offset: 0x001C02E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002637 RID: 9783
		// (get) Token: 0x0600BD43 RID: 48451 RVA: 0x001C20E9 File Offset: 0x001C02E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ItemDisuseRequest.Descriptor;
			}
		}

		// Token: 0x0600BD44 RID: 48452 RVA: 0x001C20F0 File Offset: 0x001C02F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDisuseRequest()
		{
		}

		// Token: 0x0600BD45 RID: 48453 RVA: 0x001C20F8 File Offset: 0x001C02F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDisuseRequest(ItemDisuseRequest other) : this()
		{
			this.oper_ = other.oper_;
			this.incrId_ = other.incrId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BD46 RID: 48454 RVA: 0x001C2129 File Offset: 0x001C0329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ItemDisuseRequest Clone()
		{
			return new ItemDisuseRequest(this);
		}

		// Token: 0x17002638 RID: 9784
		// (get) Token: 0x0600BD47 RID: 48455 RVA: 0x001C2131 File Offset: 0x001C0331
		// (set) Token: 0x0600BD48 RID: 48456 RVA: 0x001C2139 File Offset: 0x001C0339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Oper
		{
			get
			{
				return this.oper_;
			}
			set
			{
				this.oper_ = value;
			}
		}

		// Token: 0x17002639 RID: 9785
		// (get) Token: 0x0600BD49 RID: 48457 RVA: 0x001C2142 File Offset: 0x001C0342
		// (set) Token: 0x0600BD4A RID: 48458 RVA: 0x001C214A File Offset: 0x001C034A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x0600BD4B RID: 48459 RVA: 0x001C2153 File Offset: 0x001C0353
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ItemDisuseRequest);
		}

		// Token: 0x0600BD4C RID: 48460 RVA: 0x001C2161 File Offset: 0x001C0361
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ItemDisuseRequest other)
		{
			return other != null && (other == this || (this.Oper == other.Oper && this.IncrId == other.IncrId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BD4D RID: 48461 RVA: 0x001C21A0 File Offset: 0x001C03A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Oper != 0)
			{
				num ^= this.Oper.GetHashCode();
			}
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600BD4E RID: 48462 RVA: 0x001C21F8 File Offset: 0x001C03F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BD4F RID: 48463 RVA: 0x001C2205 File Offset: 0x001C0405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BD50 RID: 48464 RVA: 0x001C2210 File Offset: 0x001C0410
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncrId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.IncrId);
			}
			if (this.Oper != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Oper);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BD51 RID: 48465 RVA: 0x001C226C File Offset: 0x001C046C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Oper != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Oper);
			}
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600BD52 RID: 48466 RVA: 0x001C22C4 File Offset: 0x001C04C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ItemDisuseRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Oper != 0)
			{
				this.Oper = other.Oper;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600BD53 RID: 48467 RVA: 0x001C2314 File Offset: 0x001C0514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BD54 RID: 48468 RVA: 0x001C2320 File Offset: 0x001C0520
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
				if (num != 56U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Oper = input.ReadInt32();
					}
				}
				else
				{
					this.IncrId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040052BB RID: 21179
		private UnknownFieldSet _unknownFields;

		// Token: 0x040052BC RID: 21180
		public const int OperFieldNumber = 10;

		// Token: 0x040052BD RID: 21181
		private int oper_;

		// Token: 0x040052BE RID: 21182
		public const int IncrIdFieldNumber = 7;

		// Token: 0x040052BF RID: 21183
		private int incrId_;
	}
}
