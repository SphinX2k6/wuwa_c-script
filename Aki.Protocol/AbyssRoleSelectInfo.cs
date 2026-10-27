using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000046 RID: 70
	public sealed class AbyssRoleSelectInfo : IMessage<AbyssRoleSelectInfo>, IMessage, IEquatable<AbyssRoleSelectInfo>, IDeepCloneable<AbyssRoleSelectInfo>, IBufferMessage
	{
		// Token: 0x06001409 RID: 5129 RVA: 0x00035F55 File Offset: 0x00034155
		[NullableContext(1)]
		public static AbyssRoleSelectInfo Create()
		{
			return new AbyssRoleSelectInfo();
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600140A RID: 5130 RVA: 0x00035F5C File Offset: 0x0003415C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AbyssRoleSelectInfo> Parser
		{
			get
			{
				return AbyssRoleSelectInfo._parser;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600140B RID: 5131 RVA: 0x00035F63 File Offset: 0x00034163
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x00035F66 File Offset: 0x00034166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssRoleSelectInfo.Descriptor;
			}
		}

		// Token: 0x0600140D RID: 5133 RVA: 0x00035F6D File Offset: 0x0003416D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleSelectInfo()
		{
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x00035F80 File Offset: 0x00034180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleSelectInfo(AbyssRoleSelectInfo other) : this()
		{
			this.playerId_ = other.playerId_;
			this.roleInfos_ = other.roleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600140F RID: 5135 RVA: 0x00035FB6 File Offset: 0x000341B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssRoleSelectInfo Clone()
		{
			return new AbyssRoleSelectInfo(this);
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06001410 RID: 5136 RVA: 0x00035FBE File Offset: 0x000341BE
		// (set) Token: 0x06001411 RID: 5137 RVA: 0x00035FC6 File Offset: 0x000341C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06001412 RID: 5138 RVA: 0x00035FCF File Offset: 0x000341CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<AbyssOneRoleSelectInfo> RoleInfos
		{
			get
			{
				return this.roleInfos_;
			}
		}

		// Token: 0x06001413 RID: 5139 RVA: 0x00035FD7 File Offset: 0x000341D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssRoleSelectInfo);
		}

		// Token: 0x06001414 RID: 5140 RVA: 0x00035FE8 File Offset: 0x000341E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssRoleSelectInfo other)
		{
			return other != null && (other == this || (this.PlayerId == other.PlayerId && this.roleInfos_.Equals(other.roleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001415 RID: 5141 RVA: 0x00036038 File Offset: 0x00034238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			num ^= this.roleInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001416 RID: 5142 RVA: 0x00036085 File Offset: 0x00034285
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001417 RID: 5143 RVA: 0x00036092 File Offset: 0x00034292
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001418 RID: 5144 RVA: 0x0003609C File Offset: 0x0003429C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.PlayerId);
			}
			this.roleInfos_.WriteTo(ref output, AbyssRoleSelectInfo._repeated_roleInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001419 RID: 5145 RVA: 0x000360EC File Offset: 0x000342EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			num += this.roleInfos_.CalculateSize(AbyssRoleSelectInfo._repeated_roleInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600141A RID: 5146 RVA: 0x00036140 File Offset: 0x00034340
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssRoleSelectInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this.roleInfos_.Add(other.roleInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600141B RID: 5147 RVA: 0x0003618D File Offset: 0x0003438D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600141C RID: 5148 RVA: 0x00036198 File Offset: 0x00034398
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
				if (num != 8U)
				{
					if (num != 18U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.roleInfos_.AddEntriesFrom(ref input, AbyssRoleSelectInfo._repeated_roleInfos_codec);
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400203C RID: 8252
		private static readonly MessageParser<AbyssRoleSelectInfo> _parser = new MessageParser<AbyssRoleSelectInfo>(() => new AbyssRoleSelectInfo());

		// Token: 0x0400203D RID: 8253
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400203E RID: 8254
		public const int PlayerIdFieldNumber = 1;

		// Token: 0x0400203F RID: 8255
		private int playerId_;

		// Token: 0x04002040 RID: 8256
		public const int RoleInfosFieldNumber = 2;

		// Token: 0x04002041 RID: 8257
		private static readonly FieldCodec<AbyssOneRoleSelectInfo> _repeated_roleInfos_codec = FieldCodec.ForMessage<AbyssOneRoleSelectInfo>(18U, AbyssOneRoleSelectInfo.Parser);

		// Token: 0x04002042 RID: 8258
		private readonly RepeatedField<AbyssOneRoleSelectInfo> roleInfos_ = new RepeatedField<AbyssOneRoleSelectInfo>();
	}
}
