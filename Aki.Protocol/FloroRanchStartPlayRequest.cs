using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005E7 RID: 1511
	[NetMessage(EMessageId.FloroRanchStartPlayRequest)]
	public sealed class FloroRanchStartPlayRequest : IMessage<FloroRanchStartPlayRequest>, IMessage, IEquatable<FloroRanchStartPlayRequest>, IDeepCloneable<FloroRanchStartPlayRequest>, IBufferMessage
	{
		// Token: 0x06008BD2 RID: 35794 RVA: 0x0015247E File Offset: 0x0015067E
		[NullableContext(1)]
		public static FloroRanchStartPlayRequest Create()
		{
			return new FloroRanchStartPlayRequest();
		}

		// Token: 0x17001BA2 RID: 7074
		// (get) Token: 0x06008BD3 RID: 35795 RVA: 0x00152485 File Offset: 0x00150685
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001BA3 RID: 7075
		// (get) Token: 0x06008BD4 RID: 35796 RVA: 0x00152488 File Offset: 0x00150688
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchStartPlayRequest.Descriptor;
			}
		}

		// Token: 0x06008BD5 RID: 35797 RVA: 0x0015248F File Offset: 0x0015068F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStartPlayRequest()
		{
		}

		// Token: 0x06008BD6 RID: 35798 RVA: 0x001524A4 File Offset: 0x001506A4
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

		// Token: 0x06008BD7 RID: 35799 RVA: 0x001524FD File Offset: 0x001506FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchStartPlayRequest Clone()
		{
			return new FloroRanchStartPlayRequest(this);
		}

		// Token: 0x17001BA4 RID: 7076
		// (get) Token: 0x06008BD8 RID: 35800 RVA: 0x00152505 File Offset: 0x00150705
		// (set) Token: 0x06008BD9 RID: 35801 RVA: 0x0015250D File Offset: 0x0015070D
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

		// Token: 0x17001BA5 RID: 7077
		// (get) Token: 0x06008BDA RID: 35802 RVA: 0x00152516 File Offset: 0x00150716
		// (set) Token: 0x06008BDB RID: 35803 RVA: 0x0015251E File Offset: 0x0015071E
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

		// Token: 0x17001BA6 RID: 7078
		// (get) Token: 0x06008BDC RID: 35804 RVA: 0x00152527 File Offset: 0x00150727
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Races
		{
			get
			{
				return this.races_;
			}
		}

		// Token: 0x17001BA7 RID: 7079
		// (get) Token: 0x06008BDD RID: 35805 RVA: 0x0015252F File Offset: 0x0015072F
		// (set) Token: 0x06008BDE RID: 35806 RVA: 0x00152537 File Offset: 0x00150737
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

		// Token: 0x06008BDF RID: 35807 RVA: 0x00152540 File Offset: 0x00150740
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchStartPlayRequest);
		}

		// Token: 0x06008BE0 RID: 35808 RVA: 0x00152550 File Offset: 0x00150750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchStartPlayRequest other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.SubInsId == other.SubInsId && this.races_.Equals(other.races_) && this.SkillId == other.SkillId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008BE1 RID: 35809 RVA: 0x001525C0 File Offset: 0x001507C0
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

		// Token: 0x06008BE2 RID: 35810 RVA: 0x0015263F File Offset: 0x0015083F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008BE3 RID: 35811 RVA: 0x0015264C File Offset: 0x0015084C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008BE4 RID: 35812 RVA: 0x00152658 File Offset: 0x00150858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.races_.WriteTo(ref output, FloroRanchStartPlayRequest._repeated_races_codec);
			if (this.SubInsId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.SubInsId);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.SkillId);
			}
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.ActivityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008BE5 RID: 35813 RVA: 0x001526E0 File Offset: 0x001508E0
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

		// Token: 0x06008BE6 RID: 35814 RVA: 0x00152764 File Offset: 0x00150964
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

		// Token: 0x06008BE7 RID: 35815 RVA: 0x001527D9 File Offset: 0x001509D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008BE8 RID: 35816 RVA: 0x001527E4 File Offset: 0x001509E4
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
				if (num <= 26U)
				{
					if (num == 24U || num == 26U)
					{
						this.races_.AddEntriesFrom(ref input, FloroRanchStartPlayRequest._repeated_races_codec);
						continue;
					}
				}
				else
				{
					if (num == 56U)
					{
						this.SubInsId = input.ReadInt32();
						continue;
					}
					if (num == 80U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
					if (num == 120U)
					{
						this.ActivityId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004487 RID: 17543
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004488 RID: 17544
		public const int ActivityIdFieldNumber = 15;

		// Token: 0x04004489 RID: 17545
		private int activityId_;

		// Token: 0x0400448A RID: 17546
		public const int SubInsIdFieldNumber = 7;

		// Token: 0x0400448B RID: 17547
		private int subInsId_;

		// Token: 0x0400448C RID: 17548
		public const int RacesFieldNumber = 3;

		// Token: 0x0400448D RID: 17549
		private static readonly FieldCodec<int> _repeated_races_codec = FieldCodec.ForInt32(26U);

		// Token: 0x0400448E RID: 17550
		private readonly RepeatedField<int> races_ = new RepeatedField<int>();

		// Token: 0x0400448F RID: 17551
		public const int SkillIdFieldNumber = 10;

		// Token: 0x04004490 RID: 17552
		private int skillId_;
	}
}
