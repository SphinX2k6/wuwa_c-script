using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol.Debug
{
	// Token: 0x02001690 RID: 5776
	[NetMessage(EMessageId.CheatInputRequest)]
	public sealed class CheatInputRequest : IMessage<CheatInputRequest>, IMessage, IEquatable<CheatInputRequest>, IDeepCloneable<CheatInputRequest>, IBufferMessage
	{
		// Token: 0x0601CF03 RID: 118531 RVA: 0x0043BD7F File Offset: 0x00439F7F
		[NullableContext(1)]
		public static CheatInputRequest Create()
		{
			return new CheatInputRequest();
		}

		// Token: 0x17006224 RID: 25124
		// (get) Token: 0x0601CF04 RID: 118532 RVA: 0x0043BD86 File Offset: 0x00439F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006225 RID: 25125
		// (get) Token: 0x0601CF05 RID: 118533 RVA: 0x0043BD89 File Offset: 0x00439F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return CheatInputRequest.Descriptor;
			}
		}

		// Token: 0x0601CF06 RID: 118534 RVA: 0x0043BD90 File Offset: 0x00439F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheatInputRequest()
		{
		}

		// Token: 0x0601CF07 RID: 118535 RVA: 0x0043BDA4 File Offset: 0x00439FA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheatInputRequest(CheatInputRequest other) : this()
		{
			this.type_ = other.type_;
			this.aoeDestroyEnemyRange_ = other.aoeDestroyEnemyRange_;
			this.entityList_ = other.entityList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CF08 RID: 118536 RVA: 0x0043BDF1 File Offset: 0x00439FF1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public CheatInputRequest Clone()
		{
			return new CheatInputRequest(this);
		}

		// Token: 0x17006226 RID: 25126
		// (get) Token: 0x0601CF09 RID: 118537 RVA: 0x0043BDF9 File Offset: 0x00439FF9
		// (set) Token: 0x0601CF0A RID: 118538 RVA: 0x0043BE01 File Offset: 0x0043A001
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ECheatInput Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17006227 RID: 25127
		// (get) Token: 0x0601CF0B RID: 118539 RVA: 0x0043BE0A File Offset: 0x0043A00A
		// (set) Token: 0x0601CF0C RID: 118540 RVA: 0x0043BE12 File Offset: 0x0043A012
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int AoeDestroyEnemyRange
		{
			get
			{
				return this.aoeDestroyEnemyRange_;
			}
			set
			{
				this.aoeDestroyEnemyRange_ = value;
			}
		}

		// Token: 0x17006228 RID: 25128
		// (get) Token: 0x0601CF0D RID: 118541 RVA: 0x0043BE1B File Offset: 0x0043A01B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> EntityList
		{
			get
			{
				return this.entityList_;
			}
		}

		// Token: 0x0601CF0E RID: 118542 RVA: 0x0043BE23 File Offset: 0x0043A023
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as CheatInputRequest);
		}

		// Token: 0x0601CF0F RID: 118543 RVA: 0x0043BE34 File Offset: 0x0043A034
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(CheatInputRequest other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.AoeDestroyEnemyRange == other.AoeDestroyEnemyRange && this.entityList_.Equals(other.entityList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CF10 RID: 118544 RVA: 0x0043BE94 File Offset: 0x0043A094
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != ECheatInput.Default)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.AoeDestroyEnemyRange != 0)
			{
				num ^= this.AoeDestroyEnemyRange.GetHashCode();
			}
			num ^= this.entityList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601CF11 RID: 118545 RVA: 0x0043BF00 File Offset: 0x0043A100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CF12 RID: 118546 RVA: 0x0043BF0D File Offset: 0x0043A10D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CF13 RID: 118547 RVA: 0x0043BF18 File Offset: 0x0043A118
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != ECheatInput.Default)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.Type);
			}
			this.entityList_.WriteTo(ref output, CheatInputRequest._repeated_entityList_codec);
			if (this.AoeDestroyEnemyRange != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.AoeDestroyEnemyRange);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CF14 RID: 118548 RVA: 0x0043BF84 File Offset: 0x0043A184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != ECheatInput.Default)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.AoeDestroyEnemyRange != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.AoeDestroyEnemyRange);
			}
			num += this.entityList_.CalculateSize(CheatInputRequest._repeated_entityList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601CF15 RID: 118549 RVA: 0x0043BFF0 File Offset: 0x0043A1F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CheatInputRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != ECheatInput.Default)
			{
				this.Type = other.Type;
			}
			if (other.AoeDestroyEnemyRange != 0)
			{
				this.AoeDestroyEnemyRange = other.AoeDestroyEnemyRange;
			}
			this.entityList_.Add(other.entityList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601CF16 RID: 118550 RVA: 0x0043C051 File Offset: 0x0043A251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CF17 RID: 118551 RVA: 0x0043C05C File Offset: 0x0043A25C
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
				if (num <= 64U)
				{
					if (num == 8U)
					{
						this.Type = (ECheatInput)input.ReadEnum();
						continue;
					}
					if (num == 64U)
					{
						goto IL_45;
					}
				}
				else
				{
					if (num == 66U)
					{
						goto IL_45;
					}
					if (num == 104U)
					{
						this.AoeDestroyEnemyRange = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_45:
				this.entityList_.AddEntriesFrom(ref input, CheatInputRequest._repeated_entityList_codec);
			}
		}

		// Token: 0x0400C361 RID: 50017
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400C362 RID: 50018
		public const int TypeFieldNumber = 1;

		// Token: 0x0400C363 RID: 50019
		private ECheatInput type_;

		// Token: 0x0400C364 RID: 50020
		public const int AoeDestroyEnemyRangeFieldNumber = 13;

		// Token: 0x0400C365 RID: 50021
		private int aoeDestroyEnemyRange_;

		// Token: 0x0400C366 RID: 50022
		public const int EntityListFieldNumber = 8;

		// Token: 0x0400C367 RID: 50023
		private static readonly FieldCodec<long> _repeated_entityList_codec = FieldCodec.ForInt64(66U);

		// Token: 0x0400C368 RID: 50024
		private readonly RepeatedField<long> entityList_ = new RepeatedField<long>();
	}
}
