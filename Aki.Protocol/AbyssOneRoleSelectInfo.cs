using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200002F RID: 47
	public sealed class AbyssOneRoleSelectInfo : IMessage<AbyssOneRoleSelectInfo>, IMessage, IEquatable<AbyssOneRoleSelectInfo>, IDeepCloneable<AbyssOneRoleSelectInfo>, IBufferMessage
	{
		// Token: 0x06001264 RID: 4708 RVA: 0x00032970 File Offset: 0x00030B70
		[NullableContext(1)]
		public static AbyssOneRoleSelectInfo Create()
		{
			return new AbyssOneRoleSelectInfo();
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06001265 RID: 4709 RVA: 0x00032977 File Offset: 0x00030B77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AbyssOneRoleSelectInfo> Parser
		{
			get
			{
				return AbyssOneRoleSelectInfo._parser;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x0003297E File Offset: 0x00030B7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x00032981 File Offset: 0x00030B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssOneRoleSelectInfo.Descriptor;
			}
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00032988 File Offset: 0x00030B88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssOneRoleSelectInfo()
		{
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x0003299C File Offset: 0x00030B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssOneRoleSelectInfo(AbyssOneRoleSelectInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.littleRoleId_ = other.littleRoleId_;
			this.pluginItemId_ = other.pluginItemId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600126A RID: 4714 RVA: 0x000329E9 File Offset: 0x00030BE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssOneRoleSelectInfo Clone()
		{
			return new AbyssOneRoleSelectInfo(this);
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600126B RID: 4715 RVA: 0x000329F1 File Offset: 0x00030BF1
		// (set) Token: 0x0600126C RID: 4716 RVA: 0x000329F9 File Offset: 0x00030BF9
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

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600126D RID: 4717 RVA: 0x00032A02 File Offset: 0x00030C02
		// (set) Token: 0x0600126E RID: 4718 RVA: 0x00032A0A File Offset: 0x00030C0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LittleRoleId
		{
			get
			{
				return this.littleRoleId_;
			}
			set
			{
				this.littleRoleId_ = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x00032A13 File Offset: 0x00030C13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PluginItemId
		{
			get
			{
				return this.pluginItemId_;
			}
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x00032A1B File Offset: 0x00030C1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssOneRoleSelectInfo);
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x00032A2C File Offset: 0x00030C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssOneRoleSelectInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.LittleRoleId == other.LittleRoleId && this.pluginItemId_.Equals(other.pluginItemId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x00032A8C File Offset: 0x00030C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.LittleRoleId != 0)
			{
				num ^= this.LittleRoleId.GetHashCode();
			}
			num ^= this.pluginItemId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x00032AF2 File Offset: 0x00030CF2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x00032AFF File Offset: 0x00030CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x00032B08 File Offset: 0x00030D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.LittleRoleId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.LittleRoleId);
			}
			this.pluginItemId_.WriteTo(ref output, AbyssOneRoleSelectInfo._repeated_pluginItemId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x00032B74 File Offset: 0x00030D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.LittleRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LittleRoleId);
			}
			num += this.pluginItemId_.CalculateSize(AbyssOneRoleSelectInfo._repeated_pluginItemId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x00032BE0 File Offset: 0x00030DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssOneRoleSelectInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.LittleRoleId != 0)
			{
				this.LittleRoleId = other.LittleRoleId;
			}
			this.pluginItemId_.Add(other.pluginItemId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x00032C41 File Offset: 0x00030E41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x00032C4C File Offset: 0x00030E4C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.LittleRoleId = input.ReadInt32();
						continue;
					}
				}
				else if (num == 24U || num == 26U)
				{
					this.pluginItemId_.AddEntriesFrom(ref input, AbyssOneRoleSelectInfo._repeated_pluginItemId_codec);
					continue;
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400200C RID: 8204
		private static readonly MessageParser<AbyssOneRoleSelectInfo> _parser = new MessageParser<AbyssOneRoleSelectInfo>(() => new AbyssOneRoleSelectInfo());

		// Token: 0x0400200D RID: 8205
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400200E RID: 8206
		public const int RoleIdFieldNumber = 1;

		// Token: 0x0400200F RID: 8207
		private int roleId_;

		// Token: 0x04002010 RID: 8208
		public const int LittleRoleIdFieldNumber = 2;

		// Token: 0x04002011 RID: 8209
		private int littleRoleId_;

		// Token: 0x04002012 RID: 8210
		public const int PluginItemIdFieldNumber = 3;

		// Token: 0x04002013 RID: 8211
		private static readonly FieldCodec<int> _repeated_pluginItemId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04002014 RID: 8212
		private readonly RepeatedField<int> pluginItemId_ = new RepeatedField<int>();
	}
}
