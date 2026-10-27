using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001245 RID: 4677
	[NetMessage(EMessageId.SkinRewardRequest)]
	public sealed class SkinRewardRequest : IMessage<SkinRewardRequest>, IMessage, IEquatable<SkinRewardRequest>, IDeepCloneable<SkinRewardRequest>, IBufferMessage
	{
		// Token: 0x06018ECB RID: 102091 RVA: 0x003A08C0 File Offset: 0x0039EAC0
		[NullableContext(1)]
		public static SkinRewardRequest Create()
		{
			return new SkinRewardRequest();
		}

		// Token: 0x1700540E RID: 21518
		// (get) Token: 0x06018ECC RID: 102092 RVA: 0x003A08C7 File Offset: 0x0039EAC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700540F RID: 21519
		// (get) Token: 0x06018ECD RID: 102093 RVA: 0x003A08CA File Offset: 0x0039EACA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SkinRewardRequest.Descriptor;
			}
		}

		// Token: 0x06018ECE RID: 102094 RVA: 0x003A08D1 File Offset: 0x0039EAD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardRequest()
		{
		}

		// Token: 0x06018ECF RID: 102095 RVA: 0x003A08D9 File Offset: 0x0039EAD9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardRequest(SkinRewardRequest other) : this()
		{
			this.rewardId_ = other.rewardId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018ED0 RID: 102096 RVA: 0x003A08FE File Offset: 0x0039EAFE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkinRewardRequest Clone()
		{
			return new SkinRewardRequest(this);
		}

		// Token: 0x17005410 RID: 21520
		// (get) Token: 0x06018ED1 RID: 102097 RVA: 0x003A0906 File Offset: 0x0039EB06
		// (set) Token: 0x06018ED2 RID: 102098 RVA: 0x003A090E File Offset: 0x0039EB0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RewardId
		{
			get
			{
				return this.rewardId_;
			}
			set
			{
				this.rewardId_ = value;
			}
		}

		// Token: 0x06018ED3 RID: 102099 RVA: 0x003A0917 File Offset: 0x0039EB17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SkinRewardRequest);
		}

		// Token: 0x06018ED4 RID: 102100 RVA: 0x003A0925 File Offset: 0x0039EB25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SkinRewardRequest other)
		{
			return other != null && (other == this || (this.RewardId == other.RewardId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018ED5 RID: 102101 RVA: 0x003A0954 File Offset: 0x0039EB54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RewardId != 0)
			{
				num ^= this.RewardId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018ED6 RID: 102102 RVA: 0x003A0993 File Offset: 0x0039EB93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018ED7 RID: 102103 RVA: 0x003A09A0 File Offset: 0x0039EBA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018ED8 RID: 102104 RVA: 0x003A09A9 File Offset: 0x0039EBA9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RewardId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.RewardId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018ED9 RID: 102105 RVA: 0x003A09DC File Offset: 0x0039EBDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RewardId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RewardId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018EDA RID: 102106 RVA: 0x003A0A1A File Offset: 0x0039EC1A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SkinRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RewardId != 0)
			{
				this.RewardId = other.RewardId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018EDB RID: 102107 RVA: 0x003A0A4B File Offset: 0x0039EC4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018EDC RID: 102108 RVA: 0x003A0A54 File Offset: 0x0039EC54
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.RewardId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040092F9 RID: 37625
		private UnknownFieldSet _unknownFields;

		// Token: 0x040092FA RID: 37626
		public const int RewardIdFieldNumber = 3;

		// Token: 0x040092FB RID: 37627
		private int rewardId_;
	}
}
