using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000980 RID: 2432
	public sealed class MainPhantomRecommendInfo : IMessage<MainPhantomRecommendInfo>, IMessage, IEquatable<MainPhantomRecommendInfo>, IDeepCloneable<MainPhantomRecommendInfo>, IBufferMessage
	{
		// Token: 0x0600D5E4 RID: 54756 RVA: 0x001F76AB File Offset: 0x001F58AB
		[NullableContext(1)]
		public static MainPhantomRecommendInfo Create()
		{
			return new MainPhantomRecommendInfo();
		}

		// Token: 0x17002B4C RID: 11084
		// (get) Token: 0x0600D5E5 RID: 54757 RVA: 0x001F76B2 File Offset: 0x001F58B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<MainPhantomRecommendInfo> Parser
		{
			get
			{
				return MainPhantomRecommendInfo._parser;
			}
		}

		// Token: 0x17002B4D RID: 11085
		// (get) Token: 0x0600D5E6 RID: 54758 RVA: 0x001F76B9 File Offset: 0x001F58B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B4E RID: 11086
		// (get) Token: 0x0600D5E7 RID: 54759 RVA: 0x001F76BC File Offset: 0x001F58BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MainPhantomRecommendInfo.Descriptor;
			}
		}

		// Token: 0x0600D5E8 RID: 54760 RVA: 0x001F76C3 File Offset: 0x001F58C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainPhantomRecommendInfo()
		{
		}

		// Token: 0x0600D5E9 RID: 54761 RVA: 0x001F76CB File Offset: 0x001F58CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainPhantomRecommendInfo(MainPhantomRecommendInfo other) : this()
		{
			this.usage_ = other.usage_;
			this.monsterId_ = other.monsterId_;
			this.fetterGroupId_ = other.fetterGroupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D5EA RID: 54762 RVA: 0x001F7708 File Offset: 0x001F5908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MainPhantomRecommendInfo Clone()
		{
			return new MainPhantomRecommendInfo(this);
		}

		// Token: 0x17002B4F RID: 11087
		// (get) Token: 0x0600D5EB RID: 54763 RVA: 0x001F7710 File Offset: 0x001F5910
		// (set) Token: 0x0600D5EC RID: 54764 RVA: 0x001F7718 File Offset: 0x001F5918
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

		// Token: 0x17002B50 RID: 11088
		// (get) Token: 0x0600D5ED RID: 54765 RVA: 0x001F7721 File Offset: 0x001F5921
		// (set) Token: 0x0600D5EE RID: 54766 RVA: 0x001F7729 File Offset: 0x001F5929
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

		// Token: 0x17002B51 RID: 11089
		// (get) Token: 0x0600D5EF RID: 54767 RVA: 0x001F7732 File Offset: 0x001F5932
		// (set) Token: 0x0600D5F0 RID: 54768 RVA: 0x001F773A File Offset: 0x001F593A
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

		// Token: 0x0600D5F1 RID: 54769 RVA: 0x001F7743 File Offset: 0x001F5943
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MainPhantomRecommendInfo);
		}

		// Token: 0x0600D5F2 RID: 54770 RVA: 0x001F7754 File Offset: 0x001F5954
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MainPhantomRecommendInfo other)
		{
			return other != null && (other == this || (this.Usage == other.Usage && this.MonsterId == other.MonsterId && this.FetterGroupId == other.FetterGroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D5F3 RID: 54771 RVA: 0x001F77B0 File Offset: 0x001F59B0
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

		// Token: 0x0600D5F4 RID: 54772 RVA: 0x001F7821 File Offset: 0x001F5A21
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D5F5 RID: 54773 RVA: 0x001F782E File Offset: 0x001F5A2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D5F6 RID: 54774 RVA: 0x001F7838 File Offset: 0x001F5A38
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

		// Token: 0x0600D5F7 RID: 54775 RVA: 0x001F78AC File Offset: 0x001F5AAC
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

		// Token: 0x0600D5F8 RID: 54776 RVA: 0x001F791C File Offset: 0x001F5B1C
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

		// Token: 0x0600D5F9 RID: 54777 RVA: 0x001F7980 File Offset: 0x001F5B80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D5FA RID: 54778 RVA: 0x001F798C File Offset: 0x001F5B8C
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

		// Token: 0x04005979 RID: 22905
		private static readonly MessageParser<MainPhantomRecommendInfo> _parser = new MessageParser<MainPhantomRecommendInfo>(() => new MainPhantomRecommendInfo());

		// Token: 0x0400597A RID: 22906
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400597B RID: 22907
		public const int UsageFieldNumber = 1;

		// Token: 0x0400597C RID: 22908
		private int usage_;

		// Token: 0x0400597D RID: 22909
		public const int MonsterIdFieldNumber = 2;

		// Token: 0x0400597E RID: 22910
		private int monsterId_;

		// Token: 0x0400597F RID: 22911
		public const int FetterGroupIdFieldNumber = 3;

		// Token: 0x04005980 RID: 22912
		private int fetterGroupId_;
	}
}
