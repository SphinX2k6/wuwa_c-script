using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200092C RID: 2348
	[NetMessage(EMessageId.LoadEquipInfoResponse)]
	public sealed class LoadEquipInfoResponse : IMessage<LoadEquipInfoResponse>, IMessage, IEquatable<LoadEquipInfoResponse>, IDeepCloneable<LoadEquipInfoResponse>, IBufferMessage
	{
		// Token: 0x0600CF44 RID: 53060 RVA: 0x001E8682 File Offset: 0x001E6882
		[NullableContext(1)]
		public static LoadEquipInfoResponse Create()
		{
			return new LoadEquipInfoResponse();
		}

		// Token: 0x170029D9 RID: 10713
		// (get) Token: 0x0600CF45 RID: 53061 RVA: 0x001E8689 File Offset: 0x001E6889
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170029DA RID: 10714
		// (get) Token: 0x0600CF46 RID: 53062 RVA: 0x001E868C File Offset: 0x001E688C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return LoadEquipInfoResponse.Descriptor;
			}
		}

		// Token: 0x0600CF47 RID: 53063 RVA: 0x001E8693 File Offset: 0x001E6893
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadEquipInfoResponse()
		{
		}

		// Token: 0x0600CF48 RID: 53064 RVA: 0x001E86A6 File Offset: 0x001E68A6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadEquipInfoResponse(LoadEquipInfoResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.equipList_ = other.equipList_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600CF49 RID: 53065 RVA: 0x001E86DC File Offset: 0x001E68DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public LoadEquipInfoResponse Clone()
		{
			return new LoadEquipInfoResponse(this);
		}

		// Token: 0x170029DB RID: 10715
		// (get) Token: 0x0600CF4A RID: 53066 RVA: 0x001E86E4 File Offset: 0x001E68E4
		// (set) Token: 0x0600CF4B RID: 53067 RVA: 0x001E86EC File Offset: 0x001E68EC
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

		// Token: 0x170029DC RID: 10716
		// (get) Token: 0x0600CF4C RID: 53068 RVA: 0x001E86F5 File Offset: 0x001E68F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleSkinEquipData> EquipList
		{
			get
			{
				return this.equipList_;
			}
		}

		// Token: 0x0600CF4D RID: 53069 RVA: 0x001E86FD File Offset: 0x001E68FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as LoadEquipInfoResponse);
		}

		// Token: 0x0600CF4E RID: 53070 RVA: 0x001E870C File Offset: 0x001E690C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(LoadEquipInfoResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.equipList_.Equals(other.equipList_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600CF4F RID: 53071 RVA: 0x001E875C File Offset: 0x001E695C
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

		// Token: 0x0600CF50 RID: 53072 RVA: 0x001E87AF File Offset: 0x001E69AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600CF51 RID: 53073 RVA: 0x001E87BC File Offset: 0x001E69BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600CF52 RID: 53074 RVA: 0x001E87C8 File Offset: 0x001E69C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.equipList_.WriteTo(ref output, LoadEquipInfoResponse._repeated_equipList_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(88);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600CF53 RID: 53075 RVA: 0x001E8818 File Offset: 0x001E6A18
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

		// Token: 0x0600CF54 RID: 53076 RVA: 0x001E886C File Offset: 0x001E6A6C
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

		// Token: 0x0600CF55 RID: 53077 RVA: 0x001E88B9 File Offset: 0x001E6AB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600CF56 RID: 53078 RVA: 0x001E88C4 File Offset: 0x001E6AC4
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
					if (num != 88U)
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
					this.equipList_.AddEntriesFrom(ref input, LoadEquipInfoResponse._repeated_equipList_codec);
				}
			}
		}

		// Token: 0x040057CB RID: 22475
		private UnknownFieldSet _unknownFields;

		// Token: 0x040057CC RID: 22476
		public const int ErrorCodeFieldNumber = 11;

		// Token: 0x040057CD RID: 22477
		private ErrorCode errorCode_;

		// Token: 0x040057CE RID: 22478
		public const int EquipListFieldNumber = 5;

		// Token: 0x040057CF RID: 22479
		private static readonly FieldCodec<RoleSkinEquipData> _repeated_equipList_codec = FieldCodec.ForMessage<RoleSkinEquipData>(42U, RoleSkinEquipData.Parser);

		// Token: 0x040057D0 RID: 22480
		private readonly RepeatedField<RoleSkinEquipData> equipList_ = new RepeatedField<RoleSkinEquipData>();
	}
}
