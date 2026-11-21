using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200025B RID: 603
	[NetMessage(EMessageId.ChangePhantomEquipGroupNameResponse)]
	public sealed class ChangePhantomEquipGroupNameResponse : IMessage<ChangePhantomEquipGroupNameResponse>, IMessage, IEquatable<ChangePhantomEquipGroupNameResponse>, IDeepCloneable<ChangePhantomEquipGroupNameResponse>, IBufferMessage
	{
		// Token: 0x0600403C RID: 16444 RVA: 0x0009E317 File Offset: 0x0009C517
		[NullableContext(1)]
		public static ChangePhantomEquipGroupNameResponse Create()
		{
			return new ChangePhantomEquipGroupNameResponse();
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x0600403D RID: 16445 RVA: 0x0009E31E File Offset: 0x0009C51E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x0600403E RID: 16446 RVA: 0x0009E321 File Offset: 0x0009C521
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangePhantomEquipGroupNameResponse.Descriptor;
			}
		}

		// Token: 0x0600403F RID: 16447 RVA: 0x0009E328 File Offset: 0x0009C528
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePhantomEquipGroupNameResponse()
		{
		}

		// Token: 0x06004040 RID: 16448 RVA: 0x0009E33B File Offset: 0x0009C53B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePhantomEquipGroupNameResponse(ChangePhantomEquipGroupNameResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomEquipGroupInfos_ = other.phantomEquipGroupInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06004041 RID: 16449 RVA: 0x0009E371 File Offset: 0x0009C571
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePhantomEquipGroupNameResponse Clone()
		{
			return new ChangePhantomEquipGroupNameResponse(this);
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06004042 RID: 16450 RVA: 0x0009E379 File Offset: 0x0009C579
		// (set) Token: 0x06004043 RID: 16451 RVA: 0x0009E381 File Offset: 0x0009C581
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

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06004044 RID: 16452 RVA: 0x0009E38A File Offset: 0x0009C58A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomEquipGroupInfo> PhantomEquipGroupInfos
		{
			get
			{
				return this.phantomEquipGroupInfos_;
			}
		}

		// Token: 0x06004045 RID: 16453 RVA: 0x0009E392 File Offset: 0x0009C592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangePhantomEquipGroupNameResponse);
		}

		// Token: 0x06004046 RID: 16454 RVA: 0x0009E3A0 File Offset: 0x0009C5A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangePhantomEquipGroupNameResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomEquipGroupInfos_.Equals(other.phantomEquipGroupInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06004047 RID: 16455 RVA: 0x0009E3F0 File Offset: 0x0009C5F0
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

		// Token: 0x06004048 RID: 16456 RVA: 0x0009E443 File Offset: 0x0009C643
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06004049 RID: 16457 RVA: 0x0009E450 File Offset: 0x0009C650
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600404A RID: 16458 RVA: 0x0009E45C File Offset: 0x0009C65C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomEquipGroupInfos_.WriteTo(ref output, ChangePhantomEquipGroupNameResponse._repeated_phantomEquipGroupInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(96);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600404B RID: 16459 RVA: 0x0009E4AC File Offset: 0x0009C6AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.phantomEquipGroupInfos_.CalculateSize(ChangePhantomEquipGroupNameResponse._repeated_phantomEquipGroupInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600404C RID: 16460 RVA: 0x0009E500 File Offset: 0x0009C700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(ChangePhantomEquipGroupNameResponse other)
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

		// Token: 0x0600404D RID: 16461 RVA: 0x0009E54D File Offset: 0x0009C74D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x0009E558 File Offset: 0x0009C758
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
				if (num != 50U)
				{
					if (num != 96U)
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
					this.phantomEquipGroupInfos_.AddEntriesFrom(ref input, ChangePhantomEquipGroupNameResponse._repeated_phantomEquipGroupInfos_codec);
				}
			}
		}

		// Token: 0x04002DAC RID: 11692
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002DAD RID: 11693
		public const int ErrorCodeFieldNumber = 12;

		// Token: 0x04002DAE RID: 11694
		private ErrorCode errorCode_;

		// Token: 0x04002DAF RID: 11695
		public const int PhantomEquipGroupInfosFieldNumber = 6;

		// Token: 0x04002DB0 RID: 11696
		private static readonly FieldCodec<PhantomEquipGroupInfo> _repeated_phantomEquipGroupInfos_codec = FieldCodec.ForMessage<PhantomEquipGroupInfo>(50U, PhantomEquipGroupInfo.Parser);

		// Token: 0x04002DB1 RID: 11697
		private readonly RepeatedField<PhantomEquipGroupInfo> phantomEquipGroupInfos_ = new RepeatedField<PhantomEquipGroupInfo>();
	}
}
