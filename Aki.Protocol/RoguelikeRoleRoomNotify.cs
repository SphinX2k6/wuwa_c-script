using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000FA3 RID: 4003
	[NetMessage(EMessageId.RoguelikeRoleRoomNotify)]
	public sealed class RoguelikeRoleRoomNotify : IMessage<RoguelikeRoleRoomNotify>, IMessage, IEquatable<RoguelikeRoleRoomNotify>, IDeepCloneable<RoguelikeRoleRoomNotify>, IBufferMessage
	{
		// Token: 0x060156F4 RID: 87796 RVA: 0x0031D39D File Offset: 0x0031B59D
		[NullableContext(1)]
		public static RoguelikeRoleRoomNotify Create()
		{
			return new RoguelikeRoleRoomNotify();
		}

		// Token: 0x1700477D RID: 18301
		// (get) Token: 0x060156F5 RID: 87797 RVA: 0x0031D3A4 File Offset: 0x0031B5A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700477E RID: 18302
		// (get) Token: 0x060156F6 RID: 87798 RVA: 0x0031D3A7 File Offset: 0x0031B5A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoguelikeRoleRoomNotify.Descriptor;
			}
		}

		// Token: 0x060156F7 RID: 87799 RVA: 0x0031D3AE File Offset: 0x0031B5AE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleRoomNotify()
		{
		}

		// Token: 0x060156F8 RID: 87800 RVA: 0x0031D3C1 File Offset: 0x0031B5C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleRoomNotify(RoguelikeRoleRoomNotify other) : this()
		{
			this.index_ = other.index_;
			this.roleRoomIds_ = other.roleRoomIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060156F9 RID: 87801 RVA: 0x0031D3F7 File Offset: 0x0031B5F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoguelikeRoleRoomNotify Clone()
		{
			return new RoguelikeRoleRoomNotify(this);
		}

		// Token: 0x1700477F RID: 18303
		// (get) Token: 0x060156FA RID: 87802 RVA: 0x0031D3FF File Offset: 0x0031B5FF
		// (set) Token: 0x060156FB RID: 87803 RVA: 0x0031D407 File Offset: 0x0031B607
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

		// Token: 0x17004780 RID: 18304
		// (get) Token: 0x060156FC RID: 87804 RVA: 0x0031D410 File Offset: 0x0031B610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleRoomIds
		{
			get
			{
				return this.roleRoomIds_;
			}
		}

		// Token: 0x060156FD RID: 87805 RVA: 0x0031D418 File Offset: 0x0031B618
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoguelikeRoleRoomNotify);
		}

		// Token: 0x060156FE RID: 87806 RVA: 0x0031D428 File Offset: 0x0031B628
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoguelikeRoleRoomNotify other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.roleRoomIds_.Equals(other.roleRoomIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060156FF RID: 87807 RVA: 0x0031D478 File Offset: 0x0031B678
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

		// Token: 0x06015700 RID: 87808 RVA: 0x0031D4C5 File Offset: 0x0031B6C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06015701 RID: 87809 RVA: 0x0031D4D2 File Offset: 0x0031B6D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06015702 RID: 87810 RVA: 0x0031D4DC File Offset: 0x0031B6DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Index != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Index);
			}
			this.roleRoomIds_.WriteTo(ref output, RoguelikeRoleRoomNotify._repeated_roleRoomIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06015703 RID: 87811 RVA: 0x0031D52C File Offset: 0x0031B72C
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

		// Token: 0x06015704 RID: 87812 RVA: 0x0031D580 File Offset: 0x0031B780
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

		// Token: 0x06015705 RID: 87813 RVA: 0x0031D5CD File Offset: 0x0031B7CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06015706 RID: 87814 RVA: 0x0031D5D8 File Offset: 0x0031B7D8
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
				if (num != 32U)
				{
					if (num != 56U && num != 58U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.roleRoomIds_.AddEntriesFrom(ref input, RoguelikeRoleRoomNotify._repeated_roleRoomIds_codec);
					}
				}
				else
				{
					this.Index = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400815E RID: 33118
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400815F RID: 33119
		public const int IndexFieldNumber = 4;

		// Token: 0x04008160 RID: 33120
		private int index_;

		// Token: 0x04008161 RID: 33121
		public const int RoleRoomIdsFieldNumber = 7;

		// Token: 0x04008162 RID: 33122
		private static readonly FieldCodec<int> _repeated_roleRoomIds_codec = FieldCodec.ForInt32(58U);

		// Token: 0x04008163 RID: 33123
		private readonly RepeatedField<int> roleRoomIds_ = new RepeatedField<int>();
	}
}
