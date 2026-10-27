using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FB3 RID: 4019
	[NetMessage(EMessageId.RoguelikeRoleRoomNotify)]
	public sealed class RoguelikeRoleRoomNotify : IMessage<RoguelikeRoleRoomNotify>, IMessage, IEquatable<RoguelikeRoleRoomNotify>, IDeepCloneable<RoguelikeRoleRoomNotify>, IBufferMessage
	{
		// Token: 0x060157D9 RID: 88025 RVA: 0x0031EA49 File Offset: 0x0031CC49
		[NullableContext(1)]
		public static RoguelikeRoleRoomNotify Create()
		{
			return new RoguelikeRoleRoomNotify();
		}

		// Token: 0x170047A7 RID: 18343
		// (get) Token: 0x060157DA RID: 88026 RVA: 0x0031EA50 File Offset: 0x0031CC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170047A8 RID: 18344
		// (get) Token: 0x060157DB RID: 88027 RVA: 0x0031EA53 File Offset: 0x0031CC53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeRoleRoomNotify.Descriptor;
			}
		}

		// Token: 0x060157DC RID: 88028 RVA: 0x0031EA5A File Offset: 0x0031CC5A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleRoomNotify()
		{
		}

		// Token: 0x060157DD RID: 88029 RVA: 0x0031EA6D File Offset: 0x0031CC6D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleRoomNotify(RoguelikeRoleRoomNotify other) : this()
		{
			this.index_ = other.index_;
			this.roleRoomIds_ = other.roleRoomIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060157DE RID: 88030 RVA: 0x0031EAA3 File Offset: 0x0031CCA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleRoomNotify Clone()
		{
			return new RoguelikeRoleRoomNotify(this);
		}

		// Token: 0x170047A9 RID: 18345
		// (get) Token: 0x060157DF RID: 88031 RVA: 0x0031EAAB File Offset: 0x0031CCAB
		// (set) Token: 0x060157E0 RID: 88032 RVA: 0x0031EAB3 File Offset: 0x0031CCB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x170047AA RID: 18346
		// (get) Token: 0x060157E1 RID: 88033 RVA: 0x0031EABC File Offset: 0x0031CCBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleRoomIds
		{
			get
			{
				return this.roleRoomIds_;
			}
		}

		// Token: 0x060157E2 RID: 88034 RVA: 0x0031EAC4 File Offset: 0x0031CCC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeRoleRoomNotify);
		}

		// Token: 0x060157E3 RID: 88035 RVA: 0x0031EAD4 File Offset: 0x0031CCD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeRoleRoomNotify other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.roleRoomIds_.Equals(other.roleRoomIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060157E4 RID: 88036 RVA: 0x0031EB24 File Offset: 0x0031CD24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			num ^= this.roleRoomIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060157E5 RID: 88037 RVA: 0x0031EB71 File Offset: 0x0031CD71
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060157E6 RID: 88038 RVA: 0x0031EB7E File Offset: 0x0031CD7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060157E7 RID: 88039 RVA: 0x0031EB88 File Offset: 0x0031CD88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleRoomIds_.WriteTo(ref output, RoguelikeRoleRoomNotify._repeated_roleRoomIds_codec);
			if (this.Index != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060157E8 RID: 88040 RVA: 0x0031EBD8 File Offset: 0x0031CDD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			num += this.roleRoomIds_.CalculateSize(RoguelikeRoleRoomNotify._repeated_roleRoomIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060157E9 RID: 88041 RVA: 0x0031EC2C File Offset: 0x0031CE2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoguelikeRoleRoomNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			this.roleRoomIds_.Add(other.roleRoomIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060157EA RID: 88042 RVA: 0x0031EC79 File Offset: 0x0031CE79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060157EB RID: 88043 RVA: 0x0031EC84 File Offset: 0x0031CE84
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
				if (num != 32U && num != 34U)
				{
					if (num != 40U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Index = input.ReadInt32();
					}
				}
				else
				{
					this.roleRoomIds_.AddEntriesFrom(ref input, RoguelikeRoleRoomNotify._repeated_roleRoomIds_codec);
				}
			}
		}

		// Token: 0x04008134 RID: 33076
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008135 RID: 33077
		public const int IndexFieldNumber = 5;

		// Token: 0x04008136 RID: 33078
		private int index_;

		// Token: 0x04008137 RID: 33079
		public const int RoleRoomIdsFieldNumber = 4;

		// Token: 0x04008138 RID: 33080
		private static readonly FieldCodec<int> _repeated_roleRoomIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04008139 RID: 33081
		private readonly RepeatedField<int> roleRoomIds_ = new RepeatedField<int>();
	}
}
