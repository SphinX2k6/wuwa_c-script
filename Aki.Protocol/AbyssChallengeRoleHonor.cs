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
		// Token: 0x060010CB RID: 4299 RVA: 0x0002ED5E File Offset: 0x0002CF5E
		[NullableContext(1)]
		public static AbyssChallengeRoleHonor Create()
		{
			return new AbyssChallengeRoleHonor();
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060010CC RID: 4300 RVA: 0x0002ED65 File Offset: 0x0002CF65
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
		// (get) Token: 0x060010CD RID: 4301 RVA: 0x0002ED6C File Offset: 0x0002CF6C
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
		// (get) Token: 0x060010CE RID: 4302 RVA: 0x0002ED6F File Offset: 0x0002CF6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssChallengeRoleHonor.Descriptor;
			}
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x0002ED76 File Offset: 0x0002CF76
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeRoleHonor()
		{
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x0002ED7E File Offset: 0x0002CF7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeRoleHonor(AbyssChallengeRoleHonor other) : this()
		{
			this.type_ = other.type_;
			this.value_ = other.value_;
			this.rankValue_ = other.rankValue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x0002EDBB File Offset: 0x0002CFBB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssChallengeRoleHonor Clone()
		{
			return new AbyssChallengeRoleHonor(this);
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060010D2 RID: 4306 RVA: 0x0002EDC3 File Offset: 0x0002CFC3
		// (set) Token: 0x060010D3 RID: 4307 RVA: 0x0002EDCB File Offset: 0x0002CFCB
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
		// (get) Token: 0x060010D4 RID: 4308 RVA: 0x0002EDD4 File Offset: 0x0002CFD4
		// (set) Token: 0x060010D5 RID: 4309 RVA: 0x0002EDDC File Offset: 0x0002CFDC
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
		// (get) Token: 0x060010D6 RID: 4310 RVA: 0x0002EDE5 File Offset: 0x0002CFE5
		// (set) Token: 0x060010D7 RID: 4311 RVA: 0x0002EDED File Offset: 0x0002CFED
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

		// Token: 0x060010D8 RID: 4312 RVA: 0x0002EDF6 File Offset: 0x0002CFF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssChallengeRoleHonor);
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x0002EE04 File Offset: 0x0002D004
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssChallengeRoleHonor other)
		{
			return other != null && (other == this || (this.Type == other.Type && this.Value == other.Value && this.RankValue == other.RankValue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x0002EE60 File Offset: 0x0002D060
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

		// Token: 0x060010DB RID: 4315 RVA: 0x0002EED1 File Offset: 0x0002D0D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x0002EEDE File Offset: 0x0002D0DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x0002EEE8 File Offset: 0x0002D0E8
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

		// Token: 0x060010DE RID: 4318 RVA: 0x0002EF5C File Offset: 0x0002D15C
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

		// Token: 0x060010DF RID: 4319 RVA: 0x0002EFCC File Offset: 0x0002D1CC
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

		// Token: 0x060010E0 RID: 4320 RVA: 0x0002F030 File Offset: 0x0002D230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x0002F03C File Offset: 0x0002D23C
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

		// Token: 0x04001F33 RID: 7987
		private static readonly MessageParser<AbyssChallengeRoleHonor> _parser = new MessageParser<AbyssChallengeRoleHonor>(() => new AbyssChallengeRoleHonor());

		// Token: 0x04001F34 RID: 7988
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001F35 RID: 7989
		public const int TypeFieldNumber = 1;

		// Token: 0x04001F36 RID: 7990
		private int type_;

		// Token: 0x04001F37 RID: 7991
		public const int ValueFieldNumber = 2;

		// Token: 0x04001F38 RID: 7992
		private int value_;

		// Token: 0x04001F39 RID: 7993
		public const int RankValueFieldNumber = 3;

		// Token: 0x04001F3A RID: 7994
		private int rankValue_;
	}
}
