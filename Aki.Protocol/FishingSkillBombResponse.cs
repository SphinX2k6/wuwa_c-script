using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000572 RID: 1394
	[NetMessage(EMessageId.FishingSkillBombResponse)]
	public sealed class FishingSkillBombResponse : IMessage<FishingSkillBombResponse>, IMessage, IEquatable<FishingSkillBombResponse>, IDeepCloneable<FishingSkillBombResponse>, IBufferMessage
	{
		// Token: 0x060081E8 RID: 33256 RVA: 0x00139A99 File Offset: 0x00137C99
		[NullableContext(1)]
		public static FishingSkillBombResponse Create()
		{
			return new FishingSkillBombResponse();
		}

		// Token: 0x1700194A RID: 6474
		// (get) Token: 0x060081E9 RID: 33257 RVA: 0x00139AA0 File Offset: 0x00137CA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700194B RID: 6475
		// (get) Token: 0x060081EA RID: 33258 RVA: 0x00139AA3 File Offset: 0x00137CA3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FishingSkillBombResponse.Descriptor;
			}
		}

		// Token: 0x060081EB RID: 33259 RVA: 0x00139AAA File Offset: 0x00137CAA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBombResponse()
		{
		}

		// Token: 0x060081EC RID: 33260 RVA: 0x00139ABD File Offset: 0x00137CBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBombResponse(FishingSkillBombResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.items_ = other.items_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060081ED RID: 33261 RVA: 0x00139AF3 File Offset: 0x00137CF3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FishingSkillBombResponse Clone()
		{
			return new FishingSkillBombResponse(this);
		}

		// Token: 0x1700194C RID: 6476
		// (get) Token: 0x060081EE RID: 33262 RVA: 0x00139AFB File Offset: 0x00137CFB
		// (set) Token: 0x060081EF RID: 33263 RVA: 0x00139B03 File Offset: 0x00137D03
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

		// Token: 0x1700194D RID: 6477
		// (get) Token: 0x060081F0 RID: 33264 RVA: 0x00139B0C File Offset: 0x00137D0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FishingItemInfo> Items
		{
			get
			{
				return this.items_;
			}
		}

		// Token: 0x060081F1 RID: 33265 RVA: 0x00139B14 File Offset: 0x00137D14
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FishingSkillBombResponse);
		}

		// Token: 0x060081F2 RID: 33266 RVA: 0x00139B24 File Offset: 0x00137D24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FishingSkillBombResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.items_.Equals(other.items_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060081F3 RID: 33267 RVA: 0x00139B74 File Offset: 0x00137D74
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.items_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060081F4 RID: 33268 RVA: 0x00139BC7 File Offset: 0x00137DC7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060081F5 RID: 33269 RVA: 0x00139BD4 File Offset: 0x00137DD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060081F6 RID: 33270 RVA: 0x00139BE0 File Offset: 0x00137DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.items_.WriteTo(ref output, FishingSkillBombResponse._repeated_items_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060081F7 RID: 33271 RVA: 0x00139C30 File Offset: 0x00137E30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.items_.CalculateSize(FishingSkillBombResponse._repeated_items_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060081F8 RID: 33272 RVA: 0x00139C84 File Offset: 0x00137E84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FishingSkillBombResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.items_.Add(other.items_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060081F9 RID: 33273 RVA: 0x00139CD1 File Offset: 0x00137ED1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060081FA RID: 33274 RVA: 0x00139CDC File Offset: 0x00137EDC
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
				if (num != 24U)
				{
					if (num != 90U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.items_.AddEntriesFrom(ref input, FishingSkillBombResponse._repeated_items_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04004168 RID: 16744
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004169 RID: 16745
		public const int ErrorCodeFieldNumber = 3;

		// Token: 0x0400416A RID: 16746
		private ErrorCode errorCode_;

		// Token: 0x0400416B RID: 16747
		public const int ItemsFieldNumber = 11;

		// Token: 0x0400416C RID: 16748
		private static readonly FieldCodec<FishingItemInfo> _repeated_items_codec = FieldCodec.ForMessage<FishingItemInfo>(90U, FishingItemInfo.Parser);

		// Token: 0x0400416D RID: 16749
		private readonly RepeatedField<FishingItemInfo> items_ = new RepeatedField<FishingItemInfo>();
	}
}
