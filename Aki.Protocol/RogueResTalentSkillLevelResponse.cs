using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200100B RID: 4107
	[NetMessage(EMessageId.RogueResTalentSkillLevelResponse)]
	public sealed class RogueResTalentSkillLevelResponse : IMessage<RogueResTalentSkillLevelResponse>, IMessage, IEquatable<RogueResTalentSkillLevelResponse>, IDeepCloneable<RogueResTalentSkillLevelResponse>, IBufferMessage
	{
		// Token: 0x06015F67 RID: 89959 RVA: 0x00331879 File Offset: 0x0032FA79
		[NullableContext(1)]
		public static RogueResTalentSkillLevelResponse Create()
		{
			return new RogueResTalentSkillLevelResponse();
		}

		// Token: 0x1700496A RID: 18794
		// (get) Token: 0x06015F68 RID: 89960 RVA: 0x00331880 File Offset: 0x0032FA80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700496B RID: 18795
		// (get) Token: 0x06015F69 RID: 89961 RVA: 0x00331883 File Offset: 0x0032FA83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResTalentSkillLevelResponse.Descriptor;
			}
		}

		// Token: 0x06015F6A RID: 89962 RVA: 0x0033188A File Offset: 0x0032FA8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTalentSkillLevelResponse()
		{
		}

		// Token: 0x06015F6B RID: 89963 RVA: 0x00331892 File Offset: 0x0032FA92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTalentSkillLevelResponse(RogueResTalentSkillLevelResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015F6C RID: 89964 RVA: 0x003318C3 File Offset: 0x0032FAC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResTalentSkillLevelResponse Clone()
		{
			return new RogueResTalentSkillLevelResponse(this);
		}

		// Token: 0x1700496C RID: 18796
		// (get) Token: 0x06015F6D RID: 89965 RVA: 0x003318CB File Offset: 0x0032FACB
		// (set) Token: 0x06015F6E RID: 89966 RVA: 0x003318D3 File Offset: 0x0032FAD3
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

		// Token: 0x1700496D RID: 18797
		// (get) Token: 0x06015F6F RID: 89967 RVA: 0x003318DC File Offset: 0x0032FADC
		// (set) Token: 0x06015F70 RID: 89968 RVA: 0x003318E4 File Offset: 0x0032FAE4
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

		// Token: 0x06015F71 RID: 89969 RVA: 0x003318ED File Offset: 0x0032FAED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResTalentSkillLevelResponse);
		}

		// Token: 0x06015F72 RID: 89970 RVA: 0x003318FB File Offset: 0x0032FAFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResTalentSkillLevelResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015F73 RID: 89971 RVA: 0x0033193C File Offset: 0x0032FB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015F74 RID: 89972 RVA: 0x0033199A File Offset: 0x0032FB9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015F75 RID: 89973 RVA: 0x003319A7 File Offset: 0x0032FBA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015F76 RID: 89974 RVA: 0x003319B0 File Offset: 0x0032FBB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015F77 RID: 89975 RVA: 0x00331A0C File Offset: 0x0032FC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015F78 RID: 89976 RVA: 0x00331A64 File Offset: 0x0032FC64
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResTalentSkillLevelResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015F79 RID: 89977 RVA: 0x00331AB4 File Offset: 0x0032FCB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015F7A RID: 89978 RVA: 0x00331AC0 File Offset: 0x0032FCC0
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
				if (num != 24U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Level = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040083CE RID: 33742
		private UnknownFieldSet _unknownFields;

		// Token: 0x040083CF RID: 33743
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x040083D0 RID: 33744
		private ErrorCode errorCode_;

		// Token: 0x040083D1 RID: 33745
		public const int LevelFieldNumber = 15;

		// Token: 0x040083D2 RID: 33746
		private int level_;
	}
}
