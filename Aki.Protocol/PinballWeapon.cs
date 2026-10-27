using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D6B RID: 3435
	public sealed class PinballWeapon : IMessage<PinballWeapon>, IMessage, IEquatable<PinballWeapon>, IDeepCloneable<PinballWeapon>, IBufferMessage
	{
		// Token: 0x06012852 RID: 75858 RVA: 0x002B3A85 File Offset: 0x002B1C85
		[NullableContext(1)]
		public static PinballWeapon Create()
		{
			return new PinballWeapon();
		}

		// Token: 0x17003D62 RID: 15714
		// (get) Token: 0x06012853 RID: 75859 RVA: 0x002B3A8C File Offset: 0x002B1C8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PinballWeapon> Parser
		{
			get
			{
				return PinballWeapon._parser;
			}
		}

		// Token: 0x17003D63 RID: 15715
		// (get) Token: 0x06012854 RID: 75860 RVA: 0x002B3A93 File Offset: 0x002B1C93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D64 RID: 15716
		// (get) Token: 0x06012855 RID: 75861 RVA: 0x002B3A96 File Offset: 0x002B1C96
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballWeapon.Descriptor;
			}
		}

		// Token: 0x06012856 RID: 75862 RVA: 0x002B3A9D File Offset: 0x002B1C9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeapon()
		{
		}

		// Token: 0x06012857 RID: 75863 RVA: 0x002B3AA8 File Offset: 0x002B1CA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeapon(PinballWeapon other) : this()
		{
			this.configId_ = other.configId_;
			this.incrId_ = other.incrId_;
			this.funcValue_ = other.funcValue_;
			this.roleId_ = other.roleId_;
			this.subEntryId_ = other.subEntryId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06012858 RID: 75864 RVA: 0x002B3B08 File Offset: 0x002B1D08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeapon Clone()
		{
			return new PinballWeapon(this);
		}

		// Token: 0x17003D65 RID: 15717
		// (get) Token: 0x06012859 RID: 75865 RVA: 0x002B3B10 File Offset: 0x002B1D10
		// (set) Token: 0x0601285A RID: 75866 RVA: 0x002B3B18 File Offset: 0x002B1D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17003D66 RID: 15718
		// (get) Token: 0x0601285B RID: 75867 RVA: 0x002B3B21 File Offset: 0x002B1D21
		// (set) Token: 0x0601285C RID: 75868 RVA: 0x002B3B29 File Offset: 0x002B1D29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncrId
		{
			get
			{
				return this.incrId_;
			}
			set
			{
				this.incrId_ = value;
			}
		}

		// Token: 0x17003D67 RID: 15719
		// (get) Token: 0x0601285D RID: 75869 RVA: 0x002B3B32 File Offset: 0x002B1D32
		// (set) Token: 0x0601285E RID: 75870 RVA: 0x002B3B3A File Offset: 0x002B1D3A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int FuncValue
		{
			get
			{
				return this.funcValue_;
			}
			set
			{
				this.funcValue_ = value;
			}
		}

		// Token: 0x17003D68 RID: 15720
		// (get) Token: 0x0601285F RID: 75871 RVA: 0x002B3B43 File Offset: 0x002B1D43
		// (set) Token: 0x06012860 RID: 75872 RVA: 0x002B3B4B File Offset: 0x002B1D4B
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

		// Token: 0x17003D69 RID: 15721
		// (get) Token: 0x06012861 RID: 75873 RVA: 0x002B3B54 File Offset: 0x002B1D54
		// (set) Token: 0x06012862 RID: 75874 RVA: 0x002B3B5C File Offset: 0x002B1D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubEntryId
		{
			get
			{
				return this.subEntryId_;
			}
			set
			{
				this.subEntryId_ = value;
			}
		}

		// Token: 0x06012863 RID: 75875 RVA: 0x002B3B65 File Offset: 0x002B1D65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballWeapon);
		}

		// Token: 0x06012864 RID: 75876 RVA: 0x002B3B74 File Offset: 0x002B1D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballWeapon other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.IncrId == other.IncrId && this.FuncValue == other.FuncValue && this.RoleId == other.RoleId && this.SubEntryId == other.SubEntryId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012865 RID: 75877 RVA: 0x002B3BF0 File Offset: 0x002B1DF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.IncrId != 0)
			{
				num ^= this.IncrId.GetHashCode();
			}
			if (this.FuncValue != 0)
			{
				num ^= this.FuncValue.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			if (this.SubEntryId != 0)
			{
				num ^= this.SubEntryId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06012866 RID: 75878 RVA: 0x002B3C93 File Offset: 0x002B1E93
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06012867 RID: 75879 RVA: 0x002B3CA0 File Offset: 0x002B1EA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06012868 RID: 75880 RVA: 0x002B3CAC File Offset: 0x002B1EAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.ConfigId);
			}
			if (this.IncrId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.IncrId);
			}
			if (this.FuncValue != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.FuncValue);
			}
			if (this.RoleId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.RoleId);
			}
			if (this.SubEntryId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.SubEntryId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06012869 RID: 75881 RVA: 0x002B3D58 File Offset: 0x002B1F58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.IncrId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncrId);
			}
			if (this.FuncValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.FuncValue);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			if (this.SubEntryId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubEntryId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601286A RID: 75882 RVA: 0x002B3DF8 File Offset: 0x002B1FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PinballWeapon other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.IncrId != 0)
			{
				this.IncrId = other.IncrId;
			}
			if (other.FuncValue != 0)
			{
				this.FuncValue = other.FuncValue;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			if (other.SubEntryId != 0)
			{
				this.SubEntryId = other.SubEntryId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601286B RID: 75883 RVA: 0x002B3E84 File Offset: 0x002B2084
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601286C RID: 75884 RVA: 0x002B3E90 File Offset: 0x002B2090
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
						this.ConfigId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.IncrId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.FuncValue = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.SubEntryId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04007313 RID: 29459
		private static readonly MessageParser<PinballWeapon> _parser = new MessageParser<PinballWeapon>(() => new PinballWeapon());

		// Token: 0x04007314 RID: 29460
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007315 RID: 29461
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x04007316 RID: 29462
		private int configId_;

		// Token: 0x04007317 RID: 29463
		public const int IncrIdFieldNumber = 2;

		// Token: 0x04007318 RID: 29464
		private int incrId_;

		// Token: 0x04007319 RID: 29465
		public const int FuncValueFieldNumber = 3;

		// Token: 0x0400731A RID: 29466
		private int funcValue_;

		// Token: 0x0400731B RID: 29467
		public const int RoleIdFieldNumber = 4;

		// Token: 0x0400731C RID: 29468
		private int roleId_;

		// Token: 0x0400731D RID: 29469
		public const int SubEntryIdFieldNumber = 5;

		// Token: 0x0400731E RID: 29470
		private int subEntryId_;
	}
}
