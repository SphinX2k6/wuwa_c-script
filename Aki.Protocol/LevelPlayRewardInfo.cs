using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020008F4 RID: 2292
	public sealed class LevelPlayRewardInfo : IMessage<LevelPlayRewardInfo>, IMessage, IEquatable<LevelPlayRewardInfo>, IDeepCloneable<LevelPlayRewardInfo>, IBufferMessage
	{
		// Token: 0x0600CACC RID: 51916 RVA: 0x001DEDE5 File Offset: 0x001DCFE5
		[NullableContext(1)]
		public static LevelPlayRewardInfo Create()
		{
			return new LevelPlayRewardInfo();
		}

		// Token: 0x170028EC RID: 10476
		// (get) Token: 0x0600CACD RID: 51917 RVA: 0x001DEDEC File Offset: 0x001DCFEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<LevelPlayRewardInfo> Parser
		{
			get
			{
				return LevelPlayRewardInfo._parser;
			}
		}

		// Token: 0x170028ED RID: 10477
		// (get) Token: 0x0600CACE RID: 51918 RVA: 0x001DEDF3 File Offset: 0x001DCFF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170028EE RID: 10478
		// (get) Token: 0x0600CACF RID: 51919 RVA: 0x001DEDF6 File Offset: 0x001DCFF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LevelPlayRewardInfo.Descriptor;
			}
		}

		// Token: 0x0600CAD0 RID: 51920 RVA: 0x001DEDFD File Offset: 0x001DCFFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardInfo()
		{
		}

		// Token: 0x0600CAD1 RID: 51921 RVA: 0x001DEE05 File Offset: 0x001DD005
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardInfo(LevelPlayRewardInfo other) : this()
		{
			this.id_ = other.id_;
			this.getReward_ = other.getReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CAD2 RID: 51922 RVA: 0x001DEE36 File Offset: 0x001DD036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LevelPlayRewardInfo Clone()
		{
			return new LevelPlayRewardInfo(this);
		}

		// Token: 0x170028EF RID: 10479
		// (get) Token: 0x0600CAD3 RID: 51923 RVA: 0x001DEE3E File Offset: 0x001DD03E
		// (set) Token: 0x0600CAD4 RID: 51924 RVA: 0x001DEE46 File Offset: 0x001DD046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x170028F0 RID: 10480
		// (get) Token: 0x0600CAD5 RID: 51925 RVA: 0x001DEE4F File Offset: 0x001DD04F
		// (set) Token: 0x0600CAD6 RID: 51926 RVA: 0x001DEE57 File Offset: 0x001DD057
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool GetReward
		{
			get
			{
				return this.getReward_;
			}
			set
			{
				this.getReward_ = value;
			}
		}

		// Token: 0x0600CAD7 RID: 51927 RVA: 0x001DEE60 File Offset: 0x001DD060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LevelPlayRewardInfo);
		}

		// Token: 0x0600CAD8 RID: 51928 RVA: 0x001DEE6E File Offset: 0x001DD06E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LevelPlayRewardInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.GetReward == other.GetReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CAD9 RID: 51929 RVA: 0x001DEEAC File Offset: 0x001DD0AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.GetReward)
			{
				num ^= this.GetReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600CADA RID: 51930 RVA: 0x001DEF04 File Offset: 0x001DD104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CADB RID: 51931 RVA: 0x001DEF11 File Offset: 0x001DD111
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CADC RID: 51932 RVA: 0x001DEF1C File Offset: 0x001DD11C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.GetReward)
			{
				output.WriteRawTag(16);
				output.WriteBool(this.GetReward);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CADD RID: 51933 RVA: 0x001DEF74 File Offset: 0x001DD174
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.GetReward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600CADE RID: 51934 RVA: 0x001DEFC0 File Offset: 0x001DD1C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LevelPlayRewardInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.GetReward)
			{
				this.GetReward = other.GetReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600CADF RID: 51935 RVA: 0x001DF010 File Offset: 0x001DD210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CAE0 RID: 51936 RVA: 0x001DF01C File Offset: 0x001DD21C
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
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.GetReward = input.ReadBool();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400568D RID: 22157
		private static readonly MessageParser<LevelPlayRewardInfo> _parser = new MessageParser<LevelPlayRewardInfo>(() => new LevelPlayRewardInfo());

		// Token: 0x0400568E RID: 22158
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400568F RID: 22159
		public const int IdFieldNumber = 1;

		// Token: 0x04005690 RID: 22160
		private int id_;

		// Token: 0x04005691 RID: 22161
		public const int GetRewardFieldNumber = 2;

		// Token: 0x04005692 RID: 22162
		private bool getReward_;
	}
}
