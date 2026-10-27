using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002D7 RID: 727
	[NetMessage(EMessageId.ConnectorCanConnectRequest)]
	public sealed class ConnectorCanConnectRequest : IMessage<ConnectorCanConnectRequest>, IMessage, IEquatable<ConnectorCanConnectRequest>, IDeepCloneable<ConnectorCanConnectRequest>, IBufferMessage
	{
		// Token: 0x06004A5D RID: 19037 RVA: 0x000B5B19 File Offset: 0x000B3D19
		[NullableContext(1)]
		public static ConnectorCanConnectRequest Create()
		{
			return new ConnectorCanConnectRequest();
		}

		// Token: 0x17000D0F RID: 3343
		// (get) Token: 0x06004A5E RID: 19038 RVA: 0x000B5B20 File Offset: 0x000B3D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D10 RID: 3344
		// (get) Token: 0x06004A5F RID: 19039 RVA: 0x000B5B23 File Offset: 0x000B3D23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectorCanConnectRequest.Descriptor;
			}
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x000B5B2A File Offset: 0x000B3D2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorCanConnectRequest()
		{
		}

		// Token: 0x06004A61 RID: 19041 RVA: 0x000B5B32 File Offset: 0x000B3D32
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorCanConnectRequest(ConnectorCanConnectRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isEnter_ = other.isEnter_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004A62 RID: 19042 RVA: 0x000B5B63 File Offset: 0x000B3D63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorCanConnectRequest Clone()
		{
			return new ConnectorCanConnectRequest(this);
		}

		// Token: 0x17000D11 RID: 3345
		// (get) Token: 0x06004A63 RID: 19043 RVA: 0x000B5B6B File Offset: 0x000B3D6B
		// (set) Token: 0x06004A64 RID: 19044 RVA: 0x000B5B73 File Offset: 0x000B3D73
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

		// Token: 0x17000D12 RID: 3346
		// (get) Token: 0x06004A65 RID: 19045 RVA: 0x000B5B7C File Offset: 0x000B3D7C
		// (set) Token: 0x06004A66 RID: 19046 RVA: 0x000B5B84 File Offset: 0x000B3D84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsEnter
		{
			get
			{
				return this.isEnter_;
			}
			set
			{
				this.isEnter_ = value;
			}
		}

		// Token: 0x06004A67 RID: 19047 RVA: 0x000B5B8D File Offset: 0x000B3D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectorCanConnectRequest);
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x000B5B9B File Offset: 0x000B3D9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConnectorCanConnectRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsEnter == other.IsEnter && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004A69 RID: 19049 RVA: 0x000B5BDC File Offset: 0x000B3DDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.IsEnter)
			{
				num ^= this.IsEnter.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x000B5C34 File Offset: 0x000B3E34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x000B5C41 File Offset: 0x000B3E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004A6C RID: 19052 RVA: 0x000B5C4C File Offset: 0x000B3E4C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.EntityId);
			}
			if (this.IsEnter)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsEnter);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x000B5CA8 File Offset: 0x000B3EA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.IsEnter)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004A6E RID: 19054 RVA: 0x000B5CF4 File Offset: 0x000B3EF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ConnectorCanConnectRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.IsEnter)
			{
				this.IsEnter = other.IsEnter;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004A6F RID: 19055 RVA: 0x000B5D44 File Offset: 0x000B3F44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004A70 RID: 19056 RVA: 0x000B5D50 File Offset: 0x000B3F50
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
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.IsEnter = input.ReadBool();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003078 RID: 12408
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003079 RID: 12409
		public const int EntityIdFieldNumber = 2;

		// Token: 0x0400307A RID: 12410
		private long entityId_;

		// Token: 0x0400307B RID: 12411
		public const int IsEnterFieldNumber = 6;

		// Token: 0x0400307C RID: 12412
		private bool isEnter_;
	}
}
