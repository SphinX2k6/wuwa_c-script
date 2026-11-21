using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000BFE RID: 3070
	[NetMessage(EMessageId.PbRolePropsNotify)]
	public sealed class PbRolePropsNotify : IMessage<PbRolePropsNotify>, IMessage, IEquatable<PbRolePropsNotify>, IDeepCloneable<PbRolePropsNotify>, IBufferMessage
	{
		// Token: 0x06010B0E RID: 68366 RVA: 0x002723DF File Offset: 0x002705DF
		[NullableContext(1)]
		public static PbRolePropsNotify Create()
		{
			return new PbRolePropsNotify();
		}

		// Token: 0x17003711 RID: 14097
		// (get) Token: 0x06010B0F RID: 68367 RVA: 0x002723E6 File Offset: 0x002705E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17003712 RID: 14098
		// (get) Token: 0x06010B10 RID: 68368 RVA: 0x002723E9 File Offset: 0x002705E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PbRolePropsNotify.Descriptor;
			}
		}

		// Token: 0x06010B11 RID: 68369 RVA: 0x002723F0 File Offset: 0x002705F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRolePropsNotify()
		{
		}

		// Token: 0x06010B12 RID: 68370 RVA: 0x00272410 File Offset: 0x00270610
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRolePropsNotify(PbRolePropsNotify other) : this()
		{
			this.roleId_ = other.roleId_;
			this.baseProp_ = other.baseProp_.Clone();
			this.addProp_ = other.addProp_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010B13 RID: 68371 RVA: 0x00272462 File Offset: 0x00270662
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PbRolePropsNotify Clone()
		{
			return new PbRolePropsNotify(this);
		}

		// Token: 0x17003713 RID: 14099
		// (get) Token: 0x06010B14 RID: 68372 RVA: 0x0027246A File Offset: 0x0027066A
		// (set) Token: 0x06010B15 RID: 68373 RVA: 0x00272472 File Offset: 0x00270672
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

		// Token: 0x17003714 RID: 14100
		// (get) Token: 0x06010B16 RID: 68374 RVA: 0x0027247B File Offset: 0x0027067B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> BaseProp
		{
			get
			{
				return this.baseProp_;
			}
		}

		// Token: 0x17003715 RID: 14101
		// (get) Token: 0x06010B17 RID: 68375 RVA: 0x00272483 File Offset: 0x00270683
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<ArrayIntInt> AddProp
		{
			get
			{
				return this.addProp_;
			}
		}

		// Token: 0x06010B18 RID: 68376 RVA: 0x0027248B File Offset: 0x0027068B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PbRolePropsNotify);
		}

		// Token: 0x06010B19 RID: 68377 RVA: 0x0027249C File Offset: 0x0027069C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PbRolePropsNotify other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.baseProp_.Equals(other.baseProp_) && this.addProp_.Equals(other.addProp_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010B1A RID: 68378 RVA: 0x00272500 File Offset: 0x00270700
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

		// Token: 0x06010B1B RID: 68379 RVA: 0x0027255B File Offset: 0x0027075B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010B1C RID: 68380 RVA: 0x00272568 File Offset: 0x00270768
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010B1D RID: 68381 RVA: 0x00272574 File Offset: 0x00270774
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.addProp_.WriteTo(ref output, PbRolePropsNotify._repeated_addProp_codec);
			this.baseProp_.WriteTo(ref output, PbRolePropsNotify._repeated_baseProp_codec);
			if (this.RoleId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010B1E RID: 68382 RVA: 0x002725D4 File Offset: 0x002707D4
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

		// Token: 0x06010B1F RID: 68383 RVA: 0x00272638 File Offset: 0x00270838
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

		// Token: 0x06010B20 RID: 68384 RVA: 0x00272696 File Offset: 0x00270896
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010B21 RID: 68385 RVA: 0x002726A0 File Offset: 0x002708A0
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
					if (num != 82U)
					{
						if (num != 112U)
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
						this.baseProp_.AddEntriesFrom(ref input, PbRolePropsNotify._repeated_baseProp_codec);
					}
				}
				else
				{
					this.addProp_.AddEntriesFrom(ref input, PbRolePropsNotify._repeated_addProp_codec);
				}
			}
		}

		// Token: 0x04006A81 RID: 27265
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006A82 RID: 27266
		public const int RoleIdFieldNumber = 14;

		// Token: 0x04006A83 RID: 27267
		private int roleId_;

		// Token: 0x04006A84 RID: 27268
		public const int BasePropFieldNumber = 10;

		// Token: 0x04006A85 RID: 27269
		private static readonly FieldCodec<ArrayIntInt> _repeated_baseProp_codec = FieldCodec.ForMessage<ArrayIntInt>(82U, ArrayIntInt.Parser);

		// Token: 0x04006A86 RID: 27270
		private readonly RepeatedField<ArrayIntInt> baseProp_ = new RepeatedField<ArrayIntInt>();

		// Token: 0x04006A87 RID: 27271
		public const int AddPropFieldNumber = 1;

		// Token: 0x04006A88 RID: 27272
		private static readonly FieldCodec<ArrayIntInt> _repeated_addProp_codec = FieldCodec.ForMessage<ArrayIntInt>(10U, ArrayIntInt.Parser);

		// Token: 0x04006A89 RID: 27273
		private readonly RepeatedField<ArrayIntInt> addProp_ = new RepeatedField<ArrayIntInt>();
	}
}
