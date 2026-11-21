using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000643 RID: 1603
	[NetMessage(EMessageId.FriendRecentlyTeamResponse)]
	public sealed class FriendRecentlyTeamResponse : IMessage<FriendRecentlyTeamResponse>, IMessage, IEquatable<FriendRecentlyTeamResponse>, IDeepCloneable<FriendRecentlyTeamResponse>, IBufferMessage
	{
		// Token: 0x060093C4 RID: 37828 RVA: 0x00165552 File Offset: 0x00163752
		[NullableContext(1)]
		public static FriendRecentlyTeamResponse Create()
		{
			return new FriendRecentlyTeamResponse();
		}

		// Token: 0x17001D61 RID: 7521
		// (get) Token: 0x060093C5 RID: 37829 RVA: 0x00165559 File Offset: 0x00163759
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D62 RID: 7522
		// (get) Token: 0x060093C6 RID: 37830 RVA: 0x0016555C File Offset: 0x0016375C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FriendRecentlyTeamResponse.Descriptor;
			}
		}

		// Token: 0x060093C7 RID: 37831 RVA: 0x00165563 File Offset: 0x00163763
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRecentlyTeamResponse()
		{
		}

		// Token: 0x060093C8 RID: 37832 RVA: 0x00165576 File Offset: 0x00163776
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRecentlyTeamResponse(FriendRecentlyTeamResponse other) : this()
		{
			this.infos_ = other.infos_.Clone();
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060093C9 RID: 37833 RVA: 0x001655AC File Offset: 0x001637AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FriendRecentlyTeamResponse Clone()
		{
			return new FriendRecentlyTeamResponse(this);
		}

		// Token: 0x17001D63 RID: 7523
		// (get) Token: 0x060093CA RID: 37834 RVA: 0x001655B4 File Offset: 0x001637B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RecentlyTeamInfo> Infos
		{
			get
			{
				return this.infos_;
			}
		}

		// Token: 0x17001D64 RID: 7524
		// (get) Token: 0x060093CB RID: 37835 RVA: 0x001655BC File Offset: 0x001637BC
		// (set) Token: 0x060093CC RID: 37836 RVA: 0x001655C4 File Offset: 0x001637C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x060093CD RID: 37837 RVA: 0x001655CD File Offset: 0x001637CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FriendRecentlyTeamResponse);
		}

		// Token: 0x060093CE RID: 37838 RVA: 0x001655DC File Offset: 0x001637DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FriendRecentlyTeamResponse other)
		{
			return other != null && (other == this || (this.infos_.Equals(other.infos_) && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060093CF RID: 37839 RVA: 0x0016562C File Offset: 0x0016382C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.infos_.GetHashCode();
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060093D0 RID: 37840 RVA: 0x0016567F File Offset: 0x0016387F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060093D1 RID: 37841 RVA: 0x0016568C File Offset: 0x0016388C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060093D2 RID: 37842 RVA: 0x00165698 File Offset: 0x00163898
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.infos_.WriteTo(ref output, FriendRecentlyTeamResponse._repeated_infos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060093D3 RID: 37843 RVA: 0x001656E8 File Offset: 0x001638E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.infos_.CalculateSize(FriendRecentlyTeamResponse._repeated_infos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060093D4 RID: 37844 RVA: 0x0016573C File Offset: 0x0016393C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FriendRecentlyTeamResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.infos_.Add(other.infos_);
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060093D5 RID: 37845 RVA: 0x00165789 File Offset: 0x00163989
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060093D6 RID: 37846 RVA: 0x00165794 File Offset: 0x00163994
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
				if (num != 50U)
				{
					if (num != 88U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.infos_.AddEntriesFrom(ref input, FriendRecentlyTeamResponse._repeated_infos_codec);
				}
			}
		}

		// Token: 0x04004742 RID: 18242
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004743 RID: 18243
		public const int InfosFieldNumber = 6;

		// Token: 0x04004744 RID: 18244
		private static readonly FieldCodec<RecentlyTeamInfo> _repeated_infos_codec = FieldCodec.ForMessage<RecentlyTeamInfo>(50U, RecentlyTeamInfo.Parser);

		// Token: 0x04004745 RID: 18245
		private readonly RepeatedField<RecentlyTeamInfo> infos_ = new RepeatedField<RecentlyTeamInfo>();

		// Token: 0x04004746 RID: 18246
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x04004747 RID: 18247
		private ErrorCode errorCode_;
	}
}
