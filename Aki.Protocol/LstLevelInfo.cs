using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200095B RID: 2395
	public sealed class LstLevelInfo : IMessage<LstLevelInfo>, IMessage, IEquatable<LstLevelInfo>, IDeepCloneable<LstLevelInfo>, IBufferMessage
	{
		// Token: 0x0600D348 RID: 54088 RVA: 0x001F2499 File Offset: 0x001F0699
		[NullableContext(1)]
		public static LstLevelInfo Create()
		{
			return new LstLevelInfo();
		}

		// Token: 0x17002AC5 RID: 10949
		// (get) Token: 0x0600D349 RID: 54089 RVA: 0x001F24A0 File Offset: 0x001F06A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LstLevelInfo> Parser
		{
			get
			{
				return LstLevelInfo._parser;
			}
		}

		// Token: 0x17002AC6 RID: 10950
		// (get) Token: 0x0600D34A RID: 54090 RVA: 0x001F24A7 File Offset: 0x001F06A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002AC7 RID: 10951
		// (get) Token: 0x0600D34B RID: 54091 RVA: 0x001F24AA File Offset: 0x001F06AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LstLevelInfo.Descriptor;
			}
		}

		// Token: 0x0600D34C RID: 54092 RVA: 0x001F24B1 File Offset: 0x001F06B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LstLevelInfo()
		{
		}

		// Token: 0x0600D34D RID: 54093 RVA: 0x001F24B9 File Offset: 0x001F06B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LstLevelInfo(LstLevelInfo other) : this()
		{
			this.levelId_ = other.levelId_;
			this.score_ = other.score_;
			this.easyPassFlag_ = other.easyPassFlag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D34E RID: 54094 RVA: 0x001F24F6 File Offset: 0x001F06F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LstLevelInfo Clone()
		{
			return new LstLevelInfo(this);
		}

		// Token: 0x17002AC8 RID: 10952
		// (get) Token: 0x0600D34F RID: 54095 RVA: 0x001F24FE File Offset: 0x001F06FE
		// (set) Token: 0x0600D350 RID: 54096 RVA: 0x001F2506 File Offset: 0x001F0706
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x17002AC9 RID: 10953
		// (get) Token: 0x0600D351 RID: 54097 RVA: 0x001F250F File Offset: 0x001F070F
		// (set) Token: 0x0600D352 RID: 54098 RVA: 0x001F2517 File Offset: 0x001F0717
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Score
		{
			get
			{
				return this.score_;
			}
			set
			{
				this.score_ = value;
			}
		}

		// Token: 0x17002ACA RID: 10954
		// (get) Token: 0x0600D353 RID: 54099 RVA: 0x001F2520 File Offset: 0x001F0720
		// (set) Token: 0x0600D354 RID: 54100 RVA: 0x001F2528 File Offset: 0x001F0728
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool EasyPassFlag
		{
			get
			{
				return this.easyPassFlag_;
			}
			set
			{
				this.easyPassFlag_ = value;
			}
		}

		// Token: 0x0600D355 RID: 54101 RVA: 0x001F2531 File Offset: 0x001F0731
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LstLevelInfo);
		}

		// Token: 0x0600D356 RID: 54102 RVA: 0x001F2540 File Offset: 0x001F0740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LstLevelInfo other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.Score == other.Score && this.EasyPassFlag == other.EasyPassFlag && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D357 RID: 54103 RVA: 0x001F259C File Offset: 0x001F079C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this.Score != 0)
			{
				num ^= this.Score.GetHashCode();
			}
			if (this.EasyPassFlag)
			{
				num ^= this.EasyPassFlag.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D358 RID: 54104 RVA: 0x001F260D File Offset: 0x001F080D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D359 RID: 54105 RVA: 0x001F261A File Offset: 0x001F081A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D35A RID: 54106 RVA: 0x001F2624 File Offset: 0x001F0824
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelId);
			}
			if (this.Score != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Score);
			}
			if (this.EasyPassFlag)
			{
				output.WriteRawTag(24);
				output.WriteBool(this.EasyPassFlag);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D35B RID: 54107 RVA: 0x001F2698 File Offset: 0x001F0898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this.Score != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Score);
			}
			if (this.EasyPassFlag)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D35C RID: 54108 RVA: 0x001F26FC File Offset: 0x001F08FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LstLevelInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			if (other.Score != 0)
			{
				this.Score = other.Score;
			}
			if (other.EasyPassFlag)
			{
				this.EasyPassFlag = other.EasyPassFlag;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D35D RID: 54109 RVA: 0x001F2760 File Offset: 0x001F0960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D35E RID: 54110 RVA: 0x001F276C File Offset: 0x001F096C
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
							this.EasyPassFlag = input.ReadBool();
						}
					}
					else
					{
						this.Score = input.ReadInt32();
					}
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005928 RID: 22824
		private static readonly MessageParser<LstLevelInfo> _parser = new MessageParser<LstLevelInfo>(() => new LstLevelInfo());

		// Token: 0x04005929 RID: 22825
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400592A RID: 22826
		public const int LevelIdFieldNumber = 1;

		// Token: 0x0400592B RID: 22827
		private int levelId_;

		// Token: 0x0400592C RID: 22828
		public const int ScoreFieldNumber = 2;

		// Token: 0x0400592D RID: 22829
		private int score_;

		// Token: 0x0400592E RID: 22830
		public const int EasyPassFlagFieldNumber = 3;

		// Token: 0x0400592F RID: 22831
		private bool easyPassFlag_;
	}
}
