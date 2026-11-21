using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000030 RID: 48
	public sealed class AbyssPassRoleInfo : IMessage<AbyssPassRoleInfo>, IMessage, IEquatable<AbyssPassRoleInfo>, IDeepCloneable<AbyssPassRoleInfo>, IBufferMessage
	{
		// Token: 0x0600127B RID: 4731 RVA: 0x00032CEF File Offset: 0x00030EEF
		[NullableContext(1)]
		public static AbyssPassRoleInfo Create()
		{
			return new AbyssPassRoleInfo();
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x0600127C RID: 4732 RVA: 0x00032CF6 File Offset: 0x00030EF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<AbyssPassRoleInfo> Parser
		{
			get
			{
				return AbyssPassRoleInfo._parser;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x0600127D RID: 4733 RVA: 0x00032CFD File Offset: 0x00030EFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x0600127E RID: 4734 RVA: 0x00032D00 File Offset: 0x00030F00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssPassRoleInfo.Descriptor;
			}
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x00032D07 File Offset: 0x00030F07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPassRoleInfo()
		{
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x00032D1C File Offset: 0x00030F1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPassRoleInfo(AbyssPassRoleInfo other) : this()
		{
			this.roleSkinId_ = other.roleSkinId_;
			this.roleLevel_ = other.roleLevel_;
			this.littleRoleId_ = other.littleRoleId_;
			this.pluginItemIds_ = other.pluginItemIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x00032D75 File Offset: 0x00030F75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPassRoleInfo Clone()
		{
			return new AbyssPassRoleInfo(this);
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06001282 RID: 4738 RVA: 0x00032D7D File Offset: 0x00030F7D
		// (set) Token: 0x06001283 RID: 4739 RVA: 0x00032D85 File Offset: 0x00030F85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleSkinId
		{
			get
			{
				return this.roleSkinId_;
			}
			set
			{
				this.roleSkinId_ = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06001284 RID: 4740 RVA: 0x00032D8E File Offset: 0x00030F8E
		// (set) Token: 0x06001285 RID: 4741 RVA: 0x00032D96 File Offset: 0x00030F96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleLevel
		{
			get
			{
				return this.roleLevel_;
			}
			set
			{
				this.roleLevel_ = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06001286 RID: 4742 RVA: 0x00032D9F File Offset: 0x00030F9F
		// (set) Token: 0x06001287 RID: 4743 RVA: 0x00032DA7 File Offset: 0x00030FA7
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

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06001288 RID: 4744 RVA: 0x00032DB0 File Offset: 0x00030FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PluginItemIds
		{
			get
			{
				return this.pluginItemIds_;
			}
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x00032DB8 File Offset: 0x00030FB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssPassRoleInfo);
		}

		// Token: 0x0600128A RID: 4746 RVA: 0x00032DC8 File Offset: 0x00030FC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssPassRoleInfo other)
		{
			return other != null && (other == this || (this.RoleSkinId == other.RoleSkinId && this.RoleLevel == other.RoleLevel && this.LittleRoleId == other.LittleRoleId && this.pluginItemIds_.Equals(other.pluginItemIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x00032E38 File Offset: 0x00031038
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleSkinId != 0)
			{
				num ^= this.RoleSkinId.GetHashCode();
			}
			if (this.RoleLevel != 0)
			{
				num ^= this.RoleLevel.GetHashCode();
			}
			if (this.LittleRoleId != 0)
			{
				num ^= this.LittleRoleId.GetHashCode();
			}
			num ^= this.pluginItemIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x00032EB7 File Offset: 0x000310B7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x00032EC4 File Offset: 0x000310C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600128E RID: 4750 RVA: 0x00032ED0 File Offset: 0x000310D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleSkinId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleSkinId);
			}
			if (this.RoleLevel != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RoleLevel);
			}
			if (this.LittleRoleId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.LittleRoleId);
			}
			this.pluginItemIds_.WriteTo(ref output, AbyssPassRoleInfo._repeated_pluginItemIds_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600128F RID: 4751 RVA: 0x00032F58 File Offset: 0x00031158
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleSkinId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleSkinId);
			}
			if (this.RoleLevel != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleLevel);
			}
			if (this.LittleRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LittleRoleId);
			}
			num += this.pluginItemIds_.CalculateSize(AbyssPassRoleInfo._repeated_pluginItemIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06001290 RID: 4752 RVA: 0x00032FDC File Offset: 0x000311DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(AbyssPassRoleInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleSkinId != 0)
			{
				this.RoleSkinId = other.RoleSkinId;
			}
			if (other.RoleLevel != 0)
			{
				this.RoleLevel = other.RoleLevel;
			}
			if (other.LittleRoleId != 0)
			{
				this.LittleRoleId = other.LittleRoleId;
			}
			this.pluginItemIds_.Add(other.pluginItemIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06001291 RID: 4753 RVA: 0x00033051 File Offset: 0x00031251
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001292 RID: 4754 RVA: 0x0003305C File Offset: 0x0003125C
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
						this.RoleSkinId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.RoleLevel = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.LittleRoleId = input.ReadInt32();
						continue;
					}
					if (num == 32U || num == 34U)
					{
						this.pluginItemIds_.AddEntriesFrom(ref input, AbyssPassRoleInfo._repeated_pluginItemIds_codec);
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04002015 RID: 8213
		private static readonly MessageParser<AbyssPassRoleInfo> _parser = new MessageParser<AbyssPassRoleInfo>(() => new AbyssPassRoleInfo());

		// Token: 0x04002016 RID: 8214
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002017 RID: 8215
		public const int RoleSkinIdFieldNumber = 1;

		// Token: 0x04002018 RID: 8216
		private int roleSkinId_;

		// Token: 0x04002019 RID: 8217
		public const int RoleLevelFieldNumber = 2;

		// Token: 0x0400201A RID: 8218
		private int roleLevel_;

		// Token: 0x0400201B RID: 8219
		public const int LittleRoleIdFieldNumber = 3;

		// Token: 0x0400201C RID: 8220
		private int littleRoleId_;

		// Token: 0x0400201D RID: 8221
		public const int PluginItemIdsFieldNumber = 4;

		// Token: 0x0400201E RID: 8222
		private static readonly FieldCodec<int> _repeated_pluginItemIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x0400201F RID: 8223
		private readonly RepeatedField<int> pluginItemIds_ = new RepeatedField<int>();
	}
}
