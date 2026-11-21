using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200135A RID: 4954
	[NetMessage(EMessageId.SurvivorsTalentLevelUpResponse)]
	public sealed class SurvivorsTalentLevelUpResponse : IMessage<SurvivorsTalentLevelUpResponse>, IMessage, IEquatable<SurvivorsTalentLevelUpResponse>, IDeepCloneable<SurvivorsTalentLevelUpResponse>, IBufferMessage
	{
		// Token: 0x0601A64C RID: 108108 RVA: 0x003D8D89 File Offset: 0x003D6F89
		[NullableContext(1)]
		public static SurvivorsTalentLevelUpResponse Create()
		{
			return new SurvivorsTalentLevelUpResponse();
		}

		// Token: 0x17005961 RID: 22881
		// (get) Token: 0x0601A64D RID: 108109 RVA: 0x003D8D90 File Offset: 0x003D6F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005962 RID: 22882
		// (get) Token: 0x0601A64E RID: 108110 RVA: 0x003D8D93 File Offset: 0x003D6F93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsTalentLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x0601A64F RID: 108111 RVA: 0x003D8D9A File Offset: 0x003D6F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTalentLevelUpResponse()
		{
		}

		// Token: 0x0601A650 RID: 108112 RVA: 0x003D8DA2 File Offset: 0x003D6FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTalentLevelUpResponse(SurvivorsTalentLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A651 RID: 108113 RVA: 0x003D8DD3 File Offset: 0x003D6FD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsTalentLevelUpResponse Clone()
		{
			return new SurvivorsTalentLevelUpResponse(this);
		}

		// Token: 0x17005963 RID: 22883
		// (get) Token: 0x0601A652 RID: 108114 RVA: 0x003D8DDB File Offset: 0x003D6FDB
		// (set) Token: 0x0601A653 RID: 108115 RVA: 0x003D8DE3 File Offset: 0x003D6FE3
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

		// Token: 0x17005964 RID: 22884
		// (get) Token: 0x0601A654 RID: 108116 RVA: 0x003D8DEC File Offset: 0x003D6FEC
		// (set) Token: 0x0601A655 RID: 108117 RVA: 0x003D8DF4 File Offset: 0x003D6FF4
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

		// Token: 0x0601A656 RID: 108118 RVA: 0x003D8DFD File Offset: 0x003D6FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsTalentLevelUpResponse);
		}

		// Token: 0x0601A657 RID: 108119 RVA: 0x003D8E0B File Offset: 0x003D700B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsTalentLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A658 RID: 108120 RVA: 0x003D8E4C File Offset: 0x003D704C
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

		// Token: 0x0601A659 RID: 108121 RVA: 0x003D8EAA File Offset: 0x003D70AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A65A RID: 108122 RVA: 0x003D8EB7 File Offset: 0x003D70B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A65B RID: 108123 RVA: 0x003D8EC0 File Offset: 0x003D70C0
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
				output.WriteRawTag(96);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A65C RID: 108124 RVA: 0x003D8F1C File Offset: 0x003D711C
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

		// Token: 0x0601A65D RID: 108125 RVA: 0x003D8F74 File Offset: 0x003D7174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsTalentLevelUpResponse other)
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

		// Token: 0x0601A65E RID: 108126 RVA: 0x003D8FC4 File Offset: 0x003D71C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A65F RID: 108127 RVA: 0x003D8FD0 File Offset: 0x003D71D0
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
					if (num != 96U)
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

		// Token: 0x04009AF6 RID: 39670
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AF7 RID: 39671
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x04009AF8 RID: 39672
		private ErrorCode errorCode_;

		// Token: 0x04009AF9 RID: 39673
		public const int LevelFieldNumber = 12;

		// Token: 0x04009AFA RID: 39674
		private int level_;
	}
}
