using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001346 RID: 4934
	public sealed class TemplateEntitySpawnerComponentPb : IMessage<TemplateEntitySpawnerComponentPb>, IMessage, IEquatable<TemplateEntitySpawnerComponentPb>, IDeepCloneable<TemplateEntitySpawnerComponentPb>, IBufferMessage
	{
		// Token: 0x0601A36E RID: 107374 RVA: 0x003CEE7E File Offset: 0x003CD07E
		[NullableContext(1)]
		public static TemplateEntitySpawnerComponentPb Create()
		{
			return new TemplateEntitySpawnerComponentPb();
		}

		// Token: 0x1700586F RID: 22639
		// (get) Token: 0x0601A36F RID: 107375 RVA: 0x003CEE85 File Offset: 0x003CD085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005870 RID: 22640
		// (get) Token: 0x0601A370 RID: 107376 RVA: 0x003CEE88 File Offset: 0x003CD088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TemplateEntitySpawnerComponentPb.Descriptor;
			}
		}

		// Token: 0x0601A371 RID: 107377 RVA: 0x003CEE8F File Offset: 0x003CD08F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemplateEntitySpawnerComponentPb()
		{
		}

		// Token: 0x0601A372 RID: 107378 RVA: 0x003CEEA2 File Offset: 0x003CD0A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemplateEntitySpawnerComponentPb(TemplateEntitySpawnerComponentPb other) : this()
		{
			this.spawnerType_ = other.spawnerType_;
			this.createEntityInfos_ = other.createEntityInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A373 RID: 107379 RVA: 0x003CEED8 File Offset: 0x003CD0D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemplateEntitySpawnerComponentPb Clone()
		{
			return new TemplateEntitySpawnerComponentPb(this);
		}

		// Token: 0x17005871 RID: 22641
		// (get) Token: 0x0601A374 RID: 107380 RVA: 0x003CEEE0 File Offset: 0x003CD0E0
		// (set) Token: 0x0601A375 RID: 107381 RVA: 0x003CEEE8 File Offset: 0x003CD0E8
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

		// Token: 0x17005872 RID: 22642
		// (get) Token: 0x0601A376 RID: 107382 RVA: 0x003CEEF1 File Offset: 0x003CD0F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SpawnerEntityInfo> CreateEntityInfos
		{
			get
			{
				return this.createEntityInfos_;
			}
		}

		// Token: 0x0601A377 RID: 107383 RVA: 0x003CEEF9 File Offset: 0x003CD0F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TemplateEntitySpawnerComponentPb);
		}

		// Token: 0x0601A378 RID: 107384 RVA: 0x003CEF08 File Offset: 0x003CD108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TemplateEntitySpawnerComponentPb other)
		{
			return other != null && (other == this || (this.SpawnerType == other.SpawnerType && this.createEntityInfos_.Equals(other.createEntityInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A379 RID: 107385 RVA: 0x003CEF58 File Offset: 0x003CD158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
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

		// Token: 0x0601A37A RID: 107386 RVA: 0x003CEFAB File Offset: 0x003CD1AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A37B RID: 107387 RVA: 0x003CEFB8 File Offset: 0x003CD1B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A37C RID: 107388 RVA: 0x003CEFC4 File Offset: 0x003CD1C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SpawnerType != TemplateSpawnerType.TemplateDefault)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.SpawnerType);
			}
			this.createEntityInfos_.WriteTo(ref output, TemplateEntitySpawnerComponentPb._repeated_createEntityInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A37D RID: 107389 RVA: 0x003CF014 File Offset: 0x003CD214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SpawnerType != TemplateSpawnerType.TemplateDefault)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.SpawnerType);
			}
			num += this.createEntityInfos_.CalculateSize(TemplateEntitySpawnerComponentPb._repeated_createEntityInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A37E RID: 107390 RVA: 0x003CF068 File Offset: 0x003CD268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TemplateEntitySpawnerComponentPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SpawnerType != TemplateSpawnerType.TemplateDefault)
			{
				this.SpawnerType = other.SpawnerType;
			}
			this.createEntityInfos_.Add(other.createEntityInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A37F RID: 107391 RVA: 0x003CF0B5 File Offset: 0x003CD2B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A380 RID: 107392 RVA: 0x003CF0C0 File Offset: 0x003CD2C0
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
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.createEntityInfos_.AddEntriesFrom(ref input, TemplateEntitySpawnerComponentPb._repeated_createEntityInfos_codec);
					}
				}
				else
				{
					this.SpawnerType = (TemplateSpawnerType)input.ReadEnum();
				}
			}
		}

		// Token: 0x040098F1 RID: 39153
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098F2 RID: 39154
		public const int SpawnerTypeFieldNumber = 1;

		// Token: 0x040098F3 RID: 39155
		private TemplateSpawnerType spawnerType_;

		// Token: 0x040098F4 RID: 39156
		public const int CreateEntityInfosFieldNumber = 2;

		// Token: 0x040098F5 RID: 39157
		private static readonly FieldCodec<SpawnerEntityInfo> _repeated_createEntityInfos_codec = FieldCodec.ForMessage<SpawnerEntityInfo>(18U, SpawnerEntityInfo.Parser);

		// Token: 0x040098F6 RID: 39158
		private readonly RepeatedField<SpawnerEntityInfo> createEntityInfos_ = new RepeatedField<SpawnerEntityInfo>();
	}
}
