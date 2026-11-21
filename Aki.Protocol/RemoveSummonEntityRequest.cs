using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000EFA RID: 3834
	[NetMessage(EMessageId.RemoveSummonEntityRequest)]
	public sealed class RemoveSummonEntityRequest : IMessage<RemoveSummonEntityRequest>, IMessage, IEquatable<RemoveSummonEntityRequest>, IDeepCloneable<RemoveSummonEntityRequest>, IBufferMessage
	{
		// Token: 0x060148FD RID: 84221 RVA: 0x002FCFF9 File Offset: 0x002FB1F9
		[NullableContext(1)]
		public static RemoveSummonEntityRequest Create()
		{
			return new RemoveSummonEntityRequest();
		}

		// Token: 0x17004462 RID: 17506
		// (get) Token: 0x060148FE RID: 84222 RVA: 0x002FD000 File Offset: 0x002FB200
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004463 RID: 17507
		// (get) Token: 0x060148FF RID: 84223 RVA: 0x002FD003 File Offset: 0x002FB203
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RemoveSummonEntityRequest.Descriptor;
			}
		}

		// Token: 0x06014900 RID: 84224 RVA: 0x002FD00A File Offset: 0x002FB20A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveSummonEntityRequest()
		{
		}

		// Token: 0x06014901 RID: 84225 RVA: 0x002FD020 File Offset: 0x002FB220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveSummonEntityRequest(RemoveSummonEntityRequest other) : this()
		{
			this.summonerId_ = other.summonerId_;
			this.skillId_ = other.skillId_;
			this.removeType_ = other.removeType_;
			this.removeEntityIds_ = other.removeEntityIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014902 RID: 84226 RVA: 0x002FD079 File Offset: 0x002FB279
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RemoveSummonEntityRequest Clone()
		{
			return new RemoveSummonEntityRequest(this);
		}

		// Token: 0x17004464 RID: 17508
		// (get) Token: 0x06014903 RID: 84227 RVA: 0x002FD081 File Offset: 0x002FB281
		// (set) Token: 0x06014904 RID: 84228 RVA: 0x002FD089 File Offset: 0x002FB289
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long SummonerId
		{
			get
			{
				return this.summonerId_;
			}
			set
			{
				this.summonerId_ = value;
			}
		}

		// Token: 0x17004465 RID: 17509
		// (get) Token: 0x06014905 RID: 84229 RVA: 0x002FD092 File Offset: 0x002FB292
		// (set) Token: 0x06014906 RID: 84230 RVA: 0x002FD09A File Offset: 0x002FB29A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SkillId
		{
			get
			{
				return this.skillId_;
			}
			set
			{
				this.skillId_ = value;
			}
		}

		// Token: 0x17004466 RID: 17510
		// (get) Token: 0x06014907 RID: 84231 RVA: 0x002FD0A3 File Offset: 0x002FB2A3
		// (set) Token: 0x06014908 RID: 84232 RVA: 0x002FD0AB File Offset: 0x002FB2AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ERemoveEntityType RemoveType
		{
			get
			{
				return this.removeType_;
			}
			set
			{
				this.removeType_ = value;
			}
		}

		// Token: 0x17004467 RID: 17511
		// (get) Token: 0x06014909 RID: 84233 RVA: 0x002FD0B4 File Offset: 0x002FB2B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<long> RemoveEntityIds
		{
			get
			{
				return this.removeEntityIds_;
			}
		}

		// Token: 0x0601490A RID: 84234 RVA: 0x002FD0BC File Offset: 0x002FB2BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RemoveSummonEntityRequest);
		}

		// Token: 0x0601490B RID: 84235 RVA: 0x002FD0CC File Offset: 0x002FB2CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RemoveSummonEntityRequest other)
		{
			return other != null && (other == this || (this.SummonerId == other.SummonerId && this.SkillId == other.SkillId && this.RemoveType == other.RemoveType && this.removeEntityIds_.Equals(other.removeEntityIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601490C RID: 84236 RVA: 0x002FD13C File Offset: 0x002FB33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SummonerId != 0L)
			{
				num ^= this.SummonerId.GetHashCode();
			}
			if (this.SkillId != 0)
			{
				num ^= this.SkillId.GetHashCode();
			}
			if (this.RemoveType != ERemoveEntityType.RemoveTypeForce)
			{
				num ^= this.RemoveType.GetHashCode();
			}
			num ^= this.removeEntityIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601490D RID: 84237 RVA: 0x002FD1C1 File Offset: 0x002FB3C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601490E RID: 84238 RVA: 0x002FD1CE File Offset: 0x002FB3CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601490F RID: 84239 RVA: 0x002FD1D8 File Offset: 0x002FB3D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SummonerId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(this.SummonerId);
			}
			if (this.SkillId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SkillId);
			}
			if (this.RemoveType != ERemoveEntityType.RemoveTypeForce)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.RemoveType);
			}
			this.removeEntityIds_.WriteTo(ref output, RemoveSummonEntityRequest._repeated_removeEntityIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014910 RID: 84240 RVA: 0x002FD260 File Offset: 0x002FB460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SummonerId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.SummonerId);
			}
			if (this.SkillId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SkillId);
			}
			if (this.RemoveType != ERemoveEntityType.RemoveTypeForce)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.RemoveType);
			}
			num += this.removeEntityIds_.CalculateSize(RemoveSummonEntityRequest._repeated_removeEntityIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014911 RID: 84241 RVA: 0x002FD2E4 File Offset: 0x002FB4E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RemoveSummonEntityRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SummonerId != 0L)
			{
				this.SummonerId = other.SummonerId;
			}
			if (other.SkillId != 0)
			{
				this.SkillId = other.SkillId;
			}
			if (other.RemoveType != ERemoveEntityType.RemoveTypeForce)
			{
				this.RemoveType = other.RemoveType;
			}
			this.removeEntityIds_.Add(other.removeEntityIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014912 RID: 84242 RVA: 0x002FD359 File Offset: 0x002FB559
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014913 RID: 84243 RVA: 0x002FD364 File Offset: 0x002FB564
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
				if (num <= 40U)
				{
					if (num == 8U)
					{
						this.SummonerId = input.ReadInt64();
						continue;
					}
					if (num == 40U)
					{
						this.SkillId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 48U)
					{
						this.RemoveType = (ERemoveEntityType)input.ReadEnum();
						continue;
					}
					if (num == 120U || num == 122U)
					{
						this.removeEntityIds_.AddEntriesFrom(ref input, RemoveSummonEntityRequest._repeated_removeEntityIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007CF4 RID: 31988
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007CF5 RID: 31989
		public const int SummonerIdFieldNumber = 1;

		// Token: 0x04007CF6 RID: 31990
		private long summonerId_;

		// Token: 0x04007CF7 RID: 31991
		public const int SkillIdFieldNumber = 5;

		// Token: 0x04007CF8 RID: 31992
		private int skillId_;

		// Token: 0x04007CF9 RID: 31993
		public const int RemoveTypeFieldNumber = 6;

		// Token: 0x04007CFA RID: 31994
		private ERemoveEntityType removeType_;

		// Token: 0x04007CFB RID: 31995
		public const int RemoveEntityIdsFieldNumber = 15;

		// Token: 0x04007CFC RID: 31996
		private static readonly FieldCodec<long> _repeated_removeEntityIds_codec = FieldCodec.ForInt64(122U);

		// Token: 0x04007CFD RID: 31997
		private readonly RepeatedField<long> removeEntityIds_ = new RepeatedField<long>();
	}
}
