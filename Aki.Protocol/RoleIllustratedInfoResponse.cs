using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001087 RID: 4231
	[NetMessage(EMessageId.RoleIllustratedInfoResponse)]
	public sealed class RoleIllustratedInfoResponse : IMessage<RoleIllustratedInfoResponse>, IMessage, IEquatable<RoleIllustratedInfoResponse>, IDeepCloneable<RoleIllustratedInfoResponse>, IBufferMessage
	{
		// Token: 0x0601698E RID: 92558 RVA: 0x003486EE File Offset: 0x003468EE
		[NullableContext(1)]
		public static RoleIllustratedInfoResponse Create()
		{
			return new RoleIllustratedInfoResponse();
		}

		// Token: 0x17004BA3 RID: 19363
		// (get) Token: 0x0601698F RID: 92559 RVA: 0x003486F5 File Offset: 0x003468F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BA4 RID: 19364
		// (get) Token: 0x06016990 RID: 92560 RVA: 0x003486F8 File Offset: 0x003468F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleIllustratedInfoResponse.Descriptor;
			}
		}

		// Token: 0x06016991 RID: 92561 RVA: 0x003486FF File Offset: 0x003468FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleIllustratedInfoResponse()
		{
		}

		// Token: 0x06016992 RID: 92562 RVA: 0x0034871D File Offset: 0x0034691D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleIllustratedInfoResponse(RoleIllustratedInfoResponse other) : this()
		{
			this.roleIllustratedInfos_ = other.roleIllustratedInfos_.Clone();
			this.weaponIllustratedInfos_ = other.weaponIllustratedInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016993 RID: 92563 RVA: 0x00348758 File Offset: 0x00346958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleIllustratedInfoResponse Clone()
		{
			return new RoleIllustratedInfoResponse(this);
		}

		// Token: 0x17004BA5 RID: 19365
		// (get) Token: 0x06016994 RID: 92564 RVA: 0x00348760 File Offset: 0x00346960
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleIllustratedInfo> RoleIllustratedInfos
		{
			get
			{
				return this.roleIllustratedInfos_;
			}
		}

		// Token: 0x17004BA6 RID: 19366
		// (get) Token: 0x06016995 RID: 92565 RVA: 0x00348768 File Offset: 0x00346968
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<WeaponIllustratedInfo> WeaponIllustratedInfos
		{
			get
			{
				return this.weaponIllustratedInfos_;
			}
		}

		// Token: 0x06016996 RID: 92566 RVA: 0x00348770 File Offset: 0x00346970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleIllustratedInfoResponse);
		}

		// Token: 0x06016997 RID: 92567 RVA: 0x00348780 File Offset: 0x00346980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleIllustratedInfoResponse other)
		{
			return other != null && (other == this || (this.roleIllustratedInfos_.Equals(other.roleIllustratedInfos_) && this.weaponIllustratedInfos_.Equals(other.weaponIllustratedInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016998 RID: 92568 RVA: 0x003487D4 File Offset: 0x003469D4
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

		// Token: 0x06016999 RID: 92569 RVA: 0x00348816 File Offset: 0x00346A16
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601699A RID: 92570 RVA: 0x00348823 File Offset: 0x00346A23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601699B RID: 92571 RVA: 0x0034882C File Offset: 0x00346A2C
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

		// Token: 0x0601699C RID: 92572 RVA: 0x00348864 File Offset: 0x00346A64
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

		// Token: 0x0601699D RID: 92573 RVA: 0x003488B0 File Offset: 0x00346AB0
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

		// Token: 0x0601699E RID: 92574 RVA: 0x003488EF File Offset: 0x00346AEF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601699F RID: 92575 RVA: 0x003488F8 File Offset: 0x00346AF8
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
					if (num != 106U)
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

		// Token: 0x040086F0 RID: 34544
		private UnknownFieldSet _unknownFields;

		// Token: 0x040086F1 RID: 34545
		public const int RoleIllustratedInfosFieldNumber = 13;

		// Token: 0x040086F2 RID: 34546
		private static readonly FieldCodec<RoleIllustratedInfo> _repeated_roleIllustratedInfos_codec = FieldCodec.ForMessage<RoleIllustratedInfo>(106U, RoleIllustratedInfo.Parser);

		// Token: 0x040086F3 RID: 34547
		private readonly RepeatedField<RoleIllustratedInfo> roleIllustratedInfos_ = new RepeatedField<RoleIllustratedInfo>();

		// Token: 0x040086F4 RID: 34548
		public const int WeaponIllustratedInfosFieldNumber = 6;

		// Token: 0x040086F5 RID: 34549
		private static readonly FieldCodec<WeaponIllustratedInfo> _repeated_weaponIllustratedInfos_codec = FieldCodec.ForMessage<WeaponIllustratedInfo>(50U, WeaponIllustratedInfo.Parser);

		// Token: 0x040086F6 RID: 34550
		private readonly RepeatedField<WeaponIllustratedInfo> weaponIllustratedInfos_ = new RepeatedField<WeaponIllustratedInfo>();
	}
}
