using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200052A RID: 1322
	[NetMessage(EMessageId.FarmGoldResultNotify)]
	public sealed class FarmGoldResultNotify : IMessage<FarmGoldResultNotify>, IMessage, IEquatable<FarmGoldResultNotify>, IDeepCloneable<FarmGoldResultNotify>, IBufferMessage
	{
		// Token: 0x06007BF2 RID: 31730 RVA: 0x0012C709 File Offset: 0x0012A909
		[NullableContext(1)]
		public static FarmGoldResultNotify Create()
		{
			return new FarmGoldResultNotify();
		}

		// Token: 0x1700180B RID: 6155
		// (get) Token: 0x06007BF3 RID: 31731 RVA: 0x0012C710 File Offset: 0x0012A910
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700180C RID: 6156
		// (get) Token: 0x06007BF4 RID: 31732 RVA: 0x0012C713 File Offset: 0x0012A913
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FarmGoldResultNotify.Descriptor;
			}
		}

		// Token: 0x06007BF5 RID: 31733 RVA: 0x0012C71A File Offset: 0x0012A91A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldResultNotify()
		{
		}

		// Token: 0x06007BF6 RID: 31734 RVA: 0x0012C724 File Offset: 0x0012A924
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldResultNotify(FarmGoldResultNotify other) : this()
		{
			this.succ_ = other.succ_;
			this.curPoint_ = other.curPoint_;
			this.hisPoint_ = other.hisPoint_;
			this.errorCode_ = other.errorCode_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06007BF7 RID: 31735 RVA: 0x0012C778 File Offset: 0x0012A978
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FarmGoldResultNotify Clone()
		{
			return new FarmGoldResultNotify(this);
		}

		// Token: 0x1700180D RID: 6157
		// (get) Token: 0x06007BF8 RID: 31736 RVA: 0x0012C780 File Offset: 0x0012A980
		// (set) Token: 0x06007BF9 RID: 31737 RVA: 0x0012C788 File Offset: 0x0012A988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Succ
		{
			get
			{
				return this.succ_;
			}
			set
			{
				this.succ_ = value;
			}
		}

		// Token: 0x1700180E RID: 6158
		// (get) Token: 0x06007BFA RID: 31738 RVA: 0x0012C791 File Offset: 0x0012A991
		// (set) Token: 0x06007BFB RID: 31739 RVA: 0x0012C799 File Offset: 0x0012A999
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurPoint
		{
			get
			{
				return this.curPoint_;
			}
			set
			{
				this.curPoint_ = value;
			}
		}

		// Token: 0x1700180F RID: 6159
		// (get) Token: 0x06007BFC RID: 31740 RVA: 0x0012C7A2 File Offset: 0x0012A9A2
		// (set) Token: 0x06007BFD RID: 31741 RVA: 0x0012C7AA File Offset: 0x0012A9AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HisPoint
		{
			get
			{
				return this.hisPoint_;
			}
			set
			{
				this.hisPoint_ = value;
			}
		}

		// Token: 0x17001810 RID: 6160
		// (get) Token: 0x06007BFE RID: 31742 RVA: 0x0012C7B3 File Offset: 0x0012A9B3
		// (set) Token: 0x06007BFF RID: 31743 RVA: 0x0012C7BB File Offset: 0x0012A9BB
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

		// Token: 0x06007C00 RID: 31744 RVA: 0x0012C7C4 File Offset: 0x0012A9C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FarmGoldResultNotify);
		}

		// Token: 0x06007C01 RID: 31745 RVA: 0x0012C7D4 File Offset: 0x0012A9D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FarmGoldResultNotify other)
		{
			return other != null && (other == this || (this.Succ == other.Succ && this.CurPoint == other.CurPoint && this.HisPoint == other.HisPoint && this.ErrorCode == other.ErrorCode && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06007C02 RID: 31746 RVA: 0x0012C840 File Offset: 0x0012AA40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Succ)
			{
				num ^= this.Succ.GetHashCode();
			}
			if (this.CurPoint != 0)
			{
				num ^= this.CurPoint.GetHashCode();
			}
			if (this.HisPoint != 0)
			{
				num ^= this.HisPoint.GetHashCode();
			}
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

		// Token: 0x06007C03 RID: 31747 RVA: 0x0012C8D0 File Offset: 0x0012AAD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06007C04 RID: 31748 RVA: 0x0012C8DD File Offset: 0x0012AADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06007C05 RID: 31749 RVA: 0x0012C8E8 File Offset: 0x0012AAE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurPoint != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.CurPoint);
			}
			if (this.Succ)
			{
				output.WriteRawTag(40);
				output.WriteBool(this.Succ);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.HisPoint != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.HisPoint);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06007C06 RID: 31750 RVA: 0x0012C97C File Offset: 0x0012AB7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Succ)
			{
				num += 2;
			}
			if (this.CurPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurPoint);
			}
			if (this.HisPoint != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HisPoint);
			}
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

		// Token: 0x06007C07 RID: 31751 RVA: 0x0012C9F8 File Offset: 0x0012ABF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FarmGoldResultNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Succ)
			{
				this.Succ = other.Succ;
			}
			if (other.CurPoint != 0)
			{
				this.CurPoint = other.CurPoint;
			}
			if (other.HisPoint != 0)
			{
				this.HisPoint = other.HisPoint;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06007C08 RID: 31752 RVA: 0x0012CA70 File Offset: 0x0012AC70
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06007C09 RID: 31753 RVA: 0x0012CA7C File Offset: 0x0012AC7C
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
				if (num <= 40U)
				{
					if (num == 24U)
					{
						this.CurPoint = input.ReadInt32();
						continue;
					}
					if (num == 40U)
					{
						this.Succ = input.ReadBool();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 88U)
					{
						this.HisPoint = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04003F4C RID: 16204
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003F4D RID: 16205
		public const int SuccFieldNumber = 5;

		// Token: 0x04003F4E RID: 16206
		private bool succ_;

		// Token: 0x04003F4F RID: 16207
		public const int CurPointFieldNumber = 3;

		// Token: 0x04003F50 RID: 16208
		private int curPoint_;

		// Token: 0x04003F51 RID: 16209
		public const int HisPointFieldNumber = 11;

		// Token: 0x04003F52 RID: 16210
		private int hisPoint_;

		// Token: 0x04003F53 RID: 16211
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04003F54 RID: 16212
		private ErrorCode errorCode_;
	}
}
