using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001514 RID: 5396
	[NetMessage(EMessageId.UpdatePhantomEquipGroupRequest)]
	public sealed class UpdatePhantomEquipGroupRequest : IMessage<UpdatePhantomEquipGroupRequest>, IMessage, IEquatable<UpdatePhantomEquipGroupRequest>, IDeepCloneable<UpdatePhantomEquipGroupRequest>, IBufferMessage
	{
		// Token: 0x0601C972 RID: 117106 RVA: 0x00424B8D File Offset: 0x00422D8D
		[NullableContext(1)]
		public static UpdatePhantomEquipGroupRequest Create()
		{
			return new UpdatePhantomEquipGroupRequest();
		}

		// Token: 0x170060B6 RID: 24758
		// (get) Token: 0x0601C973 RID: 117107 RVA: 0x00424B94 File Offset: 0x00422D94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170060B7 RID: 24759
		// (get) Token: 0x0601C974 RID: 117108 RVA: 0x00424B97 File Offset: 0x00422D97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdatePhantomEquipGroupRequest.Descriptor;
			}
		}

		// Token: 0x0601C975 RID: 117109 RVA: 0x00424B9E File Offset: 0x00422D9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePhantomEquipGroupRequest()
		{
		}

		// Token: 0x0601C976 RID: 117110 RVA: 0x00424BB4 File Offset: 0x00422DB4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePhantomEquipGroupRequest(UpdatePhantomEquipGroupRequest other) : this()
		{
			this.index_ = other.index_;
			this.roleId_ = other.roleId_;
			this.phantomIncrIds_ = other.phantomIncrIds_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C977 RID: 117111 RVA: 0x00424C01 File Offset: 0x00422E01
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdatePhantomEquipGroupRequest Clone()
		{
			return new UpdatePhantomEquipGroupRequest(this);
		}

		// Token: 0x170060B8 RID: 24760
		// (get) Token: 0x0601C978 RID: 117112 RVA: 0x00424C09 File Offset: 0x00422E09
		// (set) Token: 0x0601C979 RID: 117113 RVA: 0x00424C11 File Offset: 0x00422E11
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Index
		{
			get
			{
				return this.index_;
			}
			set
			{
				this.index_ = value;
			}
		}

		// Token: 0x170060B9 RID: 24761
		// (get) Token: 0x0601C97A RID: 117114 RVA: 0x00424C1A File Offset: 0x00422E1A
		// (set) Token: 0x0601C97B RID: 117115 RVA: 0x00424C22 File Offset: 0x00422E22
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RoleId
		{
			get
			{
				return this.roleId_;
			}
			set
			{
				this.roleId_ = value;
			}
		}

		// Token: 0x170060BA RID: 24762
		// (get) Token: 0x0601C97C RID: 117116 RVA: 0x00424C2B File Offset: 0x00422E2B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PhantomIncrIds
		{
			get
			{
				return this.phantomIncrIds_;
			}
		}

		// Token: 0x0601C97D RID: 117117 RVA: 0x00424C33 File Offset: 0x00422E33
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdatePhantomEquipGroupRequest);
		}

		// Token: 0x0601C97E RID: 117118 RVA: 0x00424C44 File Offset: 0x00422E44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdatePhantomEquipGroupRequest other)
		{
			return other != null && (other == this || (this.Index == other.Index && this.RoleId == other.RoleId && this.phantomIncrIds_.Equals(other.phantomIncrIds_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C97F RID: 117119 RVA: 0x00424CA4 File Offset: 0x00422EA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Index != 0)
			{
				num ^= this.Index.GetHashCode();
			}
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			num ^= this.phantomIncrIds_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C980 RID: 117120 RVA: 0x00424D0A File Offset: 0x00422F0A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C981 RID: 117121 RVA: 0x00424D17 File Offset: 0x00422F17
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C982 RID: 117122 RVA: 0x00424D20 File Offset: 0x00422F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RoleId != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.RoleId);
			}
			this.phantomIncrIds_.WriteTo(ref output, UpdatePhantomEquipGroupRequest._repeated_phantomIncrIds_codec);
			if (this.Index != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.Index);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C983 RID: 117123 RVA: 0x00424D8C File Offset: 0x00422F8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Index != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Index);
			}
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			num += this.phantomIncrIds_.CalculateSize(UpdatePhantomEquipGroupRequest._repeated_phantomIncrIds_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C984 RID: 117124 RVA: 0x00424DF8 File Offset: 0x00422FF8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdatePhantomEquipGroupRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Index != 0)
			{
				this.Index = other.Index;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this.phantomIncrIds_.Add(other.phantomIncrIds_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C985 RID: 117125 RVA: 0x00424E59 File Offset: 0x00423059
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C986 RID: 117126 RVA: 0x00424E64 File Offset: 0x00423064
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
				if (num <= 96U)
				{
					if (num == 88U)
					{
						this.RoleId = input.ReadInt32();
						continue;
					}
					if (num == 96U)
					{
						goto IL_46;
					}
				}
				else
				{
					if (num == 98U)
					{
						goto IL_46;
					}
					if (num == 104U)
					{
						this.Index = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				continue;
				IL_46:
				this.phantomIncrIds_.AddEntriesFrom(ref input, UpdatePhantomEquipGroupRequest._repeated_phantomIncrIds_codec);
			}
		}

		// Token: 0x0400A4C6 RID: 42182
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A4C7 RID: 42183
		public const int IndexFieldNumber = 13;

		// Token: 0x0400A4C8 RID: 42184
		private int index_;

		// Token: 0x0400A4C9 RID: 42185
		public const int RoleIdFieldNumber = 11;

		// Token: 0x0400A4CA RID: 42186
		private int roleId_;

		// Token: 0x0400A4CB RID: 42187
		public const int PhantomIncrIdsFieldNumber = 12;

		// Token: 0x0400A4CC RID: 42188
		private static readonly FieldCodec<int> _repeated_phantomIncrIds_codec = FieldCodec.ForInt32(98U);

		// Token: 0x0400A4CD RID: 42189
		private readonly RepeatedField<int> phantomIncrIds_ = new RepeatedField<int>();
	}
}
