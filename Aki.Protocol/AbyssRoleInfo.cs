using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000044 RID: 68
	public sealed class AbyssRoleInfo : IMessage<AbyssRoleInfo>, IMessage, IEquatable<AbyssRoleInfo>, IDeepCloneable<AbyssRoleInfo>, IBufferMessage
	{
		// Token: 0x0600140B RID: 5131 RVA: 0x00035FAD File Offset: 0x000341AD
		[NullableContext(1)]
		public static AbyssRoleInfo Create()
		{
			return new AbyssRoleInfo();
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x00035FB4 File Offset: 0x000341B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AbyssRoleInfo> Parser
		{
			get
			{
				return AbyssRoleInfo._parser;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600140D RID: 5133 RVA: 0x00035FBB File Offset: 0x000341BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600140E RID: 5134 RVA: 0x00035FBE File Offset: 0x000341BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRoleInfo.Descriptor;
			}
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00035FC5 File Offset: 0x000341C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleInfo()
		{
		}

		// Token: 0x06001410 RID: 5136 RVA: 0x00035FD8 File Offset: 0x000341D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleInfo(AbyssRoleInfo other) : this()
		{
			this.id_ = other.id_;
			this.level_ = other.level_;
			this.equipItems_ = other.equipItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001411 RID: 5137 RVA: 0x00036025 File Offset: 0x00034225
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleInfo Clone()
		{
			return new AbyssRoleInfo(this);
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x0003602D File Offset: 0x0003422D
		// (set) Token: 0x06001413 RID: 5139 RVA: 0x00036035 File Offset: 0x00034235
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
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

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06001414 RID: 5140 RVA: 0x0003603E File Offset: 0x0003423E
		// (set) Token: 0x06001415 RID: 5141 RVA: 0x00036046 File Offset: 0x00034246
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06001416 RID: 5142 RVA: 0x0003604F File Offset: 0x0003424F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EquipItems
		{
			get
			{
				return this.equipItems_;
			}
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x00036057 File Offset: 0x00034257
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRoleInfo);
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x00036068 File Offset: 0x00034268
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRoleInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && this.equipItems_.Equals(other.equipItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x000360C8 File Offset: 0x000342C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			num ^= this.equipItems_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x0003612E File Offset: 0x0003432E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x0003613B File Offset: 0x0003433B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x00036144 File Offset: 0x00034344
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			this.equipItems_.WriteTo(ref output, AbyssRoleInfo._repeated_equipItems_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600141D RID: 5149 RVA: 0x000361B0 File Offset: 0x000343B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			num += this.equipItems_.CalculateSize(AbyssRoleInfo._repeated_equipItems_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600141E RID: 5150 RVA: 0x0003621C File Offset: 0x0003441C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssRoleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this.equipItems_.Add(other.equipItems_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600141F RID: 5151 RVA: 0x0003627D File Offset: 0x0003447D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001420 RID: 5152 RVA: 0x00036288 File Offset: 0x00034488
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Level = input.ReadInt32();
						continue;
					}
				}
				else if (num == 24U || num == 26U)
				{
					this.equipItems_.AddEntriesFrom(ref input, AbyssRoleInfo._repeated_equipItems_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002085 RID: 8325
		private static readonly MessageParser<AbyssRoleInfo> _parser = new MessageParser<AbyssRoleInfo>(() => new AbyssRoleInfo());

		// Token: 0x04002086 RID: 8326
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002087 RID: 8327
		public const int IdFieldNumber = 1;

		// Token: 0x04002088 RID: 8328
		private int id_;

		// Token: 0x04002089 RID: 8329
		public const int LevelFieldNumber = 2;

		// Token: 0x0400208A RID: 8330
		private int level_;

		// Token: 0x0400208B RID: 8331
		public const int EquipItemsFieldNumber = 3;

		// Token: 0x0400208C RID: 8332
		private static readonly FieldCodec<int> _repeated_equipItems_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400208D RID: 8333
		private readonly RepeatedField<int> equipItems_ = new RepeatedField<int>();
	}
}
