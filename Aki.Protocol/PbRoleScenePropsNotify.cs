using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C00 RID: 3072
	[NetMessage(EMessageId.PbRoleScenePropsNotify)]
	public sealed class PbRoleScenePropsNotify : IMessage<PbRoleScenePropsNotify>, IMessage, IEquatable<PbRoleScenePropsNotify>, IDeepCloneable<PbRoleScenePropsNotify>, IBufferMessage
	{
		// Token: 0x06010B37 RID: 68407 RVA: 0x002729D4 File Offset: 0x00270BD4
		[NullableContext(1)]
		public static PbRoleScenePropsNotify Create()
		{
			return new PbRoleScenePropsNotify();
		}

		// Token: 0x1700371A RID: 14106
		// (get) Token: 0x06010B38 RID: 68408 RVA: 0x002729DB File Offset: 0x00270BDB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700371B RID: 14107
		// (get) Token: 0x06010B39 RID: 68409 RVA: 0x002729DE File Offset: 0x00270BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbRoleScenePropsNotify.Descriptor;
			}
		}

		// Token: 0x06010B3A RID: 68410 RVA: 0x002729E5 File Offset: 0x00270BE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleScenePropsNotify()
		{
		}

		// Token: 0x06010B3B RID: 68411 RVA: 0x00272A04 File Offset: 0x00270C04
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleScenePropsNotify(PbRoleScenePropsNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.baseProp_ = other.baseProp_.Clone();
			this.addProp_ = other.addProp_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010B3C RID: 68412 RVA: 0x00272A56 File Offset: 0x00270C56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRoleScenePropsNotify Clone()
		{
			return new PbRoleScenePropsNotify(this);
		}

		// Token: 0x1700371C RID: 14108
		// (get) Token: 0x06010B3D RID: 68413 RVA: 0x00272A5E File Offset: 0x00270C5E
		// (set) Token: 0x06010B3E RID: 68414 RVA: 0x00272A66 File Offset: 0x00270C66
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

		// Token: 0x1700371D RID: 14109
		// (get) Token: 0x06010B3F RID: 68415 RVA: 0x00272A6F File Offset: 0x00270C6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> BaseProp
		{
			get
			{
				return this.baseProp_;
			}
		}

		// Token: 0x1700371E RID: 14110
		// (get) Token: 0x06010B40 RID: 68416 RVA: 0x00272A77 File Offset: 0x00270C77
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> AddProp
		{
			get
			{
				return this.addProp_;
			}
		}

		// Token: 0x06010B41 RID: 68417 RVA: 0x00272A7F File Offset: 0x00270C7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbRoleScenePropsNotify);
		}

		// Token: 0x06010B42 RID: 68418 RVA: 0x00272A90 File Offset: 0x00270C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbRoleScenePropsNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.baseProp_.Equals(other.baseProp_) && this.addProp_.Equals(other.addProp_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010B43 RID: 68419 RVA: 0x00272AF4 File Offset: 0x00270CF4
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

		// Token: 0x06010B44 RID: 68420 RVA: 0x00272B4F File Offset: 0x00270D4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010B45 RID: 68421 RVA: 0x00272B5C File Offset: 0x00270D5C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010B46 RID: 68422 RVA: 0x00272B68 File Offset: 0x00270D68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.baseProp_.WriteTo(ref output, PbRoleScenePropsNotify._repeated_baseProp_codec);
			this.addProp_.WriteTo(ref output, PbRoleScenePropsNotify._repeated_addProp_codec);
			if (this.RoleId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010B47 RID: 68423 RVA: 0x00272BC8 File Offset: 0x00270DC8
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

		// Token: 0x06010B48 RID: 68424 RVA: 0x00272C2C File Offset: 0x00270E2C
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

		// Token: 0x06010B49 RID: 68425 RVA: 0x00272C8A File Offset: 0x00270E8A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010B4A RID: 68426 RVA: 0x00272C94 File Offset: 0x00270E94
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
				if (num != 18U)
				{
					if (num != 34U)
					{
						if (num != 56U)
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
						this.addProp_.AddEntriesFrom(ref input, PbRoleScenePropsNotify._repeated_addProp_codec);
					}
				}
				else
				{
					this.baseProp_.AddEntriesFrom(ref input, PbRoleScenePropsNotify._repeated_baseProp_codec);
				}
			}
		}

		// Token: 0x04006A8F RID: 27279
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A90 RID: 27280
		public const int RoleIdFieldNumber = 7;

		// Token: 0x04006A91 RID: 27281
		private int roleId_;

		// Token: 0x04006A92 RID: 27282
		public const int BasePropFieldNumber = 2;

		// Token: 0x04006A93 RID: 27283
		private static readonly FieldCodec<ArrayIntInt> _repeated_baseProp_codec = FieldCodec.ForMessage<ArrayIntInt>(18U, ArrayIntInt.Parser);

		// Token: 0x04006A94 RID: 27284
		private readonly RepeatedField<ArrayIntInt> baseProp_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x04006A95 RID: 27285
		public const int AddPropFieldNumber = 4;

		// Token: 0x04006A96 RID: 27286
		private static readonly FieldCodec<ArrayIntInt> _repeated_addProp_codec = FieldCodec.ForMessage<ArrayIntInt>(34U, ArrayIntInt.Parser);

		// Token: 0x04006A97 RID: 27287
		private readonly RepeatedField<ArrayIntInt> addProp_ = new RepeatedField<ArrayIntInt>();
	}
}
