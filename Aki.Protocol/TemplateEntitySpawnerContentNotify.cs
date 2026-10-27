using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001347 RID: 4935
	[NetMessage(EMessageId.TemplateEntitySpawnerContentNotify)]
	public sealed class TemplateEntitySpawnerContentNotify : IMessage<TemplateEntitySpawnerContentNotify>, IMessage, IEquatable<TemplateEntitySpawnerContentNotify>, IDeepCloneable<TemplateEntitySpawnerContentNotify>, IBufferMessage
	{
		// Token: 0x0601A382 RID: 107394 RVA: 0x003CF12F File Offset: 0x003CD32F
		[NullableContext(1)]
		public static TemplateEntitySpawnerContentNotify Create()
		{
			return new TemplateEntitySpawnerContentNotify();
		}

		// Token: 0x17005873 RID: 22643
		// (get) Token: 0x0601A383 RID: 107395 RVA: 0x003CF136 File Offset: 0x003CD336
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005874 RID: 22644
		// (get) Token: 0x0601A384 RID: 107396 RVA: 0x003CF139 File Offset: 0x003CD339
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TemplateEntitySpawnerContentNotify.Descriptor;
			}
		}

		// Token: 0x0601A385 RID: 107397 RVA: 0x003CF140 File Offset: 0x003CD340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemplateEntitySpawnerContentNotify()
		{
		}

		// Token: 0x0601A386 RID: 107398 RVA: 0x003CF154 File Offset: 0x003CD354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemplateEntitySpawnerContentNotify(TemplateEntitySpawnerContentNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.spawnerType_ = other.spawnerType_;
			this.createEntityInfos_ = other.createEntityInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A387 RID: 107399 RVA: 0x003CF1A1 File Offset: 0x003CD3A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemplateEntitySpawnerContentNotify Clone()
		{
			return new TemplateEntitySpawnerContentNotify(this);
		}

		// Token: 0x17005875 RID: 22645
		// (get) Token: 0x0601A388 RID: 107400 RVA: 0x003CF1A9 File Offset: 0x003CD3A9
		// (set) Token: 0x0601A389 RID: 107401 RVA: 0x003CF1B1 File Offset: 0x003CD3B1
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

		// Token: 0x17005876 RID: 22646
		// (get) Token: 0x0601A38A RID: 107402 RVA: 0x003CF1BA File Offset: 0x003CD3BA
		// (set) Token: 0x0601A38B RID: 107403 RVA: 0x003CF1C2 File Offset: 0x003CD3C2
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

		// Token: 0x17005877 RID: 22647
		// (get) Token: 0x0601A38C RID: 107404 RVA: 0x003CF1CB File Offset: 0x003CD3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SpawnerEntityInfo> CreateEntityInfos
		{
			get
			{
				return this.createEntityInfos_;
			}
		}

		// Token: 0x0601A38D RID: 107405 RVA: 0x003CF1D3 File Offset: 0x003CD3D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TemplateEntitySpawnerContentNotify);
		}

		// Token: 0x0601A38E RID: 107406 RVA: 0x003CF1E4 File Offset: 0x003CD3E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TemplateEntitySpawnerContentNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.SpawnerType == other.SpawnerType && this.createEntityInfos_.Equals(other.createEntityInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A38F RID: 107407 RVA: 0x003CF244 File Offset: 0x003CD444
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

		// Token: 0x0601A390 RID: 107408 RVA: 0x003CF2B0 File Offset: 0x003CD4B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A391 RID: 107409 RVA: 0x003CF2BD File Offset: 0x003CD4BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A392 RID: 107410 RVA: 0x003CF2C8 File Offset: 0x003CD4C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.createEntityInfos_.WriteTo(ref output, TemplateEntitySpawnerContentNotify._repeated_createEntityInfos_codec);
			if (this.SpawnerType != TemplateSpawnerType.TemplateDefault)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.SpawnerType);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(112);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A393 RID: 107411 RVA: 0x003CF334 File Offset: 0x003CD534
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

		// Token: 0x0601A394 RID: 107412 RVA: 0x003CF3A0 File Offset: 0x003CD5A0
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

		// Token: 0x0601A395 RID: 107413 RVA: 0x003CF401 File Offset: 0x003CD601
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A396 RID: 107414 RVA: 0x003CF40C File Offset: 0x003CD60C
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
				if (num != 50U)
				{
					if (num != 80U)
					{
						if (num != 112U)
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
						this.SpawnerType = (TemplateSpawnerType)input.ReadEnum();
					}
				}
				else
				{
					this.createEntityInfos_.AddEntriesFrom(ref input, TemplateEntitySpawnerContentNotify._repeated_createEntityInfos_codec);
				}
			}
		}

		// Token: 0x040098F7 RID: 39159
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098F8 RID: 39160
		public const int EntityIdFieldNumber = 14;

		// Token: 0x040098F9 RID: 39161
		private long entityId_;

		// Token: 0x040098FA RID: 39162
		public const int SpawnerTypeFieldNumber = 10;

		// Token: 0x040098FB RID: 39163
		private TemplateSpawnerType spawnerType_;

		// Token: 0x040098FC RID: 39164
		public const int CreateEntityInfosFieldNumber = 6;

		// Token: 0x040098FD RID: 39165
		private static readonly FieldCodec<SpawnerEntityInfo> _repeated_createEntityInfos_codec = FieldCodec.ForMessage<SpawnerEntityInfo>(50U, SpawnerEntityInfo.Parser);

		// Token: 0x040098FE RID: 39166
		private readonly RepeatedField<SpawnerEntityInfo> createEntityInfos_ = new RepeatedField<SpawnerEntityInfo>();
	}
}
