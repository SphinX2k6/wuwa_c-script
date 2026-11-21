using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001561 RID: 5473
	[NetMessage(EMessageId.WeaponBreachResponse)]
	public sealed class WeaponBreachResponse : IMessage<WeaponBreachResponse>, IMessage, IEquatable<WeaponBreachResponse>, IDeepCloneable<WeaponBreachResponse>, IBufferMessage
	{
		// Token: 0x0601CFC0 RID: 118720 RVA: 0x00432D75 File Offset: 0x00430F75
		[NullableContext(1)]
		public static WeaponBreachResponse Create()
		{
			return new WeaponBreachResponse();
		}

		// Token: 0x17006210 RID: 25104
		// (get) Token: 0x0601CFC1 RID: 118721 RVA: 0x00432D7C File Offset: 0x00430F7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006211 RID: 25105
		// (get) Token: 0x0601CFC2 RID: 118722 RVA: 0x00432D7F File Offset: 0x00430F7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeaponBreachResponse.Descriptor;
			}
		}

		// Token: 0x0601CFC3 RID: 118723 RVA: 0x00432D86 File Offset: 0x00430F86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponBreachResponse()
		{
		}

		// Token: 0x0601CFC4 RID: 118724 RVA: 0x00432D8E File Offset: 0x00430F8E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponBreachResponse(WeaponBreachResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.incId_ = other.incId_;
			this.weaponBreach_ = other.weaponBreach_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601CFC5 RID: 118725 RVA: 0x00432DCB File Offset: 0x00430FCB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeaponBreachResponse Clone()
		{
			return new WeaponBreachResponse(this);
		}

		// Token: 0x17006212 RID: 25106
		// (get) Token: 0x0601CFC6 RID: 118726 RVA: 0x00432DD3 File Offset: 0x00430FD3
		// (set) Token: 0x0601CFC7 RID: 118727 RVA: 0x00432DDB File Offset: 0x00430FDB
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

		// Token: 0x17006213 RID: 25107
		// (get) Token: 0x0601CFC8 RID: 118728 RVA: 0x00432DE4 File Offset: 0x00430FE4
		// (set) Token: 0x0601CFC9 RID: 118729 RVA: 0x00432DEC File Offset: 0x00430FEC
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

		// Token: 0x17006214 RID: 25108
		// (get) Token: 0x0601CFCA RID: 118730 RVA: 0x00432DF5 File Offset: 0x00430FF5
		// (set) Token: 0x0601CFCB RID: 118731 RVA: 0x00432DFD File Offset: 0x00430FFD
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

		// Token: 0x0601CFCC RID: 118732 RVA: 0x00432E06 File Offset: 0x00431006
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeaponBreachResponse);
		}

		// Token: 0x0601CFCD RID: 118733 RVA: 0x00432E14 File Offset: 0x00431014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeaponBreachResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.IncId == other.IncId && this.WeaponBreach == other.WeaponBreach && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601CFCE RID: 118734 RVA: 0x00432E70 File Offset: 0x00431070
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

		// Token: 0x0601CFCF RID: 118735 RVA: 0x00432EE7 File Offset: 0x004310E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601CFD0 RID: 118736 RVA: 0x00432EF4 File Offset: 0x004310F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601CFD1 RID: 118737 RVA: 0x00432F00 File Offset: 0x00431100
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IncId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.IncId);
			}
			if (this.WeaponBreach != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.WeaponBreach);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601CFD2 RID: 118738 RVA: 0x00432F78 File Offset: 0x00431178
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

		// Token: 0x0601CFD3 RID: 118739 RVA: 0x00432FE8 File Offset: 0x004311E8
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

		// Token: 0x0601CFD4 RID: 118740 RVA: 0x0043304C File Offset: 0x0043124C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601CFD5 RID: 118741 RVA: 0x00433058 File Offset: 0x00431258
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
					if (num != 96U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorCode = (ErrorCode)input.ReadEnum();
						}
					}
					else
					{
						this.WeaponBreach = input.ReadInt32();
					}
				}
				else
				{
					this.IncId = input.ReadInt32();
				}
			}
		}

		// Token: 0x0400A68E RID: 42638
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A68F RID: 42639
		public const int ErrorCodeFieldNumber = 13;

		// Token: 0x0400A690 RID: 42640
		private ErrorCode errorCode_;

		// Token: 0x0400A691 RID: 42641
		public const int IncIdFieldNumber = 4;

		// Token: 0x0400A692 RID: 42642
		private int incId_;

		// Token: 0x0400A693 RID: 42643
		public const int WeaponBreachFieldNumber = 12;

		// Token: 0x0400A694 RID: 42644
		private int weaponBreach_;
	}
}
