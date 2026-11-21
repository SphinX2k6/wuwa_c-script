using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B05 RID: 2821
	public sealed class NewHandInItemsProjectionMachinePb : IMessage<NewHandInItemsProjectionMachinePb>, IMessage, IEquatable<NewHandInItemsProjectionMachinePb>, IDeepCloneable<NewHandInItemsProjectionMachinePb>, IBufferMessage
	{
		// Token: 0x0600F558 RID: 62808 RVA: 0x0023CE88 File Offset: 0x0023B088
		[NullableContext(1)]
		public static NewHandInItemsProjectionMachinePb Create()
		{
			return new NewHandInItemsProjectionMachinePb();
		}

		// Token: 0x170031F2 RID: 12786
		// (get) Token: 0x0600F559 RID: 62809 RVA: 0x0023CE8F File Offset: 0x0023B08F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170031F3 RID: 12787
		// (get) Token: 0x0600F55A RID: 62810 RVA: 0x0023CE92 File Offset: 0x0023B092
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewHandInItemsProjectionMachinePb.Descriptor;
			}
		}

		// Token: 0x0600F55B RID: 62811 RVA: 0x0023CE99 File Offset: 0x0023B099
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewHandInItemsProjectionMachinePb()
		{
		}

		// Token: 0x0600F55C RID: 62812 RVA: 0x0023CEA1 File Offset: 0x0023B0A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewHandInItemsProjectionMachinePb(NewHandInItemsProjectionMachinePb other) : this()
		{
			this.entityCfgId_ = other.entityCfgId_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F55D RID: 62813 RVA: 0x0023CED2 File Offset: 0x0023B0D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewHandInItemsProjectionMachinePb Clone()
		{
			return new NewHandInItemsProjectionMachinePb(this);
		}

		// Token: 0x170031F4 RID: 12788
		// (get) Token: 0x0600F55E RID: 62814 RVA: 0x0023CEDA File Offset: 0x0023B0DA
		// (set) Token: 0x0600F55F RID: 62815 RVA: 0x0023CEE2 File Offset: 0x0023B0E2
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

		// Token: 0x170031F5 RID: 12789
		// (get) Token: 0x0600F560 RID: 62816 RVA: 0x0023CEEB File Offset: 0x0023B0EB
		// (set) Token: 0x0600F561 RID: 62817 RVA: 0x0023CEF3 File Offset: 0x0023B0F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x0600F562 RID: 62818 RVA: 0x0023CEFC File Offset: 0x0023B0FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewHandInItemsProjectionMachinePb);
		}

		// Token: 0x0600F563 RID: 62819 RVA: 0x0023CF0A File Offset: 0x0023B10A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewHandInItemsProjectionMachinePb other)
		{
			return other != null && (other == this || (this.EntityCfgId == other.EntityCfgId && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F564 RID: 62820 RVA: 0x0023CF48 File Offset: 0x0023B148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityCfgId != 0)
			{
				num ^= this.EntityCfgId.GetHashCode();
			}
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F565 RID: 62821 RVA: 0x0023CFA0 File Offset: 0x0023B1A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F566 RID: 62822 RVA: 0x0023CFAD File Offset: 0x0023B1AD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F567 RID: 62823 RVA: 0x0023CFB8 File Offset: 0x0023B1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityCfgId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.EntityCfgId);
			}
			if (this.ItemId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F568 RID: 62824 RVA: 0x0023D010 File Offset: 0x0023B210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityCfgId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.EntityCfgId);
			}
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F569 RID: 62825 RVA: 0x0023D068 File Offset: 0x0023B268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewHandInItemsProjectionMachinePb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityCfgId != 0)
			{
				this.EntityCfgId = other.EntityCfgId;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F56A RID: 62826 RVA: 0x0023D0B8 File Offset: 0x0023B2B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F56B RID: 62827 RVA: 0x0023D0C4 File Offset: 0x0023B2C4
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ItemId = input.ReadInt32();
					}
				}
				else
				{
					this.EntityCfgId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04006300 RID: 25344
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006301 RID: 25345
		public const int EntityCfgIdFieldNumber = 1;

		// Token: 0x04006302 RID: 25346
		private int entityCfgId_;

		// Token: 0x04006303 RID: 25347
		public const int ItemIdFieldNumber = 2;

		// Token: 0x04006304 RID: 25348
		private int itemId_;
	}
}
