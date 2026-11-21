using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001227 RID: 4647
	public sealed class ShieldUpdateInfo : IMessage<ShieldUpdateInfo>, IMessage, IEquatable<ShieldUpdateInfo>, IDeepCloneable<ShieldUpdateInfo>, IBufferMessage
	{
		// Token: 0x06018D12 RID: 101650 RVA: 0x0039E020 File Offset: 0x0039C220
		[NullableContext(1)]
		public static ShieldUpdateInfo Create()
		{
			return new ShieldUpdateInfo();
		}

		// Token: 0x170053D0 RID: 21456
		// (get) Token: 0x06018D13 RID: 101651 RVA: 0x0039E027 File Offset: 0x0039C227
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShieldUpdateInfo> Parser
		{
			get
			{
				return ShieldUpdateInfo._parser;
			}
		}

		// Token: 0x170053D1 RID: 21457
		// (get) Token: 0x06018D14 RID: 101652 RVA: 0x0039E02E File Offset: 0x0039C22E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053D2 RID: 21458
		// (get) Token: 0x06018D15 RID: 101653 RVA: 0x0039E031 File Offset: 0x0039C231
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShieldUpdateInfo.Descriptor;
			}
		}

		// Token: 0x06018D16 RID: 101654 RVA: 0x0039E038 File Offset: 0x0039C238
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldUpdateInfo()
		{
		}

		// Token: 0x06018D17 RID: 101655 RVA: 0x0039E040 File Offset: 0x0039C240
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldUpdateInfo(ShieldUpdateInfo other) : this()
		{
			this.handle_ = other.handle_;
			this.configId_ = other.configId_;
			this.shieldValue_ = other.shieldValue_;
			this.updateType_ = other.updateType_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018D18 RID: 101656 RVA: 0x0039E094 File Offset: 0x0039C294
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldUpdateInfo Clone()
		{
			return new ShieldUpdateInfo(this);
		}

		// Token: 0x170053D3 RID: 21459
		// (get) Token: 0x06018D19 RID: 101657 RVA: 0x0039E09C File Offset: 0x0039C29C
		// (set) Token: 0x06018D1A RID: 101658 RVA: 0x0039E0A4 File Offset: 0x0039C2A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Handle
		{
			get
			{
				return this.handle_;
			}
			set
			{
				this.handle_ = value;
			}
		}

		// Token: 0x170053D4 RID: 21460
		// (get) Token: 0x06018D1B RID: 101659 RVA: 0x0039E0AD File Offset: 0x0039C2AD
		// (set) Token: 0x06018D1C RID: 101660 RVA: 0x0039E0B5 File Offset: 0x0039C2B5
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

		// Token: 0x170053D5 RID: 21461
		// (get) Token: 0x06018D1D RID: 101661 RVA: 0x0039E0BE File Offset: 0x0039C2BE
		// (set) Token: 0x06018D1E RID: 101662 RVA: 0x0039E0C6 File Offset: 0x0039C2C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ShieldValue
		{
			get
			{
				return this.shieldValue_;
			}
			set
			{
				this.shieldValue_ = value;
			}
		}

		// Token: 0x170053D6 RID: 21462
		// (get) Token: 0x06018D1F RID: 101663 RVA: 0x0039E0CF File Offset: 0x0039C2CF
		// (set) Token: 0x06018D20 RID: 101664 RVA: 0x0039E0D7 File Offset: 0x0039C2D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EShieldUpdateType UpdateType
		{
			get
			{
				return this.updateType_;
			}
			set
			{
				this.updateType_ = value;
			}
		}

		// Token: 0x06018D21 RID: 101665 RVA: 0x0039E0E0 File Offset: 0x0039C2E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShieldUpdateInfo);
		}

		// Token: 0x06018D22 RID: 101666 RVA: 0x0039E0F0 File Offset: 0x0039C2F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShieldUpdateInfo other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.ConfigId == other.ConfigId && this.ShieldValue == other.ShieldValue && this.UpdateType == other.UpdateType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018D23 RID: 101667 RVA: 0x0039E15C File Offset: 0x0039C35C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Handle != 0)
			{
				num ^= this.Handle.GetHashCode();
			}
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.ShieldValue != 0)
			{
				num ^= this.ShieldValue.GetHashCode();
			}
			if (this.UpdateType != EShieldUpdateType.Add)
			{
				num ^= this.UpdateType.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018D24 RID: 101668 RVA: 0x0039E1EC File Offset: 0x0039C3EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018D25 RID: 101669 RVA: 0x0039E1F9 File Offset: 0x0039C3F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018D26 RID: 101670 RVA: 0x0039E204 File Offset: 0x0039C404
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Handle != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Handle);
			}
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.ConfigId);
			}
			if (this.ShieldValue != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.ShieldValue);
			}
			if (this.UpdateType != EShieldUpdateType.Add)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.UpdateType);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018D27 RID: 101671 RVA: 0x0039E294 File Offset: 0x0039C494
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Handle != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Handle);
			}
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.ShieldValue != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ShieldValue);
			}
			if (this.UpdateType != EShieldUpdateType.Add)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.UpdateType);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018D28 RID: 101672 RVA: 0x0039E31C File Offset: 0x0039C51C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShieldUpdateInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Handle != 0)
			{
				this.Handle = other.Handle;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.ShieldValue != 0)
			{
				this.ShieldValue = other.ShieldValue;
			}
			if (other.UpdateType != EShieldUpdateType.Add)
			{
				this.UpdateType = other.UpdateType;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018D29 RID: 101673 RVA: 0x0039E394 File Offset: 0x0039C594
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018D2A RID: 101674 RVA: 0x0039E3A0 File Offset: 0x0039C5A0
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
						this.Handle = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.ConfigId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.ShieldValue = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.UpdateType = (EShieldUpdateType)input.ReadEnum();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x0400933E RID: 37694
		private static readonly MessageParser<ShieldUpdateInfo> _parser = new MessageParser<ShieldUpdateInfo>(() => new ShieldUpdateInfo());

		// Token: 0x0400933F RID: 37695
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009340 RID: 37696
		public const int HandleFieldNumber = 1;

		// Token: 0x04009341 RID: 37697
		private int handle_;

		// Token: 0x04009342 RID: 37698
		public const int ConfigIdFieldNumber = 2;

		// Token: 0x04009343 RID: 37699
		private int configId_;

		// Token: 0x04009344 RID: 37700
		public const int ShieldValueFieldNumber = 3;

		// Token: 0x04009345 RID: 37701
		private int shieldValue_;

		// Token: 0x04009346 RID: 37702
		public const int UpdateTypeFieldNumber = 4;

		// Token: 0x04009347 RID: 37703
		private EShieldUpdateType updateType_;
	}
}
