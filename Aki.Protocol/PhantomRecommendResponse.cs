using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CF7 RID: 3319
	[NetMessage(EMessageId.PhantomRecommendResponse)]
	public sealed class PhantomRecommendResponse : IMessage<PhantomRecommendResponse>, IMessage, IEquatable<PhantomRecommendResponse>, IDeepCloneable<PhantomRecommendResponse>, IBufferMessage
	{
		// Token: 0x06011F24 RID: 73508 RVA: 0x0029FD89 File Offset: 0x0029DF89
		[NullableContext(1)]
		public static PhantomRecommendResponse Create()
		{
			return new PhantomRecommendResponse();
		}

		// Token: 0x17003B78 RID: 15224
		// (get) Token: 0x06011F25 RID: 73509 RVA: 0x0029FD90 File Offset: 0x0029DF90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B79 RID: 15225
		// (get) Token: 0x06011F26 RID: 73510 RVA: 0x0029FD93 File Offset: 0x0029DF93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomRecommendResponse.Descriptor;
			}
		}

		// Token: 0x06011F27 RID: 73511 RVA: 0x0029FD9A File Offset: 0x0029DF9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRecommendResponse()
		{
		}

		// Token: 0x06011F28 RID: 73512 RVA: 0x0029FDB0 File Offset: 0x0029DFB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRecommendResponse(PhantomRecommendResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.roleId_ = other.roleId_;
			this.monsterIdList_ = other.monsterIdList_.Clone();
			this.mainPropId_ = other.mainPropId_;
			this.fetterGroupId_ = other.fetterGroupId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011F29 RID: 73513 RVA: 0x0029FE15 File Offset: 0x0029E015
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRecommendResponse Clone()
		{
			return new PhantomRecommendResponse(this);
		}

		// Token: 0x17003B7A RID: 15226
		// (get) Token: 0x06011F2A RID: 73514 RVA: 0x0029FE1D File Offset: 0x0029E01D
		// (set) Token: 0x06011F2B RID: 73515 RVA: 0x0029FE25 File Offset: 0x0029E025
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

		// Token: 0x17003B7B RID: 15227
		// (get) Token: 0x06011F2C RID: 73516 RVA: 0x0029FE2E File Offset: 0x0029E02E
		// (set) Token: 0x06011F2D RID: 73517 RVA: 0x0029FE36 File Offset: 0x0029E036
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x17003B7C RID: 15228
		// (get) Token: 0x06011F2E RID: 73518 RVA: 0x0029FE3F File Offset: 0x0029E03F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MonsterIdList
		{
			get
			{
				return this.monsterIdList_;
			}
		}

		// Token: 0x17003B7D RID: 15229
		// (get) Token: 0x06011F2F RID: 73519 RVA: 0x0029FE47 File Offset: 0x0029E047
		// (set) Token: 0x06011F30 RID: 73520 RVA: 0x0029FE4F File Offset: 0x0029E04F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MainPropId
		{
			get
			{
				return this.mainPropId_;
			}
			set
			{
				this.mainPropId_ = value;
			}
		}

		// Token: 0x17003B7E RID: 15230
		// (get) Token: 0x06011F31 RID: 73521 RVA: 0x0029FE58 File Offset: 0x0029E058
		// (set) Token: 0x06011F32 RID: 73522 RVA: 0x0029FE60 File Offset: 0x0029E060
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FetterGroupId
		{
			get
			{
				return this.fetterGroupId_;
			}
			set
			{
				this.fetterGroupId_ = value;
			}
		}

		// Token: 0x06011F33 RID: 73523 RVA: 0x0029FE69 File Offset: 0x0029E069
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomRecommendResponse);
		}

		// Token: 0x06011F34 RID: 73524 RVA: 0x0029FE78 File Offset: 0x0029E078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomRecommendResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.RoleId == other.RoleId && this.monsterIdList_.Equals(other.monsterIdList_) && this.MainPropId == other.MainPropId && this.FetterGroupId == other.FetterGroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011F35 RID: 73525 RVA: 0x0029FEF8 File Offset: 0x0029E0F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			num ^= this.monsterIdList_.GetHashCode();
			if (this.MainPropId != 0)
			{
				num ^= this.MainPropId.GetHashCode();
			}
			if (this.FetterGroupId != 0)
			{
				num ^= this.FetterGroupId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011F36 RID: 73526 RVA: 0x0029FF96 File Offset: 0x0029E196
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011F37 RID: 73527 RVA: 0x0029FFA3 File Offset: 0x0029E1A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011F38 RID: 73528 RVA: 0x0029FFAC File Offset: 0x0029E1AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.MainPropId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.MainPropId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RoleId);
			}
			if (this.FetterGroupId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.FetterGroupId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.monsterIdList_.WriteTo(ref output, PhantomRecommendResponse._repeated_monsterIdList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011F39 RID: 73529 RVA: 0x002A0050 File Offset: 0x0029E250
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			num += this.monsterIdList_.CalculateSize(PhantomRecommendResponse._repeated_monsterIdList_codec);
			if (this.MainPropId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MainPropId);
			}
			if (this.FetterGroupId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FetterGroupId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011F3A RID: 73530 RVA: 0x002A00EC File Offset: 0x0029E2EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomRecommendResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this.monsterIdList_.Add(other.monsterIdList_);
			if (other.MainPropId != 0)
			{
				this.MainPropId = other.MainPropId;
			}
			if (other.FetterGroupId != 0)
			{
				this.FetterGroupId = other.FetterGroupId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011F3B RID: 73531 RVA: 0x002A0175 File Offset: 0x0029E375
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011F3C RID: 73532 RVA: 0x002A0180 File Offset: 0x0029E380
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
				if (num <= 88U)
				{
					if (num == 40U)
					{
						this.MainPropId = input.ReadInt32();
						continue;
					}
					if (num == 56U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 88U)
					{
						this.FetterGroupId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 96U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 120U || num == 122U)
					{
						this.monsterIdList_.AddEntriesFrom(ref input, PhantomRecommendResponse._repeated_monsterIdList_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007082 RID: 28802
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007083 RID: 28803
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04007084 RID: 28804
		private ErrorCode errorCode_;

		// Token: 0x04007085 RID: 28805
		public const int RoleIdFieldNumber = 7;

		// Token: 0x04007086 RID: 28806
		private int roleId_;

		// Token: 0x04007087 RID: 28807
		public const int MonsterIdListFieldNumber = 15;

		// Token: 0x04007088 RID: 28808
		private static readonly FieldCodec<int> _repeated_monsterIdList_codec = FieldCodec.ForInt32(122U);

		// Token: 0x04007089 RID: 28809
		private readonly RepeatedField<int> monsterIdList_ = new RepeatedField<int>();

		// Token: 0x0400708A RID: 28810
		public const int MainPropIdFieldNumber = 5;

		// Token: 0x0400708B RID: 28811
		private int mainPropId_;

		// Token: 0x0400708C RID: 28812
		public const int FetterGroupIdFieldNumber = 11;

		// Token: 0x0400708D RID: 28813
		private int fetterGroupId_;
	}
}
