using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001543 RID: 5443
	[NetMessage(EMessageId.VehicleFinishRequest)]
	public sealed class VehicleFinishRequest : IMessage<VehicleFinishRequest>, IMessage, IEquatable<VehicleFinishRequest>, IDeepCloneable<VehicleFinishRequest>, IBufferMessage
	{
		// Token: 0x0601CD5A RID: 118106 RVA: 0x0042DB85 File Offset: 0x0042BD85
		[NullableContext(1)]
		public static VehicleFinishRequest Create()
		{
			return new VehicleFinishRequest();
		}

		// Token: 0x17006191 RID: 24977
		// (get) Token: 0x0601CD5B RID: 118107 RVA: 0x0042DB8C File Offset: 0x0042BD8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006192 RID: 24978
		// (get) Token: 0x0601CD5C RID: 118108 RVA: 0x0042DB8F File Offset: 0x0042BD8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return VehicleFinishRequest.Descriptor;
			}
		}

		// Token: 0x0601CD5D RID: 118109 RVA: 0x0042DB96 File Offset: 0x0042BD96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleFinishRequest()
		{
		}

		// Token: 0x0601CD5E RID: 118110 RVA: 0x0042DB9E File Offset: 0x0042BD9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleFinishRequest(VehicleFinishRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CD5F RID: 118111 RVA: 0x0042DBC3 File Offset: 0x0042BDC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public VehicleFinishRequest Clone()
		{
			return new VehicleFinishRequest(this);
		}

		// Token: 0x17006193 RID: 24979
		// (get) Token: 0x0601CD60 RID: 118112 RVA: 0x0042DBCB File Offset: 0x0042BDCB
		// (set) Token: 0x0601CD61 RID: 118113 RVA: 0x0042DBD3 File Offset: 0x0042BDD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x0601CD62 RID: 118114 RVA: 0x0042DBDC File Offset: 0x0042BDDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as VehicleFinishRequest);
		}

		// Token: 0x0601CD63 RID: 118115 RVA: 0x0042DBEA File Offset: 0x0042BDEA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(VehicleFinishRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CD64 RID: 118116 RVA: 0x0042DC18 File Offset: 0x0042BE18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CD65 RID: 118117 RVA: 0x0042DC57 File Offset: 0x0042BE57
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CD66 RID: 118118 RVA: 0x0042DC64 File Offset: 0x0042BE64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CD67 RID: 118119 RVA: 0x0042DC6D File Offset: 0x0042BE6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CD68 RID: 118120 RVA: 0x0042DCA0 File Offset: 0x0042BEA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CD69 RID: 118121 RVA: 0x0042DCDE File Offset: 0x0042BEDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(VehicleFinishRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CD6A RID: 118122 RVA: 0x0042DD0F File Offset: 0x0042BF0F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CD6B RID: 118123 RVA: 0x0042DD18 File Offset: 0x0042BF18
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x0400A5E7 RID: 42471
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A5E8 RID: 42472
		public const int EntityIdFieldNumber = 8;

		// Token: 0x0400A5E9 RID: 42473
		private long entityId_;
	}
}
