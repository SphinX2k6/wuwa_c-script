using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200014D RID: 333
	[NetMessage(EMessageId.BabelTowerRankListRequest)]
	public sealed class BabelTowerRankListRequest : IMessage<BabelTowerRankListRequest>, IMessage, IEquatable<BabelTowerRankListRequest>, IDeepCloneable<BabelTowerRankListRequest>, IBufferMessage
	{
		// Token: 0x06002A97 RID: 10903 RVA: 0x0006F975 File Offset: 0x0006DB75
		[NullableContext(1)]
		public static BabelTowerRankListRequest Create()
		{
			return new BabelTowerRankListRequest();
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06002A98 RID: 10904 RVA: 0x0006F97C File Offset: 0x0006DB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06002A99 RID: 10905 RVA: 0x0006F97F File Offset: 0x0006DB7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerRankListRequest.Descriptor;
			}
		}

		// Token: 0x06002A9A RID: 10906 RVA: 0x0006F986 File Offset: 0x0006DB86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerRankListRequest()
		{
		}

		// Token: 0x06002A9B RID: 10907 RVA: 0x0006F98E File Offset: 0x0006DB8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerRankListRequest(BabelTowerRankListRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002A9C RID: 10908 RVA: 0x0006F9B3 File Offset: 0x0006DBB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerRankListRequest Clone()
		{
			return new BabelTowerRankListRequest(this);
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06002A9D RID: 10909 RVA: 0x0006F9BB File Offset: 0x0006DBBB
		// (set) Token: 0x06002A9E RID: 10910 RVA: 0x0006F9C3 File Offset: 0x0006DBC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ActivityId
		{
			get
			{
				return this.activityId_;
			}
			set
			{
				this.activityId_ = value;
			}
		}

		// Token: 0x06002A9F RID: 10911 RVA: 0x0006F9CC File Offset: 0x0006DBCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerRankListRequest);
		}

		// Token: 0x06002AA0 RID: 10912 RVA: 0x0006F9DA File Offset: 0x0006DBDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerRankListRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002AA1 RID: 10913 RVA: 0x0006FA08 File Offset: 0x0006DC08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06002AA2 RID: 10914 RVA: 0x0006FA47 File Offset: 0x0006DC47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002AA3 RID: 10915 RVA: 0x0006FA54 File Offset: 0x0006DC54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002AA4 RID: 10916 RVA: 0x0006FA5D File Offset: 0x0006DC5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002AA5 RID: 10917 RVA: 0x0006FA90 File Offset: 0x0006DC90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06002AA6 RID: 10918 RVA: 0x0006FACE File Offset: 0x0006DCCE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(BabelTowerRankListRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06002AA7 RID: 10919 RVA: 0x0006FAFF File Offset: 0x0006DCFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002AA8 RID: 10920 RVA: 0x0006FB08 File Offset: 0x0006DD08
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
				if (num != 16U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400276E RID: 10094
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400276F RID: 10095
		public const int ActivityIdFieldNumber = 2;

		// Token: 0x04002770 RID: 10096
		private int activityId_;
	}
}
