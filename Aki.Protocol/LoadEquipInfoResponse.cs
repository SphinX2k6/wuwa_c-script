using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200093D RID: 2365
	[NetMessage(EMessageId.LoadEquipInfoResponse)]
	public sealed class LoadEquipInfoResponse : IMessage<LoadEquipInfoResponse>, IMessage, IEquatable<LoadEquipInfoResponse>, IDeepCloneable<LoadEquipInfoResponse>, IBufferMessage
	{
		// Token: 0x0600D060 RID: 53344 RVA: 0x001EA956 File Offset: 0x001E8B56
		[NullableContext(1)]
		public static LoadEquipInfoResponse Create()
		{
			return new LoadEquipInfoResponse();
		}

		// Token: 0x17002A18 RID: 10776
		// (get) Token: 0x0600D061 RID: 53345 RVA: 0x001EA95D File Offset: 0x001E8B5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002A19 RID: 10777
		// (get) Token: 0x0600D062 RID: 53346 RVA: 0x001EA960 File Offset: 0x001E8B60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoadEquipInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600D063 RID: 53347 RVA: 0x001EA967 File Offset: 0x001E8B67
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadEquipInfoResponse()
		{
		}

		// Token: 0x0600D064 RID: 53348 RVA: 0x001EA97A File Offset: 0x001E8B7A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadEquipInfoResponse(LoadEquipInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.equipList_ = other.equipList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D065 RID: 53349 RVA: 0x001EA9B0 File Offset: 0x001E8BB0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadEquipInfoResponse Clone()
		{
			return new LoadEquipInfoResponse(this);
		}

		// Token: 0x17002A1A RID: 10778
		// (get) Token: 0x0600D066 RID: 53350 RVA: 0x001EA9B8 File Offset: 0x001E8BB8
		// (set) Token: 0x0600D067 RID: 53351 RVA: 0x001EA9C0 File Offset: 0x001E8BC0
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

		// Token: 0x17002A1B RID: 10779
		// (get) Token: 0x0600D068 RID: 53352 RVA: 0x001EA9C9 File Offset: 0x001E8BC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleSkinEquipData> EquipList
		{
			get
			{
				return this.equipList_;
			}
		}

		// Token: 0x0600D069 RID: 53353 RVA: 0x001EA9D1 File Offset: 0x001E8BD1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoadEquipInfoResponse);
		}

		// Token: 0x0600D06A RID: 53354 RVA: 0x001EA9E0 File Offset: 0x001E8BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoadEquipInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.equipList_.Equals(other.equipList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D06B RID: 53355 RVA: 0x001EAA30 File Offset: 0x001E8C30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.equipList_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D06C RID: 53356 RVA: 0x001EAA83 File Offset: 0x001E8C83
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D06D RID: 53357 RVA: 0x001EAA90 File Offset: 0x001E8C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D06E RID: 53358 RVA: 0x001EAA9C File Offset: 0x001E8C9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)this.ErrorCode);
			}
			this.equipList_.WriteTo(ref output, LoadEquipInfoResponse._repeated_equipList_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D06F RID: 53359 RVA: 0x001EAAEC File Offset: 0x001E8CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.equipList_.CalculateSize(LoadEquipInfoResponse._repeated_equipList_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D070 RID: 53360 RVA: 0x001EAB40 File Offset: 0x001E8D40
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(LoadEquipInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.equipList_.Add(other.equipList_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D071 RID: 53361 RVA: 0x001EAB8D File Offset: 0x001E8D8D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D072 RID: 53362 RVA: 0x001EAB98 File Offset: 0x001E8D98
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
				if (num != 8U)
				{
					if (num != 74U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.equipList_.AddEntriesFrom(ref input, LoadEquipInfoResponse._repeated_equipList_codec);
					}
				}
				else
				{
					this.ErrorCode = (ErrorCode)input.ReadEnum();
				}
			}
		}

		// Token: 0x040057C4 RID: 22468
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057C5 RID: 22469
		public const int ErrorCodeFieldNumber = 1;

		// Token: 0x040057C6 RID: 22470
		private ErrorCode errorCode_;

		// Token: 0x040057C7 RID: 22471
		public const int EquipListFieldNumber = 9;

		// Token: 0x040057C8 RID: 22472
		private static readonly FieldCodec<RoleSkinEquipData> _repeated_equipList_codec = FieldCodec.ForMessage<RoleSkinEquipData>(74U, RoleSkinEquipData.Parser);

		// Token: 0x040057C9 RID: 22473
		private readonly RepeatedField<RoleSkinEquipData> equipList_ = new RepeatedField<RoleSkinEquipData>();
	}
}
