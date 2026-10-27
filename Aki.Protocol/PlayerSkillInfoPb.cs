using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000DAF RID: 3503
	public sealed class PlayerSkillInfoPb : IMessage<PlayerSkillInfoPb>, IMessage, IEquatable<PlayerSkillInfoPb>, IDeepCloneable<PlayerSkillInfoPb>, IBufferMessage
	{
		// Token: 0x06012E08 RID: 77320 RVA: 0x002C107A File Offset: 0x002BF27A
		[NullableContext(1)]
		public static PlayerSkillInfoPb Create()
		{
			return new PlayerSkillInfoPb();
		}

		// Token: 0x17003EAA RID: 16042
		// (get) Token: 0x06012E09 RID: 77321 RVA: 0x002C1081 File Offset: 0x002BF281
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003EAB RID: 16043
		// (get) Token: 0x06012E0A RID: 77322 RVA: 0x002C1084 File Offset: 0x002BF284
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PlayerSkillInfoPb.Descriptor;
			}
		}

		// Token: 0x06012E0B RID: 77323 RVA: 0x002C108B File Offset: 0x002BF28B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSkillInfoPb()
		{
		}

		// Token: 0x06012E0C RID: 77324 RVA: 0x002C10A0 File Offset: 0x002BF2A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSkillInfoPb(PlayerSkillInfoPb other) : this()
		{
			this.roleCommonSkillInfoPb_ = ((other.roleCommonSkillInfoPb_ != null) ? other.roleCommonSkillInfoPb_.Clone() : null);
			this.roleSkillInfoPbList_ = other.roleSkillInfoPbList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012E0D RID: 77325 RVA: 0x002C10F1 File Offset: 0x002BF2F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PlayerSkillInfoPb Clone()
		{
			return new PlayerSkillInfoPb(this);
		}

		// Token: 0x17003EAC RID: 16044
		// (get) Token: 0x06012E0E RID: 77326 RVA: 0x002C10F9 File Offset: 0x002BF2F9
		// (set) Token: 0x06012E0F RID: 77327 RVA: 0x002C1101 File Offset: 0x002BF301
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

		// Token: 0x17003EAD RID: 16045
		// (get) Token: 0x06012E10 RID: 77328 RVA: 0x002C110A File Offset: 0x002BF30A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleSkillInfoPb> RoleSkillInfoPbList
		{
			get
			{
				return this.roleSkillInfoPbList_;
			}
		}

		// Token: 0x06012E11 RID: 77329 RVA: 0x002C1112 File Offset: 0x002BF312
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PlayerSkillInfoPb);
		}

		// Token: 0x06012E12 RID: 77330 RVA: 0x002C1120 File Offset: 0x002BF320
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PlayerSkillInfoPb other)
		{
			return other != null && (other == this || (object.Equals(this.RoleCommonSkillInfoPb, other.RoleCommonSkillInfoPb) && this.roleSkillInfoPbList_.Equals(other.roleSkillInfoPbList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012E13 RID: 77331 RVA: 0x002C1174 File Offset: 0x002BF374
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

		// Token: 0x06012E14 RID: 77332 RVA: 0x002C11BE File Offset: 0x002BF3BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012E15 RID: 77333 RVA: 0x002C11CB File Offset: 0x002BF3CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012E16 RID: 77334 RVA: 0x002C11D4 File Offset: 0x002BF3D4
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

		// Token: 0x06012E17 RID: 77335 RVA: 0x002C1224 File Offset: 0x002BF424
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

		// Token: 0x06012E18 RID: 77336 RVA: 0x002C1278 File Offset: 0x002BF478
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

		// Token: 0x06012E19 RID: 77337 RVA: 0x002C12DD File Offset: 0x002BF4DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012E1A RID: 77338 RVA: 0x002C12E8 File Offset: 0x002BF4E8
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

		// Token: 0x040074DE RID: 29918
		private UnknownFieldSet _unknownFields;

		// Token: 0x040074DF RID: 29919
		public const int RoleCommonSkillInfoPbFieldNumber = 1;

		// Token: 0x040074E0 RID: 29920
		private SkillInfoPb roleCommonSkillInfoPb_;

		// Token: 0x040074E1 RID: 29921
		public const int RoleSkillInfoPbListFieldNumber = 2;

		// Token: 0x040074E2 RID: 29922
		private static readonly FieldCodec<RoleSkillInfoPb> _repeated_roleSkillInfoPbList_codec = FieldCodec.ForMessage<RoleSkillInfoPb>(18U, RoleSkillInfoPb.Parser);

		// Token: 0x040074E3 RID: 29923
		private readonly RepeatedField<RoleSkillInfoPb> roleSkillInfoPbList_ = new RepeatedField<RoleSkillInfoPb>();
	}
}
