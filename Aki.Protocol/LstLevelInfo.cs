using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200096C RID: 2412
	public sealed class LstLevelInfo : IMessage<LstLevelInfo>, IMessage, IEquatable<LstLevelInfo>, IDeepCloneable<LstLevelInfo>, IBufferMessage
	{
		// Token: 0x0600D462 RID: 54370 RVA: 0x001F4681 File Offset: 0x001F2881
		[NullableContext(1)]
		public static LstLevelInfo Create()
		{
			return new LstLevelInfo();
		}

		// Token: 0x17002B03 RID: 11011
		// (get) Token: 0x0600D463 RID: 54371 RVA: 0x001F4688 File Offset: 0x001F2888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LstLevelInfo> Parser
		{
			get
			{
				return LstLevelInfo._parser;
			}
		}

		// Token: 0x17002B04 RID: 11012
		// (get) Token: 0x0600D464 RID: 54372 RVA: 0x001F468F File Offset: 0x001F288F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B05 RID: 11013
		// (get) Token: 0x0600D465 RID: 54373 RVA: 0x001F4692 File Offset: 0x001F2892
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LstLevelInfo.Descriptor;
			}
		}

		// Token: 0x0600D466 RID: 54374 RVA: 0x001F4699 File Offset: 0x001F2899
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LstLevelInfo()
		{
		}

		// Token: 0x0600D467 RID: 54375 RVA: 0x001F46A1 File Offset: 0x001F28A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LstLevelInfo(LstLevelInfo other) : this()
		{
			this.levelId_ = other.levelId_;
			this.score_ = other.score_;
			this.easyPassFlag_ = other.easyPassFlag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D468 RID: 54376 RVA: 0x001F46DE File Offset: 0x001F28DE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LstLevelInfo Clone()
		{
			return new LstLevelInfo(this);
		}

		// Token: 0x17002B06 RID: 11014
		// (get) Token: 0x0600D469 RID: 54377 RVA: 0x001F46E6 File Offset: 0x001F28E6
		// (set) Token: 0x0600D46A RID: 54378 RVA: 0x001F46EE File Offset: 0x001F28EE
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

		// Token: 0x17002B07 RID: 11015
		// (get) Token: 0x0600D46B RID: 54379 RVA: 0x001F46F7 File Offset: 0x001F28F7
		// (set) Token: 0x0600D46C RID: 54380 RVA: 0x001F46FF File Offset: 0x001F28FF
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

		// Token: 0x17002B08 RID: 11016
		// (get) Token: 0x0600D46D RID: 54381 RVA: 0x001F4708 File Offset: 0x001F2908
		// (set) Token: 0x0600D46E RID: 54382 RVA: 0x001F4710 File Offset: 0x001F2910
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

		// Token: 0x0600D46F RID: 54383 RVA: 0x001F4719 File Offset: 0x001F2919
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LstLevelInfo);
		}

		// Token: 0x0600D470 RID: 54384 RVA: 0x001F4728 File Offset: 0x001F2928
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LstLevelInfo other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.Score == other.Score && this.EasyPassFlag == other.EasyPassFlag && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D471 RID: 54385 RVA: 0x001F4784 File Offset: 0x001F2984
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

		// Token: 0x0600D472 RID: 54386 RVA: 0x001F47F5 File Offset: 0x001F29F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D473 RID: 54387 RVA: 0x001F4802 File Offset: 0x001F2A02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D474 RID: 54388 RVA: 0x001F480C File Offset: 0x001F2A0C
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

		// Token: 0x0600D475 RID: 54389 RVA: 0x001F4880 File Offset: 0x001F2A80
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

		// Token: 0x0600D476 RID: 54390 RVA: 0x001F48E4 File Offset: 0x001F2AE4
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

		// Token: 0x0600D477 RID: 54391 RVA: 0x001F4948 File Offset: 0x001F2B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D478 RID: 54392 RVA: 0x001F4954 File Offset: 0x001F2B54
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

		// Token: 0x0400591F RID: 22815
		private static readonly MessageParser<LstLevelInfo> _parser = new MessageParser<LstLevelInfo>(() => new LstLevelInfo());

		// Token: 0x04005920 RID: 22816
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005921 RID: 22817
		public const int LevelIdFieldNumber = 1;

		// Token: 0x04005922 RID: 22818
		private int levelId_;

		// Token: 0x04005923 RID: 22819
		public const int ScoreFieldNumber = 2;

		// Token: 0x04005924 RID: 22820
		private int score_;

		// Token: 0x04005925 RID: 22821
		public const int EasyPassFlagFieldNumber = 3;

		// Token: 0x04005926 RID: 22822
		private bool easyPassFlag_;
	}
}
