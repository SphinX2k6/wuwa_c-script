using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000A67 RID: 2663
	[NetMessage(EMessageId.MotorLockedTechUpdateNotify)]
	public sealed class MotorLockedTechUpdateNotify : IMessage<MotorLockedTechUpdateNotify>, IMessage, IEquatable<MotorLockedTechUpdateNotify>, IDeepCloneable<MotorLockedTechUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600E87F RID: 59519 RVA: 0x0021F904 File Offset: 0x0021DB04
		[NullableContext(1)]
		public static MotorLockedTechUpdateNotify Create()
		{
			return new MotorLockedTechUpdateNotify();
		}

		// Token: 0x17002F28 RID: 12072
		// (get) Token: 0x0600E880 RID: 59520 RVA: 0x0021F90B File Offset: 0x0021DB0B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002F29 RID: 12073
		// (get) Token: 0x0600E881 RID: 59521 RVA: 0x0021F90E File Offset: 0x0021DB0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MotorLockedTechUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600E882 RID: 59522 RVA: 0x0021F915 File Offset: 0x0021DB15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLockedTechUpdateNotify()
		{
		}

		// Token: 0x0600E883 RID: 59523 RVA: 0x0021F928 File Offset: 0x0021DB28
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLockedTechUpdateNotify(MotorLockedTechUpdateNotify other) : this()
		{
			this.treeId_ = other.treeId_;
			this.tech_ = other.tech_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600E884 RID: 59524 RVA: 0x0021F95E File Offset: 0x0021DB5E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MotorLockedTechUpdateNotify Clone()
		{
			return new MotorLockedTechUpdateNotify(this);
		}

		// Token: 0x17002F2A RID: 12074
		// (get) Token: 0x0600E885 RID: 59525 RVA: 0x0021F966 File Offset: 0x0021DB66
		// (set) Token: 0x0600E886 RID: 59526 RVA: 0x0021F96E File Offset: 0x0021DB6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int TreeId
		{
			get
			{
				return this.treeId_;
			}
			set
			{
				this.treeId_ = value;
			}
		}

		// Token: 0x17002F2B RID: 12075
		// (get) Token: 0x0600E887 RID: 59527 RVA: 0x0021F977 File Offset: 0x0021DB77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MotorTechPb> Tech
		{
			get
			{
				return this.tech_;
			}
		}

		// Token: 0x0600E888 RID: 59528 RVA: 0x0021F97F File Offset: 0x0021DB7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MotorLockedTechUpdateNotify);
		}

		// Token: 0x0600E889 RID: 59529 RVA: 0x0021F990 File Offset: 0x0021DB90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MotorLockedTechUpdateNotify other)
		{
			return other != null && (other == this || (this.TreeId == other.TreeId && this.tech_.Equals(other.tech_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600E88A RID: 59530 RVA: 0x0021F9E0 File Offset: 0x0021DBE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.TreeId != 0)
			{
				num ^= this.TreeId.GetHashCode();
			}
			num ^= this.tech_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600E88B RID: 59531 RVA: 0x0021FA2D File Offset: 0x0021DC2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600E88C RID: 59532 RVA: 0x0021FA3A File Offset: 0x0021DC3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600E88D RID: 59533 RVA: 0x0021FA44 File Offset: 0x0021DC44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.TreeId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.TreeId);
			}
			this.tech_.WriteTo(ref output, MotorLockedTechUpdateNotify._repeated_tech_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600E88E RID: 59534 RVA: 0x0021FA94 File Offset: 0x0021DC94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.TreeId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.TreeId);
			}
			num += this.tech_.CalculateSize(MotorLockedTechUpdateNotify._repeated_tech_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600E88F RID: 59535 RVA: 0x0021FAE8 File Offset: 0x0021DCE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MotorLockedTechUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.TreeId != 0)
			{
				this.TreeId = other.TreeId;
			}
			this.tech_.Add(other.tech_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600E890 RID: 59536 RVA: 0x0021FB35 File Offset: 0x0021DD35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600E891 RID: 59537 RVA: 0x0021FB40 File Offset: 0x0021DD40
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
				if (num != 56U)
				{
					if (num != 114U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.tech_.AddEntriesFrom(ref input, MotorLockedTechUpdateNotify._repeated_tech_codec);
					}
				}
				else
				{
					this.TreeId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005EFD RID: 24317
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005EFE RID: 24318
		public const int TreeIdFieldNumber = 7;

		// Token: 0x04005EFF RID: 24319
		private int treeId_;

		// Token: 0x04005F00 RID: 24320
		public const int TechFieldNumber = 14;

		// Token: 0x04005F01 RID: 24321
		private static readonly FieldCodec<MotorTechPb> _repeated_tech_codec = FieldCodec.ForMessage<MotorTechPb>(114U, MotorTechPb.Parser);

		// Token: 0x04005F02 RID: 24322
		private readonly RepeatedField<MotorTechPb> tech_ = new RepeatedField<MotorTechPb>();
	}
}
