using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FCF RID: 4047
	public sealed class RogueResActivityData : IMessage<RogueResActivityData>, IMessage, IEquatable<RogueResActivityData>, IDeepCloneable<RogueResActivityData>, IBufferMessage
	{
		// Token: 0x06015A20 RID: 88608 RVA: 0x00323BDC File Offset: 0x00321DDC
		[NullableContext(1)]
		public static RogueResActivityData Create()
		{
			return new RogueResActivityData();
		}

		// Token: 0x17004824 RID: 18468
		// (get) Token: 0x06015A21 RID: 88609 RVA: 0x00323BE3 File Offset: 0x00321DE3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004825 RID: 18469
		// (get) Token: 0x06015A22 RID: 88610 RVA: 0x00323BE6 File Offset: 0x00321DE6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResActivityData.Descriptor;
			}
		}

		// Token: 0x06015A23 RID: 88611 RVA: 0x00323BED File Offset: 0x00321DED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResActivityData()
		{
		}

		// Token: 0x06015A24 RID: 88612 RVA: 0x00323C00 File Offset: 0x00321E00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResActivityData(RogueResActivityData other) : this()
		{
			this.rogueResSeasonData_ = other.rogueResSeasonData_.Clone();
			this.rogueResGlobalInfo_ = ((other.rogueResGlobalInfo_ != null) ? other.rogueResGlobalInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015A25 RID: 88613 RVA: 0x00323C51 File Offset: 0x00321E51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResActivityData Clone()
		{
			return new RogueResActivityData(this);
		}

		// Token: 0x17004826 RID: 18470
		// (get) Token: 0x06015A26 RID: 88614 RVA: 0x00323C59 File Offset: 0x00321E59
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResSeasonData> RogueResSeasonData
		{
			get
			{
				return this.rogueResSeasonData_;
			}
		}

		// Token: 0x17004827 RID: 18471
		// (get) Token: 0x06015A27 RID: 88615 RVA: 0x00323C61 File Offset: 0x00321E61
		// (set) Token: 0x06015A28 RID: 88616 RVA: 0x00323C69 File Offset: 0x00321E69
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResGlobalInfo RogueResGlobalInfo
		{
			get
			{
				return this.rogueResGlobalInfo_;
			}
			set
			{
				this.rogueResGlobalInfo_ = value;
			}
		}

		// Token: 0x06015A29 RID: 88617 RVA: 0x00323C72 File Offset: 0x00321E72
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResActivityData);
		}

		// Token: 0x06015A2A RID: 88618 RVA: 0x00323C80 File Offset: 0x00321E80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResActivityData other)
		{
			return other != null && (other == this || (this.rogueResSeasonData_.Equals(other.rogueResSeasonData_) && object.Equals(this.RogueResGlobalInfo, other.RogueResGlobalInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015A2B RID: 88619 RVA: 0x00323CD4 File Offset: 0x00321ED4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.rogueResSeasonData_.GetHashCode();
			if (this.rogueResGlobalInfo_ != null)
			{
				num ^= this.RogueResGlobalInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06015A2C RID: 88620 RVA: 0x00323D1E File Offset: 0x00321F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015A2D RID: 88621 RVA: 0x00323D2B File Offset: 0x00321F2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015A2E RID: 88622 RVA: 0x00323D34 File Offset: 0x00321F34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.rogueResSeasonData_.WriteTo(ref output, RogueResActivityData._repeated_rogueResSeasonData_codec);
			if (this.rogueResGlobalInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.RogueResGlobalInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015A2F RID: 88623 RVA: 0x00323D84 File Offset: 0x00321F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.rogueResSeasonData_.CalculateSize(RogueResActivityData._repeated_rogueResSeasonData_codec);
			if (this.rogueResGlobalInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RogueResGlobalInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06015A30 RID: 88624 RVA: 0x00323DD8 File Offset: 0x00321FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RogueResActivityData other)
		{
			if (other == null)
			{
				return;
			}
			this.rogueResSeasonData_.Add(other.rogueResSeasonData_);
			if (other.rogueResGlobalInfo_ != null)
			{
				if (this.rogueResGlobalInfo_ == null)
				{
					this.RogueResGlobalInfo = new RogueResGlobalInfo();
				}
				this.RogueResGlobalInfo.MergeFrom(other.RogueResGlobalInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06015A31 RID: 88625 RVA: 0x00323E3D File Offset: 0x0032203D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015A32 RID: 88626 RVA: 0x00323E48 File Offset: 0x00322048
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						if (this.rogueResGlobalInfo_ == null)
						{
							this.RogueResGlobalInfo = new RogueResGlobalInfo();
						}
						input.ReadMessage(this.RogueResGlobalInfo);
					}
				}
				else
				{
					this.rogueResSeasonData_.AddEntriesFrom(ref input, RogueResActivityData._repeated_rogueResSeasonData_codec);
				}
			}
		}

		// Token: 0x040081E4 RID: 33252
		private UnknownFieldSet _unknownFields;

		// Token: 0x040081E5 RID: 33253
		public const int RogueResSeasonDataFieldNumber = 1;

		// Token: 0x040081E6 RID: 33254
		private static readonly FieldCodec<RogueResSeasonData> _repeated_rogueResSeasonData_codec = FieldCodec.ForMessage<RogueResSeasonData>(10U, Aki.Protocol.RogueResSeasonData.Parser);

		// Token: 0x040081E7 RID: 33255
		private readonly RepeatedField<RogueResSeasonData> rogueResSeasonData_ = new RepeatedField<RogueResSeasonData>();

		// Token: 0x040081E8 RID: 33256
		public const int RogueResGlobalInfoFieldNumber = 2;

		// Token: 0x040081E9 RID: 33257
		private RogueResGlobalInfo rogueResGlobalInfo_;
	}
}
