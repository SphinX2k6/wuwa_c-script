using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014EB RID: 5355
	[NetMessage(EMessageId.WeaponBreachResponse)]
	public sealed class WeaponBreachResponse : IMessage<WeaponBreachResponse>, IMessage, IEquatable<WeaponBreachResponse>, IDeepCloneable<WeaponBreachResponse>, IBufferMessage
	{
		// Token: 0x0601C4F9 RID: 115961 RVA: 0x004172B9 File Offset: 0x004154B9
		[NullableContext(1)]
		public static WeaponBreachResponse Create()
		{
			return new WeaponBreachResponse();
		}

		// Token: 0x17005F6F RID: 24431
		// (get) Token: 0x0601C4FA RID: 115962 RVA: 0x004172C0 File Offset: 0x004154C0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F70 RID: 24432
		// (get) Token: 0x0601C4FB RID: 115963 RVA: 0x004172C3 File Offset: 0x004154C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponBreachResponse.Descriptor;
			}
		}

		// Token: 0x0601C4FC RID: 115964 RVA: 0x004172CA File Offset: 0x004154CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponBreachResponse()
		{
		}

		// Token: 0x0601C4FD RID: 115965 RVA: 0x004172D2 File Offset: 0x004154D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponBreachResponse(WeaponBreachResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.incId_ = other.incId_;
			this.weaponBreach_ = other.weaponBreach_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C4FE RID: 115966 RVA: 0x0041730F File Offset: 0x0041550F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponBreachResponse Clone()
		{
			return new WeaponBreachResponse(this);
		}

		// Token: 0x17005F71 RID: 24433
		// (get) Token: 0x0601C4FF RID: 115967 RVA: 0x00417317 File Offset: 0x00415517
		// (set) Token: 0x0601C500 RID: 115968 RVA: 0x0041731F File Offset: 0x0041551F
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

		// Token: 0x17005F72 RID: 24434
		// (get) Token: 0x0601C501 RID: 115969 RVA: 0x00417328 File Offset: 0x00415528
		// (set) Token: 0x0601C502 RID: 115970 RVA: 0x00417330 File Offset: 0x00415530
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int IncId
		{
			get
			{
				return this.incId_;
			}
			set
			{
				this.incId_ = value;
			}
		}

		// Token: 0x17005F73 RID: 24435
		// (get) Token: 0x0601C503 RID: 115971 RVA: 0x00417339 File Offset: 0x00415539
		// (set) Token: 0x0601C504 RID: 115972 RVA: 0x00417341 File Offset: 0x00415541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int WeaponBreach
		{
			get
			{
				return this.weaponBreach_;
			}
			set
			{
				this.weaponBreach_ = value;
			}
		}

		// Token: 0x0601C505 RID: 115973 RVA: 0x0041734A File Offset: 0x0041554A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponBreachResponse);
		}

		// Token: 0x0601C506 RID: 115974 RVA: 0x00417358 File Offset: 0x00415558
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponBreachResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.IncId == other.IncId && this.WeaponBreach == other.WeaponBreach && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C507 RID: 115975 RVA: 0x004173B4 File Offset: 0x004155B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.IncId != 0)
			{
				num ^= this.IncId.GetHashCode();
			}
			if (this.WeaponBreach != 0)
			{
				num ^= this.WeaponBreach.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C508 RID: 115976 RVA: 0x0041742B File Offset: 0x0041562B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C509 RID: 115977 RVA: 0x00417438 File Offset: 0x00415638
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C50A RID: 115978 RVA: 0x00417444 File Offset: 0x00415644
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.IncId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.WeaponBreach != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.WeaponBreach);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C50B RID: 115979 RVA: 0x004174BC File Offset: 0x004156BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.IncId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.IncId);
			}
			if (this.WeaponBreach != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.WeaponBreach);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C50C RID: 115980 RVA: 0x0041752C File Offset: 0x0041572C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeaponBreachResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.IncId != 0)
			{
				this.IncId = other.IncId;
			}
			if (other.WeaponBreach != 0)
			{
				this.WeaponBreach = other.WeaponBreach;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C50D RID: 115981 RVA: 0x00417590 File Offset: 0x00415790
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C50E RID: 115982 RVA: 0x0041759C File Offset: 0x0041579C
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
					if (num != 56U)
					{
						if (num != 88U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.WeaponBreach = input.ReadInt32();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A235 RID: 41525
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A236 RID: 41526
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x0400A237 RID: 41527
		private ErrorCode errorCode_;

		// Token: 0x0400A238 RID: 41528
		public const int IncIdFieldNumber = 4;

		// Token: 0x0400A239 RID: 41529
		private int incId_;

		// Token: 0x0400A23A RID: 41530
		public const int WeaponBreachFieldNumber = 11;

		// Token: 0x0400A23B RID: 41531
		private int weaponBreach_;
	}
}
