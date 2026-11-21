using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000150 RID: 336
	[NetMessage(EMessageId.BabelTowerRankListRequest)]
	public sealed class BabelTowerRankListRequest : IMessage<BabelTowerRankListRequest>, IMessage, IEquatable<BabelTowerRankListRequest>, IDeepCloneable<BabelTowerRankListRequest>, IBufferMessage
	{
		// Token: 0x06002B0E RID: 11022 RVA: 0x00070DA9 File Offset: 0x0006EFA9
		[NullableContext(1)]
		public static BabelTowerRankListRequest Create()
		{
			return new BabelTowerRankListRequest();
		}

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06002B0F RID: 11023 RVA: 0x00070DB0 File Offset: 0x0006EFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06002B10 RID: 11024 RVA: 0x00070DB3 File Offset: 0x0006EFB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return BabelTowerRankListRequest.Descriptor;
			}
		}

		// Token: 0x06002B11 RID: 11025 RVA: 0x00070DBA File Offset: 0x0006EFBA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerRankListRequest()
		{
		}

		// Token: 0x06002B12 RID: 11026 RVA: 0x00070DC2 File Offset: 0x0006EFC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerRankListRequest(BabelTowerRankListRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06002B13 RID: 11027 RVA: 0x00070DE7 File Offset: 0x0006EFE7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public BabelTowerRankListRequest Clone()
		{
			return new BabelTowerRankListRequest(this);
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06002B14 RID: 11028 RVA: 0x00070DEF File Offset: 0x0006EFEF
		// (set) Token: 0x06002B15 RID: 11029 RVA: 0x00070DF7 File Offset: 0x0006EFF7
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

		// Token: 0x06002B16 RID: 11030 RVA: 0x00070E00 File Offset: 0x0006F000
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as BabelTowerRankListRequest);
		}

		// Token: 0x06002B17 RID: 11031 RVA: 0x00070E0E File Offset: 0x0006F00E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(BabelTowerRankListRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06002B18 RID: 11032 RVA: 0x00070E3C File Offset: 0x0006F03C
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

		// Token: 0x06002B19 RID: 11033 RVA: 0x00070E7B File Offset: 0x0006F07B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06002B1A RID: 11034 RVA: 0x00070E88 File Offset: 0x0006F088
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06002B1B RID: 11035 RVA: 0x00070E91 File Offset: 0x0006F091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06002B1C RID: 11036 RVA: 0x00070EC4 File Offset: 0x0006F0C4
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

		// Token: 0x06002B1D RID: 11037 RVA: 0x00070F02 File Offset: 0x0006F102
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

		// Token: 0x06002B1E RID: 11038 RVA: 0x00070F33 File Offset: 0x0006F133
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06002B1F RID: 11039 RVA: 0x00070F3C File Offset: 0x0006F13C
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040027E2 RID: 10210
		private UnknownFieldSet _unknownFields;

		// Token: 0x040027E3 RID: 10211
		public const int ActivityIdFieldNumber = 6;

		// Token: 0x040027E4 RID: 10212
		private int activityId_;
	}
}
