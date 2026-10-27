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
		// Token: 0x06001239 RID: 4665 RVA: 0x000323BC File Offset: 0x000305BC
		[NullableContext(1)]
		public static AbyssOneRoleSelectInfo Create()
		{
			return new AbyssOneRoleSelectInfo();
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x0600123A RID: 4666 RVA: 0x000323C3 File Offset: 0x000305C3
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
		// (get) Token: 0x0600123B RID: 4667 RVA: 0x000323CA File Offset: 0x000305CA
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
		// (get) Token: 0x0600123C RID: 4668 RVA: 0x000323CD File Offset: 0x000305CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return AbyssOneRoleSelectInfo.Descriptor;
			}
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x000323D4 File Offset: 0x000305D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssOneRoleSelectInfo()
		{
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x000323E8 File Offset: 0x000305E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssOneRoleSelectInfo(AbyssOneRoleSelectInfo other) : this()
		{
			this.roleId_ = other.roleId_;
			this.littleRoleId_ = other.littleRoleId_;
			this.pluginItemId_ = other.pluginItemId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x00032435 File Offset: 0x00030635
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public AbyssOneRoleSelectInfo Clone()
		{
			return new AbyssOneRoleSelectInfo(this);
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x0003243D File Offset: 0x0003063D
		// (set) Token: 0x06001241 RID: 4673 RVA: 0x00032445 File Offset: 0x00030645
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
		// (get) Token: 0x06001242 RID: 4674 RVA: 0x0003244E File Offset: 0x0003064E
		// (set) Token: 0x06001243 RID: 4675 RVA: 0x00032456 File Offset: 0x00030656
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
		// (get) Token: 0x06001244 RID: 4676 RVA: 0x0003245F File Offset: 0x0003065F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PluginItemId
		{
			get
			{
				return this.pluginItemId_;
			}
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00032467 File Offset: 0x00030667
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as AbyssOneRoleSelectInfo);
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00032478 File Offset: 0x00030678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(AbyssOneRoleSelectInfo other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.LittleRoleId == other.LittleRoleId && this.pluginItemId_.Equals(other.pluginItemId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x000324D8 File Offset: 0x000306D8
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

		// Token: 0x06001248 RID: 4680 RVA: 0x0003253E File Offset: 0x0003073E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x0003254B File Offset: 0x0003074B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00032554 File Offset: 0x00030754
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

		// Token: 0x0600124B RID: 4683 RVA: 0x000325C0 File Offset: 0x000307C0
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

		// Token: 0x0600124C RID: 4684 RVA: 0x0003262C File Offset: 0x0003082C
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

		// Token: 0x0600124D RID: 4685 RVA: 0x0003268D File Offset: 0x0003088D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00032698 File Offset: 0x00030898
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

		// Token: 0x04001FB6 RID: 8118
		private static readonly MessageParser<AbyssOneRoleSelectInfo> _parser = new MessageParser<AbyssOneRoleSelectInfo>(() => new AbyssOneRoleSelectInfo());

		// Token: 0x04001FB7 RID: 8119
		private UnknownFieldSet _unknownFields;

		// Token: 0x04001FB8 RID: 8120
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04001FB9 RID: 8121
		private int roleId_;

		// Token: 0x04001FBA RID: 8122
		public const int LittleRoleIdFieldNumber = 2;

		// Token: 0x04001FBB RID: 8123
		private int littleRoleId_;

		// Token: 0x04001FBC RID: 8124
		public const int PluginItemIdFieldNumber = 3;

		// Token: 0x04001FBD RID: 8125
		private static readonly FieldCodec<int> _repeated_pluginItemId_codec = FieldCodec.ForInt32(26U);

		// Token: 0x04001FBE RID: 8126
		private readonly RepeatedField<int> pluginItemId_ = new RepeatedField<int>();
	}
}
