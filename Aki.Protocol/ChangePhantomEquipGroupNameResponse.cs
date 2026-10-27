using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000256 RID: 598
	[NetMessage(EMessageId.ChangePhantomEquipGroupNameResponse)]
	public sealed class ChangePhantomEquipGroupNameResponse : IMessage<ChangePhantomEquipGroupNameResponse>, IMessage, IEquatable<ChangePhantomEquipGroupNameResponse>, IDeepCloneable<ChangePhantomEquipGroupNameResponse>, IBufferMessage
	{
		// Token: 0x06003F95 RID: 16277 RVA: 0x0009C64C File Offset: 0x0009A84C
		[NullableContext(1)]
		public static ChangePhantomEquipGroupNameResponse Create()
		{
			return new ChangePhantomEquipGroupNameResponse();
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06003F96 RID: 16278 RVA: 0x0009C653 File Offset: 0x0009A853
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06003F97 RID: 16279 RVA: 0x0009C656 File Offset: 0x0009A856
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return ChangePhantomEquipGroupNameResponse.Descriptor;
			}
		}

		// Token: 0x06003F98 RID: 16280 RVA: 0x0009C65D File Offset: 0x0009A85D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePhantomEquipGroupNameResponse()
		{
		}

		// Token: 0x06003F99 RID: 16281 RVA: 0x0009C670 File Offset: 0x0009A870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePhantomEquipGroupNameResponse(ChangePhantomEquipGroupNameResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.phantomEquipGroupInfos_ = other.phantomEquipGroupInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06003F9A RID: 16282 RVA: 0x0009C6A6 File Offset: 0x0009A8A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ChangePhantomEquipGroupNameResponse Clone()
		{
			return new ChangePhantomEquipGroupNameResponse(this);
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06003F9B RID: 16283 RVA: 0x0009C6AE File Offset: 0x0009A8AE
		// (set) Token: 0x06003F9C RID: 16284 RVA: 0x0009C6B6 File Offset: 0x0009A8B6
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

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06003F9D RID: 16285 RVA: 0x0009C6BF File Offset: 0x0009A8BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<PhantomEquipGroupInfo> PhantomEquipGroupInfos
		{
			get
			{
				return this.phantomEquipGroupInfos_;
			}
		}

		// Token: 0x06003F9E RID: 16286 RVA: 0x0009C6C7 File Offset: 0x0009A8C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as ChangePhantomEquipGroupNameResponse);
		}

		// Token: 0x06003F9F RID: 16287 RVA: 0x0009C6D8 File Offset: 0x0009A8D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(ChangePhantomEquipGroupNameResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.phantomEquipGroupInfos_.Equals(other.phantomEquipGroupInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06003FA0 RID: 16288 RVA: 0x0009C728 File Offset: 0x0009A928
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

		// Token: 0x06003FA1 RID: 16289 RVA: 0x0009C77B File Offset: 0x0009A97B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06003FA2 RID: 16290 RVA: 0x0009C788 File Offset: 0x0009A988
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06003FA3 RID: 16291 RVA: 0x0009C794 File Offset: 0x0009A994
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomEquipGroupInfos_.WriteTo(ref output, ChangePhantomEquipGroupNameResponse._repeated_phantomEquipGroupInfos_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(120);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06003FA4 RID: 16292 RVA: 0x0009C7E4 File Offset: 0x0009A9E4
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

		// Token: 0x06003FA5 RID: 16293 RVA: 0x0009C838 File Offset: 0x0009AA38
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

		// Token: 0x06003FA6 RID: 16294 RVA: 0x0009C885 File Offset: 0x0009AA85
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06003FA7 RID: 16295 RVA: 0x0009C890 File Offset: 0x0009AA90
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
				if (num != 66U)
				{
					if (num != 120U)
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

		// Token: 0x04002D28 RID: 11560
		private UnknownFieldSet _unknownFields;

		// Token: 0x04002D29 RID: 11561
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x04002D2A RID: 11562
		private ErrorCode errorCode_;

		// Token: 0x04002D2B RID: 11563
		public const int PhantomEquipGroupInfosFieldNumber = 8;

		// Token: 0x04002D2C RID: 11564
		private static readonly FieldCodec<PhantomEquipGroupInfo> _repeated_phantomEquipGroupInfos_codec = FieldCodec.ForMessage<PhantomEquipGroupInfo>(66U, PhantomEquipGroupInfo.Parser);

		// Token: 0x04002D2D RID: 11565
		private readonly RepeatedField<PhantomEquipGroupInfo> phantomEquipGroupInfos_ = new RepeatedField<PhantomEquipGroupInfo>();
	}
}
