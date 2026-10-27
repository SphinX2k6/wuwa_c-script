using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200029D RID: 669
	public sealed class ClientDataComponentPb : IMessage<ClientDataComponentPb>, IMessage, IEquatable<ClientDataComponentPb>, IDeepCloneable<ClientDataComponentPb>, IBufferMessage
	{
		// Token: 0x060045AA RID: 17834 RVA: 0x000AB4DF File Offset: 0x000A96DF
		[NullableContext(1)]
		public static ClientDataComponentPb Create()
		{
			return new ClientDataComponentPb();
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x060045AB RID: 17835 RVA: 0x000AB4E6 File Offset: 0x000A96E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x060045AC RID: 17836 RVA: 0x000AB4E9 File Offset: 0x000A96E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ClientDataComponentPb.Descriptor;
			}
		}

		// Token: 0x060045AD RID: 17837 RVA: 0x000AB4F0 File Offset: 0x000A96F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientDataComponentPb()
		{
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x000AB4F8 File Offset: 0x000A96F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientDataComponentPb(ClientDataComponentPb other) : this()
		{
			this.isStaticInit_ = other.isStaticInit_;
			this.ownerId_ = other.ownerId_;
			this.groupId_ = other.groupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060045AF RID: 17839 RVA: 0x000AB535 File Offset: 0x000A9735
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ClientDataComponentPb Clone()
		{
			return new ClientDataComponentPb(this);
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x060045B0 RID: 17840 RVA: 0x000AB53D File Offset: 0x000A973D
		// (set) Token: 0x060045B1 RID: 17841 RVA: 0x000AB545 File Offset: 0x000A9745
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

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x060045B2 RID: 17842 RVA: 0x000AB54E File Offset: 0x000A974E
		// (set) Token: 0x060045B3 RID: 17843 RVA: 0x000AB556 File Offset: 0x000A9756
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

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x060045B4 RID: 17844 RVA: 0x000AB55F File Offset: 0x000A975F
		// (set) Token: 0x060045B5 RID: 17845 RVA: 0x000AB567 File Offset: 0x000A9767
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

		// Token: 0x060045B6 RID: 17846 RVA: 0x000AB570 File Offset: 0x000A9770
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ClientDataComponentPb);
		}

		// Token: 0x060045B7 RID: 17847 RVA: 0x000AB580 File Offset: 0x000A9780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ClientDataComponentPb other)
		{
			return other != null && (other == this || (this.IsStaticInit == other.IsStaticInit && this.OwnerId == other.OwnerId && this.GroupId == other.GroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x000AB5DC File Offset: 0x000A97DC
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

		// Token: 0x060045B9 RID: 17849 RVA: 0x000AB64D File Offset: 0x000A984D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x000AB65A File Offset: 0x000A985A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x000AB664 File Offset: 0x000A9864
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

		// Token: 0x060045BC RID: 17852 RVA: 0x000AB6D8 File Offset: 0x000A98D8
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

		// Token: 0x060045BD RID: 17853 RVA: 0x000AB73C File Offset: 0x000A993C
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

		// Token: 0x060045BE RID: 17854 RVA: 0x000AB7A0 File Offset: 0x000A99A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x000AB7AC File Offset: 0x000A99AC
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

		// Token: 0x04002F1D RID: 12061
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002F1E RID: 12062
		public const int IsStaticInitFieldNumber = 1;

		// Token: 0x04002F1F RID: 12063
		private bool isStaticInit_;

		// Token: 0x04002F20 RID: 12064
		public const int OwnerIdFieldNumber = 2;

		// Token: 0x04002F21 RID: 12065
		private long ownerId_;

		// Token: 0x04002F22 RID: 12066
		public const int GroupIdFieldNumber = 3;

		// Token: 0x04002F23 RID: 12067
		private int groupId_;
	}
}
