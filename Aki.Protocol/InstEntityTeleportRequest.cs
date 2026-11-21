using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200080D RID: 2061
	[NetMessage(EMessageId.InstEntityTeleportRequest)]
	public sealed class InstEntityTeleportRequest : IMessage<InstEntityTeleportRequest>, IMessage, IEquatable<InstEntityTeleportRequest>, IDeepCloneable<InstEntityTeleportRequest>, IBufferMessage
	{
		// Token: 0x0600B898 RID: 47256 RVA: 0x001B7D17 File Offset: 0x001B5F17
		[NullableContext(1)]
		public static InstEntityTeleportRequest Create()
		{
			return new InstEntityTeleportRequest();
		}

		// Token: 0x1700252D RID: 9517
		// (get) Token: 0x0600B899 RID: 47257 RVA: 0x001B7D1E File Offset: 0x001B5F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700252E RID: 9518
		// (get) Token: 0x0600B89A RID: 47258 RVA: 0x001B7D21 File Offset: 0x001B5F21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstEntityTeleportRequest.Descriptor;
			}
		}

		// Token: 0x0600B89B RID: 47259 RVA: 0x001B7D28 File Offset: 0x001B5F28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntityTeleportRequest()
		{
		}

		// Token: 0x0600B89C RID: 47260 RVA: 0x001B7D30 File Offset: 0x001B5F30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntityTeleportRequest(InstEntityTeleportRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.entityConfigId_ = other.entityConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B89D RID: 47261 RVA: 0x001B7D61 File Offset: 0x001B5F61
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntityTeleportRequest Clone()
		{
			return new InstEntityTeleportRequest(this);
		}

		// Token: 0x1700252F RID: 9519
		// (get) Token: 0x0600B89E RID: 47262 RVA: 0x001B7D69 File Offset: 0x001B5F69
		// (set) Token: 0x0600B89F RID: 47263 RVA: 0x001B7D71 File Offset: 0x001B5F71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int InstId
		{
			get
			{
				return this.instId_;
			}
			set
			{
				this.instId_ = value;
			}
		}

		// Token: 0x17002530 RID: 9520
		// (get) Token: 0x0600B8A0 RID: 47264 RVA: 0x001B7D7A File Offset: 0x001B5F7A
		// (set) Token: 0x0600B8A1 RID: 47265 RVA: 0x001B7D82 File Offset: 0x001B5F82
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int EntityConfigId
		{
			get
			{
				return this.entityConfigId_;
			}
			set
			{
				this.entityConfigId_ = value;
			}
		}

		// Token: 0x0600B8A2 RID: 47266 RVA: 0x001B7D8B File Offset: 0x001B5F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstEntityTeleportRequest);
		}

		// Token: 0x0600B8A3 RID: 47267 RVA: 0x001B7D99 File Offset: 0x001B5F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstEntityTeleportRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.EntityConfigId == other.EntityConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B8A4 RID: 47268 RVA: 0x001B7DD8 File Offset: 0x001B5FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.InstId != 0)
			{
				num ^= this.InstId.GetHashCode();
			}
			if (this.EntityConfigId != 0)
			{
				num ^= this.EntityConfigId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B8A5 RID: 47269 RVA: 0x001B7E30 File Offset: 0x001B6030
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B8A6 RID: 47270 RVA: 0x001B7E3D File Offset: 0x001B603D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B8A7 RID: 47271 RVA: 0x001B7E48 File Offset: 0x001B6048
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B8A8 RID: 47272 RVA: 0x001B7EA4 File Offset: 0x001B60A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.InstId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.InstId);
			}
			if (this.EntityConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityConfigId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B8A9 RID: 47273 RVA: 0x001B7EFC File Offset: 0x001B60FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(InstEntityTeleportRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.InstId != 0)
			{
				this.InstId = other.InstId;
			}
			if (other.EntityConfigId != 0)
			{
				this.EntityConfigId = other.EntityConfigId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B8AA RID: 47274 RVA: 0x001B7F4C File Offset: 0x001B614C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B8AB RID: 47275 RVA: 0x001B7F58 File Offset: 0x001B6158
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
					if (num != 64U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.InstId = input.ReadInt32();
					}
				}
				else
				{
					this.EntityConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400519D RID: 20893
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400519E RID: 20894
		public const int InstIdFieldNumber = 8;

		// Token: 0x0400519F RID: 20895
		private int instId_;

		// Token: 0x040051A0 RID: 20896
		public const int EntityConfigIdFieldNumber = 5;

		// Token: 0x040051A1 RID: 20897
		private int entityConfigId_;
	}
}
