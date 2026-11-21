using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CE7 RID: 3303
	[NetMessage(EMessageId.PhantomRecommendResponse)]
	public sealed class PhantomRecommendResponse : IMessage<PhantomRecommendResponse>, IMessage, IEquatable<PhantomRecommendResponse>, IDeepCloneable<PhantomRecommendResponse>, IBufferMessage
	{
		// Token: 0x06011E28 RID: 73256 RVA: 0x0029E171 File Offset: 0x0029C371
		[NullableContext(1)]
		public static PhantomRecommendResponse Create()
		{
			return new PhantomRecommendResponse();
		}

		// Token: 0x17003B43 RID: 15171
		// (get) Token: 0x06011E29 RID: 73257 RVA: 0x0029E178 File Offset: 0x0029C378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003B44 RID: 15172
		// (get) Token: 0x06011E2A RID: 73258 RVA: 0x0029E17B File Offset: 0x0029C37B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomRecommendResponse.Descriptor;
			}
		}

		// Token: 0x06011E2B RID: 73259 RVA: 0x0029E182 File Offset: 0x0029C382
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRecommendResponse()
		{
		}

		// Token: 0x06011E2C RID: 73260 RVA: 0x0029E198 File Offset: 0x0029C398
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

		// Token: 0x06011E2D RID: 73261 RVA: 0x0029E1FD File Offset: 0x0029C3FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomRecommendResponse Clone()
		{
			return new PhantomRecommendResponse(this);
		}

		// Token: 0x17003B45 RID: 15173
		// (get) Token: 0x06011E2E RID: 73262 RVA: 0x0029E205 File Offset: 0x0029C405
		// (set) Token: 0x06011E2F RID: 73263 RVA: 0x0029E20D File Offset: 0x0029C40D
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

		// Token: 0x17003B46 RID: 15174
		// (get) Token: 0x06011E30 RID: 73264 RVA: 0x0029E216 File Offset: 0x0029C416
		// (set) Token: 0x06011E31 RID: 73265 RVA: 0x0029E21E File Offset: 0x0029C41E
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

		// Token: 0x17003B47 RID: 15175
		// (get) Token: 0x06011E32 RID: 73266 RVA: 0x0029E227 File Offset: 0x0029C427
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> MonsterIdList
		{
			get
			{
				return this.monsterIdList_;
			}
		}

		// Token: 0x17003B48 RID: 15176
		// (get) Token: 0x06011E33 RID: 73267 RVA: 0x0029E22F File Offset: 0x0029C42F
		// (set) Token: 0x06011E34 RID: 73268 RVA: 0x0029E237 File Offset: 0x0029C437
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

		// Token: 0x17003B49 RID: 15177
		// (get) Token: 0x06011E35 RID: 73269 RVA: 0x0029E240 File Offset: 0x0029C440
		// (set) Token: 0x06011E36 RID: 73270 RVA: 0x0029E248 File Offset: 0x0029C448
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

		// Token: 0x06011E37 RID: 73271 RVA: 0x0029E251 File Offset: 0x0029C451
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomRecommendResponse);
		}

		// Token: 0x06011E38 RID: 73272 RVA: 0x0029E260 File Offset: 0x0029C460
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomRecommendResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.RoleId == other.RoleId && this.monsterIdList_.Equals(other.monsterIdList_) && this.MainPropId == other.MainPropId && this.FetterGroupId == other.FetterGroupId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011E39 RID: 73273 RVA: 0x0029E2E0 File Offset: 0x0029C4E0
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

		// Token: 0x06011E3A RID: 73274 RVA: 0x0029E37E File Offset: 0x0029C57E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011E3B RID: 73275 RVA: 0x0029E38B File Offset: 0x0029C58B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011E3C RID: 73276 RVA: 0x0029E394 File Offset: 0x0029C594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.FetterGroupId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.FetterGroupId);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RoleId);
			}
			this.monsterIdList_.WriteTo(ref output, PhantomRecommendResponse._repeated_monsterIdList_codec);
			if (this.MainPropId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.MainPropId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011E3D RID: 73277 RVA: 0x0029E438 File Offset: 0x0029C638
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

		// Token: 0x06011E3E RID: 73278 RVA: 0x0029E4D4 File Offset: 0x0029C6D4
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

		// Token: 0x06011E3F RID: 73279 RVA: 0x0029E55D File Offset: 0x0029C75D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011E40 RID: 73280 RVA: 0x0029E568 File Offset: 0x0029C768
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
				if (num <= 64U)
				{
					if (num == 32U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 48U)
					{
						this.FetterGroupId = input.ReadInt32();
						continue;
					}
					if (num == 64U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 72U || num == 74U)
					{
						this.monsterIdList_.AddEntriesFrom(ref input, PhantomRecommendResponse._repeated_monsterIdList_codec);
						continue;
					}
					if (num == 120U)
					{
						this.MainPropId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400709A RID: 28826
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400709B RID: 28827
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x0400709C RID: 28828
		private ErrorCode errorCode_;

		// Token: 0x0400709D RID: 28829
		public const int RoleIdFieldNumber = 8;

		// Token: 0x0400709E RID: 28830
		private int roleId_;

		// Token: 0x0400709F RID: 28831
		public const int MonsterIdListFieldNumber = 9;

		// Token: 0x040070A0 RID: 28832
		private static readonly FieldCodec<int> _repeated_monsterIdList_codec = FieldCodec.ForInt32(74U);

		// Token: 0x040070A1 RID: 28833
		private readonly RepeatedField<int> monsterIdList_ = new RepeatedField<int>();

		// Token: 0x040070A2 RID: 28834
		public const int MainPropIdFieldNumber = 15;

		// Token: 0x040070A3 RID: 28835
		private int mainPropId_;

		// Token: 0x040070A4 RID: 28836
		public const int FetterGroupIdFieldNumber = 6;

		// Token: 0x040070A5 RID: 28837
		private int fetterGroupId_;
	}
}
