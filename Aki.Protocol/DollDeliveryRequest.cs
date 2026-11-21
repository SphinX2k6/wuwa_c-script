using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020003D1 RID: 977
	[NetMessage(EMessageId.DollDeliveryRequest)]
	public sealed class DollDeliveryRequest : IMessage<DollDeliveryRequest>, IMessage, IEquatable<DollDeliveryRequest>, IDeepCloneable<DollDeliveryRequest>, IBufferMessage
	{
		// Token: 0x06005F85 RID: 24453 RVA: 0x000E7651 File Offset: 0x000E5851
		[NullableContext(1)]
		public static DollDeliveryRequest Create()
		{
			return new DollDeliveryRequest();
		}

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x06005F86 RID: 24454 RVA: 0x000E7658 File Offset: 0x000E5858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x06005F87 RID: 24455 RVA: 0x000E765B File Offset: 0x000E585B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DollDeliveryRequest.Descriptor;
			}
		}

		// Token: 0x06005F88 RID: 24456 RVA: 0x000E7662 File Offset: 0x000E5862
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryRequest()
		{
		}

		// Token: 0x06005F89 RID: 24457 RVA: 0x000E766A File Offset: 0x000E586A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryRequest(DollDeliveryRequest other) : this()
		{
			this.entityCfgId_ = other.entityCfgId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005F8A RID: 24458 RVA: 0x000E768F File Offset: 0x000E588F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DollDeliveryRequest Clone()
		{
			return new DollDeliveryRequest(this);
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x06005F8B RID: 24459 RVA: 0x000E7697 File Offset: 0x000E5897
		// (set) Token: 0x06005F8C RID: 24460 RVA: 0x000E769F File Offset: 0x000E589F
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

		// Token: 0x06005F8D RID: 24461 RVA: 0x000E76A8 File Offset: 0x000E58A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DollDeliveryRequest);
		}

		// Token: 0x06005F8E RID: 24462 RVA: 0x000E76B6 File Offset: 0x000E58B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DollDeliveryRequest other)
		{
			return other != null && (other == this || (this.EntityCfgId == other.EntityCfgId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005F8F RID: 24463 RVA: 0x000E76E4 File Offset: 0x000E58E4
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

		// Token: 0x06005F90 RID: 24464 RVA: 0x000E7723 File Offset: 0x000E5923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06005F91 RID: 24465 RVA: 0x000E7730 File Offset: 0x000E5930
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06005F92 RID: 24466 RVA: 0x000E7739 File Offset: 0x000E5939
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityCfgId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.EntityCfgId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06005F93 RID: 24467 RVA: 0x000E776C File Offset: 0x000E596C
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

		// Token: 0x06005F94 RID: 24468 RVA: 0x000E77AA File Offset: 0x000E59AA
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

		// Token: 0x06005F95 RID: 24469 RVA: 0x000E77DB File Offset: 0x000E59DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005F96 RID: 24470 RVA: 0x000E77E4 File Offset: 0x000E59E4
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
				if (num != 32U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.EntityCfgId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04003778 RID: 14200
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003779 RID: 14201
		public const int EntityCfgIdFieldNumber = 4;

		// Token: 0x0400377A RID: 14202
		private int entityCfgId_;
	}
}
