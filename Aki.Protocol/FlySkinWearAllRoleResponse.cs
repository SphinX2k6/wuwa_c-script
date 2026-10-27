using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000612 RID: 1554
	[NetMessage(EMessageId.FlySkinWearAllRoleResponse)]
	public sealed class FlySkinWearAllRoleResponse : IMessage<FlySkinWearAllRoleResponse>, IMessage, IEquatable<FlySkinWearAllRoleResponse>, IDeepCloneable<FlySkinWearAllRoleResponse>, IBufferMessage
	{
		// Token: 0x06008F8E RID: 36750 RVA: 0x0015BAA5 File Offset: 0x00159CA5
		[NullableContext(1)]
		public static FlySkinWearAllRoleResponse Create()
		{
			return new FlySkinWearAllRoleResponse();
		}

		// Token: 0x17001C7F RID: 7295
		// (get) Token: 0x06008F8F RID: 36751 RVA: 0x0015BAAC File Offset: 0x00159CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001C80 RID: 7296
		// (get) Token: 0x06008F90 RID: 36752 RVA: 0x0015BAAF File Offset: 0x00159CAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FlySkinWearAllRoleResponse.Descriptor;
			}
		}

		// Token: 0x06008F91 RID: 36753 RVA: 0x0015BAB6 File Offset: 0x00159CB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearAllRoleResponse()
		{
		}

		// Token: 0x06008F92 RID: 36754 RVA: 0x0015BAC9 File Offset: 0x00159CC9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearAllRoleResponse(FlySkinWearAllRoleResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.skinChanges_ = other.skinChanges_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008F93 RID: 36755 RVA: 0x0015BAFF File Offset: 0x00159CFF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FlySkinWearAllRoleResponse Clone()
		{
			return new FlySkinWearAllRoleResponse(this);
		}

		// Token: 0x17001C81 RID: 7297
		// (get) Token: 0x06008F94 RID: 36756 RVA: 0x0015BB07 File Offset: 0x00159D07
		// (set) Token: 0x06008F95 RID: 36757 RVA: 0x0015BB0F File Offset: 0x00159D0F
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

		// Token: 0x17001C82 RID: 7298
		// (get) Token: 0x06008F96 RID: 36758 RVA: 0x0015BB18 File Offset: 0x00159D18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<RoleFlySkinChange> SkinChanges
		{
			get
			{
				return this.skinChanges_;
			}
		}

		// Token: 0x06008F97 RID: 36759 RVA: 0x0015BB20 File Offset: 0x00159D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FlySkinWearAllRoleResponse);
		}

		// Token: 0x06008F98 RID: 36760 RVA: 0x0015BB30 File Offset: 0x00159D30
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FlySkinWearAllRoleResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.skinChanges_.Equals(other.skinChanges_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06008F99 RID: 36761 RVA: 0x0015BB80 File Offset: 0x00159D80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.skinChanges_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008F9A RID: 36762 RVA: 0x0015BBD3 File Offset: 0x00159DD3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008F9B RID: 36763 RVA: 0x0015BBE0 File Offset: 0x00159DE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008F9C RID: 36764 RVA: 0x0015BBEC File Offset: 0x00159DEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.skinChanges_.WriteTo(ref output, FlySkinWearAllRoleResponse._repeated_skinChanges_codec);
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

		// Token: 0x06008F9D RID: 36765 RVA: 0x0015BC3C File Offset: 0x00159E3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.skinChanges_.CalculateSize(FlySkinWearAllRoleResponse._repeated_skinChanges_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008F9E RID: 36766 RVA: 0x0015BC90 File Offset: 0x00159E90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FlySkinWearAllRoleResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.skinChanges_.Add(other.skinChanges_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008F9F RID: 36767 RVA: 0x0015BCDD File Offset: 0x00159EDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008FA0 RID: 36768 RVA: 0x0015BCE8 File Offset: 0x00159EE8
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
					this.skinChanges_.AddEntriesFrom(ref input, FlySkinWearAllRoleResponse._repeated_skinChanges_codec);
				}
			}
		}

		// Token: 0x040045AA RID: 17834
		private UnknownFieldSet _unknownFields;

		// Token: 0x040045AB RID: 17835
		public const int ErrorCodeFieldNumber = 15;

		// Token: 0x040045AC RID: 17836
		private ErrorCode errorCode_;

		// Token: 0x040045AD RID: 17837
		public const int SkinChangesFieldNumber = 6;

		// Token: 0x040045AE RID: 17838
		private static readonly FieldCodec<RoleFlySkinChange> _repeated_skinChanges_codec = FieldCodec.ForMessage<RoleFlySkinChange>(50U, RoleFlySkinChange.Parser);

		// Token: 0x040045AF RID: 17839
		private readonly RepeatedField<RoleFlySkinChange> skinChanges_ = new RepeatedField<RoleFlySkinChange>();
	}
}
