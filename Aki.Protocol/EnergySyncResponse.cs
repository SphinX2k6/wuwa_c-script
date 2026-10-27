using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000447 RID: 1095
	[NetMessage(EMessageId.EnergySyncResponse)]
	public sealed class EnergySyncResponse : IMessage<EnergySyncResponse>, IMessage, IEquatable<EnergySyncResponse>, IDeepCloneable<EnergySyncResponse>, IBufferMessage
	{
		// Token: 0x060068BF RID: 26815 RVA: 0x000FB919 File Offset: 0x000F9B19
		[NullableContext(1)]
		public static EnergySyncResponse Create()
		{
			return new EnergySyncResponse();
		}

		// Token: 0x170013BC RID: 5052
		// (get) Token: 0x060068C0 RID: 26816 RVA: 0x000FB920 File Offset: 0x000F9B20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170013BD RID: 5053
		// (get) Token: 0x060068C1 RID: 26817 RVA: 0x000FB923 File Offset: 0x000F9B23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return EnergySyncResponse.Descriptor;
			}
		}

		// Token: 0x060068C2 RID: 26818 RVA: 0x000FB92A File Offset: 0x000F9B2A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergySyncResponse()
		{
		}

		// Token: 0x060068C3 RID: 26819 RVA: 0x000FB93D File Offset: 0x000F9B3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergySyncResponse(EnergySyncResponse other) : this()
		{
			this.errCode_ = other.errCode_;
			this.syncInfoList_ = other.syncInfoList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060068C4 RID: 26820 RVA: 0x000FB973 File Offset: 0x000F9B73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public EnergySyncResponse Clone()
		{
			return new EnergySyncResponse(this);
		}

		// Token: 0x170013BE RID: 5054
		// (get) Token: 0x060068C5 RID: 26821 RVA: 0x000FB97B File Offset: 0x000F9B7B
		// (set) Token: 0x060068C6 RID: 26822 RVA: 0x000FB983 File Offset: 0x000F9B83
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

		// Token: 0x170013BF RID: 5055
		// (get) Token: 0x060068C7 RID: 26823 RVA: 0x000FB98C File Offset: 0x000F9B8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<EnergyInfo> SyncInfoList
		{
			get
			{
				return this.syncInfoList_;
			}
		}

		// Token: 0x060068C8 RID: 26824 RVA: 0x000FB994 File Offset: 0x000F9B94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as EnergySyncResponse);
		}

		// Token: 0x060068C9 RID: 26825 RVA: 0x000FB9A4 File Offset: 0x000F9BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(EnergySyncResponse other)
		{
			return other != null && (other == this || (this.ErrCode == other.ErrCode && this.syncInfoList_.Equals(other.syncInfoList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060068CA RID: 26826 RVA: 0x000FB9F4 File Offset: 0x000F9BF4
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

		// Token: 0x060068CB RID: 26827 RVA: 0x000FBA47 File Offset: 0x000F9C47
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060068CC RID: 26828 RVA: 0x000FBA54 File Offset: 0x000F9C54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060068CD RID: 26829 RVA: 0x000FBA60 File Offset: 0x000F9C60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.syncInfoList_.WriteTo(ref output, EnergySyncResponse._repeated_syncInfoList_codec);
			if (this.ErrCode != ErrorCode.Success)
			{
				output.WriteRawTag(104);
				output.WriteEnum((int)this.ErrCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060068CE RID: 26830 RVA: 0x000FBAB0 File Offset: 0x000F9CB0
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

		// Token: 0x060068CF RID: 26831 RVA: 0x000FBB04 File Offset: 0x000F9D04
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

		// Token: 0x060068D0 RID: 26832 RVA: 0x000FBB51 File Offset: 0x000F9D51
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060068D1 RID: 26833 RVA: 0x000FBB5C File Offset: 0x000F9D5C
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
				if (num != 42U)
				{
					if (num != 104U)
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

		// Token: 0x040039CC RID: 14796
		private UnknownFieldSet _unknownFields;

		// Token: 0x040039CD RID: 14797
		public const int ErrCodeFieldNumber = 13;

		// Token: 0x040039CE RID: 14798
		private ErrorCode errCode_;

		// Token: 0x040039CF RID: 14799
		public const int SyncInfoListFieldNumber = 5;

		// Token: 0x040039D0 RID: 14800
		private static readonly FieldCodec<EnergyInfo> _repeated_syncInfoList_codec = FieldCodec.ForMessage<EnergyInfo>(42U, EnergyInfo.Parser);

		// Token: 0x040039D1 RID: 14801
		private readonly RepeatedField<EnergyInfo> syncInfoList_ = new RepeatedField<EnergyInfo>();
	}
}
