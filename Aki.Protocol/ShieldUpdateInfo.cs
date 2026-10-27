using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011EC RID: 4588
	public sealed class ShieldUpdateInfo : IMessage<ShieldUpdateInfo>, IMessage, IEquatable<ShieldUpdateInfo>, IDeepCloneable<ShieldUpdateInfo>, IBufferMessage
	{
		// Token: 0x0601874E RID: 100174 RVA: 0x0038E4BC File Offset: 0x0038C6BC
		[NullableContext(1)]
		public static ShieldUpdateInfo Create()
		{
			return new ShieldUpdateInfo();
		}

		// Token: 0x17005258 RID: 21080
		// (get) Token: 0x0601874F RID: 100175 RVA: 0x0038E4C3 File Offset: 0x0038C6C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShieldUpdateInfo> Parser
		{
			get
			{
				return ShieldUpdateInfo._parser;
			}
		}

		// Token: 0x17005259 RID: 21081
		// (get) Token: 0x06018750 RID: 100176 RVA: 0x0038E4CA File Offset: 0x0038C6CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700525A RID: 21082
		// (get) Token: 0x06018751 RID: 100177 RVA: 0x0038E4CD File Offset: 0x0038C6CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShieldUpdateInfo.Descriptor;
			}
		}

		// Token: 0x06018752 RID: 100178 RVA: 0x0038E4D4 File Offset: 0x0038C6D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldUpdateInfo()
		{
		}

		// Token: 0x06018753 RID: 100179 RVA: 0x0038E4DC File Offset: 0x0038C6DC
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

		// Token: 0x06018754 RID: 100180 RVA: 0x0038E530 File Offset: 0x0038C730
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldUpdateInfo Clone()
		{
			return new ShieldUpdateInfo(this);
		}

		// Token: 0x1700525B RID: 21083
		// (get) Token: 0x06018755 RID: 100181 RVA: 0x0038E538 File Offset: 0x0038C738
		// (set) Token: 0x06018756 RID: 100182 RVA: 0x0038E540 File Offset: 0x0038C740
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

		// Token: 0x1700525C RID: 21084
		// (get) Token: 0x06018757 RID: 100183 RVA: 0x0038E549 File Offset: 0x0038C749
		// (set) Token: 0x06018758 RID: 100184 RVA: 0x0038E551 File Offset: 0x0038C751
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

		// Token: 0x1700525D RID: 21085
		// (get) Token: 0x06018759 RID: 100185 RVA: 0x0038E55A File Offset: 0x0038C75A
		// (set) Token: 0x0601875A RID: 100186 RVA: 0x0038E562 File Offset: 0x0038C762
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

		// Token: 0x1700525E RID: 21086
		// (get) Token: 0x0601875B RID: 100187 RVA: 0x0038E56B File Offset: 0x0038C76B
		// (set) Token: 0x0601875C RID: 100188 RVA: 0x0038E573 File Offset: 0x0038C773
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

		// Token: 0x0601875D RID: 100189 RVA: 0x0038E57C File Offset: 0x0038C77C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShieldUpdateInfo);
		}

		// Token: 0x0601875E RID: 100190 RVA: 0x0038E58C File Offset: 0x0038C78C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShieldUpdateInfo other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.ConfigId == other.ConfigId && this.ShieldValue == other.ShieldValue && this.UpdateType == other.UpdateType && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601875F RID: 100191 RVA: 0x0038E5F8 File Offset: 0x0038C7F8
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

		// Token: 0x06018760 RID: 100192 RVA: 0x0038E688 File Offset: 0x0038C888
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018761 RID: 100193 RVA: 0x0038E695 File Offset: 0x0038C895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018762 RID: 100194 RVA: 0x0038E6A0 File Offset: 0x0038C8A0
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

		// Token: 0x06018763 RID: 100195 RVA: 0x0038E730 File Offset: 0x0038C930
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

		// Token: 0x06018764 RID: 100196 RVA: 0x0038E7B8 File Offset: 0x0038C9B8
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

		// Token: 0x06018765 RID: 100197 RVA: 0x0038E830 File Offset: 0x0038CA30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018766 RID: 100198 RVA: 0x0038E83C File Offset: 0x0038CA3C
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

		// Token: 0x04009094 RID: 37012
		private static readonly MessageParser<ShieldUpdateInfo> _parser = new MessageParser<ShieldUpdateInfo>(() => new ShieldUpdateInfo());

		// Token: 0x04009095 RID: 37013
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009096 RID: 37014
		public const int HandleFieldNumber = 1;

		// Token: 0x04009097 RID: 37015
		private int handle_;

		// Token: 0x04009098 RID: 37016
		public const int ConfigIdFieldNumber = 2;

		// Token: 0x04009099 RID: 37017
		private int configId_;

		// Token: 0x0400909A RID: 37018
		public const int ShieldValueFieldNumber = 3;

		// Token: 0x0400909B RID: 37019
		private int shieldValue_;

		// Token: 0x0400909C RID: 37020
		public const int UpdateTypeFieldNumber = 4;

		// Token: 0x0400909D RID: 37021
		private EShieldUpdateType updateType_;
	}
}
