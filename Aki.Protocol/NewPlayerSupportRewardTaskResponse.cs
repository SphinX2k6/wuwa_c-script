using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B22 RID: 2850
	[NetMessage(EMessageId.NewPlayerSupportRewardTaskResponse)]
	public sealed class NewPlayerSupportRewardTaskResponse : IMessage<NewPlayerSupportRewardTaskResponse>, IMessage, IEquatable<NewPlayerSupportRewardTaskResponse>, IDeepCloneable<NewPlayerSupportRewardTaskResponse>, IBufferMessage
	{
		// Token: 0x0600F770 RID: 63344 RVA: 0x00241585 File Offset: 0x0023F785
		[NullableContext(1)]
		public static NewPlayerSupportRewardTaskResponse Create()
		{
			return new NewPlayerSupportRewardTaskResponse();
		}

		// Token: 0x17003268 RID: 12904
		// (get) Token: 0x0600F771 RID: 63345 RVA: 0x0024158C File Offset: 0x0023F78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003269 RID: 12905
		// (get) Token: 0x0600F772 RID: 63346 RVA: 0x0024158F File Offset: 0x0023F78F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return NewPlayerSupportRewardTaskResponse.Descriptor;
			}
		}

		// Token: 0x0600F773 RID: 63347 RVA: 0x00241596 File Offset: 0x0023F796
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportRewardTaskResponse()
		{
		}

		// Token: 0x0600F774 RID: 63348 RVA: 0x002415A9 File Offset: 0x0023F7A9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportRewardTaskResponse(NewPlayerSupportRewardTaskResponse other) : this()
		{
			this.code_ = other.code_;
			this.roleId_ = other.roleId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F775 RID: 63349 RVA: 0x002415DF File Offset: 0x0023F7DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public NewPlayerSupportRewardTaskResponse Clone()
		{
			return new NewPlayerSupportRewardTaskResponse(this);
		}

		// Token: 0x1700326A RID: 12906
		// (get) Token: 0x0600F776 RID: 63350 RVA: 0x002415E7 File Offset: 0x0023F7E7
		// (set) Token: 0x0600F777 RID: 63351 RVA: 0x002415EF File Offset: 0x0023F7EF
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

		// Token: 0x1700326B RID: 12907
		// (get) Token: 0x0600F778 RID: 63352 RVA: 0x002415F8 File Offset: 0x0023F7F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> RoleId
		{
			get
			{
				return this.roleId_;
			}
		}

		// Token: 0x0600F779 RID: 63353 RVA: 0x00241600 File Offset: 0x0023F800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as NewPlayerSupportRewardTaskResponse);
		}

		// Token: 0x0600F77A RID: 63354 RVA: 0x00241610 File Offset: 0x0023F810
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(NewPlayerSupportRewardTaskResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.roleId_.Equals(other.roleId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F77B RID: 63355 RVA: 0x00241660 File Offset: 0x0023F860
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

		// Token: 0x0600F77C RID: 63356 RVA: 0x002416B3 File Offset: 0x0023F8B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F77D RID: 63357 RVA: 0x002416C0 File Offset: 0x0023F8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F77E RID: 63358 RVA: 0x002416CC File Offset: 0x0023F8CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.Code);
			}
			this.roleId_.WriteTo(ref output, NewPlayerSupportRewardTaskResponse._repeated_roleId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F77F RID: 63359 RVA: 0x0024171C File Offset: 0x0023F91C
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

		// Token: 0x0600F780 RID: 63360 RVA: 0x00241770 File Offset: 0x0023F970
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

		// Token: 0x0600F781 RID: 63361 RVA: 0x002417BD File Offset: 0x0023F9BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F782 RID: 63362 RVA: 0x002417C8 File Offset: 0x0023F9C8
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
					if (num != 104U && num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.roleId_.AddEntriesFrom(ref input, NewPlayerSupportRewardTaskResponse._repeated_roleId_codec);
					}
				}
				else
				{
					this.Code = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x0400634C RID: 25420
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400634D RID: 25421
		public const int CodeFieldNumber = 4;

		// Token: 0x0400634E RID: 25422
		private ErrorCode code_;

		// Token: 0x0400634F RID: 25423
		public const int RoleIdFieldNumber = 13;

		// Token: 0x04006350 RID: 25424
		private static readonly FieldCodec<int> _repeated_roleId_codec = FieldCodec.ForInt32(106U);

		// Token: 0x04006351 RID: 25425
		private readonly RepeatedField<int> roleId_ = new RepeatedField<int>();
	}
}
