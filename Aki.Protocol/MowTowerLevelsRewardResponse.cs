using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000ACF RID: 2767
	[NetMessage(EMessageId.MowTowerLevelsRewardResponse)]
	public sealed class MowTowerLevelsRewardResponse : IMessage<MowTowerLevelsRewardResponse>, IMessage, IEquatable<MowTowerLevelsRewardResponse>, IDeepCloneable<MowTowerLevelsRewardResponse>, IBufferMessage
	{
		// Token: 0x0600F0E7 RID: 61671 RVA: 0x00233350 File Offset: 0x00231550
		[NullableContext(1)]
		public static MowTowerLevelsRewardResponse Create()
		{
			return new MowTowerLevelsRewardResponse();
		}

		// Token: 0x17003110 RID: 12560
		// (get) Token: 0x0600F0E8 RID: 61672 RVA: 0x00233357 File Offset: 0x00231557
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003111 RID: 12561
		// (get) Token: 0x0600F0E9 RID: 61673 RVA: 0x0023335A File Offset: 0x0023155A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MowTowerLevelsRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600F0EA RID: 61674 RVA: 0x00233361 File Offset: 0x00231561
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsRewardResponse()
		{
		}

		// Token: 0x0600F0EB RID: 61675 RVA: 0x00233369 File Offset: 0x00231569
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsRewardResponse(MowTowerLevelsRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600F0EC RID: 61676 RVA: 0x0023338E File Offset: 0x0023158E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MowTowerLevelsRewardResponse Clone()
		{
			return new MowTowerLevelsRewardResponse(this);
		}

		// Token: 0x17003112 RID: 12562
		// (get) Token: 0x0600F0ED RID: 61677 RVA: 0x00233396 File Offset: 0x00231596
		// (set) Token: 0x0600F0EE RID: 61678 RVA: 0x0023339E File Offset: 0x0023159E
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

		// Token: 0x0600F0EF RID: 61679 RVA: 0x002333A7 File Offset: 0x002315A7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MowTowerLevelsRewardResponse);
		}

		// Token: 0x0600F0F0 RID: 61680 RVA: 0x002333B5 File Offset: 0x002315B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MowTowerLevelsRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600F0F1 RID: 61681 RVA: 0x002333E4 File Offset: 0x002315E4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600F0F2 RID: 61682 RVA: 0x00233429 File Offset: 0x00231629
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600F0F3 RID: 61683 RVA: 0x00233436 File Offset: 0x00231636
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600F0F4 RID: 61684 RVA: 0x0023343F File Offset: 0x0023163F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600F0F5 RID: 61685 RVA: 0x00233474 File Offset: 0x00231674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600F0F6 RID: 61686 RVA: 0x002334B2 File Offset: 0x002316B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MowTowerLevelsRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600F0F7 RID: 61687 RVA: 0x002334E3 File Offset: 0x002316E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600F0F8 RID: 61688 RVA: 0x002334EC File Offset: 0x002316EC
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
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006162 RID: 24930
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006163 RID: 24931
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04006164 RID: 24932
		private ErrorCode errorCode_;
	}
}
