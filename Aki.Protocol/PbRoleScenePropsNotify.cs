using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C10 RID: 3088
	[NetMessage(EMessageId.PbRoleScenePropsNotify)]
	public sealed class PbRoleScenePropsNotify : IMessage<PbRoleScenePropsNotify>, IMessage, IEquatable<PbRoleScenePropsNotify>, IDeepCloneable<PbRoleScenePropsNotify>, IBufferMessage
	{
		// Token: 0x06010C37 RID: 68663 RVA: 0x00274740 File Offset: 0x00272940
		[NullableContext(1)]
		public static PbRoleScenePropsNotify Create()
		{
			return new PbRoleScenePropsNotify();
		}

		// Token: 0x17003751 RID: 14161
		// (get) Token: 0x06010C38 RID: 68664 RVA: 0x00274747 File Offset: 0x00272947
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003752 RID: 14162
		// (get) Token: 0x06010C39 RID: 68665 RVA: 0x0027474A File Offset: 0x0027294A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbRoleScenePropsNotify.Descriptor;
			}
		}

		// Token: 0x06010C3A RID: 68666 RVA: 0x00274751 File Offset: 0x00272951
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleScenePropsNotify()
		{
		}

		// Token: 0x06010C3B RID: 68667 RVA: 0x00274770 File Offset: 0x00272970
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleScenePropsNotify(PbRoleScenePropsNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.baseProp_ = other.baseProp_.Clone();
			this.addProp_ = other.addProp_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010C3C RID: 68668 RVA: 0x002747C2 File Offset: 0x002729C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleScenePropsNotify Clone()
		{
			return new PbRoleScenePropsNotify(this);
		}

		// Token: 0x17003753 RID: 14163
		// (get) Token: 0x06010C3D RID: 68669 RVA: 0x002747CA File Offset: 0x002729CA
		// (set) Token: 0x06010C3E RID: 68670 RVA: 0x002747D2 File Offset: 0x002729D2
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

		// Token: 0x17003754 RID: 14164
		// (get) Token: 0x06010C3F RID: 68671 RVA: 0x002747DB File Offset: 0x002729DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> BaseProp
		{
			get
			{
				return this.baseProp_;
			}
		}

		// Token: 0x17003755 RID: 14165
		// (get) Token: 0x06010C40 RID: 68672 RVA: 0x002747E3 File Offset: 0x002729E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> AddProp
		{
			get
			{
				return this.addProp_;
			}
		}

		// Token: 0x06010C41 RID: 68673 RVA: 0x002747EB File Offset: 0x002729EB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbRoleScenePropsNotify);
		}

		// Token: 0x06010C42 RID: 68674 RVA: 0x002747FC File Offset: 0x002729FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbRoleScenePropsNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.baseProp_.Equals(other.baseProp_) && this.addProp_.Equals(other.addProp_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010C43 RID: 68675 RVA: 0x00274860 File Offset: 0x00272A60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			num ^= this.baseProp_.GetHashCode();
			num ^= this.addProp_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010C44 RID: 68676 RVA: 0x002748BB File Offset: 0x00272ABB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010C45 RID: 68677 RVA: 0x002748C8 File Offset: 0x00272AC8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010C46 RID: 68678 RVA: 0x002748D4 File Offset: 0x00272AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.addProp_.WriteTo(ref output, PbRoleScenePropsNotify._repeated_addProp_codec);
			this.baseProp_.WriteTo(ref output, PbRoleScenePropsNotify._repeated_baseProp_codec);
			if (this.RoleId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010C47 RID: 68679 RVA: 0x00274934 File Offset: 0x00272B34
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			num += this.baseProp_.CalculateSize(PbRoleScenePropsNotify._repeated_baseProp_codec);
			num += this.addProp_.CalculateSize(PbRoleScenePropsNotify._repeated_addProp_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010C48 RID: 68680 RVA: 0x00274998 File Offset: 0x00272B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbRoleScenePropsNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this.baseProp_.Add(other.baseProp_);
			this.addProp_.Add(other.addProp_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010C49 RID: 68681 RVA: 0x002749F6 File Offset: 0x00272BF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010C4A RID: 68682 RVA: 0x00274A00 File Offset: 0x00272C00
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
				if (num != 10U)
				{
					if (num != 90U)
					{
						if (num != 120U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.RoleId = input.ReadInt32();
						}
					}
					else
					{
						this.baseProp_.AddEntriesFrom(ref input, PbRoleScenePropsNotify._repeated_baseProp_codec);
					}
				}
				else
				{
					this.addProp_.AddEntriesFrom(ref input, PbRoleScenePropsNotify._repeated_addProp_codec);
				}
			}
		}

		// Token: 0x04006A7B RID: 27259
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A7C RID: 27260
		public const int RoleIdFieldNumber = 15;

		// Token: 0x04006A7D RID: 27261
		private int roleId_;

		// Token: 0x04006A7E RID: 27262
		public const int BasePropFieldNumber = 11;

		// Token: 0x04006A7F RID: 27263
		private static readonly FieldCodec<ArrayIntInt> _repeated_baseProp_codec = FieldCodec.ForMessage<ArrayIntInt>(90U, ArrayIntInt.Parser);

		// Token: 0x04006A80 RID: 27264
		private readonly RepeatedField<ArrayIntInt> baseProp_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x04006A81 RID: 27265
		public const int AddPropFieldNumber = 1;

		// Token: 0x04006A82 RID: 27266
		private static readonly FieldCodec<ArrayIntInt> _repeated_addProp_codec = FieldCodec.ForMessage<ArrayIntInt>(10U, ArrayIntInt.Parser);

		// Token: 0x04006A83 RID: 27267
		private readonly RepeatedField<ArrayIntInt> addProp_ = new RepeatedField<ArrayIntInt>();
	}
}
