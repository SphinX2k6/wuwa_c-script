using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001400 RID: 5120
	[NetMessage(EMessageId.TotalTopUpRewardNotify)]
	public sealed class TotalTopUpRewardNotify : IMessage<TotalTopUpRewardNotify>, IMessage, IEquatable<TotalTopUpRewardNotify>, IDeepCloneable<TotalTopUpRewardNotify>, IBufferMessage
	{
		// Token: 0x0601B38B RID: 111499 RVA: 0x003F5D44 File Offset: 0x003F3F44
		[NullableContext(1)]
		public static TotalTopUpRewardNotify Create()
		{
			return new TotalTopUpRewardNotify();
		}

		// Token: 0x17005C26 RID: 23590
		// (get) Token: 0x0601B38C RID: 111500 RVA: 0x003F5D4B File Offset: 0x003F3F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C27 RID: 23591
		// (get) Token: 0x0601B38D RID: 111501 RVA: 0x003F5D4E File Offset: 0x003F3F4E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TotalTopUpRewardNotify.Descriptor;
			}
		}

		// Token: 0x0601B38E RID: 111502 RVA: 0x003F5D55 File Offset: 0x003F3F55
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardNotify()
		{
		}

		// Token: 0x0601B38F RID: 111503 RVA: 0x003F5D68 File Offset: 0x003F3F68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardNotify(TotalTopUpRewardNotify other) : this()
		{
			this.totalTopUpRewardInfo_ = other.totalTopUpRewardInfo_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B390 RID: 111504 RVA: 0x003F5D92 File Offset: 0x003F3F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TotalTopUpRewardNotify Clone()
		{
			return new TotalTopUpRewardNotify(this);
		}

		// Token: 0x17005C28 RID: 23592
		// (get) Token: 0x0601B391 RID: 111505 RVA: 0x003F5D9A File Offset: 0x003F3F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TotalTopUpRewardInfo> TotalTopUpRewardInfo
		{
			get
			{
				return this.totalTopUpRewardInfo_;
			}
		}

		// Token: 0x0601B392 RID: 111506 RVA: 0x003F5DA2 File Offset: 0x003F3FA2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TotalTopUpRewardNotify);
		}

		// Token: 0x0601B393 RID: 111507 RVA: 0x003F5DB0 File Offset: 0x003F3FB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TotalTopUpRewardNotify other)
		{
			return other != null && (other == this || (this.totalTopUpRewardInfo_.Equals(other.totalTopUpRewardInfo_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B394 RID: 111508 RVA: 0x003F5DE4 File Offset: 0x003F3FE4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.totalTopUpRewardInfo_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B395 RID: 111509 RVA: 0x003F5E18 File Offset: 0x003F4018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B396 RID: 111510 RVA: 0x003F5E25 File Offset: 0x003F4025
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B397 RID: 111511 RVA: 0x003F5E2E File Offset: 0x003F402E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.totalTopUpRewardInfo_.WriteTo(ref output, TotalTopUpRewardNotify._repeated_totalTopUpRewardInfo_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B398 RID: 111512 RVA: 0x003F5E58 File Offset: 0x003F4058
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.totalTopUpRewardInfo_.CalculateSize(TotalTopUpRewardNotify._repeated_totalTopUpRewardInfo_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B399 RID: 111513 RVA: 0x003F5E91 File Offset: 0x003F4091
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TotalTopUpRewardNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.totalTopUpRewardInfo_.Add(other.totalTopUpRewardInfo_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B39A RID: 111514 RVA: 0x003F5EBF File Offset: 0x003F40BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B39B RID: 111515 RVA: 0x003F5EC8 File Offset: 0x003F40C8
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.totalTopUpRewardInfo_.AddEntriesFrom(ref input, TotalTopUpRewardNotify._repeated_totalTopUpRewardInfo_codec);
				}
			}
		}

		// Token: 0x04009EB5 RID: 40629
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009EB6 RID: 40630
		public const int TotalTopUpRewardInfoFieldNumber = 7;

		// Token: 0x04009EB7 RID: 40631
		private static readonly FieldCodec<TotalTopUpRewardInfo> _repeated_totalTopUpRewardInfo_codec = FieldCodec.ForMessage<TotalTopUpRewardInfo>(58U, Aki.Protocol.TotalTopUpRewardInfo.Parser);

		// Token: 0x04009EB8 RID: 40632
		private readonly RepeatedField<TotalTopUpRewardInfo> totalTopUpRewardInfo_ = new RepeatedField<TotalTopUpRewardInfo>();
	}
}
