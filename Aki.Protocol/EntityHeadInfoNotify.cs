using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000495 RID: 1173
	[NetMessage(EMessageId.EntityHeadInfoNotify)]
	public sealed class EntityHeadInfoNotify : IMessage<EntityHeadInfoNotify>, IMessage, IEquatable<EntityHeadInfoNotify>, IDeepCloneable<EntityHeadInfoNotify>, IBufferMessage
	{
		// Token: 0x06007012 RID: 28690 RVA: 0x0011311C File Offset: 0x0011131C
		[NullableContext(1)]
		public static EntityHeadInfoNotify Create()
		{
			return new EntityHeadInfoNotify();
		}

		// Token: 0x17001595 RID: 5525
		// (get) Token: 0x06007013 RID: 28691 RVA: 0x00113123 File Offset: 0x00111323
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001596 RID: 5526
		// (get) Token: 0x06007014 RID: 28692 RVA: 0x00113126 File Offset: 0x00111326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityHeadInfoNotify.Descriptor;
			}
		}

		// Token: 0x06007015 RID: 28693 RVA: 0x0011312D File Offset: 0x0011132D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityHeadInfoNotify()
		{
		}

		// Token: 0x06007016 RID: 28694 RVA: 0x00113158 File Offset: 0x00111358
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityHeadInfoNotify(EntityHeadInfoNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.tidName_ = other.tidName_;
			this.icon_ = other.icon_;
			this.secondaryName_ = other.secondaryName_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007017 RID: 28695 RVA: 0x001131AC File Offset: 0x001113AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityHeadInfoNotify Clone()
		{
			return new EntityHeadInfoNotify(this);
		}

		// Token: 0x17001597 RID: 5527
		// (get) Token: 0x06007018 RID: 28696 RVA: 0x001131B4 File Offset: 0x001113B4
		// (set) Token: 0x06007019 RID: 28697 RVA: 0x001131BC File Offset: 0x001113BC
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

		// Token: 0x17001598 RID: 5528
		// (get) Token: 0x0600701A RID: 28698 RVA: 0x001131C5 File Offset: 0x001113C5
		// (set) Token: 0x0600701B RID: 28699 RVA: 0x001131CD File Offset: 0x001113CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string TidName
		{
			get
			{
				return this.tidName_;
			}
			set
			{
				this.tidName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17001599 RID: 5529
		// (get) Token: 0x0600701C RID: 28700 RVA: 0x001131E0 File Offset: 0x001113E0
		// (set) Token: 0x0600701D RID: 28701 RVA: 0x001131E8 File Offset: 0x001113E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string Icon
		{
			get
			{
				return this.icon_;
			}
			set
			{
				this.icon_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x1700159A RID: 5530
		// (get) Token: 0x0600701E RID: 28702 RVA: 0x001131FB File Offset: 0x001113FB
		// (set) Token: 0x0600701F RID: 28703 RVA: 0x00113203 File Offset: 0x00111403
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string SecondaryName
		{
			get
			{
				return this.secondaryName_;
			}
			set
			{
				this.secondaryName_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x06007020 RID: 28704 RVA: 0x00113216 File Offset: 0x00111416
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityHeadInfoNotify);
		}

		// Token: 0x06007021 RID: 28705 RVA: 0x00113224 File Offset: 0x00111424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityHeadInfoNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && !(this.TidName != other.TidName) && !(this.Icon != other.Icon) && !(this.SecondaryName != other.SecondaryName) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007022 RID: 28706 RVA: 0x0011329C File Offset: 0x0011149C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.TidName.Length != 0)
			{
				num ^= this.TidName.GetHashCode();
			}
			if (this.Icon.Length != 0)
			{
				num ^= this.Icon.GetHashCode();
			}
			if (this.SecondaryName.Length != 0)
			{
				num ^= this.SecondaryName.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06007023 RID: 28707 RVA: 0x0011332C File Offset: 0x0011152C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007024 RID: 28708 RVA: 0x00113339 File Offset: 0x00111539
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007025 RID: 28709 RVA: 0x00113344 File Offset: 0x00111544
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SecondaryName.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(this.SecondaryName);
			}
			if (this.Icon.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(this.Icon);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(56);
				output.WriteInt64(this.EntityId);
			}
			if (this.TidName.Length != 0)
			{
				output.WriteRawTag(98);
				output.WriteString(this.TidName);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007026 RID: 28710 RVA: 0x001133E4 File Offset: 0x001115E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.TidName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.TidName);
			}
			if (this.Icon.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.Icon);
			}
			if (this.SecondaryName.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.SecondaryName);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06007027 RID: 28711 RVA: 0x0011347C File Offset: 0x0011167C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityHeadInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.TidName.Length != 0)
			{
				this.TidName = other.TidName;
			}
			if (other.Icon.Length != 0)
			{
				this.Icon = other.Icon;
			}
			if (other.SecondaryName.Length != 0)
			{
				this.SecondaryName = other.SecondaryName;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007028 RID: 28712 RVA: 0x00113503 File Offset: 0x00111703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007029 RID: 28713 RVA: 0x0011350C File Offset: 0x0011170C
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
				if (num <= 42U)
				{
					if (num == 34U)
					{
						this.SecondaryName = input.ReadString();
						continue;
					}
					if (num == 42U)
					{
						this.Icon = input.ReadString();
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 98U)
					{
						this.TidName = input.ReadString();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003C1D RID: 15389
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003C1E RID: 15390
		public const int EntityIdFieldNumber = 7;

		// Token: 0x04003C1F RID: 15391
		private long entityId_;

		// Token: 0x04003C20 RID: 15392
		public const int TidNameFieldNumber = 12;

		// Token: 0x04003C21 RID: 15393
		private string tidName_ = "";

		// Token: 0x04003C22 RID: 15394
		public const int IconFieldNumber = 5;

		// Token: 0x04003C23 RID: 15395
		private string icon_ = "";

		// Token: 0x04003C24 RID: 15396
		public const int SecondaryNameFieldNumber = 4;

		// Token: 0x04003C25 RID: 15397
		private string secondaryName_ = "";
	}
}
