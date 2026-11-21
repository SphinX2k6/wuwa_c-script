using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200096F RID: 2415
	public sealed class MainPhantomRecommendInfo : IMessage<MainPhantomRecommendInfo>, IMessage, IEquatable<MainPhantomRecommendInfo>, IDeepCloneable<MainPhantomRecommendInfo>, IBufferMessage
	{
		// Token: 0x0600D4CA RID: 54474 RVA: 0x001F54C3 File Offset: 0x001F36C3
		[NullableContext(1)]
		public static MainPhantomRecommendInfo Create()
		{
			return new MainPhantomRecommendInfo();
		}

		// Token: 0x17002B0E RID: 11022
		// (get) Token: 0x0600D4CB RID: 54475 RVA: 0x001F54CA File Offset: 0x001F36CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MainPhantomRecommendInfo> Parser
		{
			get
			{
				return MainPhantomRecommendInfo._parser;
			}
		}

		// Token: 0x17002B0F RID: 11023
		// (get) Token: 0x0600D4CC RID: 54476 RVA: 0x001F54D1 File Offset: 0x001F36D1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B10 RID: 11024
		// (get) Token: 0x0600D4CD RID: 54477 RVA: 0x001F54D4 File Offset: 0x001F36D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MainPhantomRecommendInfo.Descriptor;
			}
		}

		// Token: 0x0600D4CE RID: 54478 RVA: 0x001F54DB File Offset: 0x001F36DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainPhantomRecommendInfo()
		{
		}

		// Token: 0x0600D4CF RID: 54479 RVA: 0x001F54E3 File Offset: 0x001F36E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainPhantomRecommendInfo(MainPhantomRecommendInfo other) : this()
		{
			this.usage_ = other.usage_;
			this.monsterId_ = other.monsterId_;
			this.fetterGroupId_ = other.fetterGroupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D4D0 RID: 54480 RVA: 0x001F5520 File Offset: 0x001F3720
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainPhantomRecommendInfo Clone()
		{
			return new MainPhantomRecommendInfo(this);
		}

		// Token: 0x17002B11 RID: 11025
		// (get) Token: 0x0600D4D1 RID: 54481 RVA: 0x001F5528 File Offset: 0x001F3728
		// (set) Token: 0x0600D4D2 RID: 54482 RVA: 0x001F5530 File Offset: 0x001F3730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Usage
		{
			get
			{
				return this.usage_;
			}
			set
			{
				this.usage_ = value;
			}
		}

		// Token: 0x17002B12 RID: 11026
		// (get) Token: 0x0600D4D3 RID: 54483 RVA: 0x001F5539 File Offset: 0x001F3739
		// (set) Token: 0x0600D4D4 RID: 54484 RVA: 0x001F5541 File Offset: 0x001F3741
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MonsterId
		{
			get
			{
				return this.monsterId_;
			}
			set
			{
				this.monsterId_ = value;
			}
		}

		// Token: 0x17002B13 RID: 11027
		// (get) Token: 0x0600D4D5 RID: 54485 RVA: 0x001F554A File Offset: 0x001F374A
		// (set) Token: 0x0600D4D6 RID: 54486 RVA: 0x001F5552 File Offset: 0x001F3752
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FetterGroupId
		{
			get
			{
				return this.fetterGroupId_;
			}
			set
			{
				this.fetterGroupId_ = value;
			}
		}

		// Token: 0x0600D4D7 RID: 54487 RVA: 0x001F555B File Offset: 0x001F375B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MainPhantomRecommendInfo);
		}

		// Token: 0x0600D4D8 RID: 54488 RVA: 0x001F556C File Offset: 0x001F376C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MainPhantomRecommendInfo other)
		{
			return other != null && (other == this || (this.Usage == other.Usage && this.MonsterId == other.MonsterId && this.FetterGroupId == other.FetterGroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D4D9 RID: 54489 RVA: 0x001F55C8 File Offset: 0x001F37C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Usage != 0)
			{
				num ^= this.Usage.GetHashCode();
			}
			if (this.MonsterId != 0)
			{
				num ^= this.MonsterId.GetHashCode();
			}
			if (this.FetterGroupId != 0)
			{
				num ^= this.FetterGroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D4DA RID: 54490 RVA: 0x001F5639 File Offset: 0x001F3839
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D4DB RID: 54491 RVA: 0x001F5646 File Offset: 0x001F3846
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D4DC RID: 54492 RVA: 0x001F5650 File Offset: 0x001F3850
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Usage != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Usage);
			}
			if (this.MonsterId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.MonsterId);
			}
			if (this.FetterGroupId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FetterGroupId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D4DD RID: 54493 RVA: 0x001F56C4 File Offset: 0x001F38C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Usage != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Usage);
			}
			if (this.MonsterId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MonsterId);
			}
			if (this.FetterGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FetterGroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D4DE RID: 54494 RVA: 0x001F5734 File Offset: 0x001F3934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MainPhantomRecommendInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Usage != 0)
			{
				this.Usage = other.Usage;
			}
			if (other.MonsterId != 0)
			{
				this.MonsterId = other.MonsterId;
			}
			if (other.FetterGroupId != 0)
			{
				this.FetterGroupId = other.FetterGroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D4DF RID: 54495 RVA: 0x001F5798 File Offset: 0x001F3998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D4E0 RID: 54496 RVA: 0x001F57A4 File Offset: 0x001F39A4
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
							this.FetterGroupId = input.ReadInt32();
						}
					}
					else
					{
						this.MonsterId = input.ReadInt32();
					}
				}
				else
				{
					this.Usage = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005982 RID: 22914
		private static readonly MessageParser<MainPhantomRecommendInfo> _parser = new MessageParser<MainPhantomRecommendInfo>(() => new MainPhantomRecommendInfo());

		// Token: 0x04005983 RID: 22915
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005984 RID: 22916
		public const int UsageFieldNumber = 1;

		// Token: 0x04005985 RID: 22917
		private int usage_;

		// Token: 0x04005986 RID: 22918
		public const int MonsterIdFieldNumber = 2;

		// Token: 0x04005987 RID: 22919
		private int monsterId_;

		// Token: 0x04005988 RID: 22920
		public const int FetterGroupIdFieldNumber = 3;

		// Token: 0x04005989 RID: 22921
		private int fetterGroupId_;
	}
}
