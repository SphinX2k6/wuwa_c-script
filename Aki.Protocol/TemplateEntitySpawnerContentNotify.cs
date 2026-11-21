using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013BA RID: 5050
	[NetMessage(EMessageId.TemplateEntitySpawnerContentNotify)]
	public sealed class TemplateEntitySpawnerContentNotify : IMessage<TemplateEntitySpawnerContentNotify>, IMessage, IEquatable<TemplateEntitySpawnerContentNotify>, IDeepCloneable<TemplateEntitySpawnerContentNotify>, IBufferMessage
	{
		// Token: 0x0601AE09 RID: 110089 RVA: 0x003EA25F File Offset: 0x003E845F
		[NullableContext(1)]
		public static TemplateEntitySpawnerContentNotify Create()
		{
			return new TemplateEntitySpawnerContentNotify();
		}

		// Token: 0x17005B06 RID: 23302
		// (get) Token: 0x0601AE0A RID: 110090 RVA: 0x003EA266 File Offset: 0x003E8466
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B07 RID: 23303
		// (get) Token: 0x0601AE0B RID: 110091 RVA: 0x003EA269 File Offset: 0x003E8469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TemplateEntitySpawnerContentNotify.Descriptor;
			}
		}

		// Token: 0x0601AE0C RID: 110092 RVA: 0x003EA270 File Offset: 0x003E8470
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemplateEntitySpawnerContentNotify()
		{
		}

		// Token: 0x0601AE0D RID: 110093 RVA: 0x003EA284 File Offset: 0x003E8484
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemplateEntitySpawnerContentNotify(TemplateEntitySpawnerContentNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.spawnerType_ = other.spawnerType_;
			this.createEntityInfos_ = other.createEntityInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AE0E RID: 110094 RVA: 0x003EA2D1 File Offset: 0x003E84D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemplateEntitySpawnerContentNotify Clone()
		{
			return new TemplateEntitySpawnerContentNotify(this);
		}

		// Token: 0x17005B08 RID: 23304
		// (get) Token: 0x0601AE0F RID: 110095 RVA: 0x003EA2D9 File Offset: 0x003E84D9
		// (set) Token: 0x0601AE10 RID: 110096 RVA: 0x003EA2E1 File Offset: 0x003E84E1
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

		// Token: 0x17005B09 RID: 23305
		// (get) Token: 0x0601AE11 RID: 110097 RVA: 0x003EA2EA File Offset: 0x003E84EA
		// (set) Token: 0x0601AE12 RID: 110098 RVA: 0x003EA2F2 File Offset: 0x003E84F2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemplateSpawnerType SpawnerType
		{
			get
			{
				return this.spawnerType_;
			}
			set
			{
				this.spawnerType_ = value;
			}
		}

		// Token: 0x17005B0A RID: 23306
		// (get) Token: 0x0601AE13 RID: 110099 RVA: 0x003EA2FB File Offset: 0x003E84FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SpawnerEntityInfo> CreateEntityInfos
		{
			get
			{
				return this.createEntityInfos_;
			}
		}

		// Token: 0x0601AE14 RID: 110100 RVA: 0x003EA303 File Offset: 0x003E8503
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TemplateEntitySpawnerContentNotify);
		}

		// Token: 0x0601AE15 RID: 110101 RVA: 0x003EA314 File Offset: 0x003E8514
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TemplateEntitySpawnerContentNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.SpawnerType == other.SpawnerType && this.createEntityInfos_.Equals(other.createEntityInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AE16 RID: 110102 RVA: 0x003EA374 File Offset: 0x003E8574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.SpawnerType != TemplateSpawnerType.TemplateDefault)
			{
				num ^= this.SpawnerType.GetHashCode();
			}
			num ^= this.createEntityInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AE17 RID: 110103 RVA: 0x003EA3E0 File Offset: 0x003E85E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AE18 RID: 110104 RVA: 0x003EA3ED File Offset: 0x003E85ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AE19 RID: 110105 RVA: 0x003EA3F8 File Offset: 0x003E85F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.EntityId);
			}
			if (this.SpawnerType != TemplateSpawnerType.TemplateDefault)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.SpawnerType);
			}
			this.createEntityInfos_.WriteTo(ref output, TemplateEntitySpawnerContentNotify._repeated_createEntityInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AE1A RID: 110106 RVA: 0x003EA464 File Offset: 0x003E8664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.SpawnerType != TemplateSpawnerType.TemplateDefault)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SpawnerType);
			}
			num += this.createEntityInfos_.CalculateSize(TemplateEntitySpawnerContentNotify._repeated_createEntityInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AE1B RID: 110107 RVA: 0x003EA4D0 File Offset: 0x003E86D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TemplateEntitySpawnerContentNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.SpawnerType != TemplateSpawnerType.TemplateDefault)
			{
				this.SpawnerType = other.SpawnerType;
			}
			this.createEntityInfos_.Add(other.createEntityInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AE1C RID: 110108 RVA: 0x003EA531 File Offset: 0x003E8731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AE1D RID: 110109 RVA: 0x003EA53C File Offset: 0x003E873C
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
					if (num != 32U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.createEntityInfos_.AddEntriesFrom(ref input, TemplateEntitySpawnerContentNotify._repeated_createEntityInfos_codec);
						}
					}
					else
					{
						this.SpawnerType = (TemplateSpawnerType)input.ReadEnum();
					}
				}
				else
				{
					this.EntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04009D39 RID: 40249
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D3A RID: 40250
		public const int EntityIdFieldNumber = 1;

		// Token: 0x04009D3B RID: 40251
		private long entityId_;

		// Token: 0x04009D3C RID: 40252
		public const int SpawnerTypeFieldNumber = 4;

		// Token: 0x04009D3D RID: 40253
		private TemplateSpawnerType spawnerType_;

		// Token: 0x04009D3E RID: 40254
		public const int CreateEntityInfosFieldNumber = 14;

		// Token: 0x04009D3F RID: 40255
		private static readonly FieldCodec<SpawnerEntityInfo> _repeated_createEntityInfos_codec = FieldCodec.ForMessage<SpawnerEntityInfo>(114U, SpawnerEntityInfo.Parser);

		// Token: 0x04009D40 RID: 40256
		private readonly RepeatedField<SpawnerEntityInfo> createEntityInfos_ = new RepeatedField<SpawnerEntityInfo>();
	}
}
