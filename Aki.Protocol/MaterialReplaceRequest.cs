using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009CC RID: 2508
	[NetMessage(EMessageId.MaterialReplaceRequest)]
	public sealed class MaterialReplaceRequest : IMessage<MaterialReplaceRequest>, IMessage, IEquatable<MaterialReplaceRequest>, IDeepCloneable<MaterialReplaceRequest>, IBufferMessage
	{
		// Token: 0x0600DC05 RID: 56325 RVA: 0x00204FCA File Offset: 0x002031CA
		[NullableContext(1)]
		public static MaterialReplaceRequest Create()
		{
			return new MaterialReplaceRequest();
		}

		// Token: 0x17002C9B RID: 11419
		// (get) Token: 0x0600DC06 RID: 56326 RVA: 0x00204FD1 File Offset: 0x002031D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C9C RID: 11420
		// (get) Token: 0x0600DC07 RID: 56327 RVA: 0x00204FD4 File Offset: 0x002031D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MaterialReplaceRequest.Descriptor;
			}
		}

		// Token: 0x0600DC08 RID: 56328 RVA: 0x00204FDB File Offset: 0x002031DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialReplaceRequest()
		{
		}

		// Token: 0x0600DC09 RID: 56329 RVA: 0x00204FE3 File Offset: 0x002031E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialReplaceRequest(MaterialReplaceRequest other) : this()
		{
			this.targetReplaceItemId_ = other.targetReplaceItemId_;
			this.consumeItemId_ = other.consumeItemId_;
			this.consumeItemNum_ = other.consumeItemNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DC0A RID: 56330 RVA: 0x00205020 File Offset: 0x00203220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialReplaceRequest Clone()
		{
			return new MaterialReplaceRequest(this);
		}

		// Token: 0x17002C9D RID: 11421
		// (get) Token: 0x0600DC0B RID: 56331 RVA: 0x00205028 File Offset: 0x00203228
		// (set) Token: 0x0600DC0C RID: 56332 RVA: 0x00205030 File Offset: 0x00203230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TargetReplaceItemId
		{
			get
			{
				return this.targetReplaceItemId_;
			}
			set
			{
				this.targetReplaceItemId_ = value;
			}
		}

		// Token: 0x17002C9E RID: 11422
		// (get) Token: 0x0600DC0D RID: 56333 RVA: 0x00205039 File Offset: 0x00203239
		// (set) Token: 0x0600DC0E RID: 56334 RVA: 0x00205041 File Offset: 0x00203241
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConsumeItemId
		{
			get
			{
				return this.consumeItemId_;
			}
			set
			{
				this.consumeItemId_ = value;
			}
		}

		// Token: 0x17002C9F RID: 11423
		// (get) Token: 0x0600DC0F RID: 56335 RVA: 0x0020504A File Offset: 0x0020324A
		// (set) Token: 0x0600DC10 RID: 56336 RVA: 0x00205052 File Offset: 0x00203252
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConsumeItemNum
		{
			get
			{
				return this.consumeItemNum_;
			}
			set
			{
				this.consumeItemNum_ = value;
			}
		}

		// Token: 0x0600DC11 RID: 56337 RVA: 0x0020505B File Offset: 0x0020325B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MaterialReplaceRequest);
		}

		// Token: 0x0600DC12 RID: 56338 RVA: 0x0020506C File Offset: 0x0020326C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MaterialReplaceRequest other)
		{
			return other != null && (other == this || (this.TargetReplaceItemId == other.TargetReplaceItemId && this.ConsumeItemId == other.ConsumeItemId && this.ConsumeItemNum == other.ConsumeItemNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DC13 RID: 56339 RVA: 0x002050C8 File Offset: 0x002032C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TargetReplaceItemId != 0)
			{
				num ^= this.TargetReplaceItemId.GetHashCode();
			}
			if (this.ConsumeItemId != 0)
			{
				num ^= this.ConsumeItemId.GetHashCode();
			}
			if (this.ConsumeItemNum != 0)
			{
				num ^= this.ConsumeItemNum.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DC14 RID: 56340 RVA: 0x00205139 File Offset: 0x00203339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DC15 RID: 56341 RVA: 0x00205146 File Offset: 0x00203346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DC16 RID: 56342 RVA: 0x00205150 File Offset: 0x00203350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TargetReplaceItemId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.TargetReplaceItemId);
			}
			if (this.ConsumeItemId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ConsumeItemId);
			}
			if (this.ConsumeItemNum != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.ConsumeItemNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DC17 RID: 56343 RVA: 0x002051C8 File Offset: 0x002033C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TargetReplaceItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TargetReplaceItemId);
			}
			if (this.ConsumeItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConsumeItemId);
			}
			if (this.ConsumeItemNum != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConsumeItemNum);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DC18 RID: 56344 RVA: 0x00205238 File Offset: 0x00203438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MaterialReplaceRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TargetReplaceItemId != 0)
			{
				this.TargetReplaceItemId = other.TargetReplaceItemId;
			}
			if (other.ConsumeItemId != 0)
			{
				this.ConsumeItemId = other.ConsumeItemId;
			}
			if (other.ConsumeItemNum != 0)
			{
				this.ConsumeItemNum = other.ConsumeItemNum;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DC19 RID: 56345 RVA: 0x0020529C File Offset: 0x0020349C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DC1A RID: 56346 RVA: 0x002052A8 File Offset: 0x002034A8
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
				if (num != 40U)
				{
					if (num != 56U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ConsumeItemNum = input.ReadInt32();
						}
					}
					else
					{
						this.ConsumeItemId = input.ReadInt32();
					}
				}
				else
				{
					this.TargetReplaceItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005B3B RID: 23355
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B3C RID: 23356
		public const int TargetReplaceItemIdFieldNumber = 5;

		// Token: 0x04005B3D RID: 23357
		private int targetReplaceItemId_;

		// Token: 0x04005B3E RID: 23358
		public const int ConsumeItemIdFieldNumber = 7;

		// Token: 0x04005B3F RID: 23359
		private int consumeItemId_;

		// Token: 0x04005B40 RID: 23360
		public const int ConsumeItemNumFieldNumber = 11;

		// Token: 0x04005B41 RID: 23361
		private int consumeItemNum_;
	}
}
