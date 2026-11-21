using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001077 RID: 4215
	[NetMessage(EMessageId.RoleIllustratedInfoResponse)]
	public sealed class RoleIllustratedInfoResponse : IMessage<RoleIllustratedInfoResponse>, IMessage, IEquatable<RoleIllustratedInfoResponse>, IDeepCloneable<RoleIllustratedInfoResponse>, IBufferMessage
	{
		// Token: 0x060168A9 RID: 92329 RVA: 0x00347016 File Offset: 0x00345216
		[NullableContext(1)]
		public static RoleIllustratedInfoResponse Create()
		{
			return new RoleIllustratedInfoResponse();
		}

		// Token: 0x17004B79 RID: 19321
		// (get) Token: 0x060168AA RID: 92330 RVA: 0x0034701D File Offset: 0x0034521D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004B7A RID: 19322
		// (get) Token: 0x060168AB RID: 92331 RVA: 0x00347020 File Offset: 0x00345220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleIllustratedInfoResponse.Descriptor;
			}
		}

		// Token: 0x060168AC RID: 92332 RVA: 0x00347027 File Offset: 0x00345227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleIllustratedInfoResponse()
		{
		}

		// Token: 0x060168AD RID: 92333 RVA: 0x00347045 File Offset: 0x00345245
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleIllustratedInfoResponse(RoleIllustratedInfoResponse other) : this()
		{
			this.roleIllustratedInfos_ = other.roleIllustratedInfos_.Clone();
			this.weaponIllustratedInfos_ = other.weaponIllustratedInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060168AE RID: 92334 RVA: 0x00347080 File Offset: 0x00345280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleIllustratedInfoResponse Clone()
		{
			return new RoleIllustratedInfoResponse(this);
		}

		// Token: 0x17004B7B RID: 19323
		// (get) Token: 0x060168AF RID: 92335 RVA: 0x00347088 File Offset: 0x00345288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleIllustratedInfo> RoleIllustratedInfos
		{
			get
			{
				return this.roleIllustratedInfos_;
			}
		}

		// Token: 0x17004B7C RID: 19324
		// (get) Token: 0x060168B0 RID: 92336 RVA: 0x00347090 File Offset: 0x00345290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WeaponIllustratedInfo> WeaponIllustratedInfos
		{
			get
			{
				return this.weaponIllustratedInfos_;
			}
		}

		// Token: 0x060168B1 RID: 92337 RVA: 0x00347098 File Offset: 0x00345298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleIllustratedInfoResponse);
		}

		// Token: 0x060168B2 RID: 92338 RVA: 0x003470A8 File Offset: 0x003452A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleIllustratedInfoResponse other)
		{
			return other != null && (other == this || (this.roleIllustratedInfos_.Equals(other.roleIllustratedInfos_) && this.weaponIllustratedInfos_.Equals(other.weaponIllustratedInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060168B3 RID: 92339 RVA: 0x003470FC File Offset: 0x003452FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.roleIllustratedInfos_.GetHashCode();
			num ^= this.weaponIllustratedInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060168B4 RID: 92340 RVA: 0x0034713E File Offset: 0x0034533E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060168B5 RID: 92341 RVA: 0x0034714B File Offset: 0x0034534B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060168B6 RID: 92342 RVA: 0x00347154 File Offset: 0x00345354
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.weaponIllustratedInfos_.WriteTo(ref output, RoleIllustratedInfoResponse._repeated_weaponIllustratedInfos_codec);
			this.roleIllustratedInfos_.WriteTo(ref output, RoleIllustratedInfoResponse._repeated_roleIllustratedInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060168B7 RID: 92343 RVA: 0x0034718C File Offset: 0x0034538C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.roleIllustratedInfos_.CalculateSize(RoleIllustratedInfoResponse._repeated_roleIllustratedInfos_codec);
			num += this.weaponIllustratedInfos_.CalculateSize(RoleIllustratedInfoResponse._repeated_weaponIllustratedInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060168B8 RID: 92344 RVA: 0x003471D8 File Offset: 0x003453D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleIllustratedInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.roleIllustratedInfos_.Add(other.roleIllustratedInfos_);
			this.weaponIllustratedInfos_.Add(other.weaponIllustratedInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060168B9 RID: 92345 RVA: 0x00347217 File Offset: 0x00345417
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060168BA RID: 92346 RVA: 0x00347220 File Offset: 0x00345420
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
				if (num != 26U)
				{
					if (num != 98U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.roleIllustratedInfos_.AddEntriesFrom(ref input, RoleIllustratedInfoResponse._repeated_roleIllustratedInfos_codec);
					}
				}
				else
				{
					this.weaponIllustratedInfos_.AddEntriesFrom(ref input, RoleIllustratedInfoResponse._repeated_weaponIllustratedInfos_codec);
				}
			}
		}

		// Token: 0x0400871A RID: 34586
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400871B RID: 34587
		public const int RoleIllustratedInfosFieldNumber = 12;

		// Token: 0x0400871C RID: 34588
		private static readonly FieldCodec<RoleIllustratedInfo> _repeated_roleIllustratedInfos_codec = FieldCodec.ForMessage<RoleIllustratedInfo>(98U, RoleIllustratedInfo.Parser);

		// Token: 0x0400871D RID: 34589
		private readonly RepeatedField<RoleIllustratedInfo> roleIllustratedInfos_ = new RepeatedField<RoleIllustratedInfo>();

		// Token: 0x0400871E RID: 34590
		public const int WeaponIllustratedInfosFieldNumber = 3;

		// Token: 0x0400871F RID: 34591
		private static readonly FieldCodec<WeaponIllustratedInfo> _repeated_weaponIllustratedInfos_codec = FieldCodec.ForMessage<WeaponIllustratedInfo>(26U, WeaponIllustratedInfo.Parser);

		// Token: 0x04008720 RID: 34592
		private readonly RepeatedField<WeaponIllustratedInfo> weaponIllustratedInfos_ = new RepeatedField<WeaponIllustratedInfo>();
	}
}
