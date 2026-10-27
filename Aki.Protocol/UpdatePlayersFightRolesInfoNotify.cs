using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014A3 RID: 5283
	[NetMessage(EMessageId.UpdatePlayersFightRolesInfoNotify)]
	public sealed class UpdatePlayersFightRolesInfoNotify : IMessage<UpdatePlayersFightRolesInfoNotify>, IMessage, IEquatable<UpdatePlayersFightRolesInfoNotify>, IDeepCloneable<UpdatePlayersFightRolesInfoNotify>, IBufferMessage
	{
		// Token: 0x0601BF11 RID: 114449 RVA: 0x00409EB9 File Offset: 0x004080B9
		[NullableContext(1)]
		public static UpdatePlayersFightRolesInfoNotify Create()
		{
			return new UpdatePlayersFightRolesInfoNotify();
		}

		// Token: 0x17005E2A RID: 24106
		// (get) Token: 0x0601BF12 RID: 114450 RVA: 0x00409EC0 File Offset: 0x004080C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E2B RID: 24107
		// (get) Token: 0x0601BF13 RID: 114451 RVA: 0x00409EC3 File Offset: 0x004080C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdatePlayersFightRolesInfoNotify.Descriptor;
			}
		}

		// Token: 0x0601BF14 RID: 114452 RVA: 0x00409ECA File Offset: 0x004080CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayersFightRolesInfoNotify()
		{
		}

		// Token: 0x0601BF15 RID: 114453 RVA: 0x00409EDD File Offset: 0x004080DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayersFightRolesInfoNotify(UpdatePlayersFightRolesInfoNotify other) : this()
		{
			this.playersFightRoles_ = other.playersFightRoles_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BF16 RID: 114454 RVA: 0x00409F07 File Offset: 0x00408107
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePlayersFightRolesInfoNotify Clone()
		{
			return new UpdatePlayersFightRolesInfoNotify(this);
		}

		// Token: 0x17005E2C RID: 24108
		// (get) Token: 0x0601BF17 RID: 114455 RVA: 0x00409F0F File Offset: 0x0040810F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PlayerFightRolesInfo> PlayersFightRoles
		{
			get
			{
				return this.playersFightRoles_;
			}
		}

		// Token: 0x0601BF18 RID: 114456 RVA: 0x00409F17 File Offset: 0x00408117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdatePlayersFightRolesInfoNotify);
		}

		// Token: 0x0601BF19 RID: 114457 RVA: 0x00409F25 File Offset: 0x00408125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdatePlayersFightRolesInfoNotify other)
		{
			return other != null && (other == this || (this.playersFightRoles_.Equals(other.playersFightRoles_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BF1A RID: 114458 RVA: 0x00409F58 File Offset: 0x00408158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.playersFightRoles_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BF1B RID: 114459 RVA: 0x00409F8C File Offset: 0x0040818C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BF1C RID: 114460 RVA: 0x00409F99 File Offset: 0x00408199
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BF1D RID: 114461 RVA: 0x00409FA2 File Offset: 0x004081A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.playersFightRoles_.WriteTo(ref output, UpdatePlayersFightRolesInfoNotify._repeated_playersFightRoles_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BF1E RID: 114462 RVA: 0x00409FCC File Offset: 0x004081CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.playersFightRoles_.CalculateSize(UpdatePlayersFightRolesInfoNotify._repeated_playersFightRoles_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BF1F RID: 114463 RVA: 0x0040A005 File Offset: 0x00408205
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdatePlayersFightRolesInfoNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.playersFightRoles_.Add(other.playersFightRoles_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BF20 RID: 114464 RVA: 0x0040A033 File Offset: 0x00408233
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BF21 RID: 114465 RVA: 0x0040A03C File Offset: 0x0040823C
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
				if (num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.playersFightRoles_.AddEntriesFrom(ref input, UpdatePlayersFightRolesInfoNotify._repeated_playersFightRoles_codec);
				}
			}
		}

		// Token: 0x0400A08B RID: 41099
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A08C RID: 41100
		public const int PlayersFightRolesFieldNumber = 11;

		// Token: 0x0400A08D RID: 41101
		private static readonly FieldCodec<PlayerFightRolesInfo> _repeated_playersFightRoles_codec = FieldCodec.ForMessage<PlayerFightRolesInfo>(90U, PlayerFightRolesInfo.Parser);

		// Token: 0x0400A08E RID: 41102
		private readonly RepeatedField<PlayerFightRolesInfo> playersFightRoles_ = new RepeatedField<PlayerFightRolesInfo>();
	}
}
