using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020002A2 RID: 674
	public sealed class ClientDataComponentPb : IMessage<ClientDataComponentPb>, IMessage, IEquatable<ClientDataComponentPb>, IDeepCloneable<ClientDataComponentPb>, IBufferMessage
	{
		// Token: 0x06004653 RID: 18003 RVA: 0x000AD25F File Offset: 0x000AB45F
		[NullableContext(1)]
		public static ClientDataComponentPb Create()
		{
			return new ClientDataComponentPb();
		}

		// Token: 0x17000C2C RID: 3116
		// (get) Token: 0x06004654 RID: 18004 RVA: 0x000AD266 File Offset: 0x000AB466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C2D RID: 3117
		// (get) Token: 0x06004655 RID: 18005 RVA: 0x000AD269 File Offset: 0x000AB469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientDataComponentPb.Descriptor;
			}
		}

		// Token: 0x06004656 RID: 18006 RVA: 0x000AD270 File Offset: 0x000AB470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientDataComponentPb()
		{
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x000AD278 File Offset: 0x000AB478
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientDataComponentPb(ClientDataComponentPb other) : this()
		{
			this.isStaticInit_ = other.isStaticInit_;
			this.ownerId_ = other.ownerId_;
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x000AD2B5 File Offset: 0x000AB4B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientDataComponentPb Clone()
		{
			return new ClientDataComponentPb(this);
		}

		// Token: 0x17000C2E RID: 3118
		// (get) Token: 0x06004659 RID: 18009 RVA: 0x000AD2BD File Offset: 0x000AB4BD
		// (set) Token: 0x0600465A RID: 18010 RVA: 0x000AD2C5 File Offset: 0x000AB4C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsStaticInit
		{
			get
			{
				return this.isStaticInit_;
			}
			set
			{
				this.isStaticInit_ = value;
			}
		}

		// Token: 0x17000C2F RID: 3119
		// (get) Token: 0x0600465B RID: 18011 RVA: 0x000AD2CE File Offset: 0x000AB4CE
		// (set) Token: 0x0600465C RID: 18012 RVA: 0x000AD2D6 File Offset: 0x000AB4D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OwnerId
		{
			get
			{
				return this.ownerId_;
			}
			set
			{
				this.ownerId_ = value;
			}
		}

		// Token: 0x17000C30 RID: 3120
		// (get) Token: 0x0600465D RID: 18013 RVA: 0x000AD2DF File Offset: 0x000AB4DF
		// (set) Token: 0x0600465E RID: 18014 RVA: 0x000AD2E7 File Offset: 0x000AB4E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x0600465F RID: 18015 RVA: 0x000AD2F0 File Offset: 0x000AB4F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientDataComponentPb);
		}

		// Token: 0x06004660 RID: 18016 RVA: 0x000AD300 File Offset: 0x000AB500
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientDataComponentPb other)
		{
			return other != null && (other == this || (this.IsStaticInit == other.IsStaticInit && this.OwnerId == other.OwnerId && this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004661 RID: 18017 RVA: 0x000AD35C File Offset: 0x000AB55C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.IsStaticInit)
			{
				num ^= this.IsStaticInit.GetHashCode();
			}
			if (this.OwnerId != 0L)
			{
				num ^= this.OwnerId.GetHashCode();
			}
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06004662 RID: 18018 RVA: 0x000AD3CD File Offset: 0x000AB5CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004663 RID: 18019 RVA: 0x000AD3DA File Offset: 0x000AB5DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06004664 RID: 18020 RVA: 0x000AD3E4 File Offset: 0x000AB5E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsStaticInit)
			{
				output.WriteRawTag(8);
				output.WriteBool(this.IsStaticInit);
			}
			if (this.OwnerId != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.OwnerId);
			}
			if (this.GroupId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06004665 RID: 18021 RVA: 0x000AD458 File Offset: 0x000AB658
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.IsStaticInit)
			{
				num += 2;
			}
			if (this.OwnerId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.OwnerId);
			}
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06004666 RID: 18022 RVA: 0x000AD4BC File Offset: 0x000AB6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ClientDataComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.IsStaticInit)
			{
				this.IsStaticInit = other.IsStaticInit;
			}
			if (other.OwnerId != 0L)
			{
				this.OwnerId = other.OwnerId;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x000AD520 File Offset: 0x000AB720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06004668 RID: 18024 RVA: 0x000AD52C File Offset: 0x000AB72C
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
					if (num != 16U)
					{
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.GroupId = input.ReadInt32();
						}
					}
					else
					{
						this.OwnerId = input.ReadInt64();
					}
				}
				else
				{
					this.IsStaticInit = input.ReadBool();
				}
			}
		}

		// Token: 0x04002FA3 RID: 12195
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002FA4 RID: 12196
		public const int IsStaticInitFieldNumber = 1;

		// Token: 0x04002FA5 RID: 12197
		private bool isStaticInit_;

		// Token: 0x04002FA6 RID: 12198
		public const int OwnerIdFieldNumber = 2;

		// Token: 0x04002FA7 RID: 12199
		private long ownerId_;

		// Token: 0x04002FA8 RID: 12200
		public const int GroupIdFieldNumber = 3;

		// Token: 0x04002FA9 RID: 12201
		private int groupId_;
	}
}
