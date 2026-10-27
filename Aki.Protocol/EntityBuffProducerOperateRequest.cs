using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000475 RID: 1141
	[NetMessage(EMessageId.EntityBuffProducerOperateRequest)]
	public sealed class EntityBuffProducerOperateRequest : IMessage<EntityBuffProducerOperateRequest>, IMessage, IEquatable<EntityBuffProducerOperateRequest>, IDeepCloneable<EntityBuffProducerOperateRequest>, IBufferMessage
	{
		// Token: 0x06006CBE RID: 27838 RVA: 0x001067B5 File Offset: 0x001049B5
		[NullableContext(1)]
		public static EntityBuffProducerOperateRequest Create()
		{
			return new EntityBuffProducerOperateRequest();
		}

		// Token: 0x170014AA RID: 5290
		// (get) Token: 0x06006CBF RID: 27839 RVA: 0x001067BC File Offset: 0x001049BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014AB RID: 5291
		// (get) Token: 0x06006CC0 RID: 27840 RVA: 0x001067BF File Offset: 0x001049BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBuffProducerOperateRequest.Descriptor;
			}
		}

		// Token: 0x06006CC1 RID: 27841 RVA: 0x001067C6 File Offset: 0x001049C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerOperateRequest()
		{
		}

		// Token: 0x06006CC2 RID: 27842 RVA: 0x001067CE File Offset: 0x001049CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerOperateRequest(EntityBuffProducerOperateRequest other) : this()
		{
			this.opType_ = other.opType_;
			this.opEntityId_ = other.opEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006CC3 RID: 27843 RVA: 0x001067FF File Offset: 0x001049FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerOperateRequest Clone()
		{
			return new EntityBuffProducerOperateRequest(this);
		}

		// Token: 0x170014AC RID: 5292
		// (get) Token: 0x06006CC4 RID: 27844 RVA: 0x00106807 File Offset: 0x00104A07
		// (set) Token: 0x06006CC5 RID: 27845 RVA: 0x0010680F File Offset: 0x00104A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BuffOperateType OpType
		{
			get
			{
				return this.opType_;
			}
			set
			{
				this.opType_ = value;
			}
		}

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x06006CC6 RID: 27846 RVA: 0x00106818 File Offset: 0x00104A18
		// (set) Token: 0x06006CC7 RID: 27847 RVA: 0x00106820 File Offset: 0x00104A20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OpEntityId
		{
			get
			{
				return this.opEntityId_;
			}
			set
			{
				this.opEntityId_ = value;
			}
		}

		// Token: 0x06006CC8 RID: 27848 RVA: 0x00106829 File Offset: 0x00104A29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBuffProducerOperateRequest);
		}

		// Token: 0x06006CC9 RID: 27849 RVA: 0x00106837 File Offset: 0x00104A37
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBuffProducerOperateRequest other)
		{
			return other != null && (other == this || (this.OpType == other.OpType && this.OpEntityId == other.OpEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006CCA RID: 27850 RVA: 0x00106878 File Offset: 0x00104A78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.OpType != BuffOperateType.AddBuff)
			{
				num ^= this.OpType.GetHashCode();
			}
			if (this.OpEntityId != 0L)
			{
				num ^= this.OpEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006CCB RID: 27851 RVA: 0x001068D6 File Offset: 0x00104AD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006CCC RID: 27852 RVA: 0x001068E3 File Offset: 0x00104AE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006CCD RID: 27853 RVA: 0x001068EC File Offset: 0x00104AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.OpType != BuffOperateType.AddBuff)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.OpType);
			}
			if (this.OpEntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.OpEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006CCE RID: 27854 RVA: 0x00106948 File Offset: 0x00104B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.OpType != BuffOperateType.AddBuff)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.OpType);
			}
			if (this.OpEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.OpEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006CCF RID: 27855 RVA: 0x001069A0 File Offset: 0x00104BA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBuffProducerOperateRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.OpType != BuffOperateType.AddBuff)
			{
				this.OpType = other.OpType;
			}
			if (other.OpEntityId != 0L)
			{
				this.OpEntityId = other.OpEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006CD0 RID: 27856 RVA: 0x001069F0 File Offset: 0x00104BF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006CD1 RID: 27857 RVA: 0x001069FC File Offset: 0x00104BFC
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
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.OpEntityId = input.ReadInt64();
					}
				}
				else
				{
					this.OpType = (BuffOperateType)input.ReadEnum();
				}
			}
		}

		// Token: 0x04003B07 RID: 15111
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B08 RID: 15112
		public const int OpTypeFieldNumber = 2;

		// Token: 0x04003B09 RID: 15113
		private BuffOperateType opType_;

		// Token: 0x04003B0A RID: 15114
		public const int OpEntityIdFieldNumber = 8;

		// Token: 0x04003B0B RID: 15115
		private long opEntityId_;
	}
}
