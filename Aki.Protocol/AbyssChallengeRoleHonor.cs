using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200001E RID: 30
	public sealed class AbyssChallengeRoleHonor : IMessage<AbyssChallengeRoleHonor>, IMessage, IEquatable<AbyssChallengeRoleHonor>, IDeepCloneable<AbyssChallengeRoleHonor>, IBufferMessage
	{
		// Token: 0x060010F6 RID: 4342 RVA: 0x0002F312 File Offset: 0x0002D512
		[NullableContext(1)]
		public static AbyssChallengeRoleHonor Create()
		{
			return new AbyssChallengeRoleHonor();
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x0002F319 File Offset: 0x0002D519
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AbyssChallengeRoleHonor> Parser
		{
			get
			{
				return AbyssChallengeRoleHonor._parser;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060010F8 RID: 4344 RVA: 0x0002F320 File Offset: 0x0002D520
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x0002F323 File Offset: 0x0002D523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeRoleHonor.Descriptor;
			}
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x0002F32A File Offset: 0x0002D52A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeRoleHonor()
		{
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x0002F332 File Offset: 0x0002D532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeRoleHonor(AbyssChallengeRoleHonor other) : this()
		{
			this.type_ = other.type_;
			this.value_ = other.value_;
			this.rankValue_ = other.rankValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x0002F36F File Offset: 0x0002D56F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeRoleHonor Clone()
		{
			return new AbyssChallengeRoleHonor(this);
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x0002F377 File Offset: 0x0002D577
		// (set) Token: 0x060010FE RID: 4350 RVA: 0x0002F37F File Offset: 0x0002D57F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Type
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

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x0002F388 File Offset: 0x0002D588
		// (set) Token: 0x06001100 RID: 4352 RVA: 0x0002F390 File Offset: 0x0002D590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Value
		{
			get
			{
				return this.value_;
			}
			set
			{
				this.value_ = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x0002F399 File Offset: 0x0002D599
		// (set) Token: 0x06001102 RID: 4354 RVA: 0x0002F3A1 File Offset: 0x0002D5A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RankValue
		{
			get
			{
				return this.rankValue_;
			}
			set
			{
				this.rankValue_ = value;
			}
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x0002F3AA File Offset: 0x0002D5AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeRoleHonor);
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x0002F3B8 File Offset: 0x0002D5B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeRoleHonor other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Value == other.Value && this.RankValue == other.RankValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x0002F414 File Offset: 0x0002D614
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Type != 0)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Value != 0)
			{
				num ^= this.Value.GetHashCode();
			}
			if (this.RankValue != 0)
			{
				num ^= this.RankValue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x0002F485 File Offset: 0x0002D685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x0002F492 File Offset: 0x0002D692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x0002F49C File Offset: 0x0002D69C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Type != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Type);
			}
			if (this.Value != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Value);
			}
			if (this.RankValue != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RankValue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x0002F510 File Offset: 0x0002D710
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Type != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Type);
			}
			if (this.Value != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Value);
			}
			if (this.RankValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RankValue);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0002F580 File Offset: 0x0002D780
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssChallengeRoleHonor other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Type != 0)
			{
				this.Type = other.Type;
			}
			if (other.Value != 0)
			{
				this.Value = other.Value;
			}
			if (other.RankValue != 0)
			{
				this.RankValue = other.RankValue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0002F5E4 File Offset: 0x0002D7E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0002F5F0 File Offset: 0x0002D7F0
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RankValue = input.ReadInt32();
						}
					}
					else
					{
						this.Value = input.ReadInt32();
					}
				}
				else
				{
					this.Type = input.ReadInt32();
				}
			}
		}

		// Token: 0x04001F89 RID: 8073
		private static readonly MessageParser<AbyssChallengeRoleHonor> _parser = new MessageParser<AbyssChallengeRoleHonor>(() => new AbyssChallengeRoleHonor());

		// Token: 0x04001F8A RID: 8074
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F8B RID: 8075
		public const int TypeFieldNumber = 1;

		// Token: 0x04001F8C RID: 8076
		private int type_;

		// Token: 0x04001F8D RID: 8077
		public const int ValueFieldNumber = 2;

		// Token: 0x04001F8E RID: 8078
		private int value_;

		// Token: 0x04001F8F RID: 8079
		public const int RankValueFieldNumber = 3;

		// Token: 0x04001F90 RID: 8080
		private int rankValue_;
	}
}
