using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F45 RID: 3909
	[NetMessage(EMessageId.RhythmRoleUpdateNotify)]
	public sealed class RhythmRoleUpdateNotify : IMessage<RhythmRoleUpdateNotify>, IMessage, IEquatable<RhythmRoleUpdateNotify>, IDeepCloneable<RhythmRoleUpdateNotify>, IBufferMessage
	{
		// Token: 0x06014EA3 RID: 85667 RVA: 0x00308CE5 File Offset: 0x00306EE5
		[NullableContext(1)]
		public static RhythmRoleUpdateNotify Create()
		{
			return new RhythmRoleUpdateNotify();
		}

		// Token: 0x1700458E RID: 17806
		// (get) Token: 0x06014EA4 RID: 85668 RVA: 0x00308CEC File Offset: 0x00306EEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700458F RID: 17807
		// (get) Token: 0x06014EA5 RID: 85669 RVA: 0x00308CEF File Offset: 0x00306EEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmRoleUpdateNotify.Descriptor;
			}
		}

		// Token: 0x06014EA6 RID: 85670 RVA: 0x00308CF6 File Offset: 0x00306EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRoleUpdateNotify()
		{
		}

		// Token: 0x06014EA7 RID: 85671 RVA: 0x00308D09 File Offset: 0x00306F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRoleUpdateNotify(RhythmRoleUpdateNotify other) : this()
		{
			this.activityId_ = other.activityId_;
			this.unlockedRole_ = other.unlockedRole_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014EA8 RID: 85672 RVA: 0x00308D3F File Offset: 0x00306F3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmRoleUpdateNotify Clone()
		{
			return new RhythmRoleUpdateNotify(this);
		}

		// Token: 0x17004590 RID: 17808
		// (get) Token: 0x06014EA9 RID: 85673 RVA: 0x00308D47 File Offset: 0x00306F47
		// (set) Token: 0x06014EAA RID: 85674 RVA: 0x00308D4F File Offset: 0x00306F4F
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

		// Token: 0x17004591 RID: 17809
		// (get) Token: 0x06014EAB RID: 85675 RVA: 0x00308D58 File Offset: 0x00306F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> UnlockedRole
		{
			get
			{
				return this.unlockedRole_;
			}
		}

		// Token: 0x06014EAC RID: 85676 RVA: 0x00308D60 File Offset: 0x00306F60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmRoleUpdateNotify);
		}

		// Token: 0x06014EAD RID: 85677 RVA: 0x00308D70 File Offset: 0x00306F70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmRoleUpdateNotify other)
		{
			return other != null && (other == this || (this.ActivityId == other.ActivityId && this.unlockedRole_.Equals(other.unlockedRole_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014EAE RID: 85678 RVA: 0x00308DC0 File Offset: 0x00306FC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ActivityId != 0)
			{
				num ^= this.ActivityId.GetHashCode();
			}
			num ^= this.unlockedRole_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014EAF RID: 85679 RVA: 0x00308E0D File Offset: 0x0030700D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014EB0 RID: 85680 RVA: 0x00308E1A File Offset: 0x0030701A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014EB1 RID: 85681 RVA: 0x00308E24 File Offset: 0x00307024
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ActivityId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.ActivityId);
			}
			this.unlockedRole_.WriteTo(ref output, RhythmRoleUpdateNotify._repeated_unlockedRole_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014EB2 RID: 85682 RVA: 0x00308E74 File Offset: 0x00307074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ActivityId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ActivityId);
			}
			num += this.unlockedRole_.CalculateSize(RhythmRoleUpdateNotify._repeated_unlockedRole_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014EB3 RID: 85683 RVA: 0x00308EC8 File Offset: 0x003070C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmRoleUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ActivityId != 0)
			{
				this.ActivityId = other.ActivityId;
			}
			this.unlockedRole_.Add(other.unlockedRole_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014EB4 RID: 85684 RVA: 0x00308F15 File Offset: 0x00307115
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014EB5 RID: 85685 RVA: 0x00308F20 File Offset: 0x00307120
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
				if (num != 40U)
				{
					if (num != 56U && num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.unlockedRole_.AddEntriesFrom(ref input, RhythmRoleUpdateNotify._repeated_unlockedRole_codec);
					}
				}
				else
				{
					this.ActivityId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007E24 RID: 32292
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E25 RID: 32293
		public const int ActivityIdFieldNumber = 5;

		// Token: 0x04007E26 RID: 32294
		private int activityId_;

		// Token: 0x04007E27 RID: 32295
		public const int UnlockedRoleFieldNumber = 7;

		// Token: 0x04007E28 RID: 32296
		private static readonly FieldCodec<int> _repeated_unlockedRole_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04007E29 RID: 32297
		private readonly RepeatedField<int> unlockedRole_ = new RepeatedField<int>();
	}
}
