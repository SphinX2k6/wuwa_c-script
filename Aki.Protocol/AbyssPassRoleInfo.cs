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
		// Token: 0x06001250 RID: 4688 RVA: 0x0003273B File Offset: 0x0003093B
		[NullableContext(1)]
		public static AbyssPassRoleInfo Create()
		{
			return new AbyssPassRoleInfo();
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06001251 RID: 4689 RVA: 0x00032742 File Offset: 0x00030942
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
		// (get) Token: 0x06001252 RID: 4690 RVA: 0x00032749 File Offset: 0x00030949
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
		// (get) Token: 0x06001253 RID: 4691 RVA: 0x0003274C File Offset: 0x0003094C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssPassRoleInfo.Descriptor;
			}
		}

		// Token: 0x06001254 RID: 4692 RVA: 0x00032753 File Offset: 0x00030953
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPassRoleInfo()
		{
		}

		// Token: 0x06001255 RID: 4693 RVA: 0x00032768 File Offset: 0x00030968
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

		// Token: 0x06001256 RID: 4694 RVA: 0x000327C1 File Offset: 0x000309C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssPassRoleInfo Clone()
		{
			return new AbyssPassRoleInfo(this);
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06001257 RID: 4695 RVA: 0x000327C9 File Offset: 0x000309C9
		// (set) Token: 0x06001258 RID: 4696 RVA: 0x000327D1 File Offset: 0x000309D1
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
		// (get) Token: 0x06001259 RID: 4697 RVA: 0x000327DA File Offset: 0x000309DA
		// (set) Token: 0x0600125A RID: 4698 RVA: 0x000327E2 File Offset: 0x000309E2
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
		// (get) Token: 0x0600125B RID: 4699 RVA: 0x000327EB File Offset: 0x000309EB
		// (set) Token: 0x0600125C RID: 4700 RVA: 0x000327F3 File Offset: 0x000309F3
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
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x000327FC File Offset: 0x000309FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PluginItemIds
		{
			get
			{
				return this.pluginItemIds_;
			}
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00032804 File Offset: 0x00030A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssPassRoleInfo);
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x00032814 File Offset: 0x00030A14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssPassRoleInfo other)
		{
			return other != null && (other == this || (this.RoleSkinId == other.RoleSkinId && this.RoleLevel == other.RoleLevel && this.LittleRoleId == other.LittleRoleId && this.pluginItemIds_.Equals(other.pluginItemIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00032884 File Offset: 0x00030A84
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

		// Token: 0x06001261 RID: 4705 RVA: 0x00032903 File Offset: 0x00030B03
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x00032910 File Offset: 0x00030B10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x0003291C File Offset: 0x00030B1C
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

		// Token: 0x06001264 RID: 4708 RVA: 0x000329A4 File Offset: 0x00030BA4
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

		// Token: 0x06001265 RID: 4709 RVA: 0x00032A28 File Offset: 0x00030C28
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

		// Token: 0x06001266 RID: 4710 RVA: 0x00032A9D File Offset: 0x00030C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00032AA8 File Offset: 0x00030CA8
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

		// Token: 0x04001FBF RID: 8127
		private static readonly MessageParser<AbyssPassRoleInfo> _parser = new MessageParser<AbyssPassRoleInfo>(() => new AbyssPassRoleInfo());

		// Token: 0x04001FC0 RID: 8128
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FC1 RID: 8129
		public const int RoleSkinIdFieldNumber = 1;

		// Token: 0x04001FC2 RID: 8130
		private int roleSkinId_;

		// Token: 0x04001FC3 RID: 8131
		public const int RoleLevelFieldNumber = 2;

		// Token: 0x04001FC4 RID: 8132
		private int roleLevel_;

		// Token: 0x04001FC5 RID: 8133
		public const int LittleRoleIdFieldNumber = 3;

		// Token: 0x04001FC6 RID: 8134
		private int littleRoleId_;

		// Token: 0x04001FC7 RID: 8135
		public const int PluginItemIdsFieldNumber = 4;

		// Token: 0x04001FC8 RID: 8136
		private static readonly FieldCodec<int> _repeated_pluginItemIds_codec = FieldCodec.ForInt32(34U);

		// Token: 0x04001FC9 RID: 8137
		private readonly RepeatedField<int> pluginItemIds_ = new RepeatedField<int>();
	}
}
