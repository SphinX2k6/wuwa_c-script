using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B11 RID: 2833
	[NetMessage(EMessageId.NewPlayerSupportRewardTaskResponse)]
	public sealed class NewPlayerSupportRewardTaskResponse : IMessage<NewPlayerSupportRewardTaskResponse>, IMessage, IEquatable<NewPlayerSupportRewardTaskResponse>, IDeepCloneable<NewPlayerSupportRewardTaskResponse>, IBufferMessage
	{
		// Token: 0x0600F656 RID: 63062 RVA: 0x0023F36D File Offset: 0x0023D56D
		[NullableContext(1)]
		public static NewPlayerSupportRewardTaskResponse Create()
		{
			return new NewPlayerSupportRewardTaskResponse();
		}

		// Token: 0x1700322A RID: 12842
		// (get) Token: 0x0600F657 RID: 63063 RVA: 0x0023F374 File Offset: 0x0023D574
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700322B RID: 12843
		// (get) Token: 0x0600F658 RID: 63064 RVA: 0x0023F377 File Offset: 0x0023D577
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportRewardTaskResponse.Descriptor;
			}
		}

		// Token: 0x0600F659 RID: 63065 RVA: 0x0023F37E File Offset: 0x0023D57E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportRewardTaskResponse()
		{
		}

		// Token: 0x0600F65A RID: 63066 RVA: 0x0023F391 File Offset: 0x0023D591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportRewardTaskResponse(NewPlayerSupportRewardTaskResponse other) : this()
		{
			this.code_ = other.code_;
			this.roleId_ = other.roleId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F65B RID: 63067 RVA: 0x0023F3C7 File Offset: 0x0023D5C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportRewardTaskResponse Clone()
		{
			return new NewPlayerSupportRewardTaskResponse(this);
		}

		// Token: 0x1700322C RID: 12844
		// (get) Token: 0x0600F65C RID: 63068 RVA: 0x0023F3CF File Offset: 0x0023D5CF
		// (set) Token: 0x0600F65D RID: 63069 RVA: 0x0023F3D7 File Offset: 0x0023D5D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x1700322D RID: 12845
		// (get) Token: 0x0600F65E RID: 63070 RVA: 0x0023F3E0 File Offset: 0x0023D5E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleId
		{
			get
			{
				return this.roleId_;
			}
		}

		// Token: 0x0600F65F RID: 63071 RVA: 0x0023F3E8 File Offset: 0x0023D5E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportRewardTaskResponse);
		}

		// Token: 0x0600F660 RID: 63072 RVA: 0x0023F3F8 File Offset: 0x0023D5F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportRewardTaskResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.roleId_.Equals(other.roleId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F661 RID: 63073 RVA: 0x0023F448 File Offset: 0x0023D648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			num ^= this.roleId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F662 RID: 63074 RVA: 0x0023F49B File Offset: 0x0023D69B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F663 RID: 63075 RVA: 0x0023F4A8 File Offset: 0x0023D6A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F664 RID: 63076 RVA: 0x0023F4B4 File Offset: 0x0023D6B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.roleId_.WriteTo(ref output, NewPlayerSupportRewardTaskResponse._repeated_roleId_codec);
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Code);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F665 RID: 63077 RVA: 0x0023F504 File Offset: 0x0023D704
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			num += this.roleId_.CalculateSize(NewPlayerSupportRewardTaskResponse._repeated_roleId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F666 RID: 63078 RVA: 0x0023F558 File Offset: 0x0023D758
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(NewPlayerSupportRewardTaskResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			this.roleId_.Add(other.roleId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F667 RID: 63079 RVA: 0x0023F5A5 File Offset: 0x0023D7A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F668 RID: 63080 RVA: 0x0023F5B0 File Offset: 0x0023D7B0
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
				if (num != 48U && num != 50U)
				{
					if (num != 80U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.roleId_.AddEntriesFrom(ref input, NewPlayerSupportRewardTaskResponse._repeated_roleId_codec);
				}
			}
		}

		// Token: 0x04006355 RID: 25429
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006356 RID: 25430
		public const int CodeFieldNumber = 10;

		// Token: 0x04006357 RID: 25431
		private ErrorCode code_;

		// Token: 0x04006358 RID: 25432
		public const int RoleIdFieldNumber = 6;

		// Token: 0x04006359 RID: 25433
		private static readonly FieldCodec<int> _repeated_roleId_codec = FieldCodec.ForInt32(50U);

		// Token: 0x0400635A RID: 25434
		private readonly RepeatedField<int> roleId_ = new RepeatedField<int>();
	}
}
