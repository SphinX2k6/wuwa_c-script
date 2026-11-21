using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000D5B RID: 3419
	public sealed class PinballWeapon : IMessage<PinballWeapon>, IMessage, IEquatable<PinballWeapon>, IDeepCloneable<PinballWeapon>, IBufferMessage
	{
		// Token: 0x06012756 RID: 75606 RVA: 0x002B1E6D File Offset: 0x002B006D
		[NullableContext(1)]
		public static PinballWeapon Create()
		{
			return new PinballWeapon();
		}

		// Token: 0x17003D2D RID: 15661
		// (get) Token: 0x06012757 RID: 75607 RVA: 0x002B1E74 File Offset: 0x002B0074
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<PinballWeapon> Parser
		{
			get
			{
				return PinballWeapon._parser;
			}
		}

		// Token: 0x17003D2E RID: 15662
		// (get) Token: 0x06012758 RID: 75608 RVA: 0x002B1E7B File Offset: 0x002B007B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003D2F RID: 15663
		// (get) Token: 0x06012759 RID: 75609 RVA: 0x002B1E7E File Offset: 0x002B007E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PinballWeapon.Descriptor;
			}
		}

		// Token: 0x0601275A RID: 75610 RVA: 0x002B1E85 File Offset: 0x002B0085
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeapon()
		{
		}

		// Token: 0x0601275B RID: 75611 RVA: 0x002B1E90 File Offset: 0x002B0090
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

		// Token: 0x0601275C RID: 75612 RVA: 0x002B1EF0 File Offset: 0x002B00F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PinballWeapon Clone()
		{
			return new PinballWeapon(this);
		}

		// Token: 0x17003D30 RID: 15664
		// (get) Token: 0x0601275D RID: 75613 RVA: 0x002B1EF8 File Offset: 0x002B00F8
		// (set) Token: 0x0601275E RID: 75614 RVA: 0x002B1F00 File Offset: 0x002B0100
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

		// Token: 0x17003D31 RID: 15665
		// (get) Token: 0x0601275F RID: 75615 RVA: 0x002B1F09 File Offset: 0x002B0109
		// (set) Token: 0x06012760 RID: 75616 RVA: 0x002B1F11 File Offset: 0x002B0111
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

		// Token: 0x17003D32 RID: 15666
		// (get) Token: 0x06012761 RID: 75617 RVA: 0x002B1F1A File Offset: 0x002B011A
		// (set) Token: 0x06012762 RID: 75618 RVA: 0x002B1F22 File Offset: 0x002B0122
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

		// Token: 0x17003D33 RID: 15667
		// (get) Token: 0x06012763 RID: 75619 RVA: 0x002B1F2B File Offset: 0x002B012B
		// (set) Token: 0x06012764 RID: 75620 RVA: 0x002B1F33 File Offset: 0x002B0133
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

		// Token: 0x17003D34 RID: 15668
		// (get) Token: 0x06012765 RID: 75621 RVA: 0x002B1F3C File Offset: 0x002B013C
		// (set) Token: 0x06012766 RID: 75622 RVA: 0x002B1F44 File Offset: 0x002B0144
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

		// Token: 0x06012767 RID: 75623 RVA: 0x002B1F4D File Offset: 0x002B014D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PinballWeapon);
		}

		// Token: 0x06012768 RID: 75624 RVA: 0x002B1F5C File Offset: 0x002B015C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PinballWeapon other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.IncrId == other.IncrId && this.FuncValue == other.FuncValue && this.RoleId == other.RoleId && this.SubEntryId == other.SubEntryId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06012769 RID: 75625 RVA: 0x002B1FD8 File Offset: 0x002B01D8
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

		// Token: 0x0601276A RID: 75626 RVA: 0x002B207B File Offset: 0x002B027B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601276B RID: 75627 RVA: 0x002B2088 File Offset: 0x002B0288
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601276C RID: 75628 RVA: 0x002B2094 File Offset: 0x002B0294
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

		// Token: 0x0601276D RID: 75629 RVA: 0x002B2140 File Offset: 0x002B0340
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

		// Token: 0x0601276E RID: 75630 RVA: 0x002B21E0 File Offset: 0x002B03E0
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

		// Token: 0x0601276F RID: 75631 RVA: 0x002B226C File Offset: 0x002B046C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06012770 RID: 75632 RVA: 0x002B2278 File Offset: 0x002B0478
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

		// Token: 0x0400732B RID: 29483
		private static readonly MessageParser<PinballWeapon> _parser = new MessageParser<PinballWeapon>(() => new PinballWeapon());

		// Token: 0x0400732C RID: 29484
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400732D RID: 29485
		public const int ConfigIdFieldNumber = 1;

		// Token: 0x0400732E RID: 29486
		private int configId_;

		// Token: 0x0400732F RID: 29487
		public const int IncrIdFieldNumber = 2;

		// Token: 0x04007330 RID: 29488
		private int incrId_;

		// Token: 0x04007331 RID: 29489
		public const int FuncValueFieldNumber = 3;

		// Token: 0x04007332 RID: 29490
		private int funcValue_;

		// Token: 0x04007333 RID: 29491
		public const int RoleIdFieldNumber = 4;

		// Token: 0x04007334 RID: 29492
		private int roleId_;

		// Token: 0x04007335 RID: 29493
		public const int SubEntryIdFieldNumber = 5;

		// Token: 0x04007336 RID: 29494
		private int subEntryId_;
	}
}
