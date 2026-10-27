using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000477 RID: 1143
	[NetMessage(EMessageId.EntityBuffProducerRequest)]
	public sealed class EntityBuffProducerRequest : IMessage<EntityBuffProducerRequest>, IMessage, IEquatable<EntityBuffProducerRequest>, IDeepCloneable<EntityBuffProducerRequest>, IBufferMessage
	{
		// Token: 0x06006CE8 RID: 27880 RVA: 0x00106DA7 File Offset: 0x00104FA7
		[NullableContext(1)]
		public static EntityBuffProducerRequest Create()
		{
			return new EntityBuffProducerRequest();
		}

		// Token: 0x170014B3 RID: 5299
		// (get) Token: 0x06006CE9 RID: 27881 RVA: 0x00106DAE File Offset: 0x00104FAE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014B4 RID: 5300
		// (get) Token: 0x06006CEA RID: 27882 RVA: 0x00106DB1 File Offset: 0x00104FB1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityBuffProducerRequest.Descriptor;
			}
		}

		// Token: 0x06006CEB RID: 27883 RVA: 0x00106DB8 File Offset: 0x00104FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerRequest()
		{
		}

		// Token: 0x06006CEC RID: 27884 RVA: 0x00106DC0 File Offset: 0x00104FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerRequest(EntityBuffProducerRequest other) : this()
		{
			this.buffConsumerId_ = other.buffConsumerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006CED RID: 27885 RVA: 0x00106DE5 File Offset: 0x00104FE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityBuffProducerRequest Clone()
		{
			return new EntityBuffProducerRequest(this);
		}

		// Token: 0x170014B5 RID: 5301
		// (get) Token: 0x06006CEE RID: 27886 RVA: 0x00106DED File Offset: 0x00104FED
		// (set) Token: 0x06006CEF RID: 27887 RVA: 0x00106DF5 File Offset: 0x00104FF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long BuffConsumerId
		{
			get
			{
				return this.buffConsumerId_;
			}
			set
			{
				this.buffConsumerId_ = value;
			}
		}

		// Token: 0x06006CF0 RID: 27888 RVA: 0x00106DFE File Offset: 0x00104FFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityBuffProducerRequest);
		}

		// Token: 0x06006CF1 RID: 27889 RVA: 0x00106E0C File Offset: 0x0010500C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityBuffProducerRequest other)
		{
			return other != null && (other == this || (this.BuffConsumerId == other.BuffConsumerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006CF2 RID: 27890 RVA: 0x00106E3C File Offset: 0x0010503C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BuffConsumerId != 0L)
			{
				num ^= this.BuffConsumerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006CF3 RID: 27891 RVA: 0x00106E7B File Offset: 0x0010507B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006CF4 RID: 27892 RVA: 0x00106E88 File Offset: 0x00105088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006CF5 RID: 27893 RVA: 0x00106E91 File Offset: 0x00105091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BuffConsumerId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.BuffConsumerId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006CF6 RID: 27894 RVA: 0x00106EC4 File Offset: 0x001050C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BuffConsumerId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.BuffConsumerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006CF7 RID: 27895 RVA: 0x00106F02 File Offset: 0x00105102
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityBuffProducerRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BuffConsumerId != 0L)
			{
				this.BuffConsumerId = other.BuffConsumerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006CF8 RID: 27896 RVA: 0x00106F33 File Offset: 0x00105133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006CF9 RID: 27897 RVA: 0x00106F3C File Offset: 0x0010513C
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.BuffConsumerId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003B13 RID: 15123
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B14 RID: 15124
		public const int BuffConsumerIdFieldNumber = 1;

		// Token: 0x04003B15 RID: 15125
		private long buffConsumerId_;
	}
}
