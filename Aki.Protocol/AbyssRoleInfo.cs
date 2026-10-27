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
		// Token: 0x060013E0 RID: 5088 RVA: 0x000359F5 File Offset: 0x00033BF5
		[NullableContext(1)]
		public static AbyssRoleInfo Create()
		{
			return new AbyssRoleInfo();
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060013E1 RID: 5089 RVA: 0x000359FC File Offset: 0x00033BFC
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
		// (get) Token: 0x060013E2 RID: 5090 RVA: 0x00035A03 File Offset: 0x00033C03
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
		// (get) Token: 0x060013E3 RID: 5091 RVA: 0x00035A06 File Offset: 0x00033C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRoleInfo.Descriptor;
			}
		}

		// Token: 0x060013E4 RID: 5092 RVA: 0x00035A0D File Offset: 0x00033C0D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleInfo()
		{
		}

		// Token: 0x060013E5 RID: 5093 RVA: 0x00035A20 File Offset: 0x00033C20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleInfo(AbyssRoleInfo other) : this()
		{
			this.id_ = other.id_;
			this.level_ = other.level_;
			this.equipItems_ = other.equipItems_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060013E6 RID: 5094 RVA: 0x00035A6D File Offset: 0x00033C6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleInfo Clone()
		{
			return new AbyssRoleInfo(this);
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x00035A75 File Offset: 0x00033C75
		// (set) Token: 0x060013E8 RID: 5096 RVA: 0x00035A7D File Offset: 0x00033C7D
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
		// (get) Token: 0x060013E9 RID: 5097 RVA: 0x00035A86 File Offset: 0x00033C86
		// (set) Token: 0x060013EA RID: 5098 RVA: 0x00035A8E File Offset: 0x00033C8E
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
		// (get) Token: 0x060013EB RID: 5099 RVA: 0x00035A97 File Offset: 0x00033C97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> EquipItems
		{
			get
			{
				return this.equipItems_;
			}
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x00035A9F File Offset: 0x00033C9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRoleInfo);
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x00035AB0 File Offset: 0x00033CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRoleInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Level == other.Level && this.equipItems_.Equals(other.equipItems_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x00035B10 File Offset: 0x00033D10
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

		// Token: 0x060013EF RID: 5103 RVA: 0x00035B76 File Offset: 0x00033D76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x00035B83 File Offset: 0x00033D83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060013F1 RID: 5105 RVA: 0x00035B8C File Offset: 0x00033D8C
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

		// Token: 0x060013F2 RID: 5106 RVA: 0x00035BF8 File Offset: 0x00033DF8
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

		// Token: 0x060013F3 RID: 5107 RVA: 0x00035C64 File Offset: 0x00033E64
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

		// Token: 0x060013F4 RID: 5108 RVA: 0x00035CC5 File Offset: 0x00033EC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060013F5 RID: 5109 RVA: 0x00035CD0 File Offset: 0x00033ED0
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

		// Token: 0x0400202F RID: 8239
		private static readonly MessageParser<AbyssRoleInfo> _parser = new MessageParser<AbyssRoleInfo>(() => new AbyssRoleInfo());

		// Token: 0x04002030 RID: 8240
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002031 RID: 8241
		public const int IdFieldNumber = 1;

		// Token: 0x04002032 RID: 8242
		private int id_;

		// Token: 0x04002033 RID: 8243
		public const int LevelFieldNumber = 2;

		// Token: 0x04002034 RID: 8244
		private int level_;

		// Token: 0x04002035 RID: 8245
		public const int EquipItemsFieldNumber = 3;

		// Token: 0x04002036 RID: 8246
		private static readonly FieldCodec<int> _repeated_equipItems_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04002037 RID: 8247
		private readonly RepeatedField<int> equipItems_ = new RepeatedField<int>();
	}
}
