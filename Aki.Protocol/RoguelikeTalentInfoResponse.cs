using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FAF RID: 4015
	[NetMessage(EMessageId.RoguelikeTalentInfoResponse)]
	public sealed class RoguelikeTalentInfoResponse : IMessage<RoguelikeTalentInfoResponse>, IMessage, IEquatable<RoguelikeTalentInfoResponse>, IDeepCloneable<RoguelikeTalentInfoResponse>, IBufferMessage
	{
		// Token: 0x060157F3 RID: 88051 RVA: 0x0031F924 File Offset: 0x0031DB24
		[NullableContext(1)]
		public static RoguelikeTalentInfoResponse Create()
		{
			return new RoguelikeTalentInfoResponse();
		}

		// Token: 0x170047B5 RID: 18357
		// (get) Token: 0x060157F4 RID: 88052 RVA: 0x0031F92B File Offset: 0x0031DB2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047B6 RID: 18358
		// (get) Token: 0x060157F5 RID: 88053 RVA: 0x0031F92E File Offset: 0x0031DB2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeTalentInfoResponse.Descriptor;
			}
		}

		// Token: 0x060157F6 RID: 88054 RVA: 0x0031F935 File Offset: 0x0031DB35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentInfoResponse()
		{
		}

		// Token: 0x060157F7 RID: 88055 RVA: 0x0031F948 File Offset: 0x0031DB48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentInfoResponse(RoguelikeTalentInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.talentSkillDict_ = other.talentSkillDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060157F8 RID: 88056 RVA: 0x0031F97E File Offset: 0x0031DB7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentInfoResponse Clone()
		{
			return new RoguelikeTalentInfoResponse(this);
		}

		// Token: 0x170047B7 RID: 18359
		// (get) Token: 0x060157F9 RID: 88057 RVA: 0x0031F986 File Offset: 0x0031DB86
		// (set) Token: 0x060157FA RID: 88058 RVA: 0x0031F98E File Offset: 0x0031DB8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170047B8 RID: 18360
		// (get) Token: 0x060157FB RID: 88059 RVA: 0x0031F997 File Offset: 0x0031DB97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> TalentSkillDict
		{
			get
			{
				return this.talentSkillDict_;
			}
		}

		// Token: 0x060157FC RID: 88060 RVA: 0x0031F99F File Offset: 0x0031DB9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeTalentInfoResponse);
		}

		// Token: 0x060157FD RID: 88061 RVA: 0x0031F9B0 File Offset: 0x0031DBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeTalentInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.TalentSkillDict.Equals(other.TalentSkillDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060157FE RID: 88062 RVA: 0x0031FA00 File Offset: 0x0031DC00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.TalentSkillDict.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060157FF RID: 88063 RVA: 0x0031FA53 File Offset: 0x0031DC53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015800 RID: 88064 RVA: 0x0031FA60 File Offset: 0x0031DC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015801 RID: 88065 RVA: 0x0031FA6C File Offset: 0x0031DC6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.talentSkillDict_.WriteTo(ref output, RoguelikeTalentInfoResponse._map_talentSkillDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015802 RID: 88066 RVA: 0x0031FABC File Offset: 0x0031DCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.talentSkillDict_.CalculateSize(RoguelikeTalentInfoResponse._map_talentSkillDict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015803 RID: 88067 RVA: 0x0031FB10 File Offset: 0x0031DD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeTalentInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.talentSkillDict_.MergeFrom(other.talentSkillDict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015804 RID: 88068 RVA: 0x0031FB5D File Offset: 0x0031DD5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015805 RID: 88069 RVA: 0x0031FB68 File Offset: 0x0031DD68
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
				if (num != 104U)
				{
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.talentSkillDict_.AddEntriesFrom(ref input, RoguelikeTalentInfoResponse._map_talentSkillDict_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040081B0 RID: 33200
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081B1 RID: 33201
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x040081B2 RID: 33202
		private ErrorCode errorCode_;

		// Token: 0x040081B3 RID: 33203
		public const int TalentSkillDictFieldNumber = 15;

		// Token: 0x040081B4 RID: 33204
		private static readonly MapField<int, int>.Codec _map_talentSkillDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 122U);

		// Token: 0x040081B5 RID: 33205
		private readonly MapField<int, int> talentSkillDict_ = new MapField<int, int>();
	}
}
