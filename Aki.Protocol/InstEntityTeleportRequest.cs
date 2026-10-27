using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000821 RID: 2081
	[NetMessage(EMessageId.InstEntityTeleportRequest)]
	public sealed class InstEntityTeleportRequest : IMessage<InstEntityTeleportRequest>, IMessage, IEquatable<InstEntityTeleportRequest>, IDeepCloneable<InstEntityTeleportRequest>, IBufferMessage
	{
		// Token: 0x0600B9EE RID: 47598 RVA: 0x001BA753 File Offset: 0x001B8953
		[NullableContext(1)]
		public static InstEntityTeleportRequest Create()
		{
			return new InstEntityTeleportRequest();
		}

		// Token: 0x17002577 RID: 9591
		// (get) Token: 0x0600B9EF RID: 47599 RVA: 0x001BA75A File Offset: 0x001B895A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002578 RID: 9592
		// (get) Token: 0x0600B9F0 RID: 47600 RVA: 0x001BA75D File Offset: 0x001B895D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return InstEntityTeleportRequest.Descriptor;
			}
		}

		// Token: 0x0600B9F1 RID: 47601 RVA: 0x001BA764 File Offset: 0x001B8964
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntityTeleportRequest()
		{
		}

		// Token: 0x0600B9F2 RID: 47602 RVA: 0x001BA76C File Offset: 0x001B896C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntityTeleportRequest(InstEntityTeleportRequest other) : this()
		{
			this.instId_ = other.instId_;
			this.entityConfigId_ = other.entityConfigId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B9F3 RID: 47603 RVA: 0x001BA79D File Offset: 0x001B899D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public InstEntityTeleportRequest Clone()
		{
			return new InstEntityTeleportRequest(this);
		}

		// Token: 0x17002579 RID: 9593
		// (get) Token: 0x0600B9F4 RID: 47604 RVA: 0x001BA7A5 File Offset: 0x001B89A5
		// (set) Token: 0x0600B9F5 RID: 47605 RVA: 0x001BA7AD File Offset: 0x001B89AD
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

		// Token: 0x1700257A RID: 9594
		// (get) Token: 0x0600B9F6 RID: 47606 RVA: 0x001BA7B6 File Offset: 0x001B89B6
		// (set) Token: 0x0600B9F7 RID: 47607 RVA: 0x001BA7BE File Offset: 0x001B89BE
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

		// Token: 0x0600B9F8 RID: 47608 RVA: 0x001BA7C7 File Offset: 0x001B89C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as InstEntityTeleportRequest);
		}

		// Token: 0x0600B9F9 RID: 47609 RVA: 0x001BA7D5 File Offset: 0x001B89D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(InstEntityTeleportRequest other)
		{
			return other != null && (other == this || (this.InstId == other.InstId && this.EntityConfigId == other.EntityConfigId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B9FA RID: 47610 RVA: 0x001BA814 File Offset: 0x001B8A14
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

		// Token: 0x0600B9FB RID: 47611 RVA: 0x001BA86C File Offset: 0x001B8A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B9FC RID: 47612 RVA: 0x001BA879 File Offset: 0x001B8A79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B9FD RID: 47613 RVA: 0x001BA884 File Offset: 0x001B8A84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityConfigId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.EntityConfigId);
			}
			if (this.InstId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.InstId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B9FE RID: 47614 RVA: 0x001BA8E0 File Offset: 0x001B8AE0
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

		// Token: 0x0600B9FF RID: 47615 RVA: 0x001BA938 File Offset: 0x001B8B38
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

		// Token: 0x0600BA00 RID: 47616 RVA: 0x001BA988 File Offset: 0x001B8B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BA01 RID: 47617 RVA: 0x001BA994 File Offset: 0x001B8B94
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
				if (num != 24U)
				{
					if (num != 120U)
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

		// Token: 0x040051A4 RID: 20900
		private UnknownFieldSet _unknownFields;

		// Token: 0x040051A5 RID: 20901
		public const int InstIdFieldNumber = 15;

		// Token: 0x040051A6 RID: 20902
		private int instId_;

		// Token: 0x040051A7 RID: 20903
		public const int EntityConfigIdFieldNumber = 3;

		// Token: 0x040051A8 RID: 20904
		private int entityConfigId_;
	}
}
