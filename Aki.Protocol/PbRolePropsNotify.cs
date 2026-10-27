using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C0E RID: 3086
	[NetMessage(EMessageId.PbRolePropsNotify)]
	public sealed class PbRolePropsNotify : IMessage<PbRolePropsNotify>, IMessage, IEquatable<PbRolePropsNotify>, IDeepCloneable<PbRolePropsNotify>, IBufferMessage
	{
		// Token: 0x06010C0E RID: 68622 RVA: 0x0027414B File Offset: 0x0027234B
		[NullableContext(1)]
		public static PbRolePropsNotify Create()
		{
			return new PbRolePropsNotify();
		}

		// Token: 0x17003748 RID: 14152
		// (get) Token: 0x06010C0F RID: 68623 RVA: 0x00274152 File Offset: 0x00272352
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003749 RID: 14153
		// (get) Token: 0x06010C10 RID: 68624 RVA: 0x00274155 File Offset: 0x00272355
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbRolePropsNotify.Descriptor;
			}
		}

		// Token: 0x06010C11 RID: 68625 RVA: 0x0027415C File Offset: 0x0027235C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRolePropsNotify()
		{
		}

		// Token: 0x06010C12 RID: 68626 RVA: 0x0027417C File Offset: 0x0027237C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRolePropsNotify(PbRolePropsNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.baseProp_ = other.baseProp_.Clone();
			this.addProp_ = other.addProp_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010C13 RID: 68627 RVA: 0x002741CE File Offset: 0x002723CE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRolePropsNotify Clone()
		{
			return new PbRolePropsNotify(this);
		}

		// Token: 0x1700374A RID: 14154
		// (get) Token: 0x06010C14 RID: 68628 RVA: 0x002741D6 File Offset: 0x002723D6
		// (set) Token: 0x06010C15 RID: 68629 RVA: 0x002741DE File Offset: 0x002723DE
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

		// Token: 0x1700374B RID: 14155
		// (get) Token: 0x06010C16 RID: 68630 RVA: 0x002741E7 File Offset: 0x002723E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> BaseProp
		{
			get
			{
				return this.baseProp_;
			}
		}

		// Token: 0x1700374C RID: 14156
		// (get) Token: 0x06010C17 RID: 68631 RVA: 0x002741EF File Offset: 0x002723EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> AddProp
		{
			get
			{
				return this.addProp_;
			}
		}

		// Token: 0x06010C18 RID: 68632 RVA: 0x002741F7 File Offset: 0x002723F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbRolePropsNotify);
		}

		// Token: 0x06010C19 RID: 68633 RVA: 0x00274208 File Offset: 0x00272408
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbRolePropsNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.baseProp_.Equals(other.baseProp_) && this.addProp_.Equals(other.addProp_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010C1A RID: 68634 RVA: 0x0027426C File Offset: 0x0027246C
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

		// Token: 0x06010C1B RID: 68635 RVA: 0x002742C7 File Offset: 0x002724C7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010C1C RID: 68636 RVA: 0x002742D4 File Offset: 0x002724D4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010C1D RID: 68637 RVA: 0x002742E0 File Offset: 0x002724E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.addProp_.WriteTo(ref output, PbRolePropsNotify._repeated_addProp_codec);
			if (this.RoleId != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(this.RoleId);
			}
			this.baseProp_.WriteTo(ref output, PbRolePropsNotify._repeated_baseProp_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010C1E RID: 68638 RVA: 0x00274340 File Offset: 0x00272540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			num += this.baseProp_.CalculateSize(PbRolePropsNotify._repeated_baseProp_codec);
			num += this.addProp_.CalculateSize(PbRolePropsNotify._repeated_addProp_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010C1F RID: 68639 RVA: 0x002743A4 File Offset: 0x002725A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PbRolePropsNotify other)
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

		// Token: 0x06010C20 RID: 68640 RVA: 0x00274402 File Offset: 0x00272602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010C21 RID: 68641 RVA: 0x0027440C File Offset: 0x0027260C
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
					if (num != 64U)
					{
						if (num != 114U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.baseProp_.AddEntriesFrom(ref input, PbRolePropsNotify._repeated_baseProp_codec);
						}
					}
					else
					{
						this.RoleId = input.ReadInt32();
					}
				}
				else
				{
					this.addProp_.AddEntriesFrom(ref input, PbRolePropsNotify._repeated_addProp_codec);
				}
			}
		}

		// Token: 0x04006A6D RID: 27245
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A6E RID: 27246
		public const int RoleIdFieldNumber = 8;

		// Token: 0x04006A6F RID: 27247
		private int roleId_;

		// Token: 0x04006A70 RID: 27248
		public const int BasePropFieldNumber = 14;

		// Token: 0x04006A71 RID: 27249
		private static readonly FieldCodec<ArrayIntInt> _repeated_baseProp_codec = FieldCodec.ForMessage<ArrayIntInt>(114U, ArrayIntInt.Parser);

		// Token: 0x04006A72 RID: 27250
		private readonly RepeatedField<ArrayIntInt> baseProp_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x04006A73 RID: 27251
		public const int AddPropFieldNumber = 1;

		// Token: 0x04006A74 RID: 27252
		private static readonly FieldCodec<ArrayIntInt> _repeated_addProp_codec = FieldCodec.ForMessage<ArrayIntInt>(10U, ArrayIntInt.Parser);

		// Token: 0x04006A75 RID: 27253
		private readonly RepeatedField<ArrayIntInt> addProp_ = new RepeatedField<ArrayIntInt>();
	}
}
