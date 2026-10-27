using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000388 RID: 904
	[NetMessage(EMessageId.DangoMonopolyGridRewardResponse)]
	public sealed class DangoMonopolyGridRewardResponse : IMessage<DangoMonopolyGridRewardResponse>, IMessage, IEquatable<DangoMonopolyGridRewardResponse>, IDeepCloneable<DangoMonopolyGridRewardResponse>, IBufferMessage
	{
		// Token: 0x0600596D RID: 22893 RVA: 0x000D9D25 File Offset: 0x000D7F25
		[NullableContext(1)]
		public static DangoMonopolyGridRewardResponse Create()
		{
			return new DangoMonopolyGridRewardResponse();
		}

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x0600596E RID: 22894 RVA: 0x000D9D2C File Offset: 0x000D7F2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x0600596F RID: 22895 RVA: 0x000D9D2F File Offset: 0x000D7F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return DangoMonopolyGridRewardResponse.Descriptor;
			}
		}

		// Token: 0x06005970 RID: 22896 RVA: 0x000D9D36 File Offset: 0x000D7F36
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyGridRewardResponse()
		{
		}

		// Token: 0x06005971 RID: 22897 RVA: 0x000D9D3E File Offset: 0x000D7F3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyGridRewardResponse(DangoMonopolyGridRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.hasReward_ = other.hasReward_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06005972 RID: 22898 RVA: 0x000D9D6F File Offset: 0x000D7F6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DangoMonopolyGridRewardResponse Clone()
		{
			return new DangoMonopolyGridRewardResponse(this);
		}

		// Token: 0x17001081 RID: 4225
		// (get) Token: 0x06005973 RID: 22899 RVA: 0x000D9D77 File Offset: 0x000D7F77
		// (set) Token: 0x06005974 RID: 22900 RVA: 0x000D9D7F File Offset: 0x000D7F7F
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

		// Token: 0x17001082 RID: 4226
		// (get) Token: 0x06005975 RID: 22901 RVA: 0x000D9D88 File Offset: 0x000D7F88
		// (set) Token: 0x06005976 RID: 22902 RVA: 0x000D9D90 File Offset: 0x000D7F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool HasReward
		{
			get
			{
				return this.hasReward_;
			}
			set
			{
				this.hasReward_ = value;
			}
		}

		// Token: 0x06005977 RID: 22903 RVA: 0x000D9D99 File Offset: 0x000D7F99
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as DangoMonopolyGridRewardResponse);
		}

		// Token: 0x06005978 RID: 22904 RVA: 0x000D9DA7 File Offset: 0x000D7FA7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(DangoMonopolyGridRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.HasReward == other.HasReward && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06005979 RID: 22905 RVA: 0x000D9DE8 File Offset: 0x000D7FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.HasReward)
			{
				num ^= this.HasReward.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600597A RID: 22906 RVA: 0x000D9E46 File Offset: 0x000D8046
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600597B RID: 22907 RVA: 0x000D9E53 File Offset: 0x000D8053
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600597C RID: 22908 RVA: 0x000D9E5C File Offset: 0x000D805C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HasReward)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.HasReward);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600597D RID: 22909 RVA: 0x000D9EB8 File Offset: 0x000D80B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.HasReward)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600597E RID: 22910 RVA: 0x000D9F04 File Offset: 0x000D8104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(DangoMonopolyGridRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.HasReward)
			{
				this.HasReward = other.HasReward;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600597F RID: 22911 RVA: 0x000D9F54 File Offset: 0x000D8154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06005980 RID: 22912 RVA: 0x000D9F60 File Offset: 0x000D8160
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
				if (num != 56U)
				{
					if (num != 80U)
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
					this.HasReward = input.ReadBool();
				}
			}
		}

		// Token: 0x04003564 RID: 13668
		private UnknownFieldSet _unknownFields;

		// Token: 0x04003565 RID: 13669
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04003566 RID: 13670
		private ErrorCode errorCode_;

		// Token: 0x04003567 RID: 13671
		public const int HasRewardFieldNumber = 7;

		// Token: 0x04003568 RID: 13672
		private bool hasReward_;
	}
}
