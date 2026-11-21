using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D19 RID: 3353
	public sealed class PhotoFightLevelGroupPb : IMessage<PhotoFightLevelGroupPb>, IMessage, IEquatable<PhotoFightLevelGroupPb>, IDeepCloneable<PhotoFightLevelGroupPb>, IBufferMessage
	{
		// Token: 0x06012211 RID: 74257 RVA: 0x002A652F File Offset: 0x002A472F
		[NullableContext(1)]
		public static PhotoFightLevelGroupPb Create()
		{
			return new PhotoFightLevelGroupPb();
		}

		// Token: 0x17003C10 RID: 15376
		// (get) Token: 0x06012212 RID: 74258 RVA: 0x002A6536 File Offset: 0x002A4736
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PhotoFightLevelGroupPb> Parser
		{
			get
			{
				return PhotoFightLevelGroupPb._parser;
			}
		}

		// Token: 0x17003C11 RID: 15377
		// (get) Token: 0x06012213 RID: 74259 RVA: 0x002A653D File Offset: 0x002A473D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003C12 RID: 15378
		// (get) Token: 0x06012214 RID: 74260 RVA: 0x002A6540 File Offset: 0x002A4740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhotoFightLevelGroupPb.Descriptor;
			}
		}

		// Token: 0x06012215 RID: 74261 RVA: 0x002A6547 File Offset: 0x002A4747
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightLevelGroupPb()
		{
		}

		// Token: 0x06012216 RID: 74262 RVA: 0x002A655C File Offset: 0x002A475C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightLevelGroupPb(PhotoFightLevelGroupPb other) : this()
		{
			this.groupId_ = other.groupId_;
			this.openTime_ = other.openTime_;
			this.endTime_ = other.endTime_;
			this.photoFightLevelInfo_ = other.photoFightLevelInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012217 RID: 74263 RVA: 0x002A65B5 File Offset: 0x002A47B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhotoFightLevelGroupPb Clone()
		{
			return new PhotoFightLevelGroupPb(this);
		}

		// Token: 0x17003C13 RID: 15379
		// (get) Token: 0x06012218 RID: 74264 RVA: 0x002A65BD File Offset: 0x002A47BD
		// (set) Token: 0x06012219 RID: 74265 RVA: 0x002A65C5 File Offset: 0x002A47C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int GroupId
		{
			get
			{
				return this.groupId_;
			}
			set
			{
				this.groupId_ = value;
			}
		}

		// Token: 0x17003C14 RID: 15380
		// (get) Token: 0x0601221A RID: 74266 RVA: 0x002A65CE File Offset: 0x002A47CE
		// (set) Token: 0x0601221B RID: 74267 RVA: 0x002A65D6 File Offset: 0x002A47D6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long OpenTime
		{
			get
			{
				return this.openTime_;
			}
			set
			{
				this.openTime_ = value;
			}
		}

		// Token: 0x17003C15 RID: 15381
		// (get) Token: 0x0601221C RID: 74268 RVA: 0x002A65DF File Offset: 0x002A47DF
		// (set) Token: 0x0601221D RID: 74269 RVA: 0x002A65E7 File Offset: 0x002A47E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EndTime
		{
			get
			{
				return this.endTime_;
			}
			set
			{
				this.endTime_ = value;
			}
		}

		// Token: 0x17003C16 RID: 15382
		// (get) Token: 0x0601221E RID: 74270 RVA: 0x002A65F0 File Offset: 0x002A47F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhotoFightLevelPb> PhotoFightLevelInfo
		{
			get
			{
				return this.photoFightLevelInfo_;
			}
		}

		// Token: 0x0601221F RID: 74271 RVA: 0x002A65F8 File Offset: 0x002A47F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhotoFightLevelGroupPb);
		}

		// Token: 0x06012220 RID: 74272 RVA: 0x002A6608 File Offset: 0x002A4808
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhotoFightLevelGroupPb other)
		{
			return other != null && (other == this || (this.GroupId == other.GroupId && this.OpenTime == other.OpenTime && this.EndTime == other.EndTime && this.photoFightLevelInfo_.Equals(other.photoFightLevelInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012221 RID: 74273 RVA: 0x002A6678 File Offset: 0x002A4878
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.GroupId != 0)
			{
				num ^= this.GroupId.GetHashCode();
			}
			if (this.OpenTime != 0L)
			{
				num ^= this.OpenTime.GetHashCode();
			}
			if (this.EndTime != 0L)
			{
				num ^= this.EndTime.GetHashCode();
			}
			num ^= this.photoFightLevelInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012222 RID: 74274 RVA: 0x002A66F7 File Offset: 0x002A48F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012223 RID: 74275 RVA: 0x002A6704 File Offset: 0x002A4904
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012224 RID: 74276 RVA: 0x002A6710 File Offset: 0x002A4910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.GroupId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.GroupId);
			}
			if (this.OpenTime != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(this.OpenTime);
			}
			if (this.EndTime != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(this.EndTime);
			}
			this.photoFightLevelInfo_.WriteTo(ref output, PhotoFightLevelGroupPb._repeated_photoFightLevelInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012225 RID: 74277 RVA: 0x002A6798 File Offset: 0x002A4998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.GroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.GroupId);
			}
			if (this.OpenTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.OpenTime);
			}
			if (this.EndTime != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EndTime);
			}
			num += this.photoFightLevelInfo_.CalculateSize(PhotoFightLevelGroupPb._repeated_photoFightLevelInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012226 RID: 74278 RVA: 0x002A681C File Offset: 0x002A4A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhotoFightLevelGroupPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.GroupId != 0)
			{
				this.GroupId = other.GroupId;
			}
			if (other.OpenTime != 0L)
			{
				this.OpenTime = other.OpenTime;
			}
			if (other.EndTime != 0L)
			{
				this.EndTime = other.EndTime;
			}
			this.photoFightLevelInfo_.Add(other.photoFightLevelInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012227 RID: 74279 RVA: 0x002A6891 File Offset: 0x002A4A91
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012228 RID: 74280 RVA: 0x002A689C File Offset: 0x002A4A9C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.GroupId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.OpenTime = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.EndTime = input.ReadInt64();
						continue;
					}
					if (num == 34U)
					{
						this.photoFightLevelInfo_.AddEntriesFrom(ref input, PhotoFightLevelGroupPb._repeated_photoFightLevelInfo_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040071B0 RID: 29104
		private static readonly MessageParser<PhotoFightLevelGroupPb> _parser = new MessageParser<PhotoFightLevelGroupPb>(() => new PhotoFightLevelGroupPb());

		// Token: 0x040071B1 RID: 29105
		private UnknownFieldSet _unknownFields;

		// Token: 0x040071B2 RID: 29106
		public const int GroupIdFieldNumber = 1;

		// Token: 0x040071B3 RID: 29107
		private int groupId_;

		// Token: 0x040071B4 RID: 29108
		public const int OpenTimeFieldNumber = 2;

		// Token: 0x040071B5 RID: 29109
		private long openTime_;

		// Token: 0x040071B6 RID: 29110
		public const int EndTimeFieldNumber = 3;

		// Token: 0x040071B7 RID: 29111
		private long endTime_;

		// Token: 0x040071B8 RID: 29112
		public const int PhotoFightLevelInfoFieldNumber = 4;

		// Token: 0x040071B9 RID: 29113
		private static readonly FieldCodec<PhotoFightLevelPb> _repeated_photoFightLevelInfo_codec = FieldCodec.ForMessage<PhotoFightLevelPb>(34U, PhotoFightLevelPb.Parser);

		// Token: 0x040071BA RID: 29114
		private readonly RepeatedField<PhotoFightLevelPb> photoFightLevelInfo_ = new RepeatedField<PhotoFightLevelPb>();
	}
}
