using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001389 RID: 5001
	[NetMessage(EMessageId.TopPhantomEquipGroupResponse)]
	public sealed class TopPhantomEquipGroupResponse : IMessage<TopPhantomEquipGroupResponse>, IMessage, IEquatable<TopPhantomEquipGroupResponse>, IDeepCloneable<TopPhantomEquipGroupResponse>, IBufferMessage
	{
		// Token: 0x0601A8AD RID: 108717 RVA: 0x003D9EC9 File Offset: 0x003D80C9
		[NullableContext(1)]
		public static TopPhantomEquipGroupResponse Create()
		{
			return new TopPhantomEquipGroupResponse();
		}

		// Token: 0x1700597F RID: 22911
		// (get) Token: 0x0601A8AE RID: 108718 RVA: 0x003D9ED0 File Offset: 0x003D80D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005980 RID: 22912
		// (get) Token: 0x0601A8AF RID: 108719 RVA: 0x003D9ED3 File Offset: 0x003D80D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TopPhantomEquipGroupResponse.Descriptor;
			}
		}

		// Token: 0x0601A8B0 RID: 108720 RVA: 0x003D9EDA File Offset: 0x003D80DA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TopPhantomEquipGroupResponse()
		{
		}

		// Token: 0x0601A8B1 RID: 108721 RVA: 0x003D9EED File Offset: 0x003D80ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TopPhantomEquipGroupResponse(TopPhantomEquipGroupResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomEquipGroupInfos_ = other.phantomEquipGroupInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A8B2 RID: 108722 RVA: 0x003D9F23 File Offset: 0x003D8123
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TopPhantomEquipGroupResponse Clone()
		{
			return new TopPhantomEquipGroupResponse(this);
		}

		// Token: 0x17005981 RID: 22913
		// (get) Token: 0x0601A8B3 RID: 108723 RVA: 0x003D9F2B File Offset: 0x003D812B
		// (set) Token: 0x0601A8B4 RID: 108724 RVA: 0x003D9F33 File Offset: 0x003D8133
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

		// Token: 0x17005982 RID: 22914
		// (get) Token: 0x0601A8B5 RID: 108725 RVA: 0x003D9F3C File Offset: 0x003D813C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomEquipGroupInfo> PhantomEquipGroupInfos
		{
			get
			{
				return this.phantomEquipGroupInfos_;
			}
		}

		// Token: 0x0601A8B6 RID: 108726 RVA: 0x003D9F44 File Offset: 0x003D8144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TopPhantomEquipGroupResponse);
		}

		// Token: 0x0601A8B7 RID: 108727 RVA: 0x003D9F54 File Offset: 0x003D8154
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TopPhantomEquipGroupResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomEquipGroupInfos_.Equals(other.phantomEquipGroupInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A8B8 RID: 108728 RVA: 0x003D9FA4 File Offset: 0x003D81A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.phantomEquipGroupInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A8B9 RID: 108729 RVA: 0x003D9FF7 File Offset: 0x003D81F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A8BA RID: 108730 RVA: 0x003DA004 File Offset: 0x003D8204
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A8BB RID: 108731 RVA: 0x003DA010 File Offset: 0x003D8210
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomEquipGroupInfos_.WriteTo(ref output, TopPhantomEquipGroupResponse._repeated_phantomEquipGroupInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(48);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A8BC RID: 108732 RVA: 0x003DA060 File Offset: 0x003D8260
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.phantomEquipGroupInfos_.CalculateSize(TopPhantomEquipGroupResponse._repeated_phantomEquipGroupInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A8BD RID: 108733 RVA: 0x003DA0B4 File Offset: 0x003D82B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TopPhantomEquipGroupResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.phantomEquipGroupInfos_.Add(other.phantomEquipGroupInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A8BE RID: 108734 RVA: 0x003DA101 File Offset: 0x003D8301
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A8BF RID: 108735 RVA: 0x003DA10C File Offset: 0x003D830C
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
				if (num != 34U)
				{
					if (num != 48U)
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
					this.phantomEquipGroupInfos_.AddEntriesFrom(ref input, TopPhantomEquipGroupResponse._repeated_phantomEquipGroupInfos_codec);
				}
			}
		}

		// Token: 0x04009A54 RID: 39508
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009A55 RID: 39509
		public const int ErrorCodeFieldNumber = 6;

		// Token: 0x04009A56 RID: 39510
		private ErrorCode errorCode_;

		// Token: 0x04009A57 RID: 39511
		public const int PhantomEquipGroupInfosFieldNumber = 4;

		// Token: 0x04009A58 RID: 39512
		private static readonly FieldCodec<PhantomEquipGroupInfo> _repeated_phantomEquipGroupInfos_codec = FieldCodec.ForMessage<PhantomEquipGroupInfo>(34U, PhantomEquipGroupInfo.Parser);

		// Token: 0x04009A59 RID: 39513
		private readonly RepeatedField<PhantomEquipGroupInfo> phantomEquipGroupInfos_ = new RepeatedField<PhantomEquipGroupInfo>();
	}
}
