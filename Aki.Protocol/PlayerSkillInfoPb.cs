using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D9F RID: 3487
	public sealed class PlayerSkillInfoPb : IMessage<PlayerSkillInfoPb>, IMessage, IEquatable<PlayerSkillInfoPb>, IDeepCloneable<PlayerSkillInfoPb>, IBufferMessage
	{
		// Token: 0x06012D0C RID: 77068 RVA: 0x002BF456 File Offset: 0x002BD656
		[NullableContext(1)]
		public static PlayerSkillInfoPb Create()
		{
			return new PlayerSkillInfoPb();
		}

		// Token: 0x17003E75 RID: 15989
		// (get) Token: 0x06012D0D RID: 77069 RVA: 0x002BF45D File Offset: 0x002BD65D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003E76 RID: 15990
		// (get) Token: 0x06012D0E RID: 77070 RVA: 0x002BF460 File Offset: 0x002BD660
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerSkillInfoPb.Descriptor;
			}
		}

		// Token: 0x06012D0F RID: 77071 RVA: 0x002BF467 File Offset: 0x002BD667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSkillInfoPb()
		{
		}

		// Token: 0x06012D10 RID: 77072 RVA: 0x002BF47C File Offset: 0x002BD67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSkillInfoPb(PlayerSkillInfoPb other) : this()
		{
			this.roleCommonSkillInfoPb_ = ((other.roleCommonSkillInfoPb_ != null) ? other.roleCommonSkillInfoPb_.Clone() : null);
			this.roleSkillInfoPbList_ = other.roleSkillInfoPbList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012D11 RID: 77073 RVA: 0x002BF4CD File Offset: 0x002BD6CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSkillInfoPb Clone()
		{
			return new PlayerSkillInfoPb(this);
		}

		// Token: 0x17003E77 RID: 15991
		// (get) Token: 0x06012D12 RID: 77074 RVA: 0x002BF4D5 File Offset: 0x002BD6D5
		// (set) Token: 0x06012D13 RID: 77075 RVA: 0x002BF4DD File Offset: 0x002BD6DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SkillInfoPb RoleCommonSkillInfoPb
		{
			get
			{
				return this.roleCommonSkillInfoPb_;
			}
			set
			{
				this.roleCommonSkillInfoPb_ = value;
			}
		}

		// Token: 0x17003E78 RID: 15992
		// (get) Token: 0x06012D14 RID: 77076 RVA: 0x002BF4E6 File Offset: 0x002BD6E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleSkillInfoPb> RoleSkillInfoPbList
		{
			get
			{
				return this.roleSkillInfoPbList_;
			}
		}

		// Token: 0x06012D15 RID: 77077 RVA: 0x002BF4EE File Offset: 0x002BD6EE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerSkillInfoPb);
		}

		// Token: 0x06012D16 RID: 77078 RVA: 0x002BF4FC File Offset: 0x002BD6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerSkillInfoPb other)
		{
			return other != null && (other == this || (object.Equals(this.RoleCommonSkillInfoPb, other.RoleCommonSkillInfoPb) && this.roleSkillInfoPbList_.Equals(other.roleSkillInfoPbList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012D17 RID: 77079 RVA: 0x002BF550 File Offset: 0x002BD750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.roleCommonSkillInfoPb_ != null)
			{
				num ^= this.RoleCommonSkillInfoPb.GetHashCode();
			}
			num ^= this.roleSkillInfoPbList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012D18 RID: 77080 RVA: 0x002BF59A File Offset: 0x002BD79A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012D19 RID: 77081 RVA: 0x002BF5A7 File Offset: 0x002BD7A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012D1A RID: 77082 RVA: 0x002BF5B0 File Offset: 0x002BD7B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roleCommonSkillInfoPb_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.RoleCommonSkillInfoPb);
			}
			this.roleSkillInfoPbList_.WriteTo(ref output, PlayerSkillInfoPb._repeated_roleSkillInfoPbList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012D1B RID: 77083 RVA: 0x002BF600 File Offset: 0x002BD800
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.roleCommonSkillInfoPb_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleCommonSkillInfoPb);
			}
			num += this.roleSkillInfoPbList_.CalculateSize(PlayerSkillInfoPb._repeated_roleSkillInfoPbList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06012D1C RID: 77084 RVA: 0x002BF654 File Offset: 0x002BD854
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PlayerSkillInfoPb other)
		{
			if (other == null)
			{
				return;
			}
			if (other.roleCommonSkillInfoPb_ != null)
			{
				if (this.roleCommonSkillInfoPb_ == null)
				{
					this.RoleCommonSkillInfoPb = new SkillInfoPb();
				}
				this.RoleCommonSkillInfoPb.MergeFrom(other.RoleCommonSkillInfoPb);
			}
			this.roleSkillInfoPbList_.Add(other.roleSkillInfoPbList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06012D1D RID: 77085 RVA: 0x002BF6B9 File Offset: 0x002BD8B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012D1E RID: 77086 RVA: 0x002BF6C4 File Offset: 0x002BD8C4
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
				if (num != 10U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.roleSkillInfoPbList_.AddEntriesFrom(ref input, PlayerSkillInfoPb._repeated_roleSkillInfoPbList_codec);
					}
				}
				else
				{
					if (this.roleCommonSkillInfoPb_ == null)
					{
						this.RoleCommonSkillInfoPb = new SkillInfoPb();
					}
					input.ReadMessage(this.RoleCommonSkillInfoPb);
				}
			}
		}

		// Token: 0x040074F6 RID: 29942
		private UnknownFieldSet _unknownFields;

		// Token: 0x040074F7 RID: 29943
		public const int RoleCommonSkillInfoPbFieldNumber = 1;

		// Token: 0x040074F8 RID: 29944
		private SkillInfoPb roleCommonSkillInfoPb_;

		// Token: 0x040074F9 RID: 29945
		public const int RoleSkillInfoPbListFieldNumber = 2;

		// Token: 0x040074FA RID: 29946
		private static readonly FieldCodec<RoleSkillInfoPb> _repeated_roleSkillInfoPbList_codec = FieldCodec.ForMessage<RoleSkillInfoPb>(18U, RoleSkillInfoPb.Parser);

		// Token: 0x040074FB RID: 29947
		private readonly RepeatedField<RoleSkillInfoPb> roleSkillInfoPbList_ = new RepeatedField<RoleSkillInfoPb>();
	}
}
