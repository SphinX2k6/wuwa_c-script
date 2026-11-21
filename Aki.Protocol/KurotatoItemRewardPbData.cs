using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200088C RID: 2188
	public sealed class KurotatoItemRewardPbData : IMessage<KurotatoItemRewardPbData>, IMessage, IEquatable<KurotatoItemRewardPbData>, IDeepCloneable<KurotatoItemRewardPbData>, IBufferMessage
	{
		// Token: 0x0600C2DA RID: 49882 RVA: 0x001CEA95 File Offset: 0x001CCC95
		[NullableContext(1)]
		public static KurotatoItemRewardPbData Create()
		{
			return new KurotatoItemRewardPbData();
		}

		// Token: 0x1700275F RID: 10079
		// (get) Token: 0x0600C2DB RID: 49883 RVA: 0x001CEA9C File Offset: 0x001CCC9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<KurotatoItemRewardPbData> Parser
		{
			get
			{
				return KurotatoItemRewardPbData._parser;
			}
		}

		// Token: 0x17002760 RID: 10080
		// (get) Token: 0x0600C2DC RID: 49884 RVA: 0x001CEAA3 File Offset: 0x001CCCA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002761 RID: 10081
		// (get) Token: 0x0600C2DD RID: 49885 RVA: 0x001CEAA6 File Offset: 0x001CCCA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return KurotatoItemRewardPbData.Descriptor;
			}
		}

		// Token: 0x0600C2DE RID: 49886 RVA: 0x001CEAAD File Offset: 0x001CCCAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemRewardPbData()
		{
		}

		// Token: 0x0600C2DF RID: 49887 RVA: 0x001CEAB5 File Offset: 0x001CCCB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemRewardPbData(KurotatoItemRewardPbData other) : this()
		{
			this.itemId_ = other.itemId_;
			this.selectionId_ = other.selectionId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C2E0 RID: 49888 RVA: 0x001CEAE6 File Offset: 0x001CCCE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public KurotatoItemRewardPbData Clone()
		{
			return new KurotatoItemRewardPbData(this);
		}

		// Token: 0x17002762 RID: 10082
		// (get) Token: 0x0600C2E1 RID: 49889 RVA: 0x001CEAEE File Offset: 0x001CCCEE
		// (set) Token: 0x0600C2E2 RID: 49890 RVA: 0x001CEAF6 File Offset: 0x001CCCF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ItemId
		{
			get
			{
				return this.itemId_;
			}
			set
			{
				this.itemId_ = value;
			}
		}

		// Token: 0x17002763 RID: 10083
		// (get) Token: 0x0600C2E3 RID: 49891 RVA: 0x001CEAFF File Offset: 0x001CCCFF
		// (set) Token: 0x0600C2E4 RID: 49892 RVA: 0x001CEB07 File Offset: 0x001CCD07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SelectionId
		{
			get
			{
				return this.selectionId_;
			}
			set
			{
				this.selectionId_ = value;
			}
		}

		// Token: 0x0600C2E5 RID: 49893 RVA: 0x001CEB10 File Offset: 0x001CCD10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as KurotatoItemRewardPbData);
		}

		// Token: 0x0600C2E6 RID: 49894 RVA: 0x001CEB1E File Offset: 0x001CCD1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(KurotatoItemRewardPbData other)
		{
			return other != null && (other == this || (this.ItemId == other.ItemId && this.SelectionId == other.SelectionId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C2E7 RID: 49895 RVA: 0x001CEB5C File Offset: 0x001CCD5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ItemId != 0)
			{
				num ^= this.ItemId.GetHashCode();
			}
			if (this.SelectionId != 0)
			{
				num ^= this.SelectionId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C2E8 RID: 49896 RVA: 0x001CEBB4 File Offset: 0x001CCDB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C2E9 RID: 49897 RVA: 0x001CEBC1 File Offset: 0x001CCDC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C2EA RID: 49898 RVA: 0x001CEBCC File Offset: 0x001CCDCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ItemId);
			}
			if (this.SelectionId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.SelectionId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C2EB RID: 49899 RVA: 0x001CEC24 File Offset: 0x001CCE24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ItemId);
			}
			if (this.SelectionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SelectionId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C2EC RID: 49900 RVA: 0x001CEC7C File Offset: 0x001CCE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(KurotatoItemRewardPbData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ItemId != 0)
			{
				this.ItemId = other.ItemId;
			}
			if (other.SelectionId != 0)
			{
				this.SelectionId = other.SelectionId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C2ED RID: 49901 RVA: 0x001CECCC File Offset: 0x001CCECC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C2EE RID: 49902 RVA: 0x001CECD8 File Offset: 0x001CCED8
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
						this.SelectionId = input.ReadInt32();
					}
				}
				else
				{
					this.ItemId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040054A1 RID: 21665
		private static readonly MessageParser<KurotatoItemRewardPbData> _parser = new MessageParser<KurotatoItemRewardPbData>(() => new KurotatoItemRewardPbData());

		// Token: 0x040054A2 RID: 21666
		private UnknownFieldSet _unknownFields;

		// Token: 0x040054A3 RID: 21667
		public const int ItemIdFieldNumber = 1;

		// Token: 0x040054A4 RID: 21668
		private int itemId_;

		// Token: 0x040054A5 RID: 21669
		public const int SelectionIdFieldNumber = 2;

		// Token: 0x040054A6 RID: 21670
		private int selectionId_;
	}
}
