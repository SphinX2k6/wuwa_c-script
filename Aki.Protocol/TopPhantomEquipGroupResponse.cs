using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013FC RID: 5116
	[NetMessage(EMessageId.TopPhantomEquipGroupResponse)]
	public sealed class TopPhantomEquipGroupResponse : IMessage<TopPhantomEquipGroupResponse>, IMessage, IEquatable<TopPhantomEquipGroupResponse>, IDeepCloneable<TopPhantomEquipGroupResponse>, IBufferMessage
	{
		// Token: 0x0601B338 RID: 111416 RVA: 0x003F5197 File Offset: 0x003F3397
		[NullableContext(1)]
		public static TopPhantomEquipGroupResponse Create()
		{
			return new TopPhantomEquipGroupResponse();
		}

		// Token: 0x17005C14 RID: 23572
		// (get) Token: 0x0601B339 RID: 111417 RVA: 0x003F519E File Offset: 0x003F339E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C15 RID: 23573
		// (get) Token: 0x0601B33A RID: 111418 RVA: 0x003F51A1 File Offset: 0x003F33A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TopPhantomEquipGroupResponse.Descriptor;
			}
		}

		// Token: 0x0601B33B RID: 111419 RVA: 0x003F51A8 File Offset: 0x003F33A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TopPhantomEquipGroupResponse()
		{
		}

		// Token: 0x0601B33C RID: 111420 RVA: 0x003F51BB File Offset: 0x003F33BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TopPhantomEquipGroupResponse(TopPhantomEquipGroupResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomEquipGroupInfos_ = other.phantomEquipGroupInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B33D RID: 111421 RVA: 0x003F51F1 File Offset: 0x003F33F1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TopPhantomEquipGroupResponse Clone()
		{
			return new TopPhantomEquipGroupResponse(this);
		}

		// Token: 0x17005C16 RID: 23574
		// (get) Token: 0x0601B33E RID: 111422 RVA: 0x003F51F9 File Offset: 0x003F33F9
		// (set) Token: 0x0601B33F RID: 111423 RVA: 0x003F5201 File Offset: 0x003F3401
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

		// Token: 0x17005C17 RID: 23575
		// (get) Token: 0x0601B340 RID: 111424 RVA: 0x003F520A File Offset: 0x003F340A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomEquipGroupInfo> PhantomEquipGroupInfos
		{
			get
			{
				return this.phantomEquipGroupInfos_;
			}
		}

		// Token: 0x0601B341 RID: 111425 RVA: 0x003F5212 File Offset: 0x003F3412
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TopPhantomEquipGroupResponse);
		}

		// Token: 0x0601B342 RID: 111426 RVA: 0x003F5220 File Offset: 0x003F3420
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TopPhantomEquipGroupResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomEquipGroupInfos_.Equals(other.phantomEquipGroupInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B343 RID: 111427 RVA: 0x003F5270 File Offset: 0x003F3470
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

		// Token: 0x0601B344 RID: 111428 RVA: 0x003F52C3 File Offset: 0x003F34C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B345 RID: 111429 RVA: 0x003F52D0 File Offset: 0x003F34D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B346 RID: 111430 RVA: 0x003F52DC File Offset: 0x003F34DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.phantomEquipGroupInfos_.WriteTo(ref output, TopPhantomEquipGroupResponse._repeated_phantomEquipGroupInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B347 RID: 111431 RVA: 0x003F532C File Offset: 0x003F352C
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

		// Token: 0x0601B348 RID: 111432 RVA: 0x003F5380 File Offset: 0x003F3580
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

		// Token: 0x0601B349 RID: 111433 RVA: 0x003F53CD File Offset: 0x003F35CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B34A RID: 111434 RVA: 0x003F53D8 File Offset: 0x003F35D8
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
					if (num != 122U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.phantomEquipGroupInfos_.AddEntriesFrom(ref input, TopPhantomEquipGroupResponse._repeated_phantomEquipGroupInfos_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x04009E9B RID: 40603
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009E9C RID: 40604
		public const int ErrorCodeFieldNumber = 10;

		// Token: 0x04009E9D RID: 40605
		private ErrorCode errorCode_;

		// Token: 0x04009E9E RID: 40606
		public const int PhantomEquipGroupInfosFieldNumber = 15;

		// Token: 0x04009E9F RID: 40607
		private static readonly FieldCodec<PhantomEquipGroupInfo> _repeated_phantomEquipGroupInfos_codec = FieldCodec.ForMessage<PhantomEquipGroupInfo>(122U, PhantomEquipGroupInfo.Parser);

		// Token: 0x04009EA0 RID: 40608
		private readonly RepeatedField<PhantomEquipGroupInfo> phantomEquipGroupInfos_ = new RepeatedField<PhantomEquipGroupInfo>();
	}
}
