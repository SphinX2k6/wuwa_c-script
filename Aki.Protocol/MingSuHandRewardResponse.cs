using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020009D5 RID: 2517
	[NetMessage(EMessageId.MingSuHandRewardResponse)]
	public sealed class MingSuHandRewardResponse : IMessage<MingSuHandRewardResponse>, IMessage, IEquatable<MingSuHandRewardResponse>, IDeepCloneable<MingSuHandRewardResponse>, IBufferMessage
	{
		// Token: 0x0600DCB7 RID: 56503 RVA: 0x00206684 File Offset: 0x00204884
		[NullableContext(1)]
		public static MingSuHandRewardResponse Create()
		{
			return new MingSuHandRewardResponse();
		}

		// Token: 0x17002CBE RID: 11454
		// (get) Token: 0x0600DCB8 RID: 56504 RVA: 0x0020668B File Offset: 0x0020488B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002CBF RID: 11455
		// (get) Token: 0x0600DCB9 RID: 56505 RVA: 0x0020668E File Offset: 0x0020488E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MingSuHandRewardResponse.Descriptor;
			}
		}

		// Token: 0x0600DCBA RID: 56506 RVA: 0x00206695 File Offset: 0x00204895
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MingSuHandRewardResponse()
		{
		}

		// Token: 0x0600DCBB RID: 56507 RVA: 0x0020669D File Offset: 0x0020489D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MingSuHandRewardResponse(MingSuHandRewardResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.levelGains_ = other.levelGains_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600DCBC RID: 56508 RVA: 0x002066CE File Offset: 0x002048CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MingSuHandRewardResponse Clone()
		{
			return new MingSuHandRewardResponse(this);
		}

		// Token: 0x17002CC0 RID: 11456
		// (get) Token: 0x0600DCBD RID: 56509 RVA: 0x002066D6 File Offset: 0x002048D6
		// (set) Token: 0x0600DCBE RID: 56510 RVA: 0x002066DE File Offset: 0x002048DE
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

		// Token: 0x17002CC1 RID: 11457
		// (get) Token: 0x0600DCBF RID: 56511 RVA: 0x002066E7 File Offset: 0x002048E7
		// (set) Token: 0x0600DCC0 RID: 56512 RVA: 0x002066EF File Offset: 0x002048EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelGains
		{
			get
			{
				return this.levelGains_;
			}
			set
			{
				this.levelGains_ = value;
			}
		}

		// Token: 0x0600DCC1 RID: 56513 RVA: 0x002066F8 File Offset: 0x002048F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MingSuHandRewardResponse);
		}

		// Token: 0x0600DCC2 RID: 56514 RVA: 0x00206706 File Offset: 0x00204906
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MingSuHandRewardResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.LevelGains == other.LevelGains && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600DCC3 RID: 56515 RVA: 0x00206744 File Offset: 0x00204944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.LevelGains != 0)
			{
				num ^= this.LevelGains.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600DCC4 RID: 56516 RVA: 0x002067A2 File Offset: 0x002049A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600DCC5 RID: 56517 RVA: 0x002067AF File Offset: 0x002049AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600DCC6 RID: 56518 RVA: 0x002067B8 File Offset: 0x002049B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelGains != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.LevelGains);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600DCC7 RID: 56519 RVA: 0x00206810 File Offset: 0x00204A10
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.LevelGains != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelGains);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600DCC8 RID: 56520 RVA: 0x00206868 File Offset: 0x00204A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MingSuHandRewardResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.LevelGains != 0)
			{
				this.LevelGains = other.LevelGains;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600DCC9 RID: 56521 RVA: 0x002068B8 File Offset: 0x00204AB8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600DCCA RID: 56522 RVA: 0x002068C4 File Offset: 0x00204AC4
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
				if (num != 8U)
				{
					if (num != 112U)
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
					this.LevelGains = input.ReadInt32();
				}
			}
		}

		// Token: 0x04005B65 RID: 23397
		private UnknownFieldSet _unknownFields;

		// Token: 0x04005B66 RID: 23398
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04005B67 RID: 23399
		private ErrorCode errorCode_;

		// Token: 0x04005B68 RID: 23400
		public const int LevelGainsFieldNumber = 1;

		// Token: 0x04005B69 RID: 23401
		private int levelGains_;
	}
}
