using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FBF RID: 4031
	[NetMessage(EMessageId.RoguelikeTalentInfoResponse)]
	public sealed class RoguelikeTalentInfoResponse : IMessage<RoguelikeTalentInfoResponse>, IMessage, IEquatable<RoguelikeTalentInfoResponse>, IDeepCloneable<RoguelikeTalentInfoResponse>, IBufferMessage
	{
		// Token: 0x060158D8 RID: 88280 RVA: 0x00320FD9 File Offset: 0x0031F1D9
		[NullableContext(1)]
		public static RoguelikeTalentInfoResponse Create()
		{
			return new RoguelikeTalentInfoResponse();
		}

		// Token: 0x170047DF RID: 18399
		// (get) Token: 0x060158D9 RID: 88281 RVA: 0x00320FE0 File Offset: 0x0031F1E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047E0 RID: 18400
		// (get) Token: 0x060158DA RID: 88282 RVA: 0x00320FE3 File Offset: 0x0031F1E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeTalentInfoResponse.Descriptor;
			}
		}

		// Token: 0x060158DB RID: 88283 RVA: 0x00320FEA File Offset: 0x0031F1EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentInfoResponse()
		{
		}

		// Token: 0x060158DC RID: 88284 RVA: 0x00320FFD File Offset: 0x0031F1FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentInfoResponse(RoguelikeTalentInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.talentSkillDict_ = other.talentSkillDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060158DD RID: 88285 RVA: 0x00321033 File Offset: 0x0031F233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentInfoResponse Clone()
		{
			return new RoguelikeTalentInfoResponse(this);
		}

		// Token: 0x170047E1 RID: 18401
		// (get) Token: 0x060158DE RID: 88286 RVA: 0x0032103B File Offset: 0x0031F23B
		// (set) Token: 0x060158DF RID: 88287 RVA: 0x00321043 File Offset: 0x0031F243
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

		// Token: 0x170047E2 RID: 18402
		// (get) Token: 0x060158E0 RID: 88288 RVA: 0x0032104C File Offset: 0x0031F24C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> TalentSkillDict
		{
			get
			{
				return this.talentSkillDict_;
			}
		}

		// Token: 0x060158E1 RID: 88289 RVA: 0x00321054 File Offset: 0x0031F254
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeTalentInfoResponse);
		}

		// Token: 0x060158E2 RID: 88290 RVA: 0x00321064 File Offset: 0x0031F264
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeTalentInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.TalentSkillDict.Equals(other.TalentSkillDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060158E3 RID: 88291 RVA: 0x003210B4 File Offset: 0x0031F2B4
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

		// Token: 0x060158E4 RID: 88292 RVA: 0x00321107 File Offset: 0x0031F307
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060158E5 RID: 88293 RVA: 0x00321114 File Offset: 0x0031F314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060158E6 RID: 88294 RVA: 0x00321120 File Offset: 0x0031F320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.talentSkillDict_.WriteTo(ref output, RoguelikeTalentInfoResponse._map_talentSkillDict_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060158E7 RID: 88295 RVA: 0x00321170 File Offset: 0x0031F370
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

		// Token: 0x060158E8 RID: 88296 RVA: 0x003211C4 File Offset: 0x0031F3C4
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

		// Token: 0x060158E9 RID: 88297 RVA: 0x00321211 File Offset: 0x0031F411
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060158EA RID: 88298 RVA: 0x0032121C File Offset: 0x0031F41C
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
				if (num != 26U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.talentSkillDict_.AddEntriesFrom(ref input, RoguelikeTalentInfoResponse._map_talentSkillDict_codec);
				}
			}
		}

		// Token: 0x04008186 RID: 33158
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008187 RID: 33159
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04008188 RID: 33160
		private ErrorCode errorCode_;

		// Token: 0x04008189 RID: 33161
		public const int TalentSkillDictFieldNumber = 3;

		// Token: 0x0400818A RID: 33162
		private static readonly MapField<int, int>.Codec _map_talentSkillDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 26U);

		// Token: 0x0400818B RID: 33163
		private readonly MapField<int, int> talentSkillDict_ = new MapField<int, int>();
	}
}
