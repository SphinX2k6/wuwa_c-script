using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020007AE RID: 1966
	[NetMessage(EMessageId.HonamiStoryWeaponDressResponse)]
	public sealed class HonamiStoryWeaponDressResponse : IMessage<HonamiStoryWeaponDressResponse>, IMessage, IEquatable<HonamiStoryWeaponDressResponse>, IDeepCloneable<HonamiStoryWeaponDressResponse>, IBufferMessage
	{
		// Token: 0x0600B11D RID: 45341 RVA: 0x001A892F File Offset: 0x001A6B2F
		[NullableContext(1)]
		public static HonamiStoryWeaponDressResponse Create()
		{
			return new HonamiStoryWeaponDressResponse();
		}

		// Token: 0x170023BC RID: 9148
		// (get) Token: 0x0600B11E RID: 45342 RVA: 0x001A8936 File Offset: 0x001A6B36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170023BD RID: 9149
		// (get) Token: 0x0600B11F RID: 45343 RVA: 0x001A8939 File Offset: 0x001A6B39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryWeaponDressResponse.Descriptor;
			}
		}

		// Token: 0x0600B120 RID: 45344 RVA: 0x001A8940 File Offset: 0x001A6B40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryWeaponDressResponse()
		{
		}

		// Token: 0x0600B121 RID: 45345 RVA: 0x001A8948 File Offset: 0x001A6B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryWeaponDressResponse(HonamiStoryWeaponDressResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.weaponItemId_ = other.weaponItemId_;
			this.rackIndex_ = other.rackIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600B122 RID: 45346 RVA: 0x001A8985 File Offset: 0x001A6B85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryWeaponDressResponse Clone()
		{
			return new HonamiStoryWeaponDressResponse(this);
		}

		// Token: 0x170023BE RID: 9150
		// (get) Token: 0x0600B123 RID: 45347 RVA: 0x001A898D File Offset: 0x001A6B8D
		// (set) Token: 0x0600B124 RID: 45348 RVA: 0x001A8995 File Offset: 0x001A6B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x170023BF RID: 9151
		// (get) Token: 0x0600B125 RID: 45349 RVA: 0x001A899E File Offset: 0x001A6B9E
		// (set) Token: 0x0600B126 RID: 45350 RVA: 0x001A89A6 File Offset: 0x001A6BA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponItemId
		{
			get
			{
				return this.weaponItemId_;
			}
			set
			{
				this.weaponItemId_ = value;
			}
		}

		// Token: 0x170023C0 RID: 9152
		// (get) Token: 0x0600B127 RID: 45351 RVA: 0x001A89AF File Offset: 0x001A6BAF
		// (set) Token: 0x0600B128 RID: 45352 RVA: 0x001A89B7 File Offset: 0x001A6BB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RackIndex
		{
			get
			{
				return this.rackIndex_;
			}
			set
			{
				this.rackIndex_ = value;
			}
		}

		// Token: 0x0600B129 RID: 45353 RVA: 0x001A89C0 File Offset: 0x001A6BC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryWeaponDressResponse);
		}

		// Token: 0x0600B12A RID: 45354 RVA: 0x001A89D0 File Offset: 0x001A6BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryWeaponDressResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.WeaponItemId == other.WeaponItemId && this.RackIndex == other.RackIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600B12B RID: 45355 RVA: 0x001A8A2C File Offset: 0x001A6C2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.WeaponItemId != 0)
			{
				num ^= this.WeaponItemId.GetHashCode();
			}
			if (this.RackIndex != 0)
			{
				num ^= this.RackIndex.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600B12C RID: 45356 RVA: 0x001A8AA3 File Offset: 0x001A6CA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600B12D RID: 45357 RVA: 0x001A8AB0 File Offset: 0x001A6CB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600B12E RID: 45358 RVA: 0x001A8ABC File Offset: 0x001A6CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RackIndex != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RackIndex);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(64);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.WeaponItemId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.WeaponItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600B12F RID: 45359 RVA: 0x001A8B34 File Offset: 0x001A6D34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.WeaponItemId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponItemId);
			}
			if (this.RackIndex != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RackIndex);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600B130 RID: 45360 RVA: 0x001A8BA4 File Offset: 0x001A6DA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryWeaponDressResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.WeaponItemId != 0)
			{
				this.WeaponItemId = other.WeaponItemId;
			}
			if (other.RackIndex != 0)
			{
				this.RackIndex = other.RackIndex;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600B131 RID: 45361 RVA: 0x001A8C08 File Offset: 0x001A6E08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600B132 RID: 45362 RVA: 0x001A8C14 File Offset: 0x001A6E14
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
				if (num != 40U)
				{
					if (num != 64U)
					{
						if (num != 96U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.WeaponItemId = input.ReadInt32();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.RackIndex = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004F71 RID: 20337
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F72 RID: 20338
		public const int ErrorCodeFieldNumber = 8;

		// Token: 0x04004F73 RID: 20339
		private ErrorCode errorCode_;

		// Token: 0x04004F74 RID: 20340
		public const int WeaponItemIdFieldNumber = 12;

		// Token: 0x04004F75 RID: 20341
		private int weaponItemId_;

		// Token: 0x04004F76 RID: 20342
		public const int RackIndexFieldNumber = 5;

		// Token: 0x04004F77 RID: 20343
		private int rackIndex_;
	}
}
