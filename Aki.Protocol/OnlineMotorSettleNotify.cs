using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000B8C RID: 2956
	[NetMessage(EMessageId.OnlineMotorSettleNotify)]
	public sealed class OnlineMotorSettleNotify : IMessage<OnlineMotorSettleNotify>, IMessage, IEquatable<OnlineMotorSettleNotify>, IDeepCloneable<OnlineMotorSettleNotify>, IBufferMessage
	{
		// Token: 0x060100DD RID: 65757 RVA: 0x00258791 File Offset: 0x00256991
		[NullableContext(1)]
		public static OnlineMotorSettleNotify Create()
		{
			return new OnlineMotorSettleNotify();
		}

		// Token: 0x1700349B RID: 13467
		// (get) Token: 0x060100DE RID: 65758 RVA: 0x00258798 File Offset: 0x00256998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700349C RID: 13468
		// (get) Token: 0x060100DF RID: 65759 RVA: 0x0025879B File Offset: 0x0025699B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return OnlineMotorSettleNotify.Descriptor;
			}
		}

		// Token: 0x060100E0 RID: 65760 RVA: 0x002587A2 File Offset: 0x002569A2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorSettleNotify()
		{
		}

		// Token: 0x060100E1 RID: 65761 RVA: 0x002587B5 File Offset: 0x002569B5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorSettleNotify(OnlineMotorSettleNotify other) : this()
		{
			this.levelId_ = other.levelId_;
			this.settleInfos_ = other.settleInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060100E2 RID: 65762 RVA: 0x002587EB File Offset: 0x002569EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public OnlineMotorSettleNotify Clone()
		{
			return new OnlineMotorSettleNotify(this);
		}

		// Token: 0x1700349D RID: 13469
		// (get) Token: 0x060100E3 RID: 65763 RVA: 0x002587F3 File Offset: 0x002569F3
		// (set) Token: 0x060100E4 RID: 65764 RVA: 0x002587FB File Offset: 0x002569FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x1700349E RID: 13470
		// (get) Token: 0x060100E5 RID: 65765 RVA: 0x00258804 File Offset: 0x00256A04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<OnlineMotorSettleInfo> SettleInfos
		{
			get
			{
				return this.settleInfos_;
			}
		}

		// Token: 0x060100E6 RID: 65766 RVA: 0x0025880C File Offset: 0x00256A0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as OnlineMotorSettleNotify);
		}

		// Token: 0x060100E7 RID: 65767 RVA: 0x0025881C File Offset: 0x00256A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(OnlineMotorSettleNotify other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && this.settleInfos_.Equals(other.settleInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060100E8 RID: 65768 RVA: 0x0025886C File Offset: 0x00256A6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			num ^= this.settleInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060100E9 RID: 65769 RVA: 0x002588B9 File Offset: 0x00256AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060100EA RID: 65770 RVA: 0x002588C6 File Offset: 0x00256AC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060100EB RID: 65771 RVA: 0x002588D0 File Offset: 0x00256AD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.LevelId);
			}
			this.settleInfos_.WriteTo(ref output, OnlineMotorSettleNotify._repeated_settleInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060100EC RID: 65772 RVA: 0x00258920 File Offset: 0x00256B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			num += this.settleInfos_.CalculateSize(OnlineMotorSettleNotify._repeated_settleInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060100ED RID: 65773 RVA: 0x00258974 File Offset: 0x00256B74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(OnlineMotorSettleNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			this.settleInfos_.Add(other.settleInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060100EE RID: 65774 RVA: 0x002589C1 File Offset: 0x00256BC1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060100EF RID: 65775 RVA: 0x002589CC File Offset: 0x00256BCC
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
				if (num != 80U)
				{
					if (num != 106U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.settleInfos_.AddEntriesFrom(ref input, OnlineMotorSettleNotify._repeated_settleInfos_codec);
					}
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040066CF RID: 26319
		private UnknownFieldSet _unknownFields;

		// Token: 0x040066D0 RID: 26320
		public const int LevelIdFieldNumber = 10;

		// Token: 0x040066D1 RID: 26321
		private int levelId_;

		// Token: 0x040066D2 RID: 26322
		public const int SettleInfosFieldNumber = 13;

		// Token: 0x040066D3 RID: 26323
		private static readonly FieldCodec<OnlineMotorSettleInfo> _repeated_settleInfos_codec = FieldCodec.ForMessage<OnlineMotorSettleInfo>(106U, OnlineMotorSettleInfo.Parser);

		// Token: 0x040066D4 RID: 26324
		private readonly RepeatedField<OnlineMotorSettleInfo> settleInfos_ = new RepeatedField<OnlineMotorSettleInfo>();
	}
}
