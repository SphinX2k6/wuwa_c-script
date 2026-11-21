using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001226 RID: 4646
	public sealed class ShieldInfoPb : IMessage<ShieldInfoPb>, IMessage, IEquatable<ShieldInfoPb>, IDeepCloneable<ShieldInfoPb>, IBufferMessage
	{
		// Token: 0x06018CF4 RID: 101620 RVA: 0x0039DACC File Offset: 0x0039BCCC
		[NullableContext(1)]
		public static ShieldInfoPb Create()
		{
			return new ShieldInfoPb();
		}

		// Token: 0x170053C7 RID: 21447
		// (get) Token: 0x06018CF5 RID: 101621 RVA: 0x0039DAD3 File Offset: 0x0039BCD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<ShieldInfoPb> Parser
		{
			get
			{
				return ShieldInfoPb._parser;
			}
		}

		// Token: 0x170053C8 RID: 21448
		// (get) Token: 0x06018CF6 RID: 101622 RVA: 0x0039DADA File Offset: 0x0039BCDA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170053C9 RID: 21449
		// (get) Token: 0x06018CF7 RID: 101623 RVA: 0x0039DADD File Offset: 0x0039BCDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ShieldInfoPb.Descriptor;
			}
		}

		// Token: 0x06018CF8 RID: 101624 RVA: 0x0039DAE4 File Offset: 0x0039BCE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldInfoPb()
		{
		}

		// Token: 0x06018CF9 RID: 101625 RVA: 0x0039DAEC File Offset: 0x0039BCEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldInfoPb(ShieldInfoPb other) : this()
		{
			this.handle_ = other.handle_;
			this.configId_ = other.configId_;
			this.shieldValue_ = other.shieldValue_;
			this.priority_ = other.priority_;
			this.buffHandle_ = other.buffHandle_;
			this.isValid_ = other.isValid_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06018CFA RID: 101626 RVA: 0x0039DB58 File Offset: 0x0039BD58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ShieldInfoPb Clone()
		{
			return new ShieldInfoPb(this);
		}

		// Token: 0x170053CA RID: 21450
		// (get) Token: 0x06018CFB RID: 101627 RVA: 0x0039DB60 File Offset: 0x0039BD60
		// (set) Token: 0x06018CFC RID: 101628 RVA: 0x0039DB68 File Offset: 0x0039BD68
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

		// Token: 0x170053CB RID: 21451
		// (get) Token: 0x06018CFD RID: 101629 RVA: 0x0039DB71 File Offset: 0x0039BD71
		// (set) Token: 0x06018CFE RID: 101630 RVA: 0x0039DB79 File Offset: 0x0039BD79
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

		// Token: 0x170053CC RID: 21452
		// (get) Token: 0x06018CFF RID: 101631 RVA: 0x0039DB82 File Offset: 0x0039BD82
		// (set) Token: 0x06018D00 RID: 101632 RVA: 0x0039DB8A File Offset: 0x0039BD8A
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

		// Token: 0x170053CD RID: 21453
		// (get) Token: 0x06018D01 RID: 101633 RVA: 0x0039DB93 File Offset: 0x0039BD93
		// (set) Token: 0x06018D02 RID: 101634 RVA: 0x0039DB9B File Offset: 0x0039BD9B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Priority
		{
			get
			{
				return this.priority_;
			}
			set
			{
				this.priority_ = value;
			}
		}

		// Token: 0x170053CE RID: 21454
		// (get) Token: 0x06018D03 RID: 101635 RVA: 0x0039DBA4 File Offset: 0x0039BDA4
		// (set) Token: 0x06018D04 RID: 101636 RVA: 0x0039DBAC File Offset: 0x0039BDAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int BuffHandle
		{
			get
			{
				return this.buffHandle_;
			}
			set
			{
				this.buffHandle_ = value;
			}
		}

		// Token: 0x170053CF RID: 21455
		// (get) Token: 0x06018D05 RID: 101637 RVA: 0x0039DBB5 File Offset: 0x0039BDB5
		// (set) Token: 0x06018D06 RID: 101638 RVA: 0x0039DBBD File Offset: 0x0039BDBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsValid
		{
			get
			{
				return this.isValid_;
			}
			set
			{
				this.isValid_ = value;
			}
		}

		// Token: 0x06018D07 RID: 101639 RVA: 0x0039DBC6 File Offset: 0x0039BDC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ShieldInfoPb);
		}

		// Token: 0x06018D08 RID: 101640 RVA: 0x0039DBD4 File Offset: 0x0039BDD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ShieldInfoPb other)
		{
			return other != null && (other == this || (this.Handle == other.Handle && this.ConfigId == other.ConfigId && this.ShieldValue == other.ShieldValue && this.Priority == other.Priority && this.BuffHandle == other.BuffHandle && this.IsValid == other.IsValid && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018D09 RID: 101641 RVA: 0x0039DC60 File Offset: 0x0039BE60
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
			if (this.Priority != 0)
			{
				num ^= this.Priority.GetHashCode();
			}
			if (this.BuffHandle != 0)
			{
				num ^= this.BuffHandle.GetHashCode();
			}
			if (this.IsValid)
			{
				num ^= this.IsValid.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018D0A RID: 101642 RVA: 0x0039DD1C File Offset: 0x0039BF1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018D0B RID: 101643 RVA: 0x0039DD29 File Offset: 0x0039BF29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06018D0C RID: 101644 RVA: 0x0039DD34 File Offset: 0x0039BF34
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
			if (this.Priority != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.Priority);
			}
			if (this.BuffHandle != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.BuffHandle);
			}
			if (this.IsValid)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsValid);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06018D0D RID: 101645 RVA: 0x0039DDFC File Offset: 0x0039BFFC
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
			if (this.Priority != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Priority);
			}
			if (this.BuffHandle != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.BuffHandle);
			}
			if (this.IsValid)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06018D0E RID: 101646 RVA: 0x0039DEA8 File Offset: 0x0039C0A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ShieldInfoPb other)
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
			if (other.Priority != 0)
			{
				this.Priority = other.Priority;
			}
			if (other.BuffHandle != 0)
			{
				this.BuffHandle = other.BuffHandle;
			}
			if (other.IsValid)
			{
				this.IsValid = other.IsValid;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06018D0F RID: 101647 RVA: 0x0039DF48 File Offset: 0x0039C148
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06018D10 RID: 101648 RVA: 0x0039DF54 File Offset: 0x0039C154
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
				if (num <= 24U)
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
					if (num == 24U)
					{
						this.ShieldValue = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 32U)
					{
						this.Priority = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.BuffHandle = input.ReadInt32();
						continue;
					}
					if (num == 48U)
					{
						this.IsValid = input.ReadBool();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009330 RID: 37680
		private static readonly MessageParser<ShieldInfoPb> _parser = new MessageParser<ShieldInfoPb>(() => new ShieldInfoPb());

		// Token: 0x04009331 RID: 37681
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009332 RID: 37682
		public const int HandleFieldNumber = 1;

		// Token: 0x04009333 RID: 37683
		private int handle_;

		// Token: 0x04009334 RID: 37684
		public const int ConfigIdFieldNumber = 2;

		// Token: 0x04009335 RID: 37685
		private int configId_;

		// Token: 0x04009336 RID: 37686
		public const int ShieldValueFieldNumber = 3;

		// Token: 0x04009337 RID: 37687
		private int shieldValue_;

		// Token: 0x04009338 RID: 37688
		public const int PriorityFieldNumber = 4;

		// Token: 0x04009339 RID: 37689
		private int priority_;

		// Token: 0x0400933A RID: 37690
		public const int BuffHandleFieldNumber = 5;

		// Token: 0x0400933B RID: 37691
		private int buffHandle_;

		// Token: 0x0400933C RID: 37692
		public const int IsValidFieldNumber = 6;

		// Token: 0x0400933D RID: 37693
		private bool isValid_;
	}
}
