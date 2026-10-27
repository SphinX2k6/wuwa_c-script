using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003E8 RID: 1000
	[NetMessage(EMessageId.DollDeliveryRequest)]
	public sealed class DollDeliveryRequest : IMessage<DollDeliveryRequest>, IMessage, IEquatable<DollDeliveryRequest>, IDeepCloneable<DollDeliveryRequest>, IBufferMessage
	{
		// Token: 0x06006115 RID: 24853 RVA: 0x000EA7D1 File Offset: 0x000E89D1
		[NullableContext(1)]
		public static DollDeliveryRequest Create()
		{
			return new DollDeliveryRequest();
		}

		// Token: 0x17001218 RID: 4632
		// (get) Token: 0x06006116 RID: 24854 RVA: 0x000EA7D8 File Offset: 0x000E89D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001219 RID: 4633
		// (get) Token: 0x06006117 RID: 24855 RVA: 0x000EA7DB File Offset: 0x000E89DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollDeliveryRequest.Descriptor;
			}
		}

		// Token: 0x06006118 RID: 24856 RVA: 0x000EA7E2 File Offset: 0x000E89E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryRequest()
		{
		}

		// Token: 0x06006119 RID: 24857 RVA: 0x000EA7EA File Offset: 0x000E89EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryRequest(DollDeliveryRequest other) : this()
		{
			this.entityCfgId_ = other.entityCfgId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600611A RID: 24858 RVA: 0x000EA80F File Offset: 0x000E8A0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryRequest Clone()
		{
			return new DollDeliveryRequest(this);
		}

		// Token: 0x1700121A RID: 4634
		// (get) Token: 0x0600611B RID: 24859 RVA: 0x000EA817 File Offset: 0x000E8A17
		// (set) Token: 0x0600611C RID: 24860 RVA: 0x000EA81F File Offset: 0x000E8A1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityCfgId
		{
			get
			{
				return this.entityCfgId_;
			}
			set
			{
				this.entityCfgId_ = value;
			}
		}

		// Token: 0x0600611D RID: 24861 RVA: 0x000EA828 File Offset: 0x000E8A28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollDeliveryRequest);
		}

		// Token: 0x0600611E RID: 24862 RVA: 0x000EA836 File Offset: 0x000E8A36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollDeliveryRequest other)
		{
			return other != null && (other == this || (this.EntityCfgId == other.EntityCfgId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600611F RID: 24863 RVA: 0x000EA864 File Offset: 0x000E8A64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityCfgId != 0)
			{
				num ^= this.EntityCfgId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006120 RID: 24864 RVA: 0x000EA8A3 File Offset: 0x000E8AA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006121 RID: 24865 RVA: 0x000EA8B0 File Offset: 0x000E8AB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006122 RID: 24866 RVA: 0x000EA8B9 File Offset: 0x000E8AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityCfgId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.EntityCfgId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006123 RID: 24867 RVA: 0x000EA8EC File Offset: 0x000E8AEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityCfgId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityCfgId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006124 RID: 24868 RVA: 0x000EA92A File Offset: 0x000E8B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DollDeliveryRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityCfgId != 0)
			{
				this.EntityCfgId = other.EntityCfgId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006125 RID: 24869 RVA: 0x000EA95B File Offset: 0x000E8B5B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006126 RID: 24870 RVA: 0x000EA964 File Offset: 0x000E8B64
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
				if (num != 64U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityCfgId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400378B RID: 14219
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400378C RID: 14220
		public const int EntityCfgIdFieldNumber = 8;

		// Token: 0x0400378D RID: 14221
		private int entityCfgId_;
	}
}
