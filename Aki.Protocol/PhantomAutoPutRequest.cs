using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000C0A RID: 3082
	[NetMessage(EMessageId.PhantomAutoPutRequest)]
	public sealed class PhantomAutoPutRequest : IMessage<PhantomAutoPutRequest>, IMessage, IEquatable<PhantomAutoPutRequest>, IDeepCloneable<PhantomAutoPutRequest>, IBufferMessage
	{
		// Token: 0x06010C0F RID: 68623 RVA: 0x002749AC File Offset: 0x00272BAC
		[NullableContext(1)]
		public static PhantomAutoPutRequest Create()
		{
			return new PhantomAutoPutRequest();
		}

		// Token: 0x1700374B RID: 14155
		// (get) Token: 0x06010C10 RID: 68624 RVA: 0x002749B3 File Offset: 0x00272BB3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700374C RID: 14156
		// (get) Token: 0x06010C11 RID: 68625 RVA: 0x002749B6 File Offset: 0x00272BB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return PhantomAutoPutRequest.Descriptor;
			}
		}

		// Token: 0x06010C12 RID: 68626 RVA: 0x002749BD File Offset: 0x00272BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAutoPutRequest()
		{
		}

		// Token: 0x06010C13 RID: 68627 RVA: 0x002749D0 File Offset: 0x00272BD0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAutoPutRequest(PhantomAutoPutRequest other) : this()
		{
			this.roleId_ = other.roleId_;
			this.phantomItemIncrId_ = other.phantomItemIncrId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06010C14 RID: 68628 RVA: 0x00274A06 File Offset: 0x00272C06
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public PhantomAutoPutRequest Clone()
		{
			return new PhantomAutoPutRequest(this);
		}

		// Token: 0x1700374D RID: 14157
		// (get) Token: 0x06010C15 RID: 68629 RVA: 0x00274A0E File Offset: 0x00272C0E
		// (set) Token: 0x06010C16 RID: 68630 RVA: 0x00274A16 File Offset: 0x00272C16
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

		// Token: 0x1700374E RID: 14158
		// (get) Token: 0x06010C17 RID: 68631 RVA: 0x00274A1F File Offset: 0x00272C1F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> PhantomItemIncrId
		{
			get
			{
				return this.phantomItemIncrId_;
			}
		}

		// Token: 0x06010C18 RID: 68632 RVA: 0x00274A27 File Offset: 0x00272C27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as PhantomAutoPutRequest);
		}

		// Token: 0x06010C19 RID: 68633 RVA: 0x00274A38 File Offset: 0x00272C38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(PhantomAutoPutRequest other)
		{
			return other != null && (other == this || (this.RoleId == other.RoleId && this.phantomItemIncrId_.Equals(other.phantomItemIncrId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06010C1A RID: 68634 RVA: 0x00274A88 File Offset: 0x00272C88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RoleId != 0)
			{
				num ^= this.RoleId.GetHashCode();
			}
			num ^= this.phantomItemIncrId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06010C1B RID: 68635 RVA: 0x00274AD5 File Offset: 0x00272CD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06010C1C RID: 68636 RVA: 0x00274AE2 File Offset: 0x00272CE2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06010C1D RID: 68637 RVA: 0x00274AEC File Offset: 0x00272CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantomItemIncrId_.WriteTo(ref output, PhantomAutoPutRequest._repeated_phantomItemIncrId_codec);
			if (this.RoleId != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(this.RoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06010C1E RID: 68638 RVA: 0x00274B3C File Offset: 0x00272D3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RoleId);
			}
			num += this.phantomItemIncrId_.CalculateSize(PhantomAutoPutRequest._repeated_phantomItemIncrId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06010C1F RID: 68639 RVA: 0x00274B90 File Offset: 0x00272D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(PhantomAutoPutRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RoleId != 0)
			{
				this.RoleId = other.RoleId;
			}
			this.phantomItemIncrId_.Add(other.phantomItemIncrId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06010C20 RID: 68640 RVA: 0x00274BDD File Offset: 0x00272DDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06010C21 RID: 68641 RVA: 0x00274BE8 File Offset: 0x00272DE8
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
				if (num != 64U && num != 66U)
				{
					if (num != 80U)
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
					this.phantomItemIncrId_.AddEntriesFrom(ref input, PhantomAutoPutRequest._repeated_phantomItemIncrId_codec);
				}
			}
		}

		// Token: 0x04006AD7 RID: 27351
		private UnknownFieldSet _unknownFields;

		// Token: 0x04006AD8 RID: 27352
		public const int RoleIdFieldNumber = 10;

		// Token: 0x04006AD9 RID: 27353
		private int roleId_;

		// Token: 0x04006ADA RID: 27354
		public const int PhantomItemIncrIdFieldNumber = 8;

		// Token: 0x04006ADB RID: 27355
		private static readonly FieldCodec<int> _repeated_phantomItemIncrId_codec = FieldCodec.ForInt32(66U);

		// Token: 0x04006ADC RID: 27356
		private readonly RepeatedField<int> phantomItemIncrId_ = new RepeatedField<int>();
	}
}
