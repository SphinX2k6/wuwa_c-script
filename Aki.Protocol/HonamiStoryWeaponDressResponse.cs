using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200079A RID: 1946
	[NetMessage(EMessageId.HonamiStoryWeaponDressResponse)]
	public sealed class HonamiStoryWeaponDressResponse : IMessage<HonamiStoryWeaponDressResponse>, IMessage, IEquatable<HonamiStoryWeaponDressResponse>, IDeepCloneable<HonamiStoryWeaponDressResponse>, IBufferMessage
	{
		// Token: 0x0600AFC7 RID: 44999 RVA: 0x001A5EFE File Offset: 0x001A40FE
		[NullableContext(1)]
		public static HonamiStoryWeaponDressResponse Create()
		{
			return new HonamiStoryWeaponDressResponse();
		}

		// Token: 0x17002372 RID: 9074
		// (get) Token: 0x0600AFC8 RID: 45000 RVA: 0x001A5F05 File Offset: 0x001A4105
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002373 RID: 9075
		// (get) Token: 0x0600AFC9 RID: 45001 RVA: 0x001A5F08 File Offset: 0x001A4108
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryWeaponDressResponse.Descriptor;
			}
		}

		// Token: 0x0600AFCA RID: 45002 RVA: 0x001A5F0F File Offset: 0x001A410F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryWeaponDressResponse()
		{
		}

		// Token: 0x0600AFCB RID: 45003 RVA: 0x001A5F17 File Offset: 0x001A4117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryWeaponDressResponse(HonamiStoryWeaponDressResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.weaponItemId_ = other.weaponItemId_;
			this.rackIndex_ = other.rackIndex_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AFCC RID: 45004 RVA: 0x001A5F54 File Offset: 0x001A4154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryWeaponDressResponse Clone()
		{
			return new HonamiStoryWeaponDressResponse(this);
		}

		// Token: 0x17002374 RID: 9076
		// (get) Token: 0x0600AFCD RID: 45005 RVA: 0x001A5F5C File Offset: 0x001A415C
		// (set) Token: 0x0600AFCE RID: 45006 RVA: 0x001A5F64 File Offset: 0x001A4164
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

		// Token: 0x17002375 RID: 9077
		// (get) Token: 0x0600AFCF RID: 45007 RVA: 0x001A5F6D File Offset: 0x001A416D
		// (set) Token: 0x0600AFD0 RID: 45008 RVA: 0x001A5F75 File Offset: 0x001A4175
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

		// Token: 0x17002376 RID: 9078
		// (get) Token: 0x0600AFD1 RID: 45009 RVA: 0x001A5F7E File Offset: 0x001A417E
		// (set) Token: 0x0600AFD2 RID: 45010 RVA: 0x001A5F86 File Offset: 0x001A4186
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

		// Token: 0x0600AFD3 RID: 45011 RVA: 0x001A5F8F File Offset: 0x001A418F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryWeaponDressResponse);
		}

		// Token: 0x0600AFD4 RID: 45012 RVA: 0x001A5FA0 File Offset: 0x001A41A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryWeaponDressResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.WeaponItemId == other.WeaponItemId && this.RackIndex == other.RackIndex && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AFD5 RID: 45013 RVA: 0x001A5FFC File Offset: 0x001A41FC
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

		// Token: 0x0600AFD6 RID: 45014 RVA: 0x001A6073 File Offset: 0x001A4273
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AFD7 RID: 45015 RVA: 0x001A6080 File Offset: 0x001A4280
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AFD8 RID: 45016 RVA: 0x001A608C File Offset: 0x001A428C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.RackIndex != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.RackIndex);
			}
			if (this.WeaponItemId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.WeaponItemId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AFD9 RID: 45017 RVA: 0x001A6104 File Offset: 0x001A4304
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

		// Token: 0x0600AFDA RID: 45018 RVA: 0x001A6174 File Offset: 0x001A4374
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

		// Token: 0x0600AFDB RID: 45019 RVA: 0x001A61D8 File Offset: 0x001A43D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AFDC RID: 45020 RVA: 0x001A61E4 File Offset: 0x001A43E4
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
				if (num != 32U)
				{
					if (num != 88U)
					{
						if (num != 120U)
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
						this.RackIndex = input.ReadInt32();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004F6A RID: 20330
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004F6B RID: 20331
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04004F6C RID: 20332
		private ErrorCode errorCode_;

		// Token: 0x04004F6D RID: 20333
		public const int WeaponItemIdFieldNumber = 15;

		// Token: 0x04004F6E RID: 20334
		private int weaponItemId_;

		// Token: 0x04004F6F RID: 20335
		public const int RackIndexFieldNumber = 11;

		// Token: 0x04004F70 RID: 20336
		private int rackIndex_;
	}
}
