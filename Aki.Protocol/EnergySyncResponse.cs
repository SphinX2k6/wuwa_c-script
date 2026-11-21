using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000430 RID: 1072
	[NetMessage(EMessageId.EnergySyncResponse)]
	public sealed class EnergySyncResponse : IMessage<EnergySyncResponse>, IMessage, IEquatable<EnergySyncResponse>, IDeepCloneable<EnergySyncResponse>, IBufferMessage
	{
		// Token: 0x0600672F RID: 26415 RVA: 0x000F878D File Offset: 0x000F698D
		[NullableContext(1)]
		public static EnergySyncResponse Create()
		{
			return new EnergySyncResponse();
		}

		// Token: 0x17001367 RID: 4967
		// (get) Token: 0x06006730 RID: 26416 RVA: 0x000F8794 File Offset: 0x000F6994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001368 RID: 4968
		// (get) Token: 0x06006731 RID: 26417 RVA: 0x000F8797 File Offset: 0x000F6997
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnergySyncResponse.Descriptor;
			}
		}

		// Token: 0x06006732 RID: 26418 RVA: 0x000F879E File Offset: 0x000F699E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergySyncResponse()
		{
		}

		// Token: 0x06006733 RID: 26419 RVA: 0x000F87B1 File Offset: 0x000F69B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergySyncResponse(EnergySyncResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.syncInfoList_ = other.syncInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06006734 RID: 26420 RVA: 0x000F87E7 File Offset: 0x000F69E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergySyncResponse Clone()
		{
			return new EnergySyncResponse(this);
		}

		// Token: 0x17001369 RID: 4969
		// (get) Token: 0x06006735 RID: 26421 RVA: 0x000F87EF File Offset: 0x000F69EF
		// (set) Token: 0x06006736 RID: 26422 RVA: 0x000F87F7 File Offset: 0x000F69F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrCode
		{
			get
			{
				return this.errCode_;
			}
			set
			{
				this.errCode_ = value;
			}
		}

		// Token: 0x1700136A RID: 4970
		// (get) Token: 0x06006737 RID: 26423 RVA: 0x000F8800 File Offset: 0x000F6A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EnergyInfo> SyncInfoList
		{
			get
			{
				return this.syncInfoList_;
			}
		}

		// Token: 0x06006738 RID: 26424 RVA: 0x000F8808 File Offset: 0x000F6A08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnergySyncResponse);
		}

		// Token: 0x06006739 RID: 26425 RVA: 0x000F8818 File Offset: 0x000F6A18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnergySyncResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.syncInfoList_.Equals(other.syncInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600673A RID: 26426 RVA: 0x000F8868 File Offset: 0x000F6A68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrCode != ErrorCode.Success)
			{
				num ^= this.ErrCode.GetHashCode();
			}
			num ^= this.syncInfoList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600673B RID: 26427 RVA: 0x000F88BB File Offset: 0x000F6ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600673C RID: 26428 RVA: 0x000F88C8 File Offset: 0x000F6AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600673D RID: 26429 RVA: 0x000F88D4 File Offset: 0x000F6AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.syncInfoList_.WriteTo(ref output, EnergySyncResponse._repeated_syncInfoList_codec);
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600673E RID: 26430 RVA: 0x000F8924 File Offset: 0x000F6B24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrCode);
			}
			num += this.syncInfoList_.CalculateSize(EnergySyncResponse._repeated_syncInfoList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600673F RID: 26431 RVA: 0x000F8978 File Offset: 0x000F6B78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(EnergySyncResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrCode != ErrorCode.Success)
			{
				this.ErrCode = other.ErrCode;
			}
			this.syncInfoList_.Add(other.syncInfoList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06006740 RID: 26432 RVA: 0x000F89C5 File Offset: 0x000F6BC5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06006741 RID: 26433 RVA: 0x000F89D0 File Offset: 0x000F6BD0
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
				if (num != 26U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.ErrCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.syncInfoList_.AddEntriesFrom(ref input, EnergySyncResponse._repeated_syncInfoList_codec);
				}
			}
		}

		// Token: 0x040039B9 RID: 14777
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039BA RID: 14778
		public const int ErrCodeFieldNumber = 7;

		// Token: 0x040039BB RID: 14779
		private ErrorCode errCode_;

		// Token: 0x040039BC RID: 14780
		public const int SyncInfoListFieldNumber = 3;

		// Token: 0x040039BD RID: 14781
		private static readonly FieldCodec<EnergyInfo> _repeated_syncInfoList_codec = FieldCodec.ForMessage<EnergyInfo>(26U, EnergyInfo.Parser);

		// Token: 0x040039BE RID: 14782
		private readonly RepeatedField<EnergyInfo> syncInfoList_ = new RepeatedField<EnergyInfo>();
	}
}
