using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010F1 RID: 4337
	public sealed class RoverRogueBlessGroupData : IMessage<RoverRogueBlessGroupData>, IMessage, IEquatable<RoverRogueBlessGroupData>, IDeepCloneable<RoverRogueBlessGroupData>, IBufferMessage
	{
		// Token: 0x06017212 RID: 94738 RVA: 0x0035B65F File Offset: 0x0035985F
		[NullableContext(1)]
		public static RoverRogueBlessGroupData Create()
		{
			return new RoverRogueBlessGroupData();
		}

		// Token: 0x17004D7E RID: 19838
		// (get) Token: 0x06017213 RID: 94739 RVA: 0x0035B666 File Offset: 0x00359866
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoverRogueBlessGroupData> Parser
		{
			get
			{
				return RoverRogueBlessGroupData._parser;
			}
		}

		// Token: 0x17004D7F RID: 19839
		// (get) Token: 0x06017214 RID: 94740 RVA: 0x0035B66D File Offset: 0x0035986D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D80 RID: 19840
		// (get) Token: 0x06017215 RID: 94741 RVA: 0x0035B670 File Offset: 0x00359870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoverRogueBlessGroupData.Descriptor;
			}
		}

		// Token: 0x06017216 RID: 94742 RVA: 0x0035B677 File Offset: 0x00359877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupData()
		{
		}

		// Token: 0x06017217 RID: 94743 RVA: 0x0035B68A File Offset: 0x0035988A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupData(RoverRogueBlessGroupData other) : this()
		{
			this.blessGroupId_ = other.blessGroupId_;
			this.blessIdList_ = other.blessIdList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017218 RID: 94744 RVA: 0x0035B6C0 File Offset: 0x003598C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoverRogueBlessGroupData Clone()
		{
			return new RoverRogueBlessGroupData(this);
		}

		// Token: 0x17004D81 RID: 19841
		// (get) Token: 0x06017219 RID: 94745 RVA: 0x0035B6C8 File Offset: 0x003598C8
		// (set) Token: 0x0601721A RID: 94746 RVA: 0x0035B6D0 File Offset: 0x003598D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BlessGroupId
		{
			get
			{
				return this.blessGroupId_;
			}
			set
			{
				this.blessGroupId_ = value;
			}
		}

		// Token: 0x17004D82 RID: 19842
		// (get) Token: 0x0601721B RID: 94747 RVA: 0x0035B6D9 File Offset: 0x003598D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> BlessIdList
		{
			get
			{
				return this.blessIdList_;
			}
		}

		// Token: 0x0601721C RID: 94748 RVA: 0x0035B6E1 File Offset: 0x003598E1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoverRogueBlessGroupData);
		}

		// Token: 0x0601721D RID: 94749 RVA: 0x0035B6F0 File Offset: 0x003598F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoverRogueBlessGroupData other)
		{
			return other != null && (other == this || (this.BlessGroupId == other.BlessGroupId && this.blessIdList_.Equals(other.blessIdList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601721E RID: 94750 RVA: 0x0035B740 File Offset: 0x00359940
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.BlessGroupId != 0)
			{
				num ^= this.BlessGroupId.GetHashCode();
			}
			num ^= this.blessIdList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601721F RID: 94751 RVA: 0x0035B78D File Offset: 0x0035998D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017220 RID: 94752 RVA: 0x0035B79A File Offset: 0x0035999A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017221 RID: 94753 RVA: 0x0035B7A4 File Offset: 0x003599A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.BlessGroupId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.BlessGroupId);
			}
			this.blessIdList_.WriteTo(ref output, RoverRogueBlessGroupData._repeated_blessIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017222 RID: 94754 RVA: 0x0035B7F4 File Offset: 0x003599F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.BlessGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BlessGroupId);
			}
			num += this.blessIdList_.CalculateSize(RoverRogueBlessGroupData._repeated_blessIdList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017223 RID: 94755 RVA: 0x0035B848 File Offset: 0x00359A48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoverRogueBlessGroupData other)
		{
			if (other == null)
			{
				return;
			}
			if (other.BlessGroupId != 0)
			{
				this.BlessGroupId = other.BlessGroupId;
			}
			this.blessIdList_.Add(other.blessIdList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017224 RID: 94756 RVA: 0x0035B895 File Offset: 0x00359A95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017225 RID: 94757 RVA: 0x0035B8A0 File Offset: 0x00359AA0
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
					if (num != 24U && num != 26U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.blessIdList_.AddEntriesFrom(ref input, RoverRogueBlessGroupData._repeated_blessIdList_codec);
					}
				}
				else
				{
					this.BlessGroupId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400899A RID: 35226
		private static readonly MessageParser<RoverRogueBlessGroupData> _parser = new MessageParser<RoverRogueBlessGroupData>(() => new RoverRogueBlessGroupData());

		// Token: 0x0400899B RID: 35227
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400899C RID: 35228
		public const int BlessGroupIdFieldNumber = 2;

		// Token: 0x0400899D RID: 35229
		private int blessGroupId_;

		// Token: 0x0400899E RID: 35230
		public const int BlessIdListFieldNumber = 3;

		// Token: 0x0400899F RID: 35231
		private static readonly FieldCodec<int> _repeated_blessIdList_codec = FieldCodec.ForInt32(26U);

		// Token: 0x040089A0 RID: 35232
		private readonly RepeatedField<int> blessIdList_ = new RepeatedField<int>();
	}
}
