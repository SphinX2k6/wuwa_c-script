using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000CBE RID: 3262
	[NetMessage(EMessageId.PhantomEquipGroupInfosResponse)]
	public sealed class PhantomEquipGroupInfosResponse : IMessage<PhantomEquipGroupInfosResponse>, IMessage, IEquatable<PhantomEquipGroupInfosResponse>, IDeepCloneable<PhantomEquipGroupInfosResponse>, IBufferMessage
	{
		// Token: 0x06011AEA RID: 72426 RVA: 0x00296F0D File Offset: 0x0029510D
		[NullableContext(1)]
		public static PhantomEquipGroupInfosResponse Create()
		{
			return new PhantomEquipGroupInfosResponse();
		}

		// Token: 0x17003A93 RID: 14995
		// (get) Token: 0x06011AEB RID: 72427 RVA: 0x00296F14 File Offset: 0x00295114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003A94 RID: 14996
		// (get) Token: 0x06011AEC RID: 72428 RVA: 0x00296F17 File Offset: 0x00295117
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomEquipGroupInfosResponse.Descriptor;
			}
		}

		// Token: 0x06011AED RID: 72429 RVA: 0x00296F1E File Offset: 0x0029511E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfosResponse()
		{
		}

		// Token: 0x06011AEE RID: 72430 RVA: 0x00296F34 File Offset: 0x00295134
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfosResponse(PhantomEquipGroupInfosResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomEquipGroupInfos_ = other.phantomEquipGroupInfos_.Clone();
			this.isOldData_ = other.isOldData_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06011AEF RID: 72431 RVA: 0x00296F81 File Offset: 0x00295181
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomEquipGroupInfosResponse Clone()
		{
			return new PhantomEquipGroupInfosResponse(this);
		}

		// Token: 0x17003A95 RID: 14997
		// (get) Token: 0x06011AF0 RID: 72432 RVA: 0x00296F89 File Offset: 0x00295189
		// (set) Token: 0x06011AF1 RID: 72433 RVA: 0x00296F91 File Offset: 0x00295191
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

		// Token: 0x17003A96 RID: 14998
		// (get) Token: 0x06011AF2 RID: 72434 RVA: 0x00296F9A File Offset: 0x0029519A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomEquipGroupInfo> PhantomEquipGroupInfos
		{
			get
			{
				return this.phantomEquipGroupInfos_;
			}
		}

		// Token: 0x17003A97 RID: 14999
		// (get) Token: 0x06011AF3 RID: 72435 RVA: 0x00296FA2 File Offset: 0x002951A2
		// (set) Token: 0x06011AF4 RID: 72436 RVA: 0x00296FAA File Offset: 0x002951AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsOldData
		{
			get
			{
				return this.isOldData_;
			}
			set
			{
				this.isOldData_ = value;
			}
		}

		// Token: 0x06011AF5 RID: 72437 RVA: 0x00296FB3 File Offset: 0x002951B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomEquipGroupInfosResponse);
		}

		// Token: 0x06011AF6 RID: 72438 RVA: 0x00296FC4 File Offset: 0x002951C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomEquipGroupInfosResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomEquipGroupInfos_.Equals(other.phantomEquipGroupInfos_) && this.IsOldData == other.IsOldData && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06011AF7 RID: 72439 RVA: 0x00297024 File Offset: 0x00295224
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
			if (this.IsOldData)
			{
				num ^= this.IsOldData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06011AF8 RID: 72440 RVA: 0x00297090 File Offset: 0x00295290
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06011AF9 RID: 72441 RVA: 0x0029709D File Offset: 0x0029529D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06011AFA RID: 72442 RVA: 0x002970A8 File Offset: 0x002952A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.IsOldData)
			{
				output.WriteRawTag(48);
				output.WriteBool(this.IsOldData);
			}
			this.phantomEquipGroupInfos_.WriteTo(ref output, PhantomEquipGroupInfosResponse._repeated_phantomEquipGroupInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06011AFB RID: 72443 RVA: 0x00297114 File Offset: 0x00295314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.phantomEquipGroupInfos_.CalculateSize(PhantomEquipGroupInfosResponse._repeated_phantomEquipGroupInfos_codec);
			if (this.IsOldData)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06011AFC RID: 72444 RVA: 0x00297174 File Offset: 0x00295374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomEquipGroupInfosResponse other)
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
			if (other.IsOldData)
			{
				this.IsOldData = other.IsOldData;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06011AFD RID: 72445 RVA: 0x002971D5 File Offset: 0x002953D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06011AFE RID: 72446 RVA: 0x002971E0 File Offset: 0x002953E0
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
					if (num != 48U)
					{
						if (num != 58U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.phantomEquipGroupInfos_.AddEntriesFrom(ref input, PhantomEquipGroupInfosResponse._repeated_phantomEquipGroupInfos_codec);
						}
					}
					else
					{
						this.IsOldData = input.ReadBool();
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04006F98 RID: 28568
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006F99 RID: 28569
		public const int ErrorCodeFieldNumber = 4;

		// Token: 0x04006F9A RID: 28570
		private ErrorCode errorCode_;

		// Token: 0x04006F9B RID: 28571
		public const int PhantomEquipGroupInfosFieldNumber = 7;

		// Token: 0x04006F9C RID: 28572
		private static readonly FieldCodec<PhantomEquipGroupInfo> _repeated_phantomEquipGroupInfos_codec = FieldCodec.ForMessage<PhantomEquipGroupInfo>(58U, PhantomEquipGroupInfo.Parser);

		// Token: 0x04006F9D RID: 28573
		private readonly RepeatedField<PhantomEquipGroupInfo> phantomEquipGroupInfos_ = new RepeatedField<PhantomEquipGroupInfo>();

		// Token: 0x04006F9E RID: 28574
		public const int IsOldDataFieldNumber = 6;

		// Token: 0x04006F9F RID: 28575
		private bool isOldData_;
	}
}
