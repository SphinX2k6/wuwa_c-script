using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002DE RID: 734
	[NetMessage(EMessageId.ConnectorCanConnectRequest)]
	public sealed class ConnectorCanConnectRequest : IMessage<ConnectorCanConnectRequest>, IMessage, IEquatable<ConnectorCanConnectRequest>, IDeepCloneable<ConnectorCanConnectRequest>, IBufferMessage
	{
		// Token: 0x06004B36 RID: 19254 RVA: 0x000B7F01 File Offset: 0x000B6101
		[NullableContext(1)]
		public static ConnectorCanConnectRequest Create()
		{
			return new ConnectorCanConnectRequest();
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06004B37 RID: 19255 RVA: 0x000B7F08 File Offset: 0x000B6108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x06004B38 RID: 19256 RVA: 0x000B7F0B File Offset: 0x000B610B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ConnectorCanConnectRequest.Descriptor;
			}
		}

		// Token: 0x06004B39 RID: 19257 RVA: 0x000B7F12 File Offset: 0x000B6112
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorCanConnectRequest()
		{
		}

		// Token: 0x06004B3A RID: 19258 RVA: 0x000B7F1A File Offset: 0x000B611A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorCanConnectRequest(ConnectorCanConnectRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.isEnter_ = other.isEnter_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004B3B RID: 19259 RVA: 0x000B7F4B File Offset: 0x000B614B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ConnectorCanConnectRequest Clone()
		{
			return new ConnectorCanConnectRequest(this);
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x06004B3C RID: 19260 RVA: 0x000B7F53 File Offset: 0x000B6153
		// (set) Token: 0x06004B3D RID: 19261 RVA: 0x000B7F5B File Offset: 0x000B615B
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

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x06004B3E RID: 19262 RVA: 0x000B7F64 File Offset: 0x000B6164
		// (set) Token: 0x06004B3F RID: 19263 RVA: 0x000B7F6C File Offset: 0x000B616C
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

		// Token: 0x06004B40 RID: 19264 RVA: 0x000B7F75 File Offset: 0x000B6175
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ConnectorCanConnectRequest);
		}

		// Token: 0x06004B41 RID: 19265 RVA: 0x000B7F83 File Offset: 0x000B6183
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ConnectorCanConnectRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.IsEnter == other.IsEnter && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004B42 RID: 19266 RVA: 0x000B7FC4 File Offset: 0x000B61C4
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

		// Token: 0x06004B43 RID: 19267 RVA: 0x000B801C File Offset: 0x000B621C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004B44 RID: 19268 RVA: 0x000B8029 File Offset: 0x000B6229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004B45 RID: 19269 RVA: 0x000B8034 File Offset: 0x000B6234
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsEnter)
			{
				output.WriteRawTag(32);
				output.WriteBool(this.IsEnter);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004B46 RID: 19270 RVA: 0x000B8090 File Offset: 0x000B6290
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

		// Token: 0x06004B47 RID: 19271 RVA: 0x000B80DC File Offset: 0x000B62DC
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

		// Token: 0x06004B48 RID: 19272 RVA: 0x000B812C File Offset: 0x000B632C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004B49 RID: 19273 RVA: 0x000B8138 File Offset: 0x000B6338
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
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					this.IsEnter = input.ReadBool();
				}
			}
		}

		// Token: 0x0400310F RID: 12559
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003110 RID: 12560
		public const int EntityIdFieldNumber = 15;

		// Token: 0x04003111 RID: 12561
		private long entityId_;

		// Token: 0x04003112 RID: 12562
		public const int IsEnterFieldNumber = 4;

		// Token: 0x04003113 RID: 12563
		private bool isEnter_;
	}
}
