using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200047E RID: 1150
	[NetMessage(EMessageId.EntityCommonTagNotify)]
	public sealed class EntityCommonTagNotify : IMessage<EntityCommonTagNotify>, IMessage, IEquatable<EntityCommonTagNotify>, IDeepCloneable<EntityCommonTagNotify>, IBufferMessage
	{
		// Token: 0x06006D72 RID: 28018 RVA: 0x00107F8B File Offset: 0x0010618B
		[NullableContext(1)]
		public static EntityCommonTagNotify Create()
		{
			return new EntityCommonTagNotify();
		}

		// Token: 0x170014CE RID: 5326
		// (get) Token: 0x06006D73 RID: 28019 RVA: 0x00107F92 File Offset: 0x00106192
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170014CF RID: 5327
		// (get) Token: 0x06006D74 RID: 28020 RVA: 0x00107F95 File Offset: 0x00106195
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EntityCommonTagNotify.Descriptor;
			}
		}

		// Token: 0x06006D75 RID: 28021 RVA: 0x00107F9C File Offset: 0x0010619C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCommonTagNotify()
		{
		}

		// Token: 0x06006D76 RID: 28022 RVA: 0x00107FAF File Offset: 0x001061AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCommonTagNotify(EntityCommonTagNotify other) : this()
		{
			this.id_ = other.id_;
			this.tags_ = other.tags_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006D77 RID: 28023 RVA: 0x00107FE5 File Offset: 0x001061E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EntityCommonTagNotify Clone()
		{
			return new EntityCommonTagNotify(this);
		}

		// Token: 0x170014D0 RID: 5328
		// (get) Token: 0x06006D78 RID: 28024 RVA: 0x00107FED File Offset: 0x001061ED
		// (set) Token: 0x06006D79 RID: 28025 RVA: 0x00107FF5 File Offset: 0x001061F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170014D1 RID: 5329
		// (get) Token: 0x06006D7A RID: 28026 RVA: 0x00107FFE File Offset: 0x001061FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<CommonTagData> Tags
		{
			get
			{
				return this.tags_;
			}
		}

		// Token: 0x06006D7B RID: 28027 RVA: 0x00108006 File Offset: 0x00106206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EntityCommonTagNotify);
		}

		// Token: 0x06006D7C RID: 28028 RVA: 0x00108014 File Offset: 0x00106214
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EntityCommonTagNotify other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.tags_.Equals(other.tags_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06006D7D RID: 28029 RVA: 0x00108064 File Offset: 0x00106264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0L)
			{
				num ^= this.Id.GetHashCode();
			}
			num ^= this.tags_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06006D7E RID: 28030 RVA: 0x001080B1 File Offset: 0x001062B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06006D7F RID: 28031 RVA: 0x001080BE File Offset: 0x001062BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06006D80 RID: 28032 RVA: 0x001080C8 File Offset: 0x001062C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.Id);
			}
			this.tags_.WriteTo(ref output, EntityCommonTagNotify._repeated_tags_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06006D81 RID: 28033 RVA: 0x00108118 File Offset: 0x00106318
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.Id);
			}
			num += this.tags_.CalculateSize(EntityCommonTagNotify._repeated_tags_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06006D82 RID: 28034 RVA: 0x0010816C File Offset: 0x0010636C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EntityCommonTagNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0L)
			{
				this.Id = other.Id;
			}
			this.tags_.Add(other.tags_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006D83 RID: 28035 RVA: 0x001081B9 File Offset: 0x001063B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006D84 RID: 28036 RVA: 0x001081C4 File Offset: 0x001063C4
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
				if (num != 40U)
				{
					if (num != 50U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.tags_.AddEntriesFrom(ref input, EntityCommonTagNotify._repeated_tags_codec);
					}
				}
				else
				{
					this.Id = input.ReadInt64();
				}
			}
		}

		// Token: 0x04003B34 RID: 15156
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003B35 RID: 15157
		public const int IdFieldNumber = 5;

		// Token: 0x04003B36 RID: 15158
		private long id_;

		// Token: 0x04003B37 RID: 15159
		public const int TagsFieldNumber = 6;

		// Token: 0x04003B38 RID: 15160
		private static readonly FieldCodec<CommonTagData> _repeated_tags_codec = FieldCodec.ForMessage<CommonTagData>(50U, CommonTagData.Parser);

		// Token: 0x04003B39 RID: 15161
		private readonly RepeatedField<CommonTagData> tags_ = new RepeatedField<CommonTagData>();
	}
}
