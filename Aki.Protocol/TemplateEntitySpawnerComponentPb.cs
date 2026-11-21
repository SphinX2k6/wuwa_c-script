using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013B9 RID: 5049
	public sealed class TemplateEntitySpawnerComponentPb : IMessage<TemplateEntitySpawnerComponentPb>, IMessage, IEquatable<TemplateEntitySpawnerComponentPb>, IDeepCloneable<TemplateEntitySpawnerComponentPb>, IBufferMessage
	{
		// Token: 0x0601ADF5 RID: 110069 RVA: 0x003E9FAE File Offset: 0x003E81AE
		[NullableContext(1)]
		public static TemplateEntitySpawnerComponentPb Create()
		{
			return new TemplateEntitySpawnerComponentPb();
		}

		// Token: 0x17005B02 RID: 23298
		// (get) Token: 0x0601ADF6 RID: 110070 RVA: 0x003E9FB5 File Offset: 0x003E81B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005B03 RID: 23299
		// (get) Token: 0x0601ADF7 RID: 110071 RVA: 0x003E9FB8 File Offset: 0x003E81B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TemplateEntitySpawnerComponentPb.Descriptor;
			}
		}

		// Token: 0x0601ADF8 RID: 110072 RVA: 0x003E9FBF File Offset: 0x003E81BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemplateEntitySpawnerComponentPb()
		{
		}

		// Token: 0x0601ADF9 RID: 110073 RVA: 0x003E9FD2 File Offset: 0x003E81D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemplateEntitySpawnerComponentPb(TemplateEntitySpawnerComponentPb other) : this()
		{
			this.spawnerType_ = other.spawnerType_;
			this.createEntityInfos_ = other.createEntityInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ADFA RID: 110074 RVA: 0x003EA008 File Offset: 0x003E8208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TemplateEntitySpawnerComponentPb Clone()
		{
			return new TemplateEntitySpawnerComponentPb(this);
		}

		// Token: 0x17005B04 RID: 23300
		// (get) Token: 0x0601ADFB RID: 110075 RVA: 0x003EA010 File Offset: 0x003E8210
		// (set) Token: 0x0601ADFC RID: 110076 RVA: 0x003EA018 File Offset: 0x003E8218
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

		// Token: 0x17005B05 RID: 23301
		// (get) Token: 0x0601ADFD RID: 110077 RVA: 0x003EA021 File Offset: 0x003E8221
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<SpawnerEntityInfo> CreateEntityInfos
		{
			get
			{
				return this.createEntityInfos_;
			}
		}

		// Token: 0x0601ADFE RID: 110078 RVA: 0x003EA029 File Offset: 0x003E8229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TemplateEntitySpawnerComponentPb);
		}

		// Token: 0x0601ADFF RID: 110079 RVA: 0x003EA038 File Offset: 0x003E8238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TemplateEntitySpawnerComponentPb other)
		{
			return other != null && (other == this || (this.SpawnerType == other.SpawnerType && this.createEntityInfos_.Equals(other.createEntityInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AE00 RID: 110080 RVA: 0x003EA088 File Offset: 0x003E8288
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

		// Token: 0x0601AE01 RID: 110081 RVA: 0x003EA0DB File Offset: 0x003E82DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AE02 RID: 110082 RVA: 0x003EA0E8 File Offset: 0x003E82E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AE03 RID: 110083 RVA: 0x003EA0F4 File Offset: 0x003E82F4
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

		// Token: 0x0601AE04 RID: 110084 RVA: 0x003EA144 File Offset: 0x003E8344
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

		// Token: 0x0601AE05 RID: 110085 RVA: 0x003EA198 File Offset: 0x003E8398
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

		// Token: 0x0601AE06 RID: 110086 RVA: 0x003EA1E5 File Offset: 0x003E83E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AE07 RID: 110087 RVA: 0x003EA1F0 File Offset: 0x003E83F0
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

		// Token: 0x04009D33 RID: 40243
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009D34 RID: 40244
		public const int SpawnerTypeFieldNumber = 1;

		// Token: 0x04009D35 RID: 40245
		private TemplateSpawnerType spawnerType_;

		// Token: 0x04009D36 RID: 40246
		public const int CreateEntityInfosFieldNumber = 2;

		// Token: 0x04009D37 RID: 40247
		private static readonly FieldCodec<SpawnerEntityInfo> _repeated_createEntityInfos_codec = FieldCodec.ForMessage<SpawnerEntityInfo>(18U, SpawnerEntityInfo.Parser);

		// Token: 0x04009D38 RID: 40248
		private readonly RepeatedField<SpawnerEntityInfo> createEntityInfos_ = new RepeatedField<SpawnerEntityInfo>();
	}
}
