using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FB1 RID: 4017
	[NetMessage(EMessageId.RoguelikeTalentLevelUpResponse)]
	public sealed class RoguelikeTalentLevelUpResponse : IMessage<RoguelikeTalentLevelUpResponse>, IMessage, IEquatable<RoguelikeTalentLevelUpResponse>, IDeepCloneable<RoguelikeTalentLevelUpResponse>, IBufferMessage
	{
		// Token: 0x06015819 RID: 88089 RVA: 0x0031FDBD File Offset: 0x0031DFBD
		[NullableContext(1)]
		public static RoguelikeTalentLevelUpResponse Create()
		{
			return new RoguelikeTalentLevelUpResponse();
		}

		// Token: 0x170047BC RID: 18364
		// (get) Token: 0x0601581A RID: 88090 RVA: 0x0031FDC4 File Offset: 0x0031DFC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047BD RID: 18365
		// (get) Token: 0x0601581B RID: 88091 RVA: 0x0031FDC7 File Offset: 0x0031DFC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeTalentLevelUpResponse.Descriptor;
			}
		}

		// Token: 0x0601581C RID: 88092 RVA: 0x0031FDCE File Offset: 0x0031DFCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentLevelUpResponse()
		{
		}

		// Token: 0x0601581D RID: 88093 RVA: 0x0031FDD6 File Offset: 0x0031DFD6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentLevelUpResponse(RoguelikeTalentLevelUpResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601581E RID: 88094 RVA: 0x0031FE07 File Offset: 0x0031E007
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeTalentLevelUpResponse Clone()
		{
			return new RoguelikeTalentLevelUpResponse(this);
		}

		// Token: 0x170047BE RID: 18366
		// (get) Token: 0x0601581F RID: 88095 RVA: 0x0031FE0F File Offset: 0x0031E00F
		// (set) Token: 0x06015820 RID: 88096 RVA: 0x0031FE17 File Offset: 0x0031E017
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

		// Token: 0x170047BF RID: 18367
		// (get) Token: 0x06015821 RID: 88097 RVA: 0x0031FE20 File Offset: 0x0031E020
		// (set) Token: 0x06015822 RID: 88098 RVA: 0x0031FE28 File Offset: 0x0031E028
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

		// Token: 0x06015823 RID: 88099 RVA: 0x0031FE31 File Offset: 0x0031E031
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeTalentLevelUpResponse);
		}

		// Token: 0x06015824 RID: 88100 RVA: 0x0031FE3F File Offset: 0x0031E03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeTalentLevelUpResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015825 RID: 88101 RVA: 0x0031FE80 File Offset: 0x0031E080
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

		// Token: 0x06015826 RID: 88102 RVA: 0x0031FEDE File Offset: 0x0031E0DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015827 RID: 88103 RVA: 0x0031FEEB File Offset: 0x0031E0EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015828 RID: 88104 RVA: 0x0031FEF4 File Offset: 0x0031E0F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.Level);
			}
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

		// Token: 0x06015829 RID: 88105 RVA: 0x0031FF50 File Offset: 0x0031E150
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

		// Token: 0x0601582A RID: 88106 RVA: 0x0031FFA8 File Offset: 0x0031E1A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeTalentLevelUpResponse other)
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

		// Token: 0x0601582B RID: 88107 RVA: 0x0031FFF8 File Offset: 0x0031E1F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601582C RID: 88108 RVA: 0x00320004 File Offset: 0x0031E204
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
				if (num != 80U)
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
					this.Level = input.ReadInt32();
				}
			}
		}

		// Token: 0x040081B9 RID: 33209
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081BA RID: 33210
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040081BB RID: 33211
		private ErrorCode errorCode_;

		// Token: 0x040081BC RID: 33212
		public const int LevelFieldNumber = 10;

		// Token: 0x040081BD RID: 33213
		private int level_;
	}
}
