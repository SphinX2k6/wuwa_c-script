using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005D2 RID: 1490
	[NetMessage(EMessageId.FloroRanchStartPlayRequest)]
	public sealed class FloroRanchStartPlayRequest : IMessage<FloroRanchStartPlayRequest>, IMessage, IEquatable<FloroRanchStartPlayRequest>, IDeepCloneable<FloroRanchStartPlayRequest>, IBufferMessage
	{
		// Token: 0x06008A6A RID: 35434 RVA: 0x0014F86A File Offset: 0x0014DA6A
		[NullableContext(1)]
		public static FloroRanchStartPlayRequest Create()
		{
			return new FloroRanchStartPlayRequest();
		}

		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x06008A6B RID: 35435 RVA: 0x0014F871 File Offset: 0x0014DA71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x06008A6C RID: 35436 RVA: 0x0014F874 File Offset: 0x0014DA74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchStartPlayRequest.Descriptor;
			}
		}

		// Token: 0x06008A6D RID: 35437 RVA: 0x0014F87B File Offset: 0x0014DA7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStartPlayRequest()
		{
		}

		// Token: 0x06008A6E RID: 35438 RVA: 0x0014F890 File Offset: 0x0014DA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStartPlayRequest(FloroRanchStartPlayRequest other) : this()
		{
			this.activityId_ = other.activityId_;
			this.subInsId_ = other.subInsId_;
			this.races_ = other.races_.Clone();
			this.skillId_ = other.skillId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008A6F RID: 35439 RVA: 0x0014F8E9 File Offset: 0x0014DAE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStartPlayRequest Clone()
		{
			return new FloroRanchStartPlayRequest(this);
		}

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x06008A70 RID: 35440 RVA: 0x0014F8F1 File Offset: 0x0014DAF1
		// (set) Token: 0x06008A71 RID: 35441 RVA: 0x0014F8F9 File Offset: 0x0014DAF9
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

		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x06008A72 RID: 35442 RVA: 0x0014F902 File Offset: 0x0014DB02
		// (set) Token: 0x06008A73 RID: 35443 RVA: 0x0014F90A File Offset: 0x0014DB0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubInsId
		{
			get
			{
				return this.subInsId_;
			}
			set
			{
				this.subInsId_ = value;
			}
		}

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x06008A74 RID: 35444 RVA: 0x0014F913 File Offset: 0x0014DB13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Races
		{
			get
			{
				return this.races_;
			}
		}

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x06008A75 RID: 35445 RVA: 0x0014F91B File Offset: 0x0014DB1B
		// (set) Token: 0x06008A76 RID: 35446 RVA: 0x0014F923 File Offset: 0x0014DB23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x06008A77 RID: 35447 RVA: 0x0014F92C File Offset: 0x0014DB2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchStartPlayRequest);
		}

		// Token: 0x06008A78 RID: 35448 RVA: 0x0014F93C File Offset: 0x0014DB3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchStartPlayRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.races_.Equals(other.races_) && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008A79 RID: 35449 RVA: 0x0014F9AC File Offset: 0x0014DBAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			if (this.SubInsId != 0)
			{
				num ^= this.SubInsId.GetHashCode();
			}
			num ^= this.races_.GetHashCode();
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008A7A RID: 35450 RVA: 0x0014FA2B File Offset: 0x0014DC2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008A7B RID: 35451 RVA: 0x0014FA38 File Offset: 0x0014DC38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008A7C RID: 35452 RVA: 0x0014FA44 File Offset: 0x0014DC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SubInsId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ActivityId);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.SkillId);
			}
			this.races_.WriteTo(ref output, FloroRanchStartPlayRequest._repeated_races_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008A7D RID: 35453 RVA: 0x0014FACC File Offset: 0x0014DCCC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			if (this.SubInsId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubInsId);
			}
			num += this.races_.CalculateSize(FloroRanchStartPlayRequest._repeated_races_codec);
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008A7E RID: 35454 RVA: 0x0014FB50 File Offset: 0x0014DD50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchStartPlayRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			if (other.SubInsId != 0)
			{
				this.SubInsId = other.SubInsId;
			}
			this.races_.Add(other.races_);
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008A7F RID: 35455 RVA: 0x0014FBC5 File Offset: 0x0014DDC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008A80 RID: 35456 RVA: 0x0014FBD0 File Offset: 0x0014DDD0
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
				if (num <= 56U)
				{
					if (num == 40U)
					{
						this.SubInsId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 88U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
					if (num == 120U || num == 122U)
					{
						this.races_.AddEntriesFrom(ref input, FloroRanchStartPlayRequest._repeated_races_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400447D RID: 17533
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400447E RID: 17534
		public const int ActivityIdFieldNumber = 7;

		// Token: 0x0400447F RID: 17535
		private int activityId_;

		// Token: 0x04004480 RID: 17536
		public const int SubInsIdFieldNumber = 5;

		// Token: 0x04004481 RID: 17537
		private int subInsId_;

		// Token: 0x04004482 RID: 17538
		public const int RacesFieldNumber = 15;

		// Token: 0x04004483 RID: 17539
		private static readonly FieldCodec<int> _repeated_races_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04004484 RID: 17540
		private readonly RepeatedField<int> races_ = new RepeatedField<int>();

		// Token: 0x04004485 RID: 17541
		public const int SkillIdFieldNumber = 11;

		// Token: 0x04004486 RID: 17542
		private int skillId_;
	}
}
