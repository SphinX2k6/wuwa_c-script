using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FBF RID: 4031
	public sealed class RogueResActivityData : IMessage<RogueResActivityData>, IMessage, IEquatable<RogueResActivityData>, IDeepCloneable<RogueResActivityData>, IBufferMessage
	{
		// Token: 0x0601593B RID: 88379 RVA: 0x00322528 File Offset: 0x00320728
		[NullableContext(1)]
		public static RogueResActivityData Create()
		{
			return new RogueResActivityData();
		}

		// Token: 0x170047FA RID: 18426
		// (get) Token: 0x0601593C RID: 88380 RVA: 0x0032252F File Offset: 0x0032072F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047FB RID: 18427
		// (get) Token: 0x0601593D RID: 88381 RVA: 0x00322532 File Offset: 0x00320732
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RogueResActivityData.Descriptor;
			}
		}

		// Token: 0x0601593E RID: 88382 RVA: 0x00322539 File Offset: 0x00320739
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResActivityData()
		{
		}

		// Token: 0x0601593F RID: 88383 RVA: 0x0032254C File Offset: 0x0032074C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResActivityData(RogueResActivityData other) : this()
		{
			this.rogueResSeasonData_ = other.rogueResSeasonData_.Clone();
			this.rogueResGlobalInfo_ = ((other.rogueResGlobalInfo_ != null) ? other.rogueResGlobalInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06015940 RID: 88384 RVA: 0x0032259D File Offset: 0x0032079D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RogueResActivityData Clone()
		{
			return new RogueResActivityData(this);
		}

		// Token: 0x170047FC RID: 18428
		// (get) Token: 0x06015941 RID: 88385 RVA: 0x003225A5 File Offset: 0x003207A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RogueResSeasonData> RogueResSeasonData
		{
			get
			{
				return this.rogueResSeasonData_;
			}
		}

		// Token: 0x170047FD RID: 18429
		// (get) Token: 0x06015942 RID: 88386 RVA: 0x003225AD File Offset: 0x003207AD
		// (set) Token: 0x06015943 RID: 88387 RVA: 0x003225B5 File Offset: 0x003207B5
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

		// Token: 0x06015944 RID: 88388 RVA: 0x003225BE File Offset: 0x003207BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RogueResActivityData);
		}

		// Token: 0x06015945 RID: 88389 RVA: 0x003225CC File Offset: 0x003207CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RogueResActivityData other)
		{
			return other != null && (other == this || (this.rogueResSeasonData_.Equals(other.rogueResSeasonData_) && object.Equals(this.RogueResGlobalInfo, other.RogueResGlobalInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06015946 RID: 88390 RVA: 0x00322620 File Offset: 0x00320820
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

		// Token: 0x06015947 RID: 88391 RVA: 0x0032266A File Offset: 0x0032086A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015948 RID: 88392 RVA: 0x00322677 File Offset: 0x00320877
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015949 RID: 88393 RVA: 0x00322680 File Offset: 0x00320880
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

		// Token: 0x0601594A RID: 88394 RVA: 0x003226D0 File Offset: 0x003208D0
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

		// Token: 0x0601594B RID: 88395 RVA: 0x00322724 File Offset: 0x00320924
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

		// Token: 0x0601594C RID: 88396 RVA: 0x00322789 File Offset: 0x00320989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601594D RID: 88397 RVA: 0x00322794 File Offset: 0x00320994
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

		// Token: 0x0400820E RID: 33294
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400820F RID: 33295
		public const int RogueResSeasonDataFieldNumber = 1;

		// Token: 0x04008210 RID: 33296
		private static readonly FieldCodec<RogueResSeasonData> _repeated_rogueResSeasonData_codec = FieldCodec.ForMessage<RogueResSeasonData>(10U, Aki.Protocol.RogueResSeasonData.Parser);

		// Token: 0x04008211 RID: 33297
		private readonly RepeatedField<RogueResSeasonData> rogueResSeasonData_ = new RepeatedField<RogueResSeasonData>();

		// Token: 0x04008212 RID: 33298
		public const int RogueResGlobalInfoFieldNumber = 2;

		// Token: 0x04008213 RID: 33299
		private RogueResGlobalInfo rogueResGlobalInfo_;
	}
}
