using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010AA RID: 4266
	public sealed class RoleShowEntry : IMessage<RoleShowEntry>, IMessage, IEquatable<RoleShowEntry>, IDeepCloneable<RoleShowEntry>, IBufferMessage
	{
		// Token: 0x06016C7B RID: 93307 RVA: 0x0034F6A8 File Offset: 0x0034D8A8
		[NullableContext(1)]
		public static RoleShowEntry Create()
		{
			return new RoleShowEntry();
		}

		// Token: 0x17004C54 RID: 19540
		// (get) Token: 0x06016C7C RID: 93308 RVA: 0x0034F6AF File Offset: 0x0034D8AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RoleShowEntry> Parser
		{
			get
			{
				return RoleShowEntry._parser;
			}
		}

		// Token: 0x17004C55 RID: 19541
		// (get) Token: 0x06016C7D RID: 93309 RVA: 0x0034F6B6 File Offset: 0x0034D8B6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004C56 RID: 19542
		// (get) Token: 0x06016C7E RID: 93310 RVA: 0x0034F6B9 File Offset: 0x0034D8B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleShowEntry.Descriptor;
			}
		}

		// Token: 0x06016C7F RID: 93311 RVA: 0x0034F6C0 File Offset: 0x0034D8C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowEntry()
		{
		}

		// Token: 0x06016C80 RID: 93312 RVA: 0x0034F6C8 File Offset: 0x0034D8C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowEntry(RoleShowEntry other) : this()
		{
			this.roleId_ = other.roleId_;
			this.level_ = other.level_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016C81 RID: 93313 RVA: 0x0034F6F9 File Offset: 0x0034D8F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleShowEntry Clone()
		{
			return new RoleShowEntry(this);
		}

		// Token: 0x17004C57 RID: 19543
		// (get) Token: 0x06016C82 RID: 93314 RVA: 0x0034F701 File Offset: 0x0034D901
		// (set) Token: 0x06016C83 RID: 93315 RVA: 0x0034F709 File Offset: 0x0034D909
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

		// Token: 0x17004C58 RID: 19544
		// (get) Token: 0x06016C84 RID: 93316 RVA: 0x0034F712 File Offset: 0x0034D912
		// (set) Token: 0x06016C85 RID: 93317 RVA: 0x0034F71A File Offset: 0x0034D91A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x06016C86 RID: 93318 RVA: 0x0034F723 File Offset: 0x0034D923
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleShowEntry);
		}

		// Token: 0x06016C87 RID: 93319 RVA: 0x0034F731 File Offset: 0x0034D931
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleShowEntry other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.Level == other.Level && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016C88 RID: 93320 RVA: 0x0034F770 File Offset: 0x0034D970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016C89 RID: 93321 RVA: 0x0034F7C8 File Offset: 0x0034D9C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06016C8A RID: 93322 RVA: 0x0034F7D5 File Offset: 0x0034D9D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06016C8B RID: 93323 RVA: 0x0034F7E0 File Offset: 0x0034D9E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.RoleId);
			}
			if (this.Level != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Level);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06016C8C RID: 93324 RVA: 0x0034F838 File Offset: 0x0034DA38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06016C8D RID: 93325 RVA: 0x0034F890 File Offset: 0x0034DA90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleShowEntry other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06016C8E RID: 93326 RVA: 0x0034F8E0 File Offset: 0x0034DAE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06016C8F RID: 93327 RVA: 0x0034F8EC File Offset: 0x0034DAEC
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
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Level = input.ReadInt32();
					}
				}
				else
				{
					this.RoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008802 RID: 34818
		private static readonly MessageParser<RoleShowEntry> _parser = new MessageParser<RoleShowEntry>(() => new RoleShowEntry());

		// Token: 0x04008803 RID: 34819
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008804 RID: 34820
		public const int RoleIdFieldNumber = 1;

		// Token: 0x04008805 RID: 34821
		private int roleId_;

		// Token: 0x04008806 RID: 34822
		public const int LevelFieldNumber = 2;

		// Token: 0x04008807 RID: 34823
		private int level_;
	}
}
