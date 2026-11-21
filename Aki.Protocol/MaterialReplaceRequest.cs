using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009BB RID: 2491
	[NetMessage(EMessageId.MaterialReplaceRequest)]
	public sealed class MaterialReplaceRequest : IMessage<MaterialReplaceRequest>, IMessage, IEquatable<MaterialReplaceRequest>, IDeepCloneable<MaterialReplaceRequest>, IBufferMessage
	{
		// Token: 0x0600DAEB RID: 56043 RVA: 0x00202DD2 File Offset: 0x00200FD2
		[NullableContext(1)]
		public static MaterialReplaceRequest Create()
		{
			return new MaterialReplaceRequest();
		}

		// Token: 0x17002C5D RID: 11357
		// (get) Token: 0x0600DAEC RID: 56044 RVA: 0x00202DD9 File Offset: 0x00200FD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002C5E RID: 11358
		// (get) Token: 0x0600DAED RID: 56045 RVA: 0x00202DDC File Offset: 0x00200FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MaterialReplaceRequest.Descriptor;
			}
		}

		// Token: 0x0600DAEE RID: 56046 RVA: 0x00202DE3 File Offset: 0x00200FE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialReplaceRequest()
		{
		}

		// Token: 0x0600DAEF RID: 56047 RVA: 0x00202DEB File Offset: 0x00200FEB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialReplaceRequest(MaterialReplaceRequest other) : this()
		{
			this.targetReplaceItemId_ = other.targetReplaceItemId_;
			this.consumeItemId_ = other.consumeItemId_;
			this.consumeItemNum_ = other.consumeItemNum_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DAF0 RID: 56048 RVA: 0x00202E28 File Offset: 0x00201028
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MaterialReplaceRequest Clone()
		{
			return new MaterialReplaceRequest(this);
		}

		// Token: 0x17002C5F RID: 11359
		// (get) Token: 0x0600DAF1 RID: 56049 RVA: 0x00202E30 File Offset: 0x00201030
		// (set) Token: 0x0600DAF2 RID: 56050 RVA: 0x00202E38 File Offset: 0x00201038
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

		// Token: 0x17002C60 RID: 11360
		// (get) Token: 0x0600DAF3 RID: 56051 RVA: 0x00202E41 File Offset: 0x00201041
		// (set) Token: 0x0600DAF4 RID: 56052 RVA: 0x00202E49 File Offset: 0x00201049
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

		// Token: 0x17002C61 RID: 11361
		// (get) Token: 0x0600DAF5 RID: 56053 RVA: 0x00202E52 File Offset: 0x00201052
		// (set) Token: 0x0600DAF6 RID: 56054 RVA: 0x00202E5A File Offset: 0x0020105A
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

		// Token: 0x0600DAF7 RID: 56055 RVA: 0x00202E63 File Offset: 0x00201063
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MaterialReplaceRequest);
		}

		// Token: 0x0600DAF8 RID: 56056 RVA: 0x00202E74 File Offset: 0x00201074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MaterialReplaceRequest other)
		{
			return other != null && (other == this || (this.TargetReplaceItemId == other.TargetReplaceItemId && this.ConsumeItemId == other.ConsumeItemId && this.ConsumeItemNum == other.ConsumeItemNum && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DAF9 RID: 56057 RVA: 0x00202ED0 File Offset: 0x002010D0
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

		// Token: 0x0600DAFA RID: 56058 RVA: 0x00202F41 File Offset: 0x00201141
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DAFB RID: 56059 RVA: 0x00202F4E File Offset: 0x0020114E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DAFC RID: 56060 RVA: 0x00202F58 File Offset: 0x00201158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConsumeItemId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.ConsumeItemId);
			}
			if (this.TargetReplaceItemId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.TargetReplaceItemId);
			}
			if (this.ConsumeItemNum != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ConsumeItemNum);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DAFD RID: 56061 RVA: 0x00202FD0 File Offset: 0x002011D0
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

		// Token: 0x0600DAFE RID: 56062 RVA: 0x00203040 File Offset: 0x00201240
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

		// Token: 0x0600DAFF RID: 56063 RVA: 0x002030A4 File Offset: 0x002012A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DB00 RID: 56064 RVA: 0x002030B0 File Offset: 0x002012B0
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
				if (num != 96U)
				{
					if (num != 104U)
					{
						if (num != 120U)
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
						this.TargetReplaceItemId = input.ReadInt32();
					}
				}
				else
				{
					this.ConsumeItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005B44 RID: 23364
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B45 RID: 23365
		public const int TargetReplaceItemIdFieldNumber = 13;

		// Token: 0x04005B46 RID: 23366
		private int targetReplaceItemId_;

		// Token: 0x04005B47 RID: 23367
		public const int ConsumeItemIdFieldNumber = 12;

		// Token: 0x04005B48 RID: 23368
		private int consumeItemId_;

		// Token: 0x04005B49 RID: 23369
		public const int ConsumeItemNumFieldNumber = 15;

		// Token: 0x04005B4A RID: 23370
		private int consumeItemNum_;
	}
}
