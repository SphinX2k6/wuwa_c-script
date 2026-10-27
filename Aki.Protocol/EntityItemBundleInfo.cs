using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200049E RID: 1182
	public sealed class EntityItemBundleInfo : IMessage<EntityItemBundleInfo>, IMessage, IEquatable<EntityItemBundleInfo>, IDeepCloneable<EntityItemBundleInfo>, IBufferMessage
	{
		// Token: 0x060070D0 RID: 28880 RVA: 0x00114D55 File Offset: 0x00112F55
		[NullableContext(1)]
		public static EntityItemBundleInfo Create()
		{
			return new EntityItemBundleInfo();
		}

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x060070D1 RID: 28881 RVA: 0x00114D5C File Offset: 0x00112F5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<EntityItemBundleInfo> Parser
		{
			get
			{
				return EntityItemBundleInfo._parser;
			}
		}

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x060070D2 RID: 28882 RVA: 0x00114D63 File Offset: 0x00112F63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170015C0 RID: 5568
		// (get) Token: 0x060070D3 RID: 28883 RVA: 0x00114D66 File Offset: 0x00112F66
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityItemBundleInfo.Descriptor;
			}
		}

		// Token: 0x060070D4 RID: 28884 RVA: 0x00114D6D File Offset: 0x00112F6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityItemBundleInfo()
		{
		}

		// Token: 0x060070D5 RID: 28885 RVA: 0x00114D75 File Offset: 0x00112F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityItemBundleInfo(EntityItemBundleInfo other) : this()
		{
			this.entityId_ = other.entityId_;
			this.itemId_ = other.itemId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060070D6 RID: 28886 RVA: 0x00114DA6 File Offset: 0x00112FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityItemBundleInfo Clone()
		{
			return new EntityItemBundleInfo(this);
		}

		// Token: 0x170015C1 RID: 5569
		// (get) Token: 0x060070D7 RID: 28887 RVA: 0x00114DAE File Offset: 0x00112FAE
		// (set) Token: 0x060070D8 RID: 28888 RVA: 0x00114DB6 File Offset: 0x00112FB6
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

		// Token: 0x170015C2 RID: 5570
		// (get) Token: 0x060070D9 RID: 28889 RVA: 0x00114DBF File Offset: 0x00112FBF
		// (set) Token: 0x060070DA RID: 28890 RVA: 0x00114DC7 File Offset: 0x00112FC7
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

		// Token: 0x060070DB RID: 28891 RVA: 0x00114DD0 File Offset: 0x00112FD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityItemBundleInfo);
		}

		// Token: 0x060070DC RID: 28892 RVA: 0x00114DDE File Offset: 0x00112FDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityItemBundleInfo other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.ItemId == other.ItemId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060070DD RID: 28893 RVA: 0x00114E1C File Offset: 0x0011301C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
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

		// Token: 0x060070DE RID: 28894 RVA: 0x00114E74 File Offset: 0x00113074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060070DF RID: 28895 RVA: 0x00114E81 File Offset: 0x00113081
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060070E0 RID: 28896 RVA: 0x00114E8C File Offset: 0x0011308C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
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

		// Token: 0x060070E1 RID: 28897 RVA: 0x00114EE4 File Offset: 0x001130E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
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

		// Token: 0x060070E2 RID: 28898 RVA: 0x00114F3C File Offset: 0x0011313C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityItemBundleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060070E3 RID: 28899 RVA: 0x00114F8C File Offset: 0x0011318C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060070E4 RID: 28900 RVA: 0x00114F98 File Offset: 0x00113198
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
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003C54 RID: 15444
		private static readonly MessageParser<EntityItemBundleInfo> _parser = new MessageParser<EntityItemBundleInfo>(() => new EntityItemBundleInfo());

		// Token: 0x04003C55 RID: 15445
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C56 RID: 15446
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04003C57 RID: 15447
		private long entityId_;

		// Token: 0x04003C58 RID: 15448
		public const int ItemIdFieldNumber = 2;

		// Token: 0x04003C59 RID: 15449
		private int itemId_;
	}
}
